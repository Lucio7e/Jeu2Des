using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    [Serializable]
    [DataContract]
    public class Classement
    {
        
        #region "Propriétés et accesseurs"
        private List<Entree> _Entrees = new List<Entree>();
        IPersistable _persistable;
        [DataMember]
        public List<Entree> Entrees
        {
            get
            {
                return _Entrees;
            }
            set
            {
                 _Entrees = value;
            }

        }
        /// <summary>
        /// Permettra de changer le type de serialization 
        /// </summary>
        public IPersistable Persistable
        {
            get { return _persistable; }     
            set
            {
                _persistable = value;
            }
        }
        #endregion
        #region "Constructeurs"
        public Classement()
        {
            
        }

        public Classement(Classement c)
        {
            this.Entrees = c.Entrees;
            this.Persistable = c.Persistable;
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

        /// <summary>
        /// Methode qui apellera la sérialization au format correspondant à celui de l'interface 
        /// </summary>
        public void Persister()
        {
            _persistable.Save(this);
        }
        /// <summary>
        /// Methode qui apellera la désérialization au format correspndat à celui de l'interface
        /// </summary>
        public void Charger()
        {
            Object obj = _persistable.Load(this);
            if (obj != null)
            {
                if (obj.GetType().Equals(this.GetType()))
                {
                    Classement c = (Classement)obj;
                    this.Entrees = c.Entrees;
                }
            }
            
        }
       
        #endregion






    }
}
