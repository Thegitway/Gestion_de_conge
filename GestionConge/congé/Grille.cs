using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace congé
{
    public class Grille
    {

        static string[] moisString = { "Janvier","Février","Mars","Avril",
            "Mai","Juin","Juillet","Août","Septembre","Octobre","Novembre","Décembre" };
        static string[] dayString = { "Monday","Tuesday", "Wednesday"
                , "Thursday","Friday", "Saturday", "Sunday" };
        static string[] dayStringFR = { "Lundi","Mardi", "Mercredi"
                , "Jeudi","Vendredi", "Samedi", "Dimanche" };


        //Widget
        public  ComboBox comboBoxMois;
        public ComboBox comboBoxYear;
        private Button buttonForward;
        private Button buttonBack;
        private Button buttonAujour;

        public static int ID=1;
        public Carre[,] carres;
        public Label[] semaineJour;
        private int nombreDeCarreX;
        private int nombreDeCarreY;
        //longeur par Carre longeur de la grille = Ulenght * nombre de Carre
        int UlenghtX;
        int UlenghtY;

        public int mois;
        public int year;
        int nombreDeJour;
        DayOfWeek dayWeekFirstDay;

        Point pointOrigine;

        public Grille(Calendrier Fo1,AffectationConge Fo2,int nbrX, int nbrY, Point pointOrigine, int UlenghtX,int UlenghtY)
        {
            
            year = DateTime.Now.Year;
            mois = DateTime.Now.Month;
           
           
            carres = new Carre[nbrX, nbrY];
            semaineJour = new Label[nbrX];
            nombreDeCarreX = nbrX;
            nombreDeCarreY = nbrY;
            this.pointOrigine = pointOrigine;
            this.UlenghtX = UlenghtY;
            this.UlenghtY = UlenghtY;
            this.comboBoxMois = new ComboBox();
            this.comboBoxYear = new ComboBox();
            this.buttonForward=new Button();
            this.buttonBack = new Button();
            this.buttonAujour = new Button();




            // Button aujourd hui
            // 
            this.buttonAujour.Location = new Point(pointOrigine.X, pointOrigine.Y - 150);
            this.buttonAujour.Name = "buttonAujour";
            this.buttonAujour.Font = new Font(FontFamily.GenericSansSerif, UlenghtX / 20);
            this.buttonAujour.Text = "aujourd\'hui";
            this.buttonAujour.AutoSize = true;
            this.buttonAujour.BackColor = Color.White;
            this.buttonAujour.TabIndex = ID;
            if (Fo1 == null)
            {
                this.buttonAujour.Click += new System.EventHandler(Fo2.buttonAujour_Click);
                Fo2.Controls.Add(this.buttonAujour);
            }
            else
            {
                this.buttonAujour.Click += new System.EventHandler(Fo1.buttonAujour_Click);
                Fo1.Controls.Add(this.buttonAujour);
            }
            this.buttonAujour.Show();
            //

            // Button forward
            // 
            this.buttonForward.Location = new Point(UlenghtX * 6 +  + pointOrigine.X, pointOrigine.Y - 150);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Font = new Font(FontFamily.GenericMonospace, UlenghtX / 15);
            this.buttonForward.Text = ">";
            this.buttonForward.Size = new Size(UlenghtX/5, UlenghtX / 5);
            this.buttonForward.BackColor = Color.White;
            this.buttonForward.TabIndex = ID;
            if (Fo1 == null)
            {
                this.buttonForward.Click += new System.EventHandler(Fo2.buttonForward_Click);
                Fo2.Controls.Add(this.buttonForward);
            }
                else
            {
                this.buttonForward.Click += new System.EventHandler(Fo1.buttonForward_Click);
                Fo1.Controls.Add(this.buttonForward);
            }


            this.buttonForward.Hide();
            //

            // button Back
            // 
            this.buttonBack.Location = new Point(UlenghtX  + pointOrigine.X, pointOrigine.Y - 150);
            this.buttonBack.Name = "buttonForward";
            this.buttonBack.Font = new Font(FontFamily.GenericMonospace, UlenghtX / 15);
            this.buttonBack.Text = "<";
            this.buttonBack.Size =new Size(UlenghtX / 5, UlenghtX / 5);
            this.buttonBack.BackColor = Color.White;
            this.buttonBack.TabIndex = 1;
            if (Fo1 == null)
            {
                this.buttonBack.Click += new System.EventHandler(Fo2.buttonBack_Click);
                Fo2.Controls.Add(this.buttonBack);
            }
            else
            {
                this.buttonBack.Click += new System.EventHandler(Fo1.buttonBack_Click);
                Fo1.Controls.Add(this.buttonBack);
            }

            this.buttonBack.Hide();
            //

            // ComboBox Mois
            // 
            this.comboBoxMois.Size = new Size(UlenghtX-10 , UlenghtX / 5);
            this.comboBoxMois.Location = new Point(UlenghtX *3+ UlenghtX /2+ pointOrigine.X-comboBoxMois.Width, pointOrigine.Y-150);
            this.comboBoxMois.Name = "labelMois";
            this.comboBoxMois.Font = new Font(FontFamily.GenericSansSerif, UlenghtX/12) ;
            this.comboBoxMois.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMois.BackColor = Color.White;
            this.comboBoxMois.TabIndex = 2;
            this.comboBoxMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            if (Fo1 == null)
            {
                this.comboBoxMois.SelectedIndexChanged += new System.EventHandler(Fo2.comboBoxMois_Click);
                Fo2.Controls.Add(this.comboBoxMois);
            }
            else
            {
                this.comboBoxMois.SelectedIndexChanged += new System.EventHandler(Fo1.comboBoxMois_Click);
                Fo1.Controls.Add(this.comboBoxMois);
            }

            this.comboBoxMois.Hide();

            // ComboBox Year
            // 
            this.comboBoxYear.Size = new Size(UlenghtX-10, UlenghtX/ 5);
            this.comboBoxYear.Location = new Point(UlenghtX * 4 + UlenghtX / 2 + pointOrigine.X - comboBoxYear.Width, pointOrigine.Y - 150);
            this.comboBoxYear.Name = "labelYear";
            this.comboBoxYear.Font = new Font(FontFamily.GenericSansSerif, UlenghtX / 12);
            this.comboBoxYear.DropDownHeight = 600;
            this.comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxYear.Text = year.ToString();
            this.comboBoxYear.BackColor = Color.White;
            this.comboBoxYear.TabIndex = 3;
            for (int i = year - 30; i < year + 40; i++)
                this.comboBoxYear.Items.Add(i);
            if (Fo1 == null)
            {
                this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(Fo2.comboBoxYear_Click);
                Fo2.Controls.Add(this.comboBoxYear);
            }
            else
            {
                this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(Fo1.comboBoxYear_Click);
                Fo1.Controls.Add(this.comboBoxYear);
            }

            this.comboBoxYear.Hide();
            //Carres
            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                {
                    Size distance = new Size(i * UlenghtX-i, j * UlenghtY-j);
                    if (Fo1 == null)
                        carres[i, j] = new Carre(null, Fo2, pointOrigine + distance, UlenghtX, UlenghtY);
                    else
                        carres[i, j] = new Carre(Fo1, null, pointOrigine + distance, UlenghtX, UlenghtY);
                }

            // Jour de la semaine

            for (int i = 0; i < nombreDeCarreX; i++)
                {
                    semaineJour[i] = new Label();
                    Size distance = new Size(i * UlenghtX+10,-60);
                    semaineJour[i].BackColor = Color.Transparent;
                    semaineJour[i].Text = dayStringFR[i];
                    semaineJour[i].Font = new Font(FontFamily.GenericSansSerif, UlenghtX/12) ;
                    semaineJour[i].Location = pointOrigine + distance;
                    semaineJour[i].Size = new Size(UlenghtX, UlenghtY - 50);
                    if(Fo1==null)
                    Fo2.Controls.Add(this.semaineJour[i]);
                    else
                    Fo1.Controls.Add(this.semaineJour[i]);

            }
            ID++;

        }

        public void Show()
        {

            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                {
                    carres[i, j].Afficher();
                    if (j ==0)
                        semaineJour[i].Show();
                }
            
            this.comboBoxMois.Show();
            this.buttonBack.Show();
            this.buttonForward.Show();
            this.comboBoxYear.Show();
            this.comboBoxYear.Text = year.ToString();
            this.comboBoxMois.Text = moisString[mois - 1];
            this.buttonAujour.Show();
          


        }

        public void Resize(int WidthX,int HeightY)
        {

            //size
            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                {
                    Size distance = new Size(i * WidthX - i, j * HeightY - j);
                    carres[i, j].Size(WidthX, HeightY, pointOrigine + distance);
                   
                    }
            this.buttonForward.Size = new Size(WidthX / 5, WidthX / 5);
            this.buttonBack.Size = new Size(WidthX / 5, WidthX / 5);
            this.comboBoxMois.Size = new Size(WidthX - 10, WidthX / 5);
            this.comboBoxYear.Size = new Size(WidthX - 10, WidthX / 5);
            for (int i = 0; i < nombreDeCarreX; i++)
            {
                Size distance = new Size(i * WidthX + 10, -60);
                semaineJour[i].Size = new Size(WidthX, UlenghtY - 50);
                semaineJour[i].Location = pointOrigine + distance;
                //semaineJour[i].Font = new Font(FontFamily.GenericSansSerif, WidthX / 12);


            }


            //location

            this.buttonAujour.Location = new Point(pointOrigine.X, pointOrigine.Y - 150);
            this.buttonForward.Location = new Point(WidthX * 6 + +pointOrigine.X, pointOrigine.Y - 150);
            this.buttonBack.Location = new Point(WidthX + pointOrigine.X, pointOrigine.Y - 150);
            this.comboBoxMois.Location = new Point(WidthX * 3 + WidthX / 2 + pointOrigine.X - comboBoxMois.Width, pointOrigine.Y - 150);
            this.comboBoxYear.Location = new Point(WidthX * 4 + WidthX / 2 + pointOrigine.X - comboBoxYear.Width, pointOrigine.Y - 150);
            this.buttonAujour.Location = new Point(pointOrigine.X, pointOrigine.Y - 150);
        }

        public void BringToFront()
        {

            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                {
                    carres[i, j].BringToFront();
                   if(j== 0)
                    semaineJour[i].BringToFront();
                }

            this.comboBoxMois.BringToFront();
            this.buttonBack.BringToFront();
            this.buttonForward.BringToFront();
            this.comboBoxYear.BringToFront();
            this.buttonAujour.BringToFront();


        }

        public void disableLabelJour()
        {
            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                    carres[i,j].disableLabel();
        }



        public void nextMois()
        {

            if (mois < 12)
                mois++;
            else
            {
                year++;
                mois = 1;
                this.comboBoxYear.Text = year.ToString() ;

            }
            this.comboBoxMois.Text = moisString[mois - 1] ;
            

        }

        public void lastMois()
        {

            if (mois > 1)
                mois--;
            else
            {
                year--;
                mois = 12;
                this.comboBoxYear.Text = year.ToString();

            }
            this.comboBoxMois.Text = moisString[mois - 1];


        }
        public void updateDay()
        {

            nombreDeJour = DateTime.DaysInMonth(year, mois);
            int _jour = 0;
            int J = 0;
            
            DateTime firstDay = new DateTime(year, mois, 1);
            dayWeekFirstDay = firstDay.DayOfWeek;

            do
            {
                if (dayWeekFirstDay.ToString() != dayString[J])
                    J++;
                else
                    break;
               
            }
            while (J < 7);
            //reset les jours des carre a 0
            
           
            for (int j = 0; j < nombreDeCarreY ; j++)
                for (int i = 0; i < nombreDeCarreX ; i++)
                {


                    if (_jour >= nombreDeJour || (i < J && j == 0))
                    {
                        carres[i, j].setJour(0);
                       
                    }
                    else
                    {
                        _jour++;
                        carres[i, j].setJour(_jour);
                          
                    }
                    carres[i, j].updateJour();
                    //Verifier si c'est aujourd'hui
                    if(mois==DateTime.Today.Month 
                        && year == DateTime.Today.Year 
                        && carres[i, j].getJour()== DateTime.Today.Day)
                    {
                        carres[i, j].Today();
                    }

                }
             

        }


        public void remplireListeBox(DateTime dateDebut,DateTime dateFin, string CIN)
        {
            DateTime lastDay;
            DateTime FirstDay;
            int nextMois = mois;
            int nextYear = year;

            if (mois < 12)
                nextMois++;
            else
            {
                nextYear++;
                nextMois = 1;
            }

            //si la date du debut est du passer par rapport au mois afficher
            //donc il faut afficher
            if (dateDebut.CompareTo(new DateTime(nextYear, nextMois,1)) < 0 && dateFin.CompareTo(new DateTime(year, mois, 1)) >= 0)
                    {
                        if (dateDebut.CompareTo(new DateTime(year, mois, 1)) < 0)
                            FirstDay = new DateTime(year, mois, 1);
                        else
                            FirstDay = dateDebut;

               
                        if (dateFin.CompareTo(new DateTime(year, mois, DateTime.DaysInMonth(year, mois))) > 0)
                            lastDay = new DateTime(year, mois, DateTime.DaysInMonth(year, mois));
                        else
                            lastDay = dateFin;
                

                for (int j = 0; j < nombreDeCarreY; j++)
                    for (int i = 0; i < nombreDeCarreX; i++)
                    {
                        for (int iDay = FirstDay.Day; iDay <= lastDay.Day; iDay++)
                        {

                            if (mois == FirstDay.Month
                            && year == FirstDay.Year
                            && carres[i, j].getJour() == iDay)
                            {
                                carres[i, j].remplireListeBox(CIN);
                            }


                        }
                    }
                       

                    }
                    //si la date du debut est du futur par rapport au mois afficher
                    //pas la peine d'afficher
                     //if (dateDebut.CompareTo(new DateTime(year, mois, 1)) >= 0)

                            
                
            
        }



        public void ListClear()
        {
            for (int j = 0; j < nombreDeCarreY; j++)
                for (int i = 0; i < nombreDeCarreX; i++)
                    carres[i, j].ClearList();
        }

        public void Aujour()
        {
            mois = DateTime.Today.Month;
            year = DateTime.Today.Year;

        }




    }
}
