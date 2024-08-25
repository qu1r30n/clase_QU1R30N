using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _10_modelo_mul
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        _10_proceso_mul pr_mul = new _10_proceso_mul();

        string[] G_direcciones =
        {
            //direccion_archivo//Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1, 0]//"config\\inf\\inventario\\inventario.TXT",
        };

        public string operacion_a_hacer(string proceso, string datos, string fecha_hora)
        {
            string info_a_retornar = null;

            string[] cant_datos = datos.Split(G_caracter_separacion[1][0]);


            for (int i = 0; i < cant_datos.Length; i++)
            {
                string[] info_espliteada = cant_datos[i].Split(G_caracter_separacion[2][0]);
                string id = null;
                switch (proceso)
                {
                    case "COMICION_VENTA_BUSQUEDA_POR_ID":
                        info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], info_espliteada[0], info_espliteada[1]);
                        break;

                    case "COMICION_VENTA_BUSQUEDA_POR_TELEFONO":
                        string telefono = info_espliteada[0];
                        id = pr_mul.busqueda_id_con_telefono(telefono);
                        info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], id, info_espliteada[1]);
                        break;

                    case "COMICION_VENTA_BUSQUEDA_POR_IDENTIFICACION_OFICIAL":
                        string identificacion_oficial = info_espliteada[0];
                        id = pr_mul.busqueda_id_con_telefono(identificacion_oficial);
                        info_a_retornar = pr_mul.dinero_de_venta(G_direcciones[0], id, info_espliteada[1]);
                        break;


                    default:
                        
                        info_a_retornar = "-1" + G_caracter_para_confirmacion_o_error[0] + "no existe ese PROCESO";
                        break;
                }

            }
            return info_a_retornar;
        }

    }
}
