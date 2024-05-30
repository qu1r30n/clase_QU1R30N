using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;


namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _5_modelo_afiliados
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        _5_proceso_afiliados pr_afil = new _5_proceso_afiliados();
        public string operacion_a_hacer(string operacion)
        {
            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "inscribir_simple":

                    //0_id_enc_simp|1_tabla_enc_simple|2_datos
                    //4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com
                    //datos//nombre°apellido_paterno°apellido_materno°numero_cuenta°banco°curp°numero_celular°direccion°colonia°municiopio°estado°correo
                    string[] info_registro = a_donde_enviara_la_informacion[1].Split(G_caracter_separacion[0][0]);
                    info_a_retornar = pr_afil.registro_simple(info_registro[0], info_registro[1], info_registro[2]);
                    break;

                default:
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;

        }
    }
}
