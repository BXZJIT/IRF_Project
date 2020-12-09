using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_IRF
{
    public partial class Szelveny_Form : Form
    {
        List<SzelvenyElem> betList;
        decimal finalOdds = 0;
        public Szelveny_Form(List<SzelvenyElem> playedList)
        {
            InitializeComponent();
            betList = playedList;
            ShowSzelvenyElems();
            SetFinalOdd();
            SetProfit();
        }

        private void SetProfit()
        {
            if (!(String.IsNullOrEmpty(Tet_TextBox.Text)))
            {
               decimal betMoney = decimal.Parse(Tet_TextBox.Text);
                Nyeremeny_Label.Text = Math.Round((finalOdds * betMoney),0).ToString();
            }
            else
            {
                Nyeremeny_Label.Text = 0.ToString();
            }
        }

        private void SetFinalOdd()
        {

            // Végső szorzó beállítása
            for (int i = 0; i < betList.Count; i++)
            {
                if (i == 0) finalOdds = decimal.Parse(betList[i].oddValue);
                else
                {
                    finalOdds = finalOdds * decimal.Parse(betList[i].oddValue);
                }
            }
            SzorzoErtek_Label.Text = Math.Round(finalOdds,2).ToString();
        }

        private void ShowSzelvenyElems()
        {
            // Minden fogadási elemre új UserControl hozzáadása
            for (int i = 0; i < betList.Count; i++)
            {
                SzelvenyElem_UserControl newElem = new SzelvenyElem_UserControl();
                newElem.SZE_Bajnoksag_Label.Text = betList[i].categoryName;
                newElem.SZE_Merkozes_Label.Text = betList[i].time + " " + betList[i].localTeam + "-" + betList[i].visitorTeam;
                newElem.SZE_Fogadas_Label.Text = betList[i].oddType + "-" + betList[i].oddNameAndValue;
                newElem.Top = i * 30;
                Szelveny_Panel.Controls.Add(newElem);
            }
        }

        private void Tet_TextBox_TextChanged(object sender, EventArgs e)
        {
            SetProfit();
        }

        private void Exportalas_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //Opcionális rész
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (.csv)|.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                
                foreach (var b in betList)
                {
                    sw.Write(b.categoryName);
                    sw.Write(";");
                    sw.Write(b.time + " " + b.localTeam + "-" +b.visitorTeam);
                    sw.Write(";");
                    sw.Write(b.oddType + "-" + b.oddNameAndValue);
                    sw.WriteLine();
                }
            }
        }
    }
}
