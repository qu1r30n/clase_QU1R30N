﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace clase_QU1R30N.sin_internet.sin_formularios.herramientas
{
    class Tex_base
    {
        //para funciones globales
        
        var_fun_GG vf_GG = new var_fun_GG();
        
        //bases de datos
        static public string[][] GG_base_arreglo_de_arreglos = null;

        //direcciones_de_las_bases
        static public string[,] GG_dir_bd_y_valor_inicial_bidimencional = null;

        //[0]=indice desde donde comensara desde el 0 nombre de las columnas y es mejor empesar desde el 1
        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;
        
        //caracteres de separacion//el primero lo usaremos diferente NO USAR LOS MISMOS QUE G_separador_para_funciones_espesificas;
        /*
        public string[] G_caracter_separacion = { "|", "°", "¬", "^" };
        public string[] G_separador_para_funciones_espesificas = { "~", "§", "¶", "╣"};
        */
        public string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        public string[] G_separador_para_funciones_espesificas_ = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        public string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        /*Aquí poner las funciones de las otras clases Si te vas a llevar esta clase solamente --------------------------------
       Ver poniendo también los nombres de las funciones que estás usando para no pasar toda la clase -----------------------
       Próstata también el nombre de la clase para saber de qué clase se está sacando las funciones -------------------------
       */
        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();

        //fin Aquí poner las funciones de las otras clases Si te vas a llevar esta clase solamente --------------------------------

        //filas: es para filas iniciales valor_inicial: se utilisa para poner filas inicial normalmente se usa para poner el nombre de las columnas
        public string Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(string direccion_archivo, string valor_inicial = null, string[] filas_iniciales = null, object caracter_separacion_fun_esp_objeto = null, bool leer_y_agrega_al_arreglo = true)
        {
            string[] caracter_separacion_fun_esp = vf_GG.GG_funcion_caracter_separacion_funciones_especificas(caracter_separacion_fun_esp_objeto);

            char[] parametro2 = { '/', '\\' };//estos seran los parametros de separacion de el split
            string acumulador_directorios_y_archvo = "";
            string[] direccion_espliteada = direccion_archivo.Split(parametro2);//spliteamos la direccion
            bool creo_algo = false;

            for (int i = 0; i < direccion_espliteada.Length; i++)//pasamos por todas las los directorios y archivo
            {
                if (i < direccion_espliteada.Length - 1)//el path muestra 6 palabras que fueron espliteadas se le resta uno por que los arreglos empiesan desde 0 y solo se le pone el menor que por que la ultima palabra es el archivo
                {
                    acumulador_directorios_y_archvo = acumulador_directorios_y_archvo + direccion_espliteada[i] + "\\"; // va acumulando los directorios a los que va a entrar ejemplo: ventas\\   ventas\\2016    ventas\\2016\\        ventas\\2016\\11      ventas\\2016\\11\\dias\\  y no muestra el ultimo por que es el archivo y en el if  le dijimos que lo dejara en el penultimo
                    if (!Directory.Exists(acumulador_directorios_y_archvo))//si el directorio no existe entrara y lo creara
                    {

                        Directory.CreateDirectory(acumulador_directorios_y_archvo);//crea el directorio
                        creo_algo = true;
                    }
                }
            }

            if (direccion_espliteada[direccion_espliteada.Length - 1] != "")//checa si escribio tambien el archivo o solo carpetas
            {
                if (!File.Exists(direccion_archivo))//si el archivo no existe entra y lo crea
                {

                    FileStream fs0 = new FileStream(direccion_archivo, FileMode.CreateNew);//crea una variable tipo filestream "fs0"  y crea el archivo
                    fs0.Close();//cierra fs0 para que se pueda usar despues



                    if (valor_inicial != null)// si al llamar a la funcion  le pusiste valor_inicial las escribe //se utilisa para que sea como un titulo o un eslogan pero lo utilisaremos en este prog
                    {
                        Agregar(direccion_archivo, valor_inicial,false);//escribe aqui el valor inicial si es que lo pusiste
                    }

                    if (filas_iniciales != null)//si al llamar a la funcion le pusistes columnas a agregar//recuerda que se separan por comas
                    {
                        if (filas_iniciales.Length == 1 && filas_iniciales[0] == "")
                        {

                        }
                        else
                        {
                            for (int i = 0; i < filas_iniciales.Length; i++)
                            {
                                Agregar(direccion_archivo, filas_iniciales[i],false);//agrega las filas
                            }
                        }

                    }


                    creo_algo = true;
                }
                //si crea ele archivo lee el archivo
                if (leer_y_agrega_al_arreglo)
                {
                    GG_dir_bd_y_valor_inicial_bidimencional = op_arr.agregar_registro_del_array_bidimensional(GG_dir_bd_y_valor_inicial_bidimencional, direccion_archivo + caracter_separacion_fun_esp[0] + valor_inicial, caracter_separacion_fun_esp);
                    GG_base_arreglo_de_arreglos = op_arr.agregar_arreglo_a_arreglo_de_arreglos(GG_base_arreglo_de_arreglos, Leer(direccion_archivo));
                    return direccion_archivo + G_caracter_separacion[0] + "leido";
                }
            }
            if (creo_algo)
            {
                return direccion_archivo;
            }

            return null;
        }

        public string Agregar(string direccion_archivos, string agregando,bool con_arreglo_GG=true)
        {

            string info_a_retornar = "";

            if (con_arreglo_GG)
            {
                string resultado_indice_de_direccion = sacar_indice_del_arreglo_de_direccion(direccion_archivos);
                string[] res_indice_espliteado = resultado_indice_de_direccion.Split(G_caracter_para_confirmacion_o_error[0][0]);
                if (Convert.ToInt32(res_indice_espliteado[0])>0)
                {


                    if (res_indice_espliteado[0] == "1")
                    {

                        int num_indice_de_direccion_int = Convert.ToInt32(res_indice_espliteado[1]);
                        GG_base_arreglo_de_arreglos[num_indice_de_direccion_int] = op_arr.agregar_registro_del_array(GG_base_arreglo_de_arreglos[num_indice_de_direccion_int], agregando);

                        info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + agregando;

                    }
                }
                
                else
                {
                    if (res_indice_espliteado[1] == "0")
                    {
                        return "0" + G_caracter_para_confirmacion_o_error[0] + "no encontro archivo";
                    }
                    else if (res_indice_espliteado[1] == "-1")
                    {
                        info_a_retornar= "2" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion en la lista de direcciones pero lo agrego al archivo";
                    }
                    
                }
            }

            
            StreamWriter sw = new StreamWriter(direccion_archivos, true);
            sw.WriteLine(agregando);
            sw.Close();

            return info_a_retornar;
            
        }

        public string Agregar_sino_existe
            (string direccion_archivo_a_checar, int num_column_comp, string comparar, string texto_a_agregar_si_no_esta = "", object caracter_separacion_obj = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";

            string direccion_archivo = direccion_archivo_a_checar;
            string resultado_archivo = sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);

            //encontro o no archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                //encontro archivo y direccion en la lista
                if (res_esp_archivo[0] == "1")
                {

                    int num_indice_de_direccion_int = Convert.ToInt32(res_esp_archivo[1]);
                    bool encotro_info = false;
                    
                    for (int i = G_donde_inicia_la_tabla; i < GG_base_arreglo_de_arreglos[num_indice_de_direccion_int].Length; i++)
                    {

                        string resul_busqueda = op_tex.busqueda_profunda_string(GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i], "" + num_column_comp, comparar);
                        string[] res_esp = resul_busqueda.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro la informacion?
                        if (Convert.ToInt32(res_esp[0]) > 0)
                        {
                            if (res_esp[0] == "1")
                            {
                                info_a_retornar = "-4" + G_caracter_para_confirmacion_o_error[0] + "la informacion ya existe";
                                encotro_info = true;
                                break;
                            }
                        }


                    }
                    //no encontro la info
                    if (encotro_info == false)
                    {
                        if (texto_a_agregar_si_no_esta != "")
                        {
                            Agregar(direccion_archivo, texto_a_agregar_si_no_esta);
                            info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + "agrego_la_informacion";
                        }
                        else
                        {
                            info_a_retornar = "-3" + G_caracter_para_confirmacion_o_error[0] + "no encontro el dato y no se puede agregar por que la variable texto_a_agregar_si_no_esta esta vacia";
                        }

                    }
                }

            }

            else
            {
                //no encontro archivo
                if (res_esp_archivo[0] == "0")
                {
                    info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro el archivo";
                }
                //solo encontro archivo y no esta en la lista
                if (res_esp_archivo[0] == "-1")
                {
                    string[] inventario = Leer(direccion_archivo);
                    for (int i = G_donde_inicia_la_tabla; i < inventario.Length; i++)
                    {
                        string[] columnas = inventario[i].Split(caracter_separacion[0][0]);

                        if (columnas[num_column_comp] == comparar)
                        {


                            cambiar_archivo_con_arreglo(direccion_archivo, inventario);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + inventario[i];
                            break;
                        }
                    }

                }

            }

            return info_a_retornar;
        }


        public string Editar_incr_o_agrega_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
            (string direccion_archivo_a_checar, int num_column_comp, string comparar, string numero_columnas_editar, string editar_columna, string comparar_columna_a_editar, string edit_0_increm_1_o_agregar_si_no_esta_2, string texto_a_agregar_si_no_esta = "", object caracter_separacion_obj = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";

            string direccion_archivo = direccion_archivo_a_checar;
            string resultado_archivo = sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);

            //encontro o no archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                //encontro archivo y direccion en la lista
                if (res_esp_archivo[0] == "1")
                {

                    int num_indice_de_direccion_int = Convert.ToInt32(res_esp_archivo[1]);
                    bool encotro_info = false;
                    for (int i = G_donde_inicia_la_tabla; i < GG_base_arreglo_de_arreglos[num_indice_de_direccion_int].Length; i++)
                    {

                        string resul_busqueda = op_tex.busqueda_profunda_string(GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i], "" + num_column_comp, comparar);
                        string[] res_esp = resul_busqueda.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro la informacion?
                        if (Convert.ToInt32(res_esp[0]) > 0)
                        {
                            if (res_esp[0] == "1")
                            {
                                GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i] = 
                                    op_tex.editar_inc_agregar_edicion_profunda_multiple_comparacion_final_string
                                    (
                                        res_esp[1], 
                                        numero_columnas_editar, 
                                        editar_columna, 
                                        comparar_columna_a_editar, 
                                        edit_0_increm_1_o_agregar_si_no_esta_2
                                        );
                                
                                
                                cambiar_archivo_con_arreglo(direccion_archivo, GG_base_arreglo_de_arreglos[num_indice_de_direccion_int]);
                                info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i];
                                encotro_info = true;
                                break;
                            }
                        }


                    }
                    //no encontro la info
                    if (encotro_info == false)
                    {
                        if (texto_a_agregar_si_no_esta!="")
                        {
                            Agregar(direccion_archivo, texto_a_agregar_si_no_esta);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + "agrego_la_informacion";
                        }
                        else
                        {
                            info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no encontro el dato y no se puede agregar por que la variable texto_a_agregar_si_no_esta esta vacia";
                        }
                        
                    }
                }
                
            }

            else
            {
                //no encontro archivo
                if (res_esp_archivo[0] == "0")
                {
                    info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro el archivo";
                }
                //solo encontro archivo y no esta en la lista
                if (res_esp_archivo[0] == "-1")
                {
                    string[] inventario = Leer(direccion_archivo);
                    for (int i = G_donde_inicia_la_tabla; i < inventario.Length; i++)
                    {
                        string[] columnas = inventario[i].Split(caracter_separacion[0][0]);

                        if (columnas[num_column_comp] == comparar)
                        {

                            inventario[i] = op_tex.editar_inc_edicion_profunda_multiple_string(inventario[i], numero_columnas_editar, editar_columna, edit_0_increm_1_o_agregar_si_no_esta_2);

                            cambiar_archivo_con_arreglo(direccion_archivo, inventario);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + inventario[i];
                            break;
                        }
                    }

                }

            }

            return info_a_retornar;
        }

        public string Editar_incr_o_agrega_MULTIPLESCOMPARACIONES_AL_FINAL_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
            (string direccion_archivo, int num_column_comp, string comparar, string numero_columnas_editar, string comparar_y_edicion_COMPARACION_FINAL, string edit_0_increm_1_o_agregar_si_no_esta_2, string texto_a_agregar_si_no_esta = "", object caracter_separacion_obj = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";

            
            string resultado_archivo = sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);

            //encontro o no archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                //encontro archivo y direccion en la lista
                if (res_esp_archivo[0] == "1")
                {

                    int num_indice_de_direccion_int = Convert.ToInt32(res_esp_archivo[1]);
                    bool encotro_info = false;
                    for (int i = G_donde_inicia_la_tabla; i < GG_base_arreglo_de_arreglos[num_indice_de_direccion_int].Length; i++)
                    {

                        string resul_busqueda = op_tex.busqueda_profunda_string(GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i], "" + num_column_comp, comparar);
                        string[] res_esp = resul_busqueda.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro el dato?
                        if (Convert.ToInt32(res_esp[0]) > 0)
                        {
                            if (res_esp[0] == "1")
                            {
                                

                                GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i] = 
                                    op_tex.editar_inc_agregar_edicion_profunda_multiple_comparacion_final_MULTIPLE_A_CHECAR_string
                                    (res_esp[1], numero_columnas_editar,  comparar_y_edicion_COMPARACION_FINAL, edit_0_increm_1_o_agregar_si_no_esta_2);


                                cambiar_archivo_con_arreglo(direccion_archivo, GG_base_arreglo_de_arreglos[num_indice_de_direccion_int]);
                                info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i];
                                encotro_info = true;
                                break;
                            }
                        }


                    }
                    //no encontro la info
                    if (encotro_info == false)
                    {
                        if (texto_a_agregar_si_no_esta != "")
                        {
                            Agregar(direccion_archivo, texto_a_agregar_si_no_esta);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + "agrego_la_informacion";
                        }
                        else
                        {
                            info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no encontro el dato y no se puede agregar por que la variable texto_a_agregar_si_no_esta esta vacia";
                        }

                    }
                }

            }

            else
            {
                //no encontro archivo
                if (res_esp_archivo[0] == "0")
                {
                    info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro el archivo";
                }
                //solo encontro archivo y no esta en la lista
                if (res_esp_archivo[0] == "-1")
                {
                    string[] inventario = Leer(direccion_archivo);
                    for (int i = G_donde_inicia_la_tabla; i < inventario.Length; i++)
                    {
                        string[] columnas = inventario[i].Split(caracter_separacion[0][0]);

                        if (columnas[num_column_comp] == comparar)
                        {

                            inventario[i] = op_tex.editar_inc_edicion_profunda_multiple_string(inventario[i], numero_columnas_editar, comparar_y_edicion_COMPARACION_FINAL, edit_0_increm_1_o_agregar_si_no_esta_2);

                            cambiar_archivo_con_arreglo(direccion_archivo, inventario);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + inventario[i];
                            break;
                        }
                    }

                }

            }

            return info_a_retornar;
        }


        public string Editar_incr_o_agrega_COMPARACION_YY_info_dentro_de_celda_Y_AGREGA_fila_SI_NO_ESTA_y_no_es_vacia_la_variable_es_multiple_con_comparacion_final
    (string direccion_archivo_a_checar, string num_column_comp, string comparar, string numero_columnas_editar, string comparar_con_editar_columna,  string edit_0_increm_1_o_agregar_si_no_esta_2, string texto_a_agregar_si_no_esta = "", object caracter_separacion_obj = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            

            string info_a_retornar = "";

            string direccion_archivo = direccion_archivo_a_checar;
            string resultado_archivo = sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp_archivo = resultado_archivo.Split(G_caracter_para_confirmacion_o_error[0][0]);

            //encontro o no archivo
            if (Convert.ToInt32(res_esp_archivo[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {
                //encontro archivo y direccion en la lista
                if (res_esp_archivo[0] == "1")
                {

                    int num_indice_de_direccion_int = Convert.ToInt32(res_esp_archivo[1]);
                    bool encotro_info = false;
                    for (int i = G_donde_inicia_la_tabla; i < GG_base_arreglo_de_arreglos[num_indice_de_direccion_int].Length; i++)
                    {

                        string resul_busqueda = op_tex.busqueda_con_YY_profunda_texto(GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i], "" + num_column_comp, comparar);
                        string[] res_esp = resul_busqueda.Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontor informacion?
                        if (Convert.ToInt32(res_esp[0]) > 0)
                        {
                            if (res_esp[0] == "1")
                            {
                                GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i] 
                                    = op_tex.editar_inc_agregar_edicion_profunda_multiple_comparacion_final_MULTIPLE_A_CHECAR_string
                                    (res_esp[1], 
                                    numero_columnas_editar, 
                                    comparar_con_editar_columna,  
                                    edit_0_increm_1_o_agregar_si_no_esta_2);

                                cambiar_archivo_con_arreglo(direccion_archivo, GG_base_arreglo_de_arreglos[num_indice_de_direccion_int]);
                                info_a_retornar = "1" + G_caracter_para_confirmacion_o_error[0] + GG_base_arreglo_de_arreglos[num_indice_de_direccion_int][i];
                                encotro_info = true;
                                break;
                            }
                        }


                    }
                    //no encontro la info
                    if (encotro_info == false)
                    {
                        if (texto_a_agregar_si_no_esta != "")
                        {
                            Agregar(direccion_archivo, texto_a_agregar_si_no_esta);
                            info_a_retornar = "2" + G_caracter_para_confirmacion_o_error[0] + "agrego_la_informacion";
                        }
                        else
                        {
                            info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no encontro el dato y no se puede agregar por que la variable texto_a_agregar_si_no_esta esta vacia";
                        }

                    }
                }

            }

            else
            {
                //no encontro archivo
                if (res_esp_archivo[0] == "0")
                {
                    info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro el archivo";
                }
                

            }

            return info_a_retornar;
        }



        public string Editar_fila_espesifica_SIN_ARREGLO_GG(string direccion_archivo, int num_fila, string editar_info)
        {


            StreamReader sr = new StreamReader(direccion_archivo);
            string dir_tem = direccion_archivo.Replace(".txt", "_tem.txt");
            StreamWriter sw = new StreamWriter(dir_tem, true);
            string exito_o_fallo;

            try
            {
                int id_linea = 0;

                while (sr.Peek() >= 0)//verificamos si hay mas lineas a leer
                {
                    string linea = sr.ReadLine();//leemos linea y lo guardamos en palabra
                    if (linea != null)
                    {

                        if (id_linea == num_fila)
                        {
                            sw.WriteLine(editar_info);

                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }

                        id_linea++;
                    }
                }
                exito_o_fallo = "1)exito";
                sr.Close();
                sw.Close();
                File.Delete(direccion_archivo);//borramos el archivo original
                File.Move(dir_tem, direccion_archivo);//renombramos el archivo temporal por el que tenia el original

            }
            catch (Exception error)
            {
                sr.Close();
                sw.Close();
                exito_o_fallo = "2)error:" + error;
                File.Delete(dir_tem);//borramos el archivo original
            }
            return exito_o_fallo;
        }



        public string[] Leer(string direccionArchivo, string posString = null, object caracter_separacion_objeto = null, int iniciar_desde_que_fila = 0)
        {

            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);


            // Declaración de variables
            string[] linea = null;      // Almacenará todas las líneas cuando posString sea null
            string[] resultado = null;  // Almacenará el resultado final cuando posString no sea null
            string[] posSplit;
            int[] posiciones;

            string palabra = null;

            // Crear un objeto StreamReader para leer el archivo
            StreamReader sr = new StreamReader(direccionArchivo);

            // Si posString es null, se lee el archivo línea por línea y se agrega cada línea a "linea"
            if (posString == null)
            {
                while ((palabra = sr.ReadLine()) != null)
                {
                    if (palabra != "")
                    {
                        linea = op_arr.agregar_registro_del_array(linea, palabra);
                    }
                }
            }
            // Si posString no es null, se extraen las columnas especificadas y se agregan a "resultado"
            else
            {
                posSplit = posString.Split(caracter_separacion[0][0]);
                posiciones = new int[posSplit.Length];

                // Convertir las posiciones de las columnas de string a int
                for (int i = 0; i < posiciones.Length; i++)
                {
                    posiciones[i] = Convert.ToInt32(posSplit[i]);
                }

                // Leer el archivo línea por línea y procesar según las posiciones especificadas
                for (int i = 0; (palabra = sr.ReadLine()) != null; i++)
                {
                    string[] splLinea = palabra.Split(caracter_separacion[0][0]);

                    palabra = "";
                    for (int j = 0; j < posiciones.Length; j++)
                    {
                        if (j < posiciones.Length - 1)
                        {
                            palabra = palabra + splLinea[posiciones[j]] + caracter_separacion[0];
                        }
                        else
                        {
                            palabra = palabra + splLinea[posiciones[j]];
                        }
                    }

                    // Agregar la palabra procesada al arreglo "resultado"
                    resultado = op_arr.agregar_registro_del_array(resultado, palabra);
                }

            }

            // Cerrar el StreamReader ya que se ha completado el procesamiento
            sr.Close();

            
            if (linea!=null)
            {

                if ((linea.Length - iniciar_desde_que_fila) > 0)
                {


                    // Copiar el contenido de "linea" a un nuevo arreglo para evitar referencias no deseadas
                    string[] arreglo_a_retornar = new string[linea.Length- iniciar_desde_que_fila];
                    for (int k = iniciar_desde_que_fila; k < linea.Length; k++)
                    {
                        arreglo_a_retornar[k - iniciar_desde_que_fila] = "" + linea[k];
                    }

                    // Devolver el resultado
                    return arreglo_a_retornar;
                }
                else { return null; }
            }
            else
            {
                return null;
            }
        }

        public string sacar_indice_del_arreglo_de_direccion(string direccion_archivo)
        {
            if (File.Exists(direccion_archivo))
            {
                
                string num_indice_de_direccion = null;
                for (int i = G_donde_inicia_la_tabla; i < GG_dir_bd_y_valor_inicial_bidimencional.GetLength(0); i++)
                {
                    if (GG_dir_bd_y_valor_inicial_bidimencional[i, 0] == direccion_archivo)
                    {
                        num_indice_de_direccion = "" + i;
                        return "1" + G_caracter_para_confirmacion_o_error[0] + num_indice_de_direccion;
                    }
                }
                return "-1" + G_caracter_para_confirmacion_o_error[0] + "no esta dentro de la lista de nombres";
                
            }
            else
            {
                return "0" + G_caracter_para_confirmacion_o_error[0] + "no existe el archivo";
            }
        }

        public string cambiar_archivo_con_arreglo(string direccion_archivo, string[] arreglo, object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);


            string exito_o_fallo = "";
            string dir_tem = "tem.txt";
            StreamWriter sw = new StreamWriter(dir_tem, true);
            try
            {

                for (int i = 0; i < arreglo.Length; i++)
                {
                    sw.WriteLine(arreglo[i]);
                }
                exito_o_fallo = "1" + G_caracter_para_confirmacion_o_error[0] + "exito";
            }
            catch (Exception e)
            {

                exito_o_fallo = "0" + G_caracter_para_confirmacion_o_error[0] + "fallo: " + e;

            }


            sw.Close();
            File.Delete(direccion_archivo);//borramos el archivo original
            File.Move(dir_tem, direccion_archivo);//renombramos el archivo temporal por el que tenia el original

            return exito_o_fallo;
        }


        public string[] extraer_separado_carpetas_nombreArchivo_extencion(string direccion_archivo)
        {
            string[] arreglo_retornar = new string[2];


            string[] direccion_esp = direccion_archivo.Split('\\');
            string[] nom_ext_esp = direccion_esp[direccion_esp.Length - 1].Split('.');
            if (nom_ext_esp.Length>1)
            {
                string carpetas = op_tex.joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(direccion_archivo, '\\', 1);
                string nombre = nom_ext_esp[0];
                string extencion = nom_ext_esp[1];
                arreglo_retornar[0] = carpetas;
                arreglo_retornar[1] = nombre;
                arreglo_retornar[2] = extencion;
            }
            else
            {

            }
            

            return arreglo_retornar;
        }


    }
}
