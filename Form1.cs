using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            szulDatumBeker.Value = DateTime.Now;

        }

        public void mentesgombFelold()
        {
            if (!String.IsNullOrWhiteSpace(textBoxNev.Text) &&
                szulDatumBeker.Value < DateTime.Now &&
                listBoxHobbiLista.SelectedIndex >= 0)
            {
                buttonMentes.Enabled = true;
            }
            else
            {
                buttonMentes.Enabled = false;
            }
        }
        
        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            string szoveg = textBoxUjhobbi.Text;
            if (String.IsNullOrWhiteSpace(szoveg))
            {
                MessageBox.Show("Üres a beviteli mező!");
                textBoxUjhobbi.Text = "";
                textBoxUjhobbi.Focus();
                return;
            }
            if (listBoxHobbiLista.Items.Contains(szoveg))
            {
                MessageBox.Show("Ez már szerepel!");
                textBoxUjhobbi.Text = "";
                textBoxUjhobbi.Focus();
                return;
            }
                
                listBoxHobbiLista.Items.Add(szoveg.TrimStart().TrimEnd());
                textBoxUjhobbi.Text = "";
                textBoxUjhobbi.Focus();
            mentesgombFelold();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            try
            {
                    var result = saveFileDialog.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        return;
                    }
                string fileName = saveFileDialog.FileName;


                using (var sw = new StreamWriter(fileName))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxNev.Text))
                    {
                        sw.WriteLine(textBoxNev.Text);
                    }
                    else
                    {
                        MessageBox.Show("A név vagy üres vagy csak szóközöket tartalmaz!");
                        textBoxNev.Focus();
                        return;
                    }
                    if (szulDatumBeker.Value < DateTime.Now)
                    {
                        
                        
                        sw.WriteLine(szulDatumBeker.Value.ToString("yyyy/MM/dd"));
                    }
                    else
                    {
                        MessageBox.Show("A születési dátum nem lehet nagyobb a jelenlegi dátumnál!");
                        szulDatumBeker.Focus();
                        return;
                    }
                    if (radioButtonFerfi.Checked)
                    {
                        sw.WriteLine("Férfi");
                    }
                    if (radioButtonNo.Checked)
                    {
                        sw.WriteLine("Nő");
                    }
                    if (listBoxHobbiLista.SelectedIndex >= 0)
                    {
                        int db = 0;
                        foreach (var item in listBoxHobbiLista.Items)
                        {
                            if (db == listBoxHobbiLista.SelectedIndex)
                            {
                                sw.WriteLine("Kedvenc: " +item);
                                db++;
                            }
                            else
                            {
                                sw.WriteLine(item);
                                db++;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Válasszon ki egy kedvenc hobbit.");
                        listBoxHobbiLista.Focus();
                        return;
                    }
                    sw.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a mentés során");
            }
            
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            List<string> visszatoltLista = new List<string>();

            

            try
            {
                var result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    
                    return;
                }
                string fileName = openFileDialog1.FileName;

                    listBoxHobbiLista.Items.Clear();
                    textBoxNev.Clear();
                    radioButtonFerfi.Checked = true;
                StreamReader sr = new StreamReader(fileName);

                textBoxNev.Text = sr.ReadLine();
                szulDatumBeker.Value = DateTime.Parse(sr.ReadLine());
                if (sr.ReadLine() == "Férfi")
                {
                    radioButtonFerfi.Checked = true;
                }
                else
                {
                    radioButtonNo.Checked = false;
                }

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    if (sor.StartsWith("Kedvenc: "))
                    {
                        string torolt = sor.Remove(0, 9);
                        listBoxHobbiLista.Items.Add(torolt);
                        listBoxHobbiLista.SelectedItem = torolt;
                    }
                    else
                    {
                        listBoxHobbiLista.Items.Add(sor);
                    }
                }
                sr.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a beolvasás során");
            }

        }

        private void textBoxNev_TextChanged(object sender, EventArgs e)
        {
            mentesgombFelold();
        }

        private void listBoxHobbiLista_SelectedValueChanged(object sender, EventArgs e)
        {
            mentesgombFelold();
        }

        private void szulDatumBeker_ValueChanged(object sender, EventArgs e)
        {
            mentesgombFelold();
        }
    }
    
}
