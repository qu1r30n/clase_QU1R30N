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
        _3_proceso_productos_e_inventario pr_prod_inv = new _3_proceso_productos_e_inventario();

        public string compras(string direccion_archivo, string codigos, string cantidades, string precio_compra_piezas, string provedores, string nombres_product_si_no_existen_producto = "", string sucursales = "",double porcentage_ganancia=20)
        {
            string info_a_retornar = "";

            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
            string año = fecha_hora.ToString("yyyy");

            

            string[] codigos_espl = codigos.Split(G_caracter_separacion[1][0]);
            string[] cantidades_espl = cantidades.Split(G_caracter_separacion[1][0]);
            string[] precio_compra_piezas_espl = precio_compra_piezas.Split(G_caracter_separacion[1][0]);
            string[] provedores_espl = provedores.Split(G_caracter_separacion[1][0]);
            string[] nombres_product_si_no_existen_producto_espl = nombres_product_si_no_existen_producto.Split(G_caracter_separacion[1][0]);
            string[] sucursales_espl = sucursales.Split(G_caracter_separacion[1][0]);

            for (int i = 0; i < codigos_espl.Length; i++)
            {
                double nuevo_precio_venta = Convert.ToDouble(precio_compra_piezas_espl[i]) * (1 + (porcentage_ganancia / 100));
                string res_edicion = bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final(direccion_archivo, 5, codigos_espl[i]
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
                      /*0*/cantidades_espl[i] //cantidad
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*1*/+ precio_compra_piezas_espl[i] //costo de compra
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
                      /*2*/+ provedores_espl[i] //provedor
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*3*/+ "" //ultimo movimiento
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*4*/+ sucursales_espl[i]  //sucursal

                    ,
                      // 0:editar  1:incrementar 2:agregar
                      /*0*/"1"//incrementar//cantidad
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*1*/+ "0"//editar//costo compra
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*2*/+ "2"//editar//provedor
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*3*/+ "0"//editar//ultimo movimiento
                      + G_caracter_separacion_funciones_espesificas[0]
                      /*4*/+ 0  //sucursal
                      ,
                      ""


                      );

                string[] res_esp = res_edicion.Split(G_caracter_para_confirmacion_o_error[0][0]);

                //edicion fue exitosa?
                if (Convert.ToInt32(res_esp[0]) > 0) //si res es mayor a 0 la operacioon fue exitosa si no hubo un error
                {
                    if (res_esp[0] == "1")
                    {
                        string[] info_res = res_esp[1].Split(G_caracter_separacion[0][0]);
                        if (Convert.ToDouble(info_res[4]) <= Convert.ToDouble(precio_compra_piezas_espl[i]))
                        {

                            info_a_retornar = bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final(direccion_archivo, 5, codigos_espl[i], "4", nuevo_precio_venta + "", "", "0");
                        }

                    }
                }
                //agregar nueva fila
                else
                {

                    string texto_o_fila_que_ingresara_si_no_esta_el_producto =

                    "" + nombres_product_si_no_existen_producto_espl[i] //1_producto
                    + G_caracter_separacion[0]
                    + "0"//2_contenido
                    + G_caracter_separacion[0]
                    + "NOSE"//3_tipo_medida
                    + G_caracter_separacion[0]
                    + nuevo_precio_venta//4_precio_venta
                    + G_caracter_separacion[0]
                    + codigos_espl[i]//5_cod_barras
                    + G_caracter_separacion[0]
                    + cantidades_espl[i]//6_cantidad
                    + G_caracter_separacion[0]
                    + precio_compra_piezas_espl[i]//7_costo_comp
                    + G_caracter_separacion[0]
                    + provedores_espl[i] + G_caracter_separacion[2] + precio_compra_piezas_espl[i]//8_provedor
                    + G_caracter_separacion[0]
                    + "NOSE"//9_grupo
                    + G_caracter_separacion[0]
                    + "1"//10_cant_produc_x_paquet
                    + G_caracter_separacion[0]
                    + "NOSE"//11_tipo_de_producto
                    + G_caracter_separacion[0]
                    + ""//12_ligar_produc_sab
                    + G_caracter_separacion[0]
                    + "NOSE"//13_impuestos
                    + G_caracter_separacion[0]
                    + ""//14_si_es_elaborado_que_materia_prima_usa_y_cantidad
                    + G_caracter_separacion[0]
                    + ""//15_caducidad
                    + G_caracter_separacion[0]
                    + ""//16_ultimo_movimiento
                    + G_caracter_separacion[0]
                    + sucursales_espl[i] + G_caracter_separacion[2] + nuevo_precio_venta//18_sucursal_vent¬cost_vent
                    + G_caracter_separacion[0]
                    + "NOSE"//17_clasificacion_producto
                    + G_caracter_separacion[0]
                    + ""//18_no_poner_nada
                    + G_caracter_separacion[0]
                    ;

                    //no encontro archivo
                    if (res_esp[0] == "0")
                    {
                        info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se_encontro_archivo";
                    }
                    else if (res_esp[0] == "-1")
                    {


                        info_a_retornar = pr_prod_inv.agregar_producto(direccion_archivo, texto_o_fila_que_ingresara_si_no_esta_el_producto);
                        info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + "no se_encontro_dato pero ya se agrego";
                    }
                }

            }

            return info_a_retornar;
        }


    }
}
