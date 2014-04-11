using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    class ServiceDemandeDAO
    {
        public Boolean create(int idAdherent , int idService, string dateDemande,string heure,string min)
        {

            string[] split = dateDemande.Split(new Char[] { ' ' });
            string date = split[0];
            string newDate = date + " " + heure + ":" + min;
            SqlCommand maRequete,maRequete2;
            
            string sqlStr = "INSERT INTO serviceDemande (idAdherent, idService, dateDemande) VALUES("+idAdherent+","+idService+",'"+newDate+"')";
            string sqlStr2 = "SELECT count(*) as nb FROM serviceDemande WHERE idAdherent='" + idAdherent + "' and idService='" + idService + "' and dateDemande='" +newDate+ "'";
            string connStr = "Data Source=TRAVAIL-PC\\SQLEXPRESS;Initial Catalog=m2l_marco_salim_local;Integrated Security=True";
            SqlConnection maConnexion;
            try
            {
               maConnexion = new SqlConnection();
               maConnexion.ConnectionString = connStr;
               maConnexion.Open();

               
               maRequete2 = new SqlCommand(sqlStr2, maConnexion);
               maRequete2.CommandType = CommandType.Text;
               SqlDataReader unJeuResultat2 = maRequete2.ExecuteReader();
               int maRecup=0;
               while (unJeuResultat2.Read())
               {
                   int maVariable = (int)unJeuResultat2["nb"];
                   maRecup = maVariable;
               }
                   if (maRecup > 0)
                   {
                       MessageBox.Show("Service Deja Demandé, il y'en a deja"+maRecup);
                   }

                   else
                   {
                       unJeuResultat2.Close();
                       maRequete = new SqlCommand(sqlStr, maConnexion);
                       maRequete.ExecuteNonQuery();
                       MessageBox.Show("Bien déroulé");
                   }
               
                  // MessageBox.Show(maVariable.ToString());
                   
                   
               

               
            }
            catch (Exception e)
            {

            }
            return true;
        }

        public DataGridView find(DataGridView pTableau)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT adherent.nomAdherent, etat.libelleEtat, etat.id AS idEtat, typeService.libelleService, typeService.prix, serviceDemande.dateDemande, serviceDemande.id AS idServiceDemande, adherent.id AS Expr1, etat.id AS Expr2, typeService.id AS Expr3 FROM serviceDemande INNER JOIN adherent ON serviceDemande.idAdherent = adherent.id INNER JOIN etat ON serviceDemande.idEtat = etat.id INNER JOIN typeService ON serviceDemande.idService = typeService.id ORDER BY serviceDemande.dateDemande DESC";
            string connStr = "Data Source=TRAVAIL-PC\\SQLEXPRESS;Initial Catalog=m2l_marco_salim_local;Integrated Security=True";
            SqlConnection maConnexion;
            try
            {

                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                while (unJeuResultat.Read()) // lecture d’une ligne
                {
                    //MessageBox.Show("toto");
                    pTableau.Rows.Add((string)unJeuResultat["nomAdherent"], (string)unJeuResultat["libelleEtat"], (string)unJeuResultat["libelleService"], (string)unJeuResultat["prix"], (DateTime)unJeuResultat["dateDemande"], (int)unJeuResultat["Expr3"], (int)unJeuResultat["Expr1"], (int)unJeuResultat["idServiceDemande"], (int)unJeuResultat["idEtat"]);
                }

            }
            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return pTableau;
        }

        public Boolean update(int idSericedemande,int idEtat)
        {
            
            SqlCommand maRequete;
            string sqlStr = "UPDATE serviceDemande SET idEtat = "+idEtat+" WHERE (id = "+idSericedemande+")";
            string connStr = "Data Source=TRAVAIL-PC\\SQLEXPRESS;Initial Catalog=m2l_marco_salim_local;Integrated Security=True";
            SqlConnection maConnexion;
            try
            {
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;

                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            return true;
        }

        public DataGridView factureEdit(DataGridView pTableau,int mois,int annee,String nomLigue)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT ligue.id AS idLigue, ligue.libelleLigue AS nomLigue, adherent.nomAdherent, etat.libelleEtat, typeService.libelleService, typeService.prix, serviceDemande.dateDemande FROM adherent INNER JOIN serviceDemande ON adherent.id = serviceDemande.idAdherent INNER JOIN typeService ON serviceDemande.idService = typeService.id INNER JOIN ligue ON adherent.idLigue = ligue.id INNER JOIN etat ON serviceDemande.idEtat = etat.id WHERE (MONTH(serviceDemande.dateDemande) = " + mois + ") AND (etat.id = 1) AND (YEAR(serviceDemande.dateDemande) = " + annee + ") and ligue.libelleLigue='"+nomLigue+"'";
            string connStr = "Data Source=TRAVAIL-PC\\SQLEXPRESS;Initial Catalog=m2l_marco_salim_local;Integrated Security=True";
            SqlConnection maConnexion;
            try
            {

                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                bool bReturn = unJeuResultat.Read();
                while (bReturn) // lecture d’une ligne
                {
                    double total = 0;
                    int idLigue = (int)unJeuResultat["idLigue"];
                    while (bReturn==true && (int)unJeuResultat["idLigue"] == idLigue)
                    {
                        pTableau.Rows.Add((string)unJeuResultat["nomLigue"], (string)unJeuResultat["nomAdherent"], (string)unJeuResultat["libelleEtat"], (string)unJeuResultat["libelleService"], (string)unJeuResultat["prix"]);
                        total += Convert.ToDouble((string)unJeuResultat["prix"]);
                        bReturn = unJeuResultat.Read();
                        
                    }
                    pTableau.Rows.Add("", "", "", "", total);
                    pTableau.Rows.Add();
                }
            }
            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return pTableau;
        }

        public ComboBox remplirCombo(ComboBox cmbAnne)
        {
            SqlCommand maRequete;
            string sqlStr = "SELECT DISTINCT YEAR(dateDemande) AS annee FROM serviceDemande";
            string connStr = "Data Source=TRAVAIL-PC\\SQLEXPRESS;Initial Catalog=m2l_marco_salim_local;Integrated Security=True";
            SqlConnection maConnexion;
            try
            {
                int i = 0;
                int annee;
                maConnexion = new SqlConnection();
                maConnexion.ConnectionString = connStr;
                maConnexion.Open();

                maRequete = new SqlCommand(sqlStr, maConnexion);
                maRequete.CommandType = CommandType.Text;
                SqlDataReader unJeuResultat = maRequete.ExecuteReader();
                while (unJeuResultat.Read()) // lecture d’une ligne
                {
                    annee = (int)unJeuResultat["annee"];
                    cmbAnne.Items.Insert(i,annee);
                    cmbAnne.SelectedIndex = i;
                    i++;
                    
                }

            }
            catch (Exception e) // Try … catch permet la gestion des erreurs.
            {

            }
            return cmbAnne;
        }

        /*public Boolean updateServiceDemande(int idEtatService)
        {


        }*/
    }
}
