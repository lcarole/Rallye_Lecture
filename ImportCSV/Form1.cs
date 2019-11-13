using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rallyeLecture
{
    public partial class Form1 : Form
    {
        string année;
        LesEleves eleves = new LesEleves();
        PassWordType type;
        StreamReader csv = new StreamReader("newEleves.csv");
        public Form1()
        {
            InitializeComponent();
            TableNiveau Niveaux = new TableNiveau();
            for (int i = 0; i < Niveaux.GetAll().Count; i++)
            {
                string nom = Niveaux.GetAll()[i].GetNiveau;
                cb_niveau.Items.Add(nom);
            }
        }

  

    private void tb_annee_TextChanged(object sender, EventArgs e)
        {
            année = tb_annee.Text;
        }

        private void rd_aleatoire_CheckedChanged(object sender, EventArgs e)
        {
            type = PassWordType.Aleatoire;
        }

        private void rd_Construit_CheckedChanged(object sender, EventArgs e)
        {
            type = PassWordType.Construit;
        }

        private void btn_integ_Click(object sender, EventArgs e)
        {
            LesEleves lE = new LesEleves();
            lE.LoadCsv(type, csv);
            if (type == PassWordType.Aleatoire)
            {
                lE.CreateCsvPasswordFile();
            }
        }
    }
}
