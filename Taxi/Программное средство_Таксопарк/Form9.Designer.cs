namespace Программное_средство_Таксопарк
{
    partial class Form9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ВодительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KursachDataSet = new Программное_средство_Таксопарк.KursachDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ВодительTableAdapter = new Программное_средство_Таксопарк.KursachDataSetTableAdapters.ВодительTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ВодительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ВодительBindingSource
            // 
            this.ВодительBindingSource.DataMember = "Водитель";
            this.ВодительBindingSource.DataSource = this.KursachDataSet;
            // 
            // KursachDataSet
            // 
            this.KursachDataSet.DataSetName = "KursachDataSet";
            this.KursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ВодительBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(720, 417);
            this.reportViewer1.TabIndex = 2;
            // 
            // ВодительTableAdapter
            // 
            this.ВодительTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.Text = "Отчёт по водителям";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ВодительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursachDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ВодительBindingSource;
        private KursachDataSet KursachDataSet;
        private KursachDataSetTableAdapters.ВодительTableAdapter ВодительTableAdapter;
    }
}