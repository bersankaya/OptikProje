
namespace Optik_Proje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.üRÜNLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELLERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fİYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hareketProjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hareketProjeDataSet = new Optik_Proje.HareketProjeDataSet();
            this.hareketProjeTableAdapter = new Optik_Proje.HareketProjeDataSetTableAdapters.HareketProjeTableAdapter();
            this.hareketProjeDataSet1 = new Optik_Proje.HareketProjeDataSet1();
            this.hAREKETLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hAREKETLERTableAdapter = new Optik_Proje.HareketProjeDataSet1TableAdapters.HAREKETLERTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbPersonel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUrunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtSatisfiyat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblStok = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUrunAd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hAREKETLERBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.üRÜNLERDataGridViewTextBoxColumn,
            this.mÜŞTERİLERDataGridViewTextBoxColumn,
            this.pERSONELLERDataGridViewTextBoxColumn,
            this.fİYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hareketProjeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // üRÜNLERDataGridViewTextBoxColumn
            // 
            this.üRÜNLERDataGridViewTextBoxColumn.DataPropertyName = "ÜRÜNLER";
            this.üRÜNLERDataGridViewTextBoxColumn.HeaderText = "ÜRÜNLER";
            this.üRÜNLERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üRÜNLERDataGridViewTextBoxColumn.Name = "üRÜNLERDataGridViewTextBoxColumn";
            // 
            // mÜŞTERİLERDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİLERDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİLER";
            this.mÜŞTERİLERDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİLER";
            this.mÜŞTERİLERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİLERDataGridViewTextBoxColumn.Name = "mÜŞTERİLERDataGridViewTextBoxColumn";
            // 
            // pERSONELLERDataGridViewTextBoxColumn
            // 
            this.pERSONELLERDataGridViewTextBoxColumn.DataPropertyName = "PERSONELLER";
            this.pERSONELLERDataGridViewTextBoxColumn.HeaderText = "PERSONELLER";
            this.pERSONELLERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELLERDataGridViewTextBoxColumn.Name = "pERSONELLERDataGridViewTextBoxColumn";
            // 
            // fİYATDataGridViewTextBoxColumn
            // 
            this.fİYATDataGridViewTextBoxColumn.DataPropertyName = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.HeaderText = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fİYATDataGridViewTextBoxColumn.Name = "fİYATDataGridViewTextBoxColumn";
            // 
            // hareketProjeBindingSource
            // 
            this.hareketProjeBindingSource.DataMember = "HareketProje";
            this.hareketProjeBindingSource.DataSource = this.hareketProjeDataSet;
            // 
            // hareketProjeDataSet
            // 
            this.hareketProjeDataSet.DataSetName = "HareketProjeDataSet";
            this.hareketProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketProjeTableAdapter
            // 
            this.hareketProjeTableAdapter.ClearBeforeFill = true;
            // 
            // hareketProjeDataSet1
            // 
            this.hareketProjeDataSet1.DataSetName = "HareketProjeDataSet1";
            this.hareketProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hAREKETLERBindingSource
            // 
            this.hAREKETLERBindingSource.DataMember = "HAREKETLER";
            this.hAREKETLERBindingSource.DataSource = this.hareketProjeDataSet1;
            // 
            // hAREKETLERTableAdapter
            // 
            this.hAREKETLERTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbPersonel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbMusteri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbUrunler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Satış";
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(165, 239);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(119, 44);
            this.BtnSatisYap.TabIndex = 8;
            this.BtnSatisYap.Text = "Satış Yap";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(95, 193);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(189, 34);
            this.TxtFiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // CmbPersonel
            // 
            this.CmbPersonel.FormattingEnabled = true;
            this.CmbPersonel.Location = new System.Drawing.Point(95, 146);
            this.CmbPersonel.Name = "CmbPersonel";
            this.CmbPersonel.Size = new System.Drawing.Size(189, 35);
            this.CmbPersonel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel";
            // 
            // CmbMusteri
            // 
            this.CmbMusteri.FormattingEnabled = true;
            this.CmbMusteri.Location = new System.Drawing.Point(95, 105);
            this.CmbMusteri.Name = "CmbMusteri";
            this.CmbMusteri.Size = new System.Drawing.Size(189, 35);
            this.CmbMusteri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri:";
            // 
            // CmbUrunler
            // 
            this.CmbUrunler.FormattingEnabled = true;
            this.CmbUrunler.Location = new System.Drawing.Point(95, 64);
            this.CmbUrunler.Name = "CmbUrunler";
            this.CmbUrunler.Size = new System.Drawing.Size(189, 35);
            this.CmbUrunler.TabIndex = 1;
            this.CmbUrunler.SelectedIndexChanged += new System.EventHandler(this.CmbUrunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnListele);
            this.groupBox3.Controls.Add(this.BtnEkle);
            this.groupBox3.Controls.Add(this.TxtSatisfiyat);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TxtAlisFiyat);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TxtStok);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtAd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(886, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 363);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Ekle";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(166, 276);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(119, 32);
            this.BtnListele.TabIndex = 17;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(166, 239);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(119, 31);
            this.BtnEkle.TabIndex = 16;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtSatisfiyat
            // 
            this.TxtSatisfiyat.Location = new System.Drawing.Point(133, 189);
            this.TxtSatisfiyat.Name = "TxtSatisfiyat";
            this.TxtSatisfiyat.Size = new System.Drawing.Size(189, 34);
            this.TxtSatisfiyat.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 27);
            this.label13.TabIndex = 14;
            this.label13.Text = "Satış fiyat:";
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Location = new System.Drawing.Point(133, 149);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(189, 34);
            this.TxtAlisFiyat.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 27);
            this.label12.TabIndex = 12;
            this.label12.Text = "Alış Fiyat:";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(133, 108);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(189, 34);
            this.TxtStok.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Stok:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(133, 68);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(189, 34);
            this.TxtAd.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LblStok);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LblUrunAd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(351, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 349);
            this.panel1.TabIndex = 3;
            // 
            // LblStok
            // 
            this.LblStok.AutoSize = true;
            this.LblStok.BackColor = System.Drawing.Color.Black;
            this.LblStok.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStok.Location = new System.Drawing.Point(304, 205);
            this.LblStok.Name = "LblStok";
            this.LblStok.Size = new System.Drawing.Size(41, 45);
            this.LblStok.TabIndex = 5;
            this.LblStok.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 45);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // LblUrunAd
            // 
            this.LblUrunAd.AutoSize = true;
            this.LblUrunAd.BackColor = System.Drawing.Color.Black;
            this.LblUrunAd.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrunAd.Location = new System.Drawing.Point(276, 155);
            this.LblUrunAd.Name = "LblUrunAd";
            this.LblUrunAd.Size = new System.Drawing.Size(114, 45);
            this.LblUrunAd.TabIndex = 3;
            this.LblUrunAd.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 45);
            this.label6.TabIndex = 2;
            this.label6.Text = "ÜRÜN AD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "ÜRÜN BİLGİSİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1231, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hAREKETLERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HareketProjeDataSet hareketProjeDataSet;
        private System.Windows.Forms.BindingSource hareketProjeBindingSource;
        private HareketProjeDataSetTableAdapters.HareketProjeTableAdapter hareketProjeTableAdapter;
        private HareketProjeDataSet1 hareketProjeDataSet1;
        private System.Windows.Forms.BindingSource hAREKETLERBindingSource;
        private HareketProjeDataSet1TableAdapters.HAREKETLERTableAdapter hAREKETLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn üRÜNLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELLERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fİYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtSatisfiyat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUrunAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

