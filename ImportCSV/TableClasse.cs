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
            Connection Cnx = new Connection("localhost", "root", "siojjr", "rallyelecture");
            string idEnseignant = Convert.ToString(classe.GetIDEnseignant);
            string anneeScolaire = classe.GetanneeScolaire;
            string idNiveau = Convert.ToString(classe.GetIDniveau);
            string rq = string.Format("insert into classe(idEnseignant, anneeScolaire, id Niveau) values("+idEnseignant+","+anneeScolaire+","+idNiveau+")");

            Cnx.ouvrir();
            MySqlCommand Cmd = new MySqlCommand(rq, Cnx.Cnx);
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            Cnx.fermer();
        }
    }
}
