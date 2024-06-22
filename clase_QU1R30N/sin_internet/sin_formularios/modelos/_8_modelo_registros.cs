using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;
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
        _8_proceso_registros pr_reg = new _8_proceso_registros();
        public string registro_movimiento(string modelo, string proceso, string datos)
        {
            string info_a_retornar = null;

            pr_reg.registrar_movimiento(G_direcciones_REGISTROS[0],modelo, proceso, datos);

            return info_a_retornar;

        }


    }
}
