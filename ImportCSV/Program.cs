using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using classbibli;

namespace rallylecture
{
    class Program
    {
        static void Main(string[] args)
        {

            string message;
            Connection conn = new Connection("localhost", "root", "siojjr", "rallyelecture");
            message = conn.ouvrir();
            Console.WriteLine(message);
            conn.fermer();
            Console.ReadLine();

            conn.ouvrir();

            MySqlCommand cmd =new MySqlCommand();

            cmd.Connection = conn.Cnx; 
            cmd.CommandText = "select * from auteur";
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr["id"].ToString()+" "+ rdr["nom"].ToString()); 
            }
            conn.fermer();
            Console.ReadLine();
            




        }
    }
}
