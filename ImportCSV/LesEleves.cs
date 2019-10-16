using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rallyeLecture
{
    class LesEleves
    {
        List<Eleve> lesEleves;

        public void CreateCsvPasswordFile()
        {
            StreamWriter csv = new StreamWriter("eleveMdp.csv");
            for (int i = 0; i < lesEleves.Count; i++)
            {
                string login = lesEleves[i].GetLogin;
                string psw = lesEleves[i].GetPswd;
                csv.Write(login + ";");
                csv.WriteLine(psw + ";");
            }
            csv.Close();
        }

        public List<Eleve> LoadCsv(PassWordType type, StreamReader fichier)
        {
            fichier.ReadLine();
            while (fichier.EndOfStream == false)
            {
                string temp = fichier.ReadLine();
                string[] te = temp.Split(';');
                string nom;
                string prenom;
                nom = te[0];
                prenom = te[1];
                string login = prenom + nom + "@sio.jjr.fr";
                Eleve s = new Eleve(nom, prenom, login,type);
                lesEleves.Add(s); 
                Console.WriteLine(nom + " " + prenom + "Chargé !");
            }
            return lesEleves;
        }
    }
}
