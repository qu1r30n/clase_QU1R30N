using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _2_proceso_ventas
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.txt",
        };

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();

        public string ventas(string codigo, string cantidad, string plataforma = "", string datos_de_pataforma = "")
        {
            string info_a_retornar = null;

            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
            string año = fecha_hora.ToString("yyyy");

            string res_indise = bas.sacar_indice_del_arreglo_de_direccion(G_direcciones[0]);
            string[] res_esp_indice = res_indise.Split(G_caracter_para_confirmacion_o_error[0][0]);
            //se encontro el archivo?
            if (Convert.ToInt32(res_esp_indice[0]) > 0)
            {
                if (res_esp_indice[0] == "1")
                {
                    int indice = Convert.ToInt32(res_esp_indice[1]);
                    string res_bus = op_arr.busqueda_profunda_arreglo(Tex_base.GG_base_arreglo_de_arreglos[indice], "5", codigo, donde_iniciar: G_donde_inicia_la_tabla);
                    string[] res_esp_bus = res_bus.Split(G_caracter_para_confirmacion_o_error[0][0]);
                    
                    //se encontro el producto?
                    if (Convert.ToInt32(res_esp_bus[0])>0)
                    {
                        if (res_esp_bus[0] == "1")
                        {
                            string[] info_esp = res_esp_bus[1].Split(G_caracter_separacion[0][0]);
                            //grupo_al_que_forma_el_producto
                            if (info_esp[9]== "PRODUCTO_PIEZA")
                            {

                            }
                        }
                    }
                    else
                    {
                        if (res_esp_bus[0] == "0")
                        {

                        }
                    }


                }
            }
            else
            {
                if (res_esp_indice[0] == "0")
                {

                }
            }

            info_a_retornar = bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final(G_direcciones[0], 5, codigo,
                //columnas a editar
                "6"
                + G_caracter_separacion_funciones_espesificas[0]

                ,
                //info a editar o incrementar o agregar
                "" + (Convert.ToInt32(cantidad) * -1)
                + G_caracter_separacion_funciones_espesificas[0]

                ,
                //comparacion para edicion dejar en blanco si no hay comparacion
                // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                ""
                + G_caracter_separacion_funciones_espesificas[0]

                ,
                // 0:editar  1:incrementar 2:agregar
                "1"
                + G_caracter_separacion_funciones_espesificas[0]

                );


            return info_a_retornar;
        }
    }
}
