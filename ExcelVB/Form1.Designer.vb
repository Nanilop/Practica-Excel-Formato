<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.CategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesByCategoryBindingSource4 = New System.Windows.Forms.BindingSource()
        Me.NorthwindDataSet2 = New ExcelVB.NorthwindDataSet()
        Me.SalesByCategoryBindingSource3 = New System.Windows.Forms.BindingSource()
        Me.NorthwindDataSet1BindingSource = New System.Windows.Forms.BindingSource()
        Me.NorthwindDataSet1 = New ExcelVB.NorthwindDataSet()
        Me.SalesByCategoryBindingSource = New System.Windows.Forms.BindingSource()
        Me.NorthwindDataSetBindingSource = New System.Windows.Forms.BindingSource()
        Me.NorthwindDataSet = New ExcelVB.NorthwindDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.PBExportar = New System.Windows.Forms.ProgressBar()
        Me.Sales_by_CategoryTableAdapter = New ExcelVB.NorthwindDataSetTableAdapters.Sales_by_CategoryTableAdapter()
        Me.SalesByCategoryBindingSource1 = New System.Windows.Forms.BindingSource()
        Me.SalesByCategoryBindingSource2 = New System.Windows.Forms.BindingSource()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesByCategoryBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesByCategoryBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesByCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesByCategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesByCategoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryNameDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn, Me.Expr2DataGridViewTextBoxColumn, Me.Expr3DataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.SalesByCategoryBindingSource4
        Me.DGV.Location = New System.Drawing.Point(12, 70)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(450, 339)
        Me.DGV.TabIndex = 0
        '
        'CategoryNameDataGridViewTextBoxColumn
        '
        Me.CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn"
        Me.CategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "Año"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr3DataGridViewTextBoxColumn
        '
        Me.Expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3"
        Me.Expr3DataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.Expr3DataGridViewTextBoxColumn.Name = "Expr3DataGridViewTextBoxColumn"
        Me.Expr3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesByCategoryBindingSource4
        '
        Me.SalesByCategoryBindingSource4.DataMember = "Sales by Category"
        Me.SalesByCategoryBindingSource4.DataSource = Me.NorthwindDataSet2
        '
        'NorthwindDataSet2
        '
        Me.NorthwindDataSet2.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesByCategoryBindingSource3
        '
        Me.SalesByCategoryBindingSource3.DataMember = "Sales by Category"
        Me.SalesByCategoryBindingSource3.DataSource = Me.NorthwindDataSet1BindingSource
        '
        'NorthwindDataSet1BindingSource
        '
        Me.NorthwindDataSet1BindingSource.DataSource = Me.NorthwindDataSet1
        Me.NorthwindDataSet1BindingSource.Position = 0
        '
        'NorthwindDataSet1
        '
        Me.NorthwindDataSet1.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesByCategoryBindingSource
        '
        Me.SalesByCategoryBindingSource.DataMember = "Sales by Category"
        Me.SalesByCategoryBindingSource.DataSource = Me.NorthwindDataSetBindingSource
        '
        'NorthwindDataSetBindingSource
        '
        Me.NorthwindDataSetBindingSource.DataSource = Me.NorthwindDataSet
        Me.NorthwindDataSetBindingSource.Position = 0
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ventas por Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Consulte y exporte las ventas por categoria"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(387, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(387, 41)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'PBExportar
        '
        Me.PBExportar.Location = New System.Drawing.Point(12, 214)
        Me.PBExportar.Name = "PBExportar"
        Me.PBExportar.Size = New System.Drawing.Size(450, 23)
        Me.PBExportar.TabIndex = 5
        Me.PBExportar.Visible = False
        '
        'Sales_by_CategoryTableAdapter
        '
        Me.Sales_by_CategoryTableAdapter.ClearBeforeFill = True
        '
        'SalesByCategoryBindingSource1
        '
        Me.SalesByCategoryBindingSource1.DataMember = "Sales by Category"
        Me.SalesByCategoryBindingSource1.DataSource = Me.NorthwindDataSet1
        '
        'SalesByCategoryBindingSource2
        '
        Me.SalesByCategoryBindingSource2.DataMember = "Sales by Category"
        Me.SalesByCategoryBindingSource2.DataSource = Me.NorthwindDataSet1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 421)
        Me.Controls.Add(Me.PBExportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "Form1"
        Me.Text = "ExcelVB"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesByCategoryBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesByCategoryBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesByCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesByCategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesByCategoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents NorthwindDataSetBindingSource As BindingSource
    Friend WithEvents NorthwindDataSet As NorthwindDataSet
    Friend WithEvents SalesByCategoryBindingSource As BindingSource
    Friend WithEvents Sales_by_CategoryTableAdapter As NorthwindDataSetTableAdapters.Sales_by_CategoryTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents NorthwindDataSet1 As NorthwindDataSet
    Friend WithEvents SalesByCategoryBindingSource1 As BindingSource
    Friend WithEvents SalesByCategoryBindingSource2 As BindingSource
    Friend WithEvents NorthwindDataSet1BindingSource As BindingSource
    Friend WithEvents SalesByCategoryBindingSource3 As BindingSource
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PBExportar As ProgressBar
    Friend WithEvents NorthwindDataSet2 As NorthwindDataSet
    Friend WithEvents SalesByCategoryBindingSource4 As BindingSource
End Class
