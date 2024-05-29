using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _5_proceso_afiliados
    {


        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();
        operaciones_textos op_tex = new operaciones_textos();
        Tex_base bas = new Tex_base();
        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;


        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[4,1],//"config\\afiliados\\afiliados_simple.txt
            /*1*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[5,1],//"config\\afiliados\\afiliados_complejo.txt
            /*2*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[6,1],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_simple.txt
            /*3*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[7,1],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_complejo.txt
        };


        public void registro_simple(string id_enc_simple, string tabla_enc_simp, string datos, object caracter_separacion_obj = null, bool viene_reg_comp = false)
        {
            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);

            if (viene_reg_comp == false)
            {
                DateTime fecha_hora = DateTime.Now;
                string año_mes_dia_hora_min = fecha_hora.ToString("yyyyMMddHHmm");
                string año = fecha_hora.ToString("yyyy");
                string dir = "config\\afiliados\\reg\\" + año + "_reg.txt";
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(dir, leer_y_agrega_al_arreglo: false);
                string info_movimiento = "reg_sim" + caracter_separacion_string[0] + id_enc_simple + caracter_separacion_string[0] + tabla_enc_simp + caracter_separacion_string[0] + datos + caracter_separacion_string[0];
                bas.Agregar(dir, info_movimiento, con_arreglo_GG: false);
            }


            string direccion_tab_enc_simple = G_direcciones[0];
            string direccion_tab_NIVELES_IDHORIZONTAL_enc_simple = G_direcciones[1];
            string resultado_inf_enc_simp = bas.sacar_indice_del_arreglo_de_direccion(direccion_tab_enc_simple);
            string resultado_inf_direccion_tab_NIVELES_IDHORIZONTAL_enc_simple = direccion_tab_NIVELES_IDHORIZONTAL_enc_simple;
            string[] res_esp_enc_simp = resultado_inf_enc_simp.Split(G_caracter_para_confirmacion_o_error[0][0]);
            string[] res_esp_NIV_enc_simp = resultado_inf_direccion_tab_NIVELES_IDHORIZONTAL_enc_simple.Split(G_caracter_para_confirmacion_o_error[0][0]);

            if (res_esp_enc_simp[0] == "1" && res_esp_NIV_enc_simp[0] == "1")
            {

                int indic_afil_simp = Convert.ToInt32(res_esp_enc_simp[1]);
                int indic_niv_afil_simp = Convert.ToInt32(res_esp_NIV_enc_simp[1]);
                //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|



                string nivel_encargados = "";
                for (int i = 0; i < Tex_base.GG_base_arreglo_de_arreglos[indic_afil_simp].Length; i++)
                {
                    string[] info_base_split = Tex_base.GG_base_arreglo_de_arreglos[indic_afil_simp][i].Split(caracter_separacion_string[0][0]);
                    //en registro simple en la base el id_encargado el el id_patrocinador
                    if (info_base_split[0] == id_enc_simple)
                    {
                        nivel_encargados = info_base_split[8];
                        break;

                    }
                }

                string info_a_agregar =
                    (Tex_base.GG_base_arreglo_de_arreglos[indic_afil_simp].Length - 1 + "")//0_id_usuario
                    + caracter_separacion_string[0]
                    + ""                    //|1_id_pat_comp    
                    + caracter_separacion_string[0]
                    + ""                    //|2_tabla_pat_comp    
                    + caracter_separacion_string[0]
                    + id_enc_simple         //|3_id_enc_simp 
                    + caracter_separacion_string[0]
                    + tabla_enc_simp        //|4_tabla_enc_simp
                    + caracter_separacion_string[0]
                    + "0"                   //|5_puntos_d
                    + caracter_separacion_string[0]
                    + "0"                   //|6_puntos_d_a_dar
                    + caracter_separacion_string[0]
                    + datos                 //|7_datos
                    + caracter_separacion_string[0]
                    + "" + (Convert.ToInt32(nivel_encargados) + 1)        //|8_niveles   
                    + caracter_separacion_string[0]
                    + ""                    //|9_id_horizontal
                    + caracter_separacion_string[0]
                    + ""                    //|10_tipo_afiliado| 
                    + caracter_separacion_string[0];

                bas.Agregar(direccion_tab_enc_simple, info_a_agregar);
            }

            else
            {
                if (res_esp_enc_simp[0] != "1")
                {

                }
                else if (res_esp_NIV_enc_simp[0] != "1")
                {

                }

            }
        
        
        }
    }
}
