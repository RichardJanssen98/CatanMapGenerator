namespace CatanMapGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Generate = new Button();
            checkBox_DesertCentered = new CheckBox();
            textBox_WoodAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_WheatAmount = new TextBox();
            label3 = new Label();
            textBox_WoolAmount = new TextBox();
            label4 = new Label();
            textBox_BrickAmount = new TextBox();
            label5 = new Label();
            textBox_OreAmount = new TextBox();
            SuspendLayout();
            // 
            // btn_Generate
            // 
            btn_Generate.Location = new Point(12, 415);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(75, 23);
            btn_Generate.TabIndex = 0;
            btn_Generate.Text = "Regenerate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += Regenerate;
            // 
            // checkBox_DesertCentered
            // 
            checkBox_DesertCentered.AutoSize = true;
            checkBox_DesertCentered.Location = new Point(12, 390);
            checkBox_DesertCentered.Name = "checkBox_DesertCentered";
            checkBox_DesertCentered.Size = new Size(110, 19);
            checkBox_DesertCentered.TabIndex = 2;
            checkBox_DesertCentered.Text = "Desert Centered";
            checkBox_DesertCentered.UseVisualStyleBackColor = true;
            // 
            // textBox_WoodAmount
            // 
            textBox_WoodAmount.Location = new Point(12, 25);
            textBox_WoodAmount.Name = "textBox_WoodAmount";
            textBox_WoodAmount.Size = new Size(100, 23);
            textBox_WoodAmount.TabIndex = 3;
            textBox_WoodAmount.Text = "4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Wood Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Wheat Amount";
            // 
            // textBox_WheatAmount
            // 
            textBox_WheatAmount.Location = new Point(12, 69);
            textBox_WheatAmount.Name = "textBox_WheatAmount";
            textBox_WheatAmount.Size = new Size(100, 23);
            textBox_WheatAmount.TabIndex = 5;
            textBox_WheatAmount.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 8;
            label3.Text = "Wool Amount";
            // 
            // textBox_WoolAmount
            // 
            textBox_WoolAmount.Location = new Point(12, 113);
            textBox_WoolAmount.Name = "textBox_WoolAmount";
            textBox_WoolAmount.Size = new Size(100, 23);
            textBox_WoolAmount.TabIndex = 7;
            textBox_WoolAmount.Text = "4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 10;
            label4.Text = "Brick Amount";
            // 
            // textBox_BrickAmount
            // 
            textBox_BrickAmount.Location = new Point(12, 159);
            textBox_BrickAmount.Name = "textBox_BrickAmount";
            textBox_BrickAmount.Size = new Size(100, 23);
            textBox_BrickAmount.TabIndex = 9;
            textBox_BrickAmount.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 12;
            label5.Text = "Ore Amount";
            // 
            // textBox_OreAmount
            // 
            textBox_OreAmount.Location = new Point(12, 203);
            textBox_OreAmount.Name = "textBox_OreAmount";
            textBox_OreAmount.Size = new Size(100, 23);
            textBox_OreAmount.TabIndex = 11;
            textBox_OreAmount.Text = "3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox_OreAmount);
            Controls.Add(label4);
            Controls.Add(textBox_BrickAmount);
            Controls.Add(label3);
            Controls.Add(textBox_WoolAmount);
            Controls.Add(label2);
            Controls.Add(textBox_WheatAmount);
            Controls.Add(label1);
            Controls.Add(textBox_WoodAmount);
            Controls.Add(checkBox_DesertCentered);
            Controls.Add(btn_Generate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Generate;
        private CheckBox checkBox_DesertCentered;
        private TextBox textBox_WoodAmount;
        private Label label1;
        private Label label2;
        private TextBox textBox_WheatAmount;
        private Label label3;
        private TextBox textBox_WoolAmount;
        private Label label4;
        private TextBox textBox_BrickAmount;
        private Label label5;
        private TextBox textBox_OreAmount;
    }
}
