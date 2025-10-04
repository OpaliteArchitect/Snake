namespace Snake.UI
{
    public partial class MainMenu : UserControl
    {
        Form form;
        Board_UC board;
        public MainMenu()
        {
            InitializeComponent();
            board = new();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            form = FindForm();
        }

        private void play_Button_Click(object sender, EventArgs e)
        {
            form.Controls.Clear();
            form.Controls.Add(board);
            board.Dock = DockStyle.Fill;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
