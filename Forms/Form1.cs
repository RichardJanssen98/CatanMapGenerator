using CatanMapGenerator.Code;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace CatanMapGenerator
{
    public partial class Form1 : Form
    {
        private List<Tile> boardTiles = new List<Tile>();
        private int tileSize = 40;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            InitializeBoard();
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            foreach (var tile in boardTiles)
            {
                tile.Draw(g, tileSize);
            }
        }

        public void Regenerate(object sender, System.EventArgs e)
        {
            InitializeBoard();
            this.Invalidate();
        }

        private void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private List<int> GenerateNumberTokens()
        {
            List<int> numbers = new List<int>
            {
                2, 3, 3, 4, 4, 5, 5, 6, 6, 8, 8, 9, 9, 10, 10, 11, 11, 12
            };
            Shuffle(numbers);
            return numbers;
        }

        private bool IsAdjacentToSixOrEight(List<Tile> placedTiles, Point newPosition, int newNumber, int tileSize)
        {
            if (newNumber != 6 && newNumber != 8)
                return false;

            foreach (var tile in placedTiles)
            {
                if (tile.NumberToken != 6 && tile.NumberToken != 8)
                    continue;

                // Calculate distance between the new position and existing tile
                double distance = Math.Sqrt(
                    Math.Pow(newPosition.X - tile.Position.X, 2) +
                    Math.Pow(newPosition.Y - tile.Position.Y, 2)
                );

                // (1.8 accounts for small gaps and ensures adjacency is detected)
                if (distance < 1.8 * tileSize)
                    return true;
            }
            return false;
        }



        private List<ResourceType> GenerateResourceTypes(bool isDesertCentered)
        {
            List<ResourceType> resources = new List<ResourceType>
            {
                ResourceType.Wood, ResourceType.Wood, ResourceType.Wood, ResourceType.Wood,
                ResourceType.Brick, ResourceType.Brick, ResourceType.Brick,
                ResourceType.Wheat, ResourceType.Wheat, ResourceType.Wheat, ResourceType.Wheat,
                ResourceType.Ore, ResourceType.Ore, ResourceType.Ore,
                ResourceType.Wool, ResourceType.Wool, ResourceType.Wool, ResourceType.Wool,
                ResourceType.Desert
            };
            Shuffle(resources);

            if (isDesertCentered)
            {
                int desertIndex = 0;
                int centralIndex = 0;

                //Randomise if it should round down or up.
                Random rnd = new Random();
                int randomNr = rnd.Next(1, 3);

                float middleIndex = resources.Count / 2;

                if (randomNr == 1)
                {
                    centralIndex = (int)Math.Ceiling(middleIndex);
                }
                else
                {
                    centralIndex = (int)Math.Floor(middleIndex);
                }

                for (int i = 0; i < resources.Count; i++)
                {
                    if (resources[i] == ResourceType.Desert)
                    {
                        desertIndex = i;
                        break;
                    }
                }

                ResourceType currentCenteredResource = resources[centralIndex];

                resources[desertIndex] = currentCenteredResource;
                resources[centralIndex] = ResourceType.Desert;
            }

            return resources;
        }

        private Point GetHexagonPosition(int row, int col, int tileSize)
        {
            //Tile size doesn't change by design and this causes them to be perfectly aligned.
            float horizontalSpacing = tileSize * 1.7f;
            float verticalSpacing = tileSize * 1.47f;

            int startX = 300;
            int startY = 100;

            float x = startX + col * horizontalSpacing;
            float y = startY + row * verticalSpacing;

            // Offset every odd row (1st, 3rd, etc.) by half the horizontal spacing
            if (row % 2 == 1)
            {
                x += horizontalSpacing / 2;
            }

            return new Point((int)x, (int)y);
        }

        private void InitializeBoard()
        {
            bool isDesertCentered = checkBox_DesertCentered.Checked;

            boardTiles.Clear();
            List<ResourceType> resourceTypes = GenerateResourceTypes(isDesertCentered);
            List<int> numberTokens = GenerateNumberTokens();
            int resourceIndex = 0;
            int numIndex = 0;

            int[] hexagonsPerRow = { 3, 4, 5, 4, 3 };
            List<Tile> placedTiles = new List<Tile>();
            bool validBoard = false;
            int reshuffleAttempts = 0;
            int maxAttempts = 100; // Prevent infinite loops

            while (!validBoard && reshuffleAttempts < maxAttempts)
            {
                validBoard = true;
                placedTiles.Clear();
                boardTiles.Clear();
                numberTokens = GenerateNumberTokens(); // Reshuffle numbers
                numIndex = 0;
                resourceIndex = 0;

                for (int row = 0; row < 5; row++)
                {
                    int hexagonsInRow = hexagonsPerRow[row];
                    int startCol = (5 - hexagonsInRow) / 2;

                    for (int col = 0; col < hexagonsInRow; col++)
                    {
                        Point position = GetHexagonPosition(row, col + startCol, tileSize);
                        ResourceType resource = resourceTypes[resourceIndex];
                        int number = (resource == ResourceType.Desert) ? -1 : numberTokens[numIndex];

                        // Check adjacency for 6s and 8s
                        if ((number == 6 || number == 8) && IsAdjacentToSixOrEight(placedTiles, position, number, tileSize))
                        {
                            validBoard = false; // Mark as invalid and reshuffle
                            break;
                        }

                        boardTiles.Add(new Tile(resource, number, position));
                        placedTiles.Add(new Tile(resource, number, position));

                        if (resource != ResourceType.Desert) numIndex++;
                        resourceIndex++;
                    }
                    if (!validBoard) break;
                }
                reshuffleAttempts++;
            }

            if (reshuffleAttempts >= maxAttempts)
            {
                Debug.WriteLine("Warning: Could not generate a valid board without adjacent 6s or 8s.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}