﻿using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.con_internet.herramientas_internet
{
    internal class conmutador
    {

        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();

        Tex_base bas = new Tex_base();

        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;


        public void conmutar_datos(string parametro)
        {
            string[] res_espliteada = parametro.Split(G_caracter_separacion_funciones_espesificas[1][0]);
            // Implementa la lógica aquí
        }
    }
}
