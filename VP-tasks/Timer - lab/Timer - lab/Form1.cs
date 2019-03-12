using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer___lab
{
    public partial class Form1 : Form
    {

        Ravenka ravenka = new Ravenka();
        List<Igrac> igraci = new List<Igrac>();
        Igrac igrac;
        
        private static readonly int vreme = 60; 
        private int pominatoVreme { get; set; }
        private int poeni { get; set; }
        public string message { get; set; }
        public string caption { get; set; }

        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {
            igrac = new Igrac();
            txtIgrac.Text = "";
            txtOp1.Text = "";
            txtOp2.Text = "";
            txtOperand.Text = "";

            ravenka = new Ravenka();
            pbPoeni.Minimum = 0;
            pbPoeni.Maximum = 50;
            pbPoeni.Value = 0;

            pominatoVreme = vreme;
            pbPreostanatoVreme.Maximum = vreme;
            pbPreostanatoVreme.Value = pominatoVreme;
            pbPreostanatoVreme.Minimum = 0;

         
            novaRavenka();
            timer1.Start();
            poeni = 0;
            lblPoeniii.Text = "0"
                ;
          
            
        }

        public void novaRavenka()
        {
            ravenka = new Ravenka();
            txtOp1.Text = ravenka.prvBroj.ToString();
            txtOp2.Text = ravenka.vtorBroj.ToString();
            txtOperand.Text = ravenka.operand.ToString();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pominatoVreme--;
            pbPreostanatoVreme.Value = pominatoVreme;
            lblPreostanatoVreme.Text = String.Format("{0}:{1}", pominatoVreme / 60, pominatoVreme % 60);
            if(pominatoVreme == 0)
            {
                timer1.Stop();
                IstecenoVreme();
            }

        }


        private void btnPogodi_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIgrac.Text.Length == 0)
                {
                    timer1.Stop();
                    message = "Немате внесено играч!";
                    caption = "Грешка";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRezultat.Text = "";
                    timer1.Start();
                    return;

                }

                if (txtRezultat.Text.Length == 0)
                {
                    timer1.Stop();
                    message = "Немате внесено резултат!";
                    caption = "Грешка";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRezultat.Text = "";
                    timer1.Start();
                    return;

                }

                if (TocenRezultat(Convert.ToInt32(txtRezultat.Text)))
                {
                    poeni++;
                    pbPoeni.Value = poeni;
                    lblPoeniii.Text = poeni.ToString();

                }

                    if (poeni % 10 == 0 && poeni != 0)
                    {
                        if (pominatoVreme + 10 >= vreme)
                        {
                            pominatoVreme = vreme;
                            pbPreostanatoVreme.Value = pominatoVreme;
                        }else      
                        {
                             pominatoVreme += 10;
                             pbPreostanatoVreme.Value = pominatoVreme;
                           }
                    }
                

               
                txtRezultat.Text = "";
                novaRavenka();
            }catch(Exception ex)
            {

            }
        }

        public bool TocenRezultat(int rez)
        {
            if (ravenka.operand == '+')
            {
                if (ravenka.prvBroj + ravenka.vtorBroj == rez)
                {
                    return true;
                }
            }

            if (ravenka.operand == '-')
            {
                if (ravenka.prvBroj - ravenka.vtorBroj == rez)
                {
                    return false;
                }
            }

            if (ravenka.operand == '/')
            {
                if (ravenka.prvBroj / ravenka.vtorBroj == rez)
                {
                    return true;
                }
            }

            if (ravenka.operand == '*')
            {
                if (ravenka.prvBroj * ravenka.vtorBroj == rez)
                {
                    return true;
                }
            }


            return false;
        }

        public void endGame()
        {
            timer1.Stop();
            message = "Дали сакате да ја исклучите апликацијата?";
            caption = "Исклучување на апликацијата";
            var rezultat = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if(rezultat == DialogResult.Yes)
            {
                this.Close();
            }else
            {
                timer1.Start();
            }
        }

        public void IstecenoVreme()
        {
            message = "Времето истече! Крај на игра! ДАЛИ сакате нова игра?";
            caption = "Времето истече!";
            var rezultat = MessageBox.Show(message, caption, MessageBoxButtons.YesNo); 
            if(rezultat == DialogResult.Yes)
            {
                newGame();
            }else
            {
                this.Close(); 
            }
        }

        private void btnIskluci_Click(object sender, EventArgs e)
        {
            endGame();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            igrac.Ime = txtIgrac.Text;
            igrac.OsvoeniPoeni = Convert.ToInt32(lblPoeniii.Text);
            igraci.Add(igrac);

            timer1.Stop();
            message = "Дали сакате нова игра?";
            caption = "Нова игра!";
            var rezultat = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
            {
                newGame();
            }
            else
            {
                timer1.Start();
            }
        }

        private void btnNajdobriIgraci_Click(object sender, EventArgs e)
        {
            igrac.Ime = txtIgrac.Text;
            igrac.OsvoeniPoeni = Convert.ToInt32(lblPoeniii.Text);
            igraci.Add(igrac);

            timer1.Stop();
            igraci = igraci.OrderByDescending(x => x.OsvoeniPoeni).ToList();
            NajdobriIgraci najIgraci = new NajdobriIgraci();
            najIgraci.lista = igraci;
            najIgraci.popolni();
            najIgraci.ShowDialog();

            

        }
    }
}
