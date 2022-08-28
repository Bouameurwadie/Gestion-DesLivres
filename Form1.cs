using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AdoNet_V3
{
    public partial class Form1 : Form
    {
       
       SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=Projet_GS;Integrated Security=true;");
       SqlCommand cmd = new SqlCommand();
       SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void actualiser()  //Hakka Fonction wla Code Ghadi yb9a Yt3aoud Kandirha f blassa waheda  
        {          
            dgv.Rows.Clear();//Ykon Datagridview Khouia
            cnx.Open();//Dima Katkon conexion f departe otesliha b close f Kol Button 
            cmd.Connection = cnx;
            cmd.CommandText = "select * from tblGS";//Ki Ymashi Ychof wash Kain table f dik  database 
            dr = cmd.ExecuteReader();
            while (dr.Read())//yajib database l Datagridview 
            {
                dgv.Rows.Add(dr[0],dr[1], dr[2], dr[3], dr[4]);              
            }
            dr.Close();
            cnx.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {   
            //Code Btn Ajoutée
            cnx.Open();
            cmd = new SqlCommand("insert into tblGS values('" + txtID.Text+"', '"+txtNom.Text + "','" + txtAuteur.Text + "', '" + txtnbrpage.Text + "','" + txtprix.Text + "')", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Bien Ajouter");
            actualiser();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dgv_Click(object sender, EventArgs e)
        {  //Hada Code Dyal fash Ila clik 3la wahed Men li 3andi f dgv Ytla3 lia F mektoubin f textBox Bash Momkin Modifié
            if (dgv.SelectedRows.Count > 0)
            {
                txtID.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txtNom.Text= dgv.SelectedRows[0].Cells[1].Value.ToString();
                txtAuteur.Text=dgv.SelectedRows[0].Cells[2].Value.ToString();
                txtnbrpage.Text=dgv.SelectedRows[0].Cells[3].Value.ToString();
                txtprix.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete tblGS where ID = " + txtID.Text, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();

            //hakka Kifash Kona Kanktebo Message Yak :
            //MessageBox.Show("Bien supprimer");
            //9a3ida kifash Katkteb Methoude
            //MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            //Exemple Et  MessageBoxButtons o MessageBoxIcon Fihom bzaf Les Type :
            MessageBox.Show("Bien supprimer", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            actualiser();
            txtID.Text = ""; //TextBox Touli Khaouia Apres Fash Ymes7 dik Numero 
        }

        private void btn_Modification_Click(object sender, EventArgs e)
        {
            //Fonction ila baghit Nedir haja Matzouch hta Ya3mero Les champs Kamlin 3ad yamshio ldatabase
            if (txtID.Text == "" || txtAuteur.Text == "" || txtNom.Text == "" || txtprix.Text == "" || txtnbrpage.Text == "")
            {
                MessageBox.Show("Remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cnx.Open();
                cmd = new SqlCommand("update tblGS set Nom = '" + txtNom.Text+"', Auteur = '"+txtAuteur.Text+ "', nbrPage = '" + txtnbrpage.Text + "', Prix = '" + txtprix.Text + "' where ID='" + txtID.Text + "'", cnx);
                cmd.ExecuteNonQuery();
                cnx.Close();
               
                MessageBox.Show("Bien Modifier", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualiser();
                txtID.Text = "";
                txtNom.Text = "";
                txtAuteur.Text = "";
                txtnbrpage.Text = "";
                txtprix.Text = "";
            }
        }

        //Netaakddo Rechercher par Id:(nchofoh wach kayn f la base o Ytle3 lina f dgv)
        public bool Test()
        {
            bool e = false;
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from tblGS where ID='" + txtID.Text + "'", cnx);
            SqlDataReader RD = cmd.ExecuteReader();
            if (RD.HasRows == true)
            {
                e = true;
            }
            RD.Close();
            cnx.Close();
            return e;

        }

        private void btn_RECHERCHER_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Entrez le ID !");
            }
            else if (Test() == false)//3ayt Fonction Nechof wash dak ID deja kain f database 
            {
                MessageBox.Show("ID n'exciste Pas!");
            }
            else
            {
                dgv.Rows.Clear();//Ykon Datagridview Khouia
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from tblGS where ID='" + txtID.Text + "'", cnx);
                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    //3lash Bdelt dr b DR hit deja medclarie b dr okhedam biha f wahed code lfo9 dakchi 3lash maytkhaltouch code oylta3 lia error
                    dgv.Rows.Add(DR[0], DR[1], DR[2], DR[3], DR[4]);
                }
                DR.Close();
                cnx.Close();
                txtID.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }
    
    }
}
