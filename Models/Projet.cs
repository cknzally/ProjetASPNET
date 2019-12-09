using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetTP.Models
{
    public class Projet
    {
        #region Attributs
        private int projetId;
        private string intitule;
        private DateTime dateDebut;
        private DateTime dateLivraison;
        private int nmbreJour;
        private string description;
        private ICollection<Employe> employes;
        private ICollection <Commentaire> commentaires;


        #endregion

        #region Propriétés

        public int ProjetId
        {
            get { return projetId; }
            set { projetId = value; }
        }

        [Required]
        [RegularExpression(@"^[A-Z]{2}\d{5}$")]
        [StringLength(200)]
        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date de début")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }


        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date de livraison")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateLivraison
        {
            get { return dateLivraison; }
            set { dateLivraison = value; }
        }

        [DisplayName]
        public int NombreJour
        {
            get { return nmbreJour; }
            set { nmbreJour = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public ICollection<Employe> Employes
        {
            get { return employes; }
            set { employes = value; }
        }
        [StringLength(200)]
        public ICollection<Commentaire> Commentaires
        {
            get { return commentaires; }
            set { commentaires = value; }
        }
        #endregion 
    }
}