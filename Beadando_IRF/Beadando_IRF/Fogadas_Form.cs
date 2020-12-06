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
                XmlDocument doc = new XmlDocument();
                doc.Load(ofd.FileName);
                Console.WriteLine(ofd.FileName);

            }
         
        }
    }
}
