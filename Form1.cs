using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            string szoveg = textBoxUjhobbi.Text;
            if (String.IsNullOrWhiteSpace(szoveg))
            {
                MessageBox.Show("Üres a beviteli mező!");
                return;
            }
            if (listBoxHobbiLista.Items.Contains(szoveg))
            {
                MessageBox.Show("Ez már szerepel!");
                return;
            }
                
                listBoxHobbiLista.Items.Add(szoveg.TrimStart().TrimEnd());
                textBoxUjhobbi.Text = "";
                textBoxUjhobbi.Focus();
            
        }
    }
}
