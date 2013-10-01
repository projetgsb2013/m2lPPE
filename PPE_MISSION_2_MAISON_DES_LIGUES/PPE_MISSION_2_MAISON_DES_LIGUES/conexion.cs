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
    public partial class conexion : Form
    {
        public conexion()
        {
            InitializeComponent();
            
        }

        private void buttConexion_Click(object sender, EventArgs e)
        {
            adherentDAO verif = new adherentDAO();
            verif.verifUtilisateur(textID.Text,textMdp.Text);
        }        
    }
}
