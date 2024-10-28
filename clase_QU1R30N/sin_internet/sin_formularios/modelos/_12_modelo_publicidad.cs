
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.procesos;

namespace clase_QU1R30N.sin_internet.sin_formularios.modelos
{
    internal class _12_modelo_publicidad
    {
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        _12_proceso_publicidad pr_pub = new _12_proceso_publicidad();

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
                
                switch (proceso)
                {
                    case "PUBLICAR_TEXTO_FACEBOOK":
                            pr_pub.publicar_face(proceso, info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3]);
                        break;

                    case "PUBLICAR_IMAGEN_FACEBOOK":
                            pr_pub.publicar_face(proceso, info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3]);
                        break;

                    case "PUBLICAR_VIDEO_FACEBOOK":
                            pr_pub.publicar_face(proceso, info_espliteada[0], info_espliteada[1], info_espliteada[2], info_espliteada[3]);
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
