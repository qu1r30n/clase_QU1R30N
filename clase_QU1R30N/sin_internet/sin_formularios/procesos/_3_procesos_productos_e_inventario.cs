using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _3_procesos_productos_e_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();


        

        public object agregar_producto(object variable_a_la_que_va_a_devolver, string producto)
        {
            
            string[] producto_espliteado = producto.Split(G_caracter_separacion[0][0]);

            try
            {
                string nombre_del_producto = producto_espliteado[0];
                double cantidad_de_producto = Convert.ToDouble(producto_espliteado[1]);
                string tipo_de_medida = producto_espliteado[2];
                double precio_de_venta = Convert.ToDouble(producto_espliteado[3]);
                string codigo_de_barras = producto_espliteado[4];
                double cantidad_disponible = Convert.ToDouble(producto_espliteado[5]);
                double costo_de_compra = Convert.ToDouble(producto_espliteado[6]);
                string proveedor = producto_espliteado[7];
                string grupo = producto_espliteado[8];
                string es_multiusos = producto_espliteado[9];
                double cantidad_de_productos_por_paquete = Convert.ToDouble(producto_espliteado[10]);
                string productos_elaborados = producto_espliteado[11];
                string ligar_productos_para_sabor = producto_espliteado[12];
                string impuesto = producto_espliteado[13];
                string tipo_de_producto_para_impuesto = producto_espliteado[14];
                string caducidad = producto_espliteado[15];
                /*
                string[] arreglo_modificado = bas.Agregar(G_dir_arch_conf_negocio[0], producto);

                string se_modifico_el_arreglo = "0";
                if (arreglo_modificado != null)
                {
                    se_modifico_el_arreglo = "1";
                }
                
                variable_a_la_que_va_a_devolver = vf_GG.GG_retorno_de_datos(variable_a_la_que_va_a_devolver, producto,se_modifico_el_arreglo, respuesta_devolver_arreglo_texto: arreglo_modificado);
                */
                return variable_a_la_que_va_a_devolver;
            }
            catch 
            {
                return null;
                
            }

            
        }




    }
}
