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


        public void conmutar_datos(string parametro, string ia_ws)
        {
            string mensage_a_enviar = "probando 1 2 3 XD";
            string[] res_espliteada = parametro.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            // Implementa la lógica aquí


            //procesos_usaras------------------------------------------------------------
            string proceso_que_usaras = "punto_venta";

            if (proceso_que_usaras == "punto_venta")
            {
                punt_venta(res_espliteada[0], res_espliteada[1], res_espliteada[2]);
            }
            else if (proceso_que_usaras == "repetidor") 
            {
                repetidor(res_espliteada[0], res_espliteada[1], res_espliteada[2]);
            }
            else if (proceso_que_usaras == "inteligencia_artificial")
            {
                inteligencia_artificial(res_espliteada[0], res_espliteada[1], res_espliteada[2]);
            }
            else
            {

            }







            conexion con_ent = new conexion();
            if (res_espliteada[2] == "ws")
            {
                con_ent.datos_a_enviar(res_espliteada[0], mensage_a_enviar, ia_ws, 1);
            }

            else if (res_espliteada[2] == "prog_1")
            {
                con_ent.datos_a_enviar(res_espliteada[0], mensage_a_enviar, ia_ws, 2);
            }
            else
            {

            }
            

            
        }


        //procesos---------------------------------------------------------------------------------------------

        public void punt_venta(string contacto, string info_a_procesar, string programa)
        {

            info_a_procesar = info_a_procesar.Replace(" ", "");
            info_a_procesar = info_a_procesar.Replace(G_caracter_separacion_funciones_espesificas[2] + G_caracter_separacion_funciones_espesificas[2], "\r\n");
            info_a_procesar = info_a_procesar.Replace(G_caracter_separacion_funciones_espesificas[2], "\r\n");
            string[] lineas_del_mensaje = info_a_procesar.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            

            
        }

        public void repetidor(string contacto, string info_a_procesar, string programa)
        {

        }

        public void inteligencia_artificial(string contacto, string info_a_procesar, string programa)
        {

        }

        //fin procesos-------------------------------------------------------------------------------------------
    }
}
