using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
