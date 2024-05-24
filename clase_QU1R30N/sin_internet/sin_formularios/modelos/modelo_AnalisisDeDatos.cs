using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class modelo_AnalisisDeDatos
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        proceso_AnalisisDeDatos pr_an_dat = new proceso_AnalisisDeDatos();
        public string operacion_a_hacer(string operacion)
        {
            //proceso_que_se_ara§informacion_que_se_utilisara|informacion_que_se_utilisara
            procesos_productos proc_produc = new procesos_productos();

            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = operacion.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            if (a_donde_enviara_la_informacion[0] == "existe_producto")
            {
                pr_an_dat.existe_producto(a_donde_enviara_la_informacion[1]);
            }
        }
    }
}
