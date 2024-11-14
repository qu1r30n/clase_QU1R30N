using clase_QU1R30N.sin_internet.sin_formularios;
using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_QU1R30N.sin_internet.con_formularios
{
    public partial class herramientas_para_elementos_del_form : Form
    {

        public herramientas_para_elementos_del_form()
        {
            InitializeComponent();
        }

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        principal enl_princ = new principal();
        operaciones_textos op_tex = new operaciones_textos();
        operaciones_arreglos op_arr = new operaciones_arreglos();
        var_fun_GG vf_GG = new var_fun_GG();
        var_fun_GG_dir_arch_crear vf_GG_arc_crear = new var_fun_GG_dir_arch_crear();

        Ventana_emergente vent_emergent = new Ventana_emergente();


        public void fun_hacer_inventario_archivo_inicio()
        {
            enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~CREAR_ARCHIVOS_HACER_INVENT§");
        }

        //txt------------------------------------------------------------



        public void fun_ventana_cargar_cadaves_que_regresa_a_la_ventana(Form formulario, TextBox txt_codigo, TextBox txt_nom_producto)
        {
            formulario.Activated += (s, e) =>
            {


                txt_codigo.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_codbar_venta;
                txt_nom_producto.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_nom_produc_venta;


            };
        }


        public void fun_txt_prediccion_palabra(TextBox cmb_a_configurar, string tipo)
        {
            // Inicializar AutoCompleteStringCollection
            cmb_a_configurar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_a_configurar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (tipo == "codbar")
            {
                cmb_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_codbar_venta;
            }
            else if (tipo == "producto")
            {
                cmb_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_nom_produc_venta;
            }

        }

        public void fun_cmb_prediccion_palabra(ComboBox cmb_a_configurar, string provedor, string tipo = "PROVEDOR")
        {
            // Establecer modo de autocompletado
            cmb_a_configurar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_a_configurar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmb_a_configurar.Text = provedor;

            if (tipo == "PROVEDOR")
            {
                string[] res_prov = enl_princ.enlasador("MODELO_PROVEDORES~EXTRAER_NOM_PROVEDORES§").Split(G_caracter_para_confirmacion_o_error[0][0]);
                string[] nom_prov = res_prov[1].Split(G_caracter_separacion[1][0]);

                AutoCompleteStringCollection predicciones_de_palabra = new AutoCompleteStringCollection();

                for (int i = 0; i < nom_prov.Length; i++)
                {
                    cmb_a_configurar.Items.Add(nom_prov[i]);
                    predicciones_de_palabra.Add(nom_prov[i]);
                }

                cmb_a_configurar.AutoCompleteCustomSource = predicciones_de_palabra;
            }
        }



        public void fun_txt_procesar_tecleos_ventas(TextBox txt_a_configurar, ListBox lstb_a_configurar, Label lbl_configurar_desc_produc, Label lbl_configurar_cantidad_costo, Label lbl_configurar_total)
        {
            txt_a_configurar.KeyDown += (sender, e) =>
            {

                if (e.KeyValue == (char)Keys.Enter)
                {
                    txt_a_configurar.Text = txt_a_configurar.Text.ToUpper();

                    string[] tex_esplit = txt_a_configurar.Text.Split(Convert.ToChar(G_caracter_separacion[0]));
                    var_fun_GG_dir_arch_crear.GG_variables_string[0] = tex_esplit[0];

                    if (tex_esplit.Length > 1)
                    {




                        string[] info_producto = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[2]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = info_producto[1].Split(G_caracter_separacion[0][0]);
                        string indice_producto = info_producto[2];

                        double cantidad = 1;

                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2|producto|" + info_split_produc_inv[1], "1|cantidad en litros o kilos(se puede decimal)||solo_numeros" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);

                            if (result != "")
                            {
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);
                                cantidad = Convert.ToDouble(res_esp[1]);
                            }

                        }
                        if (indice_producto != "")
                        {
                            fun_lstb_agregar_elim(lstb_a_configurar, txt_a_configurar, "AGREGAR_PRODUCTO_VENTA", cantidad, info_producto[1], indice_producto, lbl_configurar_desc_produc, lbl_configurar_cantidad_costo, lbl_configurar_total);

                        }


                    }
                    else
                    {
                        string[] info_producto = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro el producto?
                        if (Convert.ToInt32(info_producto[0]) > 0)
                        {
                            string[] info_split_produc_inv = info_producto[1].Split(G_caracter_separacion[0][0]);
                            string indice_producto = info_producto[2];
                        }
                        else
                        {
                            ventana_nuevo_producto();
                        }

                    }

                    txt_a_configurar.Text = "";
                }

                else if (e.KeyValue == (char)(Keys.Add))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {

                        string[] tex_esplit = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                        string[] result_busq = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[6]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = result_busq[1].Split(G_caracter_separacion[0][0]);
                        double cantidad = 1;



                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2|producto|" + info_split_produc_inv[1], "1|cantidad en litros o kilos(se puede decimal)||solo_numeros" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);

                            if (result != "")
                            {
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);
                                cantidad = Convert.ToDouble(res_esp[1]);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, result_busq[1], result_busq[2], "VENTA", cantidad);

                        if (info_split_produc_inv[0] != null)
                        {


                            if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + " " + info_split_produc_inv[3] + " precio:$" + info_split_produc_inv[4]; }
                            if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc_inv[1] + " " + info_split_produc_inv[2] + "" + info_split_produc_inv[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[4])); }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }
                    txt_a_configurar.Text = "";
                }

                else if (e.KeyValue == (char)(Keys.Subtract))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {

                        string[] tex_esplit = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                        string[] result_busq = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[6]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = result_busq[1].Split(G_caracter_separacion[0][0]);
                        double cantidad = -1;



                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2|producto|" + info_split_produc_inv[1], "1|cantidad en litros o kilos(se puede decimal)||solo_numeros" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);

                            if (result != "")
                            {
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);
                                cantidad = Convert.ToDouble(res_esp[1]);
                                cantidad = cantidad * -1;
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, result_busq[1], result_busq[2], "VENTA", cantidad);

                        if (info_split_produc_inv[0] != null)
                        {

                            if (Convert.ToDouble(cantidad_sumada_o_restada) > 0)
                            {
                                if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + " " + info_split_produc_inv[3] + " precio:$" + info_split_produc_inv[4]; }
                                if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc_inv[1] + " " + info_split_produc_inv[2] + "" + info_split_produc_inv[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[4])); }
                            }
                            else
                            {
                                lbl_configurar_desc_produc.Text = "nombre del producto";
                                lbl_configurar_cantidad_costo.Text = "$";
                            }

                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }
                    txt_a_configurar.Text = "";
                }

            };

        }

        public void fun_txt_procesar_tecleos_compras(TextBox txt_a_configurar, ListBox lstb_a_configurar, Label lbl_id_producto, Label lbl_codbar, Label lbl_nom_producto, Label lbl_precio_compra, Label lbl_precio_venta, Label lbl_nom_cantidad_inventario, ComboBox cmb_provedores, Label Lbl_descripcion_product_list, Label lbl_configurar_cantidad_costo, Label lbl_precio_total)
        {
            txt_a_configurar.KeyDown += (sender, e) =>
            {

                if (e.KeyValue == (char)Keys.Enter)
                {
                    txt_a_configurar.Text = txt_a_configurar.Text.ToUpper();

                    string[] tex_esplit = txt_a_configurar.Text.Split(Convert.ToChar(G_caracter_separacion[0]));
                    var_fun_GG_dir_arch_crear.GG_variables_string[0] = tex_esplit[0];

                    if (tex_esplit.Length > 1)
                    {




                        string[] info_producto = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[2]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = info_producto[1].Split(G_caracter_separacion[0][0]);
                        string indice_producto = info_producto[2];



                        if (indice_producto != "")
                        {
                            lbl_id_producto.Text = info_producto[2];
                            lbl_codbar.Text = info_split_produc_inv[5];
                            lbl_nom_producto.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + info_split_produc_inv[3];
                            lbl_precio_compra.Text = info_split_produc_inv[7];
                            lbl_precio_venta.Text = info_split_produc_inv[4];
                            lbl_nom_cantidad_inventario.Text = info_split_produc_inv[6];

                            string[] prov = info_split_produc_inv[8].Split(G_caracter_separacion[1][0]);
                            string[] nom_prov = prov[0].Split(G_caracter_separacion[2][0]);
                            string[] enviar = null;

                            double cantidad_de_productos = 0;






                            if (info_split_produc_inv[11] == "PAQUETE_MAYOREO")
                            {


                                enviar = new string[]
                                {
                                    "1|cantidad|0|SOLO_NUMEROS",
                                    "1|precio|" + lbl_precio_compra.Text + "|SOLO_NUMEROS",
                                };

                                vent_emergent = new Ventana_emergente();
                                string result = vent_emergent.Proceso_ventana_emergente(enviar, lbl_nom_producto.Text).ToUpper();
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);
                                cantidad_de_productos = Convert.ToDouble(res_esp[0]);
                                lbl_precio_compra.Text = res_esp[1];

                            }

                            else if (info_split_produc_inv[11] == "PAQUETE_PROMOCION")
                            {
                                enviar = new string[]
                                {
                                    "1|cantidad|0|SOLO_NUMEROS",
                                    "1|precio|" + lbl_precio_compra.Text + "|SOLO_NUMEROS",
                                };

                                string result = vent_emergent.Proceso_ventana_emergente(enviar, lbl_nom_producto.Text).ToUpper();
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);

                                cantidad_de_productos = Convert.ToDouble(res_esp[0]);
                                lbl_precio_compra.Text = res_esp[1];

                            }

                            else
                            {
                                enviar = new string[]
                                {
                                    "1|cantidad|0|SOLO_NUMEROS",
                                    "1|precio|" + lbl_precio_compra.Text + "|SOLO_NUMEROS",


                                };
                                vent_emergent = new Ventana_emergente();
                                string result = vent_emergent.Proceso_ventana_emergente(enviar, lbl_nom_producto.Text).ToUpper();
                                string[] res_esp = result.Split(G_caracter_separacion[0][0]);
                                cantidad_de_productos = Convert.ToDouble(res_esp[0]);
                                lbl_precio_compra.Text = res_esp[1];
                            }



                            enviar = new string[]
                                {
                                    "3|multiplicar cant*precio|1|SOLO_NUMEROS",
                                    "3|dividir cant/precio|2|SOLO_NUMEROS",
                                };


                            vent_emergent = new Ventana_emergente();
                            string result_operacion = vent_emergent.Proceso_ventana_emergente(enviar, lbl_nom_producto.Text).ToUpper();
                            if (result_operacion == "2")
                            {

                                info_split_produc_inv[7] = "" + (Convert.ToDouble(lbl_precio_compra.Text) / cantidad_de_productos);
                                info_producto[1] = op_tex.join_paresido_simple(G_caracter_separacion[0][0], info_split_produc_inv);

                            }



                            fun_lstb_agregar_elim(lstb_a_configurar, txt_a_configurar, "AGREGAR_PRODUCTO_COMPRA", cantidad_de_productos, info_producto[1], indice_producto, Lbl_descripcion_product_list, lbl_configurar_cantidad_costo, lbl_precio_total, cmb_provedores.Text);


                        }


                    }
                    else
                    {
                        string[] info_producto = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro el producto?
                        if (Convert.ToInt32(info_producto[0]) > 0)
                        {
                            string[] info_split_produc_inv = info_producto[1].Split(G_caracter_separacion[0][0]);
                            string indice_producto = info_producto[2];
                        }
                        else
                        {
                            ventana_nuevo_producto();
                        }

                    }


                }

                else if (e.KeyValue == (char)(Keys.Add))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {

                        string[] tex_esplit = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                        string[] result_busq = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[6]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = result_busq[1].Split(G_caracter_separacion[0][0]);
                        double cantidad = 1;



                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2|producto|" + info_split_produc_inv[3], "1|cantidad en litros o kilos(se puede decimal)||2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, result_busq[1], result_busq[2], "COMPRA", cantidad);

                        if (info_split_produc_inv[0] != null)
                        {


                            //if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + " " + info_split_produc_inv[3] + " precio:$" + info_split_produc_inv[4]; }
                            //if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc_inv[1] + " " + info_split_produc_inv[2] + "" + info_split_produc_inv[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[4])); }
                            //sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }

                }

                else if (e.KeyValue == (char)(Keys.Subtract))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {

                        string[] tex_esplit = lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                        string[] result_busq = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[6]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = result_busq[1].Split(G_caracter_separacion[0][0]);
                        double cantidad = -1;



                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2|producto|" + info_split_produc_inv[3], "1|cantidad en litros o kilos(se puede decimal)||2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, result_busq[1], result_busq[2], "COMPRA", cantidad);

                        if (info_split_produc_inv[0] != null)
                        {

                            if (Convert.ToDouble(cantidad_sumada_o_restada) > 0)
                            {
                                //if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + " " + info_split_produc_inv[3] + " precio:$" + info_split_produc_inv[4]; }
                                //if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc_inv[1] + " " + info_split_produc_inv[2] + "" + info_split_produc_inv[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[4])); }
                            }
                            else
                            {
                                //lbl_configurar_desc_produc.Text = "nombre del producto";
                                //lbl_configurar_cantidad_costo.Text = "$";
                            }

                            //sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }

                    }

                }

            };
        }

        public void fun_txt_nom_produc_pasar_a_txt_codigo(TextBox txt_origen, TextBox txt_destino)
        {

            txt_origen.KeyDown += (sender, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    string[] info_espliteado = txt_origen.Text.Split(Convert.ToChar(G_caracter_separacion[0]));
                    if (info_espliteado.Length > 1)
                    {

                        txt_destino.Text = info_espliteado[1] + G_caracter_separacion[0] + info_espliteado[0] + G_caracter_separacion[0] + info_espliteado[2];
                        txt_destino.Focus();
                        txt_origen.Text = "";
                    }
                }

            };
        }


        public void fun_botones(ListBox lstb_a_configurar, Button btn_usar, string proceso, Label lbl_configurar_desc_produc = null, Label lbl_configurar_cantidad_costo = null, Label lbl_configurar_total = null)
        {
            btn_usar.Click += (sender, e) =>
            {
                //eliminar_por_item,eliminar_seleccionado,eliminar_ultimo,eliminar_todo
                funciones_de_botones_operaciones_listbox(lstb_a_configurar, proceso);

                if (lbl_configurar_desc_produc != null && lbl_configurar_cantidad_costo != null && lbl_configurar_total != null)
                {
                    lbl_configurar_desc_produc.Text = "nombre del producto";
                    lbl_configurar_cantidad_costo.Text = "$";
                    sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);
                }

                


            };
        }

        


        public string sumar_o_restar_producto_ventas(ListBox lstb_a_configurar, string datos, string indice_producto, string compra_o_venta, double cantidad = 1, string provedor = "")
        {
            bool esta_el_mismo_producto = false;
            string cantidad_retornar_string = "";

            string[] datos_espliteados = datos.Split(G_caracter_separacion[0][0]);
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                string[] elemento_espliteado = lstb_a_configurar.Items[i].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                if (datos_espliteados[5] == elemento_espliteado[0])
                {
                    esta_el_mismo_producto = true;
                    double resultado = (Convert.ToDouble(elemento_espliteado[5]) + cantidad);
                    elemento_espliteado[5] = "" + resultado;
                    if (resultado <= 0)
                    {
                        funciones_de_botones_operaciones_listbox(lstb_a_configurar, "ELIMINAR_POR_ITEM", i + "");
                        cantidad_retornar_string = "0";
                        break;
                    }
                    else
                    {
                        lstb_a_configurar.Items[i] = string.Join(G_caracter_separacion[0], elemento_espliteado);
                        cantidad_retornar_string = elemento_espliteado[5];
                    }

                }
            }


            if (esta_el_mismo_producto == false)
            {

                if (compra_o_venta == "VENTA")
                {
                    lstb_a_configurar.Items.Add(datos_espliteados[5] + G_caracter_separacion[0] + datos_espliteados[1] + G_caracter_separacion[0] + datos_espliteados[2] + G_caracter_separacion[0] + datos_espliteados[3] + G_caracter_separacion[0] + datos_espliteados[4] + G_caracter_separacion[0] + cantidad + G_caracter_separacion[0] + indice_producto + G_caracter_separacion[0]);
                }
                else
                {
                    if (provedor == "")
                    {
                        string[] prov_espliteado = datos_espliteados[8].Split(G_caracter_separacion[1][0]);
                        string provedores_del_producto = "";
                        for (int i = 0; i < prov_espliteado.Length; i++)
                        {
                            string[] info_provedor = prov_espliteado[i].Split(G_caracter_separacion[2][0]);
                            provedores_del_producto = op_tex.concatenacion_caracter_separacion(provedores_del_producto, info_provedor[0], G_caracter_separacion[1]);
                        }
                        lstb_a_configurar.Items.Add(datos_espliteados[5] + G_caracter_separacion[0] + datos_espliteados[1] + G_caracter_separacion[0] + datos_espliteados[2] + G_caracter_separacion[0] + datos_espliteados[3] + G_caracter_separacion[0] + datos_espliteados[7] + G_caracter_separacion[0] + cantidad + G_caracter_separacion[0] + indice_producto + G_caracter_separacion[0] + provedores_del_producto);
                    }
                    else
                    {
                        string[] prov_espliteado = provedor.Split(G_caracter_separacion[1][0]);
                        string provedores_del_producto = "";
                        for (int i = 0; i < prov_espliteado.Length; i++)
                        {
                            string[] info_provedor = prov_espliteado[i].Split(G_caracter_separacion[2][0]);
                            provedores_del_producto = op_tex.concatenacion_caracter_separacion(provedores_del_producto, info_provedor[0], G_caracter_separacion[1]);
                        }
                        lstb_a_configurar.Items.Add(datos_espliteados[5] + G_caracter_separacion[0] + datos_espliteados[1] + G_caracter_separacion[0] + datos_espliteados[2] + G_caracter_separacion[0] + datos_espliteados[3] + G_caracter_separacion[0] + datos_espliteados[7] + G_caracter_separacion[0] + cantidad + G_caracter_separacion[0] + indice_producto + G_caracter_separacion[0] + provedores_del_producto);
                    }

                }

                cantidad_retornar_string = "" + cantidad;
            }

            return cantidad_retornar_string;
        }

        public double sumar_precio_columna_lstbox(ListBox lstb_a_configurar, int columna_precios, int columna_cantidad, Label lbl_total = null, string caracter_separacion = null)
        {
            if (caracter_separacion == null)
            {
                caracter_separacion = G_caracter_separacion[0];
            }
            double total = 0;
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                string[] dat_produc = lstb_a_configurar.Items[i].ToString().Split(Convert.ToChar(caracter_separacion));
                total = total + (Convert.ToDouble(dat_produc[columna_cantidad]) * Convert.ToDouble(dat_produc[columna_precios]));
            }

            if (lbl_total != null) { lbl_total.Text = "" + total; }

            return total;
        }

        private void funciones_de_botones_operaciones_listbox(ListBox lstb_a_configurar, string proceso, string info_extra = "", object[] controles_extra = null)
        {
            //eliminar_por_item,eliminar_seleccionado,eliminar_ultimo,eliminar_todo
            switch (proceso)
            {
                case "ELIMINAR_POR_ITEM":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(Convert.ToInt32(info_extra));
                    }
                    break;
                case "ELIMINAR_SELECCIONADO":

                    lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.SelectedIndex);
                    break;

                case "ELIMINAR_ULTIMO":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.Items.Count - 1);
                    }
                    break;
                case "ELIMINAR_TODO":
                    lstb_a_configurar.Items.Clear();
                    break;

                case "PROCESAR_VENTA":
                    ventana_introduce_cantidad_pagada(lstb_a_configurar, "VENTA");
                    lstb_a_configurar.Items.Clear();
                    break;

                case "PROCESAR_COMPRA":
                    ventana_introduce_cantidad_pagada(lstb_a_configurar, "COMPRA");
                    lstb_a_configurar.Items.Clear();
                    break;


                case "INV_FORM_CARGAR_ARCHIVO":
                    OpenFileDialog opfd = new OpenFileDialog();
                    opfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\info_a_usar\\inventarios";
                    if (opfd.ShowDialog() == DialogResult.OK)
                    {
                        cargar_archivo_HACER_INVENTARIOS(opfd.FileName, "MOSTRAR_FALTANTES");
                    }
                    break;


                default:
                    break;
            }
        }

        public void fun_botones_entre_dos_lstbox(ListBox lstb_a_configurar_1, Button btn_usar, string proceso, ListBox lstb_a_configurar_2)
        {
            switch (proceso)
            {
                case "INV_FORM_VERIFICAR_DATOS":
                    
                    verificar_datos_para_de_lstbox_pasar_a_lstbox(lstb_a_configurar_1 , lstb_a_configurar_2);
                    
                    break;
            }
        }

        private void ventana_introduce_cantidad_pagada(ListBox lstb_a_configurar, string venta_o_compra)
        {
            string info_resultado = "";
            double total = sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5);
            string info_enviar = "";
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                //info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§COD_BAR¬1¬PLATAFORMA1╝4¬VENTAS|COD_BAR1¬1¬PLATAFORMA1╝4¬VENTAS|COD_BAR¬3¬PLATAFORMA1╝4¬VENTAS");
                string[] inf_esp = lstb_a_configurar.Items[i].ToString().Split(G_caracter_separacion[0][0]);
                info_enviar = op_tex.concatenacion_caracter_separacion(info_enviar, inf_esp[0] + G_caracter_separacion[2] + inf_esp[5] + G_caracter_separacion[2] + inf_esp[4] + G_caracter_separacion[2] + inf_esp[7] + G_caracter_separacion[2] + "0_tien" + G_caracter_separacion[3] + "0" + G_caracter_separacion[2] + venta_o_compra, G_caracter_separacion[1]);

            }

            bool pago_completo = false;
            while (pago_completo == false)
            {
                Ventana_emergente vent_emergent = new Ventana_emergente();
                string[] enviar = { "1|cantidad pagada |" + total + "|2" };

                string cantidad_en_dinero_dada = vent_emergent.Proceso_ventana_emergente(enviar);
                double cantidad_en_dinero_dada_double = Convert.ToDouble(cantidad_en_dinero_dada);

                pago_completo = true;

                if (pago_completo == true)
                {

                    //mod.modelo_unico("mod_venta", informacion_de_variables: arreglo_info_lstb);
                    if (venta_o_compra == "COMPRA")
                    {
                        info_resultado = enl_princ.enlasador("MODELO_COMPRAS~COMPRA§" + info_enviar);

                    }
                    else
                    {
                        if (cantidad_en_dinero_dada_double > total)
                        {
                            MessageBox.Show("cambio: " + (cantidad_en_dinero_dada_double - total));
                            pago_completo = true;
                        }

                        if (cantidad_en_dinero_dada_double < total)
                        {
                            MessageBox.Show("falta: " + (total - cantidad_en_dinero_dada_double));
                            pago_completo = false;
                            //ventana_introduce_cantidad_pagada(lstb_a_configurar);
                        }

                        info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§" + info_enviar);
                    }

                }


            }



        }

        public void fun_lstb_agregar_elim(ListBox lstb_a_configurar, TextBox txt_de_donde_agregara_info, string accion_realisar, double cantidad = 0, string datos = "", string indice_producto = "", Label lbl_configurar_desc_produc = null, Label lbl_configurar_cantidad_costo = null, Label lbl_configurar_total = null, string provedor_compras = "")
        {

            switch (accion_realisar)
            {
                case "AGREGAR":
                    if (txt_de_donde_agregara_info.Text != "" && txt_de_donde_agregara_info.Text != null)
                    {

                        lstb_a_configurar.Items.Add(txt_de_donde_agregara_info.Text);
                        txt_de_donde_agregara_info.Text = "";
                    }
                    break;

                //inicio agregar_productos----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                case "AGREGAR_PRODUCTO_VENTA":

                    //agrega por agregar falta revisar si ya existe el codigo
                    if (txt_de_donde_agregara_info.Text != "" && datos != "")
                    {
                        string[] info_split_produc = datos.Split(G_caracter_separacion[0][0]);




                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, datos, indice_producto, "VENTA", cantidad);

                        if (info_split_produc[0] != null)
                        {


                            if (lbl_configurar_desc_produc != null)
                            {
                                string tem_tex = info_split_produc[1] + " " + info_split_produc[2] + " " + info_split_produc[3] + " precio:" + info_split_produc[4];
                                lbl_configurar_desc_produc.Text = tem_tex;
                            }
                            if (lbl_configurar_cantidad_costo != null)
                            {
                                string tem_tex = cantidad_sumada_o_restada + " " + info_split_produc[1] + " " + info_split_produc[2] + " " + info_split_produc[3] + " " + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc[4]));
                                lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc[1] + " " + info_split_produc[2] + " " + info_split_produc[3] + " " + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc[4]));
                            }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }


                        txt_de_donde_agregara_info.Text = "";
                    }

                    break;

                case "AGREGAR_PRODUCTO_COMPRA":

                    //agrega por agregar falta revisar si ya existe el codigo
                    if (txt_de_donde_agregara_info.Text != "" && datos != "")
                    {
                        string[] info_split_produc = datos.Split(G_caracter_separacion[0][0]);


                        string cantidad_sumada_o_restada = sumar_o_restar_producto_ventas(lstb_a_configurar, datos, indice_producto, "COMPRA", cantidad, provedor_compras);

                        if (info_split_produc[0] != null)
                        {


                            if (lbl_configurar_desc_produc != null)
                            {
                                string tem_tex = info_split_produc[1] + " " + info_split_produc[2] + " " + info_split_produc[3] + " precio:" + info_split_produc[4];
                                lbl_configurar_desc_produc.Text = tem_tex;
                            }
                            if (lbl_configurar_cantidad_costo != null)
                            {
                                string tem_tex = cantidad_sumada_o_restada + " " + info_split_produc[1] + " " + info_split_produc[2] + " " + info_split_produc[3] + " " + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc[7]));
                                lbl_configurar_cantidad_costo.Text = tem_tex;
                            }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

                        }


                        txt_de_donde_agregara_info.Text = "";
                    }

                    break;

                //fin agregar_productos---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                //i------------------------------------------------------------------------------------------------------------------------
                case "ELIMINAR":

                    funciones_de_botones_operaciones_listbox(lstb_a_configurar, datos);

                    break;

                //f--------------------------------------------------------------------------------------------------------------------



                default:
                    break;
            }


        }

        public void ventana_nuevo_producto()
        {
            //tipos_medida_producto
            if (var_fun_GG_dir_arch_crear.GG_variables_string[5] == null || var_fun_GG_dir_arch_crear.GG_variables_string[5] == "")
            {
                var_fun_GG_dir_arch_crear.GG_variables_string[5] = "NOSE";
            }
            //fin_tipos_medida_producto
            //provedores
            if (var_fun_GG_dir_arch_crear.GG_variables_string[1] == null || var_fun_GG_dir_arch_crear.GG_variables_string[1] == "")
            {
                var_fun_GG_dir_arch_crear.GG_variables_string[1] = "NOSE";
            }




            string[] res_tip_med = enl_princ.enlasador("MODELO_FUNCIONES_DIVERSAS~EXTRAER_TIPOS_DE_MEDIDA§").Split(G_caracter_para_confirmacion_o_error[0][0]);

            var_fun_GG_dir_arch_crear.GG_variables_string[2] = res_tip_med[1];
            //fin_provedores
            string[] res_prov = enl_princ.enlasador("MODELO_PROVEDORES~EXTRAER_NOM_PROVEDORES§").Split(G_caracter_para_confirmacion_o_error[0][0]);
            var_fun_GG_dir_arch_crear.GG_variables_string[6] = res_prov[1];


            Ventana_emergente emergente_vent = new Ventana_emergente();
            var_fun_GG_dir_arch_crear.RecargarVentanaEmergenteProductos();
            string datos_introducidos = emergente_vent.Proceso_ventana_emergente(var_fun_GG_dir_arch_crear.GG_ventana_emergente_productos);

            string temp = "";
            for (int i = 1; i < datos_introducidos.Length; i++)
            {
                temp = temp + datos_introducidos[i];
            }
            datos_introducidos = temp;


            string info_resultado = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~AGREGAR_SINO_EXISTE§" + datos_introducidos);

        }


        

        public void cargar_archivo_HACER_INVENTARIOS(string direccion,string accion_a_hacer, object caracter_separacion_obj = null)
        {
            
            Tex_base bas = new Tex_base();
            string[] filas_archivo = bas.leer(direccion, caracter_separacion_objeto: caracter_separacion_obj);

            
            filas_archivo = op_arr.ordenar_arreglo(filas_archivo, 3);
            string filas_joineadas = string.Join(G_caracter_separacion_funciones_espesificas[3], filas_archivo);
            filas_joineadas = accion_a_hacer + G_caracter_separacion_funciones_espesificas[2] + filas_joineadas;

            enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~HACER_INVENTARIO§" + filas_joineadas);



        }


        public void ordenar_lisbox(ListBox lista_a_ordenar, int numero_columna, string orden = "menor_mayor")
        {

            if (orden == "menor_mayor")
            {
                for (int i = 0; i < lista_a_ordenar.Items.Count; i++)
                {
                    for (int j = i + 1; j < lista_a_ordenar.Items.Count; j++)
                    {

                        string[] arreglo_espliteado = lista_a_ordenar.Items[i].ToString().ToString().Split(G_caracter_separacion[0][0]);
                        double arriba = Convert.ToDouble(arreglo_espliteado[numero_columna]);
                        string[] arreglo_espliteado2 = lista_a_ordenar.Items[j].ToString().Split(G_caracter_separacion[0][0]);
                        double abajo = Convert.ToDouble(arreglo_espliteado2[numero_columna]);
                        string temp;
                        if (arriba > abajo)
                        {
                            temp = lista_a_ordenar.Items[i] + "";
                            lista_a_ordenar.Items[i] = lista_a_ordenar.Items[j];
                            lista_a_ordenar.Items[j] = temp;
                        }
                    }
                }
            }


            else if (orden == "mayor_menor")
            {
                for (int i = 0; i < lista_a_ordenar.Items.Count; i++)
                {
                    for (int j = i + 1; j < lista_a_ordenar.Items.Count; j++)
                    {

                        string[] arreglo_espliteado = lista_a_ordenar.Items[i].ToString().Split(G_caracter_separacion[0][0]);
                        double arriba = Convert.ToDouble(arreglo_espliteado[numero_columna]);
                        string[] arreglo_espliteado2 = lista_a_ordenar.Items[j].ToString().Split(G_caracter_separacion[0][0]);
                        double abajo = Convert.ToDouble(arreglo_espliteado2[numero_columna]);
                        string temp;
                        if (arriba < abajo)
                        {
                            temp = lista_a_ordenar.Items[i] + "";
                            lista_a_ordenar.Items[i] = lista_a_ordenar.Items[j];
                            lista_a_ordenar.Items[j] = temp;
                        }
                    }
                }
            }
        }

        private void verificar_datos_para_de_lstbox_pasar_a_lstbox(ListBox lstb_a_configurar_1,  ListBox lstb_a_configurar_2)
        {
            
            for (int i = 0; i < lstb_a_configurar_1.Items.Count; i++)
            {
                string[] info_spl = lstb_a_configurar_1.Items[i].ToString().Split(G_caracter_separacion[0][0]);
                
                
            }

        }

        //final clase-----------------------------------------------------------
    }
}

