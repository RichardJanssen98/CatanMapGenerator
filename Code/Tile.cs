using System;
using System.Collections.Generic;
using System.Text;

namespace CatanMapGenerator.Code
{
    internal class Tile
    {
        public ResourceType ResourceType { get; set; }
        public int NumberToken { get; set; }
        public Point Position { get; set; }

        public Tile(ResourceType resourceType, int numberToken, Point position)
        {
            this.ResourceType = resourceType;
            this.NumberToken = numberToken;
            this.Position = position;
        }

        public void Draw(Graphics g, int size)
        {
            Point[] hexagonPoints = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                //hexagon angles with the point towards the top: 60° increments starting at 30° (top point)
                double angle = Math.PI / 180 * (60 * i + 30);
                int x = Position.X + (int)(size * Math.Cos(angle));
                int y = Position.Y + (int)(size * Math.Sin(angle));
                hexagonPoints[i] = new Point(x, y);
            }

            Brush brush = GetBrushForResource(ResourceType);
            g.FillPolygon(brush, hexagonPoints);

            //Draw the number token. Desert is -1 and shouldn't have a number token.
            if (NumberToken != -1)
            {
                Font font = new Font("Arial", 12, FontStyle.Bold);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                Brush numBrush = Brushes.Black;

                if (NumberToken == 6 || NumberToken == 8)
                {
                    numBrush = Brushes.Red;
                }
                g.DrawString(NumberToken.ToString(), font, numBrush, Position, format);
            }
        }

        private Brush GetBrushForResource(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Desert: return Brushes.SandyBrown;
                case ResourceType.Wood: return Brushes.DarkGreen;
                case ResourceType.Brick: return Brushes.Firebrick;
                case ResourceType.Wheat: return Brushes.Gold;
                case ResourceType.Ore: return Brushes.Gray;
                case ResourceType.Wool: return Brushes.LightGreen;
                default: return Brushes.LightGray;
            }
        }
    }
}
