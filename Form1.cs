using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace twitdatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sex = textBox2.Text;
            string numberphone = textBox3.Text;
            string address = textBox4.Text;
            dataGridView1.Rows.Add(name, sex, numberphone, address);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            } catch(Exception ex)
                    {
                MessageBox.Show(ex.Message);
            }

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (( mystr = openFileDialog1.OpenFile()) != null)
                    {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] strl = myread.ReadToEnd().Split('\n');
                        num = strl.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num; i ++ )
                        {
                            str = strl[i].Split('^');
                            for (int l = 0; l < dataGridView1.ColumnCount; l++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[l].Value = str[l];
                                }
                                catch { }
                            }
                                
                        }
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { myread.Close();}
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "^");
                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
        }
    }
}
