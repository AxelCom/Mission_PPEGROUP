using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commergnat_boutique.GestionBoutique;
using static commergnat_boutique.GestionCommande;

namespace commergnat_boutique
{
    class ClasseGestionCommande
    {
        public static int idCommande = 0;
        public static DataTable getLesCommandes()
        {
            return ExecuterRequeteSelect("SELECT * FROM Commande");
        }
        public static DataTable getLesCommandesAvecNomCli()
        {
            return ExecuterRequeteSelect("SELECT idCommande, dateCommande, nomClient, idCli FROM Commande, Client WHERE idClient = idCli ORDER BY idCommande");
        }
        public static void AjouterCommande(int id, string date, int idCLi)
        {
            string req = "Insert into Commande Values (" + id + ",'" + date + "','" + idCLi + "')";
            Executer_Requete_Action(req);

        }
        public static void SupprimerInfoCommande(string table, int idComm)
        {
            string req = "Delete from " + table + " Where idCommande = " + idComm;
            Executer_Requete_Action(req);

        }
        public static void ModifierCommande(int id, string date, int idCLi)
        {
            string req = "Update Commande Set dateCommande = '" + date + "', idCLi = "+ idCLi +"  WHERE idCommande = " + id + " ";
            Executer_Requete_Action(req);
        }
        public static DataTable getLignesDeCommandesAvecNom()
        {
            return ExecuterRequeteSelect("call DetailCommandeByCommande(" + idCommande + ")");
        }
        public static DataTable getLignesDeCommandes()
        {
            return ExecuterRequeteSelect("SELECT * FROM lignedecommande WHERE idCommande = " + idCommande);
        }

        public static void AjouterLigneCommande(int id, string idProd, int Qte)
        {
            string req = "Insert into lignedecommande Values (" + id + ",'" + idProd + "'," + Qte + ")";
            Executer_Requete_Action(req);
        }
        public static void ModifierLigneCommande(int id, string idProd, int Qte)
        {
            string req = "Update lignedecommande Set quantiteCom = "+ Qte +" WHERE idCommande = " + id +" AND idProduit ="+ idProd;
            Executer_Requete_Action(req);
        }
        public static void SupprimerLigneCommande(string table, int idComm, int idProd)
        {
            string req = "Delete from " + table + " Where idCommande = " + idComm + " AND idProduit ="+ idProd;
            Executer_Requete_Action(req);

        }
        public static Boolean VerificationLigneDeCommande()
        {
            return VerificationTableVide(getLignesDeCommandes());
        }

        public static DataTable getCommandeByClient(string NomCli)
        {
            return ExecuterRequeteSelect("call rechercherCommandeByClient('" + NomCli +"')");
        }
    }
}
