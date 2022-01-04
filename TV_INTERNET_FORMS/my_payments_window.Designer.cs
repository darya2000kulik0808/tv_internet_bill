
namespace TV_INTERNET_FORMS
{
    partial class my_payments_window
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
            this.datagv_my_payments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagv_my_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // datagv_my_payments
            // 
            this.datagv_my_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv_my_payments.Location = new System.Drawing.Point(13, 13);
            this.datagv_my_payments.Name = "datagv_my_payments";
            this.datagv_my_payments.RowHeadersWidth = 51;
            this.datagv_my_payments.RowTemplate.Height = 29;
            this.datagv_my_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagv_my_payments.Size = new System.Drawing.Size(775, 425);
            this.datagv_my_payments.TabIndex = 0;
            // 
            // my_payments_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagv_my_payments);
            this.Name = "my_payments_window";
            this.Text = "History of my payments";
            this.Load += new System.EventHandler(this.my_payments_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv_my_payments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagv_my_payments;
    }
}