using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp74
{

    public partial class Form1 : Form
    {
        private Color[,] colorMatrix = new Color[10, 10];

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (i < j)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button2FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j < i)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button3FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j == i)
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button4FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j == (9 - i))
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button5FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j < (9 - i))
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button6FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j > (9 - i))
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button7FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount / 2; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button8FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 5; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button9FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount / 2; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        private void button10FillColor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 5; j < dataGridView1.ColumnCount; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.Width = 703;
            dataGridView1.Height = 503;
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 70;
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    colorMatrix[i, j] = Color.White;
                }
            }
        }
        
    }
}
