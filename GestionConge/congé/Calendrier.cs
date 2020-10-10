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


namespace congé
{
    public partial class Calendrier : Form
    {

        public Acceuil _acceuil;
        public  Grille calendries;
       

        public Calendrier(Acceuil _acceuil_)
        {
            _acceuil = _acceuil_;
            InitializeComponent();
           
            //calendrier
            calendries = new Grille(this,null, 7, 6, new Point(60,200), 240, 100);
            calendries.Show();
        }

        private void Calendrier_Load(object sender, EventArgs e)
        {
            
           

        }

        public void remplire_ListeBoxCalendrier()
        {
            //base de donnée 
            try
            {
                _acceuil.sqlCon.Open();

                SqlDataAdapter RequeteC = new SqlDataAdapter("Select * from DureeConge order by DateDebut", _acceuil.sqlCon);
                DataTable DureeConges = new DataTable();
                RequeteC.Fill(DureeConges);
                //remplissage calendriers
                //version 1
               
                    calendries.ListClear();
                    for (int i = 0; i < DureeConges.Rows.Count; i++)
                    {
                        object dateDebutC = DureeConges.Rows[i].ItemArray[2];
                        object dateFinC = DureeConges.Rows[i].ItemArray[3];
                        object CINTable = DureeConges.Rows[i].ItemArray[1];
                        try
                        {
                            DateTime dateDebut = DateTime.Parse(dateDebutC.ToString());
                            DateTime dateFin = DateTime.Parse(dateFinC.ToString());
                            string CIN = CINTable.ToString();

                            SqlDataAdapter RequeteE = new SqlDataAdapter("Select nom,prenom from Employe where cin='" + CIN + "'", _acceuil.sqlCon);
                            DataTable Employe = new DataTable();
                            RequeteE.Fill(Employe);
                            //nom et prenom
                            object nomEmploye = Employe.Rows[0].ItemArray[0];
                            object prenomEmploye = Employe.Rows[0].ItemArray[1];
                            int len = nomEmploye.ToString().Length;
                            calendries.remplireListeBox(dateDebut, dateFin, nomEmploye.ToString() + " " + prenomEmploye.ToString());
                        }
                        catch (SqlException)
                        {
                            _acceuil.sqlCon.Close();
                            MessageBox.Show("Erreur dans la table Conge !");

                        }
                    }

                _acceuil.sqlCon.Close();

            }
            catch (SqlException)
            {
                _acceuil.sqlCon.Close();
                MessageBox.Show("Erreur 1 : de connexion avec la base de donnée", "Erreur");

            }
        }

        private void Calendrier_Shown(object sender, EventArgs e)
        {
           calendries.updateDay();
            remplire_ListeBoxCalendrier();
        }
        public void buttonForward_Click(object sender, EventArgs e)
        {
           
                calendries.nextMois();
                calendries.updateDay();
            remplire_ListeBoxCalendrier();

        }

        public void buttonBack_Click(object sender, EventArgs e)
        {
                calendries.lastMois();
                calendries.updateDay();
                remplire_ListeBoxCalendrier();
        }
        public void comboBoxMois_Click(object sender, EventArgs e)
        {
                calendries.mois = calendries.comboBoxMois.SelectedIndex + 1;
                calendries.updateDay();
                remplire_ListeBoxCalendrier();
        }

        public void comboBoxYear_Click(object sender, EventArgs e)
        { 
                calendries.year = (int)calendries.comboBoxYear.SelectedItem;
                calendries.updateDay();
                remplire_ListeBoxCalendrier(); 
        }
        public void buttonAujour_Click(object sender, EventArgs e)
        {
                calendries.Aujour();
                calendries.updateDay();
                remplire_ListeBoxCalendrier();
        }

        
    }
}
