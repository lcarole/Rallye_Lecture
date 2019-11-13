using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rallyeLecture
{
    class TableEnseignant
    {
        public Enseignant GetByLogin(string login)
        {
            Enseignant e;
            string[] param = new string[99];
            int i;
            Connection Cnx = new Connection("172.16.0.139", "root", "siojjr", "rallyelecture");
            string rq = string.Format("select * from enseignant where login = '" + login + "'");
            Cnx.ouvrir();
            MySqlCommand Cmd = new MySqlCommand(rq, Cnx.Cnx);
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {
                i = 0;
                while(i<Rdr.FieldCount)
                {
                    Console.Write(Rdr.GetString(i) + " ");
                    param[i] = Rdr.GetString(i);
                    

                }
                Console.WriteLine();
            }
            Cnx.fermer();
            e = new Enseignant(Convert.ToInt32(param[0]), param[1], param[2], param[3], param[4]);
            return e;
        }
    }
}
