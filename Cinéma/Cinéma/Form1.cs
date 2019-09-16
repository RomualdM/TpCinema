using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinéma
{
    public partial class Form1 : Form
    {
        List<SalleCinema> Salles = new List<SalleCinema>();
        public Form1()
        {
            InitializeComponent();
            SalleCinema Salle1 = new SalleCinema("1 guy 1 jar", 150, 111.50);
            SalleCinema Salle2 = new SalleCinema("Le rapide et le furieux", 150, 11.50);
            SalleCinema Salle3 = new SalleCinema("e", 150, 11.50);
            Salles.Add(Salle1);
            Salles.Add(Salle2);
            Salles.Add(Salle3);
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "1")
            {
                label1.Text = Salles[0].toString();
            }
            if (comboBox1.SelectedItem == "2")
            {
                label1.Text = Salles[1].toString();
            }
            if (comboBox1.SelectedItem == "3")
            {
                label1.Text = Salles[2].toString();
            }
        }
    }
}
