using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{

    internal class _4_proceso_aprendices_E
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();

        public string registro_aprendices_E_cod3_r_(string direccion_archivo, string datos, object caracter_separacion_obj = null)
        {

            string[] caracter_separacion_string = vf_GG.GG_funcion_caracter_separacion(caracter_separacion_obj);
            string info_a_retornar = "";


            string direccion_archivo_aprendices_E = direccion_archivo;
            string resultado_archivo_aprendices_E = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo_aprendices_E);
            string[] res_esp_archivo_E = resultado_archivo_aprendices_E.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_esp_archivo_E[0]) > 0)//si res es mayor a 0 la operacioon fue exitosa si no hubo un error
            {

                string[] datos_espliteado = datos.Split(caracter_separacion_string[0][0]);


                string ID = "";
                string resul_agregue = "";
                bool esta_arreglo = false;
                if (res_esp_archivo_E[0] == "1")
                {
                    int indic_aprendiz_E = Convert.ToInt32(res_esp_archivo_E[1]);
                    ID = "" + Tex_base.GG_base_arreglo_de_arreglos[indic_aprendiz_E].Length;
                    resul_agregue = "1";
                    esta_arreglo = true;
                    
                }
                else if (res_esp_archivo_E[0] == "-1")
                {
                    ID = "" + bas.Leer(direccion_archivo_aprendices_E).Length;
                    resul_agregue = "2";
                    esta_arreglo = false;
                }



                string Nombre = datos_espliteado[0];
                string Apellido_paterno = datos_espliteado[1];
                string Apellido_materno = datos_espliteado[2];
                string Fecha_de_nacimiento = datos_espliteado[3];
                string Género = datos_espliteado[4];
                string Dirección = datos_espliteado[5];
                string Ciudad = datos_espliteado[6];
                string Estado_Provincia = datos_espliteado[7];
                string Código_postal = datos_espliteado[8];
                string País = datos_espliteado[9];
                string Correo_electrónico = datos_espliteado[10];
                string Teléfono = datos_espliteado[11];
                string Fecha_de_ingreso = datos_espliteado[12];
                string Sueldo = datos_espliteado[13];
                string Cargo = datos_espliteado[14];
                string Estado_de_aprendis_E = datos_espliteado[15];
                string Supervisor = datos_espliteado[16];
                string Notas = datos_espliteado[17];
                string Afiliado = datos_espliteado[18];
                string Fecha_de_terminación = datos_espliteado[19];
                string Motivo_de_terminación = datos_espliteado[20];
                string Horas_trabajadas = datos_espliteado[21];
                string Evaluaciones_de_desempeño = datos_espliteado[22];
                string Habilidades_y_certificaciones = datos_espliteado[23];
                string Idiomas = datos_espliteado[24];
                string Fecha_de_última_promoción = datos_espliteado[25];
                string ID_del_departamento_de_supervisión = datos_espliteado[26];
                string Historial_de_capacitación = datos_espliteado[27];
                string Último_aumento_de_salario = datos_espliteado[28];
                string tipo_de_aprendis_E = datos_espliteado[29];


                string datos_a_agregar = ID + caracter_separacion_string[0] + Nombre + caracter_separacion_string[0] + Apellido_paterno + caracter_separacion_string[0] + Apellido_materno + caracter_separacion_string[0] + Fecha_de_nacimiento + caracter_separacion_string[0] + Género + caracter_separacion_string[0] + Dirección + caracter_separacion_string[0] + Ciudad + caracter_separacion_string[0] + Estado_Provincia + caracter_separacion_string[0] + Código_postal + caracter_separacion_string[0] + País + caracter_separacion_string[0] + Correo_electrónico + caracter_separacion_string[0] + Teléfono + caracter_separacion_string[0] + Fecha_de_ingreso + caracter_separacion_string[0] + Sueldo + caracter_separacion_string[0] + Cargo + caracter_separacion_string[0] + Estado_de_aprendis_E + caracter_separacion_string[0] + Supervisor + caracter_separacion_string[0] + Notas + caracter_separacion_string[0] + Afiliado + caracter_separacion_string[0] + Fecha_de_terminación + caracter_separacion_string[0] + Motivo_de_terminación + caracter_separacion_string[0] + Horas_trabajadas + caracter_separacion_string[0] + Evaluaciones_de_desempeño + caracter_separacion_string[0] + Habilidades_y_certificaciones + caracter_separacion_string[0] + Idiomas + caracter_separacion_string[0] + Fecha_de_última_promoción + caracter_separacion_string[0] + ID_del_departamento_de_supervisión + caracter_separacion_string[0] + Historial_de_capacitación + caracter_separacion_string[0] + Último_aumento_de_salario + caracter_separacion_string[0] + tipo_de_aprendis_E;
                bas.Agregar(direccion_archivo_aprendices_E, datos_a_agregar, esta_arreglo);
                info_a_retornar = resul_agregue + G_caracter_para_confirmacion_o_error[0] + "agregado si es 2 solo al archivo si es 1 tambien al arreglo";
            }
            else
            {
                info_a_retornar = "0" + G_caracter_para_confirmacion_o_error[0] + "no se encontro la direccion";
            }
            return info_a_retornar;
        }

        public string funcion_a_hacer(string parametro1, string parametro2)
        {
            string info_a_retornar = null;

            return info_a_retornar;
        }
    }
}
