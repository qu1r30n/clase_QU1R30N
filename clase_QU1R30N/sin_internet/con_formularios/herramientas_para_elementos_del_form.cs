using clase_QU1R30N.sin_internet.sin_formularios;
using clase_QU1R30N.sin_internet.sin_formularios.herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        


        //txt------------------------------------------------------------


        public void fun_txt_prediccion_palabra(TextBox txt_a_configurar, string tipo)
        {
            // Inicializar AutoCompleteStringCollection
            txt_a_configurar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_a_configurar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (tipo == "codbar")
            {
                txt_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_codbar_venta;
            }
            else if (tipo == "producto")
            {
                txt_a_configurar.AutoCompleteCustomSource = var_fun_GG.GG_autoCompleteCollection_nom_produc_venta;
            }

        }

        public void fun_txt_procesar_tecleos(TextBox txt_a_configurar, ListBox lstb_a_configurar, Label lbl_configurar_desc_produc, Label lbl_configurar_cantidad_costo, Label lbl_configurar_total)
        {
            txt_a_configurar.KeyDown += (sender, e) =>
            {
                
                if (e.KeyValue == (char)Keys.Enter)
                {
                    txt_a_configurar.Text = txt_a_configurar.Text.ToUpper();

                    string[] tex_esplit = txt_a_configurar.Text.Split(Convert.ToChar(G_caracter_separacion[0]));
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


                    }
                    else
                    {
                        string[] info_producto = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        //encontro el producto?
                        if (Convert.ToInt32( info_producto[0])>0)
                        {
                            string[] info_split_produc_inv = info_producto[1].Split(G_caracter_separacion[0][0]);
                            string indice_producto = info_producto[2];
                        }
                        else
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
                        }
                        
                    }


                }

                else if (e.KeyValue == (char)(Keys.Add))
                {
                    //e.KeyChar = '\0';//este evita que escrivas cuando usas keypress
                    e.SuppressKeyPress = true;

                    if (lstb_a_configurar.Items.Count > 0)
                    {

                        string[]tex_esplit=lstb_a_configurar.Items[lstb_a_configurar.Items.Count - 1].ToString().Split(Convert.ToChar(G_caracter_separacion[0]));
                        string[] result_busq = enl_princ.enlasador("MODELO_PRODUCTOS_E_INVENTARIO~BUSCAR§" + tex_esplit[0] + G_caracter_separacion[0] + tex_esplit[6]).Split(G_caracter_para_confirmacion_o_error[0][0]);
                        string[] info_split_produc_inv = result_busq[1].Split(G_caracter_separacion[0][0]);
                        double cantidad = 1;

                        

                        if (info_split_produc_inv[9] == "PRODUCTO_CANTIDAD")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2°producto°" + info_split_produc_inv[3], "1°cantidad en litros o kilos(se puede decimal)°°2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto(lstb_a_configurar, result_busq[1], result_busq[2], cantidad);

                        if (info_split_produc_inv[0] != null)
                        {


                            if (lbl_configurar_desc_produc != null) { lbl_configurar_desc_produc.Text = info_split_produc_inv[1] + " " + info_split_produc_inv[2] + " " + info_split_produc_inv[3] + " precio:$" + info_split_produc_inv[4]; }
                            if (lbl_configurar_cantidad_costo != null) { lbl_configurar_cantidad_costo.Text = cantidad_sumada_o_restada + " " + info_split_produc_inv[1] + " " + info_split_produc_inv[2] + "" + info_split_produc_inv[3] + " $" + (Convert.ToDouble(cantidad_sumada_o_restada) * Convert.ToDouble(info_split_produc_inv[4])); }
                            sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);

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



                        if (info_split_produc_inv[9] == "2")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2°producto°" + info_split_produc_inv[3], "1°cantidad en litros o kilos(se puede decimal)°°2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto(lstb_a_configurar, result_busq[1], result_busq[2], cantidad);

                        if (info_split_produc_inv[0] != null)
                        {

                            if (Convert.ToDouble(cantidad_sumada_o_restada)>0)
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


        public void fun_botones(ListBox lstb_a_configurar, Button btn_usar, string proceso, Label lbl_configurar_desc_produc, Label lbl_configurar_cantidad_costo, Label lbl_configurar_total)
        {
            btn_usar.Click += (sender, e) =>
            {
                //eliminar_por_item,eliminar_seleccionado,eliminar_ultimo,eliminar_todo
                funciones_de_botones(lstb_a_configurar, proceso);


                lbl_configurar_desc_produc.Text = "nombre del producto";
                lbl_configurar_cantidad_costo.Text = "$";
                sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5, lbl_configurar_total);



            };
        }





        public string sumar_o_restar_producto(ListBox lstb_a_configurar, string datos, string indice_producto, double cantidad = 1)
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
                        funciones_de_botones(lstb_a_configurar, "eliminar_por_item", i + "");
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
                
                lstb_a_configurar.Items.Add(datos_espliteados[5] + G_caracter_separacion[0] + datos_espliteados[1] + G_caracter_separacion[0] + datos_espliteados[2] + G_caracter_separacion[0] + datos_espliteados[3] + G_caracter_separacion[0] + datos_espliteados[4] + G_caracter_separacion[0] + cantidad + G_caracter_separacion[0] + indice_producto);
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

        public void funciones_de_botones(ListBox lstb_a_configurar, string proceso, string info_extra = "")
        {
            //eliminar_por_item,eliminar_seleccionado,eliminar_ultimo,eliminar_todo
            switch (proceso)
            {
                case "eliminar_por_item":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(Convert.ToInt32(info_extra));
                    }
                    break;
                case "eliminar_seleccionado":

                    lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.SelectedIndex);
                    break;

                case "eliminar_ultimo":
                    if (lstb_a_configurar.Items.Count > 0)
                    {
                        lstb_a_configurar.Items.RemoveAt(lstb_a_configurar.Items.Count - 1);
                    }
                    break;
                case "eliminar_todo":
                    lstb_a_configurar.Items.Clear();
                    break;

                case "procesar_venta":
                    ventana_introduce_cantidad_pagada(lstb_a_configurar);
                    lstb_a_configurar.Items.Clear();
                    break;

                default:
                    break;
            }
        }


        private void ventana_introduce_cantidad_pagada(ListBox lstb_a_configurar)
        {
            string info_resultado = "";
            double total = sumar_precio_columna_lstbox(lstb_a_configurar, 4, 5);
            string info_enviar = "";
            for (int i = 0; i < lstb_a_configurar.Items.Count; i++)
            {
                //info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§COD_BAR¬1¬PLATAFORMA1╝4¬VENTAS°COD_BAR1¬1¬PLATAFORMA1╝4¬VENTAS°COD_BAR¬3¬PLATAFORMA1╝4¬VENTAS");
                string[] inf_esp = lstb_a_configurar.Items[i].ToString().Split(G_caracter_separacion[0][0]);
                info_enviar = op_tex.concatenacion_caracter_separacion(info_enviar, inf_esp[0] + G_caracter_separacion[2] + inf_esp[5] + G_caracter_separacion[2] + "0_tien" + G_caracter_separacion[3] + "0" + G_caracter_separacion[2] + "VENTAS", G_caracter_separacion[1]);
                
            }

            bool pago_completo = false;
            while (pago_completo == false)
            {
                Ventana_emergente vent_emergent = new Ventana_emergente();
                string[] enviar = { "1|cantidad pagada|" + total + "|2" };

                string cantidad_en_dinero_dada = vent_emergent.Proceso_ventana_emergente(enviar);
                double cantidad_en_dinero_dada_double = Convert.ToDouble(cantidad_en_dinero_dada);





                if (total + "" == cantidad_en_dinero_dada)
                {
                    //mod.modelo_unico("mod_venta", informacion_de_variables: arreglo_info_lstb);
                    
                    info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§"+info_enviar);
                    pago_completo = true;
                }
                else if (cantidad_en_dinero_dada_double > total)
                {
                    info_resultado = enl_princ.enlasador("MODELO_VENTAS~VENTA§" + info_enviar);
                    MessageBox.Show("cambio: " + (cantidad_en_dinero_dada_double - total));
                    pago_completo = true;
                }
                else if (cantidad_en_dinero_dada_double < total)
                {
                    MessageBox.Show("falta: " + (total - cantidad_en_dinero_dada_double));
                    //ventana_introduce_cantidad_pagada(lstb_a_configurar);
                }
            }
        }

        
        public void fun_lstb_agregar_elim(ListBox lstb_a_configurar, TextBox txt_de_donde_agregara_info, string accion_realisar, double cantidad = 0, string datos = "", string indice_producto = "", Label lbl_configurar_desc_produc = null, Label lbl_configurar_cantidad_costo = null, Label lbl_configurar_total = null)
        {

            switch (accion_realisar)
            {
                case "agregar":
                    if (txt_de_donde_agregara_info.Text != "" && txt_de_donde_agregara_info.Text != null)
                    {

                        lstb_a_configurar.Items.Add(txt_de_donde_agregara_info.Text);
                        txt_de_donde_agregara_info.Text = "";
                    }
                    break;

                //inicio agregar_productos----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                case "agregar_producto":

                    //agrega por agregar falta revisar si ya existe el codigo
                    if (txt_de_donde_agregara_info.Text != "" && datos != "")
                    {
                        string[] info_split_produc = datos.Split(G_caracter_separacion[0][0]);



                        if (info_split_produc[9] == "2")
                        {
                            Ventana_emergente vent_emergent = new Ventana_emergente();
                            string[] enviar = { "2°producto°" + "info_produc_del_invent[3]", "1°cantidad en litros o kilos(se puede decimal)°°2" };
                            string result = vent_emergent.Proceso_ventana_emergente(enviar);
                            if (result != "")
                            {
                                cantidad = Convert.ToDouble(result);
                            }

                        }

                        string cantidad_sumada_o_restada = sumar_o_restar_producto(lstb_a_configurar, datos,indice_producto, cantidad);

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

                //fin agregar_productos---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                //i------------------------------------------------------------------------------------------------------------------------
                case "eliminar":

                    funciones_de_botones(lstb_a_configurar, datos);

                    break;

                //f--------------------------------------------------------------------------------------------------------------------



                default:
                    break;
            }


        }

        //final clase-----------------------------------------------------------
    }
}
