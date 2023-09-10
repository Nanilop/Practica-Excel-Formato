namespace ExcelC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBExportar = new System.Windows.Forms.ProgressBar();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new ExcelC.NorthwindDataSet();
            this.sales_by_CategoryTableAdapter = new ExcelC.NorthwindDataSetTableAdapters.Sales_by_CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PBExportar
            // 
            this.PBExportar.Location = new System.Drawing.Point(12, 214);
            this.PBExportar.Name = "PBExportar";
            this.PBExportar.Size = new System.Drawing.Size(450, 23);
            this.PBExportar.TabIndex = 11;
            this.PBExportar.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(387, 41);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(387, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(315, 19);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Consulte y exporte las ventas por categoria";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(255, 30);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ventas por Categoria";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoGenerateColumns = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn});
            this.DGV.DataSource = this.salesByCategoryBindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 70);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(450, 339);
            this.DGV.TabIndex = 6;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Monto";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Año";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Mes";
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesByCategoryBindingSource
            // 
            this.salesByCategoryBindingSource.DataMember = "Sales by Category";
            this.salesByCategoryBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sales_by_CategoryTableAdapter
            // 
            this.sales_by_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 419);
            this.Controls.Add(this.PBExportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "ExcelC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar PBExportar;
        internal System.Windows.Forms.Button btnExportar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DGV;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource salesByCategoryBindingSource;
        private NorthwindDataSetTableAdapters.Sales_by_CategoryTableAdapter sales_by_CategoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
    }
}

