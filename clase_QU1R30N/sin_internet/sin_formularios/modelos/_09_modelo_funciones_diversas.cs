using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _09_modelo_funciones_diversas
    {
        string[] G_direcciones =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[22, 0],//tipo de medida
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[4, 0],//recordatorios
        };

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;



        //proceso al que se dirigira//_7_procesos_sucursales pr_sucursales = new _7_procesos_sucursales();
        _09_proceso_funciones_diversas pr_funciones_div = new _09_proceso_funciones_diversas();
        public string operacion_a_hacer(string info_entrada, string fecha_hora)
        {
            string info_a_retornar = null;


            string[] info = info_entrada.Split(G_caracter_separacion_funciones_espesificas[1][0]);
            string proceso = info[0];
            string datos = info[1];

            string año_mes_dia_hora_minuto_segundo = fecha_hora, año_mes_dia_hora_minuto = "", año_mes_dia_hora = "", año_mes_dia = "", año_mes = "", año = "";
            for (int i = 0; i < fecha_hora.Length; i++)
            {
                if (i < fecha_hora.Length - 2)
                {
                    año_mes_dia_hora_minuto = año_mes_dia_hora_minuto + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 4)
                {
                    año_mes_dia_hora = año_mes_dia_hora + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 6)
                {
                    año_mes_dia = año_mes_dia + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 8)
                {
                    año_mes = año_mes + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 10)
                {
                    año = año + fecha_hora[i];
                }
            }


            string[] cant_datos = datos.Split(G_caracter_separacion_funciones_espesificas[2][0]);

            for (int i = 0; i < cant_datos.Length; i++)
            {
                string[] info_espliteada = cant_datos[i].Split(G_caracter_separacion[0][0]);

                switch (proceso)
                {

                    case "EXTRAER_TIPOS_DE_MEDIDA":
                        info_a_retornar = pr_funciones_div.extraer_tipos_de_medida(G_direcciones[0]);
                        break;

                    case "RECORDATORIO":
                        info_a_retornar = pr_funciones_div.guardar_recordatorio(G_direcciones[1], info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3]);
                        break;

                    case "CHECAR_RECORDATORIO":
                        pr_funciones_div.checar_recordatorios();
                        break;

                    case "TRABAJO_DIA":
                        info_a_retornar = pr_funciones_div.trabajo_por_dia();
                        break;

                    default:
                        info_a_retornar = "-3" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                        break;
                }


            }
            return info_a_retornar;

        }
    }
}
