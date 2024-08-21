using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _08_proceso_registros
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        var_fun_GG vf_GG = new var_fun_GG();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        string[] G_direcciones =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0]//"config\\inf\\inventario\\inventario.txt",
        };

        Tex_base bas = new Tex_base();




        public string registrar_venta(string direccion_archivo, string datos, string fecha_o_hora, object caracter_separacion_obj = null)
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



                        string[] res_indice_invent = bas.sacar_indice_del_arreglo_de_direccion(G_direcciones[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        int indice_inventario = Convert.ToInt32(res_indice_invent[1]);
                        for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_inventario].Length; i++)
                        {
                            string[] info_bas = Tex_base.GG_base_arreglo_de_arreglos[indice_inventario][i].Split(caracter_separacion_string[0][0]);
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

        public string registrar_compra(string direccion_archivo, string datos, string fecha_o_hora, object caracter_separacion_obj = null)
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
                string[] cuantos_cod_bar = dat_esp[0].Split(G_caracter_separacion[1][0]);

                cuantos_cod_bar = si_hay_iguales_en_codigo_y_plataforma_suma_cantidad_proceso_registros(cuantos_cod_bar);


                for (int l = 0; l < cuantos_cod_bar.Length; l++)
                {
                    string[] info_dat = cuantos_cod_bar[l].Split(G_caracter_separacion[2][0]);
                    if (res_esp_archivo[0] == "1")
                    {



                        string[] res_indice_invent = bas.sacar_indice_del_arreglo_de_direccion(G_direcciones[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        int indice_inventario = Convert.ToInt32(res_indice_invent[1]);
                        for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_inventario].Length; i++)
                        {
                            string[] info_bas = Tex_base.GG_base_arreglo_de_arreglos[indice_inventario][i].Split(caracter_separacion_string[0][0]);
                            //encontro el codigo de barras?
                            if (info_bas[5] == info_dat[0])
                            {

                            }
                        }

                        ganancia_total = total_venta - total_costo_comp - total_pagar_imp;
                        tipo_de_operacion = op_tex.concatenacion_caracter_separacion(tipo_de_operacion, "VENTA", G_caracter_separacion[1]);

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
                    string[] datos_cod_bar_dinero_nom_produc = datos_esp[3].Split(G_caracter_separacion[1][0]);

                    datos_iva = si_hay_iguales_en_codigo_suma_cantidad_proceso_registros(datos_iva);
                    datos_esp[2] = string.Join(G_caracter_separacion[1], datos_iva);

                    bool fue_creada_la_informacion = false;
                    for (int j = 0; j < datos_cod_bar_dinero_nom_produc.Length; j++)
                    {
                        string[] inf_dat = datos_cod_bar_dinero_nom_produc[j].Split(G_caracter_separacion[2][0]);
                        string info_dat_prod = inf_dat[0] 
                            + G_caracter_separacion[2] + inf_dat[1] 
                            + G_caracter_separacion[2] + inf_dat[2] 
                            + G_caracter_separacion[2] + inf_dat[3];

                        string sino_lo_encuentra = datos_esp[0] //0_fecha
                            + G_caracter_separacion[0] + datos_tip_operacion[j] //1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR
                            + G_caracter_separacion[0] + datos_esp[2] //2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2
                            + G_caracter_separacion[0] + info_dat_prod //3_PRODUCTOS_PRECIO_TOTAL_PRECIO_UNITARIO
                            + G_caracter_separacion[0] + "SIN_COMENTARIOS" //4_COMENTARIO
                            + G_caracter_separacion[0] + datos_esp[5] //5_TOTAL_VENTA
                            + G_caracter_separacion[0] + datos_esp[6] //6_TOTAL_COSTO_COMP
                            + G_caracter_separacion[0] + datos_esp[7]// 7_TOTAL_IMPUESTOS
                            + G_caracter_separacion[0] + datos_esp[8] //8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA
                            + G_caracter_separacion[0] + datos_esp[9];//9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS


                        string res = bas.Editar_incr_o_agrega_COMPARACION_YY_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final_BUSQUEDA_ID
                                    (
                                    //comparaciones YY
                                    direccion_archivo,
                                    "0"                                                   //0_fecha
                                    + G_caracter_separacion_funciones_espesificas[0] + "1"//1_tipo_operacion
                                    ,
                                    fecha                                                                    //0_fecha
                                    + G_caracter_separacion_funciones_espesificas[0] + datos_tip_operacion[j]//tipo_operacion
                                    ,

                                      //columnas a editar
                                      "3"//3_productos
                                    ,

                                      //edicion
                                      info_dat_prod//3_productos
                                    ,

                                     // 0:editar  1:incrementar 2:agregar
                                      "1"                                                  //3_productos
                                    ,
                                      sino_lo_encuentra
                                    );

                        string[] res_esp = res.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        if (res_esp[0] == "2")
                        {
                            fue_creada_la_informacion = true;

                        }

                    }

                    if (fue_creada_la_informacion == false)
                    {

                        rep_funcion_cantidad_del_arreglo(direccion_archivo, "0", fecha, "2", datos_iva, -1, "1");
                        rep_funcion_cantidad_del_arreglo(direccion_archivo, "0", fecha, "5", datos_esp[5], 5, "1");
                        rep_funcion_cantidad_del_arreglo(direccion_archivo, "0", fecha, "9", datos_esp[9], 9, "1");
                        rep_funcion_cantidad_del_arreglo(direccion_archivo, "0", fecha, "6", datos_esp[6], 6, "1");
                        rep_funcion_cantidad_del_arreglo(direccion_archivo, "0", fecha, "7", datos_esp[7], 7, "1");




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
                int indice = Convert.ToInt32(res_esp_archivo[1]);


                string tipo_de_operacion = "";
                
                
                
                
                string[] cant_dat = datos.Split(G_caracter_separacion[1][0]);

                cant_dat = si_hay_iguales_en_codigo_suma_cantidad_proceso_registros(cant_dat);



                string info_agregar =
                    fecha_o_hora
                    + caracter_separacion_string[0]
                    + tipo_de_operacion
                    + caracter_separacion_string[0]
                    + string.Join(G_caracter_separacion[1],cant_dat);

                info_a_retornar = bas.Agregar(direccion_archivo, info_agregar);

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
                    string[] datos_tip_operacion = datos_esp[1].Split(G_caracter_separacion[1][0]);
                    string[] datos_codbar = datos_esp[2].Split(G_caracter_separacion[1][0]);
                    

                    datos_codbar = si_hay_iguales_en_codigo_suma_cantidad_proceso_registros(datos_codbar);
                    datos_esp[2] = string.Join(G_caracter_separacion[1], datos_codbar);


                    string[] res_indice_invent = bas.sacar_indice_del_arreglo_de_direccion(G_direcciones[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                    int indice_inventario = Convert.ToInt32(res_indice_invent[1]);
                    string[] info_producto_bas = null;
                    for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_inventario].Length; i++)
                    {
                        string[] info_bas = Tex_base.GG_base_arreglo_de_arreglos[indice_inventario][i].Split(G_caracter_separacion[0][0]);
                        if (true)
                        {
                            info_producto_bas = info_bas;
                        }
                    }

                    

                    //bool fue_creada_la_informacion = false;
                    for (int j = 0; j < datos_codbar.Length; j++)
                    {
                        string[] inf_dat = datos_codbar[j].Split(G_caracter_separacion[2][0]);
                        string info_dat_prod = info_producto_bas[1]
                            + G_caracter_separacion[2] + inf_dat[1]
                            + G_caracter_separacion[2] + inf_dat[2]
                            + G_caracter_separacion[2] + inf_dat[3];

                        string si_no_tiene_historial_ranking_semanas = "";
                        for (int i = 0; i < 52; i++)
                        {
                            si_no_tiene_historial_ranking_semanas = si_no_tiene_historial_ranking_semanas + G_caracter_separacion[1];
                        }
                        string sino_lo_encuentra =
                            info_producto_bas[1]                    //0_NOMBRE
                            + G_caracter_separacion[0] + inf_dat[1] //1_CANTIDAD
                            + G_caracter_separacion[0] + inf_dat[0] //2_CODIGO
                            + G_caracter_separacion[0] + "SIN_COMENTARIOS" //3_COMENTARIO
                            + G_caracter_separacion[0] + inf_dat[1] + si_no_tiene_historial_ranking_semanas //4_HISTORIAL
                            + G_caracter_separacion[0] + inf_dat[1] //5_columna_ranking
                            + G_caracter_separacion[0] + inf_dat[1] //6_columnas_promedio
                            + G_caracter_separacion[0] + "7" //7_columna_veces_que_supera_promedio//ponemos 7 para que sean 2 meses porque son 4 semanas por mes
                            ;
                        ;

                        //columna_historial,columna_ranking,columnas_promedio,columna_veces_que_supera_promedio,
                        //|//0_NOMBRE_PRODUCTO|1_CANTIDAD|2_COD_BAR|3_COMENTARIO



                        
                        bas.Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final_BUSQUEDA_ID
                                    (
                                    direccion_archivo
                                    ,2                                                   //2_codbar
                                    ,inf_dat[0]
                                    ,"1" + G_caracter_separacion_funciones_espesificas[0] + "4" + G_caracter_separacion_funciones_espesificas[0] + "5"
                                    ,inf_dat[1] + G_caracter_separacion_funciones_espesificas[0] + inf_dat[1] + G_caracter_separacion_funciones_espesificas[0] + inf_dat[1]
                                    ,""
                                    ,"1" + G_caracter_separacion_funciones_espesificas[0] + "1" + G_caracter_separacion_funciones_espesificas[0] + "1"
                                    ,sino_lo_encuentra
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
                            string[] plat_1 = comp_prod_1[2].Split(G_caracter_separacion[4][0]);
                            string[] plat_2 = comp_prod_2[2].Split(G_caracter_separacion[4][0]);

                            if (comp_prod_1[0] == comp_prod_2[0] && plat_1[0] == plat_2[0])
                            {

                                comp_prod_1[1] = (Convert.ToDouble(comp_prod_1[1]) + Convert.ToDouble(comp_prod_2[1])).ToString();
                                
                                plat_1[1] = plat_1[1] + G_caracter_separacion[5] + plat_2[1];
                                comp_prod_1[2] = plat_1[0] + G_caracter_separacion[4] + plat_1[1];
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



        private string[] si_hay_iguales_en_codigo_suma_cantidad_proceso_registros(string[] produc_cantidad)
        {
            string[] arr_retornar = new string[0];
            //hay mas de uno para comparar?
            if (produc_cantidad.Length > 1)
            {
                for (int i = 0; i < produc_cantidad.Length; i++)
                {
                    if (produc_cantidad[i] != "")
                    {
                        string[] comp_prod_1 = produc_cantidad[i].Split(G_caracter_separacion[2][0]);
                        for (int j = i + 1; j < produc_cantidad.Length; j++)
                        {
                            if (produc_cantidad[j] != "")
                            {
                                string[] comp_prod_2 = produc_cantidad[j].Split(G_caracter_separacion[2][0]);

                                if (comp_prod_1[0] == comp_prod_2[0])
                                {
                                    comp_prod_1[1] = (Convert.ToDouble(comp_prod_1[1]) + Convert.ToDouble(comp_prod_2[1])).ToString();
                                    produc_cantidad[j] = "";
                                }
                            }
                        }

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


        private void rep_funcion_cantidad_del_arreglo
            (string direccion_archivo
            ,string num_columnas_comparar
            ,string comparar
            ,string col_editar
            ,object arreglo_o_string_de_comparar_y_editar
            ,int indice_arreglo
            ,string _0_editar_1_incrementar_2_agregar
            )
        {
            string[] arr_comparar_editar = null;
            if (arreglo_o_string_de_comparar_y_editar is string[])
            {
                arr_comparar_editar = (string[])arreglo_o_string_de_comparar_y_editar;
            }
            else
            {
                arr_comparar_editar = arreglo_o_string_de_comparar_y_editar.ToString().Split(G_caracter_separacion[1][0]);
            }
            
            for (int j = 0; j < arr_comparar_editar.Length; j++)
            {
                string dat_epsliteado = "";
                
                string[] inf_dat = dat_epsliteado.Split(G_caracter_separacion[2][0]);
                string res = bas.Editar_incr_o_agrega_COMPARACION_YY_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final_BUSQUEDA_ID
                    (
                    direccion_archivo,
                    num_columnas_comparar,
                    comparar,
                    col_editar,
                    arr_comparar_editar[j],
                    _0_editar_1_incrementar_2_agregar
                    );
                
            }
        }
    }
}
