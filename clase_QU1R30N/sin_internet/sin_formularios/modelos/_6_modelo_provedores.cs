﻿using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;


namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _6_modelo_provedores
    {

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[2, 0],//"config\\inf\\dat\\provedores.txt",
        };


        _6_proceso_provedores pr_provedores = new _6_proceso_provedores();
        public string operacion_a_hacer(string proceso, string datos)
        {
            string info_a_retornar = null;

            string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);
            switch (proceso)
            {
                case "REGISTRO_PROVEDOR":

                    pr_provedores.registro_provedores_cod3_r_(G_direcciones[0], "err__cambiar");

                    break;

                default:
                    info_a_retornar = "3" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;

        }

    }
}
