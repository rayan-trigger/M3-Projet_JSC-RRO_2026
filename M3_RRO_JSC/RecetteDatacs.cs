using System;
using System.Collections.Generic;
using System.Text;

namespace M3_RRO_JSC
{
    internal class RecetteDatacs
    {
    }

    public class OperationRecette

    {
        public string NomOperation {  get; set; }
        public bool MoteurActif {  get; set; }
        public string Sens {  get; set; }
        public string Position { get; set; }
        public string TempsAttente { get; set; }
        public bool CycleVerin { get; set; }
        public bool Quittance { get; set; }
        public class Recette
        {
            public string NomRecette { get; set; }
            public DateTime DateCreation { get; set; }
            public List<OperationRecette> Operations { get; set; } = new List<OperationRecette>();
        }

        public static class RecetteData
        {
            public static List<Recette> ListeRecettes { get; set; } = new List<Recette>();
        }
    }




}
