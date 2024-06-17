using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _0_modelo_AnalisisDeDatos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.txt",
            /*1*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[4,0],//"config\\afiliados\\afiliados_simple.txt",
            /*2*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[6,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_simple.txt",
            /*3*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[5,0],//"config\\afiliados\\afiliados_complejo.txt",
            /*4*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[7,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_complejo.txt",
            /*5*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[8,0],//"config\\afiliados\\afiliados_unificado.txt",
            /*6*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[9,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_unificado.txt",

        };


        _0_proceso_AnalisisDeDatos pr_an_dat = new _0_proceso_AnalisisDeDatos();
        public string operacion_a_hacer(string operacion)
        {
            

            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "EXISTE_PRODUCTO":
                    info_a_retornar = pr_an_dat.existe_informacion(G_direcciones[0], a_donde_enviara_la_informacion[1],"5");
                    break;

                case "EXISTE_CURP_UNIFICADO_COD3_R_":
                    info_a_retornar = pr_an_dat.existe_informacion(G_direcciones[5], a_donde_enviara_la_informacion[1], "4|4");
                    break;

                case "EXISTE_CLAVE_LECTOR_UNIFICADO_COD3_R_":
                    info_a_retornar = pr_an_dat.existe_informacion(G_direcciones[5], a_donde_enviara_la_informacion[1], "4|5");
                    break;
                case "EXISTE_OTRA_IDENTIFICACION_OFICIAL_UNIFICADO_COD3_R_":
                    info_a_retornar = pr_an_dat.existe_informacion(G_direcciones[5], a_donde_enviara_la_informacion[1], "4|6");
                    break;





                default:
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }
            return info_a_retornar;
        }
    }
}
