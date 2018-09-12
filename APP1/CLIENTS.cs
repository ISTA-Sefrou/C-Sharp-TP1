using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

namespace APP1
{
    public partial class CLIENTS : Form
    {
        SqlConnection cnx = new SqlConnection(@"server=.\sqlexpress;database=bd1;integrated security=true;");
        SqlCommand cmd;
        public CLIENTS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();

                cmd = new SqlCommand("insert into clients values(@cin,@nom,@prenom,@ds)", cnx);
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cin", textBoxCIN.Text);
                cmd.Parameters.AddWithValue("@nom", textBoxNOM.Text);
                cmd.Parameters.AddWithValue("@prenom", textBoxPRENOM.Text);
                cmd.Parameters.AddWithValue("@ds", dateTimePickerDS.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("bien ajouté");

                cmd = new SqlCommand("select * from clients", cnx);
                DataTable t = new DataTable();
                t.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = t;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void CLIENTS_Load(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();

                cmd = new SqlCommand("select * from clients", cnx);
                DataTable t = new DataTable();
                t.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = t;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                if (MessageBox.Show("Voulez-Vous Supprimer?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE clients where cin=@cin", cnx);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cin", textBoxCIN.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bien supprimé");

                    cmd = new SqlCommand("select * from clients", cnx);
                    DataTable t = new DataTable();
                    t.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = t;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCIN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxNOM.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxPRENOM.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerDS.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();

                cmd = new SqlCommand("update clients set  nom=@nom,prenom=@prenom,DateNaissance=@ds where cin=@cin", cnx);
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cin", textBoxCIN.Text);
                cmd.Parameters.AddWithValue("@nom", textBoxNOM.Text);
                cmd.Parameters.AddWithValue("@prenom", textBoxPRENOM.Text);
                cmd.Parameters.AddWithValue("@ds", dateTimePickerDS.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("bien modifié");

                cmd = new SqlCommand("select * from clients", cnx);
                DataTable t = new DataTable();
                t.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = t;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }
    }
}
