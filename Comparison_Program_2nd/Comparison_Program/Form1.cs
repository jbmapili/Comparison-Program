using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Comparison_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void openFile(int a)
        {
            OpenFileDialog open = new OpenFileDialog();
            int max = 0;
            if (a == 0) open.FileName = txtFile1.Text;
            else open.FileName = txtFile2.Text;
            using (TextFieldParser tfp = new TextFieldParser(open.FileName, Encoding.GetEncoding(932)))
            {
                tfp.Delimiters = new string[] { "," };
                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();
                    if (fields.Count() > max)
                    {
                        max = fields.Count();
                    }
                }
                if (a == 0) dataFile1.ColumnCount = max;
                else dataFile2.ColumnCount = max;
                for (int col = 0; col < max; col++)
                {
                    if (a == 0) dataFile1.Columns[col].Name = (col + 1).ToString();
                    else dataFile2.Columns[col].Name = (col + 1).ToString();
                }
                using (TextFieldParser tfp2 = new TextFieldParser(open.FileName, Encoding.GetEncoding(932)))
                {
                    tfp2.Delimiters = new string[] { "," };
                    while (!tfp2.EndOfData)
                    {
                        string[] fields = tfp2.ReadFields();
                        if (a == 0) dataFile1.Rows.Add(fields);
                        else dataFile2.Rows.Add(fields);
                    }
                }
            }
            if (txtFile1.Text != "" && txtFile2.Text != "") initialize();
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                txtFile1.Text=Path.GetFullPath(open.FileName);
                dataFile1.Rows.Clear();
                dataFile1.Columns.Clear();
                openFile(0);
                btnColumn1.Enabled = true;
                btnRow1.Enabled = true;
            }
        }

        private void initialize()
        {
            numRow1.Minimum = 1;
            numColumn1.Minimum = 1;
            numRow2.Minimum = 1;
            numColumn2.Minimum = 1;
            numRow1.Maximum = dataFile1.RowCount;
            numColumn1.Maximum = dataFile1.ColumnCount;
            numRow2.Maximum = dataFile2.RowCount;
            numColumn2.Maximum = dataFile2.ColumnCount;
            btnCompare.Enabled = true;
        }
        private void btnFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile2.Text = Path.GetFullPath(open.FileName);
                dataFile2.Rows.Clear();
                dataFile2.Columns.Clear();
                openFile(1);
                btnColumn2.Enabled = true;
                btnRow2.Enabled = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            bool result = true;

            // look for greater column and row
            int row = (dataFile1.RowCount >= dataFile2.RowCount) ? dataFile1.RowCount : dataFile2.RowCount;
            int col=(dataFile1.ColumnCount>=dataFile2.ColumnCount)? dataFile1.ColumnCount:dataFile2.ColumnCount;

            
            //start search
            for (int r = 0; r < row; r++)
            {
                if (r+1 > dataFile1.RowCount)
                {
                    dataFile2.Rows[r].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (r+1 > dataFile2.RowCount)
                {
                    dataFile1.Rows[r].DefaultCellStyle.BackColor = Color.Red;
                }
                else { 
                    for (int c = 0; c < col; c++)
                    {
                        if (c + 1 > dataFile1.ColumnCount)
                        {
                            dataFile2.Rows[r].Cells[c].Style.BackColor = Color.Red;
                        }
                        else if (c + 1 > dataFile2.ColumnCount)
                        {
                            dataFile1.Rows[r].Cells[c].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            string data1="", data2="";
                            try{ data1 = dataFile1.Rows[r].Cells[c].Value.ToString(); }
                            catch (Exception){ data1 = ""; }
                            try{ data2 = dataFile2.Rows[r].Cells[c].Value.ToString(); }
                            catch(Exception){ data2 = ""; }
                            finally { 
                                if (!data1.Equals(data2))
                                {
                                    dataFile2.Rows[r].Cells[c].Style.BackColor = Color.Red;
                                    dataFile1.Rows[r].Cells[c].Style.BackColor = Color.Red;
                                    lblResult.Text = "Different";
                                    result = false;
                                }
                                else
                                {
                                    dataFile2.Rows[r].Cells[c].Style.BackColor = Color.White;
                                    dataFile1.Rows[r].Cells[c].Style.BackColor = Color.White;
                                }
                            }
                        }
                    }
                }
            }
            if (result)
            {
                lblResult.Text = "Same";
            }
        }

        private void btnColumn1_Click(object sender, EventArgs e)
        {
            if (dataFile1.ColumnCount > 0) {
                dataFile1.Columns.RemoveAt(Convert.ToInt32(numColumn1.Text) - 1);
                rtb1.Text = rtb1.Text + "Column Removed: " + Convert.ToInt32(numColumn1.Text) + Environment.NewLine;
                for (int a = 0; a < dataFile1.ColumnCount; a++)
                {
                    dataFile1.Columns[a].Name = (a + 1).ToString();
                }
            }
        }

        private void btnRow1_Click(object sender, EventArgs e)
        {
            if (dataFile1.RowCount > 0)
            {
                dataFile1.Rows.RemoveAt(Convert.ToInt32(numRow1.Text) - 1);
                rtb1.Text = rtb1.Text + "Row Removed: " + Convert.ToInt32(numRow1.Text) + Environment.NewLine;
            }
        }

        private void btnColumn2_Click(object sender, EventArgs e)
        {
            if (dataFile2.ColumnCount > 0) {
                dataFile2.Columns.RemoveAt(Convert.ToInt32(numColumn2.Text) - 1);
                rtb2.Text = rtb2.Text + "Column Removed: " + Convert.ToInt32(numColumn2.Text) + Environment.NewLine;
                for (int a = 0; a < dataFile2.ColumnCount; a++)
                {
                    dataFile2.Columns[a].Name = (a + 1).ToString();
                }
            }
        }

        private void btnRow2_Click(object sender, EventArgs e)
        {
            if (dataFile2.RowCount > 0) 
            {
                dataFile2.Rows.RemoveAt(Convert.ToInt32(numRow2.Text) - 1);
                rtb2.Text = rtb2.Text + "Row Removed: " + Convert.ToInt32(numRow2.Text) + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnColumn1.Enabled = false;
            btnColumn2.Enabled = false;
            btnRow1.Enabled = false;
            btnRow2.Enabled = false;
            btnCompare.Enabled = false;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File| *.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(save.FileName, rtb1.Text);
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File| *.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(save.FileName, rtb2.Text);
            }
        }
     }    
}
