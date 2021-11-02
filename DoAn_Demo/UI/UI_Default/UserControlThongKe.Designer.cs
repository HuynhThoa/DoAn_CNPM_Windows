
namespace DoAn_Demo.UI
{
    partial class UserControlThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewerThongKe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerThongKe
            // 
            this.reportViewerThongKe.LocalReport.ReportEmbeddedResource = "DoAn_Demo.Reports.ReportXepLoaiHocSinh.rdlc";
            this.reportViewerThongKe.Location = new System.Drawing.Point(15, 20);
            this.reportViewerThongKe.Name = "reportViewerThongKe";
            this.reportViewerThongKe.ServerReport.BearerToken = null;
            this.reportViewerThongKe.Size = new System.Drawing.Size(1489, 611);
            this.reportViewerThongKe.TabIndex = 0;
            // 
            // UserControlThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewerThongKe);
            this.Name = "UserControlThongKe";
            this.Size = new System.Drawing.Size(1522, 649);
            this.Load += new System.EventHandler(this.UserControlThongKe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThongKe;
    }
}
