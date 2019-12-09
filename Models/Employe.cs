using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetTP.Models
{
    public class Employe
    {
        #region Attributs
  
        private int employeId;
        private string nom;
        private string prenom;
        private ICollection<Projet> projets;
  

        #endregion


        #region Propriétés
        public int MyProperty
        {
            get { return employeId; }
            set { employeId = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public ICollection<Projet> Projets
        {
            get { return projets; }
            set { projets = value; }
        }

        #endregion
    }
}