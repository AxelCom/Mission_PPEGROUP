using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commergnat_boutique.GestionBoutique;

namespace commergnat_boutique
{
    class ClasseGestionClient
    {
        public static DataTable getLesClients()
        {
            return ExecuterRequeteSelect("SELECT * FROM Client");
        }
        public static void AjouterClient(int code, string nom, string prenom, string adresse, int codepostal, string ville)
        {
            Executer_Requete_Action("call InsertClient(" + code + ",'" + nom + "','" + prenom + "','" + adresse + "'," + codepostal + ",'" + ville + "')");
        }
        public static void SupprimerInfoClient(string table,int idClient)
        {
            string req = "Delete from " + table +" Where idClient = " + idClient + " ";
            Executer_Requete_Action(req);

        }
        public static void ModifierClient(int id,string nom, string prenom, string adresse, int codepostal, string ville)
        {
            Executer_Requete_Action("call UpdateClient("+ id +",'"+nom+"','"+prenom+"','"+adresse+"',"+codepostal+",'"+ville+"')");
        }


    }
}
