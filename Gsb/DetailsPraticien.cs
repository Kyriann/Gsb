﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gsb
{
    public partial class DetailsPraticien : Form
    {
        private MySqlConnection connection;

        string NomPraFin;

        public DetailsPraticien(string nomprafin)
        {
            InitializeComponent();
            this.InitConnexion();

            NomPraFin = nomprafin;
        }
        public void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connection = "SERVER=localhost; DATABASE=applicationppe; UID=root; PASSWORD=;SslMode=none";
            this.connection = new MySqlConnection(connection);
        }
    private void DetailsPraticien_Load(object sender, EventArgs e)
        {

            

            char[] splitters = new char[] { ' ' };
            string[] laCase = NomPraFin.Split(splitters);
            t_nom.Text = (laCase[0]);
            t_prenom.Text = (laCase[1]);
            t_nom.Enabled = false;
            t_prenom.Enabled = false;
            t_coefNotoriete.Enabled = false;



            connection.Open();
            MySqlCommand SelectCommand4 = new MySqlCommand("select pra_ville,pra_adresse,pra_cp,pra_coefnotoriete from praticien where pra_nom=" + "'" + t_nom.Text + "'" + "AND pra_prenom=" + "'" + t_prenom.Text + "'" + ";", connection);
            MySqlDataReader myReader4; 
            myReader4 = SelectCommand4.ExecuteReader();
            while (myReader4.Read())
            {
                t_ville.Text = myReader4["pra_ville"].ToString();
                t_codePostal.Text = myReader4["pra_cp"].ToString();
                t_coefNotoriete.Text = myReader4["pra_coefnotoriete"].ToString();
                t_adresse.Text = myReader4["pra_adresse"].ToString();
            }
            connection.Close();


            connection.Open();
            MySqlCommand SelectCommand6 = new MySqlCommand("select DISTINCT CONCAT(praticien.typ_code,' ',typ_libelle) from type_praticien INNER JOIN praticien on type_praticien.typ_code=praticien.typ_code" + ";", connection);
            MySqlDataReader myReader6;
            myReader6 = SelectCommand6.ExecuteReader();
            while (myReader6.Read())
            {
                c_typePraticien.Items.Add(myReader6[0]);
            }
            connection.Close();

            connection.Open();
            MySqlCommand SelectCommand7 = new MySqlCommand("select CONCAT(praticien.typ_code,' ',typ_libelle) from type_praticien INNER JOIN praticien on type_praticien.typ_code=praticien.typ_code where pra_nom=" + "'" + t_nom.Text + "'" + "AND pra_prenom=" + "'" + t_prenom.Text + "'" + ";", connection);
            MySqlDataReader myReader7;
            myReader7 = SelectCommand7.ExecuteReader();
            while (myReader7.Read())
            {
                c_typePraticien.Text = myReader7.GetString(0);
            }
            connection.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_adresse.Text))
            {
                e_adresse.SetError(t_adresse, "Le champ adresse n'est pas complet");
            }
            if (string.IsNullOrWhiteSpace(t_codePostal.Text))
            {
                e_codePostal.SetError(t_codePostal, "Le champ code postal n'est pas complet");
            }
            if (string.IsNullOrWhiteSpace(t_ville.Text))
            {
                e_ville.SetError(t_ville, "Le champ ville n'est pas complet");
            }
            if (!string.IsNullOrWhiteSpace(t_ville.Text) & !string.IsNullOrWhiteSpace(t_adresse.Text) & !string.IsNullOrWhiteSpace(t_codePostal.Text))
            {
                connection.Open();

                char[] splitters = new char[] { ' ' };
                string[] laCase = c_typePraticien.Text.Split(splitters);

                MySqlCommand SelectCommand8 = new MySqlCommand("update praticien SET pra_adresse=" + "'" + t_adresse.Text + "'" + ",pra_cp=" + "'" + t_codePostal.Text + "'" + ",pra_ville=" + "'" + t_ville.Text + "'" + ",typ_code=" + "'" + laCase[0] + "'" + "Where pra_nom=" + "'" + t_nom.Text + "'" + "AND pra_prenom=" + "'" + t_prenom.Text + "'" + ";", connection);
                SelectCommand8.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }


            

        }

        private void t_codePostal_TextChanged(object sender, EventArgs e)
        {
            e_codePostal.Clear();
        }

        private void t_ville_TextChanged(object sender, EventArgs e)
        {
            e_ville.Clear();
        }

        private void t_adresse_TextChanged(object sender, EventArgs e)
        {
            e_adresse.Clear();
        }
    }
}
