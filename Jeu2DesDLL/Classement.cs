using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    [Serializable]
    public abstract class Classement
    {
        
        #region "Propriétés et accesseurs"
        protected List<Entree> _Entrees = new List<Entree>();
        public List<Entree> Entrees
        {
            get
            {
                return _Entrees;
            }

        }
        #endregion
        #region "Constructeurs"
        public Classement()
        {
            
        }
        #endregion
        #region "Methodes"
        //GG : on peut aussi prévoir 2 paramètres pour AjouterEntree (nom, score)
        public void AjouterEntree(Joueur joueur)
        {
            Entree entree = new Entree(joueur.Nom, joueur.Score);
            Entrees.Add(entree);
        }

        //GG : J'ai ajouté une surcharge de TopN(int nb) pour afficher les "nb" plus haut scores seulement
        public string TopN()
        {
            Entrees.Sort();
            return "-----CLASSEMENT-----\n"+this.ToString();
        }
        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            string retour = "";
            foreach (Entree item in Entrees)
            {
                retour += item.ToString()+"\n";
            }
            return retour;
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"

        public abstract void Load();
        public abstract void Save();
        #endregion






    }
}
