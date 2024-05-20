using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa_de_Sala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)

        { }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginEmailEntryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginEntrarBtn_Click(object sender, EventArgs e)
        {
            //String emailEntry = LoginEmailEntryBox.Text;
            //emailEntry.Replace("@hotmail.com", "");
            //BodyTitle.Text = $"Bem Vindo {emailEntry}";
            int n1= Convert.ToInt32(LoginEmailEntryBox.Text);
            int n2 = Convert.ToInt32(LoginPasswordEntryBox.Text);
            int soma = n1 + n2;
            BodyTitle.Text = Convert.ToString(soma);
        }

        private void LoginPasswordEntryBox_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordEntryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginHeaderLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
