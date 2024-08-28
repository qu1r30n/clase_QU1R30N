using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.herramientas
{
    internal class var_fun_GG_dir_arch_crear
    {


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
        //                      [,] GG_ventana_emergente_                     //
        //                             TIENES QUE EDITAR                      //
        //                      RecargarVentanaEmergente                      //
        //                          ES EL DE ABAJITO A ESTE                   //
        //           TIENE QUE SER EL MISMO ARREGLO UNO QUE EL OTRO           //
        ////////////////////////////////////////////////////////////////////////

        //datos configuracio

        static public string[,] GG_ventana_datos_conf = new string[,]
        {
                /*0*/ { "2", "dato_de_configuracion", "" },
                /*1*/ { "2", "descripcion_de_configuracion", "" }
        };
        public static void RecargarVentanaEmergenteDatosConfiguracion(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_datos_conf = new string[,]
            {
                /*0*/ { "2", "dato_de_configuracion", "" },
                /*1*/ { "2", "descripcion_de_configuracion", "" }
            };





            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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


        //ventana productos
        static public string[,] GG_ventana_emergente_productos = new string[,]
        {
            /*0*/ { "2", "ID", "" },
            /*1*/ { "1", "PRODUCTO", "" },
            /*2*/ { "1", "CONTENIDO", "0|SOLO_NUMEROS" },
            /*3*/ { "4", "TIPO_MEDIDA", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[1] + '|' + GG_variables_string[2] },
            /*4*/ { "1", "PRECIO_VENTA", "0|SOLO_NUMEROS" },
            /*5*/ { "2", "COD_BARRAS", GG_variables_string[0] },
            /*6*/ { "1", "CANTIDAD", "1|SOLO_NUMEROS" },
            /*7*/ { "1", "COSTO_COMP", "0|SOLO_NUMEROS" },
            /*8*/ { "4", "PROVEDOR", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[5] + '|' + GG_variables_string[6] },
            /*9*/ { "4", "GRUPO", "PRODUCTO_PIEZA||PRODUCTO_PIEZA|PRODUCTO_PIEZA°PRODUCTO_CANTIDAD°PRODUCTO_ELABORADO°VENTA_INGREDIENTE|OCULTAR_CONTROL¬29¬PRODUCTO_ELABORADO°OCULTAR_CONTROL¬45¬PRODUCTO_ELABORADO" },
            /*10*/ { "1", "CANT_X_PAQUET", "1|SOLO_NUMEROS" },
            /*11*/ { "4", "ES_PAQUETE", "INDIVIDUAL||INDIVIDUAL|INDIVIDUAL°PAQUETE_MAYOREO°PAQUETE_PROMOCION|OCULTAR_CONTROL¬27¬PAQUETE_MAYOREO╦PAQUETE_PROMOCION" },
            /*12*/ { "1", "CODBAR_PAQUETE", "" },
            /*13*/ { "1", "COD_BAR_INDIVIDUAL_ES_PAQ", "" },
            /*14*/ { "1", "LIGAR_PROD_SAB", "" },
            /*15*/ { "1", "IMPUESTOS", "|TODAS_MAYUSCULAS|||REYENO_TEXTBOX_VENTANA_IMPU" },
            /*16*/ { "1", "INGREDIENTES", "||||NO_VISIBLE°PRODUCTO_ELABORADO" },
            /*17*/ { "1", "CADUCIDAD", "0|SOLO_NUMEROS" },
            /*18*/ { "1", "ULTIMO_MOV", "0|SOLO_NUMEROS" },
            /*19*/ { "1", "SUCUR_VENT", "" },
            /*20*/ { "1", "CLAF_PROD", "" },
            /*21*/ { "1", "DIR_IMG_INTER", "" },
            /*22*/ { "1", "DIR_IMG_COMP", "" },
            /*23*/ { "1", "INFO_EXTRA", "" },
            /*24*/ { "1", "PROCESO_CREAR", "||||NO_VISIBLE" },
            /*25*/ { "1", "DIR_VID_PROC_CREAR", "" },
            /*26*/ { "2", "NO_PONER_NADA", "" },
        };
        public static void RecargarVentanaEmergenteProductos(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_emergente_productos = new string[,]
            {
                /*0*/ { "2", "ID", "" },
            /*1*/ { "1", "PRODUCTO", "" },
            /*2*/ { "1", "CONTENIDO", "0|SOLO_NUMEROS" },
            /*3*/ { "4", "TIPO_MEDIDA", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[1] + '|' + GG_variables_string[2] },
            /*4*/ { "1", "PRECIO_VENTA", "0|SOLO_NUMEROS" },
            /*5*/ { "2", "COD_BARRAS", GG_variables_string[0] },
            /*6*/ { "1", "CANTIDAD", "1|SOLO_NUMEROS" },
            /*7*/ { "1", "COSTO_COMP", "0|SOLO_NUMEROS" },
            /*8*/ { "4", "PROVEDOR", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[5] + '|' + GG_variables_string[6] },
            /*9*/ { "4", "GRUPO", "PRODUCTO_PIEZA||PRODUCTO_PIEZA|PRODUCTO_PIEZA°PRODUCTO_CANTIDAD°PRODUCTO_ELABORADO°VENTA_INGREDIENTE|OCULTAR_CONTROL¬29¬PRODUCTO_ELABORADO°OCULTAR_CONTROL¬45¬PRODUCTO_ELABORADO" },
            /*10*/ { "1", "CANT_X_PAQUET", "1|SOLO_NUMEROS" },
            /*11*/ { "4", "ES_PAQUETE", "INDIVIDUAL||INDIVIDUAL|INDIVIDUAL°PAQUETE_MAYOREO°PAQUETE_PROMOCION|OCULTAR_CONTROL¬27¬PAQUETE_MAYOREO╦PAQUETE_PROMOCION" },
            /*12*/ { "1", "CODBAR_PAQUETE", "" },
            /*13*/ { "1", "COD_BAR_INDIVIDUAL_ES_PAQ", "" },
            /*14*/ { "1", "LIGAR_PROD_SAB", "" },
            /*15*/ { "1", "IMPUESTOS", "|TODAS_MAYUSCULAS|||REYENO_TEXTBOX_VENTANA_IMPU" },
            /*16*/ { "1", "INGREDIENTES", "||||NO_VISIBLE°PRODUCTO_ELABORADO" },
            /*17*/ { "1", "CADUCIDAD", "0|SOLO_NUMEROS" },
            /*18*/ { "1", "ULTIMO_MOV", "0|SOLO_NUMEROS" },
            /*19*/ { "1", "SUCUR_VENT", "" },
            /*20*/ { "1", "CLAF_PROD", "" },
            /*21*/ { "1", "DIR_IMG_INTER", "" },
            /*22*/ { "1", "DIR_IMG_COMP", "" },
            /*23*/ { "1", "INFO_EXTRA", "" },
            /*24*/ { "1", "PROCESO_CREAR", "||||NO_VISIBLE" },
            /*25*/ { "1", "DIR_VID_PROC_CREAR", "" },
            /*26*/ { "2", "NO_PONER_NADA", "" },
            };





            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //cosas no estaban en el inventario
        static public string[,] GG_ventana_COSAS_NO_ESTABAN_INVENTARIO =
        {
            { "1","0_COD_BAR","" },
            { "1","1_NOMBRE","" },

        };
        public static void RecargarVentanaEmergente_Cosas_que_no_estaban(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_COSAS_NO_ESTABAN_INVENTARIO = new string[,]
            {
                { "1","0_COD_BAR","" },
                { "1","1_NOMBRE","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana provedores
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
            { "1","18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0","" },
            { "1","19_COMENTARIOS_PREVENTA_ENTREGA","" },
            { "1","20_SUCURSALES_QUE_LE_COMPRAN","" },
            { "1","21_DINERO_A_COMPRARLE","0|SOLO_NUMEROS" },
            { "1","22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1","" },
            { "1","23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1","" },


        };
        public static void RecargarVentanaEmergenteProvedor(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_provedor = new string[,]
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
                { "1","18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0","" },
                { "1","19_COMENTARIOS_PREVENTA_ENTREGA","" },
                { "1","20_SUCURSALES_QUE_LE_COMPRAN","" },
                { "1","21_DINERO_A_COMPRARLE","0|SOLO_NUMEROS" },
                { "1","22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1","" },
                { "1","23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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


        //ventana APRENDICES_E
        static public string[,] GG_ventana_APRENDICES_E =
        {
            { "2","0_ID","" },
            { "1","1_NOMBRE","" },
            { "1","2_APELLIDO_PATERNO","" },
            { "1","3_APELLIDO_MATERNO","" },
            { "1","4_FECHA_DE_NACIMIENTO","" },
            { "1","5_GÉNERO","" },
            { "1","6_DIRECCIÓN","" },
            { "1","7_CIUDAD","" },
            { "1","8_ESTADO_PROVINCIA","" },
            { "1","9_CÓDIGO_POSTAL","" },
            { "1","10_PAÍS","" },
            { "1","11_CORREO_ELECTRÓNICO","" },
            { "1","12_TELÉFONO","" },
            { "1","13_FECHA_DE_INGRESO","" },
            { "1","14_SUELDO","" },
            { "1","15_CARGO","" },
            { "1","16_ESTADO_DE_CURS_APRENDIS_E","" },
            { "1","17_SUPERVISOR","" },
            { "1","18_NOTAS","" },
            { "1","19_AFILIADO","" },
            { "1","20_FECHA_DE_TERMINACIÓN","0|SOLO_NUMEROS" },
            { "1","21_MOTIVO_DE_TERMINACIÓN°DIAS_DE_PREVENTA_1","" },
            { "1","22_HORAS_TRABAJADAS","" },
            { "1","23_EVALUACIONES_DE_DESEMPEÑO","" },
            { "1","24_HABILIDADES_Y_CERTIFICACIONES","" },
            { "1","25_IDIOMAS","" },
            { "1","26_FECHA_DE_ÚLTIMA_PROMOCIÓN","" },
            { "1","27_ID_DEL_DEPARTAMENTO_DE_SUPERVISIÓN","" },
            { "1","28_HISTORIAL_DE_CAPACITACIÓN","" },
            { "1","29_ÚLTIMO_AUMENTO_DE_SALARIO","" },
            { "1","30_TIPO_EMPLEADO","" },
            { "1","31_RANGO_CALIF","" },

        };
        public static void RecargarVentanaEmergenteAPRENDICES_E(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_APRENDICES_E = new string[,]
            {
                { "2","0_ID","" },
                { "1","1_NOMBRE","" },
                { "1","2_APELLIDO_PATERNO","" },
                { "1","3_APELLIDO_MATERNO","" },
                { "1","4_FECHA_DE_NACIMIENTO","" },
                { "1","5_GÉNERO","" },
                { "1","6_DIRECCIÓN","" },
                { "1","7_CIUDAD","" },
                { "1","8_ESTADO_PROVINCIA","" },
                { "1","9_CÓDIGO_POSTAL","" },
                { "1","10_PAÍS","" },
                { "1","11_CORREO_ELECTRÓNICO","" },
                { "1","12_TELÉFONO","" },
                { "1","13_FECHA_DE_INGRESO","" },
                { "1","14_SUELDO","" },
                { "1","15_CARGO","" },
                { "1","16_ESTADO_DE_CURS_APRENDIS_E","" },
                { "1","17_SUPERVISOR","" },
                { "1","18_NOTAS","" },
                { "1","19_AFILIADO","" },
                { "1","20_FECHA_DE_TERMINACIÓN","0|SOLO_NUMEROS" },
                { "1","21_MOTIVO_DE_TERMINACIÓN°DIAS_DE_PREVENTA_1","" },
                { "1","22_HORAS_TRABAJADAS","" },
                { "1","23_EVALUACIONES_DE_DESEMPEÑO","" },
                { "1","24_HABILIDADES_Y_CERTIFICACIONES","" },
                { "1","25_IDIOMAS","" },
                { "1","26_FECHA_DE_ÚLTIMA_PROMOCIÓN","" },
                { "1","27_ID_DEL_DEPARTAMENTO_DE_SUPERVISIÓN","" },
                { "1","28_HISTORIAL_DE_CAPACITACIÓN","" },
                { "1","29_ÚLTIMO_AUMENTO_DE_SALARIO","" },
                { "1","30_TIPO_EMPLEADO","" },
                { "1","31_RANGO_CALIF","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana afiliados_simples
        static public string[,] GG_ventana_afiliados_simples =
        {
            { "2","0_ID_USUARIO","" },
            { "1","1_ID_PAT_COMP","" },
            { "1","2_TABLA_PAT_COMP","" },
            { "1","3_ID_ENC_SIMP","" },
            { "1","4_TABLA_ENC_SIMP","" },
            { "1","5_PUNTOS_D","" },
            { "1","6_PUNTOS_D_A_DAR","" },
            { "1","7_DATOS","" },
            { "1","8_NIVELES","" },
            { "1","9_ID_HORIZONTAL","" },
            { "1","10_TIPO_AFILIADO","" },

        };
        public static void RecargarVentanaEmergenteAfiliados_simples(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_simples = new string[,]
            {
                { "2","0_ID_USUARIO","" },
                { "1","1_ID_PAT_COMP","" },
                { "1","2_TABLA_PAT_COMP","" },
                { "1","3_ID_ENC_SIMP","" },
                { "1","4_TABLA_ENC_SIMP","" },
                { "1","5_PUNTOS_D","" },
                { "1","6_PUNTOS_D_A_DAR","" },
                { "1","7_DATOS","" },
                { "1","8_NIVELES","" },
                { "1","9_ID_HORIZONTAL","" },
                { "1","10_TIPO_AFILIADO","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana afiliados_complejos
        static public string[,] GG_ventana_afiliados_complejos =
        {
            { "2","0_ID_USUARIO","" },
            { "1","1_ID_PAT_COMP","" },
            { "1","2_TABLA_PAT_COMP","" },
            { "1","3_ID_ENC_SIMP","" },
            { "1","4_TABLA_ENC_SIMP","" },
            { "1","5_PUNTOS_D","" },
            { "1","6_PUNTOS_D_A_DAR","" },
            { "1","7_DATOS","" },
            { "1","8_NIVELES","" },
            { "1","9_ID_HORIZONTAL","" },
            { "1","10_TIPO_AFILIADO","" },

        };
        public static void RecargarVentanaEmergenteAfiliados(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_complejos = new string[,]
            {
                { "2","0_ID_USUARIO","" },
                { "1","1_ID_PAT_COMP","" },
                { "1","2_TABLA_PAT_COMP","" },
                { "1","3_ID_ENC_SIMP","" },
                { "1","4_TABLA_ENC_SIMP","" },
                { "1","5_PUNTOS_D","" },
                { "1","6_PUNTOS_D_A_DAR","" },
                { "1","7_DATOS","" },
                { "1","8_NIVELES","" },
                { "1","9_ID_HORIZONTAL","" },
                { "1","10_TIPO_AFILIADO","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana niveles_afiliados_simples
        static public string[,] GG_ventana_niv_afiliados_simples =
        {
            { "1","0_NIVEL","" },
            { "1","1_ID_HORIZONTAL","" },
            { "1","2_VACIOS","" },
        };
        public static void RecargarVentanaEmergente_niv_afiliados_simples(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_simples = new string[,]
            {
                { "1","0_NIVEL","" },
                { "1","1_ID_HORIZONTAL","" },
                { "1","2_VACIOS","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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



        //ventana niv_afiliados_comp
        static public string[,] GG_ventana_niv_afiliados_comp =
        {
            { "1","0_NIVEL","" },
            { "1","1_ID_HORIZONTAL","" },
            { "1","2_VACIOS","" },

        };
        public static void RecargarVentanaEmergente_niv_afiliados_comp(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_comp = new string[,]
            {
                { "1","0_NIVEL","" },
                { "1","1_ID_HORIZONTAL","" },
                { "1","2_VACIOS","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana afiliados_unificados
        static public string[,] GG_ventana_afiliados_unificados =
        {
            { "1","0)ID_USUARIO","" },
            { "1","1)0IDP╦1IDP¬0PROYECTO_P°0IDP╦1IDP¬1PROYECTO_P","" },
            { "1","2)0IPUNTOS_D_R¬0PROYECTO_R°1PUNTOS_D_R¬1PROYECTO_R","" },
            { "1","3)PUNTOS_D_R_TOTALES","" },
            { "1","4)DATOS","" },
            { "1","5)NIVEL","" },
            { "1","6)ID_HORIZONTAL","" },
            { "1","7)TIPO_AFILIADO","" },

        };
        public static void RecargarVentanaEmergenteAfiliados_unificados(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_unificados = new string[,]
            {
                { "1","0)ID_USUARIO","" },
                { "1","1)0IDP╦1IDP¬0PROYECTO_P°0IDP╦1IDP¬1PROYECTO_P","" },
                { "1","2)0IPUNTOS_D_R¬0PROYECTO_R°1PUNTOS_D_R¬1PROYECTO_R","" },
                { "1","3)PUNTOS_D_R_TOTALES","" },
                { "1","4)DATOS","" },
                { "1","5)NIVEL","" },
                { "1","6)ID_HORIZONTAL","" },
                { "1","7)TIPO_AFILIADO","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana niv_afiliados_comp
        static public string[,] GG_ventana_niv_afiliados_unificado =
        {
            { "1","0_NIVEL","" },
            { "1","1_ID_HORIZONTAL","" },
            { "1","2_VACIOS","" },

        };
        public static void RecargarVentanaEmergente_niv_afiliados_unificado(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_unificado = new string[,]
            {
                { "1","0_NIVEL","" },
                { "1","1_ID_HORIZONTAL","" },
                { "1","2_VACIOS","" },
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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


        //ventana SUCURSALES
        static public string[,] GG_ventana_SUCUR =
        {
            { "1","0_NOM_ID_SUCUR","" },
            { "1","1_NOMBRE_SUCUR","" },
            { "1","2_NOMBRE_ENCARGADO","" },
            { "1","3_DIRECCIÓN_SUCUR","" },
            { "1","4_CIUDAD_SUCUR","" },
            { "1","5_ESTADO_SUCUR","" },
            { "1","6_CÓDIGO_POSTAL","" },
            { "1","7_PAÍS","" },
            { "1","8_CORREO_ELECTRÓNICO","" },
            { "1","9_TELÉFONO_ENCARGADO","" },
            { "1","10_TELEFONO_SUCUR","" },
            { "1","11_TIPO_DE_SUCUR","" },
            { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" },
            { "1","13_CUENTA_BANCO","" },
            { "1","14_UBICACIÓN_(GPS)","" },
            { "1","15_NOTAS","" },
            { "1","16_RECORDATORIO","" },
            { "1","17_ACTIVO_O_NO_ACTIVO","" },
            { "1","18_HORA_ABRIR°HORA_CERRAR","" },


        };
        public static void RecargarVentanaEmergenteSUCUR(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_SUCUR = new string[,]
            {
                { "1","0_NOM_ID_SUCUR","" },
                { "1","1_NOMBRE_SUCUR","" },
                { "1","2_NOMBRE_ENCARGADO","" },
                { "1","3_DIRECCIÓN_SUCUR","" },
                { "1","4_CIUDAD_SUCUR","" },
                { "1","5_ESTADO_SUCUR","" },
                { "1","6_CÓDIGO_POSTAL","" },
                { "1","7_PAÍS","" },
                { "1","8_CORREO_ELECTRÓNICO","" },
                { "1","9_TELÉFONO_ENCARGADO","" },
                { "1","10_TELEFONO_SUCUR","" },
                { "1","11_TIPO_DE_SUCUR","" },
                { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" },
                { "1","13_CUENTA_BANCO","" },
                { "1","14_UBICACIÓN_(GPS)","" },
                { "1","15_NOTAS","" },
                { "1","16_RECORDATORIO","" },
                { "1","17_ACTIVO_O_NO_ACTIVO","" },
                { "1","18_HORA_ABRIR°HORA_CERRAR","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //REGISTROS-------------------------------------------------------------------------------------

        //registro dia
        static public string[,] GG_ventana_reg_dia =
        {

            { "1","0_HORA","" },
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
            { "1","3_CODIGO_PRECIOTOTAL_PRODUCTOS_CANTIDAD_PLATAFORMA_DATPLATAFORMA","" },
            { "1","4_COMENTARIO","" },
            { "1","5_TOTAL_VENTA","" },
            { "1","6_TOTAL_COSTO_COMP","" },
            { "1","7_TOTAL_IMPUESTOS","" },
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },
            { "1","10_PLATAFORMA","" },

        };
        public static void RecargarVentanaEmergenteRegDia(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {

            GG_ventana_reg_dia = new string[,]
            {
                { "1","0_HORA","" },
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
                { "1","3_CODIGO_PRECIOTOTAL_PRODUCTOS_CANTIDAD_PLATAFORMA_DATPLATAFORMA","" },
                { "1","4_COMENTARIO","" },
                { "1","5_TOTAL_VENTA","" },
                { "1","6_TOTAL_COSTO_COMP","" },
                { "1","7_TOTAL_IMPUESTOS","" },
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },
                { "1","10_PLATAFORMA","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro mes
        static public string[,] GG_ventana_reg_mes =
        {

            { "1","0_DIA","" },
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
            { "1","4_COMENTARIO","" },
            { "1","5_TOTAL_VENTA","" },
            { "1","6_TOTAL_COSTO_COMP","" },
            { "1","7_TOTAL_IMPUESTOS","" },
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },


        };
        public static void RecargarVentanaEmergenteRegMes(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {

            GG_ventana_reg_mes = new string[,]
            {
                { "1","0_DIA","" },
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
                { "1","4_COMENTARIO","" },
                { "1","5_TOTAL_VENTA","" },
                { "1","6_TOTAL_COSTO_COMP","" },
                { "1","7_TOTAL_IMPUESTOS","" },
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro año
        static public string[,] GG_ventana_reg_año =
        {

            { "1","0_MES","" },
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
            { "1","4_COMENTARIO","" },
            { "1","5_TOTAL_VENTA","" },
            { "1","6_TOTAL_COSTO_COMP","" },
            { "1","7_TOTAL_IMPUESTOS","" },
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },




        };
        public static void RecargarVentanaEmergenteRegAño(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_año = new string[,]
            {
                { "1","0_MES","" },
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
                { "1","4_COMENTARIO","" },
                { "1","5_TOTAL_VENTA","" },
                { "1","6_TOTAL_COSTO_COMP","" },
                { "1","7_TOTAL_IMPUESTOS","" },
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },



            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro total
        static public string[,] GG_ventana_reg_total =
        {

            { "1","0_AÑO","" },
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
            { "1","4_COMENTARIO","" },
            { "1","5_TOTAL_VENTA","" },
            { "1","6_TOTAL_COSTO_COMP","" },
            { "1","7_TOTAL_IMPUESTOS","" },
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },


        };
        public static void RecargarVentanaEmergenteRegTotal(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_total = new string[,]
            {
                { "1","0_AÑO","" },
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" },
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" },
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" },
                { "1","4_COMENTARIO","" },
                { "1","5_TOTAL_VENTA","" },
                { "1","6_TOTAL_COSTO_COMP","" },
                { "1","7_TOTAL_IMPUESTOS","" },
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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



        //registros productos

        
        //registro produc dia
        static public string[,] GG_ventana_reg_prod_dia =
        {

            { "1","0_HORA","" },
            { "1","1_OPERACION_VENTA_COMPRA_RETIRAR_PRODUCTO_INTODUCIR_PRODUCTO","" },
            { "1","2_COD_BAR_CANTIDADES_NOMBRE_PRODUCTO_PLATAFORMA_DATOSPLATAFORMA","" },
            

        };
        public static void RecargarVentanaEmergenteReg_prod_Dia(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_dia = new string[,]
            {
                { "1","0_HORA","" },
                { "1","1_OPERACION_VENTA_COMPRA_RETIRAR_PRODUCTO_INTODUCIR_PRODUCTO","" },
                { "1","2_COD_BAR_CANTIDADES_NOMBRE_PRODUCTO_PLATAFORMA_DATOSPLATAFORMA","" },
                
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro produc mes
        static public string[,] GG_ventana_reg_prod_mes =
        {


            { "1","0_NOMBRE_PRODUCTO","" },
            { "1","1_CANTIDAD","" },
            { "1","2_COD_BAR","" },
            { "1","3_PROVEDORES","" },
            { "1","4_HISTORIAL","" },
            { "1","5_RANKING","" },
            { "1","6_PROMEDIO","" },
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
            { "1","8_USO_MULTIPLE","" },              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna

        };
        public static void RecargarVentanaEmergenteReg_prod_Mes(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_mes = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","" },
                { "1","1_CANTIDAD","" },
                { "1","2_COD_BAR","" },
                { "1","3_PROVEDORES","" },
                { "1","4_HISTORIAL","" },
                { "1","5_RANKING","" },
                { "1","6_PROMEDIO","" },
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
                { "1","8_USO_MULTIPLE","" },              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro produc año
        static public string[,] GG_ventana_reg_prod_año =
        {

            { "1","0_NOMBRE_PRODUCTO","" },
            { "1","1_CANTIDAD","" },
            { "1","2_COD_BAR","" },
            { "1","3_PROVEDORES","" },
            { "1","4_HISTORIAL","" },
            { "1","5_RANKING","" },
            { "1","6_PROMEDIO","" },
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
            { "1","8_USO_MULTIPLE","" },              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna

        };
        public static void RecargarVentanaEmergenteReg_prod_Año(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_año = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","" },
                { "1","1_CANTIDAD","" },
                { "1","2_COD_BAR","" },
                { "1","3_PROVEDORES","" },
                { "1","4_HISTORIAL","" },
                { "1","5_RANKING","" },
                { "1","6_PROMEDIO","" },
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
                { "1","8_USO_MULTIPLE","" },              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna
            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //registro produc total
        static public string[,] GG_ventana_reg_prod_total =
        {
            { "1","0_NOMBRE_PRODUCTO","" },
            { "1","1_CANTIDAD","" },
            { "1","2_COD_BAR","" },
            { "1","3_PROVEDORES","" },
            { "1","4_HISTORIAL","" },
            { "1","5_RANKING","" },
            { "1","6_PROMEDIO","" },
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
            { "1","8_USO_MULTIPLE","" },              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna


        };
        public static void RecargarVentanaEmergenteReg_prod_total(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_total = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","" },
                { "1","1_CANTIDAD","" },
                { "1","2_COD_BAR","" },
                { "1","3_PROVEDORES","" },
                { "1","4_HISTORIAL","" },
                { "1","5_RANKING","" },
                { "1","6_PROMEDIO","" },
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","" },
                { "1","8_USO_MULTIPLE","" },              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" },  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" },        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" },        // Nueva columna

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //impuestos
        //ventana IMPUESTOS
        static public string[,] GG_ventana_IMPUESTOS =
        {
            { "1","0_IMPUESTO","" },
            { "1","1_PORCENTAGE","" },
            { "1","2_DESCRIPCION","" },
            { "1","3_INFO_EXTRA","" },
            { "1","3_IMPUESTO_1_DIRECTO_2_INDIRECTO_3_NOSE","" },

        };

        public static void RecargarVentanaEmergenteImpuestos(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_IMPUESTOS = new string[,]
            {
                { "1","0_IMPUESTO","" },
                { "1","1_PORCENTAGE","" },
                { "1","2_DESCRIPCION","" },
                { "1","3_INFO_EXTRA","" },
                { "1","3_IMPUESTO_1_DIRECTO_2_INDIRECTO_3_NOSE","" },


            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //ventana DEDUSIBLES
        static public string[,] GG_ventana_DEDUSIBLES =
        {
            { "1","0_FECHA_yyyyMMddHH","" },
            { "1","1_MONTO","" },
            { "1","2_DESCRIPCION","" },
            { "1","3_PROVEDOR_O_INSTITUCION_DE_LA_FACTURA_O_DONACION","" },
            { "1","4_DIRECCION_ARCHIVO_FACTURA","" },
            { "1","5_FOLIO","" },

        };

        public static void RecargarVentanaEmergenteDedusibles(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_DEDUSIBLES = new string[,]
            {
                { "1","fecha_yyyyMMddHHmm","" },
                { "1","0_IMPUESTO_DEDUSIRA","" },
                { "1","1_PORCENTAGE","" },
                { "1","2_DESCRIPCION","" },
                { "1","TIPO","" },
                { "1","DIRECCION_ARCHIVO_FACTURA","" },
            };



            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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

        //HERRAMIENTAS
        static public string[,] GG_ventana_TIPOS_DE_MEDIDA =
        {
            { "1","0_COD_BAR","" },

        };
        public static void RecargarVentanaEmergente_TIPOS_DE_MEDIDA(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_TIPOS_DE_MEDIDA = new string[,]
            {
                { "1","0_TIPO_DE_MEDIDA","" },

            };


            if (al_finalizar_que_borrar_para_proxima_ventana != null)
            {


                string[] datos_a_borrar = al_finalizar_que_borrar_para_proxima_ventana.ToString().Split(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));

                for (int i = 0; i < datos_a_borrar.Length; i++)
                {

                    if (datos_a_borrar[i] == "TODO")
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


        //--------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string columnas_concatenadas(string[,] arreglo_bidimencional, int id_columna, string caracter_separacion = null)
        {
            if (caracter_separacion == null)
            {
                caracter_separacion = var_fun_GG.GG_caracter_separacion[0];
            }
            string nombresConcatenados = "";

            for (int i = 0; i < arreglo_bidimencional.GetLength(0); i++)
            {
                string nombre = arreglo_bidimencional[i, id_columna];
                nombresConcatenados += nombre + Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]);
            }

            if (!string.IsNullOrEmpty(nombresConcatenados))
            {
                nombresConcatenados = nombresConcatenados.TrimEnd(Convert.ToChar(var_fun_GG.GG_caracter_separacion[0]));
            }

            return nombresConcatenados;
        }


        static public string[] GG_direccion_carpetas_base = { "" };



        static public string[,] GG_dir_nom_archivos =
        {
            /*0*/{ GG_direccion_carpetas_base[0] + "ARCHIVOS_INICIALES\\INICIO.TXT",columnas_concatenadas(GG_ventana_datos_conf,1,var_fun_GG.GG_caracter_separacion[0]),"2|id ultimo usuario"},
            /*1*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\INVENTARIO\\INVENTARIO.TXT", columnas_concatenadas(GG_ventana_emergente_productos,1,var_fun_GG.GG_caracter_separacion[0]),"1|PRODUCTO|200|ML|100|COD_BAR|-7|100|PROVEDOR¬0|PRODUCTO_PIEZA|10|INDIVIDUAL|CODIGO_BARRAS_PAQUETE|COD_BAR_INDIVIDUAL_ES_PAQ|1|IVA||20240606|20240605|sucursal¬0°¬2024070308|BEBIDA_ALCOLICA|||§2|PRODUCTO|200|ML|100|COD_BAR1|-4|100|PROVEDOR1¬0|PRODUCTO_PIEZA|10|INDIVIDUAL|CODIGO_BARRAS_PAQUETE|COD_BAR_INDIVIDUAL_ES_PAQ|1|IVA||20240606|20240605|sucursal¬0°¬2024070308|BEBIDA_ALCOLICA|||"},
            /*2*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\DAT\\PROVEDORES.TXT", columnas_concatenadas(GG_ventana_provedor,1,var_fun_GG.GG_caracter_separacion[0]),"1|NOSE|2_NOMBRE_ENCARGADO|3_DIRECCIÓN_EMPRESA|4_CIUDAD_EMPRESA|5_ESTADO_EMPRESA|6_CÓDIGO_POSTAL|7_PAÍS|8_CORREO_ELECTRÓNICO|9_TELÉFONO_ENCARGADO|10_TELEFONO_EMPRESA|11_TIPO_DE_PROVEEDOR|12_PRODUCTOS_SERVICIOS_SUMINISTRADOS|13_CUENTA_BANCO|14_UBICACIÓN_(GPS)|15_NOTAS|16_RECORDATORIO|17_ACTIVO_O_NO_ACTIVO|18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0|19_COMENTARIOS_PREVENTA_ENTREGA|20_SUCURSALES_QUE_LE_COMPRAN|0|22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1|23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1§2|NOSE2|2_NOMBRE_ENCARGADO2|3_DIRECCIÓN_EMPRESA|4_CIUDAD_EMPRESA|5_ESTADO_EMPRESA|6_CÓDIGO_POSTAL|7_PAÍS|8_CORREO_ELECTRÓNICO|9_TELÉFONO_ENCARGADO|10_TELEFONO_EMPRESA|11_TIPO_DE_PROVEEDOR|12_PRODUCTOS_SERVICIOS_SUMINISTRADOS|13_CUENTA_BANCO|14_UBICACIÓN_(GPS)|15_NOTAS|16_RECORDATORIO|17_ACTIVO_O_NO_ACTIVO|18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0|19_COMENTARIOS_PREVENTA_ENTREGA|20_SUCURSALES_QUE_LE_COMPRAN|0|22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1|23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1"},
            /*3*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\DAT\\APRENDICES_E.TXT", columnas_concatenadas(GG_ventana_APRENDICES_E,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*4*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\AFILIADOS_SIMPLE.TXT", columnas_concatenadas(GG_ventana_afiliados_simples,1,var_fun_GG.GG_caracter_separacion[0]),"0|0|TABLA_COMPLEJA|0|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|0|0||§1|0|TABLA_COMPLEJA|0|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|1|0||§2|1|TABLA_COMPLEJA|1|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|2|0||§3|2|TABLA_COMPLEJA|2|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|3|0||§4|3|TABLA_COMPLEJA|3|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|4|0||"},
            /*5*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\AFILIADOS_COMPLEJO.TXT", columnas_concatenadas(GG_ventana_afiliados_complejos,1,var_fun_GG.GG_caracter_separacion[0]),"0|0|TABLA_COMPLEJA|0|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|0|0||§1|0|TABLA_COMPLEJA|0|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|1|0||§2|0|TABLA_COMPLEJA|1|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|2|0||§3|0|TABLA_COMPLEJA|2|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|3|0||§4|0|TABLA_COMPLEJA|3|TABLA_SIMPLE|0|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|4|0||"},
            /*6*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\NIVELES_E_ID_HORISONTAL_AFILIADOS_SIMPLE.TXT", columnas_concatenadas(GG_ventana_niv_afiliados_simples,1,var_fun_GG.GG_caracter_separacion[0]),"1|1|§2|1|§3|1|§4|1|"},
            /*7*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\NIVELES_E_ID_HORISONTAL_AFILIADOS_COMPLEJO.TXT", columnas_concatenadas(GG_ventana_niv_afiliados_comp,1,var_fun_GG.GG_caracter_separacion[0]),"1|1|§2|1|§3|1|§4|1|"},
            /*8*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\AFILIADOS_UNIFICADO.TXT", columnas_concatenadas(GG_ventana_afiliados_unificados,1,var_fun_GG.GG_caracter_separacion[0]),"0|0╦0¬0AFILIADOS_UNIFICADO°0╦0¬AFILIADOS_UNIFICADO1|0¬AFILIADOS_UNIFICADO°0¬AFILIADOS_UNIFICADO1|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|0|0||§1|0¬AFILIADOS_UNIFICADO_P|0¬AFILIADOS_UNIFICADO|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|1|0||§2|1¬AFILIADOS_UNIFICADO|0¬AFILIADOS_UNIFICADO|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|2|0||§3|2¬AFILIADOS_UNIFICADO|0¬AFILIADOS_UNIFICADO|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|3|0||§4|3¬AFILIADOS_UNIFICADO|0¬AFILIADOS_UNIFICADO|0|0_NOM_PRU°1_AP_PAT_PRU°2_APE_MAT_PRU°0╦BANCO°4_CURP°5_CLAV_ELECTOR°6_OTRA_ID_IDENTIFICACION°7_0000000000°8_DIRECCION°9_COLONIA°10_MUNICIOPIO°11_ESTADO°12_CORREO@CORREO.COM|4|0||"},
            /*9*/{ GG_direccion_carpetas_base[0] + "CONFIG\\AFILIADOS\\NIVELES_E_ID_HORISONTAL_AFILIADOS_UNIFICADO.TXT", columnas_concatenadas(GG_ventana_niv_afiliados_unificado,1,var_fun_GG.GG_caracter_separacion[0]),"1|1|§2|1|§3|1|§4|1|"},
            /*10*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\DAT\\SUCUR.TXT", columnas_concatenadas(GG_ventana_SUCUR,1,var_fun_GG.GG_caracter_separacion[0]),""},
            //registros
            /*11*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_dia,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*12*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("yyyyMM") + "_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_mes,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*13*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_año,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*14*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\ACUMULADO_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_total,1,var_fun_GG.GG_caracter_separacion[0]),""},
            //registro productos
            /*15*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_PRODUC_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_prod_dia,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*16*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("yyyyMM") + "_PRODUC_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_prod_mes,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*17*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\FECHAS\\" + DateTime.Now.ToString("yyyy") + "_PRODUC_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_prod_año,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*18*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\REGISTROS\\ACUMULADO_PRODUC_REGISTRO.TXT", columnas_concatenadas(GG_ventana_reg_prod_total,1,var_fun_GG.GG_caracter_separacion[0]),""},
            //impuestos
            /*19*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\IMPUESTOS\\IMPUESTOS.TXT", columnas_concatenadas(GG_ventana_IMPUESTOS,1,var_fun_GG.GG_caracter_separacion[0]),"NOSE|0|SIN DESCRIPCION|INFO_EXTRA_NOSE|3§IVA|16|SIN DESCRIPCION|INFO_EXTRA_NOSE|2"},
            /*20*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\IMPUESTOS\\DEDUSIBLES.TXT", columnas_concatenadas(GG_ventana_DEDUSIBLES,1,var_fun_GG.GG_caracter_separacion[0]),""},
            //herramientas
            /*21*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\INVENTARIO\\COSAS_NO_ESTABAN.TXT", columnas_concatenadas(GG_ventana_COSAS_NO_ESTABAN_INVENTARIO,1,var_fun_GG.GG_caracter_separacion[0]),""},
            /*22*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\INVENTARIO\\TIPOS_DE_MEDIDA.TXT", columnas_concatenadas(GG_ventana_TIPOS_DE_MEDIDA,1,var_fun_GG.GG_caracter_separacion[0]),"NOSE§ML§GR§KG"},


    };

        static public string[,] GG_dir_nom_archivos_SIN_ARREGLOS_GG =
        {
            //archivos transferencia informacion
            /*0*/{ Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\xerox\\config\\inf\\bklkfjc\\banderas.TXT", "SIN_INFO", "1§2§3§7§8§9"},//no_hacer_caso
            /*1*/{ Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\xerox\\config\\inf\\bklkfjc\\1.TXT", "SIN_INFO", ""},//preguntas
            /*2*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\2.TXT", "SIN_INFO", ""},//respuestas
            /*3*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\3.TXT", "SIN_INFO", ""},//pedidos
            /*4*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\4.TXT", "SIN_INFO", ""},//agregar preguntas para_watsap desde el watsap o lectura del chatbot depende la bandera
            /*5*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\5.TXT", "SIN_INFO", ""},//agregar respuestas  para_chatbot desde el watsap o lectura del chatbot depende la bandera
            /*6*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\6.TXT", "SIN_INFO", ""},//agregar pedidos para_watsap desde el watsap o lectura del chatbot depende la bandera
            /*7*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\7.TXT", "SIN_INFO", ""},//agregar pregunta  para_chatbot desde el watsap o lectura del chatbot depende la bandera
            /*8*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\8.TXT", "SIN_INFO", ""},//agregar respuesta para_watsap desde el watsap o lectura del chatbot depende la bandera
            /*9*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\9.TXT", "SIN_INFO", ""},//agregar pedidos  para_chatbot desde el watsap o lectura del chatbot depende la bandera
            /*10*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\10.TXT", "SIN_INFO", ""},//agregar pregunta  para_chatbot desde el watsap o lectura del chatbot depende la bandera
            /*11*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\11.TXT", "SIN_INFO", ""},//agregar respuesta para_watsap desde el watsap o lectura del chatbot depende la bandera
            /*12*/{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\xerox\\config\\inf\\bklkfjc\\12.TXT", "SIN_INFO", ""},//agregar pedidos  para_chatbot desde el watsap o lectura del chatbot depende la bandera

        };

        //direccion_para_hacer_inventarios
        public string[,] GG_direccion_hacer_inventarios =
        {
            { "CONFIG\\INF\\INVENTARIO\\HACER_INVENTARIO\\" + DateTime.Now.ToString("yyyyMMdd") + "_VENTAS_DURANTE_INV.TXT", "CODBAR|nombre_producto|CANTIDA|ULTIMO_MOVIMIENTO" },
            { "CONFIG\\INF\\INVENTARIO\\HACER_INVENTARIO\\" + DateTime.Now.ToString("yyyyMMdd") + "_SOBRANTES.TXT", "CODBAR|nombre_producto|CANTIDA|ULTIMO_MOVIMIENTO" },
            { "CONFIG\\INF\\INVENTARIO\\HACER_INVENTARIO\\" + DateTime.Now.ToString("yyyyMMdd") + "_FALTANTES.TXT", "CODBAR|nombre_producto|CANTIDA|ULTIMO_MOVIMIENTO" },
            { "CONFIG\\INF\\INVENTARIO\\HACER_INVENTARIO\\" + DateTime.Now.ToString("yyyyMMdd") + "_NO_ESTAN_EN_EL_FISICO.TXT", "CODBAR|nombre_producto|CANTIDA|ULTIMO_MOVIMIENTO" },
            { "CONFIG\\INF\\INVENTARIO\\HACER_INVENTARIO\\" + DateTime.Now.ToString("yyyyMMdd") + "_NO_ESTAN_EN_EL_FISICO_PERO_PUEDE_QUE_FALTEN.TXT", "CODBAR|nombre_producto|CANTIDA|ULTIMO_MOVIMIENTO" },

        };
    }
}