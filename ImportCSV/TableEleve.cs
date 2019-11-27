using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyeLecture
{
    class TableEleve
    {
         public void InsertEleve(Eleve eleve)
        {
         Connection Cnx = new Connection("172.16.0.149", "root", "siojjr", "rallyelecture");
            string nom = eleve.Nom;
            string prenom = eleve.Prenom;
            string login = eleve.GetLogin;
            string rq = string.Format("insert into classe(nom,prenom,login) values(" + nom + "," + prenom + "," + login + ")");


            Cnx.ouvrir();
            MySqlCommand Cmd = new MySqlCommand(rq, Cnx.Cnx);
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            Cnx.fermer();
         }
    }
}
