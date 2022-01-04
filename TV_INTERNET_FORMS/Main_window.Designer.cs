
namespace TV_INTERNET_FORMS
{
    partial class Main_window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Client_show = new System.Windows.Forms.Button();
            this.btn_Service_show = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DGV_lists = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lists)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Client_show
            // 
            this.btn_Client_show.Location = new System.Drawing.Point(171, 3);
            this.btn_Client_show.Name = "btn_Client_show";
            this.btn_Client_show.Size = new System.Drawing.Size(162, 29);
            this.btn_Client_show.TabIndex = 0;
            this.btn_Client_show.Text = "Clients List";
            this.btn_Client_show.UseVisualStyleBackColor = true;
            this.btn_Client_show.Click += new System.EventHandler(this.btn_Client_show_Click);
            // 
            // btn_Service_show
            // 
            this.btn_Service_show.Location = new System.Drawing.Point(3, 3);
            this.btn_Service_show.Name = "btn_Service_show";
            this.btn_Service_show.Size = new System.Drawing.Size(162, 29);
            this.btn_Service_show.TabIndex = 1;
            this.btn_Service_show.Text = "Services List";
            this.btn_Service_show.UseVisualStyleBackColor = true;
            this.btn_Service_show.Click += new System.EventHandler(this.btn_Service_show_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Service_show);
            this.flowLayoutPanel1.Controls.Add(this.btn_Client_show);
            this.flowLayoutPanel1.Controls.Add(this.DGV_lists);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 567);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // DGV_lists
            // 
            this.DGV_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_lists.Location = new System.Drawing.Point(3, 38);
            this.DGV_lists.Name = "DGV_lists";
            this.DGV_lists.RowHeadersWidth = 51;
            this.DGV_lists.RowTemplate.Height = 29;
            this.DGV_lists.Size = new System.Drawing.Size(846, 519);
            this.DGV_lists.TabIndex = 3;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Main_window";
            this.Text = "Main Window";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_lists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Client_show;
        private System.Windows.Forms.Button btn_Service_show;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView DGV_lists;
    }
}

