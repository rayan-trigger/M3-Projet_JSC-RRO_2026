using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{

    public partial class AccueilControl : UserControl
    {
        public AccueilControl()
        {
            InitializeComponent();
        }
    }


    public void ChargerLotEnProduction()
        {
            
                grdLotEnProd.Rows.Clear();
                grdLotEnProd.Columns.Clear();

                grdLotEnProd.Columns.Add("NomLot", " Nom du lot");
                grdLotEnProd.Columns.Add("Quantite", "Quantité");
                grdLotEnProd.Columns.Add("Recette", "Recette");
                grdLotEnProd.Columns.Add("DateCreation", "Date de création");

                if (LotData.LotEnProduction != null)
                {
                    Lot lot = LotData.LotEnProduction;

                    grdLotEnProd.Rows.Add(
                        lot.NomLot,
                        lot.QuantitePieces,
                        lot.RecetteAssociee != ? lot.RecetteAssociee.NomRecette : "",
                        lot.DateCreation.ToString("dd/MM/yyyy HH:mm")
                        );
                }


            grdLotEnProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd






                
                
            

        }
}
