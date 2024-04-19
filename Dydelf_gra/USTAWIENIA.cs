using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dydelf_gra
{
    public partial class USTAWIENIA : Form
    {
        Form1 parent;
        public USTAWIENIA(Form1 okno)
        {
            InitializeComponent();
            parent = okno;
        }

        private void X_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void dydelfy_TextChanged(object sender, EventArgs e)
        {

        }

        private void krokodyle_TextChanged(object sender, EventArgs e)
        {

        }

        private void czas_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Domyślne wartości dla pól
            int domyslneX = 3;
            int domyslneY = 3;
            int domyslneDydelfy = 1;
            int domyslneKrokodyle = 1;
            int domyslnyCzas = 30;

            // Sprawdź, czy użytkownik wprowadził dane; jeśli nie, użyj domyślnych wartości
            int wprowadzoneX = string.IsNullOrWhiteSpace(X.Text) ? domyslneX : int.Parse(X.Text);
            int wprowadzoneY = string.IsNullOrWhiteSpace(Y.Text) ? domyslneY : int.Parse(Y.Text);
            int wprowadzoneDydelfy = string.IsNullOrWhiteSpace(dydelfy.Text) ? domyslneDydelfy : int.Parse(dydelfy.Text);
            int wprowadzoneKrokodyle = string.IsNullOrWhiteSpace(krokodyle.Text) ? domyslneKrokodyle : int.Parse(krokodyle.Text);
            int wprowadzonyCzas = string.IsNullOrWhiteSpace(czas.Text) ? domyslnyCzas : int.Parse(czas.Text);

            // Sprawdź poprawność wprowadzonych danych
            if (wprowadzoneX <= 10 && wprowadzoneY <= 10 && wprowadzoneDydelfy + wprowadzoneKrokodyle <= wprowadzoneX * wprowadzoneY && wprowadzonyCzas > 0)
            {
                // Przypisz wartości do pól formularza nadrzędnego
                parent.x = wprowadzoneX;
                parent.y = wprowadzoneY;
                parent.dydelfy = wprowadzoneDydelfy;
                parent.krokodyle = wprowadzoneKrokodyle;
                parent.czas = wprowadzonyCzas;

                Close();
            }
            else
            {
                label7.Text = "Podano niepoprawne dane";
            }
        }
    }
}
