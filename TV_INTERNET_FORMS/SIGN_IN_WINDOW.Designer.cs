
namespace TV_INTERNET_FORMS
{
    partial class SIGN_IN_WINDOW
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
            this.lb_login_user_name = new System.Windows.Forms.Label();
            this.tb_user_name_enter = new System.Windows.Forms.TextBox();
            this.tb_password_enter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_login_user_name
            // 
            this.lb_login_user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_login_user_name.AutoSize = true;
            this.lb_login_user_name.Location = new System.Drawing.Point(12, 47);
            this.lb_login_user_name.Name = "lb_login_user_name";
            this.lb_login_user_name.Size = new System.Drawing.Size(79, 20);
            this.lb_login_user_name.TabIndex = 0;
            this.lb_login_user_name.Text = "User name";
            // 
            // tb_user_name_enter
            // 
            this.tb_user_name_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_user_name_enter.Location = new System.Drawing.Point(97, 44);
            this.tb_user_name_enter.Name = "tb_user_name_enter";
            this.tb_user_name_enter.Size = new System.Drawing.Size(258, 27);
            this.tb_user_name_enter.TabIndex = 1;
            // 
            // tb_password_enter
            // 
            this.tb_password_enter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password_enter.Location = new System.Drawing.Point(97, 77);
            this.tb_password_enter.Name = "tb_password_enter";
            this.tb_password_enter.Size = new System.Drawing.Size(258, 27);
            this.tb_password_enter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sign_in.Location = new System.Drawing.Point(25, 131);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(343, 59);
            this.btn_sign_in.TabIndex = 4;
            this.btn_sign_in.Text = "SIGN IN";
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "First time?";
            // 
            // linkLabel_Register
            // 
            this.linkLabel_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Register.AutoSize = true;
            this.linkLabel_Register.Location = new System.Drawing.Point(97, 207);
            this.linkLabel_Register.Name = "linkLabel_Register";
            this.linkLabel_Register.Size = new System.Drawing.Size(99, 20);
            this.linkLabel_Register.TabIndex = 6;
            this.linkLabel_Register.TabStop = true;
            this.linkLabel_Register.Text = "Register now!";
            this.linkLabel_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Register_LinkClicked);
            // 
            // SIGN_IN_WINDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 249);
            this.Controls.Add(this.linkLabel_Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.tb_password_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_user_name_enter);
            this.Controls.Add(this.lb_login_user_name);
            this.Name = "SIGN_IN_WINDOW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in page";
            this.Load += new System.EventHandler(this.SIGN_IN_WINDOW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login_user_name;
        private System.Windows.Forms.TextBox tb_user_name_enter;
        private System.Windows.Forms.TextBox tb_password_enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_Register;
    }
}