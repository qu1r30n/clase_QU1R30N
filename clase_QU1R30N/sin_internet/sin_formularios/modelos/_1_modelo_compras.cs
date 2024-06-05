﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _1_modelo_compras
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0]//"config\\inf\\inventario\\inventario.txt",
        };

        _1_proceso_compras pr_Comp = new _1_proceso_compras();
        public string operacion_a_hacer(string operacion)
        {
            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "compra":
                    string[] info_espliteada = a_donde_enviara_la_informacion[1].Split(G_caracter_separacion[0][0]);
                    info_a_retornar = pr_Comp.compras(G_direcciones[0], info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                    break;
                case "compra_mayoreo":
                    
                    break;

                case "compra_con_promocion":
                    break;
                case "cancelar":
                    break;
                default:    
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }
            return info_a_retornar;
        }
    }
}
