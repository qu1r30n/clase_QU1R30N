﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.con_internet.herramientas_internet
{
    internal class conexion
    {
        
        public string[] G_dir_arch_transferencia =
        {
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[0,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[1,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[2,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[3,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[4,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[5,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[6,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[7,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[8,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[9,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[10,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[11,0],
            var_fun_GG_dir_arch_crear.GG_dir_nom_archivos_SIN_ARREGLOS_GG[12,0],
        };



        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();

        Tex_base bas = new Tex_base();

        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        conmutador conmut = new conmutador();

        public int[] checar_numero_de_direccion_de_archivo_atras_actual_adelante(int posicion_bandera)
        {
            string[] banderas = bas.Leer(G_dir_arch_transferencia[0]);



            int numero_actual_posision = Convert.ToInt32(banderas[posicion_bandera]);
            int numero_adelante_posision = numero_actual_posision + 3;
            int numero_atras_posision = numero_actual_posision - 3;
            int[] arr_devolver = { -1, -1, -1 };


            if (G_dir_arch_transferencia.Length <= numero_adelante_posision)
            {
                if (numero_adelante_posision < 3)
                {
                    numero_adelante_posision = posicion_bandera;
                }
                else
                {
                    numero_adelante_posision = posicion_bandera;
                    while (numero_adelante_posision > 3)
                    {
                        numero_adelante_posision = numero_adelante_posision - 3;
                    }
                }
            }
            if (1 > numero_actual_posision - 3)
            {
                numero_atras_posision = (G_dir_arch_transferencia.Length - 4) + posicion_bandera;
            }
            arr_devolver[0] = numero_atras_posision;
            arr_devolver[1] = numero_actual_posision;
            arr_devolver[2] = numero_adelante_posision;




            return arr_devolver;

        }


        public void datos_entrada(string contacto, string mensage, string ia_ws = "ws")
        {

            if (ia_ws == "ws")//agrega a archivos pregunta de la ia
            {
                int[] id_atras_actual_adelante_ia_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(1);//esta es de la ia
                int[] id_atras_actual_adelante_ws_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(4);//este es del ws




                string contacto_solo_los_ultimos_digitos = "";
                for (int i = 0; i < 4 && i < contacto.Length; i++)
                {
                    contacto_solo_los_ultimos_digitos = contacto_solo_los_ultimos_digitos + contacto[i];
                }



                if (id_atras_actual_adelante_ws_2[1] == id_atras_actual_adelante_ia_1[1] || id_atras_actual_adelante_ws_2[0] == id_atras_actual_adelante_ia_1[1])
                {

                    //bas.Agregar_a_archivo_sin_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_ws_2[2]], contacto + G_caracter_separacion_funciones_espesificas[1] + mensage1 + "      menu:" + mensage3 + "      " + mensage2 + "        cliente: hola soy: " + contacto_solo_los_ultimos_digitos + " " + mensage);
                    bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ws_2[2]], contacto + G_caracter_separacion_funciones_espesificas[1] + "soy " + contacto_solo_los_ultimos_digitos + ": " + mensage, false);
                    bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 4, (id_atras_actual_adelante_ws_2[2]) + "");
                }
                else
                {
                    //bas.Agregar_a_archivo_sin_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_ws_2[1]], contacto + G_caracter_separacion_funciones_espesificas[1] + mensage1 + "      menu:" + mensage3 + "      " + mensage2 + "hola soy " + contacto_solo_los_ultimos_digitos + ": " + mensage);
                    bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ws_2[1]], contacto + G_caracter_separacion_funciones_espesificas[1] + "hola soy " + contacto_solo_los_ultimos_digitos + ": " + mensage, false);
                }


            }


            else if (ia_ws == "ia")//agrega a archivos pregunta de la ia
            {
                int[] id_atras_actual_adelante_ia_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(2);//esta es de la ia
                int[] id_atras_actual_adelante_ws_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(5);//este es del ws
                string[] pedido_sie_es_mas_de_1 = mensage.Split(G_caracter_separacion_funciones_espesificas[2][0]);
                if (pedido_sie_es_mas_de_1.Length <= 1)
                {
                    if (id_atras_actual_adelante_ws_2[1] == id_atras_actual_adelante_ia_1[1])
                    {
                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ia_1[2]], contacto + G_caracter_separacion_funciones_espesificas[1] + mensage, false);
                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 2, id_atras_actual_adelante_ia_1[2] + "");
                    }
                    else
                    {
                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ia_1[1]], contacto + G_caracter_separacion_funciones_espesificas[1] + mensage, false);
                    }
                }
                else
                {
                    int[] id_atras_actual_adelante_pedido_ia_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(3);//esta es de la ia
                    int[] id_atras_actual_adelante_pedido_ws_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(6);//este es del ws

                    if (id_atras_actual_adelante_pedido_ws_2[1] == id_atras_actual_adelante_pedido_ia_1[1])
                    {
                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_pedido_ia_1[2]], "Vendedores" + G_caracter_separacion_funciones_espesificas[1] + contacto + G_caracter_separacion[0] + mensage, false);
                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 3, id_atras_actual_adelante_pedido_ia_1[2] + "");

                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ia_1[2]], contacto + G_caracter_separacion_funciones_espesificas[1] + "ya fue mandado su pedido", false);
                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 2, id_atras_actual_adelante_ia_1[2] + "");
                    }
                    else
                    {
                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_pedido_ia_1[1]], "Vendedores" + G_caracter_separacion_funciones_espesificas[1] + contacto + G_caracter_separacion + pedido_sie_es_mas_de_1[1], false);

                        bas.Agregar(G_dir_arch_transferencia[id_atras_actual_adelante_ia_1[1]], contacto + G_caracter_separacion_funciones_espesificas[1] + "ya fue mandado su pedido", false);
                    }
                }



            }


            



        }

        public void datos_salida_y_borrado(string ia_ws = "ws")
        {


            if (ia_ws == "ws")//envia info de archivos respuesta y elimina la informacion
            {
                int[] id_atras_actual_adelante_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(2);//esta es de la ia
                int[] id_atras_actual_adelante_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(5);//este es del ws


                string[] respuestas = bas.Leer(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]]);

                if (id_atras_actual_adelante_1[1] == id_atras_actual_adelante_2[1])
                {


                    if (respuestas.Length > 1)
                    {


                        for (int i = G_donde_inicia_la_tabla; i < respuestas.Length; i++)
                        {
                            //preferentemente pon funciones aqui 
                            conmut.conmutar_datos(respuestas[i]);

                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]], new string[] { "sin_informacion" });
                    }
                }
                else
                {

                    if (respuestas.Length > 1)
                    {
                        for (int i = G_donde_inicia_la_tabla; i < respuestas.Length; i++)
                        {

                            //preferentemente pon funciones aqui 
                            conmut.conmutar_datos(respuestas[i]);
                            

                            
                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]], new string[] { "sin_informacion" });
                    }
                    bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 5, id_atras_actual_adelante_2[2] + "");
                }

            }

            /*este es el original ia pero usa webdriver y  solo nesesito la contestacion haci que usare el mismo que ws pero con los ids de ia
             
             if (ia_ws == "ia")//envia info de archivos respuesta y elimina la informacion
            {
                int[] id_atras_actual_adelante_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(1);//esta es de la ia
                int[] id_atras_actual_adelante_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(4);//este es del ws

                if (id_atras_actual_adelante_1[1] == id_atras_actual_adelante_2[1])
                {
                    string[] lee_preguntas_ia = bas.Leer_inicial(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]]);
                    if (1 < lee_preguntas_ia.Length)
                    {
                        for (int i = G_donde_inicia_la_tabla; i < lee_preguntas_ia.Length; i++)
                        {
                            string[] pregunta_espliteada = lee_preguntas_ia[i].Split(G_caracter_separacion_funciones_espesificas[1][0]);
                            mandar_mensage(esperar, pregunta_espliteada[1] + G_caracter_separacion_funciones_espesificas[0]);
                            Thread.Sleep(10000);
                            string textosDelMensaje = op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(leer_respuesta_ia(esperar));
                            textosDelMensaje=op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(textosDelMensaje.Split(new string[] { "\r\n" }, StringSplitOptions.None));
                            textosDelMensaje = textosDelMensaje.Replace(G_caracter_separacion[0], ":");
                            string texto_joineado = op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(textosDelMensaje, " ");
                            datos_entrada(pregunta_espliteada[0], texto_joineado);
                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]], new string[] { "sin_informacion" });

                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "config\\chatbot\\banderas.txt", 1, "0");//este le dice al chatbot que puede volver a preguntar
                    }
                }
                else
                {
                    string[] lee_preguntas_ia = bas.Leer_inicial(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]]);
                    if (1 < lee_preguntas_ia.Length)
                    {
                        for (int i = G_donde_inicia_la_tabla; i < lee_preguntas_ia.Length; i++)
                        {
                            string[] pregunta_espliteada = lee_preguntas_ia[i].Split(G_caracter_separacion_funciones_espesificas[1][0]);
                            mandar_mensage(esperar, pregunta_espliteada[1]);
                            Thread.Sleep(5000);
                            string textosDelMensaje = op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(leer_respuesta_ia(esperar));
                            textosDelMensaje = textosDelMensaje.Replace(G_caracter_separacion[0], ":");
                            string texto_joineado = op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(textosDelMensaje, " ");
                            datos_entrada(pregunta_espliteada[0], texto_joineado);
                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]], new string[] { "sin_informacion" });
                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "config\\chatbot\\banderas.txt", 1, "0");//este le dice al chatbot que puede volver a preguntar
                    }
                    bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_direccion_de_banderas_transferencias, 1, id_atras_actual_adelante_1[2] + "");
                }
                

            }
             
             */

            if (ia_ws == "ia")//envia info de archivos respuesta y elimina la informacion
            {
                int[] id_atras_actual_adelante_1 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(1);//esta es de la ia
                int[] id_atras_actual_adelante_2 = checar_numero_de_direccion_de_archivo_atras_actual_adelante(4);//este es del ws


                string[] respuestas_ia = bas.Leer(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]]);

                if (id_atras_actual_adelante_1[1] == id_atras_actual_adelante_2[1])
                {


                    if (respuestas_ia.Length > 1)
                    {


                        for (int i = G_donde_inicia_la_tabla; i < respuestas_ia.Length; i++)
                        {
                            //preferentemente pon funciones aqui 
                            conmut.conmutar_datos(respuestas_ia[i]);

                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]], new string[] { "sin_informacion" });

                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "config\\chatbot\\banderas.txt", 1, "0");//este le dice al chatbot que puede volver a preguntar
                    }
                }
                else
                {

                    if (respuestas_ia.Length > 1)
                    {
                        for (int i = G_donde_inicia_la_tabla; i < respuestas_ia.Length; i++)
                        {
                            //preferentemente pon funciones aqui 
                            conmut.conmutar_datos(respuestas_ia[i]);


                        }

                        bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_1[1]], new string[] { "sin_informacion" });
                        bas.Editar_fila_espesifica_SIN_ARREGLO_GG(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "config\\chatbot\\banderas.txt", 1, "0");//este le dice al chatbot que puede volver a preguntar
                    }
                    bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[0], 1, id_atras_actual_adelante_1[2] + "");
                }

            }


            
        }







    }
}
