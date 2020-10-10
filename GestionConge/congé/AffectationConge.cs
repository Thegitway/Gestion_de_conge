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
using System.ComponentModel.Design;

namespace congé
{
    public partial class AffectationConge : Form
    {

        private int marginBottomForm = 200;
        public  Acceuil _acceuil;
        Point PointCalendrier;
        int nextID = 0;
        public int resolution = 0;
        Grille calenAffect;
       //Acceuil _acceuil_;
        public AffectationConge(Acceuil _acceuil_)
        {
            InitializeComponent();
            _acceuil = _acceuil_;
            // Affectation
            //date Debut
            labelDateDebut.Location = new Point(this.Width / 5 - labelDateDebut.Width-30, marginBottomForm + 100);
            dateTimePickerDateDebut.Location = new Point(this.Width / 4, marginBottomForm + 100);
            labelDateDebut.Show();
            dateTimePickerDateDebut.Show();
            //Date Fin
            labelDateFin.Location = new Point(this.Width / 5 - labelDateFin.Width-30, marginBottomForm + 100 + 50);
            dateTimePickerDateFin.Location = new Point(this.Width / 4-03, marginBottomForm + 100 + 50);
            labelDateFin.Show();
            dateTimePickerDateFin.Show();
            //button
            buttonValider.Location = new Point(this.Width / 4 - buttonValider.Width-30, marginBottomForm + 50 + 50 * 4);
            buttonValider.Show();
            //annuler
            buttonAnnuler.Location = new Point(this.Width / 4 + buttonValider.Width-30, marginBottomForm + 50 + 50 * 4);
            buttonAnnuler.Show();

            PointCalendrier = new Point(this.Width / 2, this.Height / 4);
            //calendrier //160 //110
            calenAffect = new Grille(null,this, 7, 6, PointCalendrier, (1920-200 - PointCalendrier.X) / 7, (1080-240 - PointCalendrier.Y) / 5 - 22);

            calenAffect.Show();

            //button X
            buttonX.Location = new Point(this.Width-buttonX.Width,20);

        }

        private void AffectationConge_Load(object sender, EventArgs e)
        {  
            remplire_ListeBoxCalendrier();
        }

        public void remplire_ListeBoxCalendrier()
        {
            //base de donnée 
            try
            {
                _acceuil.sqlCon.Open();

                SqlDataAdapter RequeteC = new SqlDataAdapter("Select * from DureeConge order by ID", _acceuil.sqlCon);
                DataTable DureeConges = new DataTable();
                RequeteC.Fill(DureeConges);
                //remplissage calendriers
             

                
                    calenAffect.ListClear();
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
                            calenAffect.remplireListeBox(dateDebut, dateFin, nomEmploye.ToString() + " " + prenomEmploye.ToString());

                        }
                        catch (SqlException)
                        {
                            _acceuil.sqlCon.Close();
                            MessageBox.Show("Erreur dans la table Conge !");

                        }
                    
                }


                //Calcule de ID
                if (DureeConges.Rows.Count > 0)
                {
                    nextID = 0;
                    nextID = int.Parse(DureeConges.Rows[DureeConges.Rows.Count-1].ItemArray[0].ToString());
                    nextID++;
                    
                }
                else
                    nextID = 1;

                _acceuil.sqlCon.Close();

            }
            catch (SqlException)
            {
                _acceuil.sqlCon.Close();
                MessageBox.Show("Erreur 1 : de connexion avec la base de donnée", "Erreur");

            }
        }

       

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            _acceuil._employes.Employe_update();
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);
        }

        public void buttonForward_Click(object sender, EventArgs e)
        {
            calenAffect.nextMois();
            calenAffect.updateDay();
            remplire_ListeBoxCalendrier();
        }

        public void buttonBack_Click(object sender, EventArgs e)
        {
            calenAffect.lastMois();
            calenAffect.updateDay();
            remplire_ListeBoxCalendrier();
        }
        public void comboBoxMois_Click(object sender, EventArgs e)
        {
            calenAffect.mois = calenAffect.comboBoxMois.SelectedIndex + 1;
            calenAffect.updateDay();
            remplire_ListeBoxCalendrier();
        }
        public void comboBoxYear_Click(object sender, EventArgs e)
        {
            calenAffect.year = (int)calenAffect.comboBoxYear.SelectedItem;
            calenAffect.updateDay();
            remplire_ListeBoxCalendrier();
        }
        public void buttonAujour_Click(object sender, EventArgs e)
        {
            calenAffect.Aujour();
            calenAffect.updateDay();
            remplire_ListeBoxCalendrier();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (dateTimePickerDateDebut.Text.Length != 0
            && dateTimePickerDateFin.Text.Length != 0)
            {
                if (dateTimePickerDateDebut.Value.CompareTo(dateTimePickerDateFin.Value) <= 0)
                {
                    //base de donnée Enregistrer les donne
                    try
                    {

                        _acceuil.sqlCon.Open();

                        string query = "INSERT INTO DureeConge Values" +
                            "('"
                            + nextID + "','"
                            + _acceuil._modifier.textBoxCIN.Text + "','"
                            + dateTimePickerDateDebut.Value.ToString("yyyy-MM-dd") + "','"
                            + dateTimePickerDateFin.Value.ToString("yyyy-MM-dd")
                            + "')";
                        SqlDataAdapter Requete = new SqlDataAdapter(query, _acceuil.sqlCon);
                        Requete.SelectCommand.ExecuteNonQuery();
                        _acceuil.sqlCon.Close();
                        MessageBox.Show("Conge de <" + _acceuil._modifier.textBoxNom.Text + "> est enregistré avec succès", "Succès");


                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Erreur 5 : d'insertion de donné dans DureeConge");
                        _acceuil.sqlCon.Close();
                    }
                }
                else
                    MessageBox.Show("Erreur : Date debut plus grande que la date de fin");


                //retour vers la liste des employe
                _acceuil._modifierConge.Conge_update();

                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);
                
            }
            else
            {
                MessageBox.Show("Veuillez remplire tout les champs", "Attention");
            }



        }

        private void AffectationConge_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonAnnuler_Click(sender, e);
        }

        private void AffectationConge_Resize(object sender, EventArgs e)
        {
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);

        }
    }
}
