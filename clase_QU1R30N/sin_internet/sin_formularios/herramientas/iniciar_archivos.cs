using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N
{

    internal class iniciar_archivos
    {

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;
        
        


        Tex_base bas = new Tex_base();
        public void iniciar()
        {
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(
                var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[0, 0], 
                var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[0, 1],
                var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[0, 2].Split(G_caracter_separacion_funciones_espesificas[1][0]));

            // Crear archivos del programa
            for (int i = G_donde_inicia_la_tabla; i < var_fun_GG_dir_arch_crear.GG_dir_nom_archivos.GetLength(0); i++)
            {
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 0], 
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 1], 
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 2].Split(G_caracter_separacion_funciones_espesificas[1][0]));
            }


            // Crear archivos del programa SIN ARREGLO GG
            for (int i = 0; i < var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG.GetLength(0); i++)
            {
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[i, 0],
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[i, 1],
                    var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[i, 2].Split(G_caracter_separacion_funciones_espesificas[1][0]));
            }


            string[] res_indice = bas.sacar_indice_del_arreglo_de_direccion(Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
            int indice = Convert.ToInt32(res_indice[1]);


            for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice].Length; i++)
            {
                string[] info_esp = Tex_base.GG_base_arreglo_de_arreglos[indice][i].Split(G_caracter_separacion[0][0]);
                var_fun_GG.GG_autoCompleteCollection_codbar_venta.Add(info_esp[5] + G_caracter_separacion[0] + info_esp[1] + " " + info_esp[2] + info_esp[3] + G_caracter_separacion[0] + i);
                var_fun_GG.GG_autoCompleteCollection_nom_produc_venta.Add(info_esp[1] + " " + info_esp[2] + info_esp[3] + G_caracter_separacion[0] + info_esp[5] + G_caracter_separacion[0] + i);
            }
            var_fun_GG.GG_inv_solo_lect = Array.AsReadOnly(Tex_base.GG_base_arreglo_de_arreglos[indice]);

        }


        /*
        private void ranking()
        {
            string dir_ranking_dia = "inf\\ranking\\dia\\" + fecha_hora.ToString("yyyyMMdd") + "_ranking.TXT";

            if (bas.existe_archivo(dir_ranking_dia))
            {
                bas.Crear_archivo_y_directorio(dir_ranking_dia);
                bas.si_existe_suma_sino_agega_extra(direccion3, 0, "con_dia_sem", "1", "1", "con_dia_sem|1");
            }

            string dir_ranking_año = "inf\\ranking\\" + fecha_hora.ToString("yyyy") + "_ranking.TXT";
            bas.Crear_archivo_y_directorio(dir_ranking_año);
            string info_con_dia = bas.Seleccionar(direccion3, 0, "con_dia_sem", "1");
            int num_dia = Convert.ToInt32(info_con_dia);
            if (num_dia >= 7)
            {

                bas.Editar_espesifico(direccion3, 0, "con_dia_sem", "1", "1");
                bas.Editar_una_columna(dir_ranking_año, 2, "0");
                string[] info_ranking = bas.Leer(dir_ranking_año);

                for (int i = 0; i < info_ranking.Length; i++)
                {
                    string[] info_producto = info_ranking[i].Split('|');
                    string[] historial_ranking = info_producto[4].Split('°');
                    for (int j = historial_ranking.Length - 2; j >= 0; j--)
                    {
                        historial_ranking[j + 1] = historial_ranking[j];
                    }
                    historial_ranking[0] = "0";
                    info_producto[4] = string.Join("°", historial_ranking);
                    bas.Editar_fila(dir_ranking_año, 0, info_producto[0], string.Join("|", info_producto));

                }
                bas.Editar_espesifico(direccion3, 0, "con_dia_sem", "1", "0");

            }
        }

        */


        //fin clase-----------------------------------------------------------------------------
    }
}