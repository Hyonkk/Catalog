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

        private void login_final_click(object sender, EventArgs e)
        {
            global.nume_curent = username.Text;
            global.parola_curenta = password.Text;
            if (global.ctr_log == 1)
            {
                Server.conectare_elev();
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
    }
}
