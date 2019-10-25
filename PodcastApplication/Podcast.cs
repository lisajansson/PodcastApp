using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public Podcast()
        {
            InitializeComponent();
        }

        private void ButtonNewPodcast_Click(object sender, EventArgs e)
        {
            string url = textBoxURL.Text;

            try
            {
                //if (File.Exists(url) ? "File exists." : "File does not exist.") ;
                //{                
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                var response = (HttpWebResponse)httpRequest.GetResponse();

                // Skapar en stream för att hålla innehållet (XML filen) (streamen är mototrvägen där XML filen färdas)
                var stream = response.GetResponseStream();

                // Skapar ett XML dokument
                var xmlDoc = new XmlDocument();

                // Fyller dokumentet med värdet
                xmlDoc.Load(stream);

                // Sparar XML filen med det nya värdet
                xmlDoc.Save("Podcast.xml");

                // Stänger streamen,motorvägen
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
    }
}
