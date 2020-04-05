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
    public partial class DetailJezdceEditaceForm : Form
    {
        public Zavodnik zavodnik;

        public DetailJezdceEditaceForm(Zavodnik zavodnik)
        {
            InitializeComponent();

            this.zavodnik = zavodnik;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                zavodnik.Edituj(name.Text, surname.Text, Convert.ToInt16(number.Value), team.Text, Convert.ToBoolean(isfactory.CheckState));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
