using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios;
using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.modelos;

namespace clase_QU1R30N.sin_internet.sin_formularios
{
    internal class principal
    {
        modelo_AnalisisDeDatos mod_an_dat = new modelo_AnalisisDeDatos();
        modelo_compras mod_comp = new modelo_compras();
        modelo_productos mod_prod = new modelo_productos();


        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        // Función para manejar compras
        public string enlasador(string info_entrada)
        {
            //ejemplo dato entrada: "analisis_datos~existe_producto§codigo"
            string info_a_retornar = null;
            string[] a_donde_enviara_la_informacion = info_entrada.Split(G_caracter_separacion_funciones_espesificas[0][0]);

            switch (a_donde_enviara_la_informacion[0])
            {
                case "analisis_datos":
                    //"existe_producto§codigo"
                    info_a_retornar = mod_an_dat.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_compras":
                    info_a_retornar = mod_comp.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_productos":
                    info_a_retornar = mod_prod.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
            }

            return info_a_retornar;

        }

        
    }
}
