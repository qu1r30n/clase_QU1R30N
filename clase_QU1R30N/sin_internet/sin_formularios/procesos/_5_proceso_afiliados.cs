using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
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

        



        public void registro_simple(string id_patrocinador, string tabla, string datos, char caracter_separacion = '|', char caracter_separacion2 = '°', bool viene_reg_comp = false)
        {
            if (viene_reg_comp == false)
            {
                DateTime fecha_hora = DateTime.Now;
                string año_mes_dia = fecha_hora.ToString("yyyyMMdd");
                string dir = "sismul2\\mov\\mov_diario_det\\" + año_mes_dia + "_mov.txt";
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(dir, leer_y_agrega_al_arreglo: false);
                string info_movimiento = "reg_sim" + caracter_separacion + id_patrocinador + caracter_separacion + tabla + caracter_separacion + datos + caracter_separacion;
                bas.Agregar(dir, info_movimiento);
            }


            datos = op_tex.Trimend_paresido(datos, '°');

            string direccion_tab_enc = "sismul2\\" + tabla + ".txt";
            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(direccion_tab_enc, "0|||0|0|0|0|nom°ap°etc|0°0°0°|",leer_y_agrega_al_arreglo:false);
            string[] info_base = bas.Leer(direccion_tab_enc);
            string patrocinadores = "";
            for (int i = 0; i < info_base.Length; i++)
            {
                string[] info_base_split = info_base[i].Split(caracter_separacion);
                //en registro simple en la base el id_encargado el el id_patrocinador
                if (info_base_split[0] == id_patrocinador)
                {
                    patrocinadores = info_base_split[8];

                }
            }

            //0_id_usuario|1_id_patrocinador|2_tabla_patrocinador|3_id_encargado|5_tabla_encargado|5_diner|6_a_pagar|7_datos|8_encargados|
            string info_a_agregar = info_base.Length + "" + caracter_separacion + caracter_separacion + caracter_separacion + ("" + id_patrocinador) + caracter_separacion + tabla + caracter_separacion + "0" + caracter_separacion + "0" + caracter_separacion + datos + caracter_separacion + patrocinadores + caracter_separacion;
            bas.Agregar(direccion_tab_enc, info_a_agregar);

        }



    }
}
