using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.PdfWriter;
using System.IO;


namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    public partial class Facture : Form
    {
        ServiceDemandeDAO factureEditer = new ServiceDemandeDAO();
        int ligue;
        int mois;
        int annee;
        String uneLigue;
        public Facture()
        {
            InitializeComponent();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'm2l_Marco_SalimDataSet5.ligue'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ligueTableAdapter.Fill(this.m2l_Marco_SalimDataSet5.ligue);
            for (int i = 0; i < 12; i++)
            {
                DateTime date = new DateTime(2002, i + 1, 2); // DATE AU HASARD SAUF POUR LE MOIS
                comboMois.Items.Insert(i, date.ToString("MMMM"));
                comboMois.SelectedIndex = 0;
            }
            factureEditer.remplirCombo(comboAnnee);
            LigueDAO uneLigue = new LigueDAO();
            uneLigue.readLesLigues(comboBox1);

        }

        private void comboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        private void comboAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiserTableauFacture();
        }

        public void actualiserTableauFacture()
        {
            uneLigue = Convert.ToString(comboBox1.SelectedItem);
            mois = comboMois.SelectedIndex + 1;
            annee = Convert.ToInt16(comboAnnee.SelectedItem);
            dataGridView1.Rows.Clear();
            factureEditer.factureEdit(dataGridView1, mois, annee, uneLigue);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Document doc1 = new Document();

            //string path = Server.MapPath("PDFs");

            PdfWriter.GetInstance(doc1, new FileStream("Doc3.pdf", FileMode.Create));

            doc1.Open();

            Paragraph unParagraphe = new Paragraph("Ceci est la liste de factures");

            doc1.Add(unParagraphe);

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            PdfPCell cellule = null;

            for(int i=0;i<dataGridView1.Columns.Count;i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
            }

            table.HeaderRows = 1;


            for(int k = 0 ; k<dataGridView1.Rows.Count;k++)
            {
                for(int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    if(dataGridView1[j,k].Value !=null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j,k].Value.ToString()));
                    }
                }
            }

                
             
        
            




                doc1.Add(table);


                doc1.Close();
            }
        }
    }


       