using System;
using System.Collections.Generic;
using static M3_RRO_JSC.OperationRecette;

namespace M3_RRO_JSC
{
    public class Lot
    {
        public string NomLot { get; set; }
        public int QuantitePieces { get; set; }
        public Recette RecetteAssociee { get; set; }
        public DateTime DateCreation { get; set; }
    }

    public static class LotData
    {
        public static List<Lot> ListeLots { get; set; } = new List<Lot>();
    }
}