using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commergnat_boutique.GestionBoutique;

namespace commergnat_boutique
{
    class ClasseGestionProduit
    {
        public static DataTable getLesProduitsAvecNom()
        {
            return GestionBoutique.ExecuterRequeteSelect("SELECT idProduit, libelleProduit, prixHTProduit, qteStockProduit, nomFournisseur, libelleCategorie FROM Produit, Fournisseur, Categorie where idFourn = idFournisseur and idCat = idCategorie ORDER BY idProduit");
        }
        public static DataTable getLesProduits()
        {
            return GestionBoutique.ExecuterRequeteSelect("CALL InfosProduits('')"); //Procédure stockée renvoyant tous les produits
        }

        public static DataTable getLesproduits(string TypeProduit)
        {
            return GestionBoutique.ExecuterRequeteSelect("CALL InfosProduits('" + TypeProduit + "')"); //Procédure stockée renvoyant les produits spécifiques au paramètre renseigné
        }

        public static DataTable getLesProduitsCA()
        {
            return GestionBoutique.ExecuterRequeteSelect("CALL InfosCAProduits('')"); //Procédure stockée renvoyant le chiffre d'affaire de tous les produits
        }

        public static DataTable getLesProduitsCA(string TypeProduit)
        {
            return GestionBoutique.ExecuterRequeteSelect("CALL InfosCAProduits('" + TypeProduit + "')"); //Procédure stockée renvoyant le chiffre d'affaire spécifique au paramètre renseigné
        }
        public static DataTable getLesCategories()
        {
            return GestionBoutique.ExecuterRequeteSelect("SELECT * FROM Categorie");
        }
        public static void AjouterProduit(int id, string libelle, int prix, int qte, int idFourn, int idCat)
        {
            string req = "Insert into Produit Values (" + id + ",'" + libelle + "'," + prix + "," + qte + "," + idFourn + "," + idCat + ")";
            Executer_Requete_Action(req);

        }
        public static void SupprimerProduit(string table, int idProduit)
        {
            string req = "Delete from " + table + " Where idProduit = " + idProduit + " ";
            Executer_Requete_Action(req);

        }
        public static void ModifierProduit(int id, string libelle, int prix, int qte, int idFourn, int idCat)
        {
            string req = "Update Produit Set libelleProduit = '" + libelle + "', prixHTProduit = " + prix + ", qteStockProduit = " + qte + ", idFourn = " + idFourn + ", idCat = " + idCat + "  WHERE idProduit = " + id + " ";
            Executer_Requete_Action(req);
        }
    }
}
