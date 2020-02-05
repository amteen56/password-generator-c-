using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }
        const string aplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string number = "(123456789";
        const string special = "!@#$%&*";
        int plength = 0;bool isn = false, iss = false;
        string password = "";
        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            label3.Text = "PoloBLue \t" + DateTime.Now.ToShortDateString();
            chknumber.Checked = false;
            chkspecial.Checked = false;
            cobolength.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cobolength.SelectedIndex = -1;
            chknumber.Checked = false;
            chkspecial.Checked = false;
            passwordtextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iss = chkspecial.Checked;
            isn = chknumber.Checked;
            plength = int.Parse(cobolength.SelectedItem.ToString());
            int no = 0, sp = 0;
            if(notextBox1.Text!="")
                no=int.Parse(notextBox1.Text);
            if(sptextBox2.Text!="")
                sp = int.Parse(sptextBox2.Text);
            if (no + sp > plength)
                MessageBox.Show("Sum of Numbers and Special Char length must be less then of equal to Password Length", "PasswordGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string combination = aplhabet;
               

                Random random = new Random();
                StringBuilder builder = new StringBuilder();
                StringBuilder no1 = new StringBuilder();
                StringBuilder no2 = new StringBuilder();
                for (int i = 0; i < no; i++)
                {
                    no1.Append(number.ElementAt(random.Next(0, number.Length - 1)));
                }
                for (int i = 0; i < sp; i++)
                {
                    no2.Append(special.ElementAt(random.Next(0, special.Length - 1)));
                }
                if (isn && no == 0)
                    combination += number;
                if (iss && sp == 0)
                    combination += special;
                for (int i = 0; i < plength; i++)
                {
                    builder.Append(combination.ElementAt(random.Next(0, combination.Length - 1)));
                }
                int n=-1,n1=-1;
                if (isn && no != 0)
                {
                    n =random.Next(0, builder.Length - (no - sp-1));
                    builder.Insert(n, no1.ToString());
                    //builder.Append(no1.ToString(), n,n+no);
                }
                if (iss && sp != 0)
                {
                    A:
                    n1 = random.Next(0, builder.Length - (no - sp - 1));
                    if (n1 != n)
                        builder.Insert(n1, no2.ToString());
                    else goto A;
                }
                password = builder.ToString();
                passwordtextBox1.Text = password;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
