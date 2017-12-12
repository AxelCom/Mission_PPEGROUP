using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace commergnat_boutique
{
    class GenPDF
    {
        public static void GenererPDFDepuisDataTable(string titre, DataTable lesdonnees, PdfPTable tableau_nomChamp)
        {
            Document Doc = new Document();
            PdfPTable tableau_entete;
            PdfPTable tableau_ligne;

            PdfPCell cellule = new PdfPCell();

            try
            {
                PdfWriter.GetInstance(Doc, new System.IO.FileStream("d:/fichier.pdf", System.IO.FileMode.Create));

                Doc.Open();

                tableau_entete = new PdfPTable(1);

                cellule.Colspan = 0;

                tableau_entete.AddCell(titre);
                Doc.Add(tableau_entete);


                tableau_nomChamp.SpacingBefore = 10;

                Doc.Add(tableau_nomChamp);

                tableau_ligne = new PdfPTable(lesdonnees.Columns.Count);
                tableau_ligne.SpacingBefore = 10;
                int nblignes;
                int nbcolonnes;
                string uneligne = "  ";
                nblignes = lesdonnees.Rows.Count;
                nbcolonnes = lesdonnees.Columns.Count;
                cellule.Colspan = 5;

                int i, j;
                for (i = 0; i < nblignes; i++)
                {
                    for (j = 0; j < nbcolonnes; j++)
                    {
                        tableau_ligne.AddCell(uneligne = lesdonnees.Rows[i].ItemArray[j].ToString());
                    }
                    //tableau_ligne.AddCell(uneligne);
                }
                Doc.Add(tableau_ligne);
            }
            catch (Exception e)
            {
                MessageBox.Show(" Erreur sur le fichier Pdf " + e.Message);
            }
            Doc.Close();
            Process.Start("d:/fichier.pdf");
        }
    }
}
