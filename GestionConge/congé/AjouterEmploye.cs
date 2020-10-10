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
    public partial class AjouterEmploye : Form
    {

        private int marginBottomForm = 100;
        private int marginSideForm = 300;
        private int marginTextLabel = 250;
        


        bool insertion = true;
        public Acceuil _acceuil;
        public AjouterEmploye(Acceuil _acceuil_)
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
            labelMatricule.Location = new Point(marginSideForm , marginBottomForm + 50 * 6);
            textBoxMatricule.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 6);
            labelMatricule.Show();
            textBoxMatricule.Show();
            //jour de conge
            labelJourCon.Location = new Point(marginSideForm , marginBottomForm + 50 * 7);
            textBoxJourCon.Location = new Point(marginSideForm + marginTextLabel, marginBottomForm + 50 * 7);
            labelJourCon.Show();
            textBoxJourCon.Show();
            //button
            //valider
            buttonValider.Location = new Point(2 * this.Width / 3 - buttonValider.Width - 100, marginBottomForm + 53 * 8);
            buttonValider.Show();
            //annuler
            buttonAnuler.Location = new Point(2 * this.Width / 3, marginBottomForm + 53 * 8);
            buttonAnuler.Show();
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);

        }

        private void AjouterEmploye_Resize(object sender, EventArgs e)
        {
            int leftMargin = 0;
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);
            //titre
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);
            //interface d'ajout
            //nom

            if (this.Width < 1900 && this.Width > 400)
            {
                leftMargin = this.Width;
                marginSideForm = leftMargin / 5;

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
                buttonValider.Location = new Point(2 * this.Width / 3 - buttonValider.Width - 100, marginBottomForm + 53 * 8);
                //annuler
                buttonAnuler.Location = new Point(2 * this.Width / 3, marginBottomForm + 53 * 8);
            }
        }

        private void AjouterEmploye_Load(object sender, EventArgs e)
        {
           
        }

        private void AjouterEmploye_Shown(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxCIN.Clear();
            textBoxCNSS.Clear();
            textBoxJourCon.Clear();
            textBoxMatricule.Clear();
            dateTimePickerDate.Value = DateTime.Now;

            textBoxNom.Enabled = true;
            textBoxPrenom.Enabled = true;
            textBoxCIN.Enabled = true;
            textBoxCNSS.Enabled = true;
            textBoxJourCon.Enabled = true;
            textBoxMatricule.Enabled = true;
            dateTimePickerDate.Enabled = true;

            labelTitre.Text = "Ajout d'un Employé";
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);
        }

        private void buttonValider_Click(object sender, EventArgs e)
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
                   
                        string query = "INSERT INTO Employe Values" +
                            "('" + _acceuil._employes.nextID + "','" + textBoxNom.Text + "','"
                            + textBoxPrenom.Text + "','"
                            + textBoxCIN.Text + "','"
                            + textBoxCNSS.Text + "','"
                            + dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "','"
                            + textBoxMatricule.Text + "','"
                            + int.Parse(textBoxJourCon.Text) + "')";
                        SqlDataAdapter Requete = new SqlDataAdapter(query, _acceuil.sqlCon);
                        Requete.SelectCommand.ExecuteNonQuery();
                        _acceuil.sqlCon.Close();
                        MessageBox.Show("Employé <" + textBoxNom.Text + "> est enregistré avec succès", "Succès");
                    
                 
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erreur 21 : d'insertion de donné dans employe");
                    _acceuil.sqlCon.Close();
                }
                
                //retour vers la liste des employe
                _acceuil._employes.Employe_update();

                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._employes);
                textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxCIN.Clear();
                textBoxCNSS.Clear();
                textBoxJourCon.Clear();
                textBoxMatricule.Clear();

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

        private void buttonAnuler_Click(object sender, EventArgs e)
        {
            _acceuil._employes.Employe_update();

            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._employes);
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxCIN.Clear();
            textBoxCNSS.Clear();
            textBoxJourCon.Clear();
            textBoxMatricule.Clear();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonAnuler_Click(sender, e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
