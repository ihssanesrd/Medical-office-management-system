using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
                checkBox1.Text = "afficher le mot de passe";
            }
            else
            {
                pass.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkBox1.Text = "Cacher le mot de passe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || mail.Text == "" || login.Text == "" || pass.Text == "")
            {
                MessageBox.Show("les champs sont vides", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Patient VALUES ('" + nom.Text + "','" + prenom.Text + "','" + age.Text + "','" + tel.Text + "','" + mail.Text + "','" + login.Text + "','" + pass.Text + "')";

                cmd.ExecuteNonQuery();
                connection.Close();

                nom.Text = "";
                prenom.Text = "";
                age.Text = "";
                tel.Text = "";
                mail.Text = "";
                login.Text = "";
                pass.Text = "";
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // connecter();
                Form6 f = new Form6();
                this.Hide();
                f.Show();
                
            }
        }
      

           

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            age.Text = "";
            tel.Text = "";
            mail.Text = "";
            login.Text = "";
            pass.Text = "";
            nom.Focus();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();

            f.Show();
        }

        private void age_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
