using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _7_procesos_sucursales
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();

        public string funcion_a_hacer1(string direccion_archivo, string parametro1, string parametro2, string parametro3, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";


            string direccion_archivo_aprendices_E = direccion_archivo;
            string resultado_archivo_aprendices_E = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo_aprendices_E);
            string[] res_esp_archivo_apr_E = resultado_archivo_aprendices_E.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo_apr_E[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                if (res_esp_archivo_apr_E[0] == "1")
                {

                }
            }

            else
            {
                info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
            }

            return info_a_retornar;
        }



    }
}
