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
using System.Linq.Expressions;

namespace congé
{
    public partial class Acceuil : Form
    {
        ///
        /// ERREUR
        /// 21 : insertion dans la table Employe
        /// <summary>
        /// 0 Accueil
        /// 1 Employer
        /// 2 Ajout
        /// 3 InformationModifier
        /// 4 Calendrier
        /// 5 Affectation conge
        /// 6 modifierActif
        /// </summary>
       // private int FenetreActif = 0;
       
        private Timer timerEverySeconde;
        
        
        string connectionString;

        //Form

        //string
        
       
       public SqlConnection sqlCon;

        public  Form activeForm;

        public Calendrier _calendrier;
        public Modifier _modifier;
        public Employe _employes;
        public AjouterEmploye _ajouterEmploye;
        public AffectationConge _affecterConge;
        public ModifierConge _modifierConge;
        public SupprimerConge _supprimerConge;


        public Acceuil()
        {
            InitializeComponent();

            activeForm = null;

            //Connection SQL
            string curDir = Directory.GetCurrentDirectory();
           
          //  connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Congé.mdf;Integrated Security=True;Connect Timeout=30";
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + curDir.Remove(curDir.Length - 12, 12) + @"\Congé.mdf;Integrated Security = True";

            try
            { sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCon.Close();

            }
            catch {
                MessageBox.Show("Erreur 0 : durant la Connection avec la base de donnee");
                this.Close();

            }
           
            Image myimage = new Bitmap(@"../../pic/acceuil.png");
            this.bAcceuil.BackgroundImage = myimage;

            //button Accueil
            buttonAccueil.Location = new Point(0, this.Height / 6);
            //button employer 
            buttonEmploye.Location = new Point(0,60+this.Height /6);
            //button Calendrier 
            buttonCalendrier.Location = new Point(0, 120 + this.Height / 6);
            //button Quitter
            buttonQuitter.Location = new Point(0, 250 + this.Height / 6);

            // Date a jour
            labelDate.Text =  DateTime.Now.ToString();
            labelDate.Location = new Point(this.Width /2-labelDate.Width/2,5);
            
            myimage = new Bitmap(@"../../pic/menu.png");
            BackgroundImage = myimage;
            myimage = new Bitmap(@"../../pic/dateBackground.png");
            this.labelDate.BackgroundImage = myimage;

            _calendrier = new Calendrier(this);
            _affecterConge = new AffectationConge(this);
            _modifier = new Modifier(this);
            _employes = new Employe(this);
            _ajouterEmploye = new AjouterEmploye(this);
            _modifierConge = new ModifierConge(this);
            _supprimerConge = new SupprimerConge(this);

            //Form
            _employes._acceuil = this;
            _ajouterEmploye._acceuil = this;
            _affecterConge._acceuil = this;
            _calendrier._acceuil = this;

            //panel
            panel1.Size = new Size(this.Width-200, this.Height-200);
            panel1.Location = new Point(145, 117);

            this.panel1.Controls.Add(pictureBox1);
            this.panel1.Controls.Add(labelTitre);

            //pictureBox
            pictureBox1.Size = new Size(panel1.Width, 696);
            pictureBox1.Location = new Point(30, 100);

            //label titre
            myimage = new Bitmap(@"../../pic/backgroundLabel.png");
            labelTitre.Text = "SMART WORKS INFORMATIQUE";
            labelTitre.Location = new Point(panel1.Width / 2 - labelTitre.Width / 2, 10);
            labelTitre.BackgroundImage = myimage;


        }


        public void InitTimer()
        {
            timerEverySeconde = new Timer();
            timerEverySeconde.Tick += new EventHandler(date_update);
            timerEverySeconde.Interval = 1000; // in miliseconds
            timerEverySeconde.Start();
        }

        private void date_update(object sender, EventArgs e)
        {
            //mettre la date a jour
            labelDate.Text = DateTime.Now.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //appel chaque seconde 
            InitTimer();
        }
        //---------Accueil
       

        //-----------Ajouter
       
        
        //-----------Employer
        
       
        //---------Modifier
       
        

        //affecter conge
       

        public void bAcceuil_Click(object sender, EventArgs e)
        {
            buttonAccueil_Click(sender, e);
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fenetre_Resize(object sender, EventArgs e)
        {

            // Date
            if (this.Width / 2 - labelDate.Width / 2 > 143)
                labelDate.Location = new Point(this.Width / 2 - labelDate.Width / 2, 5);


            //label titre
            if (this.Width / 2 - labelTitre.Width / 2 > 143)
                labelTitre.Location = new Point(panel1.Width / 2 - labelTitre.Width / 2, 10);

            //panel
            panel1.Size = new Size(this.Width - 200, this.Height - 200);

        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            panel1.BringToFront();
            
            buttonAccueil.BackColor = Color.FromArgb(255, 127, 0);
            buttonCalendrier.BackColor = Color.FromArgb(255, 244, 222);
            buttonEmploye.BackColor = Color.FromArgb(255, 244, 222);

        }


        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public void buttonEmploye_Click(object sender, EventArgs e)
        {

            //afficher la fenetre employe
            _employes.Employe_update();
            activeForm = FormInPanel(this,_employes);

            buttonEmploye.BackColor = Color.FromArgb(255, 127, 0);
            buttonCalendrier.BackColor = Color.FromArgb(255, 244, 222);
            buttonAccueil.BackColor = Color.FromArgb(255, 244, 222);

        }

      

        private void buttonCalendrier_Click(object sender, EventArgs e)
        {
            _calendrier.calendries.updateDay();
            _calendrier.remplire_ListeBoxCalendrier();
            activeForm = FormInPanel(this, _calendrier);

            buttonCalendrier.BackColor = Color.FromArgb(255, 127, 0);
            buttonAccueil.BackColor = Color.FromArgb(255, 244, 222);
            buttonEmploye.BackColor = Color.FromArgb(255, 244, 222);
        }

        

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }
       public Form FormInPanel(Form formFather,Form formSon)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm = null;
            }
            Form forme = formSon ;
            forme.TopLevel = false;
            forme.Dock = DockStyle.Fill;
            forme.Location = new Point(0,0);
            
            forme.TopLevel = false;
            forme.FormBorderStyle = FormBorderStyle.None;
            forme.BackColor = Color.FromArgb(254, 222,222);
            this.panel1.Controls.Add(forme);
            forme.BringToFront();
            forme.Show();
            //return the active forme 
            return forme;
        }
    }
}
