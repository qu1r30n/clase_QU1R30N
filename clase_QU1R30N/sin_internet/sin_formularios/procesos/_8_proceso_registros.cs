﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _8_proceso_registros
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        var_fun_GG vf_GG = new var_fun_GG();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();




        public string registrar_movimiento(string direccion_archivo, string modelo, string proceso, string datos, string fecha_o_hora, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";



            string resultado_archivo = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)
            {
                int indice = Convert.ToInt32(res_esp_archivo[1]);


                string tipo_de_operacion = "";
                double total_venta = 0;
                double total_costo_comp = 0;
                double total_pagar_imp = 0;
                double ganancia_total = 0;
                string Codbar_PreTot_Nom_Cant_Plat_DatPlat = "";
                string impuestos = "";


                string[] dat_esp = datos.Split(G_caracter_separacion[0][0]);
                string[] cant_dat = dat_esp[0].Split(G_caracter_separacion[1][0]);

                cant_dat = si_hay_iguales_en_codigo_y_plataforma_suma_cantidad_proceso_registros(cant_dat);


                for (int l = 0; l < cant_dat.Length; l++)
                {
                    string[] info_dat = cant_dat[l].Split(G_caracter_separacion[2][0]);
                    if (res_esp_archivo[0] == "1")
                    {
                        switch (modelo)
                        {
                            case "MODELO_ANALISIS_DATOS":

                                if (proceso == "EXISTE_PRODUCTO")
                                {
                                    // Código correspondiente al caso "EXISTE_PRODUCTO"
                                }

                                else if (proceso == "EXISTE_CURP_UNIFICADO_COD3_R_")
                                {
                                    // Código correspondiente al caso "EXISTE_CURP_UNIFICADO_COD3_R_"
                                }

                                else if (proceso == "EXISTE_CLAVE_LECTOR_UNIFICADO_COD3_R_")
                                {
                                    // Código correspondiente al caso "EXISTE_CLAVE_LECTOR_UNIFICADO_COD3_R_"
                                }

                                else if (proceso == "EXISTE_OTRA_IDENTIFICACION_OFICIAL_UNIFICADO_COD3_R_")
                                {
                                    // Código correspondiente al caso "EXISTE_OTRA_IDENTIFICACION_OFICIAL_UNIFICADO_COD3_R_"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }

                                break;

                            case "MODELO_COMPRAS":
                                if (proceso == "COMPRA")
                                {
                                    // Código correspondiente al caso "COMPRA"
                                }

                                else if (proceso == "COMPRA_MAYOREO")
                                {
                                    // Código correspondiente al caso "COMPRA_MAYOREO"
                                }

                                else if (proceso == "COMPRA_CON_PROMOCION")
                                {
                                    // Código correspondiente al caso "COMPRA_CON_PROMOCION"
                                }

                                else if (proceso == "CANCELAR")
                                {
                                    // Código correspondiente al caso "CANCELAR"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }

                                break;

                            case "MODELO_VENTAS":

                                if (proceso == "VENTA")
                                {


                                    for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[1].Length; i++)
                                    {
                                        string[] info_bas = Tex_base.GG_base_arreglo_de_arreglos[1][i].Split(caracter_separacion_string[0][0]);
                                        //encontro el codigo de barras?
                                        if (info_bas[5] == info_dat[0])
                                        {

                                            double precio_produc_tot_compra = Convert.ToDouble(info_bas[7]) * Convert.ToDouble(info_dat[1]);
                                            double precio_produc_tot_venta = Convert.ToDouble(info_bas[4]) * Convert.ToDouble(info_dat[1]);
                                            double ganancia_producto_antes_de_impuestos = precio_produc_tot_venta - precio_produc_tot_compra;

                                            total_venta = total_venta + precio_produc_tot_venta;
                                            total_costo_comp = total_costo_comp + precio_produc_tot_compra;


                                            string[] imp_produc = info_bas[13].Split(G_caracter_separacion[1][0]);
                                            for (int j = 0; j < imp_produc.Length; j++)
                                            {
                                                for (int k = G_donde_inicia_la_tabla; k < Tex_base.GG_base_arreglo_de_arreglos[19].Length; k++)
                                                {
                                                    string[] imp_bas_esplit = Tex_base.GG_base_arreglo_de_arreglos[19][k].Split(G_caracter_separacion[0][0]);
                                                    //encontro el impuesto?
                                                    if (imp_bas_esplit[0] == imp_produc[j])
                                                    {
                                                        double precio_imp_pr = (Convert.ToDouble(imp_bas_esplit[1]) / 100) * (ganancia_producto_antes_de_impuestos);
                                                        total_pagar_imp = total_pagar_imp + precio_imp_pr;
                                                        impuestos = op_tex.concatenacion_caracter_separacion(impuestos, imp_bas_esplit[0] + G_caracter_separacion[2] + precio_imp_pr + G_caracter_separacion[2] + imp_bas_esplit[1], G_caracter_separacion[1]);
                                                        break;
                                                    }
                                                }
                                            }


                                            Codbar_PreTot_Nom_Cant_Plat_DatPlat = op_tex.concatenacion_caracter_separacion(Codbar_PreTot_Nom_Cant_Plat_DatPlat,
                                                info_bas[5]
                                                + G_caracter_separacion[2] +
                                                precio_produc_tot_venta
                                                + G_caracter_separacion[2]
                                                + info_bas[1]
                                                + G_caracter_separacion[2]
                                                + info_dat[1]
                                                + G_caracter_separacion[2]
                                                + info_dat[2]
                                                + G_caracter_separacion[2]
                                                + info_dat[3]
                                                , G_caracter_separacion[1]);
                                            break;
                                        }
                                    }

                                    ganancia_total = total_venta - total_costo_comp - total_pagar_imp;
                                    tipo_de_operacion = op_tex.concatenacion_caracter_separacion(tipo_de_operacion, "VENTA", G_caracter_separacion[1]);


                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }

                                break;

                            case "MODELO_INVENTARIO":
                                if (proceso == "AGREGAR")
                                {
                                    // Código correspondiente al caso "AGREGAR"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }

                                break;

                            case "MODELO_APRENDICES_E":
                                if (proceso == "REGISTRO_APRENDICES_E")
                                {
                                    // Código correspondiente al caso "REGISTRO_APRENDICES_E"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }
                                break;

                            case "MODELO_AFILIADOS":

                                if (proceso == "INSCRIBIR_UNIFICADO_COD3_R_")
                                {
                                    // Código correspondiente al caso "INSCRIBIR_UNIFICADO_COD3_R_"
                                }

                                else if (proceso == "INSCRIBIR_SIMPLE_COD1")
                                {
                                    // Código correspondiente al caso "INSCRIBIR_SIMPLE_COD1"
                                }

                                else if (proceso == "INSCRIBIR_COMPLEJO_COD2")
                                {
                                    // Código correspondiente al caso "INSCRIBIR_COMPLEJO_COD2"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }

                                break;

                            case "MODELO_PROVEDORES":
                                if (proceso == "REGISTRO_PROVEDOR")
                                {
                                    // Código correspondiente al caso "REGISTRO_PROVEDOR"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }


                                break;

                            case "MODELO_SUCURSALES":
                                if (proceso == "REGISTRO_SUCURSAL")
                                {
                                    // Código correspondiente al caso "REGISTRO_PROVEDOR"
                                }

                                else
                                {
                                    // Código correspondiente al caso default
                                }


                                break;

                            default:

                                break;
                        }
                    }

                }

                string info_agregar =
                    fecha_o_hora
                    + caracter_separacion_string[0]
                    + tipo_de_operacion
                    + caracter_separacion_string[0]
                    + impuestos
                    + caracter_separacion_string[0]
                    + Codbar_PreTot_Nom_Cant_Plat_DatPlat
                    + caracter_separacion_string[0]
                    + "SIN_COMENTARIOS"
                    + caracter_separacion_string[0]
                    + total_venta
                    + caracter_separacion_string[0]
                    + total_costo_comp
                    + caracter_separacion_string[0]
                    + total_pagar_imp
                    + caracter_separacion_string[0]
                    + ""
                    + caracter_separacion_string[0]
                    + ganancia_total
                    + caracter_separacion_string[0]
                    + "";
                info_a_retornar = bas.Agregar(direccion_archivo, info_agregar);

            }

            else
            {
                info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
            }

            return info_a_retornar;
        }

        public string registro_incrementar(string direccion_archivo, string datos, string fecha)
        {
            string info_a_retornar = "";

            string resultado_archivo = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);
            //encontro el archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)
            {
                if (res_esp_archivo[0] == "1")
                {
                    string[] datos_esp = datos.Split(G_caracter_separacion[0][0]);
                    datos_esp[0] = fecha;
                    string[] datos_tip_operacion = datos_esp[1].Split(G_caracter_separacion[1][0]);
                    string[] datos_iva = datos_esp[2].Split(G_caracter_separacion[1][0]);
                    datos_iva = si_hay_iguales_en_iva_suma_cantidad_proceso_registros(datos_iva);
                    datos_esp[2] = string.Join(G_caracter_separacion[1], datos_iva);
                    string[] datos_cod_bar_dinero_nom_produc = datos_esp[3].Split(G_caracter_separacion[1][0]);
                    bool fue_creada_la_informacion = false;
                    for (int j = 0; j < datos_cod_bar_dinero_nom_produc.Length; j++)
                    {

                        string res = bas.Editar_incr_o_agrega_MULTIPLESCOMPARACIONES_AL_FINAL_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
                                    (
                                    direccion_archivo, 0, fecha,
                                    //columnas a editar
                                    "3"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "5"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "6"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "7"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "9"
                                    ,

                                      //comparacion para edicion dejar en blanco si no hay comparacion
                                      // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                                      // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                                      datos_cod_bar_dinero_nom_produc[j]
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + datos_esp[5]
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + datos_esp[6]
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + datos_esp[7]
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + datos_esp[9]


                                    ,
                                      // 0:editar  1:incrementar 2:agregar
                                      "1"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "1"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "1"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "1"
                                    + G_caracter_separacion_funciones_espesificas[0]
                                    + "1"
                                    ,
                                      string.Join(G_caracter_separacion[0], datos_esp)
                                    );

                        string[] res_esp = res.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        if (res_esp[0] == "2")
                        {
                            fue_creada_la_informacion = true;

                        }

                    }

                    if (fue_creada_la_informacion == false)
                    {
                        for (int j = 0; j < datos_iva.Length; j++)
                        {


                            bas.Editar_incr_o_agrega_MULTIPLESCOMPARACIONES_AL_FINAL_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
                                            (
                                            direccion_archivo, 0, fecha,
                                             //columnas a editar
                                             "2"
                                            ,
                                              //comparacion para edicion dejar en blanco si no hay comparacion
                                              // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                                              // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                                              datos_iva[j]
                                            ,
                                              // 0:editar  1:incrementar 2:agregar
                                              "1"
                                            ,
                                              ""
                                            );
                        }
                    }


                }
            }
            else
            {
                if (res_esp_archivo[0] == "0")
                {

                }
            }


            return info_a_retornar;
        }



        public string registrar_movimiento_productos(string direccion_archivo, string modelo, string proceso, string datos, string fecha_o_hora, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";



            string resultado_archivo = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)
            {
                if (res_esp_archivo[0] == "1")
                {


                    int indice = Convert.ToInt32(res_esp_archivo[1]);


                    string tipo_de_operacion = "";



                    string[] dat_esp = datos.Split(G_caracter_separacion[0][0]);
                    string[] cant_dat = dat_esp[0].Split(G_caracter_separacion[1][0]);
                    string info_productos_a_concatenar = "";
                    for (int l = 0; l < cant_dat.Length; l++)
                    {
                        string[] info_dat = cant_dat[l].Split(G_caracter_separacion[2][0]);
                        if (res_esp_archivo[0] == "1")
                        {
                            switch (modelo)
                            {
                                case "MODELO_ANALISIS_DATOS":

                                    if (proceso == "EXISTE_PRODUCTO")
                                    {
                                        // Código correspondiente al caso "EXISTE_PRODUCTO"
                                    }

                                    else if (proceso == "EXISTE_CURP_UNIFICADO_COD3_R_")
                                    {
                                        // Código correspondiente al caso "EXISTE_CURP_UNIFICADO_COD3_R_"
                                    }

                                    else if (proceso == "EXISTE_CLAVE_LECTOR_UNIFICADO_COD3_R_")
                                    {
                                        // Código correspondiente al caso "EXISTE_CLAVE_LECTOR_UNIFICADO_COD3_R_"
                                    }

                                    else if (proceso == "EXISTE_OTRA_IDENTIFICACION_OFICIAL_UNIFICADO_COD3_R_")
                                    {
                                        // Código correspondiente al caso "EXISTE_OTRA_IDENTIFICACION_OFICIAL_UNIFICADO_COD3_R_"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }

                                    break;

                                case "MODELO_COMPRAS":

                                    if (proceso == "COMPRA")
                                    {
                                        // Código correspondiente al caso "COMPRA"
                                    }

                                    else if (proceso == "COMPRA_MAYOREO")
                                    {
                                        // Código correspondiente al caso "COMPRA_MAYOREO"
                                    }

                                    else if (proceso == "COMPRA_CON_PROMOCION")
                                    {
                                        // Código correspondiente al caso "COMPRA_CON_PROMOCION"
                                    }

                                    else if (proceso == "CANCELAR")
                                    {
                                        // Código correspondiente al caso "CANCELAR"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }

                                    break;

                                case "MODELO_VENTAS":

                                    if (proceso == "VENTA")
                                    {


                                        for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[1].Length; i++)
                                        {
                                            string[] info_bas = Tex_base.GG_base_arreglo_de_arreglos[1][i].Split(caracter_separacion_string[0][0]);
                                            //encontro el codigo de barras?
                                            if (info_bas[5] == info_dat[0])
                                            {
                                                info_productos_a_concatenar = op_tex.concatenacion_caracter_separacion(info_productos_a_concatenar, info_dat[0] + caracter_separacion_string[2] + info_dat[1] + caracter_separacion_string[2] + info_bas[1] + caracter_separacion_string[2] + info_dat[2] + caracter_separacion_string[2] + info_dat[3], caracter_separacion_string[1]);
                                                break;
                                            }
                                        }


                                        tipo_de_operacion = op_tex.concatenacion_caracter_separacion(tipo_de_operacion, "VENTA", G_caracter_separacion[1]);


                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }

                                    break;

                                case "MODELO_INVENTARIO":

                                    if (proceso == "AGREGAR")
                                    {
                                        // Código correspondiente al caso "AGREGAR"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }

                                    break;

                                case "MODELO_APRENDICES_E":

                                    if (proceso == "REGISTRO_APRENDICES_E")
                                    {
                                        // Código correspondiente al caso "REGISTRO_APRENDICES_E"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }
                                    break;

                                case "MODELO_AFILIADOS":

                                    if (proceso == "INSCRIBIR_UNIFICADO_COD3_R_")
                                    {
                                        // Código correspondiente al caso "INSCRIBIR_UNIFICADO_COD3_R_"
                                    }

                                    else if (proceso == "INSCRIBIR_SIMPLE_COD1")
                                    {
                                        // Código correspondiente al caso "INSCRIBIR_SIMPLE_COD1"
                                    }

                                    else if (proceso == "INSCRIBIR_COMPLEJO_COD2")
                                    {
                                        // Código correspondiente al caso "INSCRIBIR_COMPLEJO_COD2"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }

                                    break;

                                case "MODELO_PROVEDORES":

                                    if (proceso == "REGISTRO_PROVEDOR")
                                    {
                                        // Código correspondiente al caso "REGISTRO_PROVEDOR"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }


                                    break;

                                case "MODELO_SUCURSALES":

                                    if (proceso == "REGISTRO_SUCURSAL")
                                    {
                                        // Código correspondiente al caso "REGISTRO_PROVEDOR"
                                    }

                                    else
                                    {
                                        // Código correspondiente al caso default
                                    }


                                    break;

                                default:

                                    break;
                            }
                        }

                    }

                    string info_agregar = fecha_o_hora
                        + caracter_separacion_string[0]
                        + tipo_de_operacion
                        + caracter_separacion_string[0]
                        + info_productos_a_concatenar;
                    info_a_retornar = bas.Agregar(direccion_archivo, info_agregar);

                }
            }
            else
            {
                info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
            }

            return info_a_retornar;

        }
        public string registro_incrementar_productos(string direccion_archivo, string datos, string fecha)
        {
            string info_a_retornar = "";

            string resultado_archivo = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);
            //encontro el archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)
            {
                if (res_esp_archivo[0] == "1")
                {
                    string[] datos_esp = datos.Split(G_caracter_separacion[0][0]);
                    
                    datos_esp[0] = fecha;
                    
                    string[] datos_cod_bar_dinero_nom_produc_cant_plat_infplat = datos_esp[3].Split(G_caracter_separacion[1][0]);

                    for (int j = 0; j < datos_cod_bar_dinero_nom_produc_cant_plat_infplat.Length; j++)
                    {
                        string[] inf_dat = datos_cod_bar_dinero_nom_produc_cant_plat_infplat[j].Split(G_caracter_separacion[2][0]);
                        string sino_lo_encuentra = inf_dat[2] + G_caracter_separacion[0] + inf_dat[3] + G_caracter_separacion[0] + inf_dat[0] + G_caracter_separacion[0] + "SIN_COMENTARIOS";
                        bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
                                    (
                                    direccion_archivo, 2, inf_dat[0],
                                     //columnas a editar
                                     "1"
                                    ,
                                     inf_dat[3]
                                     ,
                                      //comparacion para edicion dejar en blanco si no hay comparacion
                                      // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                                      // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                                      
                                     ""
                                    ,
                                      // 0:editar  1:incrementar 2:agregar
                                      "1"
                                    
                                    ,
                                      sino_lo_encuentra
                                    );


                    }

                }
            }
            else
            {
                if (res_esp_archivo[0] == "0")
                {

                }
            }


            return info_a_retornar;
        }



        private string[] si_hay_iguales_en_codigo_y_plataforma_suma_cantidad_proceso_registros(string[] produc_cantidad)
        {
            string[] arr_retornar = new string[0];
            if (produc_cantidad.Length > 1)
            {
                for (int i = 0; i < produc_cantidad.Length - 1; i++)
                {
                    string[] comp_prod_1 = produc_cantidad[i].Split(G_caracter_separacion[2][0]);

                    for (int j = i + 1; j < produc_cantidad.Length; j++)
                    {
                        string[] comp_prod_2 = produc_cantidad[j].Split(G_caracter_separacion[2][0]);

                        if (produc_cantidad[i] != "" && produc_cantidad[j] != "")
                        {
                            if (comp_prod_1[0] == comp_prod_2[0] && comp_prod_1[2] == comp_prod_2[2])
                            {
                                comp_prod_1[1] = (Convert.ToDouble(comp_prod_1[1]) + Convert.ToDouble(comp_prod_2[1])).ToString();
                                comp_prod_1[3] = comp_prod_1[3] + G_caracter_separacion[3] + comp_prod_2[3];
                                produc_cantidad[j] = "";
                            }
                        }
                    }
                    if (produc_cantidad[i] != "")
                    {
                        arr_retornar = op_arr.agregar_registro_del_array(arr_retornar, string.Join(G_caracter_separacion[2], comp_prod_1));
                    }
                }

            }
            else
            {
                arr_retornar = produc_cantidad;
            }

            return arr_retornar;
        }

        private string[] si_hay_iguales_en_iva_suma_cantidad_proceso_registros(string[] produc_cantidad)
        {
            string[] arr_retornar = new string[0];
            if (produc_cantidad.Length > 1)
            {
                for (int i = 0; i < produc_cantidad.Length - 1; i++)
                {
                    string[] comp_prod_1 = produc_cantidad[i].Split(G_caracter_separacion[2][0]);

                    for (int j = i + 1; j < produc_cantidad.Length; j++)
                    {
                        string[] comp_prod_2 = produc_cantidad[j].Split(G_caracter_separacion[2][0]);

                        if (produc_cantidad[i] != "" && produc_cantidad[j] != "")
                        {
                            if (comp_prod_1[0] == comp_prod_2[0])
                            {
                                comp_prod_1[1] = (Convert.ToDouble(comp_prod_1[1]) + Convert.ToDouble(comp_prod_2[1])).ToString();
                                produc_cantidad[j] = "";
                            }
                        }
                    }
                    if (produc_cantidad[i] != "")
                    {
                        arr_retornar = op_arr.agregar_registro_del_array(arr_retornar, string.Join(G_caracter_separacion[2], comp_prod_1));
                    }
                }

            }
            else
            {
                arr_retornar = produc_cantidad;
            }

            return arr_retornar;
        }


    }
}
