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
    public partial class DetailJezdceForm : Form
    {
        private Evidence evidence;

        public DetailJezdceForm(Evidence evidence)
        {
            InitializeComponent();

            this.evidence = evidence;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                evidence.Pridej(name.Text, surname.Text, Convert.ToInt16(number.Value), team.Text, Convert.ToBoolean(isfactory.CheckState));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
