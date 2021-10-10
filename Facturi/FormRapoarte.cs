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
    public partial class FormRapoarte : Form
    {
        public FormRapoarte()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Antet' table. You can move, or remove it, as needed.
            this.AntetTableAdapter.Fill(this.DataSet1.Antet);
            // TODO: This line of code loads data into the 'DataSet1.Antet' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            dateTimePickerLuna.CustomFormat = "MM-yyyy";
            dateTimePickerAnul.CustomFormat = "yyyy";
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string filter = "";
            if (radioButtonZiua.Checked == true)
            {
                filter += "Data <= '" + dateTimePickerZiua.Value.ToString("yyyy-MM-dd") + "' AND Data >= '" + dateTimePickerZiua.Value.ToString("yyyy-MM-dd") + "'"; ;
            }
            if(radioButtonLuna.Checked == true)
            {
                filter += "Data >= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-01") + "' AND Data <= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-31") + "'";
            }
            if(radioButtonAn.Checked == true)
            {
                filter += "Data >= '" + dateTimePickerAnul.Value.ToString("yyyy-01-01") + "' AND Data <= '" + dateTimePickerAnul.Value.ToString("yyyy-12-30") + "'";
            }
            try
            {
                AntetBindingSource.Filter = filter;
            }
            catch (EvaluateException ex)
            {
                try
                {
                    AntetBindingSource.Filter = "Data >= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-01") + "' AND Data <= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-30") + "'";

                }
                catch(EvaluateException ex2)
                {
                    try
                    {
                        AntetBindingSource.Filter = "Data >= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-01") + "' AND Data <= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-29") + "'";
                    }
                    catch(EvaluateException ex3)
                    {
                        AntetBindingSource.Filter = "Data >= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-01") + "' AND Data <= '" + dateTimePickerLuna.Value.ToString("yyyy-MM-28") + "'";

                    }
                }
            }
            reportViewer1.RefreshReport();
        }
    }
}