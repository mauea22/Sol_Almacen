﻿using System;
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

        #endregion

        private void Frm_articulos_Load(object sender, EventArgs e)
        {
            this.Listado_ar("%");
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estado_input(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);

            //foco en primer input
            this.Txt_descripcion_ar.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado_botones_procesos(false);
            this.Estado_input(false);
            this.Estado_botones_principales(true);
            Dgv_articulos.Enabled = false;
             

        }

    }
}
