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
            /*0*/ { "2", "_00_ID", "" ,"-1"},
                /*1*/ { "1", "_01_PRODUCTO", "", "NOSE"},
                /*2*/ { "1", "_02_CONTENIDO", "0|SOLO_NUMEROS", "-0" },
                /*3*/ { "4", "_03_TIPO_MEDIDA", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[1] + '|' + GG_variables_string[2], "NOSE" },
                /*4*/ { "1", "_04_PRECIO_VENTA", "0|SOLO_NUMEROS", "NOSE" },
                /*5*/ { "2", "_05_COD_BARRAS", GG_variables_string[0], "NOSE" },
                /*6*/ { "1", "_06_CANTIDAD", "1|SOLO_NUMEROS" , "-0"},
                /*7*/ { "1", "_07_COSTO_COMP", "0|SOLO_NUMEROS" , "-0"},
                /*8*/ { "4", "_08_PROVEDOR", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[5] + '|' + GG_variables_string[6] , "NOSE"},
                /*9*/ { "4", "_09_GRUPO", "PRODUCTO_PIEZA||PRODUCTO_PIEZA|PRODUCTO_PIEZA°PRODUCTO_CANTIDAD°PRODUCTO_ELABORADO°VENTA_INGREDIENTE|OCULTAR_CONTROL¬29¬PRODUCTO_ELABORADO°OCULTAR_CONTROL¬45¬PRODUCTO_ELABORADO", "PRODUCTO_PIEZA"},
                /*10*/ { "1", "_10_CANT_X_PAQUET", "1|SOLO_NUMEROS" , "-0"},
                /*11*/ { "4", "_11_ES_PAQUETE", "INDIVIDUAL||INDIVIDUAL|INDIVIDUAL°PAQUETE_MAYOREO°PAQUETE_PROMOCION|OCULTAR_CONTROL¬27¬PAQUETE_MAYOREO╦PAQUETE_PROMOCION", "INDIVIDUAL"},
                /*12*/ { "1", "_12_CODBAR_PAQUETE", "" , "NOSE"},
                /*13*/ { "1", "_13_COD_BAR_INDIVIDUAL_ES_PAQ", "" , "NOSE"},
                /*14*/ { "1", "_14_LIGAR_PROD_SAB", "" , "NOSE"},
                /*15*/ { "1", "_15_IMPUESTOS", "|TODAS_MAYUSCULAS|||REYENO_TEXTBOX_VENTANA_IMPU" , "NOSE"},
                /*16*/ { "1", "_16_INGREDIENTES", "||||NO_VISIBLE°PRODUCTO_ELABORADO" , "NOSE"},
                /*17*/ { "1", "_17_CADUCIDAD", "0|SOLO_NUMEROS" , "-0"},
                /*18*/ { "1", "_18_ULTIMO_MOV", "0|SOLO_NUMEROS" , "-0"},
                /*19*/ { "1", "_19_SUCUR_VENT", "" , "NOSE"},
                /*20*/ { "1", "_20_CLAF_PROD", "" , "-0"},
                /*21*/ { "1", "_21_DIR_IMG_INTER", "" , "NOSE"},
                /*22*/ { "1", "_22_DIR_IMG_COMP", "" , "NOSE"},
                /*23*/ { "1", "_23_INFO_EXTRA", "" , "NOSE"},
                /*24*/ { "1", "_24_PROCESO_CREAR", "||||NO_VISIBLE" , "NOSE"},
                /*25*/ { "1", "_25_DIR_VID_PROC_CREAR", "" , "NOSE"},
                /*26*/ { "2", "_26_NO_PONER_NADA", "" , ""},
        };
        public static void RecargarVentanaEmergenteProductos(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_emergente_productos = new string[,]
            {
                /*0*/ { "2", "_00_ID", "" ,"-1"},
                /*1*/ { "1", "_01_PRODUCTO", "", "NOSE"},
                /*2*/ { "1", "_02_CONTENIDO", "0|SOLO_NUMEROS", "-0" },
                /*3*/ { "4", "_03_TIPO_MEDIDA", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[1] + '|' + GG_variables_string[2], "NOSE" },
                /*4*/ { "1", "_04_PRECIO_VENTA", "0|SOLO_NUMEROS", "NOSE" },
                /*5*/ { "2", "_05_COD_BARRAS", GG_variables_string[0], "NOSE" },
                /*6*/ { "1", "_06_CANTIDAD", "1|SOLO_NUMEROS" , "-0"},
                /*7*/ { "1", "_07_COSTO_COMP", "0|SOLO_NUMEROS" , "-0"},
                /*8*/ { "4", "_08_PROVEDOR", "NOSE|TODAS_MAYUSCULAS|" + GG_variables_string[5] + '|' + GG_variables_string[6] , "NOSE"},
                /*9*/ { "4", "_09_GRUPO", "PRODUCTO_PIEZA||PRODUCTO_PIEZA|PRODUCTO_PIEZA°PRODUCTO_CANTIDAD°PRODUCTO_ELABORADO°VENTA_INGREDIENTE|OCULTAR_CONTROL¬29¬PRODUCTO_ELABORADO°OCULTAR_CONTROL¬45¬PRODUCTO_ELABORADO", "PRODUCTO_PIEZA"},
                /*10*/ { "1", "_10_CANT_X_PAQUET", "1|SOLO_NUMEROS" , "-0"},
                /*11*/ { "4", "_11_ES_PAQUETE", "INDIVIDUAL||INDIVIDUAL|INDIVIDUAL°PAQUETE_MAYOREO°PAQUETE_PROMOCION|OCULTAR_CONTROL¬27¬PAQUETE_MAYOREO╦PAQUETE_PROMOCION", "INDIVIDUAL"},
                /*12*/ { "1", "_12_CODBAR_PAQUETE", "" , "NOSE"},
                /*13*/ { "1", "_13_COD_BAR_INDIVIDUAL_ES_PAQ", "" , "NOSE"},
                /*14*/ { "1", "_14_LIGAR_PROD_SAB", "" , "NOSE"},
                /*15*/ { "1", "_15_IMPUESTOS", "|TODAS_MAYUSCULAS|||REYENO_TEXTBOX_VENTANA_IMPU" , "NOSE"},
                /*16*/ { "1", "_16_INGREDIENTES", "||||NO_VISIBLE°PRODUCTO_ELABORADO" , "NOSE"},
                /*17*/ { "1", "_17_CADUCIDAD", "0|SOLO_NUMEROS" , "-0"},
                /*18*/ { "1", "_18_ULTIMO_MOV", "0|SOLO_NUMEROS" , "-0"},
                /*19*/ { "1", "_19_SUCUR_VENT", "" , "NOSE"},
                /*20*/ { "1", "_20_CLAF_PROD", "" , "-0"},
                /*21*/ { "1", "_21_DIR_IMG_INTER", "" , "NOSE"},
                /*22*/ { "1", "_22_DIR_IMG_COMP", "" , "NOSE"},
                /*23*/ { "1", "_23_INFO_EXTRA", "" , "NOSE"},
                /*24*/ { "1", "_24_PROCESO_CREAR", "||||NO_VISIBLE" , "NOSE"},
                /*25*/ { "1", "_25_DIR_VID_PROC_CREAR", "" , "NOSE"},
                /*26*/ { "2", "_26_NO_PONER_NADA", "" , ""},
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
            { "1","0_COD_BAR","", "NOSE"},
            { "1","1_NOMBRE","" , "NOSE"},

        };
        public static void RecargarVentanaEmergente_Cosas_que_no_estaban(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_COSAS_NO_ESTABAN_INVENTARIO = new string[,]
            {
                { "1","0_COD_BAR","", "NOSE"},
                { "1","1_NOMBRE","" , "NOSE"},
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
            { "1","0_ID_EMPRESA","", "-0"},
            { "1","1_NOMBRE_EMPRESA","", "NOSE"},
            { "1","2_NOMBRE_ENCARGADO","", "NOSE" },
            { "1","3_DIRECCIÓN_EMPRESA","", "NOSE" },
            { "1","4_CIUDAD_EMPRESA","", "NOSE" },
            { "1","5_ESTADO_EMPRESA","", "NOSE" },
            { "1","6_CÓDIGO_POSTAL","", "NOSE" },
            { "1","7_PAÍS","" , "NOSE"},
            { "1","8_CORREO_ELECTRÓNICO","" , "NOSE"},
            { "1","9_TELÉFONO_ENCARGADO","" , "NOSE"},
            { "1","10_TELEFONO_EMPRESA","" , "NOSE"},
            { "1","11_TIPO_DE_PROVEEDOR","" , "NOSE"},
            { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" , "NOSE"},
            { "1","13_CUENTA_BANCO","" , "NOSE"},
            { "1","14_UBICACIÓN_(GPS)","" , "-0"},
            { "1","15_NOTAS","" , "NOSE"},
            { "1","16_RECORDATORIO","" , ""},
            { "1","17_ACTIVO_O_NO_ACTIVO","", "ACTIVO"},
            { "1","18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0","" ,"CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0" },
            { "1","19_COMENTARIOS_PREVENTA_ENTREGA","" , "NOSE"},
            { "1","20_SUCURSALES_QUE_LE_COMPRAN","" , "NOSE"},
            { "1","21_DINERO_A_COMPRARLE","0|SOLO_NUMEROS" , "0"},
            { "1","22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1","","NOSE°NOSE" },
            { "1","23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1","","NOSE°NOSE" },


        };
        public static void RecargarVentanaEmergenteProvedor(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_provedor = new string[,]
            {
                { "1","0_ID_EMPRESA","", "-0"},
                { "1","1_NOMBRE_EMPRESA","", "NOSE"},
                { "1","2_NOMBRE_ENCARGADO","", "NOSE" },
                { "1","3_DIRECCIÓN_EMPRESA","", "NOSE" },
                { "1","4_CIUDAD_EMPRESA","", "NOSE" },
                { "1","5_ESTADO_EMPRESA","", "NOSE" },
                { "1","6_CÓDIGO_POSTAL","", "NOSE" },
                { "1","7_PAÍS","" , "NOSE"},
                { "1","8_CORREO_ELECTRÓNICO","" , "NOSE"},
                { "1","9_TELÉFONO_ENCARGADO","" , "NOSE"},
                { "1","10_TELEFONO_EMPRESA","" , "NOSE"},
                { "1","11_TIPO_DE_PROVEEDOR","" , "NOSE"},
                { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" , "NOSE"},
                { "1","13_CUENTA_BANCO","" , "NOSE"},
                { "1","14_UBICACIÓN_(GPS)","" , "-0"},
                { "1","15_NOTAS","" , "NOSE"},
                { "1","16_RECORDATORIO","" , ""},
                { "1","17_ACTIVO_O_NO_ACTIVO","", "ACTIVO"},
                { "1","18_CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0","" ,"CALIFICACION_PREVENTA¬0°CALIFICACION_ENTREGA¬0" },
                { "1","19_COMENTARIOS_PREVENTA_ENTREGA","" , "NOSE"},
                { "1","20_SUCURSALES_QUE_LE_COMPRAN","" , "NOSE"},
                { "1","21_DINERO_A_COMPRARLE","0|SOLO_NUMEROS" , "0"},
                { "1","22_DIAS_DE_PREVENTA_0°DIAS_DE_PREVENTA_1","","NOSE°NOSE" },
                { "1","23_DIAS_DE_ENTREGA_0°DIAS_DE_ENTREGA_1","","NOSE°NOSE" },
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
            { "2","0_ID","","-0" },
            { "1","1_NOMBRE","" , "NOSE"},
            { "1","2_APELLIDO_PATERNO","" , "NOSE"},
            { "1","3_APELLIDO_MATERNO","" , "NOSE"},
            { "1","4_FECHA_DE_NACIMIENTO","" , "NOSE"},
            { "1","5_GÉNERO","" , "NOSE"},
            { "1","6_DIRECCIÓN","" , "NOSE"},
            { "1","7_CIUDAD","" , "NOSE"},
            { "1","8_ESTADO_PROVINCIA","" , "NOSE"},
            { "1","9_CÓDIGO_POSTAL","" , "NOSE"},
            { "1","10_PAÍS","" , "NOSE"},
            { "1","11_CORREO_ELECTRÓNICO","" , "NOSE"},
            { "1","12_TELÉFONO","" , "NOSE"},
            { "1","13_FECHA_DE_INGRESO","" , "NOSE"},
            { "1","14_SUELDO","" , "NOSE"},
            { "1","15_CARGO","" , "NOSE"},
            { "1","16_ESTADO_DE_CURS_APRENDIS_E","" , "NOSE"},
            { "1","17_SUPERVISOR","" , "NOSE"},
            { "1","18_NOTAS","" , ""},
            { "1","19_AFILIADO","" , "NOSE"},
            { "1","20_FECHA_DE_TERMINACIÓN","0|SOLO_NUMEROS" , "0"},
            { "1","21_MOTIVO_DE_TERMINACIÓN°DIAS_DE_PREVENTA_1","" , "NOSE"},
            { "1","22_HORAS_TRABAJADAS","" , "NOSE"},
            { "1","23_EVALUACIONES_DE_DESEMPEÑO","" , "NOSE"},
            { "1","24_HABILIDADES_Y_CERTIFICACIONES","" , "NOSE"},
            { "1","25_IDIOMAS","" , "NOSE"},
            { "1","26_FECHA_DE_ÚLTIMA_PROMOCIÓN","" , "NOSE"},
            { "1","27_ID_DEL_DEPARTAMENTO_DE_SUPERVISIÓN","" , "NOSE"},
            { "1","28_HISTORIAL_DE_CAPACITACIÓN","" , "NOSE"},
            { "1","29_ÚLTIMO_AUMENTO_DE_SALARIO","" , "NOSE"},
            { "1","30_TIPO_EMPLEADO","" , "NOSE"},
            { "1","31_RANGO_CALIF","" , "-0"},

        };
        public static void RecargarVentanaEmergenteAPRENDICES_E(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_APRENDICES_E = new string[,]
            {
                { "2","0_ID","","-0" },
                { "1","1_NOMBRE","" , "NOSE"},
                { "1","2_APELLIDO_PATERNO","" , "NOSE"},
                { "1","3_APELLIDO_MATERNO","" , "NOSE"},
                { "1","4_FECHA_DE_NACIMIENTO","" , "NOSE"},
                { "1","5_GÉNERO","" , "NOSE"},
                { "1","6_DIRECCIÓN","" , "NOSE"},
                { "1","7_CIUDAD","" , "NOSE"},
                { "1","8_ESTADO_PROVINCIA","" , "NOSE"},
                { "1","9_CÓDIGO_POSTAL","" , "NOSE"},
                { "1","10_PAÍS","" , "NOSE"},
                { "1","11_CORREO_ELECTRÓNICO","" , "NOSE"},
                { "1","12_TELÉFONO","" , "NOSE"},
                { "1","13_FECHA_DE_INGRESO","" , "NOSE"},
                { "1","14_SUELDO","" , "NOSE"},
                { "1","15_CARGO","" , "NOSE"},
                { "1","16_ESTADO_DE_CURS_APRENDIS_E","" , "NOSE"},
                { "1","17_SUPERVISOR","" , "NOSE"},
                { "1","18_NOTAS","" , ""},
                { "1","19_AFILIADO","" , "NOSE"},
                { "1","20_FECHA_DE_TERMINACIÓN","0|SOLO_NUMEROS" , "0"},
                { "1","21_MOTIVO_DE_TERMINACIÓN°DIAS_DE_PREVENTA_1","" , "NOSE"},
                { "1","22_HORAS_TRABAJADAS","" , "NOSE"},
                { "1","23_EVALUACIONES_DE_DESEMPEÑO","" , "NOSE"},
                { "1","24_HABILIDADES_Y_CERTIFICACIONES","" , "NOSE"},
                { "1","25_IDIOMAS","" , "NOSE"},
                { "1","26_FECHA_DE_ÚLTIMA_PROMOCIÓN","" , "NOSE"},
                { "1","27_ID_DEL_DEPARTAMENTO_DE_SUPERVISIÓN","" , "NOSE"},
                { "1","28_HISTORIAL_DE_CAPACITACIÓN","" , "NOSE"},
                { "1","29_ÚLTIMO_AUMENTO_DE_SALARIO","" , "NOSE"},
                { "1","30_TIPO_EMPLEADO","" , "NOSE"},
                { "1","31_RANGO_CALIF","" , "-0"},

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
            { "2","0_ID_USUARIO","","-0" },
            { "1","1_ID_PAT_COMP","","-0" },
            { "1","2_TABLA_PAT_COMP","","NOSE" },
            { "1","3_ID_ENC_SIMP","", "-0"},
            { "1","4_TABLA_ENC_SIMP","","NOSE" },
            { "1","5_PUNTOS_D","" ,"0"},
            { "1","6_PUNTOS_D_A_DAR","" ,"0"},
            { "1","7_DATOS","","" },
            { "1","8_NIVELES","","0" },
            { "1","9_ID_HORIZONTAL","","0" },
            { "1","10_TIPO_AFILIADO","","NOSE" },

        };
        public static void RecargarVentanaEmergenteAfiliados_simples(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_simples = new string[,]
            {
                { "2","0_ID_USUARIO","","-0" },
                { "1","1_ID_PAT_COMP","","-0" },
                { "1","2_TABLA_PAT_COMP","","NOSE" },
                { "1","3_ID_ENC_SIMP","", "-0"},
                { "1","4_TABLA_ENC_SIMP","","NOSE" },
                { "1","5_PUNTOS_D","" ,"0"},
                { "1","6_PUNTOS_D_A_DAR","" ,"0"},
                { "1","7_DATOS","","" },
                { "1","8_NIVELES","","0" },
                { "1","9_ID_HORIZONTAL","","0" },
                { "1","10_TIPO_AFILIADO","","NOSE" },
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
            { "2","0_ID_USUARIO","","0" },
            { "1","1_ID_PAT_COMP","","0" },
            { "1","2_TABLA_PAT_COMP","","NOSE" },
            { "1","3_ID_ENC_SIMP","","0" },
            { "1","4_TABLA_ENC_SIMP","","NOSE" },
            { "1","5_PUNTOS_D","","0" },
            { "1","6_PUNTOS_D_A_DAR","","0" },
            { "1","7_DATOS","","" },
            { "1","8_NIVELES","","0" },
            { "1","9_ID_HORIZONTAL","","0" },
            { "1","10_TIPO_AFILIADO","","0" },

        };
        public static void RecargarVentanaEmergenteAfiliados(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_complejos = new string[,]
            {
                { "2","0_ID_USUARIO","","0" },
                { "1","1_ID_PAT_COMP","","0" },
                { "1","2_TABLA_PAT_COMP","","NOSE" },
                { "1","3_ID_ENC_SIMP","","0" },
                { "1","4_TABLA_ENC_SIMP","","NOSE" },
                { "1","5_PUNTOS_D","","0" },
                { "1","6_PUNTOS_D_A_DAR","","0" },
                { "1","7_DATOS","","" },
                { "1","8_NIVELES","","0" },
                { "1","9_ID_HORIZONTAL","","0" },
                { "1","10_TIPO_AFILIADO","","0" },
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
            { "1","0_NIVEL","","0" },
            { "1","1_ID_HORIZONTAL","","0" },
            { "1","2_VACIOS","","" },
        };
        public static void RecargarVentanaEmergente_niv_afiliados_simples(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_simples = new string[,]
            {
                { "1","0_NIVEL","","0" },
                { "1","1_ID_HORIZONTAL","","0" },
                { "1","2_VACIOS","","" },
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
            { "1","0_NIVEL","","0" },
            { "1","1_ID_HORIZONTAL","","0" },
            { "1","2_VACIOS","","" },

        };
        public static void RecargarVentanaEmergente_niv_afiliados_comp(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_comp = new string[,]
            {
                { "1","0_NIVEL","","0" },
                { "1","1_ID_HORIZONTAL","","0" },
                { "1","2_VACIOS","","" },
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
            { "1","0)ID_USUARIO","","0" },
            { "1","1)0IDP╦1IDP¬0PROYECTO_P°0IDP╦1IDP¬1PROYECTO_P","","0╦0¬0°0╦1¬1" },
            { "1","2)0IPUNTOS_D_R¬0PROYECTO_R°1PUNTOS_D_R¬1PROYECTO_R","","0¬0°0¬0" },
            { "1","3)PUNTOS_D_R_TOTALES","","0" },
            { "1","4)DATOS","" , "NOSE"},
            { "1","5)NIVEL","" ,"0"},
            { "1","6)ID_HORIZONTAL","" , "0"},
            { "1","7)TIPO_AFILIADO","" ,"NOSE"},

        };
        public static void RecargarVentanaEmergenteAfiliados_unificados(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_afiliados_unificados = new string[,]
            {
                { "1","0)ID_USUARIO","","0" },
                { "1","1)0IDP╦1IDP¬0PROYECTO_P°0IDP╦1IDP¬1PROYECTO_P","","0╦0¬0°0╦1¬1" },
                { "1","2)0IPUNTOS_D_R¬0PROYECTO_R°1PUNTOS_D_R¬1PROYECTO_R","","0¬0°0¬0" },
                { "1","3)PUNTOS_D_R_TOTALES","","0" },
                { "1","4)DATOS","" , "NOSE"},
                { "1","5)NIVEL","" ,"0"},
                { "1","6)ID_HORIZONTAL","" , "0"},
                { "1","7)TIPO_AFILIADO","" ,"NOSE"},

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
            { "1","0_NIVEL","","0" },
            { "1","1_ID_HORIZONTAL","","0" },
            { "1","2_VACIOS","" ,""},

        };
        public static void RecargarVentanaEmergente_niv_afiliados_unificado(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_niv_afiliados_unificado = new string[,]
            {
                { "1","0_NIVEL","","0" },
                { "1","1_ID_HORIZONTAL","","0" },
                { "1","2_VACIOS","" ,""},
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
            { "1","0_NOM_ID_SUCUR","","-0" },
            { "1","1_NOMBRE_SUCUR","" , "NOSE"},
            { "1","2_NOMBRE_ENCARGADO","" , "NOSE"},
            { "1","3_DIRECCIÓN_SUCUR","" , "NOSE"},
            { "1","4_CIUDAD_SUCUR","" , "NOSE"},
            { "1","5_ESTADO_SUCUR","" , "NOSE"},
            { "1","6_CÓDIGO_POSTAL","" , "NOSE"},
            { "1","7_PAÍS","" , "NOSE"},
            { "1","8_CORREO_ELECTRÓNICO","" , "NOSE"},
            { "1","9_TELÉFONO_ENCARGADO","" , "NOSE"},
            { "1","10_TELEFONO_SUCUR","" , "NOSE"},
            { "1","11_TIPO_DE_SUCUR","" , "NOSE"},
            { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" , "NOSE"},
            { "1","13_CUENTA_BANCO","" , "NOSE"},
            { "1","14_UBICACIÓN_(GPS)","" , "-0"},
            { "1","15_NOTAS","" , ""},
            { "1","16_RECORDATORIO","" , "NOSE"},
            { "1","17_ACTIVO_O_NO_ACTIVO","" , "NOSE"},
            { "1","18_HORA_ABRIR°HORA_CERRAR","" , "NOSE"},


        };
        public static void RecargarVentanaEmergenteSUCUR(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_SUCUR = new string[,]
            {
                { "1","0_NOM_ID_SUCUR","","-0" },
                { "1","1_NOMBRE_SUCUR","" , "NOSE"},
                { "1","2_NOMBRE_ENCARGADO","" , "NOSE"},
                { "1","3_DIRECCIÓN_SUCUR","" , "NOSE"},
                { "1","4_CIUDAD_SUCUR","" , "NOSE"},
                { "1","5_ESTADO_SUCUR","" , "NOSE"},
                { "1","6_CÓDIGO_POSTAL","" , "NOSE"},
                { "1","7_PAÍS","" , "NOSE"},
                { "1","8_CORREO_ELECTRÓNICO","" , "NOSE"},
                { "1","9_TELÉFONO_ENCARGADO","" , "NOSE"},
                { "1","10_TELEFONO_SUCUR","" , "NOSE"},
                { "1","11_TIPO_DE_SUCUR","" , "NOSE"},
                { "1","12_PRODUCTOS_SERVICIOS_SUMINISTRADOS","" , "NOSE"},
                { "1","13_CUENTA_BANCO","" , "NOSE"},
                { "1","14_UBICACIÓN_(GPS)","" , "-0"},
                { "1","15_NOTAS","" , ""},
                { "1","16_RECORDATORIO","" , "NOSE"},
                { "1","17_ACTIVO_O_NO_ACTIVO","" , "NOSE"},
                { "1","18_HORA_ABRIR°HORA_CERRAR","" , "NOSE"},

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

            { "1","0_HORA","" ,"0"},
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","","NOSE" },
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
            { "1","3_CODIGO_PRECIOTOTAL_PRODUCTOS_CANTIDAD_PLATAFORMA_DATPLATAFORMA","" ,"NOSE"},
            { "1","4_COMENTARIO","" ,""},
            { "1","5_TOTAL_VENTA","" ,"0"},
            { "1","6_TOTAL_COSTO_COMP","","0" },
            { "1","7_TOTAL_IMPUESTOS","" ,"0"},
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" ,"0"},
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" ,"0"},
            { "1","10_PLATAFORMA","" ,"NOSE"},

        };
        public static void RecargarVentanaEmergenteRegDia(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {

            GG_ventana_reg_dia = new string[,]
            {
                { "1","0_HORA","" ,"0"},
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","","NOSE" },
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
                { "1","3_CODIGO_PRECIOTOTAL_PRODUCTOS_CANTIDAD_PLATAFORMA_DATPLATAFORMA","" ,"NOSE"},
                { "1","4_COMENTARIO","" ,""},
                { "1","5_TOTAL_VENTA","" ,"0"},
                { "1","6_TOTAL_COSTO_COMP","","0" },
                { "1","7_TOTAL_IMPUESTOS","" ,"0"},
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" ,"0"},
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" ,"0"},
                { "1","10_PLATAFORMA","" ,"NOSE"},

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

            { "1","0_DIA","" ,"0"},
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" ,"NOSE"},
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","","0" },
            { "1","4_COMENTARIO","" ,""},
            { "1","5_TOTAL_VENTA","" ,"0"},
            { "1","6_TOTAL_COSTO_COMP","","0" },
            { "1","7_TOTAL_IMPUESTOS","" ,"0"},
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","","0" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","","0" },


        };
        public static void RecargarVentanaEmergenteRegMes(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {

            GG_ventana_reg_mes = new string[,]
            {
                { "1","0_DIA","" ,"0"},
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" ,"NOSE"},
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","","0" },
                { "1","4_COMENTARIO","" ,""},
                { "1","5_TOTAL_VENTA","" ,"0"},
                { "1","6_TOTAL_COSTO_COMP","","0" },
                { "1","7_TOTAL_IMPUESTOS","" ,"0"},
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","","0" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","","0" },

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

            { "1","0_MES","" ,"0"},
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" ,"NOSE"},
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" ,"NOSE"},
            { "1","4_COMENTARIO","","" },
            { "1","5_TOTAL_VENTA","","0" },
            { "1","6_TOTAL_COSTO_COMP","","0" },
            { "1","7_TOTAL_IMPUESTOS","","0" },
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","","0" },
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" ,"0"},




        };
        public static void RecargarVentanaEmergenteRegAño(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_año = new string[,]
            {
                { "1","0_MES","" ,"0"},
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" ,"NOSE"},
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","","NOSE¬0" },
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" ,"NOSE"},
                { "1","4_COMENTARIO","","" },
                { "1","5_TOTAL_VENTA","","0" },
                { "1","6_TOTAL_COSTO_COMP","","0" },
                { "1","7_TOTAL_IMPUESTOS","","0" },
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","","0" },
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" ,"0"},


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

            { "1","0_AÑO","","0" },
            { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" , "NOSE"},
            { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" , "NOSE¬0"},
            { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" , "0"},
            { "1","4_COMENTARIO","" , ""},
            { "1","5_TOTAL_VENTA","" , "0"},
            { "1","6_TOTAL_COSTO_COMP","", "0" },
            { "1","7_TOTAL_IMPUESTOS","" , "0"},
            { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" , "0"},
            { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" , "0"},


        };
        public static void RecargarVentanaEmergenteRegTotal(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_total = new string[,]
            {
                { "1","0_AÑO","","0" },
                { "1","1_OPERACION_1_VENTA_2_COMPRA_3_RETIRAR_DINERO_4_INTODUCIR","" , "NOSE"},
                { "1","2_IMPUESTO_1¬CANTIDAD_A_PAGAR_IMPUESTO_1¬PORCENTAGE_DE_IMPUESTO_1°IMPUESTO_2¬CANTIDAD_A_PAGAR_IMPUESTO_2¬PORCENTAGE_DE_IMPUESTO_2","" , "NOSE¬0"},
                { "1","3_PRODUCTOS_PRECIOTOTAL_CANTIDAD","" , "0"},
                { "1","4_COMENTARIO","" , ""},
                { "1","5_TOTAL_VENTA","" , "0"},
                { "1","6_TOTAL_COSTO_COMP","", "0" },
                { "1","7_TOTAL_IMPUESTOS","" , "0"},
                { "1","8_TOTAL_DEDUSIBLES_SOLO_SE_USA_EN_COMPRAS_Y_DONACIONES_SENECECITA_LA_FACTURA","" , "0"},
                { "1","9_TOTAL_GANANCIA_DESPUES_DE_IMPUESTOS","" , "0"},

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

            { "1","0_HORA","" ,"0"},
            { "1","1_OPERACION_VENTA_COMPRA_RETIRAR_PRODUCTO_INTODUCIR_PRODUCTO","" , "NOSE"},
            { "1","2_COD_BAR_CANTIDADES_NOMBRE_PRODUCTO_PLATAFORMA_DATOSPLATAFORMA","" , "NOSE"},
            

        };
        public static void RecargarVentanaEmergenteReg_prod_Dia(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_dia = new string[,]
            {
                { "1","0_HORA","" ,"0"},
                { "1","1_OPERACION_VENTA_COMPRA_RETIRAR_PRODUCTO_INTODUCIR_PRODUCTO","" , "NOSE"},
                { "1","2_COD_BAR_CANTIDADES_NOMBRE_PRODUCTO_PLATAFORMA_DATOSPLATAFORMA","" , "NOSE"},

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


            { "1","0_NOMBRE_PRODUCTO","","NOSE" },
            { "1","1_CANTIDAD","" , "0"},
            { "1","2_COD_BAR","" , "NOSE"},
            { "1","3_PROVEDORES","" , "NOSE"},
            { "1","4_HISTORIAL","" , "0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°"},
            { "1","5_RANKING","" , "0"},
            { "1","6_PROMEDIO","" , "0"},
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","","7" },
            { "1","8_USO_MULTIPLE","" ,""},              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","","" },  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" , "0"},        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna

        };
        public static void RecargarVentanaEmergenteReg_prod_Mes(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_mes = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","","NOSE" },
                { "1","1_CANTIDAD","" , "0"},
                { "1","2_COD_BAR","" , "NOSE"},
                { "1","3_PROVEDORES","" , "NOSE"},
                { "1","4_HISTORIAL","" , "0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°"},
                { "1","5_RANKING","" , "0"},
                { "1","6_PROMEDIO","" , "0"},
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","","7" },
                { "1","8_USO_MULTIPLE","" ,""},              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","","" },  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" , ""},        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna
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

            { "1","0_NOMBRE_PRODUCTO","" ,"NOSE"},
            { "1","1_CANTIDAD","" , "0"},
            { "1","2_COD_BAR","" , "NOSE"},
            { "1","3_PROVEDORES","" , "NOSE"},
            { "1","4_HISTORIAL","","0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°" },
            { "1","5_RANKING","" , "0"},
            { "1","6_PROMEDIO","" , "0"},
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","" , "7"},
            { "1","8_USO_MULTIPLE","" , ""},              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" , ""},  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" , "0"},        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna

        };
        public static void RecargarVentanaEmergenteReg_prod_Año(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_año = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","" ,"NOSE"},
                { "1","1_CANTIDAD","" , "0"},
                { "1","2_COD_BAR","" , "NOSE"},
                { "1","3_PROVEDORES","" , "NOSE"},
                { "1","4_HISTORIAL","","0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°" },
                { "1","5_RANKING","" , "0"},
                { "1","6_PROMEDIO","" , "0"},
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","" , "7"},
                { "1","8_USO_MULTIPLE","" , ""},              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" , ""},  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" , "0"},        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna
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
            { "1","0_NOMBRE_PRODUCTO","" ,"NOSE"},
            { "1","1_CANTIDAD","" , "0"},
            { "1","2_COD_BAR","" , "NOSE"},
            { "1","3_PROVEDORES","" , "NOSE"},
            { "1","4_HISTORIAL","","0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°" },
            { "1","5_RANKING","" , "0"},
            { "1","6_PROMEDIO","" , "0"},
            { "1","7_VECES_QUE_SUPERA_PROMEDIO","" , "7"},
            { "1","8_USO_MULTIPLE","" , ""},              // Nueva columna
            { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" , ""},  // Nueva columna
            { "1","10_MULTI_COSTO_COMPRA","" , "0"},        // Nueva columna
            { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna


        };
        public static void RecargarVentanaEmergenteReg_prod_total(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_reg_prod_total = new string[,]
            {
                { "1","0_NOMBRE_PRODUCTO","" ,"NOSE"},
                { "1","1_CANTIDAD","" , "0"},
                { "1","2_COD_BAR","" , "NOSE"},
                { "1","3_PROVEDORES","" , "NOSE"},
                { "1","4_HISTORIAL","","0°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°" },
                { "1","5_RANKING","" , "0"},
                { "1","6_PROMEDIO","" , "0"},
                { "1","7_VECES_QUE_SUPERA_PROMEDIO","" , "7"},
                { "1","8_USO_MULTIPLE","" , ""},              // Nueva columna
                { "1","9_USOMULTI_TIPO_DE_PRODUCTO","" , ""},  // Nueva columna
                { "1","10_MULTI_COSTO_COMPRA","" , "0"},        // Nueva columna
                { "1","11_NIVEL_DE_NESECIDAD","" , "0"},        // Nueva columna

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
            { "1","0_IMPUESTO","","0" },
            { "1","1_PORCENTAGE","" , "0"},
            { "1","2_DESCRIPCION","" , "NOSE"},
            { "1","3_INFO_EXTRA","" , "NOSE"},
            { "1","3_IMPUESTO_1_DIRECTO_2_INDIRECTO_3_NOSE","" , "3"},

        };

        public static void RecargarVentanaEmergenteImpuestos(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_IMPUESTOS = new string[,]
            {
                { "1","0_IMPUESTO","","0" },
                { "1","1_PORCENTAGE","" , "0"},
                { "1","2_DESCRIPCION","" , "NOSE"},
                { "1","3_INFO_EXTRA","" , "NOSE"},
                { "1","3_IMPUESTO_1_DIRECTO_2_INDIRECTO_3_NOSE","" , "3"},


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
            { "1","0_FECHA_yyyyMMddHH","" ,"0"},
            { "1","1_MONTO","" , "0"},
            { "1","2_DESCRIPCION","" , "NOSE"},
            { "1","3_PROVEDOR_O_INSTITUCION_DE_LA_FACTURA_O_DONACION","" , "NOSE"},
            { "1","4_DIRECCION_ARCHIVO_FACTURA","" , "NOSE"},
            { "1","5_FOLIO","" , "NOSE"},

        };

        public static void RecargarVentanaEmergenteDedusibles(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_DEDUSIBLES = new string[,]
            {
                { "1","0_FECHA_yyyyMMddHH","" ,"0"},
                { "1","1_MONTO","" , "0"},
                { "1","2_DESCRIPCION","" , "NOSE"},
                { "1","3_PROVEDOR_O_INSTITUCION_DE_LA_FACTURA_O_DONACION","" , "NOSE"},
                { "1","4_DIRECCION_ARCHIVO_FACTURA","" , "NOSE"},
                { "1","5_FOLIO","" , "NOSE"},
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
        static public string[,] GG_ventana_HERRAMIENTAS =
        {
            { "1","0_COD_BAR","","" },

        };
        public static void RecargarVentanaEmergente_TIPOS_DE_MEDIDA(string al_finalizar_que_borrar_para_proxima_ventana = "")
        {
            GG_ventana_HERRAMIENTAS = new string[,]
            {
                { "1","0_COD_BAR","","" },

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
            /*1*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\INVENTARIO\\INVENTARIO.TXT", columnas_concatenadas(GG_ventana_emergente_productos,1,var_fun_GG.GG_caracter_separacion[0]),""},
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
            /*22*/{ GG_direccion_carpetas_base[0] + "CONFIG\\INF\\INVENTARIO\\TIPOS_DE_MEDIDA.TXT", columnas_concatenadas(GG_ventana_HERRAMIENTAS,1,var_fun_GG.GG_caracter_separacion[0]),"NOSE§ML§GR§KG"},


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

        public static string GG_NUEVA_INFO_DEFAUL(string[,] arreglo_info, string columnas_a_ingresar_info_NO_DEFAUL, string info_NO_DEFAUL, string columnas_que_no_quieres_que_aparescan="")
        {
            string info_a_retornar = "";

            

            string[] copia_arreglo = new  string [arreglo_info.GetLength(0)];

            for (int i = 0; i < arreglo_info.GetLength(0); i++)
            {
                copia_arreglo[i] = arreglo_info[i, 3];
            }


            operaciones_textos op_tex = new operaciones_textos();
            string[] columnas_a_editar = columnas_a_ingresar_info_NO_DEFAUL.Split(var_fun_GG.GG_caracter_separacion[0][0]);
            string[] info_editar = info_NO_DEFAUL.Split(var_fun_GG.GG_caracter_separacion[0][0]);
            string[] columnas_a_QUITAR = columnas_que_no_quieres_que_aparescan.Split(var_fun_GG.GG_caracter_separacion[0][0]);

            for (int j = 0; j < columnas_a_editar.Length; j++)
            {
                int indice_a_editar = Convert.ToInt32(columnas_a_editar[j]);
                copia_arreglo[indice_a_editar] = info_editar[j];
            }




            if (columnas_que_no_quieres_que_aparescan != "")
            {
                for (int i = 0; i < copia_arreglo.Length; i++)
                {
                    bool agregar = true;
                    for (int j = 0; j < columnas_a_QUITAR.Length; j++)
                    {
                        if ((i + "") == columnas_a_QUITAR[j])
                        {
                            agregar = false;
                            break;
                        }
                        
                    }
                    if (agregar == true)
                    {
                        info_a_retornar = op_tex.concatenacion_caracter_separacion(info_a_retornar, copia_arreglo[i], var_fun_GG.GG_caracter_separacion[0]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < copia_arreglo.Length; i++)
                {
                    info_a_retornar = op_tex.concatenacion_caracter_separacion(info_a_retornar, copia_arreglo[i], var_fun_GG.GG_caracter_separacion[0]);
                }
            }

            return info_a_retornar;
        }
    }
}