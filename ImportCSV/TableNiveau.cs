using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rallyeLecture
{
    class TableNiveau
    {
        public List<Niveau> GetAll()
        {
            MySqlDataReader Rdr;
            Connection cnx = new Connection("172.16.0.139", "root", "siojjr", "rallyeLecture");
            List<Niveau> niveau = new List<Niveau>();
            Niveau n;
            string message = cnx.ouvrir();
            Console.WriteLine(message);
            string requete = "select * from niveau";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx.Cnx;
            cmd.CommandText = requete;
            cmd.CommandType = System.Data.CommandType.Text;
            Rdr = cmd.ExecuteReader();
            while (Rdr.Read())
            {
                n = new Niveau(Rdr.GetInt32(0), Rdr.GetString(1));
                niveau.Add(n);
            }
            cnx.fermer();
            return niveau;
        }

    }
}
