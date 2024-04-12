namespace Dydelf_gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            START nowe_okno = new START(this);
            nowe_okno.ShowDialog();
        }

        private void ustawienia_Click(object sender, EventArgs e)
        {

        }

        private void koniec_Click(object sender, EventArgs e)
        {

        }
    }
}
