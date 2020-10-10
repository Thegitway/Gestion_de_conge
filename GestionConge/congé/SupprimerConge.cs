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
    public partial class SupprimerConge : Form
    {

        private int marginBottomForm = 100;
        private int marginSideForm = 300;
        private int marginTextLabel = 250;

        bool modifier = false;
        public Acceuil _acceuil;
        

        public SupprimerConge(Acceuil _acceuil_)
        {
            InitializeComponent();

            _acceuil = _acceuil_;
            //interface d'ajout
            //nom
            labelCIN.Location = new Point(marginSideForm, marginBottomForm + 50);
            textBoxCIN.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50);
            labelCIN.Show();
            textBoxCIN.Show();
            //Date Debut
            labelDateD.Location = new Point(marginSideForm, marginBottomForm + 50 * 2);
            dateTimePickerDateDebut.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 2);
            labelDateD.Show();
            dateTimePickerDateDebut.Show();

            //Date Fin
            labelDateFin.Location = new Point(marginSideForm, marginBottomForm + 50 * 3);
            dateTimePickerDateFin.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 3);
            labelDateD.Show();
            dateTimePickerDateFin.Show();

            //button
            //valider
            buttonValider.Location = new Point(2 * this.Width / 3 - buttonValider.Width - 100, marginBottomForm + 53 * 4);
            buttonValider.Show();
            //annuler
            buttonAnnuler.Location = new Point(2 * this.Width / 3, marginBottomForm + 53 * 4);
            buttonAnnuler.Show();
            //button supprimer
            buttonSupprimer.Location = new Point(3 * this.Width / 3 + 50 - buttonValider.Width - 200, marginBottomForm + 53 * 4);
            buttonSupprimer.Show();
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);

        }


        private void SupprimerConge_Load(object sender, EventArgs e)
        {
            if (!modifier)
            {
                buttonValider.Text = "Modifer";
            }
            else
                buttonValider.Text = "Valider";

        }

        private void SupprimerConge_Shown(object sender, EventArgs e)
        {
            textBoxCIN.Enabled = false;
            dateTimePickerDateDebut.Enabled = false;
            dateTimePickerDateFin.Enabled = false;

            labelTitre.Text = "Information Congé";
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

        }

        private void SupprimerConge_Resize(object sender, EventArgs e)
        {
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);
            //button affecter un conge
           if (this.Width - labelTitre.Width > 200)
                labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!modifier)
            {

                modifier = true;
                
                dateTimePickerDateDebut.Enabled = true;
                dateTimePickerDateFin.Enabled = true;
                buttonValider.Text = "Valider";
               
            }
            else
            {
               
                if (textBoxCIN.Text.Length != 0
                && dateTimePickerDateDebut.Text.Length != 0
                && dateTimePickerDateFin.Text.Length != 0
                )
                {
                    if (dateTimePickerDateDebut.Value.CompareTo(dateTimePickerDateFin.Value) <= 0)
                    {
                        //base de donnée Enregistrer les donnes
                        try
                        {

                            _acceuil.sqlCon.Open();
                            string queryCo = "Update DureeConge set" +
                                " DateDebut=\'" + dateTimePickerDateDebut.Value.ToString("yyyy-MM-dd")
                                + "\',DateFin=\'" + dateTimePickerDateFin.Value.ToString("yyyy-MM-dd")
                                + "\' where CIN=\'" + _acceuil._modifierConge.CIN + "\'";



                            SqlDataAdapter RequeteCo = new SqlDataAdapter(queryCo, _acceuil.sqlCon);

                            RequeteCo.SelectCommand.ExecuteNonQuery();

                            _acceuil.sqlCon.Close();
                            MessageBox.Show("Congé de <" + textBoxCIN.Text + "> est modifier avec succès", "Succès");

                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Erreur 21 : d'insertion de donné dans DurreConge");
                            _acceuil.sqlCon.Close();
                        }
                    }
                    else
                        MessageBox.Show("Erreur : Date debut plus grande que la date de fin");

                    //retour vers la liste des Conges
                    _acceuil._modifierConge.Conge_update();
                    _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);
                    buttonValider.Text = "Modifier";
                    dateTimePickerDateDebut.Enabled = false;
                    dateTimePickerDateFin.Enabled = false;
                    modifier = false;

                }
                else
                {
                        MessageBox.Show("Erreur 22 : Insertion impossible CIN incorrect");   
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (!modifier)
            {
                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);
            }
            else
            {
                modifier = false;
                
                textBoxCIN.Enabled = false;
                dateTimePickerDateDebut.Enabled = false;
                dateTimePickerDateFin.Enabled = false;

                buttonValider.Text = "Modifier";
                
                textBoxCIN.Text = _acceuil._employes.CIN;
                dateTimePickerDateDebut.Text = _acceuil._modifierConge.DateDebut;
                dateTimePickerDateFin.Text = _acceuil._modifierConge.DateFin;



            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            _acceuil.sqlCon.Open();
            try
            { 
               string queryCo = "delete DureeConge where id='" + _acceuil._modifierConge.indexModifier + "'"+"and cin ='" + _acceuil._modifierConge.CIN + "'";
                SqlDataAdapter RequeteCo = new SqlDataAdapter(queryCo, _acceuil.sqlCon);
                RequeteCo.SelectCommand.ExecuteNonQuery();
                _acceuil.sqlCon.Close();
                MessageBox.Show("Conge de <" + textBoxCIN.Text + "> est supprimer avec succès", "Succès");


            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur 23 : suppression de donné dans la table employe", "Erreur");
                _acceuil.sqlCon.Close();
            }

            //retour vers la liste des Conges
            _acceuil._modifierConge.Conge_update();
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonAnnuler_Click(sender, e);
        }
    }
}
