using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N
{

    internal class iniciar_archivos
    {

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();
        public void iniciar()
        {
            string direccion_archivo_de_direcciones_de_bd = "archivos_iniciales\\inicio.txt";
            string fila_inicial = "direccion_de_las_bases_de_datos" + bas.G_separador_para_funciones_espesificas_[0] + "fila_inicial" + bas.G_separador_para_funciones_espesificas_[0] + "arreglo_de_filas_separado_por_§//posdata_solo_ir_agregando_archivos_asta_abajo_por_que_las_filas_ya_son_ocupadas_por_el_programa_y_no_borrar";
            
            string[] agregar_filas =
            {
                // empiesa desde el 1 por que el 0 es de los archivos iniciales
                /*1*/ "config\\inf\\inventario\\inventario.txt~0_id|1_producto|2_contenido|3_tipo_medida|4_precio_venta|5_cod_barras|6_cantidad|7_costo_comp|8_provedor|9_grupo|10_no_poner_nada|11_cant_produc_x_paquet|12_tipo_de_producto|13_ligar_produc_sab|14_impuestos|15_parte_de_que_producto|16_caducidad|~",
                /*2*/ "config\\inf\\dat\\provedores.txt~0_ID_empresa|1_Nombre_empresa|2_Nombre_encargado|3_Dirección_empresa|4_Ciudad_empresa|5_Estado_empresa|6_Código_postal|7_País|8_Correo_electrónico|9_Teléfono_encargado|10_Telefono_empresa|11_Tipo_de_proveedor|12_Productos/Servicios_suministrados|13_Número_de_cuenta_bancaria|14_Banco|15_Ubicación_(GPS)|16_Notas|17_Recordatorio|18_activo_o_no_activo|~",
                /*3*/ "config\\inf\\dat\\empleados.txt~0_ID|1_Nombre|2_Apellido_paterno|3_Apellido_materno|4_Fecha_de_nacimiento|5_Género|6_Dirección|7_Ciudad|8_Estado/Provincia|9_Código_postal|10_País|11_Correo_electrónico|12_Teléfono|13_Fecha_de_ingreso|14_Sueldo|15_Cargo|16_Estado_de_empleo|17_Supervisor|18_Notas|19_Afiliado|20_Fecha_de_terminación|21_Motivo_de_terminación|22_Horas_trabajadas|23_Evaluaciones_de_desempeño|24_Habilidades_y_certificaciones|25_Idiomas|26_Fecha_de_última_promoción|27_ID_del_departamento_de_supervisión|28_Historial_de_capacitación|29_Último_aumento_de_salario|30_tipo_empleado|31_rango_calif|~",
                /*4*/ "config\\afiliados\\afiliados_simple.txt~0_id_usuario|1_id_pat_comp|2_tabla_pat_comp|3_id_enc_simp|4_tabla_enc_simp|5_puntos_d|6_puntos_d_a_dar|7_datos|8_niveles|9_id_horizontal|10_tipo_afiliado|~0|0|tabla_compleja|0|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|0|0||§1|0|tabla_compleja|0|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|1|0||§2|1|tabla_compleja|1|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|2|0||§3|2|tabla_compleja|2|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|3|0||§4|3|tabla_compleja|3|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|4|0||",
                /*5*/ "config\\afiliados\\afiliados_complejo.txt~0_id_usuario|1_id_pat_comp|2_tabla_pat_comp|3_id_enc_simp|4_tabla_enc_simp|5_puntos_d|6_puntos_d_a_dar|7_datos|8_niveles|9_id_horizontal|10_tipo_afiliado|~0|0|tabla_compleja|0|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|0|0||§1|0|tabla_compleja|0|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|1|0||§2|0|tabla_compleja|1|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|2|0||§3|0|tabla_compleja|2|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|3|0||§4|0|tabla_compleja|3|tabla_simple|0|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|4|0||",
                /*6*/ "config\\afiliados\\niveles_e_id_horisontal_afiliados_simple.txt~nivel|id_horizontal|vacios~1|1|§2|1|§3|1|§4|1|",
                /*7*/ "config\\afiliados\\niveles_e_id_horisontal_afiliados_complejo.txt~nivel|id_horizontal|vacios~1|1|§2|1|§3|1|§4|1|",
                /*8*/ "config\\afiliados\\afiliados_unificado.txt~0)id_usuario|1)0idp╦1idp¬0proyecto_p°0idp╦1idp¬1proyecto_p|2)0ipuntos_d_r¬0proyecto_r°1puntos_d_r¬1proyecto_r|3)puntos_d_r_totales|4)datos|5)nivel|6)id_horizontal|7)tipo_afiliado|~0|0╦0¬0afiliados_unificado°0╦0¬afiliados_unificado1|0¬afiliados_unificado°0¬afiliados_unificado1|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|0|0||§1|0¬afiliados_unificado_p|0¬afiliados_unificado|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|1|0||§2|1¬afiliados_unificado|0¬afiliados_unificado|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|2|0||§3|2¬afiliados_unificado|0¬afiliados_unificado|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|3|0||§4|3¬afiliados_unificado|0¬afiliados_unificado|0|0_nom_pru°1_ap_pat_pru°2_ape_mat_pru°0╦banco°4_curp°5_clav_elector°6_otra_id_identificacion°7_0000000000°8_direccion°9_colonia°10_municiopio°11_estado°12_correo@correo.com|4|0||",
                /*9*/ "config\\afiliados\\niveles_e_id_horisontal_afiliados_unificado.txt~nivel|id_horizontal|vacios~1|1|§2|1|§3|1|§4|1|",
            };

            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(direccion_archivo_de_direcciones_de_bd, fila_inicial, agregar_filas, caracter_separacion_fun_esp_objeto: G_caracter_separacion_funciones_espesificas[2]);
            //Tex_base.GG_dir_bd_y_valor_inicial_bidimencional = op_arreglos.agregar_registro_del_array_bidimensional(Tex_base.GG_dir_bd_y_valor_inicial_bidimencional, direccion_archivo_de_direcciones_de_bd, new string[] { bas.G_separador_para_funciones_espesificas });

            for (int i = G_donde_inicia_la_tabla; i < Tex_base.GG_base_arreglo_de_arreglos[0].Length; i++)
            {
                string[] espliteados_direcciones_bases_datos_y_fila_inicial = Tex_base.GG_base_arreglo_de_arreglos[0][i].Split(bas.G_separador_para_funciones_espesificas_[0][0]);
                string[] filas_iniciales = espliteados_direcciones_bases_datos_y_fila_inicial[2].Split(G_caracter_separacion_funciones_espesificas[1][0]);
                if (i > 0)
                {
                    bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(espliteados_direcciones_bases_datos_y_fila_inicial[0], espliteados_direcciones_bases_datos_y_fila_inicial[1], filas_iniciales);
                }



            }
        }
    }
}