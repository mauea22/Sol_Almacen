using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sol_Almacen.Presentacion
{
    public class D_Articulos
    {
        public DataTable Listado_ar( string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SELECT a.codigo_ar," +
                                   "a.descripcion_ar," +
                                   "a.marca_ar,"+
                                   "b.descripcion_um,"+
                                   "c.descripcion_ca,"+
                                   "a.stock_actual,"+
                                   "a.codigo_um,"+
                                   "a.codigo_ca "+
                                   "FROM tb_articulos a " +
                                   "inner join tb_unidades_medidas b on a.codigo_um = b.codigo_um " +
                                   "inner join tb_categorias c on a.codigo_ca = c.codigo_ca " +
                                   "where a.descripcion_ar like '"+ cTexto +"' "+
                                   "order by a.codigo_ar";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon)
                {
                    CommandTimeout = 60
                };
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
            }
        }

        public string Guardar_ar(int nOpcion, P_articulos oAr )
        {
            string rPta = "";
            string sqlTarea = "";
            MySqlConnection SqlCon = new MySqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                if (nOpcion == 1) //nuevo registro
                {
                    sqlTarea = " insert into tb_articulos(descripcion_ar," +
                                                         "marca_ar," +
                                                         "codigo_um," +
                                                         "codico_ca," +
                                                         "stock_actual," +
                                                         "fechaCrea_ar, " +
                                                         "fechaModifica_ar, " +
                                                 "values('"+oAr.Descripcion_ar+"', " + 
                                                        "'"+oAr.Marca_ar+"', " +
                                                        "'"+oAr.Codigo_um+"', " +
                                                        "'"+oAr.Codigo_ca+"', " +
                                                        "'"+oAr.stock_actual+"', "+ 
                                                        "'"+oAr.FechaCrea_ar+"', "+
                                                        "'"+oAr.FechaModifica_ar+"', "+ ")";
                }
                else
                {
                    //actualizar registro
                }
                MySqlCommand Comando = new MySqlCommand( sqlTarea, SqlCon);
                SqlCon.Open();
                rPta = Comando.ExecuteNonQuery() >= 1 ? "Ok" : "No se pudo ingreasar el registro";
            }
            catch (Exception ex)
            {

                rPta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
            }

            return rPta;
        }
    }
}
