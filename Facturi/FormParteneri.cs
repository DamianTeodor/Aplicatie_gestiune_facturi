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
    public partial class addParteneriForm : Form
    {
        public addParteneriForm()
        {
            InitializeComponent();
        }

        private void addParteneriForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Partener' table. You can move, or remove it, as needed.
            this.partenerTableAdapter.Fill(this.dataSet11.Partener);
        }

        private void commit()
        {
            try
            {
                partenerBindingSource.EndEdit();
                partenerTableAdapter.Update(dataSet11.Partener);
            }
            catch(Exception ex)
            {
                partenerBindingSource.CancelEdit();
                MessageBox.Show(ex.Message);
            }
        }

        private void set_edit_mode(bool edit)
        {
            groupBox1.Enabled = edit;
            saveButton.Visible = edit;
            cancelButton.Visible = edit;
            editButton.Visible = !edit;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            set_edit_mode(true);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            set_edit_mode(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            set_edit_mode(false);
            partenerBindingSource.CancelEdit();
            partenerBindingSource.ResetBindings(false);
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            set_edit_mode(false);
            commit();
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmati stergerea?", "Confirmare", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                commit();
            }
            else
            {
                partenerBindingSource.CancelEdit();
                partenerBindingSource.ResetBindings(false);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}