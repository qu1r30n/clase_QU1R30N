using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _3_modelo_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;
        
        
        
        _3_procesos_inventario proc_inventario = new _3_procesos_inventario();
        public string operacion_a_hacer(string operacion)
        {
            

            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "agregar":
                    string temp = "";
                    temp = (string)proc_inventario.agregar_producto(temp, a_donde_enviara_la_informacion[0]);
                    info_a_retornar = temp;

                    break;

                default:
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;
        }


    }
}
