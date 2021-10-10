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
    public partial class FormFacturaNoua : Form
    {
        bool editWasClicked;
        bool addWasClicked;
        int open_id;
        System.Data.DataRowView row;
        public FormFacturaNoua()
        {
            InitializeComponent();
            groupBoxMain.Enabled = false;
            editWasClicked = false;
            addWasClicked = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            partenerBindingSourceFurnizor.Sort = "Nume";
            partenerBindingSourceClient.Sort = "Nume";
        }
        public FormFacturaNoua(int id)
        {
            InitializeComponent();
            groupBoxMain.Enabled = false;
            editWasClicked = false;
            addWasClicked = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            partenerBindingSourceFurnizor.Sort = "Nume";
            partenerBindingSourceClient.Sort = "Nume";
            open_id = id;
        }

        private void FormFacturaNoua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Partener' table. You can move, or remove it, as needed.
            this.partenerTableAdapter.Fill(this.dataSet1.Partener);
            // TODO: This line of code loads data into the 'dataSet1.LinieFactura' table. You can move, or remove it, as needed.
            this.linieFacturaTableAdapter.Fill(this.dataSet1.LinieFactura);
            // TODO: This line of code loads data into the 'dataSet1.Antet' table. You can move, or remove it, as needed.
            this.antetTableAdapter.Fill(this.dataSet1.Antet);
            int open_position = 0;
            for (int i = 0; i < dataSet1.Antet.Rows.Count; i++)
            {
                if (open_id == dataSet1.Antet[i].ID)
                {
                    open_position = i;
                    break;
                }
            }
            bindingSourceAntet.Position = open_position;
        }

        private void filter_linii_facturi()
        {
            bindingSourceLinii.Filter = "AntetID = " + ((System.Data.DataRowView)bindingSourceAntet.Current)[0].ToString();
        }

        private void bindingSourceAntet_CurrentChanged(object sender, EventArgs e)
        {
            if ((int)((System.Data.DataRowView)bindingSourceAntet.Current)[0] != -1)
            {
                filter_linii_facturi();
            }
            else
            {
                //new row
            }
            var furnizor_assigned_partener_index = partenerBindingSourceFurnizor.Find("ID", ((System.Data.DataRowView)bindingSourceAntet.Current)[7]);
            var client_assigned_partener_index = partenerBindingSourceClient.Find("ID", ((System.Data.DataRowView)bindingSourceAntet.Current)[6]);
            if (furnizor_assigned_partener_index < 0)
            {
                partenerBindingSourceFurnizor.Position = 0;
                partenerBindingSourceFurnizor.ResetBindings(true);
                partenerBindingSourceClient.Position = 0;
                partenerBindingSourceClient.ResetBindings(true);
                /*
                 pentru resetare 
                partenerBindingSourceFurnizor.Position = -1;
                resetare manuala a controalelor legate la partenerbs
                 */
            }
            else
            {
                partenerBindingSourceFurnizor.Position = furnizor_assigned_partener_index;
                partenerBindingSourceClient.Position = client_assigned_partener_index;
            }
        }

        private void commit()
        {
            try
            {
                bindingSourceLinii.EndEdit();
                bindingSourceAntet.EndEdit();
                antetTableAdapter.Update(dataSet1.Antet);
                linieFacturaTableAdapter.Update(dataSet1.LinieFactura);
            }
            catch (Exception ex)
            {
                bindingSourceAntet.CancelEdit();
                bindingSourceLinii.CancelEdit();
                MessageBox.Show(ex.Message);
            }
        }

        private void set_edit_mode(bool edit)
        {
            dataGridView1.Columns[1].ReadOnly = !edit;
            dataGridView1.Columns[2].ReadOnly = !edit;
            dataGridView1.Columns[3].ReadOnly = !edit;
            dataGridView1.Columns[4].ReadOnly = !edit;
            editButton.Visible = !edit;
            bindingNavigatorAddNewItem.Visible = !edit;
            saveButton.Visible = edit;
            cancelButton.Visible = edit;
            groupBoxMain.Enabled = edit;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            editWasClicked = true;
            dataGridView1.AllowUserToDeleteRows = true;
            set_edit_mode(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            addRowsButton.Enabled = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            set_edit_mode(false);
            dataGridView1.DataSource = bindingSourceLinii;
            dataSet1.LinieFactura.RejectChanges();
            bindingSourceLinii.CancelEdit();
            bindingSourceLinii.ResetBindings(false);
            bindingSourceAntet.CancelEdit();
            bindingSourceAntet.ResetBindings(false);
            dataGridView1.Refresh();
            addWasClicked = false;
            editWasClicked = false;
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmati stergerea", "Sunteti sigur?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rows = dataGridView1.Rows.Count;
                if (rows > 1)
                {
                    int index = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(index);
                    bindingSourceLinii.EndEdit();
                    linieFacturaTableAdapter.Update(dataSet1.LinieFactura);
                }
                bindingSourceAntet.RemoveAt(bindingSourceAntet.Position);
                commit();
            }
            else
            {
                bindingSourceAntet.CancelEdit();
                bindingSourceAntet.ResetBindings(false);
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            //new row
            try
            {
                addRowsButton.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                ((System.Data.DataRowView)bindingSourceAntet.Current)[3] = DateTime.Now;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[6] = dataSet1.Partener[0].ID;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[7] = dataSet1.Partener[0].ID;
                addWasClicked = true;
                set_edit_mode(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(editWasClicked)
            {
                return;
            }
            dataGridView1.AllowUserToDeleteRows = false;
            if (addWasClicked)
            {
                dataGridView1.DataSource = bindingSourceLinii;
                filter_linii_facturi();
            }
        }

        private void saveButton_MouseUp(object sender, MouseEventArgs e)
        {

            try
            {
            
            if (editWasClicked)
            {
                editWasClicked = false;
                //modifica furnizor client si data si altele
                ((System.Data.DataRowView)bindingSourceAntet.Current)[3] = dateTimePicker1.Value.Date;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[6] = comboBoxC.SelectedValue;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[7] = comboBoxF.SelectedValue;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[2] = Convert.ToInt32(numarTextBox.Text);
                ((System.Data.DataRowView)bindingSourceAntet.Current)[1] = serieTextBox.Text;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[4] = Convert.ToInt32(tvaTextBox.Text);
                ((System.Data.DataRowView)bindingSourceLinii.Current)[1] = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                ((System.Data.DataRowView)bindingSourceLinii.Current)[2] = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                ((System.Data.DataRowView)bindingSourceLinii.Current)[3] = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                ((System.Data.DataRowView)bindingSourceLinii.Current)[4] = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
            }
            if (addWasClicked)
            {
                ((System.Data.DataRowView)bindingSourceAntet.Current)[3] = dateTimePicker1.Value.Date;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[6] = comboBoxC.SelectedValue;
                ((System.Data.DataRowView)bindingSourceAntet.Current)[7] = comboBoxF.SelectedValue;
                addWasClicked = false;
                addRowsButton.Enabled = true;
            }
            filter_linii_facturi();
            double suma = 0;
            for (int i = 0; i < bindingSourceLinii.Count; i++)
            {
                int cantitate_linie = 0;
                float pret_unitar_fara_tva_linie = 0;
                float valoare_linie = 0;
                float valoare_tva_linie = 0;
                float valoare_totala_linie = 0;

                if (((DataRowView)bindingSourceLinii[i])[7] != DBNull.Value)
                {
                    cantitate_linie = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    pret_unitar_fara_tva_linie = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value);
                    valoare_linie = cantitate_linie * pret_unitar_fara_tva_linie;
                    valoare_tva_linie = Convert.ToSingle(tvaTextBox.Text) / 100 * valoare_linie;
                    valoare_totala_linie = valoare_linie + valoare_tva_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[5] = valoare_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[6] = valoare_tva_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[7] = valoare_totala_linie;
                    suma += valoare_totala_linie;
                }
                else
                {
                    cantitate_linie = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    pret_unitar_fara_tva_linie = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value);
                    valoare_linie = cantitate_linie * pret_unitar_fara_tva_linie;
                    valoare_tva_linie = Convert.ToSingle(tvaTextBox.Text) / 100 * valoare_linie;
                    valoare_totala_linie = valoare_linie + valoare_tva_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[5] = valoare_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[6] = valoare_tva_linie;
                    ((System.Data.DataRowView)bindingSourceLinii[i])[7] = valoare_totala_linie;
                    suma += valoare_totala_linie;
                }
            }
            ((System.Data.DataRowView)bindingSourceAntet.Current)[5] = suma;
            commit();
            set_edit_mode(false);
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void addRowsButton_Click(object sender, EventArgs e)
        {
            try
            {//facem o linie noua si ii setam id ul antetului
                row = (System.Data.DataRowView)bindingSourceLinii.AddNew();
                row[8] = dataSet1.Antet[bindingSourceAntet.Position].ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}