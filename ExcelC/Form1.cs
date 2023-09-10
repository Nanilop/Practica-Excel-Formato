using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Sales_by_Category' Puede moverla o quitarla según sea necesario.
            this.sales_by_CategoryTableAdapter.Fill(this.northwindDataSet.Sales_by_Category);
            btnExportar.Enabled = true;
            PBExportar.Maximum = DGV.Rows.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnExportar.Enabled = false;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnExportar.Enabled = false;
            DGV.Enabled = false;
            PBExportar.Value = 0;
            PBExportar.Visible = true;
            Excel.Application aplicacion;
            Excel.Workbook libros_trabajo;
            Excel.Worksheet hoja_trabajo;
            aplicacion = new Excel.Application();

            libros_trabajo = aplicacion.Workbooks.Open(Path.GetFullPath("..\\..\\Resources\\") + "Plantilla.xlsx", ReadOnly:true) ;
            hoja_trabajo = libros_trabajo.Worksheets[1];
            int renglones = DGV.Rows.Count;
            if (renglones!= 0) {
                int a = 6;
                foreach (DataGridViewRow renglon in DGV.Rows){
                    hoja_trabajo.Cells[a, 3] = renglon.Cells[0].Value.ToString();
                    hoja_trabajo.Cells[a, 4] = renglon.Cells[3].Value.ToString() + "/" + renglon.Cells[2].Value.ToString();
                    hoja_trabajo.Cells[a, 5] = renglon.Cells[1].Value.ToString();
                    if (a!= 5 + DGV.Rows.Count) {
                        hoja_trabajo.ListObjects[1].ListRows.AddEx();
                    }
                    a = a + 1;
                    PBExportar.Value = PBExportar.Value + 1;
                }
                aplicacion.Visible = true;
                }
        else { 
            MessageBox.Show("No hay registros para exportar");
        }
            btnBuscar.Enabled = true;
        btnExportar.Enabled = true;
        DGV.Enabled = true;
        PBExportar.Visible = false;
        }
    }
}
