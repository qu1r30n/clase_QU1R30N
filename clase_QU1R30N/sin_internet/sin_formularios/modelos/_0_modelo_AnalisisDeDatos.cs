using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _0_modelo_AnalisisDeDatos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        _0_proceso_AnalisisDeDatos pr_an_dat = new _0_proceso_AnalisisDeDatos();
        public string operacion_a_hacer(string operacion)
        {
            //proceso_que_se_ara§informacion_que_se_utilisara|informacion_que_se_utilisara
            _3_procesos_inventario proc_produc = new _3_procesos_inventario();

            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "existe_producto":
                    info_a_retornar = pr_an_dat.existe_producto(a_donde_enviara_la_informacion[1]);
                    break;
                default:
                    info_a_retornar = "3" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }
            return info_a_retornar;
        }
    }
}
