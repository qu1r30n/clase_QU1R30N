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
    internal class _8_proceso_registros
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();




        public string registrar_movimiento(string direccion_archivo, string modelo, string proceso, string datos, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";


            string direccion_archivo_aprendices_emp = direccion_archivo;
            string resultado_archivo_aprendices_emp = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo_aprendices_emp);
            string[] res_esp_archivo_emp = resultado_archivo_aprendices_emp.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo_emp[0]) > 0)
            {
                string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);
                if (res_esp_archivo_emp[0]=="1")
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

                                // Código correspondiente al caso "VENTA"
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

            else
            {
                info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
            }

            return info_a_retornar;
        }


        public string funcion_a_hacer2(string parametro1, string parametro2)
        {
            string info_a_retornar = null;

            return info_a_retornar;
        }



    }
}
