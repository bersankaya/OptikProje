
namespace Optik_Proje
{
    partial class FRMURUN
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
            this.hareketProjeDataSet3 = new Optik_Proje.HareketProjeDataSet3();
            this.uRUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRUNLERTableAdapter = new Optik_Proje.HareketProjeDataSet3TableAdapters.URUNLERTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sTOKDataGridViewTextBoxColumn,
            this.aLISFIYATDataGridViewTextBoxColumn,
            this.sATISFIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uRUNLERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 639);
            this.dataGridView1.TabIndex = 0;
            // 
            // hareketProjeDataSet3
            // 
            this.hareketProjeDataSet3.DataSetName = "HareketProjeDataSet3";
            this.hareketProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNLERBindingSource
            // 
            this.uRUNLERBindingSource.DataMember = "URUNLER";
            this.uRUNLERBindingSource.DataSource = this.hareketProjeDataSet3;
            // 
            // uRUNLERTableAdapter
            // 
            this.uRUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sTOKDataGridViewTextBoxColumn
            // 
            this.sTOKDataGridViewTextBoxColumn.DataPropertyName = "STOK";
            this.sTOKDataGridViewTextBoxColumn.HeaderText = "STOK";
            this.sTOKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOKDataGridViewTextBoxColumn.Name = "sTOKDataGridViewTextBoxColumn";
            // 
            // aLISFIYATDataGridViewTextBoxColumn
            // 
            this.aLISFIYATDataGridViewTextBoxColumn.DataPropertyName = "ALISFIYAT";
            this.aLISFIYATDataGridViewTextBoxColumn.HeaderText = "ALISFIYAT";
            this.aLISFIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLISFIYATDataGridViewTextBoxColumn.Name = "aLISFIYATDataGridViewTextBoxColumn";
            // 
            // sATISFIYATDataGridViewTextBoxColumn
            // 
            this.sATISFIYATDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYAT";
            this.sATISFIYATDataGridViewTextBoxColumn.HeaderText = "SATISFIYAT";
            this.sATISFIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sATISFIYATDataGridViewTextBoxColumn.Name = "sATISFIYATDataGridViewTextBoxColumn";
            // 
            // FRMURUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 639);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FRMURUN";
            this.Text = "FRMURUN";
            this.Load += new System.EventHandler(this.FRMURUN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketProjeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HareketProjeDataSet3 hareketProjeDataSet3;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource;
        private HareketProjeDataSet3TableAdapters.URUNLERTableAdapter uRUNLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATDataGridViewTextBoxColumn;
    }
}