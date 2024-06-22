using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;

namespace clase_QU1R30N.sin_internet.sin_formularios.procesos
{
    internal class _3_proceso_productos_e_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;
        
        

        var_fun_GG vf_GG = new var_fun_GG();

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        Tex_base bas = new Tex_base();


        

        public string agregar_producto(string direccion_archivo,string producto)
        {
            string info_a_retornar = "";
            string res_ind_ar = bas.sacar_indice_del_arreglo_de_direccion(direccion_archivo);
            string[] res_esp = res_ind_ar.Split(G_caracter_para_confirmacion_o_error[0][0]);
            if (Convert.ToInt32(res_ind_ar[0]) > 0)
            {

                if (res_esp[0] == "1")
                {

                    string[] producto_espliteado = producto.Split(G_caracter_separacion[0][0]);

                    DateTime fecha_hora = DateTime.Now;
                    string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
                    string año = fecha_hora.ToString("yyyy");
                    int indice_arreglo = Convert.ToInt32(res_esp[1]);


                    string _0_id = "" + Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length;
                    string _1_producto = producto_espliteado[0];
                    double _2_contenido = Convert.ToDouble(producto_espliteado[1]);
                    string _3_tipo_medida = producto_espliteado[2];
                    double _4_precio_venta = Convert.ToDouble(producto_espliteado[3]);
                    string _5_cod_barras = producto_espliteado[4];
                    double _6_cantidad = Convert.ToDouble(producto_espliteado[5]);
                    double _7_costo_comp = Convert.ToDouble(producto_espliteado[6]);
                    string _8_provedor = producto_espliteado[7];
                    string _9_grupo = producto_espliteado[8];
                    double _10_cant_produc_x_paquet = Convert.ToDouble(producto_espliteado[9]);
                    string _11_tipo_de_producto = producto_espliteado[10];
                    string _12_ligar_produc_sab = producto_espliteado[11];
                    string _13_impuestos = producto_espliteado[12];
                    string _14_si_es_elaborado_que_materia_prima_usa_y_cantidad = producto_espliteado[13];
                    string _15_caducidad = producto_espliteado[14];
                    string _16_ultimo_movimiento = año_mes_dia_hora;
                    string _17_sucursal_vent = producto_espliteado[16];
                    string _18_clasificacion_producto = producto_espliteado[17];
                    string _19_no_poner_nada = producto_espliteado[18];

                    string todo_unido = _0_id + G_caracter_separacion[0] + _1_producto + G_caracter_separacion[0] + _2_contenido + G_caracter_separacion[0] + _3_tipo_medida + G_caracter_separacion[0] + _4_precio_venta + G_caracter_separacion[0] + _5_cod_barras + G_caracter_separacion[0] + _6_cantidad + G_caracter_separacion[0] + _7_costo_comp + G_caracter_separacion[0] + _8_provedor + G_caracter_separacion[0] + _9_grupo + G_caracter_separacion[0] + _10_cant_produc_x_paquet + G_caracter_separacion[0] + _11_tipo_de_producto + G_caracter_separacion[0] + _12_ligar_produc_sab + G_caracter_separacion[0] + _13_impuestos + G_caracter_separacion[0] + _14_si_es_elaborado_que_materia_prima_usa_y_cantidad + G_caracter_separacion[0] + _15_caducidad + G_caracter_separacion[0] + _16_ultimo_movimiento + G_caracter_separacion[0] + _17_sucursal_vent + G_caracter_separacion[0] + _18_clasificacion_producto + G_caracter_separacion[0] + _19_no_poner_nada + G_caracter_separacion[0];
                    info_a_retornar = bas.Agregar(direccion_archivo, todo_unido);

                    return "";
                }

                


            }

            else
            {
                if (res_esp[0]=="0")
                {
                    return "0";
                }
                else if(res_esp[0]=="-1") 
                {
                    return "-1";
                }
            }

            return "";
        }

        


    }
}
