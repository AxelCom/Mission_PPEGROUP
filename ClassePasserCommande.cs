using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static commergnat_boutique.GestionBoutique;

namespace commergnat_boutique
{
    class ClassePasserCommande
    {
        public static int idReappro = 0;
        public static DataTable getLesReappro()
        {
            return GestionBoutique.ExecuterRequeteSelect("SELECT * FROM passercommande");
        }
        public static void ajouterReappro(int idReappro, DateTime dateReappro, int idProd, int qteCom, Boolean estArrivee)
        {
            string req = "Insert into lignedecommande Values (" + idReappro + ",'" + dateReappro + "'," + idProd + ","+ qteCom +","+ estArrivee +")";
            Executer_Requete_Action(req);
        }
    }
}