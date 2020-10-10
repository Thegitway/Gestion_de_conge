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
    public partial class ModifierConge : Form
    {

        public Acceuil _acceuil;
        public string DateDebut,DateFin, JourCon,CIN,Nom,ID;

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            if (this.Width - labelTitre.Width > 20)
                labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            _acceuil._affecterConge.remplire_ListeBoxCalendrier();
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._affecterConge);
        }

        public int indexModifier = 0;
        public ModifierConge(Acceuil _acceuil_)
        {
            InitializeComponent();

            _acceuil = _acceuil_;

            //label titre
            Image myimage = new Bitmap(@"../../pic/backgroundLabel.png");
            labelTitre.Text = "Liste des Employes";
            labelTitre.Location = new Point(this.Width / 2 - 300 - labelTitre.Width / 2, 20);
            labelTitre.BackgroundImage = myimage;

            //dataGrideView
            dataGridView1.Location = new Point(60, 160);
            dataGridView1.Width = this.Width - 100;
            dataGridView1.Show();
            //button Ajouter Employer
            ButtonAjouter.Location = new Point(5 * this.Width / 6 - ButtonAjouter.Width, 100);
            ButtonAjouter.Show();
            //button X
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifier);
        }

       

        private void ModifierConge_Resize(object sender, EventArgs e)
        {
            buttonX.Location = new Point(this.Width - buttonX.Width, 20);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //l'utilisateur ne doit pas cliquer sur la dernier case de la datagride view
            if (e.RowIndex + 1 != this.dataGridView1.Rows.Count && e.RowIndex + 1 != 0)
            {
                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._supprimerConge);



                if (e.RowIndex >= 0)
                {

                    indexModifier = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    _acceuil._supprimerConge.textBoxCIN.Text = dataGridView1.Rows[e.RowIndex].Cells["CIN"].Value.ToString();
                    _acceuil._supprimerConge.dateTimePickerDateDebut.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    _acceuil._supprimerConge.dateTimePickerDateFin.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                    //stock

                    CIN = _acceuil._supprimerConge.textBoxCIN.Text;
                    DateDebut = _acceuil._supprimerConge.dateTimePickerDateDebut.Text;
                    DateFin = _acceuil._supprimerConge.dateTimePickerDateFin.Text;

                }


            }
            else
                MessageBox.Show("Ligne Vide selection impossible !!!", "Attention");

        }

        public void Conge_update()
        {
            labelTitre.Text = "Liste des conges";
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

            //base de donnée 
            try
            {
                _acceuil.sqlCon.Open();
                SqlDataAdapter Requete = new SqlDataAdapter("Select * from DureeConge where CIN=\'"+_acceuil._employes.CIN+"\' order by Id", _acceuil.sqlCon);
                DataTable Conges = new DataTable();
                Requete.Fill(Conges);
                dataGridView1.DataSource = Conges;
               
                dataGridView1.Columns[1].HeaderText = "CIN";
                dataGridView1.Columns[2].HeaderText = "Date De debut";
                dataGridView1.Columns[3].HeaderText = "Date de fin";
                dataGridView1.Columns[3].HeaderText = "Date de fin";
                
                _acceuil.sqlCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur 1 : de connexion avec la base de donnée", "Erreur");
                _acceuil.sqlCon.Close();
            }


        }

        private void ModifierConge_Load(object sender, EventArgs e)
        {

        }
    }
}
