using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _3_modelo_productos_e_inventario
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;


        string[] G_direcciones =
        {
            /*0*/Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0],//"config\\tienda\\inf\\inventario\\inventario.txt",
        };

        

        _3_proceso_productos_e_inventario proc_inventario = new _3_proceso_productos_e_inventario();
        public string operacion_a_hacer(string proceso, string datos)
        {
            string info_a_retornar = null;

            string[] info_espliteada = datos.Split(G_caracter_separacion[0][0]);

            switch (proceso)
            {
                case "AGREGAR":

                    Tex_base bas = new Tex_base();

                    string res_ind_ar = bas.sacar_indice_del_arreglo_de_direccion(G_direcciones[0]);
                    string[] res_esp = res_ind_ar.Split(G_caracter_para_confirmacion_o_error[0][0]);

                    DateTime fecha_hora = DateTime.Now;
                    string año_mes_dia_hora = fecha_hora.ToString("yyyyMMddHH");
                    string año = fecha_hora.ToString("yyyy");
                    int indice_arreglo = Convert.ToInt32(res_esp[1]);


                    string _0_id = "" + Tex_base.GG_base_arreglo_de_arreglos[indice_arreglo].Length;
                    string _1_producto = info_espliteada[0];
                    double _2_contenido = Convert.ToDouble(info_espliteada[1]);
                    string _3_tipo_medida = info_espliteada[2];
                    double _4_precio_venta = Convert.ToDouble(info_espliteada[3]);
                    string _5_cod_barras = info_espliteada[4];
                    double _6_cantidad = Convert.ToDouble(info_espliteada[5]);
                    double _7_costo_comp = Convert.ToDouble(info_espliteada[6]);
                    string _8_provedor = info_espliteada[7];
                    string _9_grupo = info_espliteada[8];
                    double _10_cant_produc_x_paquet = Convert.ToDouble(info_espliteada[9]);
                    string _11_tipo_de_producto = info_espliteada[10];
                    string _12_ligar_produc_sab = info_espliteada[11];
                    string _13_impuestos = info_espliteada[12];
                    string _14_si_es_elaborado_que_materia_prima_usa_y_cantidad = info_espliteada[13];
                    string _15_caducidad = info_espliteada[14];
                    string _16_ultimo_movimiento = año_mes_dia_hora;
                    string _17_sucursal_vent = info_espliteada[16];
                    string _18_clasificacion_producto = info_espliteada[17];
                    string _19_no_poner_nada = info_espliteada[18];

                    string todo_unido = _0_id + G_caracter_separacion[0] + _1_producto + G_caracter_separacion[0] + _2_contenido + G_caracter_separacion[0] + _3_tipo_medida + G_caracter_separacion[0] + _4_precio_venta + G_caracter_separacion[0] + _5_cod_barras + G_caracter_separacion[0] + _6_cantidad + G_caracter_separacion[0] + _7_costo_comp + G_caracter_separacion[0] + _8_provedor + G_caracter_separacion[0] + _9_grupo + G_caracter_separacion[0] + _10_cant_produc_x_paquet + G_caracter_separacion[0] + _11_tipo_de_producto + G_caracter_separacion[0] + _12_ligar_produc_sab + G_caracter_separacion[0] + _13_impuestos + G_caracter_separacion[0] + _14_si_es_elaborado_que_materia_prima_usa_y_cantidad + G_caracter_separacion[0] + _15_caducidad + G_caracter_separacion[0] + _16_ultimo_movimiento + G_caracter_separacion[0] + _17_sucursal_vent + G_caracter_separacion[0] + _18_clasificacion_producto + G_caracter_separacion[0] + _19_no_poner_nada + G_caracter_separacion[0];



                    info_a_retornar = proc_inventario.agregar_producto(G_direcciones[0],todo_unido);
                    

                    break;

                default:
                    info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                    break;
            }

            return info_a_retornar;
        }


    }
}
