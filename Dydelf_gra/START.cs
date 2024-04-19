using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Dydelf_gra
{
    public partial class START : Form
    {
        Form1 parent;
        private int czasOdmierzania;
        public START(Form1 okno)
        {
            InitializeComponent();
            parent = okno;
            czasOdmierzania = parent.czas;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            timer.Start();

        }

        private int znalezione_dydelfy;
        private bool koniec_gry;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        int x = 0;
        int y = 100;
        private PictureBox[,] pictureBoxes; // Tablica przechowująca PictureBox
        List<Tuple<int, int>> listaDydelfow = new List<Tuple<int, int>>();
        List<Tuple<int, int>> listaKrokodylow = new List<Tuple<int, int>>();
        public void GameBoard()
        {
            pictureBoxes = new PictureBox[parent.y, parent.x]; // Inicjalizacja tablicy PictureBox
            for (int i = 0; i < parent.y; i++)
            {
                for (int j = 0; j < parent.x; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(x, y); // x i y to współrzędne punktu, gdzie ma być umieszczony PictureBox
                    x = x + 170;
                    // Ustaw rozmiar
                    pictureBox.Size = new Size(170, 170);
                    pictureBox.Image = Resource1.krzak;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(pictureBox);
                    // Dodaj PictureBox do tablicy
                    pictureBoxes[i, j] = pictureBox;
                    // Dodaj obsługę zdarzenia kliknięcia w PictureBox
                    pictureBox.Click += PictureBox_Click;
                }
                y = y + 170;
                x = 0;
            }

            int totalFields = parent.y * parent.x;

            // Pętla wykonująca się tyle razy, ile wynosi parent.dydelfy
            for (int i = 0; i < parent.dydelfy; i++)
            {
                Random random = new Random();
                int randomRow = random.Next(1, parent.y);
                int randomColumn = random.Next(1, parent.x);

                // Dodajemy parę (indeks wiersza, indeks kolumny) do listy
                listaDydelfow.Add(new Tuple<int, int>(randomRow, randomColumn));
                //MessageBox.Show($"Clicked PictureBox at row {randomRow}, column {randomColumn}");
            }


            for (int i = 0; i < parent.krokodyle; i++)
            {
                Tuple<int, int> krokodylTuple;
                do
                {
                    Random random = new Random();
                    int randomRow = random.Next(1, parent.y);
                    int randomColumn = random.Next(1, parent.x);
                    krokodylTuple = new Tuple<int, int>(randomRow, randomColumn);
                } while (listaDydelfow.Contains(krokodylTuple));

                // Dodajemy parę (indeks wiersza, indeks kolumny) do listy
                listaKrokodylow.Add(krokodylTuple);
            }


        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Znajdź indeks klikniętego PictureBox w tablicy pictureBoxes
            PictureBox clickedPictureBox = (PictureBox)sender;
            int clickedRowIndex = -1;
            int clickedColumnIndex = -1;
            bool isClickedDydelf = false;
            bool isClickedKrokodyl = false;
            // Przeszukaj tablicę pictureBoxes, aby znaleźć indeks klikniętego PictureBox
            for (int i = 0; i < parent.y; i++)
            {
                for (int j = 0; j < parent.x; j++)
                {
                    if (pictureBoxes[i, j] == clickedPictureBox)
                    {
                        clickedRowIndex = i;
                        clickedColumnIndex = j;
                        var clickedBox = Tuple.Create(j, i);
                        isClickedDydelf = listaDydelfow.Contains(clickedBox);
                        isClickedKrokodyl = listaKrokodylow.Contains(clickedBox);
                        break;
                    }
                }
                if (clickedRowIndex != -1)
                    break;
            }

            if (isClickedDydelf)
            {
                clickedPictureBox.Image = Resource1.dydelf;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                znalezione_dydelfy++;
                if (znalezione_dydelfy == parent.dydelfy && !koniec_gry)
                {
                    koniec_gry = true;
                    label1.Text = "WYGRAŁEŚ!!!";
                    timer.Stop();
                }
            }
            else if (isClickedKrokodyl)
            {
                clickedPictureBox.Image = Resource1.krokodyl;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!koniec_gry)
                {
                    koniec_gry = true;
                    label1.Text = "PRZEGRAŁEŚ :(";
                    timer.Stop();
                }
            }
            else
            {
                clickedPictureBox.Image = Resource1.nic;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czasOdmierzania--;

            label2.Text = czasOdmierzania.ToString() + " s";

            if (czasOdmierzania <= 0)
            {
                timer.Stop();

                label1.Text = "PRZEGRAŁEŚ :( czas się skończył";
                koniec_gry = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
