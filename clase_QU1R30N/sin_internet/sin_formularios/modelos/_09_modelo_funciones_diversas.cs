using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{

    using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
    using clase_QU1R30N.sin_internet.sin_formularios.procesos;

    internal class _09_modelo_funciones_diversas
    {
        string[] G_direcciones =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[22, 0]//tipo de medida
        };

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        //proceso al que se dirigira//_7_procesos_sucursales pr_sucursales = new _7_procesos_sucursales();
        _09_proceso_funciones_diversas pr_funciones_div = new _09_proceso_funciones_diversas();
        public string operacion_a_hacer(string operacion, string datos, string fecha_hora)
        {
            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "EXTRAER_TIPOS_DE_MEDIDA":
                    info_a_retornar = pr_funciones_div.extraer_tipos_de_medida(G_direcciones[0]);
                    break;

                default:
                    info_a_retornar = "-3" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;

        }
    }
}
