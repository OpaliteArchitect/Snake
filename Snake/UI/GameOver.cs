namespace Snake.UI
{
    public partial class GameOver : UserControl
    {
        readonly Board_UC board_UC;
        public GameOver(int score, Board_UC board_UC)
        {
            this.board_UC = board_UC;
            InitializeComponent();
            finalScore_Label.Text = $"Final score: {score}";
        }

        private void replay_Button_Click(object sender, EventArgs e)
        {
            Form form = FindForm();
            form.Controls.Clear();

            MainMenu mainMenu = new();
            form.Controls.Add(mainMenu);
            mainMenu.Dock = DockStyle.Fill;
        }
    }
}
