namespace QlkhNamespace
{
    partial class TransactionLog
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
            this.saoke_bt = new System.Windows.Forms.Button();
            this.dgvSaoke = new System.Windows.Forms.DataGridView();
            this.saoke_tb3 = new System.Windows.Forms.TextBox();
            this.saoke_tb2 = new System.Windows.Forms.TextBox();
            this.saoke_tb1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saoke_tb5 = new System.Windows.Forms.DateTimePicker();
            this.saoke_tb4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaoke)).BeginInit();
            this.SuspendLayout();
            // 
            // saoke_bt
            // 
            this.saoke_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saoke_bt.ForeColor = System.Drawing.SystemColors.Control;
            this.saoke_bt.Location = new System.Drawing.Point(320, 196);
            this.saoke_bt.Name = "saoke_bt";
            this.saoke_bt.Size = new System.Drawing.Size(75, 37);
            this.saoke_bt.TabIndex = 31;
            this.saoke_bt.Text = "In";
            this.saoke_bt.UseVisualStyleBackColor = false;
            this.saoke_bt.Click += new System.EventHandler(this.saoke_bt_Click);
            // 
            // dgvSaoke
            // 
            this.dgvSaoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaoke.Location = new System.Drawing.Point(12, 239);
            this.dgvSaoke.Name = "dgvSaoke";
            this.dgvSaoke.Size = new System.Drawing.Size(691, 186);
            this.dgvSaoke.TabIndex = 30;
            // 
            // saoke_tb3
            // 
            this.saoke_tb3.Location = new System.Drawing.Point(122, 133);
            this.saoke_tb3.Name = "saoke_tb3";
            this.saoke_tb3.ReadOnly = true;
            this.saoke_tb3.Size = new System.Drawing.Size(212, 20);
            this.saoke_tb3.TabIndex = 29;
            // 
            // saoke_tb2
            // 
            this.saoke_tb2.Location = new System.Drawing.Point(122, 104);
            this.saoke_tb2.Name = "saoke_tb2";
            this.saoke_tb2.ReadOnly = true;
            this.saoke_tb2.Size = new System.Drawing.Size(212, 20);
            this.saoke_tb2.TabIndex = 28;
            // 
            // saoke_tb1
            // 
            this.saoke_tb1.Location = new System.Drawing.Point(122, 75);
            this.saoke_tb1.Name = "saoke_tb1";
            this.saoke_tb1.ReadOnly = true;
            this.saoke_tb1.Size = new System.Drawing.Size(212, 20);
            this.saoke_tb1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "đến ngày";
            // 
            // saoke_tb5
            // 
            this.saoke_tb5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saoke_tb5.Location = new System.Drawing.Point(410, 162);
            this.saoke_tb5.Name = "saoke_tb5";
            this.saoke_tb5.Size = new System.Drawing.Size(200, 20);
            this.saoke_tb5.TabIndex = 25;
            this.saoke_tb5.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
            // 
            // saoke_tb4
            // 
            this.saoke_tb4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saoke_tb4.Location = new System.Drawing.Point(122, 162);
            this.saoke_tb4.Name = "saoke_tb4";
            this.saoke_tb4.Size = new System.Drawing.Size(200, 20);
            this.saoke_tb4.TabIndex = 24;
            this.saoke_tb4.Value = new System.DateTime(2017, 4, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sao kê từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Loại tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thông báo sao kê tài khoản";
            // 
            // TransactionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 435);
            this.Controls.Add(this.saoke_bt);
            this.Controls.Add(this.dgvSaoke);
            this.Controls.Add(this.saoke_tb3);
            this.Controls.Add(this.saoke_tb2);
            this.Controls.Add(this.saoke_tb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saoke_tb5);
            this.Controls.Add(this.saoke_tb4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionLog";
            this.Text = "TransactionLog";
            this.Load += new System.EventHandler(this.TransactionLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saoke_bt;
        private System.Windows.Forms.DataGridView dgvSaoke;
        private System.Windows.Forms.TextBox saoke_tb3;
        private System.Windows.Forms.TextBox saoke_tb2;
        private System.Windows.Forms.TextBox saoke_tb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker saoke_tb5;
        private System.Windows.Forms.DateTimePicker saoke_tb4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}