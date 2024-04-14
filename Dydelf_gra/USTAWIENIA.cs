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
            X.Text = "3";
            Y.Text = "3";
            dydelfy.Text = "1";
            krokodyle.Text = "1";
            czas.Text = "30";
            if (Int32.Parse(X.Text) <= 10 && Int32.Parse(Y.Text) <= 10 && Int32.Parse(dydelfy.Text) + Int32.Parse(krokodyle.Text) <= Int32.Parse(X.Text) * Int32.Parse(Y.Text) && Int32.Parse(czas.Text) > 0)
            {
                parent.x = Int32.Parse(X.Text);
                parent.y = Int32.Parse(Y.Text);
                parent.dydelfy = Int32.Parse(dydelfy.Text);
                parent.krokodyle = Int32.Parse(krokodyle.Text);
                parent.czas = Int32.Parse(czas.Text);
                Close();
            }
            else
            {
                label7.Text = "Podano niepoprawne dane";
            }
        }
    }
}
