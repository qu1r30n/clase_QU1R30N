using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _1_proceso_compras
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();


        _0_proceso_AnalisisDeDatos pr_analisis = new _0_proceso_AnalisisDeDatos();


        public string compras(string direccion_inventario, string codigo, string cantidad, string precio)
        {
            string info_a_retornar = "";



            bas.Editar_o_incr_multiple(direccion_inventario, 5, codigo
                ,
                  //columnas a editar
                  /*0*/"6"
                + G_caracter_separacion_funciones_espesificas[0]
                 /*1*/+ ""
                ,
                  //info a editar o incrementar
                  /*0*/cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ ""

                ,
                  // 0:editar  1:incrementar
                  /*0*/"1"
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ ""
                  );


            return info_a_retornar;
        }


    }
}
