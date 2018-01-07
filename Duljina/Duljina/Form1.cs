using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duljina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prva_duljina;
            double druga_duljina;
            double rezultat;
            string veličina;
              if(double.TryParse(IznosDuljine_1.Text,out prva_duljina) && double.TryParse(IznosDuljine_2.Text,out druga_duljina))
            {
                if (ListaDuljina_1.SelectedIndex == ListaDuljine_2.SelectedIndex)
                {
                    if (Operacije.SelectedIndex == 0)
                    {
                        rezultat = prva_duljina + druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina = ListaDuljina_1.Text;

                    }
                    else
                    {
                        rezultat = prva_duljina - druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina = ListaDuljina_1.Text;
                    }

                    switch (veličina)
                    {
                        case "m":
                            Velicina.Text = veličina;
                            break;
                        case "km":
                            Velicina.Text = veličina;
                            break;
                        case "mm":
                            Velicina.Text = veličina;
                            break;
                        case "in":
                            Velicina.Text = veličina;
                            break;
                        case "feet":
                            Velicina.Text = veličina;
                            break;
                        case "yard":
                            Velicina.Text = veličina;
                            break;
                        case "mile":
                            Velicina.Text = veličina;
                            break;
                        case "cm":
                            Velicina.Text = veličina;
                            break;



                    }

                }
                else
                {
                    MessageBox.Show("Morate izabrati istu veličinu duljine");
                }
            }
            else
            {
                MessageBox.Show("Morate unjeti duljinu");
            }
           

            
            
        }
    }
}
