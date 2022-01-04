
namespace TV_INTERNET_FORMS
{
    partial class TOP_UP_payment
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
            this.comboBox_method_pay = new System.Windows.Forms.ComboBox();
            this.CB_mail = new System.Windows.Forms.CheckBox();
            this.lb_method = new System.Windows.Forms.Label();
            this.panel_card = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_amountC = new System.Windows.Forms.NumericUpDown();
            this.lb_card_number = new System.Windows.Forms.Label();
            this.tb_cvv2_cvc2 = new System.Windows.Forms.TextBox();
            this.tb_card_number = new System.Windows.Forms.TextBox();
            this.num_amountT = new System.Windows.Forms.NumericUpDown();
            this.lb_amount = new System.Windows.Forms.Label();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.lb_telefon = new System.Windows.Forms.Label();
            this.panel_telephone = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.panel_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountT)).BeginInit();
            this.panel_telephone.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_method_pay
            // 
            this.comboBox_method_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_method_pay.FormattingEnabled = true;
            this.comboBox_method_pay.Location = new System.Drawing.Point(12, 175);
            this.comboBox_method_pay.Name = "comboBox_method_pay";
            this.comboBox_method_pay.Size = new System.Drawing.Size(342, 28);
            this.comboBox_method_pay.TabIndex = 0;
            this.comboBox_method_pay.SelectedIndexChanged += new System.EventHandler(this.comboBox_method_pay_SelectedIndexChanged);
            // 
            // CB_mail
            // 
            this.CB_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_mail.AutoSize = true;
            this.CB_mail.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_mail.Location = new System.Drawing.Point(35, 227);
            this.CB_mail.Name = "CB_mail";
            this.CB_mail.Size = new System.Drawing.Size(274, 31);
            this.CB_mail.TabIndex = 1;
            this.CB_mail.Text = "Send me receipt via E-mail";
            this.CB_mail.UseVisualStyleBackColor = true;
            // 
            // lb_method
            // 
            this.lb_method.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_method.AutoSize = true;
            this.lb_method.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_method.Location = new System.Drawing.Point(12, 134);
            this.lb_method.Name = "lb_method";
            this.lb_method.Size = new System.Drawing.Size(342, 27);
            this.lb_method.TabIndex = 2;
            this.lb_method.Text = "Choose the method of the payment ";
            // 
            // panel_card
            // 
            this.panel_card.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_card.Controls.Add(this.label4);
            this.panel_card.Controls.Add(this.label3);
            this.panel_card.Controls.Add(this.num_amountC);
            this.panel_card.Controls.Add(this.lb_card_number);
            this.panel_card.Controls.Add(this.tb_cvv2_cvc2);
            this.panel_card.Controls.Add(this.tb_card_number);
            this.panel_card.Enabled = false;
            this.panel_card.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_card.Location = new System.Drawing.Point(360, 188);
            this.panel_card.Name = "panel_card";
            this.panel_card.Size = new System.Drawing.Size(549, 235);
            this.panel_card.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVC2/CVV2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount of payment";
            // 
            // num_amountC
            // 
            this.num_amountC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_amountC.Location = new System.Drawing.Point(209, 171);
            this.num_amountC.Name = "num_amountC";
            this.num_amountC.Size = new System.Drawing.Size(325, 34);
            this.num_amountC.TabIndex = 5;
            // 
            // lb_card_number
            // 
            this.lb_card_number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_card_number.AutoSize = true;
            this.lb_card_number.Location = new System.Drawing.Point(17, 15);
            this.lb_card_number.Name = "lb_card_number";
            this.lb_card_number.Size = new System.Drawing.Size(133, 27);
            this.lb_card_number.TabIndex = 0;
            this.lb_card_number.Text = "Card number";
            // 
            // tb_cvv2_cvc2
            // 
            this.tb_cvv2_cvc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_cvv2_cvc2.Location = new System.Drawing.Point(156, 72);
            this.tb_cvv2_cvc2.Name = "tb_cvv2_cvc2";
            this.tb_cvv2_cvc2.Size = new System.Drawing.Size(378, 34);
            this.tb_cvv2_cvc2.TabIndex = 3;
            // 
            // tb_card_number
            // 
            this.tb_card_number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_card_number.Location = new System.Drawing.Point(156, 15);
            this.tb_card_number.Name = "tb_card_number";
            this.tb_card_number.Size = new System.Drawing.Size(378, 34);
            this.tb_card_number.TabIndex = 1;
            // 
            // num_amountT
            // 
            this.num_amountT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_amountT.Location = new System.Drawing.Point(220, 67);
            this.num_amountT.Name = "num_amountT";
            this.num_amountT.Size = new System.Drawing.Size(318, 34);
            this.num_amountT.TabIndex = 3;
            // 
            // lb_amount
            // 
            this.lb_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(18, 69);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(196, 27);
            this.lb_amount.TabIndex = 2;
            this.lb_amount.Text = "Amount of payment";
            // 
            // tb_telephone
            // 
            this.tb_telephone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_telephone.Location = new System.Drawing.Point(209, 14);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(329, 34);
            this.tb_telephone.TabIndex = 1;
            // 
            // lb_telefon
            // 
            this.lb_telefon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_telefon.AutoSize = true;
            this.lb_telefon.Location = new System.Drawing.Point(18, 17);
            this.lb_telefon.Name = "lb_telefon";
            this.lb_telefon.Size = new System.Drawing.Size(185, 27);
            this.lb_telefon.TabIndex = 0;
            this.lb_telefon.Text = "Telephone number";
            // 
            // panel_telephone
            // 
            this.panel_telephone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_telephone.Controls.Add(this.num_amountT);
            this.panel_telephone.Controls.Add(this.label2);
            this.panel_telephone.Controls.Add(this.lb_amount);
            this.panel_telephone.Controls.Add(this.label1);
            this.panel_telephone.Controls.Add(this.lb_telefon);
            this.panel_telephone.Controls.Add(this.tb_telephone);
            this.panel_telephone.Enabled = false;
            this.panel_telephone.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_telephone.Location = new System.Drawing.Point(360, 22);
            this.panel_telephone.Name = "panel_telephone";
            this.panel_telephone.Size = new System.Drawing.Size(549, 160);
            this.panel_telephone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, -57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount of payment";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "CVC2/CVV2";
            // 
            // btn_pay
            // 
            this.btn_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pay.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pay.Location = new System.Drawing.Point(49, 285);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(260, 38);
            this.btn_pay.TabIndex = 5;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // TOP_UP_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 454);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.panel_telephone);
            this.Controls.Add(this.panel_card);
            this.Controls.Add(this.lb_method);
            this.Controls.Add(this.CB_mail);
            this.Controls.Add(this.comboBox_method_pay);
            this.Name = "TOP_UP_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Up ";
            this.Load += new System.EventHandler(this.TOP_UP_payment_Load);
            this.panel_card.ResumeLayout(false);
            this.panel_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_amountT)).EndInit();
            this.panel_telephone.ResumeLayout(false);
            this.panel_telephone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_method_pay;
        private System.Windows.Forms.CheckBox CB_mail;
        private System.Windows.Forms.Label lb_method;
        private System.Windows.Forms.Panel panel_card;
        private System.Windows.Forms.NumericUpDown num_amountT;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.Label lb_telefon;
        private System.Windows.Forms.Panel panel_telephone;
        private System.Windows.Forms.NumericUpDown num_amountC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cvv2_cvc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_card_number;
        private System.Windows.Forms.Label lb_card_number;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}