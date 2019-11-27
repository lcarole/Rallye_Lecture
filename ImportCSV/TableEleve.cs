using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rallyeLecture
{
    class TableEleve
    {
        public void InsertEleve(Eleve eleve)
        {
            Connection Cnx = new Connection("172.16.0.138", "root", "siojjr", "rallyeLecture");
            string nom = eleve.Nom;
            string prenom = eleve.Prenom;
            string login = eleve.GetLogin;
            string rq = string.Format("insert into eleve (nom,prenom,login,idClasse,idAuth) values('"+nom+"','"+prenom+"','"+login+"','1','1')");
            Cnx.ouvrir();
            MySqlCommand Cmd = new MySqlCommand(rq, Cnx.Cnx);
            Cmd.ExecuteNonQuery();
            Cnx.fermer();
        }
    }
}
