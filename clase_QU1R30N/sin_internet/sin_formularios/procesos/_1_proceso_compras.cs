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


        public string compras(string direccion_inventario, string codigo, string cantidad, string precio, string provedor)
        {
            string info_a_retornar = "";

            DateTime fecha_hora = DateTime.Now;
            string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
            string año = fecha_hora.ToString("yyyy");

            bas.Editar_o_incr_multiple_con_comparacion_final(direccion_inventario, 5, codigo
                ,
                  //columnas a editar
                  /*0*/"6"//cantidad
                + G_caracter_separacion_funciones_espesificas[0]
                 /*1*/+ "7"//costo de compra
                + G_caracter_separacion_funciones_espesificas[0]
                 /*2*/+ "8"//provedor
                 + G_caracter_separacion_funciones_espesificas[0]
                 /*3*/+ "17"//ultimo movimiento

                ,
                  //info a editar o incrementar
                  /*0*/cantidad //cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ precio //costo de compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ provedor //provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ año_mes_dia_hora  //ultimo movimiento
                  ,
                  //comparacion para edicion dejar en blanco si no hay comparacion
                  // si cuando se hace el espliteo de la info extraida del archivo solo es 1 celda no comparara
                  // ejemplo correcto "a¬1" ejemplo donde no comparara  "provedor" y este sera comparado con la info de edicion
                  /*0*/  "b" //cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ "d" //costo de compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ "c" //provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ "" //ultimo movimiento

                ,
                  // 0:editar  1:incrementar
                  /*0*/"1"//incrementar//cantidad
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*1*/+ "0"//editar//costo compra
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*2*/+ "2"//editar//provedor
                  + G_caracter_separacion_funciones_espesificas[0]
                  /*3*/+ "0"//editar//ultimo movimiento
                  );


            return info_a_retornar;
        }


    }
}
