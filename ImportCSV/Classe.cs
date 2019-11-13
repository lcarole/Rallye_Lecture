using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture
{
    class Classe
    {
        private int idEnseignant;
        private string anneeScolaire;
        private int idNiveau;

        public Classe(int idEnseignant, string anneeScolaire, int idNiveau)
        {
            this.idEnseignant = idEnseignant;
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
        }
    }
}
