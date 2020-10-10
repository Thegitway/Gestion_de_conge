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
    public partial class Employe : Form
    {

        public Acceuil _acceuil;
        public string Nom, Prenom, CIN, CNSS, Matricule, Date, JourCon;
        public int indexModifier = 0;
        private bool boxSearch;

        // table selection
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //l'utilisateur ne doit pas cliquer sur la dernier case de la datagride view
            if (e.RowIndex + 1 != this.dataGridView1.Rows.Count && e.RowIndex + 1 != 0)
            {


                _acceuil.activeForm = _acceuil.FormInPanel(_acceuil, _acceuil._modifier);

                if (e.RowIndex >= 0)
                {

                    indexModifier = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    _acceuil._modifier.textBoxNom.Text = dataGridView1.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                    _acceuil._modifier.textBoxPrenom.Text = dataGridView1.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                    _acceuil._modifier.textBoxCIN.Text = dataGridView1.Rows[e.RowIndex].Cells["CIN"].Value.ToString();
                    _acceuil._modifier.textBoxCNSS.Text = dataGridView1.Rows[e.RowIndex].Cells["CNSS"].Value.ToString();
                    _acceuil._modifier.textBoxJourCon.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    _acceuil._modifier.textBoxMatricule.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    _acceuil._modifier.dateTimePickerDate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                    //stock
                   
                    Nom = _acceuil._modifier.textBoxNom.Text;
                    Prenom = _acceuil._modifier.textBoxPrenom.Text;
                    CIN = _acceuil._modifier.textBoxCIN.Text;
                    CNSS = _acceuil._modifier.textBoxCNSS.Text;
                    JourCon = _acceuil._modifier.textBoxJourCon.Text;
                    Matricule = _acceuil._modifier.textBoxMatricule.Text;
                    Date = _acceuil._modifier.dateTimePickerDate.Text;
                }


            }
            else
            if(e.RowIndex + 1 != 0)
                MessageBox.Show("Ligne Vide selection impossible !!!", "Attention");
        }

       

        public int nextID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (textSearch.Text.Length==0)
            {
                textSearch.Text = "Recherche...";
                boxSearch = false;
            }
            else
            {
                boxSearch = true;
            }
            Employe_update();

        }

        private void textSearch_Enter(object sender, EventArgs e)
        {
            boxSearch = false;
            if(textSearch.Text=="Recherche...")
               textSearch.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void Employe_Shown(object sender, EventArgs e)
        {
            Employe_update();
        }
            public void Employe_update()
        {
            labelTitre.Text = "Liste des employés";
            labelTitre.Location = new Point(this.Width / 2 - 50 - labelTitre.Width / 2, 20);

            //base de donnée 
            try
            {
                _acceuil.sqlCon.Open();
                SqlDataAdapter Requete=new SqlDataAdapter();

                if (boxSearch)
                {
                    Requete = new SqlDataAdapter("Select * from Employe where id like \'%" + textSearch.Text +
                        "%\' or Nom like \'%" + textSearch.Text +
                        "%\' or Prenom like \'%" + textSearch.Text +
                        "%\' or CIN like \'%" + textSearch.Text +
                        "%\' or CNSS like \'%" + textSearch.Text +
                        "%\' or Matricule like \'%" + textSearch.Text +
                        "%\' order by Id", _acceuil.sqlCon);
                }
                else
                    Requete = new SqlDataAdapter("Select * from Employe order by Id", _acceuil.sqlCon);
                DataTable Employes = new DataTable();
                Requete.Fill(Employes);
                dataGridView1.DataSource = Employes;
                dataGridView1.Columns[5].HeaderText = "Date embauche";
                dataGridView1.Columns[7].HeaderText = "Jour de congé";

                Requete = new SqlDataAdapter("Select * from Employe order by Id", _acceuil.sqlCon);
                DataTable EmployesID = new DataTable();
                Requete.Fill(EmployesID);
                if (Employes.Rows.Count > 0)
                {
                    nextID = 0;
                    nextID = int.Parse(EmployesID.Rows[EmployesID.Rows.Count - 1].ItemArray[0].ToString());
                    nextID++;
                }
                else
                    nextID = 1;
               

                _acceuil.sqlCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erreur 1 : de connexion avec la base de donnée", "Erreur");
                _acceuil.sqlCon.Close();
            }


        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            _acceuil.activeForm = _acceuil.FormInPanel(_acceuil,_acceuil._ajouterEmploye);
        }
       

        private void Employe_Resize(object sender, EventArgs e)
        {
         
            //button Ajouter Employer
          //  if (this.Width - ButtonAjouter.Width > 20)
           //     ButtonAjouter.Location = new Point(5 * this.Width / 6+200 - ButtonAjouter.Width, 200);

            if (this.Width - labelTitre.Width > 20)
                labelTitre.Location = new Point(this.Width / 2 -50- labelTitre.Width / 2, 20);

        }

        public Employe(Acceuil _acceuil_)
        {
            InitializeComponent();
            _acceuil = _acceuil_;

            //Search
            textSearch.Location= new Point(this.Width / 2 - 300 - textSearch.Width / 2, 100);
            textSearch.Text = "Recherche...";

            buttonSearch.Location = new Point(this.Width / 2 - 280 +textSearch.Width/2, 100);

            //label titre
            labelTitre.Text = "Liste des Employes";
            labelTitre.Location = new Point(this.Width/2 -300- labelTitre.Width / 2, 20);
            //Pink
            labelTitre.BackColor = Color.FromArgb(0, 245, 222, 222);

            //dataGrideView
            dataGridView1.Location = new Point(60, 160);
            dataGridView1.Width = this.Width -100;
            dataGridView1.Show();
            //button Ajouter Employer
            ButtonAjouter.Location = new Point(5 * this.Width / 6 - ButtonAjouter.Width, 100);
            ButtonAjouter.Show();

           
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
