﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;


namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _5_modelo_afiliados
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.txt",
            /*1*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[4,0],//"config\\afiliados\\afiliados_simple.txt",
            /*2*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[6,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_simple.txt",
            /*3*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[5,0],//"config\\afiliados\\afiliados_complejo.txt",
            /*4*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[7,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_complejo.txt",
            /*5*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[8,0],//"config\\afiliados\\afiliados_unificado.txt",
            /*6*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[9,0],//"config\\afiliados\\niveles_e_id_horisontal_afiliados_unificado.txt",

        };

        

        _5_proceso_afiliados pr_afil = new _5_proceso_afiliados();
        public string operacion_a_hacer(string proceso, string datos)
        {
            string info_a_retornar = null;

            string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);

            switch (proceso)
            {
                //usables-----------------------------------------------------------------------------------

                case "INSCRIBIR_UNIFICADO_COD3_R_":
                    //0_id_enc_simp|1_tabla_enc_simple|2_datos
                    //4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com
                    //datos//nombre°apellido_paterno°apellido_materno°numero_cuenta°banco°curp°numero_celular°direccion°colonia°municiopio°estado°correo                    
                    info_a_retornar = pr_afil.registro_unificado_cod3_r_(G_direcciones[5], G_direcciones[6], info_espliteada[0], info_espliteada[1], info_espliteada[2]);

                    break;
                    
                    //no usables--------------------------------------------------------------------------

                case "INSCRIBIR_SIMPLE_COD1":
                    //0_id_enc_simp|1_tabla_enc_simple|2_datos
                    //4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com
                    //datos//nombre°apellido_paterno°apellido_materno°numero_cuenta°banco°curp°numero_celular°direccion°colonia°municiopio°estado°correo                    
                    info_a_retornar = pr_afil.registro_simple_cod1(G_direcciones[1], G_direcciones[2], info_espliteada[0], info_espliteada[1], info_espliteada[2]);
                    
                    break;

                case "INSCRIBIR_COMPLEJO_COD2":
                    //0_id_enc_simp|1_tabla_enc_simple|2_datos
                    //4|afiliados_complejo|4|afiliados_simple|nom_pru°ap_pat_pru°ape_mat_pru°0°banco°curp°0000000000°direccion°colonia°municiopio°estado°correo@correo.com
                    //datos//nombre°apellido_paterno°apellido_materno°numero_cuenta°banco°curp°numero_celular°direccion°colonia°municiopio°estado°correo
                    info_a_retornar = pr_afil.registro_complejo_cod2(G_direcciones[1], G_direcciones[2], info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3], info_espliteada[4]);
                    
                    break;
                
                default:
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;

        }
    }
}
