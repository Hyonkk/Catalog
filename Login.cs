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
        private Button login_elev=new Button(), login_prof= new Button(), login_final = new Button();
        private Label titlu = new Label(), user=new Label(),pass=new Label();
        private TextBox username = new TextBox(),password = new TextBox();
        public login()
        {
            InitializeComponent();
            this.CenterToScreen();
            global.F_curent = this;
            global.F_curent.Select();
            global.F_curent.BackColor = Color.FromArgb(210, 218, 217);
            //creare titlu
            titlu.Text = "Bine ati venit!" + '\n' + "Catalogul Online CNMV Ploiesti";
            titlu.BackColor = SystemColors.MenuHighlight;
            titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titlu.Location = new Point(180, 64);
            titlu.AutoSize = true;
            titlu.TextAlign = ContentAlignment.MiddleCenter;
            global.F_curent.Controls.Add(titlu);

            //creare buton login elev
            login_elev.Location = new Point(270, 300);
            login_elev.Size = new Size(100, 50);
            login_elev.Text = "ELEV";
            login_elev.TabIndex = 1;
            login_elev.Visible = true;
            login_elev.BackColor = Color.FromArgb(150, 190, 180);
            login_elev.FlatStyle = FlatStyle.Flat;
            login_elev.Click += new System.EventHandler(login_elev_click);
            global.F_curent.Controls.Add(login_elev);

            //creare buton login profesor
            login_prof.Location = new Point(430, 300);
            login_prof.Size = new Size(100, 50);
            login_prof.Text = "PROFESOR";
            login_prof.TabIndex = 2;
            login_prof.Visible = true;
            login_prof.BackColor = Color.FromArgb(150, 190, 180);
            login_prof.FlatStyle = FlatStyle.Flat;
            login_prof.Click += new System.EventHandler(login_prof_click);
            global.F_curent.Controls.Add(login_prof);

            //creare label pass si user
            user.Text = "USERNAME:";
            user.Location = new Point(175, 300);
            //user.Size = new Size(200, 100);
            user.AutoSize = true;
            global.F_curent.Controls.Add(user);
            user.Visible = false;
            user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            pass.Text = "PASSWORD:";
            pass.Location = new Point(175, 375);
            //pass.Size = new Size(200, 100);
            pass.AutoSize = true;
            global.F_curent.Controls.Add(pass);
            pass.Visible = false;
            pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //creare textbox password si username
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Location = new Point(350, 300);
            username.Size = new Size(200, 100);
            global.F_curent.Controls.Add(username);
            username.Visible = false;
            username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            password.BorderStyle = BorderStyle.FixedSingle;
            password.Location = new Point(350, 375);
            password.Size = new Size(200, 100);
            global.F_curent.Controls.Add(password);
            password.Visible = false;
            password.PasswordChar = '*';
            password.Font= new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //creare buton logare
            login_final.Location = new Point(350, 450);
            login_final.Size = new Size(150, 50);
            login_final.Text = "LOGARE";
            login_final.Visible = false;
            login_final.BackColor = Color.FromArgb(150, 190, 180);
            login_final.FlatStyle = FlatStyle.Flat;
            login_final.Click += new System.EventHandler(login_final_click);
            global.F_curent.Controls.Add(login_final);
            d1.SendToBack();
        }

        private void login_final_click(object sender, EventArgs e)
        {
            global.nume_curent = username.Text;
            if(global.ctr_log==1)
            {
                global.F_curent= new ter_elev();
                this.Hide();
                global.F_curent.ShowDialog();
                this.Close();
            }
            else
            {
                global.F_curent = new ter_profesor();
                this.Hide();
                global.F_curent.ShowDialog();
                this.Close();
            };
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
            titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titlu.Location = new Point(300,100);
            titlu.AutoSize = true;
            titlu.TextAlign = ContentAlignment.MiddleCenter;
            user.Visible = true;
            pass.Visible = true;
            password.Visible = true;
            username.Visible = true;
            login_final.Visible = true;
            global.ctr_log = 1;//logare elev
        }

        //login profesor
        private void creare_login_prof()
        {
            titlu.Text = "Bine ati venit!" + '\n' + "Logare Profesor";
            titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titlu.Location = new Point(290, 100);
            titlu.AutoSize = true;
            titlu.TextAlign = ContentAlignment.MiddleCenter;
            user.Visible = true;
            pass.Visible = true;
            password.Visible = true;
            username.Visible = true;
            login_final.Visible = true;
            global.ctr_log = 2;
        }
    }
}
