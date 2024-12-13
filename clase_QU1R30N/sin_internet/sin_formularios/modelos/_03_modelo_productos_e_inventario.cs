using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _03_modelo_productos_e_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.TXT",
        };

        Tex_base bas = new Tex_base();

        _03_proceso_productos_e_inventario proc_inventario = new _03_proceso_productos_e_inventario();
        public string operacion_a_hacer(string info_entrada, string fecha_hora)
        {
            string info_a_retornar = null;


            string[] info = info_entrada.Split(G_caracter_separacion_funciones_espesificas[1][0]);
            string proceso = info[0];
            string datos = info[1];

            string año_mes_dia_hora_minuto_segundo = fecha_hora, año_mes_dia_hora_minuto = "", año_mes_dia_hora = "", año_mes_dia = "", año_mes = "", año = "";
            for (int i = 0; i < fecha_hora.Length; i++)
            {
                if (i < fecha_hora.Length - 2)
                {
                    año_mes_dia_hora_minuto = año_mes_dia_hora_minuto + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 4)
                {
                    año_mes_dia_hora = año_mes_dia_hora + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 6)
                {
                    año_mes_dia = año_mes_dia + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 8)
                {
                    año_mes = año_mes + fecha_hora[i];
                }
                if (i < fecha_hora.Length - 10)
                {
                    año = año + fecha_hora[i];
                }
            }


            string[] cant_datos = datos.Split(G_caracter_separacion_funciones_espesificas[2][0]);

            for (int i = 0; i < cant_datos.Length; i++)
            {
                string[] info_espliteada = cant_datos[i].Split(G_caracter_separacion[0][0]);

                switch (proceso)
                {
                    case "AGREGAR_SINO_EXISTE":

                            info_a_retornar = proc_inventario.agrega_si_no_existe(G_direcciones[0], info_espliteada[0]);

                        break;

                    case "AGREGAR":
                        info_a_retornar = proc_inventario.agregar_producto(G_direcciones[0], info_espliteada[0]);
                        break;


                    case "BUSCAR":

                            info_a_retornar = proc_inventario.buscar(G_direcciones[0], info_espliteada[0], info_espliteada[1]);
                        

                        break;

                    case "EXTRAER_INVENTARIO_STRING":

                        
                        info_a_retornar = proc_inventario.dar_el_inventario_string_caracter_sep(G_direcciones[0]);

                        break;


                    case "HACER_INVENTARIO":

                        proc_inventario.archivos_inicio_hacer_inventario();

                        info_a_retornar = proc_inventario.hacer_inventario(datos, año_mes_dia);

                        break;



                    default:
                        info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                        break;
                }

            }

            return info_a_retornar;
        }


    }
}
