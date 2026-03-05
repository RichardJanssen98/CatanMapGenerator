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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
