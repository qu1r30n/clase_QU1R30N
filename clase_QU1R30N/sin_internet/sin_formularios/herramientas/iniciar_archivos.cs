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
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[0, 0], var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[0, 1], null);

            // Crear archivos del programa
            for (int i = G_donde_inicia_la_tabla; i < var_fun_GG_dir_arch_crear.GG_dir_nom_archivos.GetLength(0); i++)
            {
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 0], var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 1], var_fun_GG_dir_arch_crear.GG_dir_nom_archivos[i, 2].Split(G_caracter_separacion_funciones_espesificas[1][0]));
            }
            
            
        }
    }
}