using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rallyeLecture
{
    class TableClasse
    {
        public void Insert(Classe classe)
        {
            Connection Cnx = new Connection("172.16.0.138", "root", "siojjr", "rallyeLecture");
            int idEnseignant =classe.GetIDEnseignant;
            string anneeScolaire = classe.GetanneeScolaire;
            int idNiveau =classe.GetIDniveau;
            string rq = string.Format("insert into classe (idEnseignant,anneeScolaire,idNiveau) values(" + idEnseignant + ",'" + anneeScolaire+ "'," + idNiveau + ")");

            Cnx.ouvrir();
            MySqlCommand Cmd = new MySqlCommand(rq, Cnx.Cnx);
            Cmd.ExecuteNonQuery();
            Cnx.fermer();
        }
    }
}
