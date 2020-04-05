using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MotoGP
{
    public partial class MainForm : Form
    {
        private Evidence evidence = new Evidence();

        public MainForm()
        {
            InitializeComponent();

            list.DataSource = evidence.Zavodnici;
        }

        private void add_Click(object sender, EventArgs e)
        {
            DetailJezdceForm detailJezdceForm = new DetailJezdceForm(evidence);
            detailJezdceForm.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(list.SelectedItem != null)
            {
                evidence.Odeber((Zavodnik)list.SelectedItem);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list.SelectedItem != null)
            {
                Zavodnik vybrany = (Zavodnik)list.SelectedItem;
                //Evidence seznam = evidence.Zobraz();
               // DetailJezdceForm detailJezdceForm = new DetailJezdceForm(seznam);
                //detailJezdceForm.ShowDialog();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter xw = XmlWriter.Create(@"seznam_jezdcu.xml", settings))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("jezdci");

                foreach (Zavodnik z in evidence.Zavodnici)
                {
                    xw.WriteStartElement("jezdec");
                    xw.WriteAttributeString("cislo", z.Cislo.ToString());

                    xw.WriteElementString("jmeno", z.Jmeno);
                    xw.WriteElementString("prijmeni", z.Prijmeni);
                    xw.WriteElementString("tym", z.Tym);
                    xw.WriteElementString("tovarni_tym", z.TovarniTym.ToString());

                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Flush();
            }
            DialogResult result = MessageBox.Show("Seznam jezdců úspěšně exportován do XML.");
        }

        private void import_Click(object sender, EventArgs e)
        {
            using (XmlReader xr = XmlReader.Create(@"seznam_jezdcu.xml"))
            {
                string jmeno = "";
                string prijmeni = "";
                int cislo = 0;
                string tym = "";
                bool tovarni_tym = false;

                string element = "";

                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name; 
                        if (element == "jezdec")
                        {
                            cislo = int.Parse(xr.GetAttribute("cislo"));
                        }
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "jmeno":
                                jmeno = xr.Value;
                                break;
                            case "prijmeni":
                                prijmeni = xr.Value;
                                break;
                            case "tym":
                                tym = xr.Value;
                                break;
                            case "tovarni_tym":
                                tovarni_tym = bool.Parse(xr.Value);
                                break;
                        }
                    }
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "jezdec"))
                    {
                        evidence.Pridej(jmeno, prijmeni, cislo, tym, tovarni_tym);
                    }
                }
            }
        }
    }
}
