using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    /// <summary>
    /// Classe Classement permettant de gerer un classement d'entrées 
    /// </summary>
    [Serializable]
    public abstract class Classement
    {
        
        #region "Propriétés et accesseurs"
        //La liste des entrees du classement
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
       /// <summary>
       /// Methode qui permet d'ajouter une entree de type joueur à la liste d'entrées du classement 
       /// </summary>
       /// <param name="joueur"></param>
        public void AjouterEntree(Joueur joueur)
        {
            Entree entree = new Entree(joueur.Nom, joueur.Score);
            Entrees.Add(entree);
        }
        /// <summary>
        /// Methode qui permet d'ajouter une entree en passant le nom, et le score du joueur en paramètres
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="score"></param>
        public void AjouterEntree(string nom, int score)
        {
            Entree entree = new Entree(nom, score);
            Entrees.Add(entree);
        }
        /// <summary>
        /// Methode qui renvoie, sous forme de string, le classement trier par ordre décroissant
        /// </summary>
        /// <returns></returns>
        public string TopN()
        {
            Entrees.Sort();
            return "-----CLASSEMENT-----\n"+this.ToString();
        }
        #endregion
        #region "Methodes héritées et substituées"
        /// <summary>
        ///Redefinition de la methode toString, on renvoi la liste des entrées du classement sous forme de chaine de caracteres.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Methode abstraite permettant la persistance du classement 
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Methode abstraite qui permet de recuperer un classement déjà sauvegardé
        /// </summary>
        public abstract void Save();

        #endregion






    }
}
