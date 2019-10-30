using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PodcastApplication
{
    public partial class Podcast : Form
    {
        private int index;

        public Podcast()
        {
            InitializeComponent();
        }

        private void ButtonNewPodcast_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;

            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                var response = (HttpWebResponse)httpRequest.GetResponse();

                // Skapar en stream för att hålla innehållet (XML filen) (streamen är mototrvägen där XML filen färdas)
                var stream = response.GetResponseStream();

                // Skapar ett XML dokument
                var xmlDoc = new XmlDocument();

                // Fyller dokumentet med värdet
                xmlDoc.Load(stream);

                // Sparar XML filen med det nya värdet
                xmlDoc.Save("podcast.xml");

                // Stänger streamen, motorvägen
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Något gick fel!");
            }
        }

        private void ButtonSavePodcast_Click(object sender, EventArgs e)
        {
        }




        private void buttonNewCatefory_Click(object sender, EventArgs e)
        {

            textBoxCategory.AppendText(string.Join(",", new string[] { }));

            if (!string.IsNullOrEmpty(textBoxCategory.Text))
            {
                comboBoxCategory.Items.Add(textBoxCategory.Text);
                listBoxCategory.Items.Add(textBoxCategory.Text);
                textBoxCategory.Clear();
                MessageBox.Show("En ny kategori har lagts till!");
            }
            else
            {
                MessageBox.Show("Fältet får inte vara tomt!");
            }
        }

        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedItem = listBoxCategory.SelectedIndex;
                listBoxCategory.Items.RemoveAt(selectedItem);
                comboBoxCategory.Items.RemoveAt(selectedItem);
                listBoxCategory.Items.Insert(selectedItem, textBoxCategory.Text);
                comboBoxCategory.Items.Insert(selectedItem, textBoxCategory.Text);
                textBoxCategory.Clear();
            }
            catch { }
        }

        private void buttonDeletePodcast_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            int selectedCategory = listBoxCategory.SelectedIndex;
            listBoxCategory.Items.RemoveAt(selectedCategory);
            comboBoxCategory.Items.RemoveAt(selectedCategory);
            comboBoxCategory.Text = "";
            textBoxCategory.Clear();
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxCategory.Text = listBoxCategory.SelectedItem.ToString();
            }
            catch { }


        }

        private void comboBoxFrekvens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //* comboBoxCategory.Items.Insert("Varannan minut...";
            }
            catch { }
        }
    }
}


            
            

        
    
