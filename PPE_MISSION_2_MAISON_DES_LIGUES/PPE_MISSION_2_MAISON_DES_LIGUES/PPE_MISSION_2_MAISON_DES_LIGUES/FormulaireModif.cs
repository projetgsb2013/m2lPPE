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
    public partial class FormulaireModif : Form
    {
        private int idService;
        private int idEtat;
        private DataGridView tableau;

        public FormulaireModif()
        {
            InitializeComponent();
        }
        public FormulaireModif(int idServ,int pIdEtat,DataGridView pTableau)
        {
            idService = idServ;
            idEtat = pIdEtat;
            tableau = pTableau;
            InitializeComponent();
        }

        private void FormulaireModif_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet4.etat'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.etatTableAdapter.Fill(this.m2l_Marco_SalimDataSet4.etat);
            ServiceDemandeDAO unService = new ServiceDemandeDAO();

            if (idEtat == 0)
            {
                label1.Text="Validé ?";
            }
            if (idEtat == 1)
            {
                label1.Text = "Realise ?";
            }
            if (idEtat == 2)
            {
                label1.Text = "Facturé ?";
            }
            if (idEtat == 3)
            {
                label1.Text = "Service Déjà Facturé";
                buttValiderChangement.Hide();
            }
        }

        private void buttValiderChangement_Click_1(object sender, EventArgs e)
        {
           // int unEtat =Convert.ToInt16(comboChangement.SelectedValue);
            if (idEtat == 0)
            {
                ServiceDemandeDAO mettreAjour = new ServiceDemandeDAO();
                mettreAjour.update(idService, 1);
                tableau.Rows.Clear();
                mettreAjour.find(tableau);
                this.Close();
                MessageBox.Show("Vous ne pouvez pas passe en mode demandé un service déjà realisé");
            }

            if (idEtat == 1)
            {
                ServiceDemandeDAO mettreAjour = new ServiceDemandeDAO();
                mettreAjour.update(idService, 2);
                tableau.Rows.Clear();
                mettreAjour.find(tableau);
                this.Close();
            }

            if (idEtat == 2)
            {
                ServiceDemandeDAO mettreAjour = new ServiceDemandeDAO();
                mettreAjour.update(idService, 3);
                tableau.Rows.Clear();
                mettreAjour.find(tableau);
                this.Close();
            }


            else
            {


            }

        }

        private void comboChangement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void etatBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void labelChangement_Click(object sender, EventArgs e)
        {

        }

       
    }
}
