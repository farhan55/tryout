namespace WindowsFormsApplication1
{
    partial class home2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namabarangtxt = new System.Windows.Forms.TextBox();
            this.hargabarangtxt = new System.Windows.Forms.TextBox();
            this.jumlahbarangtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hargatotal = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.txtkembali = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(270, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harga Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah Barang";
            // 
            // namabarangtxt
            // 
            this.namabarangtxt.Enabled = false;
            this.namabarangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namabarangtxt.Location = new System.Drawing.Point(237, 340);
            this.namabarangtxt.Name = "namabarangtxt";
            this.namabarangtxt.Size = new System.Drawing.Size(100, 30);
            this.namabarangtxt.TabIndex = 4;
            this.namabarangtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hargabarangtxt
            // 
            this.hargabarangtxt.Enabled = false;
            this.hargabarangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargabarangtxt.Location = new System.Drawing.Point(237, 390);
            this.hargabarangtxt.Name = "hargabarangtxt";
            this.hargabarangtxt.Size = new System.Drawing.Size(100, 30);
            this.hargabarangtxt.TabIndex = 5;
            this.hargabarangtxt.TextChanged += new System.EventHandler(this.hargabarangtxt_TextChanged);
            // 
            // jumlahbarangtxt
            // 
            this.jumlahbarangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahbarangtxt.Location = new System.Drawing.Point(237, 452);
            this.jumlahbarangtxt.Name = "jumlahbarangtxt";
            this.jumlahbarangtxt.Size = new System.Drawing.Size(100, 30);
            this.jumlahbarangtxt.TabIndex = 6;
            this.jumlahbarangtxt.TextChanged += new System.EventHandler(this.jumlahbarangtxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hargatotal
            // 
            this.hargatotal.Location = new System.Drawing.Point(500, 345);
            this.hargatotal.Name = "hargatotal";
            this.hargatotal.Size = new System.Drawing.Size(100, 22);
            this.hargatotal.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namabarang,
            this.jumlahbarang,
            this.hargabarang});
            this.dataGridView2.Location = new System.Drawing.Point(383, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(433, 175);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // namabarang
            // 
            this.namabarang.HeaderText = "namabarang";
            this.namabarang.MinimumWidth = 6;
            this.namabarang.Name = "namabarang";
            this.namabarang.ReadOnly = true;
            this.namabarang.Width = 125;
            // 
            // jumlahbarang
            // 
            this.jumlahbarang.HeaderText = "jumlahbarang";
            this.jumlahbarang.MinimumWidth = 6;
            this.jumlahbarang.Name = "jumlahbarang";
            this.jumlahbarang.ReadOnly = true;
            this.jumlahbarang.Width = 125;
            // 
            // hargabarang
            // 
            this.hargabarang.HeaderText = "hargabarang";
            this.hargabarang.MinimumWidth = 6;
            this.hargabarang.Name = "hargabarang";
            this.hargabarang.ReadOnly = true;
            this.hargabarang.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "uangyangdibayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "kembalian";
            // 
            // txtbayar
            // 
            this.txtbayar.Location = new System.Drawing.Point(500, 392);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(100, 22);
            this.txtbayar.TabIndex = 13;
            this.txtbayar.TextChanged += new System.EventHandler(this.txtbayar_TextChanged);
            // 
            // txtkembali
            // 
            this.txtkembali.Location = new System.Drawing.Point(500, 497);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.Size = new System.Drawing.Size(100, 22);
            this.txtkembali.TabIndex = 14;
            this.txtkembali.TextChanged += new System.EventHandler(this.txtkembali_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "bayar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ke pengiriman";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 612);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtkembali);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.hargatotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jumlahbarangtxt);
            this.Controls.Add(this.hargabarangtxt);
            this.Controls.Add(this.namabarangtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "home2";
            this.Text = "home2";
            this.Load += new System.EventHandler(this.home2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namabarangtxt;
        private System.Windows.Forms.TextBox hargabarangtxt;
        private System.Windows.Forms.TextBox jumlahbarangtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hargatotal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.TextBox txtkembali;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}