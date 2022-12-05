using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Almacen.Presentacion
{
    public partial class Frm_articulos : Form
    {
        public Frm_articulos()
        {
            InitializeComponent();
        }
        #region "mis variables"
        int nCodigo_ar = 0;
        int nEstadoGuarda = 0;
        #endregion

        #region "mis metodos"
        private void Formato_ar()
        {
            Dgv_articulos.Columns[0].Width = 80;
            Dgv_articulos.Columns[0].HeaderText = "CÓDIGO";
            Dgv_articulos.Columns[1].Width = 250;
            Dgv_articulos.Columns[1].HeaderText = "ARTICULO";
            Dgv_articulos.Columns[2].Width = 200;
            Dgv_articulos.Columns[2].HeaderText = "MARCA";
            Dgv_articulos.Columns[3].Width = 80;
            Dgv_articulos.Columns[3].HeaderText = "MEDIDA";
            Dgv_articulos.Columns[4].Width = 200;
            Dgv_articulos.Columns[4].HeaderText = "CATEGORIA";
            Dgv_articulos.Columns[5].Width = 100;
            Dgv_articulos.Columns[5].HeaderText = "STOCK ACTUAL";
            Dgv_articulos.Columns[6].Visible = false;
            Dgv_articulos.Columns[7].Visible = false;


        }
        private void Listado_ar( string cTexto)
        {
            D_Articulos Datos = new D_Articulos();
            Dgv_articulos.DataSource = Datos.Listado_ar(cTexto);
            this.Formato_ar();
        }
        private void Estado_input( bool lEstado)
        {
            Txt_descripcion_ar.ReadOnly = !lEstado; 
            Txt_marca_ar.ReadOnly = !lEstado;    
            Txt_stock_actual.ReadOnly = !lEstado;
        }
        private void Estado_botones_procesos( bool lEstado)
        {
            Btn_lupa_ca.Enabled = lEstado;
            Btn_lupa_um.Enabled = lEstado;

            Btn_cancelar.Visible = lEstado;
            Btn_guardar.Visible = lEstado;

            //desactivar Dgv
            Dgv_articulos.Enabled = !lEstado;
        }
        private void Estado_botones_principales( bool lEstado)
        {
            Btn_nuevo.Enabled = lEstado;
            Btn_actualizar.Enabled = lEstado;
            Btn_eliminar.Enabled = lEstado; 
            Btn_reporte.Enabled = lEstado;
            Btn_salir.Enabled = lEstado;
        }
        private void Limpiar_input( bool lEstado)
        {
            Txt_descripcion_ar.Text = "";
            Txt_descripcion_ca.Text = "";
            Txt_descripcion_um.Text = "";
            Txt_marca_ar.Text = "";
            Txt_stock_actual.Text = "";
        }

        #endregion

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //nuevo registro
            this.Estado_input(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.Limpiar_input(true);

            //foco en primer input
            this.Txt_descripcion_ar.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_botones_procesos(false);
            this.Estado_input(false);
            this.Estado_botones_principales(true);
            this.Limpiar_input(true);
            Dgv_articulos.Enabled = false;
             

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        
        {
            string rPta = "";
            P_articulos oAr = new P_articulos();
            oAr.Codigo_ar = nCodigo_ar;
            oAr.Descripcion_ar = Txt_descripcion_ar.Text.Trim();
            oAr.Marca_ar = Txt_marca_ar.Text.Trim();
            oAr.Codigo_um = 1;
            oAr.Codigo_ca = 1;
            oAr.stock_actual = Convert.ToDecimal(Txt_stock_actual);
            oAr.FechaCrea_ar = DateTime.Now.ToString("yyyy-mm-dd");
            oAr.FechaModifica_ar = DateTime.Now.ToString("yyyyy-mm-dd");
        }

    }
}
