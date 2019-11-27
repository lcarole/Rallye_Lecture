using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Eleve
    {
        private string nom;
        private string prenom;
        private string login;
        private string passWord;
        public static Random caracAleatoire = new Random();
       

        public Eleve(string nom, string prenom, string login, PassWordType type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GetNewPassWord(type);
        }
        private static string GetPasswordAleatoire() 
            {
            string majAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string minAlpha = "abcdefghijklmnopqrstuvwxyz";
            char[] mdp = new char[9];
            string num = "0123456789";
            string caraSpe = "&':!*%$£=_";
            string mDePasse = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < majAlpha.Length; j++)
                {
                    if (mdp[i] != majAlpha[j] || mdp[i] != minAlpha[j] || mdp[i] != num[i] || mdp[i] != caraSpe[i])
                    {
                        mdp[caracAleatoire.Next(9)] = minAlpha[caracAleatoire.Next(25)];
                        mdp[caracAleatoire.Next(9)] = majAlpha[caracAleatoire.Next(25)];
                        mdp[caracAleatoire.Next(9)] = num[caracAleatoire.Next(10)];
                        mdp[caracAleatoire.Next(9)] = caraSpe[caracAleatoire.Next(10)];
                        mDePasse = new string(mdp); 
                    }
                }
                
            }
            return mDePasse;
            }

        private string GetPassWordConstruit()
        {
            string mdp = Convert.ToString(this.prenom[0]) + this.nom;
            return mdp;
        }

        public string GetNewPassWord(PassWordType type)
        {
            if (type == PassWordType.Aleatoire)
            {
               return this.passWord=GetPasswordAleatoire();
            }
            else
            {
                return this.passWord=GetPassWordConstruit();
            }
            

        }

        public string GetLogin
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        public string GetPswd
        {
            get
            {
                return this.passWord;
            }
            set
            {
                this.passWord = value;
            }
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
