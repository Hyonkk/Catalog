using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class login : Form
    {
        private Rectangle OriginalSize;
        private Rectangle OriginalButton1, OriginalButton2, OriginalButton3, OriginalButton4, OriginalButton5, OriginalButton6, OriginalButton7, OriginalButton8, OriginalButton9, OriginalButton10, OriginalButton11;
        private float FontSize1, FontSize2, FontSize3,FontSize4;
        public login()
        {
            InitializeComponent();
            this.CenterToScreen();
            global.F_curent = this;
            titlu.Text = "Bine ați venit!" + '\n' + "Catalogul Online CNMV Ploiești";
            username.Visible = false;
            password.Visible = false;
            password.PasswordChar = '●';
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
                    string mb = "Nu ai introdus numele sau parola corectă!" + '\n' + "Reîncearcă!";
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
                    string mb = "Nu ai introdus numele sau parola corectă!" + '\n' + "Reîncearcă!";
                    MessageBox.Show(mb, "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //buton login elev
        private void login_elev_click(object sender, EventArgs e)
        {
            login_elev.Visible = false;
            login_prof.Visible = false;
            tip_logare_label.Visible = false;
            creare_login_elev();
        }

        //buton login profesor
        private void login_prof_click(object sender, EventArgs e)
        {
            login_elev.Visible = false;
            login_prof.Visible = false;
            tip_logare_label.Visible = false;
            creare_login_prof();
        }

        //login elev
        private void creare_login_elev()
        {
            titlu.Text = "Bine ați venit!" + '\n' + "Logare Elev";
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
            titlu.Text = "Bine ați venit!" + '\n' + "Logare Profesor";
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
            titlu.Text= "Bine ați venit!" + '\n' + "Catalogul Online CNMV Ploiești";
            user.Visible = false;
            pass.Visible = false;
            password.Visible = false;
            username.Visible = false;
            login_final.Visible= false;
            login_elev.Visible = true;
            login_prof.Visible = true;
            inapoi.Visible = false;
            tip_logare_label.Visible = true;
            username.Text = "";
            password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resizeControls(Rectangle r,Control c,float FontSize)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            float fontRatio = (float)(FontSize) / (float)(r.Width+r.Height);

            int newX=(int)(xRatio*r.Location.X);
            int newY=(int)(yRatio*r.Location.Y);

            int newWidth= (int)(xRatio*r.Width);
            int newHeight= (int)(yRatio*r.Height);

            c.Location=new Point(newX,newY);
            c.Size=new Size(newWidth, newHeight);
            // newWidth * fontRatio
            c.Font = new System.Drawing.Font("Georgia", (newWidth+newHeight) * fontRatio, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void login_Resize(object sender, EventArgs e)
        {
            resizeControls(OriginalButton1, login_elev, FontSize1);
            resizeControls(OriginalButton2, login_prof, FontSize1);
            resizeControls(OriginalButton3, login_final, FontSize1);
            resizeControls(OriginalButton4, inapoi, FontSize1);
            resizeControls(OriginalButton5, user, FontSize2);
            resizeControls(OriginalButton6, pass, FontSize2);
            resizeControls(OriginalButton7, password, FontSize4);
            resizeControls(OriginalButton8, username, FontSize4);
            resizeControls(OriginalButton9, titlu, FontSize3);
            //resizeControls(OriginalButton11, background, FontSize3);
            resizeControls(OriginalButton10, tip_logare_label, FontSize3);
            titlu.Font= titlu.Font = new System.Drawing.Font(titlu.Font.FontFamily, titlu.Font.Size, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void login_Load(object sender, EventArgs e)
        {
            OriginalSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            OriginalButton1 = new Rectangle(login_elev.Location.X, login_elev.Location.Y, login_elev.Size.Width, login_elev.Size.Height);
            OriginalButton2 = new Rectangle(login_prof.Location.X, login_prof.Location.Y, login_prof.Size.Width, login_prof.Size.Height);
            OriginalButton3 = new Rectangle(login_final.Location.X, login_final.Location.Y, login_final.Size.Width, login_final.Size.Height);
            OriginalButton4 = new Rectangle(inapoi.Location.X, inapoi.Location.Y, inapoi.Size.Width, inapoi.Size.Height);
            OriginalButton5 = new Rectangle(user.Location.X, user.Location.Y, user.Size.Width, user.Size.Height);
            OriginalButton6 = new Rectangle(pass.Location.X, pass.Location.Y, pass.Size.Width, pass.Size.Height);
            OriginalButton7 = new Rectangle(password.Location.X, password.Location.Y, password.Size.Width, password.Size.Height);
            OriginalButton8 = new Rectangle(username.Location.X, username.Location.Y, username.Size.Width, username.Size.Height);
            OriginalButton9 = new Rectangle(titlu.Location.X, titlu.Location.Y, titlu.Size.Width, titlu.Size.Height);
            OriginalButton10 = new Rectangle(tip_logare_label.Location.X, tip_logare_label.Location.Y, tip_logare_label.Size.Width, tip_logare_label.Size.Height);
            //OriginalButton11 = new Rectangle(background.Location.X, background.Location.Y, background.Size.Width, background.Size.Height);
            FontSize1 = login_elev.Font.Size;
            FontSize2 = user.Font.Size;
            FontSize3 = titlu.Font.Size;
            FontSize4 = username.Font.Size;
        }
    }
}
