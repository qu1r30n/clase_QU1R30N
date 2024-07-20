using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _3_proceso_productos_e_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;
        
        

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();
        
        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.txt",
        };

        public string agregar_producto(string direccion_archivo,string producto)
        {
            string info_a_retornar = "";
            string res_ind_ar = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp = res_ind_ar.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_ind_ar[0]) > 0)
            {

                if (res_esp[0] == "1")
                {

                    string[] producto_espliteado = producto.Split(G_caracter_separacion[0][0]);

                    DateTime fecha_hora = DateTime.Now;
                    string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
                    string año = fecha_hora.ToString("yyyy");
                    int indice_arreglo = Convert.ToInt32(res_esp[1]);


                    string _0_id = "" + Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length;
                    string _1_NOM_PRODUCTO = producto_espliteado[0];
                    double _2_CONTENIDO = Convert.ToDouble(producto_espliteado[1]);
                    string _3_TIPO_MEDIDA = producto_espliteado[2];
                    double _4_PRECIO_VENTA = Convert.ToDouble(producto_espliteado[3]);
                    string _5_COD_BARRAS = producto_espliteado[4];
                    double _6_CANTIDAD = Convert.ToDouble(producto_espliteado[5]);
                    double _7_COSTO_COMP = Convert.ToDouble(producto_espliteado[6]);
                    string _8_PROVEDOR = producto_espliteado[7];
                    string _9_GRUPO = producto_espliteado[8];
                    double _10_CANT_PRODUC_X_PAQUET = Convert.ToDouble(producto_espliteado[9]);
                    string _11_COD_BAR_PAQUETE1_DATO1_DATO2_COD_BAR2_PAQUETE1_DATO1_DATO2 = producto_espliteado[10];
                    string _12_COD_BAR_INDIVIDUAL_ES_PAQ = producto_espliteado[11];
                    string _13_LIGAR_PRODUC_SAB = producto_espliteado[12];
                    string _14_IMPUESTOS = producto_espliteado[13];
                    string _15_SI_ES_ELABORADO_QUE_MATERIA_PRIMA_USA_Y_CANTIDAD = producto_espliteado[14];
                    string _16_CADUCIDAD = producto_espliteado[15];
                    string _17_ULTIMO_MOVIMIENTO = producto_espliteado[16];
                    string _18_SUCURSAL_VENT = producto_espliteado[17];
                    string _19_CLASIFICACION_PRODUCTO = producto_espliteado[18];
                    string _20_DIRECCION_IMAGEN_INTERNET = producto_espliteado[19];
                    string _21_DIRECCION_IMAGEN_COMPUTADORA = producto_espliteado[20];
                    string _22_NO_PONER_NADA = producto_espliteado[21];

                    string todo_unido = _0_id + G_caracter_separacion[0] +
                     _1_NOM_PRODUCTO + G_caracter_separacion[0] +
                     _2_CONTENIDO + G_caracter_separacion[0] +
                     _3_TIPO_MEDIDA + G_caracter_separacion[0] +
                     _4_PRECIO_VENTA + G_caracter_separacion[0] +
                     _5_COD_BARRAS + G_caracter_separacion[0] +
                     _6_CANTIDAD + G_caracter_separacion[0] +
                     _7_COSTO_COMP + G_caracter_separacion[0] +
                     _8_PROVEDOR + G_caracter_separacion[0] +
                     _9_GRUPO + G_caracter_separacion[0] +
                     _10_CANT_PRODUC_X_PAQUET + G_caracter_separacion[0] +
                     _11_COD_BAR_PAQUETE1_DATO1_DATO2_COD_BAR2_PAQUETE1_DATO1_DATO2 + G_caracter_separacion[0] +
                     _12_COD_BAR_INDIVIDUAL_ES_PAQ + G_caracter_separacion[0] +
                     _13_LIGAR_PRODUC_SAB + G_caracter_separacion[0] +
                     _14_IMPUESTOS + G_caracter_separacion[0] +
                     _15_SI_ES_ELABORADO_QUE_MATERIA_PRIMA_USA_Y_CANTIDAD + G_caracter_separacion[0] +
                     _16_CADUCIDAD + G_caracter_separacion[0] +
                     _17_ULTIMO_MOVIMIENTO + G_caracter_separacion[0] +
                     _18_SUCURSAL_VENT + G_caracter_separacion[0] +
                     _19_CLASIFICACION_PRODUCTO + G_caracter_separacion[0] +
                     _20_DIRECCION_IMAGEN_INTERNET + G_caracter_separacion[0] +
                     _21_DIRECCION_IMAGEN_COMPUTADORA + G_caracter_separacion[0] +
                     _22_NO_PONER_NADA;

                    info_a_retornar = bas.Agregar(direccion_archivo, todo_unido);


                    var_fun_GG.GG_autoCompleteCollection_codbar_venta.Add(_5_COD_BARRAS + G_caracter_separacion[0] + _1_NOM_PRODUCTO + " " + _2_CONTENIDO + _3_TIPO_MEDIDA + G_caracter_separacion[0] + _0_id);
                    var_fun_GG.GG_autoCompleteCollection_nom_produc_venta.Add(_1_NOM_PRODUCTO + G_caracter_separacion[0] + _5_COD_BARRAS + " " + _2_CONTENIDO + _3_TIPO_MEDIDA + G_caracter_separacion[0] + _0_id);

                    return "";
                }

                


            }

            else
            {
                if (res_esp[0]=="0")
                {
                    return "0";
                }
                else if(res_esp[0]=="-1") 
                {
                    return "-1";
                }
            }

            return "";
        }


        public string agrega_si_no_existe(string direccion_archivo, string producto)
        {
            string info_a_retornar = "";
            string res_ind_ar = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp = res_ind_ar.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_ind_ar[0]) > 0)
            {

                if (res_esp[0] == "1")
                {

                    string[] producto_espliteado = producto.Split(G_caracter_separacion[0][0]);

                    DateTime fecha_hora = DateTime.Now;
                    string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
                    string año = fecha_hora.ToString("yyyy");
                    int indice_arreglo = Convert.ToInt32(res_esp[1]);


                    string _0_id = "" + Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length;
                    string _1_NOM_PRODUCTO = producto_espliteado[0];
                    double _2_CONTENIDO = Convert.ToDouble(producto_espliteado[1]);
                    string _3_TIPO_MEDIDA = producto_espliteado[2];
                    double _4_PRECIO_VENTA = Convert.ToDouble(producto_espliteado[3]);
                    string _5_COD_BARRAS = producto_espliteado[4];
                    double _6_CANTIDAD = Convert.ToDouble(producto_espliteado[5]);
                    double _7_COSTO_COMP = Convert.ToDouble(producto_espliteado[6]);
                    string _8_PROVEDOR = producto_espliteado[7];
                    string _9_GRUPO = producto_espliteado[8];
                    double _10_CANT_PRODUC_X_PAQUET = Convert.ToDouble(producto_espliteado[9]);
                    string _11_COD_BAR_PAQUETE1_DATO1_DATO2_COD_BAR2_PAQUETE1_DATO1_DATO2 = producto_espliteado[10];
                    string _12_LIGAR_PRODUC_SAB = producto_espliteado[11];
                    string _13_IMPUESTOS = producto_espliteado[12];
                    string _14_SI_ES_ELABORADO_QUE_MATERIA_PRIMA_USA_Y_CANTIDAD = producto_espliteado[13];
                    string _15_CADUCIDAD = producto_espliteado[14];
                    int _16_ULTIMO_MOVIMIENTO = Convert.ToInt32(producto_espliteado[15]);
                    string _17_SUCURSAL_VENT = producto_espliteado[16];
                    string _18_CLASIFICACION_PRODUCTO = producto_espliteado[17];
                    string _19_DIRECCION_IMAGEN_INTERNET = producto_espliteado[18];
                    string _20_DIRECCION_IMAGEN_COMPUTADORA = producto_espliteado[19];
                    string _21_NO_PONER_NADA = producto_espliteado[20];



                    string todo_unido = _0_id + G_caracter_separacion[0] +
                     _1_NOM_PRODUCTO + G_caracter_separacion[0] +
                     _2_CONTENIDO + G_caracter_separacion[0] +
                     _3_TIPO_MEDIDA + G_caracter_separacion[0] +
                     _4_PRECIO_VENTA + G_caracter_separacion[0] +
                     _5_COD_BARRAS + G_caracter_separacion[0] +
                     _6_CANTIDAD + G_caracter_separacion[0] +
                     _7_COSTO_COMP + G_caracter_separacion[0] +
                     _8_PROVEDOR + G_caracter_separacion[0] +
                     _9_GRUPO + G_caracter_separacion[0] +
                     _10_CANT_PRODUC_X_PAQUET + G_caracter_separacion[0] +
                     _11_COD_BAR_PAQUETE1_DATO1_DATO2_COD_BAR2_PAQUETE1_DATO1_DATO2 + G_caracter_separacion[0] +
                     _12_LIGAR_PRODUC_SAB + G_caracter_separacion[0] +
                     _13_IMPUESTOS + G_caracter_separacion[0] +
                     _14_SI_ES_ELABORADO_QUE_MATERIA_PRIMA_USA_Y_CANTIDAD + G_caracter_separacion[0] +
                     _15_CADUCIDAD + G_caracter_separacion[0] +
                     _16_ULTIMO_MOVIMIENTO + G_caracter_separacion[0] +
                     _17_SUCURSAL_VENT + G_caracter_separacion[0] +
                     _18_CLASIFICACION_PRODUCTO + G_caracter_separacion[0] +
                     _19_DIRECCION_IMAGEN_INTERNET + G_caracter_separacion[0] +
                     _20_DIRECCION_IMAGEN_COMPUTADORA + G_caracter_separacion[0] +
                     _21_NO_PONER_NADA;

                    info_a_retornar = bas.Agregar_sino_existe(direccion_archivo, 5, _5_COD_BARRAS, todo_unido);
                    string[] resultado_espliteado = info_a_retornar.Split(G_caracter_para_confirmacion_o_error[0][0]);

                    if (resultado_espliteado[0]=="1")
                    {
                        var_fun_GG.GG_autoCompleteCollection_codbar_venta.Add(_5_COD_BARRAS + G_caracter_separacion[0] + _1_NOM_PRODUCTO + " " + _2_CONTENIDO + _3_TIPO_MEDIDA + G_caracter_separacion[0] + _0_id);
                        var_fun_GG.GG_autoCompleteCollection_nom_produc_venta.Add(_1_NOM_PRODUCTO + G_caracter_separacion[0] + _5_COD_BARRAS + " " + _2_CONTENIDO + _3_TIPO_MEDIDA + G_caracter_separacion[0] + _0_id);

                    }
                    

                    


                }




            }

            else
            {
                if (res_esp[0] == "0")
                {
                    info_a_retornar = "0";
                }
                else if (res_esp[0] == "-1")
                {
                    info_a_retornar = "-1";
                }
            }

            return info_a_retornar;
        }

        public string buscar(string direccion_archivo, string cod_bar,string id_producto_string="")
        {
            string inf_retornar = "";
            string[]res_busq=bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo).Split(G_caracter_para_confirmacion_o_error[0][0]);
            int indice = Convert.ToInt32(res_busq[1]);
            if (id_producto_string != "")
            {
                int id_producto = Convert.ToInt32(id_producto_string);
                string[] info_produc_esp = Tex_base.GG_base_arreglo_de_arreglos[indice][id_producto].Split(G_caracter_separacion[0][0]);
                if (cod_bar == info_produc_esp[5])
                {
                    inf_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][id_producto] + G_caracter_para_confirmacion_o_error[0] + id_producto;
                }
                else
                {
                    bool encontro_producto = false;
                    int indice_iniciar_busqueda = id_producto;
                    if (id_producto>9) { indice_iniciar_busqueda = indice_iniciar_busqueda - 10; }
                    else{ indice_iniciar_busqueda = G_donde_inicia_la_tabla; }

                    for (int i = indice_iniciar_busqueda; i < id_producto; i++)
                    {
                        string[] info_prod_bas= Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);
                        if (cod_bar == info_prod_bas[5])
                        {
                            inf_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                            encontro_producto = true;
                            break;
                        }
                    }
                    if (encontro_producto == false)
                    {

                        for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
                        {
                            string[] info_prod_bas = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);

                            if (cod_bar == info_prod_bas[5])
                            {
                                inf_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                                encontro_producto = true;
                                break;
                            }
                        }

                    }
                }
            }
            else
            {
                bool encontro_producto = false;
                for (int i = 0; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
                {
                    string[] info_produc_esp = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);
                    if (cod_bar == info_produc_esp[5])
                    {
                        inf_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                        encontro_producto = true;
                        break;
                    }
                }
                if (encontro_producto == false)
                {
                    inf_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no encontro el producto";
                }
            }
            return inf_retornar;
        }

        public string sacar_info_productos_unitario_del_paquete(string direccion_archivo, string cod_bar_si_es_paquete, string id_producto_string = "")
        {
            string info_retornar = "";
            string[] res_busq = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo).Split(G_caracter_para_confirmacion_o_error[0][0]);
            int indice = Convert.ToInt32(res_busq[1]);
            if (id_producto_string != "")
            {
                int id_producto = Convert.ToInt32(id_producto_string);
                string[] info_produc_esp = Tex_base.GG_base_arreglo_de_arreglos[indice][id_producto].Split(G_caracter_separacion[0][0]);
                if (cod_bar_si_es_paquete == info_produc_esp[5])
                {
                    info_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][id_producto] + G_caracter_para_confirmacion_o_error[0] + id_producto;
                }
                else
                {
                    bool encontro_producto = false;
                    int indice_iniciar_busqueda = id_producto;
                    if (id_producto > 9) { indice_iniciar_busqueda = indice_iniciar_busqueda - 10; }
                    else { indice_iniciar_busqueda = G_donde_inicia_la_tabla; }

                    for (int i = indice_iniciar_busqueda; i < id_producto; i++)
                    {
                        string[] info_prod_bas = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);
                        if (cod_bar_si_es_paquete == info_prod_bas[5])
                        {
                            info_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                            encontro_producto = true;
                            break;
                        }
                    }
                    if (encontro_producto == false)
                    {

                        for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
                        {
                            string[] info_prod_bas = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);

                            if (cod_bar_si_es_paquete == info_prod_bas[5])
                            {
                                info_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                                encontro_producto = true;
                                break;
                            }
                        }

                    }
                }
            }
            else
            {
                bool encontro_producto = false;
                for (int i = 0; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
                {
                    string[] info_produc_esp = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);
                    if (cod_bar_si_es_paquete == info_produc_esp[5])
                    {
                        info_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + Tex_base.GG_base_arreglo_de_arreglos[indice][i] + G_caracter_para_confirmacion_o_error[0] + i;
                        encontro_producto = true;
                        break;
                    }
                }
                if (encontro_producto == false)
                {
                    info_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no encontro el producto";
                }
            }


            return info_retornar;

        }

        public string hacer_inventario(string informacion, object caracter_separacion_obj = null, object caracter_separacion_obj_funciones_espesificas_obj = null)
        {
            string info_retornar = "";

            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string[] caracter_separacion_funciones_espesificas = vf_GG.GG_funcion_caracter_separacion_funciones_especificas(caracter_separacion_obj_funciones_espesificas_obj);

            string[] cantidad_informacion = informacion.Split(caracter_separacion_funciones_espesificas[0][0]);

            for (int i = 0; i < cantidad_informacion.Length; i++)
            {
                string[] info_producto = cantidad_informacion[i].Split(caracter_separacion[0][0]);

                string res_busq = buscar(G_direcciones[0], info_producto[0]);
                
                string[] res_esp = res_busq.Split(G_caracter_para_confirmacion_o_error[0][0]);
                string[] info_esp_producto = res_esp[1].Split(G_caracter_separacion[0][0]);
                string info_a_procesar = "";
                if (Convert.ToInt32(res_esp[0]) > 0)
                {

                    info_a_procesar = info_producto[0] + G_caracter_separacion[0] + info_esp_producto[1] + G_caracter_separacion[0] + info_producto[2] + G_caracter_separacion[0] + info_producto[3];

                    
                }
                else
                {
                    info_a_procesar = info_producto[0] + G_caracter_separacion[0] + "NOMBRE_PRODUCTO" + G_caracter_separacion[0] + info_producto[2] + G_caracter_separacion[0] + info_producto[3];
                }

            }

            return info_retornar;
            
        }

        public string dar_el_inventario_string_caracter_sep(string direccion_archivo, object caracter_separacion_obj = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion_funciones_especificas(caracter_separacion_obj);
            string[] res_inv = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo).Split(G_caracter_para_confirmacion_o_error[0][0]);
            int indice = Convert.ToInt32(res_inv[1]);

            string inventario = op_tex.join_paresido_simple(caracter_separacion[0][0], Tex_base.GG_base_arreglo_de_arreglos[indice]);

            return inventario;
            
        }

    }
}
