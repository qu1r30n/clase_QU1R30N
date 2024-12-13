using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
        internal class _10_modelo_mul
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        _10_proceso_mul pr_mul = new _10_proceso_mul();

        string[] G_direcciones =
        {
                Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[8, 0]//
            };

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
                string tem_dat = "";
                switch (proceso)
                {

                    case "BUSQUEDA_POR_TELEFONO":
                        string telefono_b = info_espliteada[0];
                        info_a_retornar = pr_mul.busqueda_con_telefono(telefono_b);
                        break;

                    case "BUSQUEDA_POR_CURP":
                        string curp_b = info_espliteada[0];
                        info_a_retornar = pr_mul.busqueda_con_curp(curp_b);
                        break;

                    case "BUSQUEDA_POR_INE":
                        string ine_b = info_espliteada[0];
                        info_a_retornar = pr_mul.busqueda_con_clave_elector(ine_b);
                        break;

                    case "BUSQUEDA_POR_IDENTIFICACION_OFICIAL":
                        string identificacion_oficial_b = info_espliteada[0];
                        info_a_retornar = pr_mul.busqueda_con_otra_identificacion_oficial(identificacion_oficial_b);
                        
                        break;



                    case "COMICION_VENTA_BUSQUEDA_POR_TELEFONO":
                        string telefono = info_espliteada[0];
                        tem_dat = pr_mul.busqueda_con_telefono(telefono);
                        if (tem_dat != "")
                        {
                            string[] info_esplitedo = tem_dat.Split(G_caracter_separacion[0][0]);
                            info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_esplitedo[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                        }

                        break;

                    case "COMICION_VENTA_BUSQUEDA_POR_CURP":
                        string curp = info_espliteada[0];
                        tem_dat = pr_mul.busqueda_con_curp(curp);
                        if (tem_dat != "")
                        {
                            string[] info_esplitedo = tem_dat.Split(G_caracter_separacion[0][0]);
                            info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_esplitedo[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                        }
                        break;

                    case "COMICION_VENTA_BUSQUEDA_POR_INE":
                        string ine = info_espliteada[0];
                        tem_dat = pr_mul.busqueda_con_clave_elector(ine);
                        if (tem_dat != "")
                        {
                            string[] info_esplitedo = tem_dat.Split(G_caracter_separacion[0][0]);
                            info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_esplitedo[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                        }
                        break;

                    case "COMICION_VENTA_BUSQUEDA_POR_IDENTIFICACION_OFICIAL":
                        string identificacion_oficial = info_espliteada[0];
                        tem_dat = pr_mul.busqueda_con_otra_identificacion_oficial(identificacion_oficial);
                        if (tem_dat != "")
                        {
                            string[] info_esplitedo = tem_dat.Split(G_caracter_separacion[0][0]);
                            info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_esplitedo[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                        }
                        break;

                        case "COMICION_VENTA_BUSQUEDA_POR_ID":
                        info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4], info_espliteada[5]);
                        break;
                    default:

                        info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                        break;
                }

            }
            return info_a_retornar;
        }

    }
}
