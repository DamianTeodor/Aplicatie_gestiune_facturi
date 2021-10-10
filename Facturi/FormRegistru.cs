using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturi
{
    public partial class FormRegistru : Form
    {
        public FormRegistru()
        {
            InitializeComponent();
        }

        private void FormRegistru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Antet' table. You can move, or remove it, as needed.
            this.antetTableAdapter.Fill(this.dataSet1.Antet);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormFacturaNoua formFactura = new FormFacturaNoua(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            formFactura.Show();
        }

        private string filter_sum_or_not(string filter)
        {
            string final;
            if (searchTextBox.Text == "")
            {
                final = ")";
            }
            if(chkDateFrom.Checked == false && chkDateUntil.Checked == false)
            {
                final = ")";
            }
            else
            {
                final = ") AND ";
            }
            if (sumaMinTextBox.Text != "" && sumaMaxTextBox.Text == "")
            {
                filter += "(Suma_Totala >= " + Convert.ToInt32(sumaMinTextBox.Text) + final;
            }
            if (sumaMinTextBox.Text == "" && sumaMaxTextBox.Text != "")
            {
                filter += "(Suma_Totala <= " + Convert.ToInt32(sumaMaxTextBox.Text) + final;
            }
            if (sumaMinTextBox.Text != "" && sumaMaxTextBox.Text != "")
            {
                filter += "(Suma_Totala >= " + Convert.ToInt32(sumaMinTextBox.Text) + " AND Suma_Totala <= " + Convert.ToInt32(sumaMaxTextBox.Text) + final;
            }
            return filter;
        }

        private void execute_filter()
        {
            string filter = "";
            if (searchTextBox.Text != "")
            {
                bool convertible;
                try
                {
                    Convert.ToInt32(searchTextBox.Text);
                    convertible = true;
                }
                catch(Exception ex)
                {
                    convertible = false;
                }
                if (convertible)
                {
                    filter += "(ID = " + Convert.ToInt32(searchTextBox.Text);
                    filter += " OR Seria LIKE '%" + searchTextBox.Text;
                    filter += "%' OR Numar LIKE '%" + searchTextBox.Text;
                    filter += "%' OR Tva = " + Convert.ToInt32(searchTextBox.Text);
                    filter += " OR CumparatorID = " + Convert.ToInt32(searchTextBox.Text);
                    filter += " OR FurnizorID = " + Convert.ToInt32(searchTextBox.Text);
                    filter += ") AND ";
                }
                else
                {
                    filter += "(Seria LIKE '%" + searchTextBox.Text;
                    filter += "%' OR Numar LIKE '%" + searchTextBox.Text;
                    filter += "%') AND ";
                }
            }
            if (chkDateFrom.Checked == true && chkDateUntil.Checked == false)
            {
                // de la
                filter = filter_sum_or_not(filter);
                filter += "(Data >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";
            }
            if (chkDateFrom.Checked == false && chkDateUntil.Checked == true)
            {  // pana la 
                filter = filter_sum_or_not(filter);
                filter += "(Data <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";
            }
            if (chkDateFrom.Checked == true && chkDateUntil.Checked == true)
            { //de la si pana la
                filter = filter_sum_or_not(filter);
                filter += "(Data >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND Data <='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";
            }
            if (chkDateFrom.Checked == false && chkDateUntil.Checked == false)
            {
                filter = filter_sum_or_not(filter);
                if (searchTextBox.Text != "")
                {
                    filter = filter.Remove(filter.Length - 4);
                }
            }
            antetBindingSource.Filter = filter;
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            execute_filter();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void chkDateFrom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void chkDateUntil_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void dateTimePicker2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                execute_filter();
            }
        }
    }
}