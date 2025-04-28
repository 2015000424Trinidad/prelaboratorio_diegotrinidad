using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelaboratorio_diegotrinidad
{
    public partial class crud : Form
    {
        int codigo = 1;
        public crud()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] datos = {
                codigo.ToString(),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,
                textBox11.Text,
            };

            dataGridView1.Rows.Add(datos);
            codigo++;


            MessageBox.Show("Cita Registrada", "Colegio Salesiano Don Bosco"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.RowCount != 0)
                {
                    int indice = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows[indice].Cells[1].Value = textBox1.Text;
                    dataGridView1.Rows[indice].Cells[2].Value = textBox2.Text;
                    dataGridView1.Rows[indice].Cells[3].Value = textBox3.Text;
                    dataGridView1.Rows[indice].Cells[4].Value = textBox4.Text;
                    dataGridView1.Rows[indice].Cells[5].Value = textBox5.Text;
                    dataGridView1.Rows[indice].Cells[6].Value = textBox6.Text;
                    dataGridView1.Rows[indice].Cells[7].Value = textBox7.Text;
                    dataGridView1.Rows[indice].Cells[8].Value = textBox8.Text;
                    dataGridView1.Rows[indice].Cells[9].Value = textBox9.Text;
                    dataGridView1.Rows[indice].Cells[10].Value = textBox10.Text;
                    dataGridView1.Rows[indice].Cells[11].Value = textBox11.Text;

                    MessageBox.Show("Cita Registrada", "Colegio Salesiano Don Bosco"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("No hay cita", "Colegio Salesiano Don Bosco"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
    }
}
