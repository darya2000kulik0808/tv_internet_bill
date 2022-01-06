
namespace TV_INTERNET_FORMS
{
    partial class ChoiseOfSericeSource
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DB_choice = new System.Windows.Forms.Button();
            this.btn_file_choice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the source for list of services";
            // 
            // btn_DB_choice
            // 
            this.btn_DB_choice.Location = new System.Drawing.Point(28, 56);
            this.btn_DB_choice.Name = "btn_DB_choice";
            this.btn_DB_choice.Size = new System.Drawing.Size(115, 37);
            this.btn_DB_choice.TabIndex = 1;
            this.btn_DB_choice.Text = "Data Base";
            this.btn_DB_choice.UseVisualStyleBackColor = true;
            this.btn_DB_choice.Click += new System.EventHandler(this.btn_DB_choice_Click);
            // 
            // btn_file_choice
            // 
            this.btn_file_choice.Location = new System.Drawing.Point(192, 56);
            this.btn_file_choice.Name = "btn_file_choice";
            this.btn_file_choice.Size = new System.Drawing.Size(115, 37);
            this.btn_file_choice.TabIndex = 2;
            this.btn_file_choice.Text = "File Source";
            this.btn_file_choice.UseVisualStyleBackColor = true;
            this.btn_file_choice.Click += new System.EventHandler(this.btn_file_choice_Click);
            // 
            // ChoiseOfSericeSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 127);
            this.Controls.Add(this.btn_file_choice);
            this.Controls.Add(this.btn_DB_choice);
            this.Controls.Add(this.label1);
            this.Name = "ChoiseOfSericeSource";
            this.Text = "Service List Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DB_choice;
        private System.Windows.Forms.Button btn_file_choice;
    }
}