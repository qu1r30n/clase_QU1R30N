using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.herramientas
{
    class var_fun_GG
    {


        static public int GG_indice_donde_comensar = 1;

        static public string[] GG_caracter_separacion = { "|", "°", "¬", "^" };

        static public string[] GG_caracter_separacion_funciones_espesificas = { "~", "§", "¶" };

        static public string[] GG_caracter_para_confirmacion_o_error = { "╣" };

        //funciones---------------------------------------------------------------------------------------------------------

        public string[] GG_funcion_caracter_separacion(object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = null;
            if (caracter_separacion_objeto == null)
            {
                caracter_separacion = GG_caracter_separacion;
            }
            else
            {
                if (caracter_separacion_objeto is char)
                {
                    caracter_separacion = new string[] { caracter_separacion_objeto + "" };
                }
                if (caracter_separacion_objeto is string)
                {
                    if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[0])
                    {
                        caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][0]);
                    }
                    else
                    {
                        caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[1][0]);
                    }

                }
                if (caracter_separacion_objeto is string[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
            }

            return caracter_separacion;

        }

        

        public string[] GG_funcion_caracter_separacion_funciones_especificas(object caracter_separacion_objeto = null)
        {
            string[] caracter_separacion = null;
            if (caracter_separacion_objeto == null)
            {
                caracter_separacion = GG_caracter_separacion_funciones_espesificas;
            }
            else
            {
                if (caracter_separacion_objeto is char)
                {
                    //caracter_separacion = new string[] { caracter_separacion_objeto + "" };
                    for (int i = 0; i < GG_caracter_separacion_funciones_espesificas.Length; i++)
                    {
                        if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[i])
                        {
                            caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][i]);
                            return caracter_separacion;
                        }
                    }

                }
                if (caracter_separacion_objeto is string)
                {
                    for (int i = 0; i < GG_caracter_separacion_funciones_espesificas.Length; i++)
                    {
                        if (caracter_separacion_objeto.ToString() != GG_caracter_separacion_funciones_espesificas[i])
                        {
                            caracter_separacion = caracter_separacion_objeto.ToString().Split(GG_caracter_separacion_funciones_espesificas[0][i]);
                            return caracter_separacion;
                        }
                    }
                }
                if (caracter_separacion_objeto is string[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
                if (caracter_separacion_objeto is char[])
                {
                    caracter_separacion = (string[])caracter_separacion_objeto;
                }
            }

            return caracter_separacion;

        }

        //movimientos a repetir esto es mas para la aplicacion del celular para pasarlo al de la computadora y mejorar
        //tienes que poner en datos la informacion de_las_variables si es un arreglo usa el join paresido y agregale un GG_separador_para_funciones_espesificas
        public string GG_movimientos_a_repetir(string direccion, string datos, bool guardar_movimiento = false)
        {
            if (guardar_movimiento == true)
            {


                Tex_base bas = new Tex_base();
                operaciones_textos op_textos = new operaciones_textos();
                string carpetas = op_textos.joineada_paraesida_y_quitador_de_extremos_del_string(direccion, "\\", 2);

                bas.Agregar(direccion, datos,false);

                return datos;
            }
            return null;
        }

        //registro para control de ventas compras y todo
        public string GG_registros(string direccion, object datos)
        {
            Tex_base bas = new Tex_base();
            operaciones_textos op_textos = new operaciones_textos();
            string carpetas = op_textos.joineada_paraesida_y_quitador_de_extremos_del_string(direccion, "\\", 2);

            string info_a_retornar = "";
            if (datos is string)
            {

                bas.Agregar(direccion, (string)datos,false);
                info_a_retornar = (string)datos;
                return info_a_retornar;
            }
            else if (datos is string[])
            {
                string[] temp = (string[])datos;
                bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(carpetas + "\\", "datos", leer_y_agrega_al_arreglo: false);
                for (int i = 0; i < temp.Length; i++)
                {
                    bas.Agregar(direccion, temp[i],false);
                    info_a_retornar = info_a_retornar + temp[i] + "\n";
                }
                return info_a_retornar;
            }
            return null;
        }


        public object GG_retorno_de_datos(object variable_a_la_que_devolvera, string respuesta_devolver_texto = null, string respuesta_devolver_verdadero_1_falso_0 = null, string respuesta_devolver_numer = null, string[] respuesta_devolver_arreglo_texto = null, string[] respuesta_devolver_arreglo_verdadero_1_falso_0 = null, string[] respuesta_devolver_arreglo_numer = null)
        {
            if (variable_a_la_que_devolvera is string)
            {
                if (respuesta_devolver_arreglo_texto!=null)
                {
                    return respuesta_devolver_texto;
                }
            }
            else if (variable_a_la_que_devolvera is bool)
            {
                
                if (respuesta_devolver_verdadero_1_falso_0 != null)
                {
                    bool valor_retornar = false;
                    if (respuesta_devolver_verdadero_1_falso_0=="1")
                    {
                        valor_retornar = true;
                    }
                    return valor_retornar;
                }
            }
            else if (variable_a_la_que_devolvera is double || variable_a_la_que_devolvera is int)
            {
                if (respuesta_devolver_numer != null)
                {
                    return Convert.ToDouble(respuesta_devolver_numer);
                }
            }
            else if (variable_a_la_que_devolvera is string[])
            {
                if (respuesta_devolver_arreglo_texto != null)
                {
                    return respuesta_devolver_arreglo_texto;
                }
            }
            else if (variable_a_la_que_devolvera is bool[])
            {
                if (respuesta_devolver_arreglo_verdadero_1_falso_0 != null)
                {
                    bool[] temp = new bool[respuesta_devolver_arreglo_verdadero_1_falso_0.Length];
                    for (int i = 0; i < respuesta_devolver_arreglo_verdadero_1_falso_0.Length; i++)
                    {
                        temp[i] = false;
                        if (respuesta_devolver_arreglo_verdadero_1_falso_0[i]=="1")
                        {
                            temp[i] = true;
                        }
                        
                    }
                    return temp;
                }
            }
            else if (variable_a_la_que_devolvera is double[] || variable_a_la_que_devolvera is int[])
            {
                if (respuesta_devolver_arreglo_numer != null)
                {
                    double[] temp = new double[respuesta_devolver_arreglo_numer.Length];
                    for (int i = 0; i < respuesta_devolver_arreglo_numer.Length; i++)
                    {
                        temp[i] = Convert.ToDouble(respuesta_devolver_arreglo_numer[i]);
                    }
                }
            }

            return null;

        }

    }
}
