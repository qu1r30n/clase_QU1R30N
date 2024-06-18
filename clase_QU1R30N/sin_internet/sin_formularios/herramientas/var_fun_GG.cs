using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.herramientas
{
    class var_fun_GG
    {


        static public int GG_indice_donde_comensar = 1;

        static public string[] GG_caracter_separacion = { "|", "°", "¬", "╦" };

        static public string[] GG_caracter_separacion_funciones_espesificas = { "~", "§", "¶" };

        static public string[] GG_caracter_para_confirmacion_o_error = { "╣" };

        //funciones---------------------------------------------------------------------------------------------------------

        public string[] GG_funcion_caracter_separacion(object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = null;
            if (caracter_separacion_objeto == null)
            {
                caracter_separacion = GG_caracter_separacion;
            }
            else
            {
                if (caracter_separacion_objeto is char)
                {
                    caracter_separacion = new string[] { caracter_separacion_objeto + "" };
                }
                if (caracter_separacion_objeto is string)
                {
                    if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[0])
                    {
                        caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][0]);
                    }
                    else
                    {
                        caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[1][0]);
                    }

                }
                if (caracter_separacion_objeto is string[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
            }

            return caracter_separacion;

        }

        public string[] GG_funcion_caracter_separacion_funciones_especificas(object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = null;
            if (caracter_separacion_objeto == null)
            {
                caracter_separacion = GG_caracter_separacion_funciones_espesificas;
            }
            else
            {
                if (caracter_separacion_objeto is char)
                {
                    //caracter_separacion = new string[] { caracter_separacion_objeto + "" };
                    for (int i = 0; i < GG_caracter_separacion_funciones_espesificas.Length; i++)
                    {
                        if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[i])
                        {
                            caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][i]);
                            return caracter_separacion;
                        }
                    }

                }
                if (caracter_separacion_objeto is string)
                {
                    for (int i = 0; i < GG_caracter_separacion_funciones_espesificas.Length; i++)
                    {
                        if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[i])
                        {
                            caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][i]);
                            return caracter_separacion;
                        }
                    }
                }
                if (caracter_separacion_objeto is string[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
                if (caracter_separacion_objeto is char[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
            }

            return caracter_separacion;

        }



        static public string[] GG_variables_string =
        {
           /*0*/ "",//tex_esplit[0]//codbar
           /*1*/ "",//prov_anterior
           /*2*/ "", //provedores_txt//todos_los_provedores
           /*3*/ "",//impuesto anterior
           /*4*/ "", //impuestos_txt//todos_los_impuestos
           /*5*/ "",//tipo_medida_producto_anterior
           /*6*/ ""//tipo_medida_producto_txt//todos_los_tipos_de_medida
           
        };

        //funciones y restricciones txt y cmb ventana_emergente cod:poison
        ////////////////////////////////////////////////////////////////////////
        //                                SI EDITAS                           //
        //                      [,] GG_ventana_emergente_productos            //
        //                             TIENES QUE EDITAR                      //
        //                      RecargarVentanaEmergenteProductos             //
        //                          ES EL DE ABAJITO A ESTE                   //
        ////////////////////////////////////////////////////////////////////////
        static public string[,] GG_ventana_emergente_productos = new string[,]
        {
            /*0*/ { "2", "_0_id", "" },
            /*1*/ { "1", "_1_producto", "" },
            /*2*/ { "1", "_2_contenido", "0|solo_numeros" },
            /*3*/ { "4", "_3_tipo_medida", "NOSE|todas_mayusculas|" + GG_variables_string[5] + '|' + GG_variables_string[6] },
            /*4*/ { "1", "_4_precio_venta", "0|solo_numeros" },
            /*5*/ { "2", "_5_cod_barras", GG_variables_string[0] },
            /*6*/ { "1", "_6_cantidad", "1|solo_numeros" },
            /*7*/ { "1", "_7_costo_comp", "0|solo_numeros" },
            /*8*/ { "4", "_8_provedor", "NOSE|todas_mayusculas|" + GG_variables_string[1] + '|' + GG_variables_string[2] },
            /*9*/ { "4", "_9_grupo", "1||1|1°2°producto_elaborado°venta_ingrediente|ocultar_control¬23¬producto_elaborado°ocultar_control¬29¬venta_ingrediente" },
            /*10*/ { "2", "_10_no_poner_nada", "" },
            /*11*/ { "1", "_11_cant_produc_x_paquet", "1|solo_numeros" },
            /*12*/ { "1", "_12_tipo_de_producto", "||||no_visible°producto_elaborado" },
            /*13*/ { "1", "_13_ligar_produc_sab", "" },
            /*14*/ { "1", "_14_impuestos", "|todas_mayusculas|||reyeno_textbox_ventana_impu" },
            /*15*/ { "1", "_15_si_es_elaborado_que_materia_prima_usa_y_cantidad", "||||no_visible°venta_ingrediente" },
            /*16*/ { "1", "_16_caducidad", "0|solo_numeros" },
            /*17*/ { "1", "_17_ultimo_movimiento", "0|solo_numeros" },
            /*18*/ { "1", "_18_sucursal_vent", "" },
            /*19*/ { "1", "_19_clasificacion_producto", "" },
        };

        public static void RecargarVentanaEmergenteProductos(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_emergente_productos = new string[,]
            {
                /*0*/ { "1", "producto", "" },
                /*1*/ { "1", "contenido", "0|solo_numeros" },
                /*2*/ { "4", "tipo_medida", "NOSE|todas_mayusculas|" + GG_variables_string[5] + '|' + GG_variables_string[6] },
                /*3*/ { "1", "precio_venta", "0|solo_numeros" },
                /*4*/ { "2", "cod_barras", GG_variables_string[0] },
                /*5*/ { "1", "cantidad", "1|solo_numeros" },
                /*6*/ { "1", "costo_comp", "0|solo_numeros" },
                /*7*/ { "4", "provedor", "NOSE|todas_mayusculas|" + GG_variables_string[1] + '|' + GG_variables_string[2] },
                /*8*/ { "4", "grupo", "1||1|1°2°producto_elaborado°venta_ingrediente|ocultar_control¬23¬producto_elaborado°ocultar_control¬29¬venta_ingrediente" },
                /*9*/ { "2", "no poner nada", "" },
                /*10*/ { "1", "cant_produc_x_paquet", "1|solo_numeros" },
                /*11*/ { "1", "tipo_de_producto", "||||no_visible°producto_elaborado" },
                /*12*/ { "1", "ligar_produc_sab", "" },
                /*13*/ { "1", "impuestos", "|todas_mayusculas|||reyeno_textbox_ventana_impu" },
                /*14*/ { "1", "parte_de_que_producto", "||||no_visible°venta_ingrediente" }
            };





            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "todo")
                    {
                        GG_variables_string = new[]
                        {
                            /*0*/ "",//tex_esplit[0]//codbar
                            /*1*/ "",//prov_anterior
                            /*2*/ "", //provedores_txt//todos_los_provedores
                            /*3*/ "",//impuesto anterior
                            /*4*/ "", //impuestos_txt//todos_los_impuestos
                            /*5*/ "",//tipo_medida_producto_anterior
                            /*6*/ ""//tipo_medida_producto_txt//todos_los_tipos_de_medida
           
                        };
                    }

                    else if (datos_a_borrar[i] == "") { }

                    else
                    {
                        GG_variables_string[Convert.ToInt32(datos_a_borrar[i])] = "";
                    }

                }
            }

        }

        //lo mismo ventana provedor
        static public string[,] GG_ventana_provedor =
        {
            { "1","0_ID_EMPRESA","" },
            { "1","1_NOMBRE_EMPRESA","" },
            { "1","2_NOMBRE_ENCARGADO","" },
            { "1","3_DIRECCIÓN_EMPRESA","" },
            { "1","4_CIUDAD_EMPRESA","" },
            { "1","5_ESTADO_EMPRESA","" },
            { "1","6_CÓDIGO_POSTAL","" },
            { "1","7_PAÍS","" },
            { "1","8_CORREO_ELECTRÓNICO","" },
            { "1","9_TELÉFONO_ENCARGADO","" },
            { "1","10_TELEFONO_EMPRESA","" },
            { "1","11_TIPO_DE_PROVEEDOR","" },
            { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" },
            { "1","13_CUENTA_BANCO","" },
            { "1","14_UBICACIÓN_(GPS)","" },
            { "1","15_NOTAS","" },
            { "1","16_RECORDATORIO","" },
            { "1","17_ACTIVO_O_NO_ACTIVO","" },
            { "1","calificacion_preventa¬0°calificacion_entrega¬0","" },
            { "1","comentarios_preventa_entrega","" },
            { "1","dinero","0|solo_numeros" },
            { "1","dias_de_preventa_0°dias_de_preventa_1","" },
            { "1","dias_de_entrega_0°dias_de_entrega_1","" },
            
        };


        public static string columnas_concatenadas(string[,] arreglo_bidimencional, int id_columna, string caracter_separacion = null)
        {
            if (caracter_separacion == null)
            {
                caracter_separacion = GG_caracter_separacion[0];
            }
            string nombresConcatenados = "";

            for (int i = 0; i < arreglo_bidimencional.GetLength(0); i++)
            {
                string nombre = arreglo_bidimencional[i, id_columna];
                nombresConcatenados += nombre + Convert.ToChar(GG_caracter_separacion[0]);
            }

            if (!string.IsNullOrEmpty(nombresConcatenados))
            {
                nombresConcatenados = nombresConcatenados.TrimEnd(Convert.ToChar(GG_caracter_separacion[0]));
            }

            return nombresConcatenados;
        }


        static public string[] GG_direccion_base = { "" };
        static public string[,] GG_dir_nom_archivos =
        {
            /*0*/{ GG_direccion_base[0]+"CONFIG\\INF\\INVENTARIO\\INVENTARIO.TXT", columnas_concatenadas(GG_ventana_emergente_productos,1,GG_caracter_separacion[0])},
            /*0*/{ GG_direccion_base[0]+"CONFIG\\INF\\DAT\\PROVEDORES.TXT", columnas_concatenadas(GG_ventana_provedor,1,GG_caracter_separacion[0])},

        };






        //movimientos a repetir esto es mas para la aplicacion del celular para pasarlo al de la computadora y mejorar
        //tienes que poner en datos la informacion de_las_variables si es un arreglo usa el join paresido y agregale un GG_separador_para_funciones_espesificas
        public string GG_movimientos_a_repetir(string direccion, string datos, bool guardar_movimiento = false)
        {
            if (guardar_movimiento == true)
            {


                Tex_base bas = new Tex_base();
                operaciones_textos op_textos = new operaciones_textos();
                string carpetas = op_textos.joineada_paraesida_y_quitador_de_extremos_del_string(direccion, "\\", 2);

                bas.Agregar(direccion, datos,false);

                return datos;
            }
            return null;
        }

        //registro para control de ventas compras y todo
        public string GG_registros(string direccion, object datos)
        {
            Tex_base bas = new Tex_base();
            operaciones_textos op_textos = new operaciones_textos();
            string carpetas = op_textos.joineada_paraesida_y_quitador_de_extremos_del_string(direccion, "\\", 2);

            string info_a_retornar = "";
            if (datos is string)
            {

                bas.Agregar(direccion, (string)datos,false);
                info_a_retornar = (string)datos;
                return info_a_retornar;
            }
            else if (datos is string[])
            {
                string[] temp = (string[])datos;
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(carpetas + "\\", "datos", leer_y_agrega_al_arreglo: false);
                for (int i = 0; i < temp.Length; i++)
                {
                    bas.Agregar(direccion, temp[i],false);
                    info_a_retornar = info_a_retornar + temp[i] + "\n";
                }
                return info_a_retornar;
            }
            return null;
        }


        public object GG_retorno_de_datos(object variable_a_la_que_devolvera, string respuesta_devolver_texto = null, string respuesta_devolver_verdadero_1_falso_0 = null, string respuesta_devolver_numer = null, string[] respuesta_devolver_arreglo_texto = null, string[] respuesta_devolver_arreglo_verdadero_1_falso_0 = null, string[] respuesta_devolver_arreglo_numer = null)
        {
            if (variable_a_la_que_devolvera is string)
            {
                if (respuesta_devolver_arreglo_texto!=null)
                {
                    return respuesta_devolver_texto;
                }
            }
            else if (variable_a_la_que_devolvera is bool)
            {
                
                if (respuesta_devolver_verdadero_1_falso_0 != null)
                {
                    bool valor_retornar = false;
                    if (respuesta_devolver_verdadero_1_falso_0=="1")
                    {
                        valor_retornar = true;
                    }
                    return valor_retornar;
                }
            }
            else if (variable_a_la_que_devolvera is double || variable_a_la_que_devolvera is int)
            {
                if (respuesta_devolver_numer != null)
                {
                    return Convert.ToDouble(respuesta_devolver_numer);
                }
            }
            else if (variable_a_la_que_devolvera is string[])
            {
                if (respuesta_devolver_arreglo_texto != null)
                {
                    return respuesta_devolver_arreglo_texto;
                }
            }
            else if (variable_a_la_que_devolvera is bool[])
            {
                if (respuesta_devolver_arreglo_verdadero_1_falso_0 != null)
                {
                    bool[] temp = new bool[respuesta_devolver_arreglo_verdadero_1_falso_0.Length];
                    for (int i = 0; i < respuesta_devolver_arreglo_verdadero_1_falso_0.Length; i++)
                    {
                        temp[i] = false;
                        if (respuesta_devolver_arreglo_verdadero_1_falso_0[i]=="1")
                        {
                            temp[i] = true;
                        }
                        
                    }
                    return temp;
                }
            }
            else if (variable_a_la_que_devolvera is double[] || variable_a_la_que_devolvera is int[])
            {
                if (respuesta_devolver_arreglo_numer != null)
                {
                    double[] temp = new double[respuesta_devolver_arreglo_numer.Length];
                    for (int i = 0; i < respuesta_devolver_arreglo_numer.Length; i++)
                    {
                        temp[i] = Convert.ToDouble(respuesta_devolver_arreglo_numer[i]);
                    }
                }
            }

            return null;

        }

    }
}
