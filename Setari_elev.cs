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
        int verif=0;
        public setari()
        {
            InitializeComponent();
            this.CenterToParent();
            check.BackColor = Color.Gray;
            this.Select();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            //visible
            schimba_username.Visible = true;
            schimba_parola.Visible = true;
            exit.Visible = true;
            inapoi.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            titlu.Visible = false;
            tx1.Visible = false;
            tx2.Visible = false;
            check.Visible = false;
            tx1.Text = "";
            tx2.Text = "";
            finish.Visible = false;
            check.BackColor = Color.Gray;
            vezi1.Visible = vezi2.Visible = false;
            vezi1.BackColor = vezi2.BackColor = Color.Gray;

        }

        private void schimba_username_Click(object sender, EventArgs e)
        {
            //visible
            schimba_username.Visible = false;
            schimba_parola.Visible = false;
            exit.Visible = false;
            inapoi.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            titlu.Visible = true;
            tx1.Visible = true;
            tx2.Visible = true;
            check.Visible = true;
            finish.Visible = true;
            verif = 1;
            vezi1.Visible = vezi2.Visible = true;
            vezi1.BackColor = vezi2.BackColor = Color.Gray;

            //text
            label1.Text = "Username nou";
            label2.Text = "Confirmare username nou";
            titlu.Text = "Schimbare username";
            check.BackColor = Color.Gray;
        }

        private void schimba_parola_Click(object sender, EventArgs e)
        {
            //visible
            schimba_username.Visible = false;
            schimba_parola.Visible = false;
            exit.Visible = false;
            inapoi.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            titlu.Visible = true;
            tx1.Visible = true;
            tx2.Visible = true;
            check.Visible = true;
            finish.Visible = true;
            verif = 2;
            vezi1.Visible = vezi2.Visible = true;
            vezi1.BackColor = vezi2.BackColor = Color.Gray;

            //text
            label1.Text = "Parola noua";
            label2.Text = "Confirmare parola noua";
            titlu.Text = "Schimbare parola";
            check.BackColor = Color.Gray;
        }

        private void finish_Click(object sender, EventArgs e)
        {

            if (verif == 1)
            {
                if (tx1.Text != "")
                {
                    if (check.BackColor == Color.Green)
                    {
                        global.nume_nou = tx1.Text;
                        if (Server.verif_username_elev() == 0)
                        {
                            Server.schimbare_user_elev();

                            //Visibilitate
                            schimba_parola.Visible = true;
                            schimba_username.Visible = true;
                            inapoi.Visible = false;
                            finish.Visible = false;
                            exit.Visible = true;
                            titlu.Visible = false;
                            tx1.Visible = false;
                            tx2.Visible = false;
                            check.Visible = false;
                            label1.Visible = false;
                            label2.Visible = false;
                            finish.Visible = false;
                            check.BackColor = Color.Gray;
                            vezi1.Visible = vezi2.Visible = false;

                            //resetare textbox user
                            tx1.Text = "";
                            tx2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Nume introdus este luat! Alegeti alt nume!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //resetare textbox user
                            tx1.Text = "";
                            tx2.Text = "";
                        }


                    }
                    else MessageBox.Show("Numele introduse nu coincid!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Introdu un username!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tx1.Text != "")
                {
                    if (check.BackColor == Color.Green)
                    {
                        global.parola_noua = tx1.Text;
                        Server.schimbare_parola_elev();

                        //Visibilitate
                        schimba_parola.Visible = true;
                        schimba_username.Visible = true;
                        inapoi.Visible = false;
                        finish.Visible = false;
                        exit.Visible = true;
                        titlu.Visible = false;
                        tx1.Visible = false;
                        tx2.Visible = false;
                        check.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        finish.Visible = false;
                        check.BackColor = Color.Gray;
                        vezi1.Visible = vezi2.Visible = false;

                        //resetare textbox parola
                        tx1.Text = "";
                        tx2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Parolele introduse nu coincid!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //resetare textbox parola
                        tx1.Text = "";
                        tx2.Text = "";
                    }
                }
                else MessageBox.Show("Introdu o parola!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tx2_TextChanged(object sender, EventArgs e)
        {
            if (tx1.Text == "") check.BackColor = Color.Red;
            else
            {
                if (String.Equals(tx1.Text, tx2.Text)) check.BackColor = Color.Green;
                else check.BackColor = Color.Red;
            }
        }

        private void vezi1_Click(object sender, EventArgs e)
        {
            if (vezi1.BackColor == Color.Gray)
            {
                vezi1.BackColor = Color.Blue;
                tx1.PasswordChar = '\0';
            }
            else
            {
                vezi1.BackColor = Color.Gray;
                tx1.PasswordChar = '*';
            }
        }

        private void vezi2_Click(object sender, EventArgs e)
        {
            if (vezi2.BackColor == Color.Gray)
            {
                vezi2.BackColor = Color.Blue;
                tx2.PasswordChar = '\0';
            }
            else
            {
                vezi2.BackColor = Color.Gray;
                tx2.PasswordChar = '*';
            }
        }
    }
}