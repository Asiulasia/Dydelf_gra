namespace Dydelf_gra
{
    public partial class Form1 : Form
    {
        public int x = 3;
        public int y = 3;
        public int dydelfy = 1;
        public int krokodyle = 1;
        public int czas = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            START nowe_okno = new START(this);
            nowe_okno.Show();
            nowe_okno.GameBoard(); 
        }

        private void ustawienia_Click(object sender, EventArgs e)
        {
            USTAWIENIA nowe_okno = new USTAWIENIA(this);
            nowe_okno.ShowDialog();
        }

        private void koniec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
