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
                /*1*/ "config\\tienda\\inf\\inventario\\inventario.txt~0_id|1_producto|2_contenido|3_tipo_medida|4_precio_venta|5_cod_barras|6_cantidad|7_costo_comp|8_provedor|9_grupo|10_no_poner_nada|11_cant_produc_x_paquet|12_tipo_de_producto|13_ligar_produc_sab|14_impuestos|15_parte_de_que_producto|16_caducidad~",
                /*2*/ "config\\tienda\\inf\\dat\\provedores.txt~0_id|1_provedor|~",
                /*3*/ "config\\tienda\\inf\\dat\\empleados.txt~0_id|1_empleado|~",
                /*4*/ "config\\tienda\\inf\\dat\\mul\\afiliados_simple.txt~0_id|1_afiliado|~",
                /*4*/ "config\\tienda\\inf\\dat\\mul\\afiliados_complejo.txt~0_id|1_afiliado|~",
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