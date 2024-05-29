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
        _0_modelo_AnalisisDeDatos mod_an_dat = new _0_modelo_AnalisisDeDatos();
        _1_modelo_compras mod_comp = new _1_modelo_compras();
        _2_modelo_ventas mod_vent = new _2_modelo_ventas();
        _3_modelo_inventario mod_inv = new _3_modelo_inventario();
        _4_modelo_empleados mod_emp = new _4_modelo_empleados();
        _5_modelo_afiliados mod_afil = new _5_modelo_afiliados();
        

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
                case "modelo_analisis_datos":
                    //"existe_producto§codigo"
                    info_a_retornar = mod_an_dat.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_compras":
                    info_a_retornar = mod_comp.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_productos":
                    info_a_retornar = mod_inv.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_inventario":
                    info_a_retornar = mod_inv.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_empleados":
                    info_a_retornar = mod_emp.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
                case "modelo_afiliados":
                    //inscribir_simple§4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com
                    info_a_retornar = mod_afil.operacion_a_hacer(a_donde_enviara_la_informacion[1]);
                    break;
            }

            return info_a_retornar;

        }

        
    }
}
