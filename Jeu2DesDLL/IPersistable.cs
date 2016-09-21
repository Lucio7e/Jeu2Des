using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2DesDLL
{
    public interface IPersistable
    {
        /// <summary>
        /// Methode de l'interface permettant de persister un objet dans differents formats
        /// </summary>
       T Load<T>(T obj);

        /// <summary>
        /// Methode de l'interface permettant de récupérer un objet persité
        /// </summary>
        void Save<T>(T obj);
    }
}
