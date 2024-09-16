using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_transferencia_entre_archivos = var_fun_GG.GG_caracter_para_transferencia_entre_archivos;

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


        public void datos_a_enviar(string folio_o_palbra_clave_a_del_que_lo_recibira, string info, string programa_enviar = "NEXOPORTALARCANO")
        {
            //E_2_5_ia
            //segun 3_6 es para peticiones o talves otro programa como otra conexion ws pero creo que es exesivo

            string info_a_enviar = programa_enviar + G_caracter_para_transferencia_entre_archivos[0] + var_fun_GG.GG_id_programa + G_caracter_para_transferencia_entre_archivos[1] + folio_o_palbra_clave_a_del_que_lo_recibira + G_caracter_para_transferencia_entre_archivos[1] + info;


            bas.Agregar(G_dir_arch_transferencia[8], info_a_enviar, false);





        }

        public void datos_recibidos_a_procesar_y_borrar(string ia_ws)
        {
            //S_1_4_ia
            if (ia_ws == "IA")//envia info de archivos respuesta y elimina la informacion
            {
                
                string[] respuestas_ia = bas.Leer(G_dir_arch_transferencia[7]);




                if (respuestas_ia.Length > 1)
                {
                    for (int i = G_donde_inicia_la_tabla; i < respuestas_ia.Length; i++)
                    {
                        string[] id_programa_comparar = respuestas_ia[i].Split(G_caracter_para_transferencia_entre_archivos[0][0]);
                        if (id_programa_comparar[0] == var_fun_GG.GG_id_programa)
                        {

                            //preferentemente pon funciones aqui 
                            conmut.conmutar_datos(respuestas_ia[i]);
                        }

                    }

                    bas.eliminar_fila_PARA_MULTIPLES_PROGRAMAS(G_dir_arch_transferencia[7], 0, var_fun_GG.GG_id_programa, G_caracter_para_transferencia_entre_archivos[0]);
                    //bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]], new string[] { "sin_informacion" });

                }
                

            }


            



            else
            {

            }




        }







    }
}
