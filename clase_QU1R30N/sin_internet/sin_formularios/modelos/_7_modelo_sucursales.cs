﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _7_modelo_sucursales
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[10, 0]//"config\\inf\\inventario\\inventario.txt",
        };



        _7_proceso_sucursales pr_sucursales = new _7_proceso_sucursales();
        public string operacion_a_hacer(string proceso, string datos)
        {
            string info_a_retornar = null;

            string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);
            switch (proceso)
            {
                case "AGREGAR":
                    pr_sucursales.funcion_a_hacer1(G_direcciones[0], "", "", "");
                    break;

                default:
                    info_a_retornar = "3" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;

        }

    }
}
