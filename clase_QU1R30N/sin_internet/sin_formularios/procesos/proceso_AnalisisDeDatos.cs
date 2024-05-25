﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class proceso_AnalisisDeDatos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();


        public string existe_producto(string codigo)
        {
            string[] resultao = bas.sacar_indice_del_arreglo_de_direccion(Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0]).ToString().Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (resultao[0] == "1")
            {
                int indice_arreglo = Convert.ToInt32(resultao[1]);

                for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length; i++)
                {
                    string[] info_espliteado = Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo][i].Split(G_caracter_separacion[0][0]);
                    if (codigo == info_espliteado[4])
                    {
                        return "1" + G_caracter_para_confirmacion_o_error[0] + "encontrado";
                    }
                }
                return "3" + G_caracter_para_confirmacion_o_error + "no_encontrado";
            }
            else
            {
                return resultao[0] + G_caracter_para_confirmacion_o_error + resultao[1];
            }
            
            return null;
        }
    }
}
