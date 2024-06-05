using System;
using System.Linq;

namespace clase_QU1R30N.sin_internet.sin_formularios.herramientas
{
    class operaciones_textos
    {
        
        public string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        public string[] G_separador_para_funciones_espesificas_ = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        public string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;
        
        var_fun_GG vf_GG = new var_fun_GG();

        public string joineada_paraesida_y_quitador_de_extremos_del_string(object arreglo_objeto, object caracter_separacion_objeto = null, int restar_cuantas_ultimas_o_primeras_celdas = 0, bool restar_primera_celda = false)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);
            string[] arreglo = null;

            if (arreglo_objeto is string)
            {

                arreglo = arreglo_objeto.ToString().Split(caracter_separacion[0][0]);
                if (arreglo.Length <= 1)
                {
                    char[] arreglo_letras = arreglo_objeto.ToString().ToCharArray();
                    arreglo = new string[arreglo_letras.Length];
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        arreglo[i] = "" + arreglo_letras[i];
                    }


                }
            }
            else if (arreglo_objeto is string[])
            {
                arreglo = (string[])arreglo_objeto;
            }


            string a_retornar = "";

            if (restar_primera_celda)
            {
                if (arreglo != null)
                {


                    for (int i = restar_cuantas_ultimas_o_primeras_celdas; i < arreglo.Length; i++)
                    {
                        if (arreglo_objeto is string)
                        {
                            a_retornar = a_retornar + arreglo[i];
                        }
                        else
                        {


                            if (i < arreglo.Length - 1)
                            {

                                a_retornar = a_retornar + arreglo[i] + caracter_separacion[0];
                            }
                            else
                            {
                                a_retornar = a_retornar + arreglo[i];
                            }
                        }
                    }
                }
                

            }
            
            else
            {
                int cantidad_celdas_a_retornar_del_arreglo = arreglo.Length - restar_cuantas_ultimas_o_primeras_celdas;
                for (int i = 0; i < cantidad_celdas_a_retornar_del_arreglo; i++)
                {
                    if (i < cantidad_celdas_a_retornar_del_arreglo - 1)
                    {
                        a_retornar = a_retornar + arreglo[i] + caracter_separacion[0];
                    }
                    else
                    {
                        a_retornar = a_retornar + arreglo[i];
                    }
                }
            }

            return a_retornar;
        }


        public string joineada_paraesida_SIN_NULOS_y_quitador_de_extremos_del_string(object arreglo_objeto, object caracter_separacion_objeto = null, int restar_cuantas_ultimas_o_primeras_celdas = 0, bool restar_primera_celda = false)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);
            string[] arreglo = null;

            if (arreglo_objeto is string)
            {

                arreglo = arreglo_objeto.ToString().Split(caracter_separacion[0][0]);
                if (arreglo.Length <= 1)
                {
                    char[] arreglo_letras = arreglo_objeto.ToString().ToCharArray();
                    arreglo = new string[arreglo_letras.Length];
                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        arreglo[i] = "" + arreglo_letras[i];
                    };


                }
            }

            else if (arreglo_objeto is string[])
            {
                arreglo = (string[])arreglo_objeto;
            }


            string a_retornar = "";

            if (restar_primera_celda)
            {
                for (int i = restar_cuantas_ultimas_o_primeras_celdas; i < arreglo.Length; i++)
                {
                    if (i == 0)
                    {
                        if (arreglo[i] != null)
                        {
                            a_retornar = a_retornar + arreglo[i];
                        }

                    }
                    else
                    {
                        if (arreglo[i] != null)
                        {
                            a_retornar = a_retornar + caracter_separacion[0] + arreglo[i];

                        }

                    }
                }

            }

            else
            {
                if (arreglo != null)
                {
                    int cantidad_celdas_a_retornar_del_arreglo = arreglo.Length - restar_cuantas_ultimas_o_primeras_celdas;
                    for (int i = 0; i < cantidad_celdas_a_retornar_del_arreglo; i++)
                    {
                        if (i == 0)
                        {
                            if (arreglo[i] != null)
                            {
                                a_retornar = a_retornar + arreglo[i];
                            }
                        }
                        else
                        {
                            if (arreglo[i] != null)
                            {
                                a_retornar = a_retornar + caracter_separacion[0] + arreglo[i];
                            }
                        }
                    }
                }
                
            }

            return a_retornar;
        }

        public string Trimend_paresido(string texto, object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);

            string texto_editado = "";
            string[] texto_spliteado = texto.Split(caracter_separacion[0][0]);

            if (texto_spliteado[texto_spliteado.Length - 1] == "")
            {
                for (int i = 0; i < texto_spliteado.Length; i++)
                {
                    if (i < texto_spliteado.Length - 2)
                    {
                        texto_editado = texto_editado + texto_spliteado[i] + caracter_separacion[0];
                    }
                    else
                    {
                        texto_editado = texto_editado + texto_spliteado[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < texto_spliteado.Length; i++)
                {
                    if (i < texto_spliteado.Length - 1)
                    {
                        texto_editado = texto_editado + texto_spliteado[i] + caracter_separacion[0];
                    }

                    else
                    {
                        texto_editado = texto_editado + texto_spliteado[i];
                    }
                }
            }


            return texto_editado;
        }

        public string concatenacion_filas_de_un_archivo(string direccion_archivo, bool poner_num_fila = false, object caracter_separacion_obj = null)
        {
            Tex_base bas = new Tex_base();

            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);

            string[] num_indice_del_arreglo = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo).Split(G_caracter_para_confirmacion_o_error[0][0]);
            string texto_a_agregar_concatenacion = "";
            if (num_indice_del_arreglo[0] == "1")
            {
                int indice_arreglo_de_arreglos = Convert.ToInt32(num_indice_del_arreglo[1]);
                
                for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo_de_arreglos].Length; i++)
                {
                    string num_fil = "";
                    if (poner_num_fila)
                    {
                        num_fil = i + ") ";
                    }
                    texto_a_agregar_concatenacion = concatenacion_caracter_separacion(texto_a_agregar_concatenacion, num_fil + Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo_de_arreglos][i], caracter_separacion[0]);

                }
                
            }
            else if (num_indice_del_arreglo[0] == "0")
            {
                string[] info_a_concarenar = bas.Leer(direccion_archivo);
                for (int i = G_donde_inicia_la_tabla; i < info_a_concarenar.Length; i++)
                {
                    string num_fil = "";
                    if (poner_num_fila)
                    {
                        num_fil = i + ") ";
                    }
                    texto_a_agregar_concatenacion = concatenacion_caracter_separacion(texto_a_agregar_concatenacion, num_fil + info_a_concarenar[i], caracter_separacion[0]);

                }
            }
            else
            {
                return num_indice_del_arreglo[0] + G_caracter_para_confirmacion_o_error[0] + num_indice_del_arreglo[1];
            }
            return texto_a_agregar_concatenacion;
        }

        public string concatenacion_filas_de_un_arreglo(string[] arreglo, bool poner_num_fila = false,object caracter_separacion_obj=null)
        {

            string[] caracter_separacion=vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);

            string mensaje_de_bienvenida_a_enviar = "";
            for (int i = G_donde_inicia_la_tabla; i < arreglo.Length; i++)
            {
                string num_fil = "";
                if (poner_num_fila)
                {
                    num_fil = i + ") ";
                }
                mensaje_de_bienvenida_a_enviar = concatenacion_caracter_separacion(mensaje_de_bienvenida_a_enviar, num_fil + arreglo[i], caracter_separacion[0]);

            }
            return mensaje_de_bienvenida_a_enviar;
        }

        public string concatenacion_filas_de_un_arreglo_bidimencional(string[,] arreglo, bool poner_num_fila = false, object caracter_separacion_obj = null)
        {



            string mensaje_de_bienvenida_a_enviar = "";

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                string tiene_informacion = arreglo[i, 0];
                if (tiene_informacion != null)
                {
                    string concatenado = "";
                    for (int j = 0; j < arreglo.GetLength(1); j++)
                    {

                        concatenado = concatenacion_caracter_separacion(concatenado, arreglo[i, j], caracter_separacion_obj);

                    }


                    string num_fil = "";
                    if (poner_num_fila)
                    {
                        num_fil = i + ") ";
                    }
                    mensaje_de_bienvenida_a_enviar = concatenacion_caracter_separacion(mensaje_de_bienvenida_a_enviar, num_fil + concatenado, '\n');
                }

            }
            return mensaje_de_bienvenida_a_enviar;
        }

        public string concatenacion_caracter_separacion(string tex_a_cambiar, string tex_a_agregar, object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);

            if (tex_a_cambiar != "" && tex_a_cambiar != null)
            {
                tex_a_cambiar = tex_a_cambiar + caracter_separacion[0] + tex_a_agregar;
            }
            else
            {
                if (tex_a_cambiar == null)
                {
                    tex_a_cambiar = "";
                }
                tex_a_cambiar = tex_a_cambiar + tex_a_agregar;
            }



            return tex_a_cambiar;



        }


        public string busqueda_profunda_string(string texto, string columnas_a_recorrer, string comparar, string columnas_a_retornar = null, object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);

            string[] arr_col_rec = null;
            //caracter_separacion[0][0] el primer [0] es la celda y el segundo [0] es el caracter para no usar convert.tochar
            arr_col_rec = columnas_a_recorrer.Split(caracter_separacion[0][0]);

            string tem_linea = texto;
            string[] espliteado = null;
            int j = 0;
            do
            {

                espliteado = tem_linea.Split(caracter_separacion[j][0]);
                //caracter_separacion[j][0] el primer [j] es la celda y el segundo [0] es el caracter para no usar convert.tochar
                tem_linea = espliteado[Convert.ToInt32(arr_col_rec[j])];

                j++;
            } while (j < arr_col_rec.Length);


            //comparacion--------------------------------------------------------------------------
            if (tem_linea == comparar)
            {
                return "1" + G_caracter_para_confirmacion_o_error + texto;
            }


            return "0" + G_caracter_para_confirmacion_o_error + "no se_encontro";
        }

        public string busqueda_con_YY_profunda_texto(string texto, string columnas_a_recorrer, string comparaciones, object caracter_separacion_objeto = null, object caracter_separacion_para_busqueda_multiple_profuda_obj = null)
        {
            operaciones_arreglos op_arr = new operaciones_arreglos();
            //editar_busqueda_multiple_edicion_profunda_arreglo(texto, "2|1|1~2|1|0", "5~9", "2|1|1~1~2|1|0", "10~10~10","1~1~0");
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);

            string[] caracter_separacion_para_busqueda_multiple_profuda = vf_GG.GG_funcion_caracter_separacion_funciones_especificas(caracter_separacion_para_busqueda_multiple_profuda_obj);

            //caracter_separacion[0][0] el primer [0] es la celda y el segundo [0] es el caracter para no usar convert.tochar
            string[] arr_comparaciones_a_rec = columnas_a_recorrer.Split(caracter_separacion_para_busqueda_multiple_profuda[0][0]);
            string[] arr_comparaciones = comparaciones.Split(caracter_separacion_para_busqueda_multiple_profuda[0][0]);

            


                bool[] chequeo_todas_las_comparaciones = new bool[arr_comparaciones_a_rec.Length];

                string[][] niveles_de_profundidad = null;
                for (int l = 0; l < arr_comparaciones_a_rec.Length; l++)
                {
                    string tem_linea = texto;
                    string[] arr_col_rec = arr_comparaciones_a_rec[l].Split(caracter_separacion[0][0]);



                    if (arr_col_rec.Length > 1)
                    {

                        string temp_opciones_comp = joineada_paraesida_y_quitador_de_extremos_del_string(arr_comparaciones_a_rec[l], restar_cuantas_ultimas_o_primeras_celdas: 1);
                        string[] arr_info = op_arr.extraer_arreglo_dentro_de_un_string(tem_linea, temp_opciones_comp);
                        for (int m = 0; m < arr_info.Length; m++)
                        {
                            string[] elemento_espliteado = arr_info[m].Split(caracter_separacion[arr_col_rec.Length][0]);
                            tem_linea = elemento_espliteado[Convert.ToInt32(arr_col_rec[arr_col_rec.Length - 1])];
                        }

                    }
                    else
                    {
                        niveles_de_profundidad = op_arr.agregar_arreglo_a_arreglo_de_arreglos(niveles_de_profundidad, tem_linea.Split(caracter_separacion[0][0]));
                        tem_linea = niveles_de_profundidad[0][Convert.ToInt32(arr_col_rec[0])];
                    }
                    //string tem_linea_2 = "";
                    //comparacion--------------------------------------------------------------------------
                    chequeo_todas_las_comparaciones[l] = false;
                    if (tem_linea == arr_comparaciones[l])
                    {
                        chequeo_todas_las_comparaciones[l] = true;


                    }

                }
                bool estan_todas_las_comparaciones = true;
                for (int m = 0; m < chequeo_todas_las_comparaciones.Length; m++)
                {
                    if (chequeo_todas_las_comparaciones[m] == false)
                    {
                        estan_todas_las_comparaciones = false;
                        break;
                    }
                }
                if (estan_todas_las_comparaciones)
                {


                    return texto;
                }
            


            return null;

        }


        public string editar_incr_string_funcion_recursiva(string texto, object columnas_a_recorrer, string info_a_sustituir, string edit_0_o_increm_1 = null, object caracter_separacion_objeto = null, string caracter_separacion_dif_a_texto = null)
        {
            //string texto="0|1|2¬3°4¬5|6", object columnas_a_recorrer="2°1°1", string info_a_sustituir="10", string edit_0_o_increm_1 = "1",  string[] caracter_separacion = null, string caracter_separacion_dif_a_texto = "°"

            /*ejemplo puesto
                    string[] indices_espliteado = indices_a_editar.Split(caracter_separacion[0][0]);
                    string[] info_editar_espliteado = info_editar.Split(caracter_separacion[0][0]);
                    string[] edit_0_o_increm_1_espliteado = edit_0_o_increm_1.Split(caracter_separacion[0][0]);
                    for (int k = 0; k < indices_espliteado.Length; k++)
                    {
                        areglo[i] = editar_incr_string_funcion_recursiva(areglo[i], indices_espliteado[k], info_editar_espliteado[k], edit_0_o_increm_1_espliteado[k], caracter_separacion_dif_a_texto:"°");
                    }
            
            */
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);

            string[] espliteado_columnas_recorrer = { };

            //Sí es un string lo splitea Este normalmente es al inicio de la función 
            if (columnas_a_recorrer is string)
            {
                if (caracter_separacion_dif_a_texto == null)
                {
                    espliteado_columnas_recorrer = columnas_a_recorrer.ToString().Split(caracter_separacion[0][0]);

                }
                else
                {
                    espliteado_columnas_recorrer = columnas_a_recorrer.ToString().Split(caracter_separacion_dif_a_texto[0]);
                }

            }
            else if (columnas_a_recorrer is string[] temp)
            {

                espliteado_columnas_recorrer = temp;
            }

            string[] espliteado_texto = texto.Split(caracter_separacion[0][0]);

            //En esta parte Se inicia desde el segundo elemento y se guardan los caracteres y
            //las columnas para sí hay otro elemento En el arreglo múltiple 
            string texto_a_retornar = "";

            string[] tem_array_caracter_separacion = caracter_separacion;
            if (espliteado_columnas_recorrer.Length > 0)
            {
                string[] tem_array_col_recorrer = espliteado_columnas_recorrer;
                //espliteado_texto = texto.Split(Convert.ToChar(tem_array_caracter_separacion[0]));
                texto_a_retornar = espliteado_texto[Convert.ToInt32(tem_array_col_recorrer[0])];

                tem_array_col_recorrer = new string[espliteado_columnas_recorrer.Length - 1];
                tem_array_caracter_separacion = new string[caracter_separacion.Length - 1];
                for (int i = 1; i < espliteado_columnas_recorrer.Length; i++)
                {

                    tem_array_col_recorrer[i - 1] = espliteado_columnas_recorrer[i];

                }
                for (int i = 1; i < caracter_separacion.Length; i++)
                {
                    tem_array_caracter_separacion[i - 1] = caracter_separacion[i];
                }


                espliteado_texto[Convert.ToInt32(espliteado_columnas_recorrer[0])] = editar_incr_string_funcion_recursiva(texto_a_retornar, tem_array_col_recorrer, info_a_sustituir, edit_0_o_increm_1, tem_array_caracter_separacion); // Llamada recursiva


            }
            else
            {
                if (edit_0_o_increm_1 == "1")
                {
                    espliteado_texto[0] = "" + (Convert.ToDouble(espliteado_texto[0]) + Convert.ToDouble(info_a_sustituir));
                }
                else
                {
                    espliteado_texto[0] = info_a_sustituir;
                }

            }

            string retornar = string.Join(caracter_separacion[0], espliteado_texto);
            return retornar;
        }

        public string editar_inc_busqueda_multiple_edicion_profunda_string(string texto, string indices_a_editar, string info_editar, string edit_0_o_increm_1 = null, object caracter_separacion_objeto = null, string caracter_separacion_para_busqueda_multiple_profuda_objeto = null)
        {
            //editar_busqueda_multiple_edicion_profunda_arreglo(texto, "2|1|1~1~2|1|0", "10~10~10","1~1~0");
            string[] caracter_separacion = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_objeto);
            string[] caracter_separacion_para_busqueda_multiple_profuda = vf_GG.GG_funcion_caracter_separacion_funciones_especificas(caracter_separacion_para_busqueda_multiple_profuda_objeto);


            string[] indices_espliteado = indices_a_editar.Split(caracter_separacion_para_busqueda_multiple_profuda[0][0]);
            string[] info_editar_espliteado = info_editar.Split(caracter_separacion_para_busqueda_multiple_profuda[0][0]);
            string[] edit_0_o_increm_1_espliteado = edit_0_o_increm_1.Split(caracter_separacion_para_busqueda_multiple_profuda[0][0]);
            for (int k = 0; k < indices_espliteado.Length; k++)
            {
                texto = editar_incr_string_funcion_recursiva(texto, indices_espliteado[k], info_editar_espliteado[k], edit_0_o_increm_1_espliteado[k], caracter_separacion_dif_a_texto: caracter_separacion_para_busqueda_multiple_profuda[0]);
            }

            return texto;

        }

    }
}