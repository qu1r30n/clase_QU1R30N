using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios;

namespace clase_QU1R30N.con_internet.herramientas_internet
{
    internal class conmutador
    {
        
        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();

        Tex_base bas = new Tex_base();

        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        principal enlace_principal = new principal();

        public void conmutar_datos(string parametro)
        {
            string[] res_espliteada = parametro.Split(G_caracter_separacion_funciones_espesificas[1][0]);

            // Implementa la lógica aquí


            //procesos_usaras------------------------------------------------------------


            if (res_espliteada[0] == "punto_venta")
            {
                punt_venta(res_espliteada[1],    res_espliteada[2], res_espliteada[3]);
            }
            else if (res_espliteada[0] == "negocio")
            {
                negocio(res_espliteada[1], res_espliteada[2], res_espliteada[3]);
            }
            else if (res_espliteada[0] == "repetidor")
            {
                repetidor(res_espliteada[1], res_espliteada[2], res_espliteada[3]);
            }
            else if (res_espliteada[0] == "inteligencia_artificial")
            {
                inteligencia_artificial(res_espliteada[1], res_espliteada[2], res_espliteada[3]); ;
            }
            else
            {

            }


        }


        //procesos---------------------------------------------------------------------------------------------

        public void punt_venta(string proceso, string folio_o_palbra_clave_a_del_que_lo_recibira, string info_a_procesar)
        {
            info_a_procesar = info_a_procesar.Replace(" ", "");
            string[] lineas_del_mensaje = info_a_procesar.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            switch (proceso)
            {
                case "extraer_inventario":
                    

                    break;




                default:
                    break;
            }

        }


        public void negocio(string proceso, string folio_o_palbra_clave_a_del_que_lo_recibira, string info_a_procesar)
        {
            conexion con = new conexion();
            switch (proceso)
            {
                case "extraer_inventario":


                    string inventario = enlace_principal.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~EXTRAER_INVENTARIO_STRING§");
                    con.datos_a_enviar(folio_o_palbra_clave_a_del_que_lo_recibira, inventario);
                    break;

                    


                default:
                    break;
            }
        }

        public void repetidor(string proceso, string folio_o_palbra_clave_a_del_que_lo_recibira, string info_a_procesar)
        {
            switch (proceso)
            {
                case "peticiones":
                    break;




                default:
                    break;
            }
        }

        public void inteligencia_artificial(string proceso, string folio_o_palbra_clave_a_del_que_lo_recibira, string info_a_procesar)
        {
            switch (proceso)
            {
                case "peticiones":
                    break;




                default:
                    break;
            }
        }

        //fin procesos-------------------------------------------------------------------------------------------
    }
}
