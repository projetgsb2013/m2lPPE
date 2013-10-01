using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    public partial class menuGrade0 : Form
    {
        public menuGrade0()
        {
            InitializeComponent();
        }

        private void buttDemanderService_Click(object sender, EventArgs e)
        {
            this.Size=new Size(500,500);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void menuGrade0_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet2.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter2.Fill(this.m2l_Marco_SalimDataSet2.typeService);
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet1.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter1.Fill(this.m2l_Marco_SalimDataSet1.typeService);
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet.typeService'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeServiceTableAdapter.Fill(this.m2l_Marco_SalimDataSet.typeService);

        }
    }
}
