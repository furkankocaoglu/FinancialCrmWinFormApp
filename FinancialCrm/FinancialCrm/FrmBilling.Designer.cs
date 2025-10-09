namespace FinancialCrm
{
    partial class FrmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 680);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(42, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button7.Location = new System.Drawing.Point(42, 448);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ayarlar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button6.Location = new System.Drawing.Point(42, 389);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(42, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(42, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Giderler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(42, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Faturalar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBanksForm.Location = new System.Drawing.Point(42, 143);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(205, 44);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(42, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnDeleteBill);
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnBillList);
            this.panel2.Controls.Add(this.txtBillPeriod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(304, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 315);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnUpdateBill.Location = new System.Drawing.Point(775, 237);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(205, 44);
            this.btnUpdateBill.TabIndex = 11;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteBill.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBill.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDeleteBill.Location = new System.Drawing.Point(564, 237);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(205, 44);
            this.btnDeleteBill.TabIndex = 10;
            this.btnDeleteBill.Text = "Ödeme Sil";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateBill.Location = new System.Drawing.Point(353, 237);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(205, 44);
            this.btnCreateBill.TabIndex = 9;
            this.btnCreateBill.Text = "Yeni Ödeme";
            this.btnCreateBill.UseVisualStyleBackColor = false;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBillList.Location = new System.Drawing.Point(142, 237);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(205, 44);
            this.btnBillList.TabIndex = 8;
            this.btnBillList.Text = "Ödeme Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBillPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillPeriod.Location = new System.Drawing.Point(135, 172);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(854, 30);
            this.txtBillPeriod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periyot:";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBillAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillAmount.Location = new System.Drawing.Point(135, 128);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(854, 30);
            this.txtBillAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBillTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillTitle.Location = new System.Drawing.Point(135, 85);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(854, 30);
            this.txtBillTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillId.Location = new System.Drawing.Point(135, 41);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(854, 30);
            this.txtBillId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Id:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(304, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 315);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1347, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme ve Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}