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
    class LigueDAO
    {
        public ComboBox readLesLigues(ComboBox pCombo)
        {

            SqlCommand maRequete;
            string sqlStr = "SELECT libelleLigue FROM ligue";
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
                String maRecup;
                int i=0;
                while (unJeuResultat.Read())
                {
                    maRecup = (string)unJeuResultat["libelleLigue"];
                    pCombo.Items.Insert(i,maRecup);

                }


            }
            catch (Exception e)
            {

            }
            return pCombo;
        }
    
    
    }
}
