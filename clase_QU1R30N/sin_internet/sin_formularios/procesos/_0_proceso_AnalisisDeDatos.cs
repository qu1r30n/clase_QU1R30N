﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _0_proceso_AnalisisDeDatos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();
        operaciones_arreglos op_arr = new operaciones_arreglos();






        public string existe_informacion(string direccion_archivo, string informacion, string columnas_a_recorrer)
        {
            string info_a_retornar = null;

            

            string[] resultado = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo).ToString().Split(G_caracter_para_confirmacion_o_error[0][0]);

            if (Convert.ToInt32(resultado[0]) > 0)
            {
                if (resultado[0] == "1")
                {
                    int indice_arreglo = Convert.ToInt32(resultado[1]);

                    for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length; i++)
                    {
                        string[] info_espliteado = Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo][i].Split(G_caracter_separacion[0][0]);
                        if (informacion == info_espliteado[4])
                        {
                            info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + "encontrado";
                            return info_a_retornar;
                        }
                    }
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no_encontrado";
                    return info_a_retornar;
                }
            }
            else
            {
                if (resultado[0] == "-1")
                {

                }
                else if (resultado[0] == "-1")
                {
                    string[] contenido_archivo = bas.Leer(direccion_archivo);

                    for (int i = G_donde_inicia_la_tabla; i < contenido_archivo.Length; i++)
                    {
                        string[] info_espliteado = contenido_archivo[i].Split(G_caracter_separacion[0][0]);
                        if (informacion == info_espliteado[4])
                        {
                            info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + "encontrado";
                            return info_a_retornar;
                        }
                    }
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no_encontrado";

                    return info_a_retornar;
                }
            }
            

            info_a_retornar = resultado[0] + G_caracter_para_confirmacion_o_error[0] + resultado[1];

            return info_a_retornar;

        }




    }
}
