using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using clase_QU1R30N.sin_internet.sin_formularios;
using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using clase_QU1R30N.sin_internet.sin_formularios.modelos;


namespace clase_QU1R30N.sin_internet.con_formularios.tienda
{
    public partial class compras : Form
    {
        Tex_base bas = new Tex_base();
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        string[] G_direcciones_REGISTROS =
        {
            Tex_base.GG_dir_bd_y_valor_inicial_bidimencional[1,0],//inventario
            
        };
        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        herramientas_para_elementos_del_form herr_form = new herramientas_para_elementos_del_form();
        Ventana_emergente vent_emergent = new Ventana_emergente();
        principal enl_princ = new principal();

        public compras()
        {
            InitializeComponent();
            
            herr_form.fun_txt_prediccion_palabra(Txt_Codbar, "codbar");
            herr_form.fun_txt_prediccion_palabra(Txt_nom_producto, "producto");


            string[] res_prov = enl_princ.enlasador("MODELO_PROVEDORES~EXTRAER_NOM_PROVEDORES_Y_DINERO§").Split(G_caracter_para_confirmacion_o_error[0][0]);

            string[] enviar = { "4|PROVEDOR||||" + res_prov[1] };
            string result = vent_emergent.Proceso_ventana_emergente(enviar).ToUpper();
            string[] res_esp = result.Split(G_caracter_separacion[2][0]);

            string provedor = res_esp[0];
            string cantidad_din_comprar = res_esp[1];

            herr_form.fun_cmb_prediccion_palabra(cmb_provedor, provedor, "PROVEDOR");


            herr_form.fun_txt_procesar_tecleos_compras(Txt_Codbar, Lst_compras, Lbl_id, lbl_codbar, Lbl_nombre_producto, Lbl_precio_compra, Lbl_precio_venta, Lbl_cantidad_cant, cmb_provedor,Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_txt_nom_produc_pasar_a_txt_codigo(Txt_nom_producto, Txt_Codbar);

            herr_form.fun_botones(Lst_compras, Btn_eliminar_seleccionado, "eliminar_seleccionado", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_compras, Btn_eliminar_todo, "eliminar_todo", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_compras, Btn_elim_ultimo, "eliminar_ultimo", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);
            herr_form.fun_botones(Lst_compras, Btn_procesar_venta, "procesar_compra", Lbl_nom_product_list, Lbl_costo_product_list, Lbl_cuenta);

        }
    }
}
