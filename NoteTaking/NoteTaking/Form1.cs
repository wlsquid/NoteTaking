using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["messages"].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextTitle.Clear();
            textMessage.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TextTitle.Text, textMessage.Text);
            TextTitle.Clear();
            textMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null) // Prevents null error
            {

                int index = dataGridView1.CurrentCell.RowIndex;

                bool v = dataGridView1 != null;
                if (index > -1 && v)
                {
                    TextTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    textMessage.Text = table.Rows[index].ItemArray[1].ToString();
                }
            }
            else
            {
                return;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["messages"].Visible = false;
            dataGridView1.Columns["title"].Width = 316;
        }
    }
}
