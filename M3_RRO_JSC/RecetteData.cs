// Fichier: RecetteData.cs
// Description: Définit les modèles de données OperationRecette et Recette,
// ainsi qu'un cache statique pour la liste des recettes.
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace M3_RRO_JSC
{

    public class OperationRecette

    {
        public int IdOperation { get;set; }
        public string NomOperation { get; set; }
        public string Sens { get; set; }
        public string Position { get; set; }
        public string TempsAttente { get; set; }
        public bool CycleVerin { get; set; } = false;
        public bool Quittance { get; set; }
    }

    public class Recette
    {
        public int IdRecette { get; set; }
        public string NomRecette { get; set; }
        public DateTime DateCreation { get; set; }
        public List<OperationRecette> Operations { get; set; } = new List<OperationRecette>();
    }

    public static class RecetteData
    {
      public static List<Recette> ListeRecettes { get; set; } = new List<Recette>();
    }
    




}
