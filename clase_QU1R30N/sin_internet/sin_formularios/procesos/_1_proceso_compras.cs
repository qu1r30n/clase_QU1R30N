using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _1_proceso_compras
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();


        _0_proceso_AnalisisDeDatos pr_analisis = new _0_proceso_AnalisisDeDatos();
        _3_procesos_productos_e_inventario proc_inventario = new _3_procesos_productos_e_inventario();

        public string compras(string direccion_archivo, string codigo, string cantidad, string precio_compra_pieza, string provedor, string nombre_product_si_no_existe_producto = "", string sucursal = "")
        {
            string info_a_retornar = "";

            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
            string año = fecha_hora.ToString("yyyy");

            double nuevo_precio_venta = Convert.ToDouble(precio_compra_pieza) * 1.20;

            string texto_o_fila_que_ingresara_si_no_esta_el_producto =
                Tex_base.GG_base_arreglo_de_arreglos[1].Length //0_id
                + G_caracter_separacion[0]
                + nombre_product_si_no_existe_producto //1_producto
                + G_caracter_separacion[0]
                + "0"//2_contenido
                + G_caracter_separacion[0]
                + "NOSE"//3_tipo_medida
                + G_caracter_separacion[0]
                + nuevo_precio_venta//4_precio_venta
                + G_caracter_separacion[0]
                + codigo//5_cod_barras
                + G_caracter_separacion[0]
                + cantidad//6_cantidad
                + G_caracter_separacion[0]
                + precio_compra_pieza//7_costo_comp
                + G_caracter_separacion[0]
                + provedor + G_caracter_separacion[2]+precio_compra_pieza//8_provedor
                + G_caracter_separacion[0]
                + "NOSE"//9_grupo
                + G_caracter_separacion[0]
                + ""//10_no_poner_nada
                + G_caracter_separacion[0]
                + "1"//11_cant_produc_x_paquet
                + G_caracter_separacion[0]
                + "NOSE"//12_tipo_de_producto
                + G_caracter_separacion[0]
                + ""//13_ligar_produc_sab
                + G_caracter_separacion[0]
                + "NOSE"//14_impuestos
                + G_caracter_separacion[0]
                + ""//15_si_es_elaborado_que_materia_prima_usa_y_cantidad
                + G_caracter_separacion[0]
                + ""//16_caducidad
                + G_caracter_separacion[0]
                + ""//17_ultimo_movimiento
                + G_caracter_separacion[0]
                + sucursal + G_caracter_separacion[2] + nuevo_precio_venta//18_sucursal_vent¬cost_vent
                + G_caracter_separacion[0]

                ;
                


            string res_edicion = bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final(direccion_archivo, 5, codigo
                ,
                  //columnas a editar
                  /*0*/"6"//cantidad
                + G_caracter_separacion_funciones_espesificas[0]
                 /*1*/+ "7"//costo de compra
                + G_caracter_separacion_funciones_espesificas[0]
                 /*2*/+ "8"//provedor
                 + G_caracter_separacion_funciones_espesificas[0]
                 /*3*/+ "17"//ultimo movimiento
                 + G_caracter_separacion_funciones_espesificas[0]
                 /*4*/+ "18"//sucursal
                 

                ,
                  //info a editar o incrementar o agregar
                  /*0*/cantidad //cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ precio_compra_pieza //costo de compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ nuevo_precio_venta //provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ año_mes_dia_hora  //ultimo movimiento
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*4*/+ nuevo_precio_venta  //sucursal

                  ,
                  //comparacion para edicion dejar en blanco si no hay comparacion
                  // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                  // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                  /*0*/  "b" //cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ "d" //costo de compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ provedor //provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ "" //ultimo movimiento
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*4*/+ sucursal  //sucursal

                ,
                  // 0:editar  1:incrementar
                  /*0*/"1"//incrementar//cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ "0"//editar//costo compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ "2"//editar//provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ "0"//editar//ultimo movimiento
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*4*/+ 2  //sucursal
                  ,
                  texto_o_fila_que_ingresara_si_no_esta_el_producto
                  

                  );

            string[] res_esp = res_edicion.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp[0]) > 0) //si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                if (res_esp[0] == "1")
                {
                    string[] info_res = res_esp[1].Split(G_caracter_separacion[0][0]);
                    if (Convert.ToDouble(info_res[4]) <= Convert.ToDouble(precio_compra_pieza))
                    {
                        
                        info_a_retornar = bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final(direccion_archivo, 5, codigo, "4", nuevo_precio_venta + "", "", "0");
                    }

                }
            }
            
            else
            {
                if (res_esp[0] == "-0")
                {
                    info_a_retornar = "-0" + G_caracter_para_confirmacion_o_error[0] + "no se_encontro_archivo";
                }
                if (res_esp[0] == "-1")
                {
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no se_encontro_dato";
                }
            }

            return info_a_retornar;
        }


    }
}
