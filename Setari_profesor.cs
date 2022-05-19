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
    public partial class Setari_profesor : Form
    {
        int verif = 0;
        public Setari_profesor()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Select();
            check.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
            check.BackColor = Color.Gray;

            //text
            label1.Text = "Username nou";
            label2.Text = "Confirmare username nou";
            titlu.Text = "Schimbare username";
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
                        if (Server.verif_username_profesor() == 0)
                        {
                            Server.schimbare_user_profesor();

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
                        Server.schimbare_parola_profesor();

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
            if (String.Equals(tx1.Text, tx2.Text)) check.BackColor = Color.Green;
            else check.BackColor = Color.Red;
        }
    }
    }

