using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    public interface IPersistable
    {
        /// <summary>
        /// Methode de l'interface permettant de persister un objet dans differents formats
        /// </summary>
        void Load(Classement classement);

        /// <summary>
        /// Methode de l'interface permettant de récupérer un objet persité
        /// </summary>
        void Save(Classement classement);
    }
}
