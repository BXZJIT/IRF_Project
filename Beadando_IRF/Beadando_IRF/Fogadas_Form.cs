using Beadando_IRF.Entities;
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
using System.Xml;

namespace Beadando_IRF
{
    public partial class Fogadas_Form : Form
    {
        List <string> championships = new List<string>();
        List<Match> matches = new List<Match>();
        XmlDocument doc;
        public Fogadas_Form()
        {
            InitializeComponent();
        }

        private void Beolvasas_Button_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            //ofd.Filter = "XML Files (.xml)|.xml"; 
            ofd.DefaultExt = "xml";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {
                doc = new XmlDocument();
                doc.Load(ofd.FileName);
                foreach (XmlElement element in doc.DocumentElement)
                {
                    string championshipName = element.GetAttribute("name");
                    championships.Add(championshipName);
                }

            }
            Bajnoksag_Listbox.DataSource = championships;
         
        }

        private void Bajnoksag_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            matches.Clear();
            string selectedChampionship = Bajnoksag_Listbox.SelectedItem.ToString();

            // Kategóriák
            foreach (XmlElement element in doc.DocumentElement)
            {
                if (element.GetAttribute("name") == selectedChampionship)
                {
                    // Meccsek
                    foreach (XmlElement match in element.FirstChild)
                    {
                        Match newMatch = new Match();
                        newMatch.id = match.GetAttribute("id");
                        //Console.WriteLine("NewMatchId: " + match.GetAttribute("id"));
                        string localTeam = "";
                        string visitorTeam = "";

                        // Meccs gyermekeiből hazai és vendég csapat tárolása
                        foreach (XmlElement matchChild in match.ChildNodes)
                        {
                            if (matchChild.Name == "localteam")
                            {
                                localTeam = matchChild.GetAttribute("name");
                                newMatch.localTeam = localTeam;
                                //Console.WriteLine("Localteam: " + matchChild.GetAttribute("name"));
                            }

                            if (matchChild.Name == "visitorteam")
                            {
                                visitorTeam = matchChild.GetAttribute("name");
                                newMatch.visitorTeam = visitorTeam;
                                //Console.WriteLine("Visitorteam: " + matchChild.GetAttribute("name"));
                            }
                        }

                        // Meccs hozzáadása listához
                        newMatch.localAndVisitor = localTeam + "-" + visitorTeam;
                        matches.Add(newMatch);
                        //Console.WriteLine("LocalAndVisitor: " + localTeam + "-" + visitorTeam);
                    }
                }
            }
            // Listbox frissítése
            Merkozes_Listbox.DataSource = new List<string>();
            Merkozes_Listbox.DataSource = matches;
            Merkozes_Listbox.DisplayMember = "localAndVisitor";
            Merkozes_Listbox.ValueMember = "id";



        }
    }
}
