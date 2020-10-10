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
    public partial class Modifier : Form
    {
        private int marginBottomForm = 100;
        private int marginSideForm = 300;
        private int marginTextLabel = 250;

        bool modifier = false;
        public Acceuil _acceuil;
        bool insertion = true;
        public Modifier(Acceuil _acceuil_)
        {
            InitializeComponent();
            _acceuil = _acceuil_;
            //interface d'ajout
            //nom
            labelNom.Location = new Point(marginSideForm, marginBottomForm + 50);
            textBoxNom.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50);
            labelNom.Show();
            textBoxNom.Show();
            //prenom
            labelPrenom.Location = new Point(marginSideForm, marginBottomForm + 50 * 2);
            textBoxPrenom.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 2);
            labelPrenom.Show();
            textBoxPrenom.Show();
            //CIN
            labelCIN.Location = new Point(marginSideForm, marginBottomForm + 50 * 3);
            textBoxCIN.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 3);
            labelCIN.Show();
            textBoxCIN.Show();
            //CNSS
            labelCNSS.Location = new Point(marginSideForm, marginBottomForm + 50 * 4);
            textBoxCNSS.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 4);
            labelCNSS.Show();
            textBoxCNSS.Show();
            //Date Embauche
            labelDateE.Location = new Point(marginSideForm, marginBottomForm + 50 * 5);
            dateTimePickerDate.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 5);
            labelDateE.Show();
            dateTimePickerDate.Show();
            //matricule
            labelMatricule.Location = new Point(marginSideForm, marginBottomForm + 50 * 6);
            textBoxMatricule.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 6);
            labelMatricule.Show();
            textBoxMatricule.Show();
            //jour de conge
            labelJourCon.Location = new Point(marginSideForm, marginBottomForm + 50 * 7);
            textBoxJourCon.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 7);
            labelJourCon.Show();
            textBoxJourCon.Show();
            //button
            //valider
            buttonValider.Location = new Point(2 * this.Width / 3 - buttonValider.Width - 100, marginBottomForm + 53 * 8);
            buttonValider.Show();
            //annuler
            buttonAnnuler.Location = new Point(2 * this.Width / 3, marginBottomForm + 53 * 8);
            buttonAnnuler.Show();
            //button supprimer
            buttonSupprimer.Location = new Point(3 * this.Width / 3 +50- buttonValider.Width - 200, marginBottomForm + 53 * 8);
            buttonSupprimer.Show();
            //button affecter un conge
            buttonAffecterCon.Location = new Point(5 * this.Width / 6 -100- buttonAffecterCon.Width, 100);
            buttonAffecterCon.Show();
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);

        }

        private void buttonAffecterCon_Click(object sender, EventArgs e)
        {
            _acceuil._modifierConge.Conge_update();
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifierConge);

        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            if (!modifier)
            {
                buttonValider.Text = "Modifer";
            }
            else
                buttonValider.Text = "Valider";

        }

        private void Modifier_Shown(object sender, EventArgs e)
        {
            textBoxNom.Enabled = false;
            textBoxPrenom.Enabled = false;
            textBoxCIN.Enabled = false;
            textBoxCNSS.Enabled = false;
            textBoxJourCon.Enabled = false;
            textBoxMatricule.Enabled = false;
            dateTimePickerDate.Enabled = false;

            labelTitre.Text = "Information";
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

        }

        private void Modifier_Resize(object sender, EventArgs e)
        {
            int leftMargin;
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);
           

            if (this.Width < 1500 && this.Width > 400)
            {
                leftMargin = this.Width;
                marginSideForm = leftMargin / 5;
                
            }
            else
                if (this.Width > 1500)
            {
                marginSideForm = 300;
               
            }

            labelNom.Location = new Point(marginSideForm, marginBottomForm + 50);
                textBoxNom.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50);

                //prenom
                labelPrenom.Location = new Point(marginSideForm, marginBottomForm + 50 * 2);
                textBoxPrenom.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 2);

                //CIN
                labelCIN.Location = new Point(marginSideForm, marginBottomForm + 50 * 3);
                textBoxCIN.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 3);

                //CNSS
                labelCNSS.Location = new Point(marginSideForm, marginBottomForm + 50 * 4);
                textBoxCNSS.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 4);

                //Date Embauche
                labelDateE.Location = new Point(marginSideForm, marginBottomForm + 50 * 5);
                dateTimePickerDate.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 5);

                //matricule
                labelMatricule.Location = new Point(marginSideForm, marginBottomForm + 50 * 6);
                textBoxMatricule.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 6);

                //jour de conge
                labelJourCon.Location = new Point(marginSideForm, marginBottomForm + 50 * 7);
                textBoxJourCon.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 7);

            //button
            //valider
            buttonValider.Location = new Point(marginSideForm+100+buttonValider.Width, marginBottomForm + 53 * 8);
            //annuler
            buttonAnnuler.Location = new Point(buttonValider.Location.X +50 +buttonValider.Width, marginBottomForm + 53 * 8);
            //suprimer
            buttonSupprimer.Location = new Point(buttonValider.Location.X+marginSideForm*2, marginBottomForm + 53 * 8);
            //button affecter un conge
            buttonAffecterCon.Location = new Point(buttonValider.Location.X + marginSideForm * 2, 100);


        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (!modifier)
            {

                modifier = true;
                textBoxNom.Enabled = true;
                textBoxPrenom.Enabled = true;
                textBoxCIN.Enabled = true;
                textBoxCNSS.Enabled = true;
                textBoxJourCon.Enabled = true;
                textBoxMatricule.Enabled = true;
                dateTimePickerDate.Enabled = true;
                buttonValider.Text = "Valider";
                buttonAffecterCon.Enabled = false;
            }
            else
            {
                for (int i = 1; i <= _acceuil._employes.dataGridView1.RowCount - 2; i++)
                {

                    if (_acceuil._employes.dataGridView1.Rows[i].Cells["CIN"].Value.ToString() == textBoxCIN.Text)
                    {
                        insertion = false;
                    }
                }
                if (textBoxNom.Text.Length != 0
                && textBoxPrenom.Text.Length != 0
                && textBoxCIN.Text.Length != 0
                && textBoxCNSS.Text.Length != 0
                && textBoxJourCon.Text.Length != 0
                && textBoxMatricule.Text.Length != 0
                && dateTimePickerDate.Text.Length != 0
                && insertion == true)
                {
                    //base de donnée Enregistrer les donne
                    try
                    {

                        _acceuil.sqlCon.Open();
                        string queryE = "Update Employe set Nom=\'" + textBoxNom.Text
                            + "\',Prenom=\'" + textBoxPrenom.Text
                            + "\',CIN=\'" + textBoxCIN.Text
                            + "\',CNSS=\'" + textBoxCNSS.Text
                            + "\',Date=\'" + dateTimePickerDate.Value.ToString("yyyy-MM-dd")
                            + "\',Matricule=\'" + textBoxMatricule.Text
                            + "\',JourDeConge=\'" + int.Parse(textBoxJourCon.Text)
                            + "\' where cin='" + _acceuil._employes.CIN + "'";

                        string queryC = "Update DureeConge set CIN=\'" + textBoxCIN.Text
                            + "\' where cin='" + _acceuil._employes.CIN + "'";

                        SqlDataAdapter RequeteC = new SqlDataAdapter(queryC, _acceuil.sqlCon);
                        SqlDataAdapter RequeteE = new SqlDataAdapter(queryE, _acceuil.sqlCon);

                        RequeteE.SelectCommand.ExecuteNonQuery();
                        RequeteC.SelectCommand.ExecuteNonQuery();

                        _acceuil.sqlCon.Close();
                        MessageBox.Show("Employé <" + textBoxNom.Text + "> est modifier avec succès", "Succès");

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Erreur 21 : d'insertion de donné dans employe");
                        _acceuil.sqlCon.Close();
                    }

                    //retour vers la liste des employe
                    _acceuil._employes.Employe_update();
                    _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._employes);
                    modifier = false;
                    textBoxNom.Enabled = false;
                    textBoxPrenom.Enabled = false;
                    textBoxCIN.Enabled = false;
                    textBoxCNSS.Enabled = false;
                    textBoxJourCon.Enabled = false;
                    textBoxMatricule.Enabled = false;
                    dateTimePickerDate.Enabled = false;
                    buttonValider.Text = "Modifier";
                    buttonAffecterCon.Enabled = true;

                }
                else
                {
                    if (insertion == true)
                        MessageBox.Show("Veuillez remplire tout les champs", "Attention");
                    else
                    {
                        MessageBox.Show("Attention CIN incorrect");
                        insertion = true;
                    }
                }
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (!modifier)
            {
                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._employes);
                
            }
            else
            {
                modifier = false;
                textBoxNom.Enabled = false;
                textBoxPrenom.Enabled = false;
                textBoxCIN.Enabled = false;
                textBoxCNSS.Enabled = false;
                textBoxJourCon.Enabled = false;
                textBoxMatricule.Enabled = false;
                dateTimePickerDate.Enabled = false;
                buttonValider.Text = "Modifier";
                textBoxNom.Text = _acceuil._employes.Nom;
                textBoxPrenom.Text = _acceuil._employes.Prenom;
                textBoxCIN.Text = _acceuil._employes.CIN;
                textBoxCNSS.Text = _acceuil._employes.CNSS;
                textBoxJourCon.Text = _acceuil._employes.JourCon;
                textBoxMatricule.Text = _acceuil._employes.Matricule;
                dateTimePickerDate.Text = _acceuil._employes.Date;
                buttonAffecterCon.Enabled = true;

            }
        }

        //text box accept que int
        private void textBoxJourCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Veuillez entre un nombre valide", "Jours de congé");
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            _acceuil.sqlCon.Open();
            try
            {
                

                    string queryE = "delete Employe where Id=" + _acceuil._employes.indexModifier;
                    string queryC = "delete DureeConge where cin='" + _acceuil._employes.CIN + "'";
                    SqlDataAdapter RequeteC = new SqlDataAdapter(queryC, _acceuil.sqlCon);
                    SqlDataAdapter RequeteE = new SqlDataAdapter(queryE, _acceuil.sqlCon);
                    RequeteC.SelectCommand.ExecuteNonQuery();
                    RequeteE.SelectCommand.ExecuteNonQuery();
                    _acceuil.sqlCon.Close();
                    MessageBox.Show("Employé <" + textBoxNom.Text + "> est supprimer avec succès", "Succès");

                
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur 23 : suppression de donné dans la table employe", "Erreur");
                _acceuil.sqlCon.Close();
            }

            //retour vers la liste des employe
            _acceuil._employes.Employe_update();
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._employes);
            
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonAnnuler_Click(sender, e);
        }
    }
}
