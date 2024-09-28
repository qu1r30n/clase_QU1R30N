using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_QU1R30N.sin_internet.sin_formularios.herramientas;


namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _09_proceso_funciones_diversas
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_para_transferencia_entre_archivos = var_fun_GG.GG_caracter_para_transferencia_entre_archivos;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        operaciones_textos op_tex = new operaciones_textos();
        Tex_base bas = new Tex_base();


        public string extraer_tipos_de_medida(string direccion_archivo, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";


            string direccion_archivo_tipo_medid = direccion_archivo;
            string resultado_archivo_tipo_medida = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo_tipo_medid);
            string[] res_esp_archivo_tipo_medida = resultado_archivo_tipo_medida.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo_tipo_medida[0]) > 0)
            {
                if (res_esp_archivo_tipo_medida[0] == "1")
                {
                    int indice = Convert.ToInt32(res_esp_archivo_tipo_medida[1]);
                    for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
                    {
                        info_a_retornar = op_tex.concatenacion_caracter_separacion(info_a_retornar, Tex_base.GG_base_arreglo_de_arreglos[indice][i], caracter_separacion_string[1]);
                    }
                    info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + info_a_retornar;
                }

            }

            else
            {
                if (res_esp_archivo_tipo_medida[0] == "0")
                {
                    info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
                }

            }

            return info_a_retornar;
        }


        public string recordatorio(string direccion_archivo, string mensaje, string horario, string CONTACTO, string ID_PROGRAMA = "NEXOPORTALARCANO")
        {
            string info_a_retornar = null;

            string info_a_agregar = ID_PROGRAMA + G_caracter_para_transferencia_entre_archivos[0] + var_fun_GG.GG_id_programa + G_caracter_para_transferencia_entre_archivos[1] + "WS_RS" + G_caracter_para_transferencia_entre_archivos[1] + "RECORDATORIO" + G_caracter_para_transferencia_entre_archivos[1] + mensaje + G_caracter_para_transferencia_entre_archivos[1] + horario + G_caracter_para_transferencia_entre_archivos[1] + CONTACTO;
            bas.Agregar(direccion_archivo, info_a_agregar, false);

            info_a_retornar = "recordatorio guardado";

            return info_a_retornar;
        }



    }
}

