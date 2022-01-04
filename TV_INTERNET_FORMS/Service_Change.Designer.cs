
namespace TV_INTERNET_FORMS
{
    partial class Service_Change
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
            this.DGV_Change_service = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Change_service)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Change_service
            // 
            this.DGV_Change_service.AllowUserToAddRows = false;
            this.DGV_Change_service.AllowUserToDeleteRows = false;
            this.DGV_Change_service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Change_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Change_service.Location = new System.Drawing.Point(12, 12);
            this.DGV_Change_service.MultiSelect = false;
            this.DGV_Change_service.Name = "DGV_Change_service";
            this.DGV_Change_service.ReadOnly = true;
            this.DGV_Change_service.RowHeadersWidth = 51;
            this.DGV_Change_service.RowTemplate.Height = 29;
            this.DGV_Change_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Change_service.Size = new System.Drawing.Size(849, 431);
            this.DGV_Change_service.TabIndex = 0;
            this.DGV_Change_service.DoubleClick += new System.EventHandler(this.DGV_Change_service_DoubleClick);
            // 
            // Service_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 455);
            this.Controls.Add(this.DGV_Change_service);
            this.Name = "Service_Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Change";
            this.Load += new System.EventHandler(this.Service_Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Change_service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Change_service;
    }
}