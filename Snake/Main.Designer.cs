namespace Snake
{
    partial class Main
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
            mainMenu1 = new Snake.UI.MainMenu();
            SuspendLayout();
            // 
            // mainMenu1
            // 
            mainMenu1.Dock = DockStyle.Fill;
            mainMenu1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainMenu1.Location = new Point(0, 0);
            mainMenu1.Name = "mainMenu1";
            mainMenu1.Size = new Size(686, 480);
            mainMenu1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(686, 480);
            Controls.Add(mainMenu1);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.SaddleBrown;
            Name = "Main";
            Text = "Snake";
            ResumeLayout(false);
        }

        #endregion

        private UI.MainMenu mainMenu1;
    }
}
