using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace congé
{
    public class Carre
    {
        public static int ID=0;
        private PictureBox carre;
        private Label labelJour;
        private Point pointOrigine;
        private ListBox listeBoxEmp;

        //size du pic box
        private int hori;
        private int verti;
        //

        private int jour;
        private List<string> Employe;


        public Carre(Calendrier Fo1,AffectationConge Fo2,Point pointOrigine, int hori,int verti, int jour=0,List<string> Employe=null)
        {
            ID++;
            this.jour = jour;
            this.pointOrigine = pointOrigine;
            this.hori = hori;
            this.verti = verti;
            this.labelJour = new Label();
            carre = new PictureBox();
            this.listeBoxEmp = new ListBox();

            // labelJour
            // 
            labelJour.Location = new Point(2+pointOrigine.X, 2+pointOrigine.Y);
            this.labelJour.Name = "labelJour"+jour+ID;
           this.labelJour.Font= new Font(FontFamily.GenericSansSerif, hori/20);
            if (jour != 0)
                this.labelJour.Text = jour.ToString();
            else
            {
                this.labelJour.Text = "";
            }
            this.labelJour.AutoSize = true;
            this.labelJour.BackColor = Color.FromArgb(255, 127, 0);
            this.labelJour.TabIndex = 0;
            if(Fo1==null)
            Fo2.Controls.Add(this.labelJour);
            else
            Fo1.Controls.Add(this.labelJour);

            labelJour.Show();
            // 

            // listBox
            // 
            this.listeBoxEmp.Location = new Point(hori*1/3 + pointOrigine.X -20, 2+pointOrigine.Y);
            this.listeBoxEmp.Font = new Font(FontFamily.GenericSansSerif, hori / 23);
            this.listeBoxEmp.Name = "listeBoxEmp" + jour+ID;
            this.listeBoxEmp.Size = new Size(hori*2/3, verti-3);
            this.listeBoxEmp.BackColor = Color.FromArgb(255, 127, 0);
            this.listeBoxEmp.TabIndex = 3;
            this.listeBoxEmp.BorderStyle = BorderStyle.None;
            if(Fo1==null)
            Fo2.Controls.Add(this.listeBoxEmp);
            else
                Fo1.Controls.Add(this.listeBoxEmp);

            listeBoxEmp.Show();
            // 


            // pic box
            // 
           
            carre.Location = new Point(pointOrigine.X, pointOrigine.Y);
            this.carre.Name = "pic"+ID;
            this.carre.BorderStyle = BorderStyle.FixedSingle;
            carre.Size = new Size(hori - 1, verti - 1);
            this.carre.BackColor = Color.FromArgb(255, 127, 0);
            this.carre.TabIndex = 1;
            //this.carre.Click += new System.EventHandler(Fo1.carre_Click);
            if(Fo1==null)
            Fo2.Controls.Add(this.carre);
            else
            Fo1.Controls.Add(this.carre);

            this.carre.Hide();
           //
        }

        public void Afficher()
        {
            carre.Show();
             
        }

        public void Size(int WidthX,int HeightY,Point NewPos)
        {
            //size
            this.listeBoxEmp.Size = new Size(WidthX * 2 / 3, HeightY - 3);
            carre.Size = new Size(WidthX - 1, HeightY - 1);
            this.labelJour.Font = new Font(FontFamily.GenericSansSerif, WidthX / 20);

            //position
            labelJour.Location = new Point(2 + NewPos.X, 2 + NewPos.Y);
            this.listeBoxEmp.Location = new Point(WidthX * 1 / 3 + NewPos.X - 20, 2 + NewPos.Y);
            carre.Location = new Point(NewPos.X, NewPos.Y);

        }
        public void BringToFront()
        {
            carre.BringToFront();
            labelJour.BringToFront();
            this.listeBoxEmp.BringToFront();


        }

        public void updateJour()
        {
            
            this.labelJour.Text = "";

            if (jour != 0)
            {  
                this.labelJour.Text = jour.ToString();
                normaleBack();
            }
            else
            {
                grisBack();
            }
        }

        public void grisBack()
        {
            labelJour.Hide();
            this.listeBoxEmp.Hide();
            carre.BackColor = Color.FromArgb(202, 202, 202);
          
        }
        public void normaleBack()
        {
            labelJour.Show();
            this.listeBoxEmp.Show();
            carre.BackColor = Color.FromArgb(255,127,0);
            this.labelJour.BackColor = Color.FromArgb(255, 127, 0);
            this.listeBoxEmp.BackColor = Color.FromArgb(255, 127, 0);
           


        }

        public void Today()
        {
            carre.BackColor = Color.FromArgb(255, 255,200);
            this.labelJour.BackColor = Color.FromArgb(255, 255, 200);
            this.listeBoxEmp.BackColor = Color.FromArgb(255, 255, 200);
        }

        public void remplireListeBox(string CIN)
        {
            this.listeBoxEmp.Items.Add(CIN);
        }

        public void ClearList()
        {
            this.listeBoxEmp.Items.Clear();
        }

        public void disableLabel()
        {
            labelJour.Hide();
            this.listeBoxEmp.Hide();
        }
        public bool pointInCarre(Point p)
        {

            return false;
        }

        public int getJour()
        {
            return this.jour;
        }

        public void setJour(int jour)
        {
            this.jour = jour;
        }

        List<string> getEmployes()
        {
            
            return this.Employe;
        }
    }
}
