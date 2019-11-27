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
        StreamReader csv;
        public Form1()
        {
            InitializeComponent();
            TableNiveau Niveaux = new TableNiveau();
            for (int i = 0; i < Niveaux.GetAll().Count; i++)
            {
                string nom = Niveaux.GetAll()[i].GetNiveau;
                cb_niveau.Items.Add(nom);
            }

            string[] Dir = Directory.GetDirectories(@"C:\");

            for (int i = 0; i < Dir.Length; i++)
            {
                cb_reper.Items.Add(Dir[i]);
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
            csv = new StreamReader(clb_fichcsv.SelectedItem.ToString());
            LesEleves lE = new LesEleves();
            TableEleve TE = new TableEleve();
            Classe cE = new Classe(1,année,cb_niveau.SelectedIndex);
            TableClasse Ce = new TableClasse();
            Ce.Insert(cE);
            for (int i = 0; i < lE.LoadCsv(type, csv).Count; i++)
            {
                TE.InsertEleve(lE.LoadCsv(type, csv)[i]);
            }
            if (type == PassWordType.Aleatoire)
            {
                lE.CreateCsvPasswordFile();
            }
            MessageBox.Show("L'integration s'est bien déroulée" , "Intégration effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cb_reper_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] F = Directory.GetFiles(@"C:\Rallye_Lecture\ImportCSV\bin\Debug");
            string Dossier = Directory.GetCurrentDirectory();
            int count = clb_fichcsv.Items.Count;
            if (count > 0)
            {

                clb_fichcsv.Items.Clear();

            }

            for (int i = 0; i < F.Length; i++)
            {
                string message = System.IO.Path.GetFileName(F[i]);
                clb_fichcsv.Items.Add(message);
            }
        }


    }
}
