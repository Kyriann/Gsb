using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gsb
{
    public partial class VoirRapportVisiteVisiteur : Form
    {
        private MySqlConnection connection;
        private string login;



        public VoirRapportVisiteVisiteur(string log)
        {
            InitializeComponent();
            this.InitConnexion();
            login = log;

        }
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connection = "SERVER=localhost; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";
            this.connection = new MySqlConnection(connection);
        }


        private void VoirRapportVisiteVisiteur_Load(object sender, EventArgs e)
        {
            date_debutDate.Hide();
            date_finDate.Hide();
            date_finDate.Value = DateTime.Now.AddDays(1);

            t_visiteur.Enabled = false;
            l_nom.Hide();
            l_prenom.Hide();
            l_numVisiteur.Hide();





            connection.Open();
            MySqlCommand SelectCommand = new MySqlCommand("select concat(col_nom,' ',col_prenom) from collaborateur where col_nom=" + "'" + login + "'" + ";", connection);

            MySqlDataReader myReader;

            myReader = SelectCommand.ExecuteReader();

            while (myReader.Read())
            {
                t_visiteur.Text = myReader[0].ToString();
            }
            connection.Close();


            char[] splitters = new char[] { ' ' };
            string[] laCase = t_visiteur.Text.Split(splitters);
            l_nom.Text = (laCase[0]);
            l_prenom.Text = (laCase[1]);



            connection.Open();
            MySqlCommand SelectCommand2 = new MySqlCommand("select col_matricule from collaborateur where col_nom=" + "'" + laCase[0] + "'" + ";", connection);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            while (myReader2.Read())
            {
                l_numVisiteur.Text = myReader2.GetString(0);


            }
            connection.Close();

            connection.Open();
            MySqlCommand SelectCommand3 = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            while (myReader3.Read())
            {
                c_numRapport.Items.Add(myReader3[0]);
            }

            connection.Close();









        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void c_numRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            e_detailsPraticien.Clear();

            connection.Open();
            MySqlCommand SelectCommand4 = new MySqlCommand("select rap_date,rap_bilan,rap_motif from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "AND rap_num=" + "'" + c_numRapport.Text + "'" + ";", connection);
            MySqlDataReader myReader4;
            myReader4 = SelectCommand4.ExecuteReader();
            while (myReader4.Read())
            {
                l_date.Text = myReader4["rap_date"].ToString();
                DateTime datefin = DateTime.Parse(l_date.Text);
                l_date.Text = datefin.ToString("dd-MM-yyyy");
                l_bilan.Text = myReader4["rap_bilan"].ToString();
                l_motif.Text = myReader4["rap_motif"].ToString();
            }

            connection.Close();


            connection.Open();
            MySqlCommand SelectCommand7 = new MySqlCommand("select CONCAT(pra_nom,' ',pra_prenom) from praticien INNER JOIN rapport_visite on praticien.PRA_NUM = rapport_visite.PRA_NUM where rapport_visite.rap_num =" + "'" + c_numRapport.Text + "'" + "AND col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);
            MySqlDataReader myReader7;
            myReader7 = SelectCommand7.ExecuteReader();
            while (myReader7.Read())
            {
                l_nomPrenomPraticien.Text = myReader7.GetString(0);
            }

            connection.Close();

            connection.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter("SELECT MED_DEPOTLEGAL AS Medicaments,OFF_QTE AS Quantite from offrir INNER JOIN rapport_visite on offrir.VIS_MATRICULE=rapport_visite.COL_MATRICULE where col_matricule=" + "'" + l_numVisiteur.Text + "'" + "; ", connection);
            DataSet DS = new DataSet();
            MyDA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];


            connection.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_details_Click(object sender, EventArgs e)
        {

            if (l_nomPrenomPraticien.Text != "")
            {
                string nomprafin;
                nomprafin = l_nomPrenomPraticien.Text;
                DetailsPraticien DP2 = new DetailsPraticien(nomprafin);
                DP2.Show();

            }
            else if (string.IsNullOrWhiteSpace(l_nomPrenomPraticien.Text))
            {
                e_detailsPraticien.SetError(b_details, "Pas de praticien choisi");
            }

        }

        private void b_retour_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selection S3 = new Selection(login, "", "visiteur");
            S3.Show();
            this.Hide();
        }

        private void b_supprimer_Click(object sender, EventArgs e)
        {

        }
        private void check_entre2Dates_CheckedChanged(object sender, EventArgs e)
        {
           
            if (check_entre2Dates.Checked)
            {
                
                date_debutDate.Show();
                date_finDate.Show();

                c_numRapport.Items.Clear();

                e_detailsPraticien.Clear();


                l_motif.Text = "";
                l_bilan.Text = "";

                l_date.Text = "";
                l_nomPrenomPraticien.Text = "";

                if (this.dataGridView1.DataSource != null)
                {
                    this.dataGridView1.DataSource = null;
                }
                else
                {
                    this.dataGridView1.Rows.Clear();
                }

            }
            else
            {
                date_debutDate.Hide();
                date_finDate.Hide();

                e_detailsPraticien.Clear();


                l_motif.Text = "";
                l_bilan.Text = "";

                c_numRapport.Items.Clear();

                l_date.Text = "";
                l_nomPrenomPraticien.Text = "";

                if (this.dataGridView1.DataSource != null)
                {
                    this.dataGridView1.DataSource = null;
                }
                else
                {
                    this.dataGridView1.Rows.Clear();
                }


                try
                {
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {

                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void date_finDate_ValueChanged(object sender, EventArgs e)
        {
            if (date_finDate.Value < date_debutDate.Value)
            {
                date_finDate.Value = DateTime.Now;
                MessageBox.Show("La deuxième date ne peut pas avant la première date");
            }
            else
            {
                try
                {

                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + "AND col_matricule=" + "'" + l_numVisiteur.Text + "'" + ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        private void date_debutDate_ValueChanged(object sender, EventArgs e)
        {


            if (date_debutDate.Value > date_finDate.Value)
            {
                date_debutDate.Value = DateTime.Now;
                MessageBox.Show("La première date ne peut pas après la deuxiéme date");
            }
            else
            {
                try
                {

                    string date_debutstr, date_finstr;
                    date_debutstr = date_debutDate.Value.ToString("yyyy-MM-dd");
                    date_finstr = date_finDate.Value.ToString("yyyy-MM-dd");
                    connection.Open();
                    MySqlCommand SelectCommand = new MySqlCommand("select rap_num from rapport_visite where RAP_DATE BETWEEN" + "'" + date_debutstr + "'" + " AND " + "'" + date_finstr + "'" + "AND col_matricule=" +"'"+l_numVisiteur.Text+"'"+ ";", connection);

                    MySqlDataReader myReader;

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        c_numRapport.Items.Add(myReader[0]);
                    }
                    connection.Close();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

