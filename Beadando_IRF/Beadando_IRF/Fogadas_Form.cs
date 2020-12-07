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
        List<SzelvenyElem> oddsList = new List<SzelvenyElem>();
        List<SzelvenyElem> playedList = new List<SzelvenyElem>();
        XmlDocument doc;
        public Fogadas_Form()
        {
            InitializeComponent();
            Szelveny_ListBox.DataSource = playedList;
            Szelveny_ListBox.DisplayMember = "oddNameAndValue";
            Szelveny_ListBox.ValueMember = "oddId";
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
                        newMatch.time = match.GetAttribute("time");
                        //Console.WriteLine("NewMatchId: " + match.GetAttribute("id"));
                        newMatch.categoryName = Bajnoksag_Listbox.SelectedItem.ToString();
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
                        newMatch.localAndVisitor = localTeam + "-" + visitorTeam + "-" + newMatch.time;
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

        private void Merkozes_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            oddsList.Clear();
            Match selectedMatch = (Match)Merkozes_Listbox.SelectedItem;
            // Kategóriák
            foreach (XmlElement element in doc.DocumentElement)
            {
                if (element.GetAttribute("name") == selectedMatch.categoryName)
                {
                    // Meccsek
                    foreach (XmlElement match in element.FirstChild)
                    {
                        if (match.GetAttribute("id") == selectedMatch.id)
                        {
                            // Meccs gyermekeinek iterálása
                            foreach (XmlElement matchChild in match.ChildNodes)
                            {
                                if (matchChild.Name == "odds")
                                {
                                    // Fogadási lehetőségek iterálása
                                    foreach (XmlElement oddsChild in matchChild.ChildNodes)
                                    {
                                        if (oddsChild.GetAttribute("value") == "Match Winner")
                                        {
                                            // Segéd sor
                                            SzelvenyElem dummyElem = new SzelvenyElem();
                                            dummyElem.oddId = "dummy";
                                            dummyElem.oddNameAndValue = "Ki nyeri a meccset?";
                                            oddsList.Add(dummyElem);
                                            // Match winner típusú fogadás iterálása
                                            foreach (XmlElement odd in oddsChild.FirstChild)
                                            {
                                                SzelvenyElem newElem = new SzelvenyElem();
                                                newElem.categoryName = selectedMatch.categoryName;
                                                newElem.matchId = selectedMatch.id;
                                                newElem.localTeam = selectedMatch.localTeam;
                                                newElem.visitorTeam = selectedMatch.visitorTeam;
                                                newElem.time = selectedMatch.time;
                                                newElem.oddType = oddsChild.GetAttribute("value");
                                                newElem.oddName = odd.GetAttribute("name");
                                                newElem.oddValue = odd.GetAttribute("value");
                                                newElem.oddNameAndValue = odd.GetAttribute("name") + "-" + odd.GetAttribute("value");
                                                newElem.oddId = odd.GetAttribute("id");
                                                newElem.fullDetail = newElem.oddType + "," + newElem.localTeam + "-" + newElem.visitorTeam + " at " + newElem.time + " Odd: " + newElem.oddNameAndValue;

                                                oddsList.Add(newElem);
                                            }
                                        }

                                        // Both Teams to score típusú fogaád iterálása
                                        if (oddsChild.GetAttribute("value") == "Both Teams To Score")
                                        {
                                            // Segéd sor
                                            SzelvenyElem dummyElem = new SzelvenyElem();
                                            dummyElem.oddId = "dummy";
                                            dummyElem.oddNameAndValue = "Mindkét csapat rúg gólt?";
                                            oddsList.Add(dummyElem);
                                            foreach (XmlElement odd in oddsChild.FirstChild)
                                            {
                                                SzelvenyElem newElem = new SzelvenyElem();
                                                newElem.categoryName = selectedMatch.categoryName;
                                                newElem.matchId = selectedMatch.id;
                                                newElem.localTeam = selectedMatch.localTeam;
                                                newElem.visitorTeam = selectedMatch.visitorTeam;
                                                newElem.time = selectedMatch.time;
                                                newElem.oddType = oddsChild.GetAttribute("value");
                                                newElem.oddName = odd.GetAttribute("name");
                                                newElem.oddValue = odd.GetAttribute("value");
                                                newElem.oddNameAndValue = odd.GetAttribute("name") + "-" + odd.GetAttribute("value");
                                                newElem.oddId = odd.GetAttribute("id");
                                                newElem.fullDetail = newElem.oddType + "," + newElem.localTeam + "-" + newElem.visitorTeam + "at " + newElem.time + " Odd: " + newElem.oddNameAndValue;

                                                oddsList.Add(newElem);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Listbox frissítése
            Lehetosegek_Listbox.DataSource = new List<SzelvenyElem>();
            Lehetosegek_Listbox.DataSource = oddsList;
            Lehetosegek_Listbox.DisplayMember = "oddNameAndValue";
            Lehetosegek_Listbox.ValueMember = "oddId";
        }

        private void Hozzaadas_Button_Click(object sender, EventArgs e)
        {
            SzelvenyElem elemToAdd = (SzelvenyElem)Lehetosegek_Listbox.SelectedItem;
            // Dummy elem esetén (segéd sor) ne tegyen semmit
            if (elemToAdd.oddId == "dummy") return;

            // Listbox frissítése
            playedList.Add(elemToAdd);
            Szelveny_ListBox.DataSource = new List<SzelvenyElem>();
            Szelveny_ListBox.DataSource = playedList;
            Szelveny_ListBox.DisplayMember = "fullDetail";
            Szelveny_ListBox.ValueMember = "oddId";
        }
    }
}
