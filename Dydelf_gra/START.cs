using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dydelf_gra
{
    public partial class START : Form
    {
        Form1 parent;
        private int rows = 3; // Domyślna liczba wierszy
        private int columns = 3; // Domyślna liczba kolumn
        public START(Form1 okno)
        {
            InitializeComponent();
            parent = okno;
        }

        int x = 0;
        int y = 0;
        private void GameBoard()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    //pictureBox.Dock = DockStyle.Fill;
                    //pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pictureBox.BackColor = Color.White; // Domyślne tło

                    //// Dodaj obsługę zdarzenia kliknięcia w PictureBox
                    //pictureBox.Click += PictureBox_Click;
                    pictureBox.Location = new Point(x, y); // x i y to współrzędne punktu, gdzie ma być umieszczony PictureBox
                    x = x + 20;
                    // Ustaw rozmiar
                    pictureBox.Size = new Size(20, 20);
                    pictureBox.Image = Image.FromFile("C:\\Users\\Tomasz\\Desktop\\krzak.jpg");
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(pictureBox);
                }
                y = y + 20;
                x = 0;
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            // Obsługa kliknięcia w PictureBox
            MessageBox.Show("Kliknięto na PictureBox!");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GameBoard();
        }
    }
}
