using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class login : Form
    {
        private Rectangle OriginalSize;
        private Rectangle OriginalButton;
        private float FontSize;
        public login()
        {
            InitializeComponent();
            this.CenterToScreen();
            global.F_curent = this;
            //creare titlu
            titlu.Text = "Bine ati venit!" + '\n' + "Catalogul Online CNMV Ploiesti";


            //creare textbox password si username
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Visible = false;
            username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            password.BorderStyle = BorderStyle.FixedSingle;
            password.Visible = false;
            password.PasswordChar = '●';
            password.Font= new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //creare buton logare
            login_final.Visible = false;
            
        }

        private async void login_final_clickAsync(object sender, EventArgs e)
        {
            global.nume_curent = username.Text;
            global.parola_curenta = password.Text;
            if (global.ctr_log == 1)
            {
                await Server.conectare_elevAsync();
                if (Server.ctr == 1)
                {
                    global.F_curent = new ter_elev();
                    this.Hide();
                    global.F_curent.ShowDialog();
                    this.Close();
                }
                else
                { 
                    string mb = "Nu ai introdus numele sau parola corecta!" + '\n' + "Reincearca!";
                    MessageBox.Show(mb, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Server.conectare_profesor();
                if (Server.ctr == 1)
                {
                    global.F_curent = new ter_profesor();
                    this.Hide();
                    global.F_curent.ShowDialog();
                    this.Close();
                }
                else
                {
                    string mb = "Nu ai introdus numele sau parola corecta!" + '\n' + "Reincearca!";
                    MessageBox.Show(mb, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //buton login elev
        private void login_elev_click(object sender, EventArgs e)
        {
            login_elev.Visible = false;
            login_prof.Visible = false;
            creare_login_elev();
        }

        //buton login profesor
        private void login_prof_click(object sender, EventArgs e)
        {
            login_elev.Visible = false;
            login_prof.Visible = false;
            creare_login_prof();
        }

        //login elev
        private void creare_login_elev()
        {
            titlu.Text = "Bine ati venit!" + '\n' + "Logare Elev";
            user.Visible = true;
            pass.Visible = true;
            password.Visible = true;
            username.Visible = true;
            login_final.Visible = true;
            inapoi.Visible = true;
            global.ctr_log = 1;//logare elev
        }

        //login profesor
        private void creare_login_prof()
        {
            titlu.Text = "Bine ati venit!" + '\n' + "Logare Profesor";
            user.Visible = true;
            pass.Visible = true;
            password.Visible = true;
            username.Visible = true;
            login_final.Visible = true;
            inapoi.Visible = true;
            global.ctr_log = 2;
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            //visible
            titlu.Text= "Bine ati venit!" + '\n' + "Catalogul Online CNMV Ploiesti";
            user.Visible = false;
            pass.Visible = false;
            password.Visible = false;
            username.Visible = false;
            login_final.Visible= false;
            login_elev.Visible = true;
            login_prof.Visible = true;
            inapoi.Visible = false;
            username.Text = "";
            password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resizeControls(Rectangle r,Control c)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            float fontRatio = (float)(OriginalSize.Width)/(float)(FontSize);

            int newX=(int)(xRatio*r.Location.X);
            int newY=(int)(yRatio*r.Location.Y);

            int newWidth= (int)(xRatio*r.Width);
            int newHeight= (int)(yRatio*r.Height);

            c.Location=new Point(newX,newY);
            c.Size=new Size(newWidth, newHeight);
            //c.Font.Size= fontRatio*c.Size.Width;
            c.Font = new System.Drawing.Font("Georgia", fontRatio * c.Font.Size);
        }

        private void login_Resize(object sender, EventArgs e)
        {
            //login_elev.Size = new Size((int)(this.Size.Width/5.6), this.Size.Height/10);
            //login_prof.Size = new Size((int)(this.Size.Width / 5.6), this.Size.Height / 10);
            resizeControls(OriginalButton, login_elev);
        }

        private void login_Load(object sender, EventArgs e)
        {
            OriginalSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            OriginalButton = new Rectangle(login_elev.Location.X, login_elev.Location.Y, login_elev.Size.Width, login_elev.Size.Height);
            FontSize = login_elev.Font.Size;
        }
    }
}
