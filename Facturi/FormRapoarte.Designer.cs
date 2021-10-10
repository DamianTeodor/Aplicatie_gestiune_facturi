
namespace Facturi
{
    partial class FormRapoarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataSet1 = new Facturi.DataSet1();
            this.AntetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AntetTableAdapter = new Facturi.DataSet1TableAdapters.AntetTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerZiua = new System.Windows.Forms.DateTimePicker();
            this.filterButton = new System.Windows.Forms.Button();
            this.dateTimePickerLuna = new System.Windows.Forms.DateTimePicker();
            this.radioButtonZiua = new System.Windows.Forms.RadioButton();
            this.radioButtonLuna = new System.Windows.Forms.RadioButton();
            this.radioButtonAn = new System.Windows.Forms.RadioButton();
            this.dateTimePickerAnul = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AntetBindingSource
            // 
            this.AntetBindingSource.DataMember = "Antet";
            this.AntetBindingSource.DataSource = this.DataSet1;
            // 
            // AntetTableAdapter
            // 
            this.AntetTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.AntetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePickerZiua
            // 
            this.dateTimePickerZiua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerZiua.Location = new System.Drawing.Point(65, 27);
            this.dateTimePickerZiua.Name = "dateTimePickerZiua";
            this.dateTimePickerZiua.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerZiua.TabIndex = 1;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(618, 24);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filtreaza";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // dateTimePickerLuna
            // 
            this.dateTimePickerLuna.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLuna.Location = new System.Drawing.Point(274, 29);
            this.dateTimePickerLuna.Name = "dateTimePickerLuna";
            this.dateTimePickerLuna.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerLuna.TabIndex = 5;
            // 
            // radioButtonZiua
            // 
            this.radioButtonZiua.AutoSize = true;
            this.radioButtonZiua.Location = new System.Drawing.Point(12, 27);
            this.radioButtonZiua.Name = "radioButtonZiua";
            this.radioButtonZiua.Size = new System.Drawing.Size(46, 17);
            this.radioButtonZiua.TabIndex = 6;
            this.radioButtonZiua.TabStop = true;
            this.radioButtonZiua.Text = "Ziua";
            this.radioButtonZiua.UseVisualStyleBackColor = true;
            // 
            // radioButtonLuna
            // 
            this.radioButtonLuna.AutoSize = true;
            this.radioButtonLuna.Location = new System.Drawing.Point(213, 29);
            this.radioButtonLuna.Name = "radioButtonLuna";
            this.radioButtonLuna.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLuna.TabIndex = 7;
            this.radioButtonLuna.TabStop = true;
            this.radioButtonLuna.Text = "Luna";
            this.radioButtonLuna.UseVisualStyleBackColor = true;
            // 
            // radioButtonAn
            // 
            this.radioButtonAn.AutoSize = true;
            this.radioButtonAn.Location = new System.Drawing.Point(405, 29);
            this.radioButtonAn.Name = "radioButtonAn";
            this.radioButtonAn.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAn.TabIndex = 9;
            this.radioButtonAn.TabStop = true;
            this.radioButtonAn.Text = "Anul";
            this.radioButtonAn.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerAnul
            // 
            this.dateTimePickerAnul.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAnul.Location = new System.Drawing.Point(466, 29);
            this.dateTimePickerAnul.Name = "dateTimePickerAnul";
            this.dateTimePickerAnul.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerAnul.TabIndex = 8;
            // 
            // FormRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonAn);
            this.Controls.Add(this.dateTimePickerAnul);
            this.Controls.Add(this.radioButtonLuna);
            this.Controls.Add(this.radioButtonZiua);
            this.Controls.Add(this.dateTimePickerLuna);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.dateTimePickerZiua);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRapoarte";
            this.Text = "Rapoarte";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource AntetBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.AntetTableAdapter AntetTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerZiua;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerLuna;
        private System.Windows.Forms.RadioButton radioButtonZiua;
        private System.Windows.Forms.RadioButton radioButtonLuna;
        private System.Windows.Forms.RadioButton radioButtonAn;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnul;
    }
}