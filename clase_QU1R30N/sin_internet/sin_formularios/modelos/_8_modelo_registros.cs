using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _8_modelo_registros
    {

        string[] G_direcciones_REGISTROS =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[11,0],//reg_año_mes_dia
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[12,0],//reg_año_mes
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[13,0],//reg_año
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[14,0],//reg_total
            //productos
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[15,0],//reg_año_mes_dia
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[16,0],//reg_año_mes
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[17,0],//reg_año
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[18,0],//reg_total
        };

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        //proceso al que se dirigira//_7_procesos_sucursales pr_sucursales = new _7_procesos_sucursales();
        public string registro_movimiento(string modelo, string proceso, string datos)
        {
            string info_a_retornar = null;

            string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);

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

            return info_a_retornar;

        }


    }
}
