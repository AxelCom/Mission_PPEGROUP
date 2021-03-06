﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Renci.SshNet;

namespace commergnat_boutique
{
    class GestionBoutique
    {
        #region champs statiques
        public static MySqlConnection Cnx = new MySqlConnection();
        public static MySqlCommand Cmd = new MySqlCommand();
        public static MySqlDataAdapter DataAdapt = new MySqlDataAdapter();
        public static DataSet MonDataSet = new DataSet();
        public static string maChaine;
        public static int cptvue = 0;
        #endregion

        #region méthodes statiques
        public static void seConnecter(string login, string mdp)
        {
            ConnectionInfo cnxInfo = new ConnectionInfo("ent.btssio.net", "paulsalban", new PasswordAuthenticationMethod("paulsalban", "sa59s"));
            MySqlConnectionStringBuilder cnxBld = new MySqlConnectionStringBuilder();
            cnxBld.AllowBatch = true;
            cnxBld.Server = "localhost";
            cnxBld.Database = "paulsalban1";
            cnxBld.UserID = login;
            cnxBld.Password = mdp;

            SshClient sshClient = new SshClient(cnxInfo);
            ForwardedPortLocal port = new ForwardedPortLocal("127.0.0.1", 0, "127.0.0.1", 3306);
            sshClient.Connect();
            sshClient.AddForwardedPort(port);
            port.Start();
            cnxBld.Port = port.BoundPort;
            try
            {
                if (Cnx.State == ConnectionState.Open)
                {
                    Cnx.Close();
                }
                maChaine = cnxBld.ConnectionString;
                Cnx.ConnectionString = maChaine;
                Cnx.Open();
                MonDataSet = new DataSet("CommergnatPPE2");
                MonDataSet.Clear();
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = Cnx;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur... Contacter votre Administrateur Système : " + ex.Message);
            }
        }
        public static int GenererClePrimaire(string nomcle,string nomtable)
        {
            Cmd.CommandText = "SELECT Max(" + nomcle + ") FROM " + nomtable;
            DataAdapt.SelectCommand = Cmd;
            return Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
        }

        public static string GetStringFromTable(string request)
        {
            Cmd.CommandText = request;
            DataAdapt.SelectCommand = Cmd;
            return Cmd.ExecuteScalar().ToString();
        }
        public static DataTable ExecuterRequeteSelect(string marequeteselect)
        {
            DataTable result;
            string MaVue = "MaVue" + cptvue;
            try
            {
                Cmd.CommandText = marequeteselect;
                DataAdapt.SelectCommand = Cmd;
                DataAdapt.Fill(MonDataSet, MaVue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            result = MonDataSet.Tables[MaVue];
            cptvue = cptvue + 1;
            return result;
        }   
            
        public static DataTable getLesTuplesByRequete(string texteRequete, string nomJeuDonnees)
        {
            GestionBoutique.Cmd.CommandText = texteRequete;
            GestionBoutique.DataAdapt.SelectCommand = GestionBoutique.Cmd;
            GestionBoutique.DataAdapt.Fill(GestionBoutique.MonDataSet, nomJeuDonnees );
            return GestionBoutique.MonDataSet.Tables[ nomJeuDonnees ];
        }

        public static Boolean VerificationTableVide(DataTable matable)
        {
            return (matable.Rows.Count != 0);
        }
        public static void Executer_Requete_Action(string marequeteaction)
        {
            try
            {
                Cmd.CommandText = marequeteaction;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Requête Action Correctement Exécutée...!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur dans la tentative d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }    
        #endregion
    }
}
