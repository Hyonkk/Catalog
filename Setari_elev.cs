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
    public partial class setari : Form
    {
        private Button schimba_parola = new Button(), schimba_user = new Button(), finish = new Button(), exit = new Button() , inapoi = new Button();
        private Label titlu = new Label(), tx1 = new Label(), tx2 = new Label();
        private TextBox schimbare_nume = new TextBox(), schimbare_nume_conf = new TextBox();
        private TextBox schimbare_parola = new TextBox(), schimbare_parola_conf = new TextBox();
        private Label check = new Label();
        private int verif;
        public setari()
        {
            InitializeComponent();
            this.CenterToParent();
            this.BackColor = Color.Wheat;
            creare_butoane();
            creare_textbox();
            creare_label();
            this.Select();
        }
        private void creare_label()
        {
            //label check 
            check.Location = new Point(500, 250);
            check.Size = new Size(20, 20);
            check.Visible = false;
            check.BackColor = Color.Gray;
            this.Controls.Add(check);

            //label titlu
            titlu.AutoSize = true;
            this.Controls.Add(titlu);
            titlu.Visible = false;
            titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //label pt textbox1
            this.Controls.Add(tx1);
            tx1.Visible = false;
            //tx1.BackColor = Color.FromArgb(79, 169, 75);
            tx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tx1.Size = new Size(292, 35);

            //label pt textbox2
            tx2.AutoSize = true;
            this.Controls.Add(tx2);
            tx2.Visible = false;
            //tx2.BackColor = Color.FromArgb(79, 169, 75);
            tx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tx2.Size = new Size(293, 35);
        }

        private void creare_textbox()
        {
            //schimbare user
            schimbare_nume.Size = new Size(200,100);
            schimbare_nume.Left = (int)((this.ClientSize.Width - schimbare_nume.Width) / 1.2);
            schimbare_nume.Top = (int)((this.ClientSize.Height - schimbare_nume.Height) / 3);
            schimbare_nume.Visible = false;
            this.Controls.Add(schimbare_nume);

            //schimbare user conf
            schimbare_nume_conf.Size = new Size(200, 100);
            schimbare_nume_conf.Left = (int)((this.ClientSize.Width - schimbare_nume_conf.Width) / 1.2);
            schimbare_nume_conf.Top = (int)((this.ClientSize.Height - schimbare_nume_conf.Height) / 2);
            schimbare_nume_conf.Visible = false;
            schimbare_nume_conf.TextChanged += new EventHandler(schimbare_nume_conf_TextChanged);
            this.Controls.Add(schimbare_nume_conf);

            //schimbare parola
            schimbare_parola.Size = new Size(200, 75);
            schimbare_parola.Left = (int)((this.ClientSize.Width - schimbare_parola.Width) / 1.2);
            schimbare_parola.Top = (int)((this.ClientSize.Height - schimbare_parola.Height) / 3);
            schimbare_parola.Visible = false;
            schimbare_parola.PasswordChar = '*';
            this.Controls.Add(schimbare_parola);

            //schimbare parola conf
            schimbare_parola_conf.Size = new Size(200, 75);
            schimbare_parola_conf.Left = (int)((this.ClientSize.Width - schimbare_parola_conf.Width) / 1.2);
            schimbare_parola_conf.Top = (int)((this.ClientSize.Height - schimbare_parola_conf.Height) / 2);
            schimbare_parola_conf.Visible = false;
            schimbare_parola_conf.PasswordChar='*';
            schimbare_parola_conf.TextChanged += new EventHandler(schimbare_parola_conf_TextChanged);
            this.Controls.Add(schimbare_parola_conf);
        }

        private void schimbare_nume_conf_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(schimbare_nume.Text, schimbare_nume_conf.Text))
            {
                check.BackColor = Color.Green;
            }
            else check.BackColor = Color.Red;
        }

        private void schimbare_parola_conf_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(schimbare_parola.Text, schimbare_parola_conf.Text))
            {
                check.BackColor = Color.Green;
            }
            else check.BackColor = Color.Red;
        }

        private void creare_butoane()
        {
            //user
            schimba_user.Location = new Point(92, 100);
            schimba_user.Size = new Size(150, 75);
            schimba_user.Text = "Schimba username-ul";
            schimba_user.BackColor = Color.FromArgb(150, 190, 180);
            schimba_user.FlatStyle = FlatStyle.Flat;
            schimba_user.Click += new System.EventHandler(schimba_user_Click);
            this.Controls.Add(schimba_user);

            //parola
            schimba_parola.Location = new Point(342, 100);
            schimba_parola.Size = new Size(150, 75);
            schimba_parola.Text = "Schimba parola";
            schimba_parola.BackColor = Color.FromArgb(150, 190, 180);
            schimba_parola.FlatStyle = FlatStyle.Flat;
            schimba_parola.Click += new System.EventHandler(schimba_parola_Click);
            this.Controls.Add(schimba_parola);

            //exit
            exit.Size = new Size(100, 60);
            exit.Left = (this.ClientSize.Width - exit.Width) / 2;
            exit.Top = (int)((this.ClientSize.Height - exit.Height) / 1.5);
            exit.Text = "Exit";
            exit.BackColor = Color.FromArgb(150, 190, 180);
            exit.FlatStyle = FlatStyle.Flat;
            exit.Click += new System.EventHandler(exit_Click);
            this.Controls.Add(exit);            
            
            //finish
            
            finish.Size = new Size(100, 60);
            finish.Left = (int)((this.ClientSize.Width - finish.Width) / 1.5);
            finish.Top = (int)((this.ClientSize.Height - finish.Height) / 1.2);
            finish.Text = "Confirmare";
            finish.BackColor = Color.FromArgb(150, 190, 180);
            finish.FlatStyle = FlatStyle.Flat;
            finish.Visible = false;
            finish.Click += new System.EventHandler(finish_Click);
            this.Controls.Add(finish);

            //inapoi
            inapoi.Size = new Size(100, 60);
            inapoi.Left = (this.ClientSize.Width - inapoi.Width) / 3;
            inapoi.Top = (int)((this.ClientSize.Height - inapoi.Height) / 1.2);
            inapoi.Text = "Inapoi";
            inapoi.Visible = false;
            inapoi.BackColor = Color.FromArgb(150, 190, 180);
            inapoi.FlatStyle = FlatStyle.Flat;
            inapoi.Click += new System.EventHandler(inapoi_Click);
            this.Controls.Add(inapoi);
        }

        //Butoane

        private void exit_Click(object sender, EventArgs e)
        {
            //check.BackColor = Color.Gray;
            this.Close();
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            //Visibilitate
            schimba_parola.Visible = true;
            schimba_user.Visible = true;
            schimbare_nume.Visible = false;
            schimbare_nume_conf.Visible = false;
            schimbare_parola.Visible = false;
            schimbare_parola_conf.Visible = false;
            inapoi.Visible = false;
            finish.Visible = false;
            exit.Visible = true;
            titlu.Visible = false;
            tx1.Visible = false;
            tx2.Visible = false;
            check.Visible = false;
            schimbare_nume.Text = "";
            schimbare_nume_conf.Text = "";
            schimbare_parola.Text = "";
            schimbare_parola_conf.Text = "";
            //check.BackColor = Color.Gray;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            /*
            //Visibilitate
            schimba_parola.Visible = true;
            schimba_user.Visible = true;
            schimbare_nume.Visible = false;
            schimbare_nume_conf.Visible = false;
            schimbare_parola.Visible = false;
            schimbare_parola_conf.Visible = false;
            inapoi.Visible = false;
            finish.Visible = false;
            exit.Visible = true;
            titlu.Visible = false;
            tx1.Visible = false;
            tx2.Visible = false;
            check.Visible = false;

            */

            //check.BackColor = Color.Gray;

            //schimbare in database

            if (verif == 1)
            {
                if (schimbare_nume.Text != "")
                {
                    if (check.BackColor == Color.Green)
                    {
                        global.nume_nou = schimbare_nume.Text;
                        if (Server.verif_username_elev() == 0)
                        {
                            Server.schimbare_user_elev();

                            //Visibilitate
                            schimba_parola.Visible = true;
                            schimba_user.Visible = true;
                            schimbare_nume.Visible = false;
                            schimbare_nume_conf.Visible = false;
                            schimbare_parola.Visible = false;
                            schimbare_parola_conf.Visible = false;
                            inapoi.Visible = false;
                            finish.Visible = false;
                            exit.Visible = true;
                            titlu.Visible = false;
                            tx1.Visible = false;
                            tx2.Visible = false;
                            check.Visible = false;

                            //resetare textbox user
                            schimbare_nume.Text = "";
                            schimbare_nume_conf.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Nume introdus este luat! Alegeti alt nume!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //resetare textbox user
                            schimbare_nume.Text = "";
                            schimbare_nume_conf.Text = "";
                        }


                    }
                    else MessageBox.Show("Numele introduse nu coincid!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Introdu un username!","Eroare!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (schimbare_nume.Text != "")
                {
                    if (check.BackColor == Color.Green)
                    {
                        global.parola_noua = schimbare_parola.Text;
                        Server.schimbare_parola_elev();

                        //Visibilitate
                        schimba_parola.Visible = true;
                        schimba_user.Visible = true;
                        schimbare_nume.Visible = false;
                        schimbare_nume_conf.Visible = false;
                        schimbare_parola.Visible = false;
                        schimbare_parola_conf.Visible = false;
                        inapoi.Visible = false;
                        finish.Visible = false;
                        exit.Visible = true;
                        titlu.Visible = false;
                        tx1.Visible = false;
                        tx2.Visible = false;
                        check.Visible = false;

                        //resetare textbox parola
                        schimbare_parola.Text = "";
                        schimbare_parola_conf.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Parolele introduse nu coincid!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //resetare textbox parola
                        schimbare_parola.Text = "";
                        schimbare_parola_conf.Text = "";
                    }
                }
                else MessageBox.Show("Introdu o parola!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void schimba_user_Click(object sender, EventArgs e)
        {
            //Visibilitate
            schimba_parola.Visible = false;
            schimba_user.Visible = false;
            exit.Visible = false;
            schimbare_nume.Visible = true;
            schimbare_nume_conf.Visible = true;
            inapoi.Visible = true;
            finish.Visible = true;
            titlu.Visible = true;
            tx1.Visible = true;
            tx2.Visible = true;
            check.Visible = true;
            check.BackColor = Color.Gray;

            //titlu
            titlu.Text = "Schimbare username";
            titlu.Left = (this.ClientSize.Width - titlu.Width) / 2;
            titlu.Top = (int)((this.ClientSize.Height - titlu.Height) / 8);

            //tx1
            tx1.Text = "Username nou";
            tx1.TextAlign = ContentAlignment.MiddleCenter;
            tx1.Left = (this.ClientSize.Width - tx1.Width) / 10;
            tx1.Top = (int)((this.ClientSize.Height - tx1.Height) / 3);

            //tx2
            tx2.Text = "Confirmare username nou";
            tx2.TextAlign = ContentAlignment.MiddleCenter;
            
            tx2.Left = (this.ClientSize.Width - tx2.Width) / 10;
            tx2.Top = (int)((this.ClientSize.Height - tx2.Height) / 2);

            verif = 1;
        }        
        
        private void schimba_parola_Click(object sender, EventArgs e)
        {
            //Visibilitate
            schimba_parola.Visible = false;
            schimba_user.Visible = false;
            exit.Visible = false;
            schimbare_parola.Visible = true;
            schimbare_parola_conf.Visible = true;
            inapoi.Visible = true;
            finish.Visible = true;
            titlu.Visible = true;
            tx1.Visible = true;
            tx2.Visible = true;
            check.Visible = true;
            check.BackColor = Color.Gray;

            //titlu
            titlu.Text = "Schimbare parola";
            titlu.Left = (this.ClientSize.Width - titlu.Width) / 2;
            titlu.Top = (int)((this.ClientSize.Height - titlu.Height) / 8);

            //tx1
            tx1.Text = "Parola noua";
            tx1.TextAlign = ContentAlignment.MiddleCenter;
            tx1.Left = (this.ClientSize.Width - tx1.Width) / 10;
            tx1.Top = (int)((this.ClientSize.Height - tx1.Height) / 3);

            //tx2
            tx2.Text = "Confirmare parola noua";
            tx2.TextAlign = ContentAlignment.MiddleCenter;

            tx2.Left = (this.ClientSize.Width - tx2.Width) / 10;
            tx2.Top = (int)((this.ClientSize.Height - tx2.Height) / 2);

            verif = 2;
        }
    }
}
