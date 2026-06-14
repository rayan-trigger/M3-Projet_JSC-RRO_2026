using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Resources.ResXFileRef;

namespace M3_RRO_JSC
{
    /*  On a décidé de  créé des enum pour éviter de travailler avec du texte libre dans les ComboBox.Comme la base de données attend des valeurs numériques
        pour la position moteur et le sens moteur, l’enum permet d’associer un nom lisible à une valeur numérique.
        Dans l’interface, l’utilisateur voit un choix clair, mais au moment d’enregistrer en base, on convertis ce choix en entier.*/

    /// <summary>
    /// Représente les différentes positions possibles du moteur.
    /// </summary>
    public enum PosMoteur
    {
        Inactif = 0,
        Midi = 1, 
        TroisHeures = 2,
        SixHeures = 3,
        NeufHeures = 4,
    }

    /// <summary>
    /// J’utilise une enum pour éviter les valeurs invalides, l’utilisateur choisit un sens dans la liste, 
    /// puis je le convertis en booléen pour respecter le type BOOLEAN de la base de données.
    /// </summary>
    public enum SensMoteur
    {
        AntiHoraire = 0,
        Horaire = 1,
    }
}
