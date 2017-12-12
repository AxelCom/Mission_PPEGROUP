using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commergnat_boutique.GestionBoutique;

namespace commergnat_boutique
{
    class ClasseGestionFournisseur
    {
        public static DataTable getLesFournisseurs()
        {
            return ExecuterRequeteSelect("SELECT * FROM fournisseur");
        }
        public static void AjouterFournisseur(int id, string nom, string ville, int codepostal)
        {
            string req = "Insert into Fournisseur Values (" + id + ",'" + nom + "','" + ville + "'," + codepostal + ")";
           Executer_Requete_Action(req);

        }
        public static void SupprimerInfoFournisseur(string table, int idFourn)
        {
            string req = "Delete from " + table + " Where idFournisseur = " + idFourn + " ";
            Executer_Requete_Action(req);

        }
        public static void ModifierFournisseur(int id, string nom, string ville, int codepostal)
        {
            string req = "Update Fournisseur Set nomFournisseur = '" + nom + "', villeFournisseur = '" + ville + "', cpFournisseur = " + codepostal + "  WHERE idFournisseur = " + id + " ";
            Executer_Requete_Action(req);
        }
    }
}
