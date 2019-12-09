using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetTP.Models
{
    public class Commentaire
    {
       #region Attributs
        private int commentaireId;
        private string texte;
        private string projet;

        #endregion


        #region Propriété

        public int CommentaireId
        {
            get { return commentaireId; }
            set { commentaireId = value; }
        }

        [StringLength(200)]
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        public string Projet
        {
            get { return projet; }
            set { projet = value; }
        }
        #endregion
    }
}