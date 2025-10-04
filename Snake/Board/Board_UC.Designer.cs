using CustomControls;

namespace Snake.UI
{
    partial class Board_UC
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
            board_Panel = new DoubleBufferedPanel();
            score_Label = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(board_Panel, 1, 0);
            tableLayoutPanel1.Controls.Add(score_Label, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(487, 466);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // board_Panel
            // 
            board_Panel.Dock = DockStyle.Fill;
            board_Panel.Location = new Point(100, 3);
            board_Panel.Name = "board_Panel";
            board_Panel.Size = new Size(286, 413);
            board_Panel.TabIndex = 0;
            board_Panel.Paint += board_Panel_Paint;
            // 
            // score_Label
            // 
            score_Label.AutoSize = true;
            score_Label.Dock = DockStyle.Fill;
            score_Label.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            score_Label.Location = new Point(100, 419);
            score_Label.Name = "score_Label";
            score_Label.Size = new Size(286, 47);
            score_Label.TabIndex = 1;
            score_Label.Text = "Score: 0";
            score_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Board_UC
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Board_UC";
            Size = new Size(487, 466);
            Load += Board_UC_Load;
            KeyDown += Board_UC_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DoubleBufferedPanel board_Panel;
        private Label score_Label;
    }
}
