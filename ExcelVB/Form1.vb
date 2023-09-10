Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet2.Sales_by_Category' Puede moverla o quitarla según sea necesario.


        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet.Sales_by_Category' Puede moverla o quitarla según sea necesario.
        btnExportar.Enabled = False

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Sales_by_CategoryTableAdapter.Fill(Me.NorthwindDataSet.Sales_by_Category)
        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet1.Sales_by_Category' Puede moverla o quitarla según sea necesario.
        Me.Sales_by_CategoryTableAdapter.Fill(Me.NorthwindDataSet1.Sales_by_Category)
        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet1.Sales_by_Category' Puede moverla o quitarla según sea necesario.
        Me.Sales_by_CategoryTableAdapter.Fill(Me.NorthwindDataSet1.Sales_by_Category)
        'TODO: esta línea de código carga datos en la tabla 'NorthwindDataSet1.Sales_by_Category' Puede moverla o quitarla según sea necesario.
        Me.Sales_by_CategoryTableAdapter.Fill(Me.NorthwindDataSet1.Sales_by_Category)
        Me.Sales_by_CategoryTableAdapter.Fill(Me.NorthwindDataSet2.Sales_by_Category)
        btnExportar.Enabled = True
        PBExportar.Maximum = DGV.Rows.Count
    End Sub
    '  Select Case
    '    [CategoryName]
    '    ,[ProductName]
    '    ,sum([ProductSales])
    '    ,year([orderDate]), MONTH(OrderDate)
    'FROM [Northwind].[dbo].[Sales by Category]
    'group by year(OrderDate), MONTH(OrderDate),[CategoryName]
    '    ,[ProductName]
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        btnBuscar.Enabled = False
        btnExportar.Enabled = False
        DGV.Enabled = False
        PBExportar.Value = 0
        PBExportar.Visible = True
        Dim aplicacion As Excel.Application
        Dim libros_trabajo As Excel.Workbook
        Dim hoja_trabajo As Excel.Worksheet
        aplicacion = New Excel.Application()

        libros_trabajo = aplicacion.Workbooks.Open(Path.GetFullPath("..\\..\\Resources\\") + "Plantilla.xlsx", [ReadOnly]:=True)
        hoja_trabajo = libros_trabajo.Worksheets(1)
        'hoja_trabajo.EnableSelection = Microsoft.Office.Interop.Excel.XlEnableSelection.xlNoSelection
        Dim renglones As Integer = DGV.Rows.Count
        If renglones <> 0 Then
            Dim a As Integer = 6

            For Each renglon As DataGridViewRow In DGV.Rows
                hoja_trabajo.Cells(a, 3) = renglon.Cells(0).Value.ToString()
                hoja_trabajo.Cells(a, 4) = renglon.Cells(3).Value.ToString() + "/" + renglon.Cells(2).Value.ToString()
                hoja_trabajo.Cells(a, 5) = renglon.Cells(1).Value.ToString()
                If a <> 5 + DGV.Rows.Count Then
                    hoja_trabajo.ListObjects(1).ListRows.AddEx()
                End If
                a = a + 1
                PBExportar.Value = PBExportar.Value + 1
            Next
            aplicacion.Visible = True

        Else
            MessageBox.Show("No hay registros para exportar")
        End If
        btnBuscar.Enabled = True
        btnExportar.Enabled = True
        DGV.Enabled = True
        PBExportar.Visible = False
    End Sub
    Private Sub wait(ByVal seconds As Integer) 'suspende la ejecucion un tiempo especifico de segundos
        For i As Integer = 0 To seconds * 100 'realiza el conteo de segundos por 100 para hacerlos equivalentes a la cantidad de milisegundos a esperar
            System.Threading.Thread.Sleep(10) 'suspende la ejecucion 10 milisegundos
            Application.DoEvents() 'procesa lo que esta en espera
        Next
    End Sub
    'Crear formato en Excel

    'Crear aplicacion para llenar el formato en base a los datos de una base de datos en SQL Server

    'Aplicacion en VB y en c#

    '-Conservar formato, calcular sumatorias, nostrar numero de linea 
    'y abrir en solo lectura
End Class
