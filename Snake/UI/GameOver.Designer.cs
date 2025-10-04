namespace Snake.UI
{
    partial class GameOver
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            replay_Button = new Button();
            finalScore_Label = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(replay_Button, 0, 2);
            tableLayoutPanel1.Controls.Add(finalScore_Label, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(600, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // replay_Button
            // 
            replay_Button.BackColor = Color.PaleVioletRed;
            replay_Button.Dock = DockStyle.Fill;
            replay_Button.FlatAppearance.BorderSize = 0;
            replay_Button.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            replay_Button.FlatStyle = FlatStyle.Flat;
            replay_Button.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replay_Button.Location = new Point(3, 323);
            replay_Button.Name = "replay_Button";
            replay_Button.Size = new Size(594, 74);
            replay_Button.TabIndex = 2;
            replay_Button.Text = "Back To Menu";
            replay_Button.UseVisualStyleBackColor = false;
            replay_Button.Click += replay_Button_Click;
            // 
            // finalScore_Label
            // 
            finalScore_Label.AutoSize = true;
            finalScore_Label.Dock = DockStyle.Fill;
            finalScore_Label.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalScore_Label.Location = new Point(3, 240);
            finalScore_Label.Name = "finalScore_Label";
            finalScore_Label.Size = new Size(594, 80);
            finalScore_Label.TabIndex = 1;
            finalScore_Label.Text = "Final Score: 0";
            finalScore_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(594, 240);
            label1.TabIndex = 0;
            label1.Text = "Game Over!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "GameOver";
            Size = new Size(600, 400);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label finalScore_Label;
        private Button replay_Button;
    }
}
