using System;
using System.Collections.Generic;
using static M3_RRO_JSC.OperationRecette;

namespace M3_RRO_JSC
{
    public class Lot
    {
        public string NomLot { get; set; } = string.Empty;
        public int QuantitePieces { get; set; }
        public Recette? RecetteAssociee { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;

    }

    public static class LotData
    {
        public static List<Lot> ListeLots { get; set; } = new List<Lot>();

        public static Lot? LotEnProduction { get; set; }

    }
}