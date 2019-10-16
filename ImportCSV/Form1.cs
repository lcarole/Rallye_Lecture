using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rallyeLecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tb_annee_TextChanged(object sender, EventArgs e)
        {

            Eleve test = new Eleve("dfe", "dsfds", "dsde",PassWordType.Aleatoire);
            tb_annee.Text = test.GetPswd;
        }
 
    }
}
