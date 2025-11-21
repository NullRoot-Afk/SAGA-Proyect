using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SAGA_EV3
{
    public partial class Form2 : Form
    {
        private DataTable dt_inventario = new DataTable();
        private DataTable dt_usuarios = new DataTable();
        private DataTable dt_empleados = new DataTable();
        private List<Usuario> usuarios = new List<Usuario>();
        private string usuario;
        private string rol;
        private bool agregar = false;
        private string perfil_editado;

        public Form2(string usuario, string rol)
        {
            InitializeComponent();
            Inicializar_dgv();
            CargarDatosUsuarios();
            Cargardatos_inventario();
            this.usuario = usuario;
            this.rol = rol;
            Lbl_usuario_logeado.Text = $"Usuario: {usuario} - Rol: {rol}";
            if (this.rol == "Empleado")
            {
                Tsm_gestion_usuarios.Enabled = false;
                Tsm_nuevo_prod.Enabled = false;
                TSM_eliminar_producto.Enabled = false;
                Tsm_gestion_empleados.Enabled = false;

            }
        }
        private void Tsm_nuevo_prod_Click(object sender, EventArgs e)
        {
            DGV_inventario.Refresh();
            //Adjusting panel visibility
            Pnl_agregar_nuevo.Visible = true;
            Pnl_agregar_existente.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_gestionUsuarios.Visible = false;
            Pnl_gestion_empleados.Visible = false;
            //Adjusting checks
            Tsm_agregar_existente.Checked = false;
            Tsm_agregar.Checked = true;
            Tsm_Eliminar.Checked = false;
            TSM_eliminar_existencias.Checked = false;
            TSM_eliminar_producto.Checked = false;
            Tsm_nuevo_prod.Checked = true;
        }
        private void Tsm_agregar_existente_Click(object sender, EventArgs e)
        {
            DGV_inventario.Refresh();
            //Adjusting panel visibility
            Pnl_agregar_existente.Visible = true;
            Pnl_agregar_nuevo.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_gestionUsuarios.Visible = false;
            Pnl_gestion_empleados.Visible = false;
            //Adjusting checks
            Tsm_nuevo_prod.Checked = false;
            Tsm_Eliminar.Checked = false;
            Tsm_agregar.Checked = true;
            Tsm_agregar_existente.Checked = true;
            TSM_eliminar_existencias.Checked = false;
            TSM_eliminar_producto.Checked = false;
        }
        private void Inicializar_dgv()
        {
            if (!File.Exists("Users.TXT")) return;
            dt_usuarios.Columns.Add("Nombre de Usuario", typeof(string));
            dt_usuarios.Columns.Add("Tipo de Usuario", typeof(string));
            dt_usuarios.Columns.Add("Fecha de Creacion", typeof(string));

        }
        private void CargarDatosEmpleados()
        {
            dt_empleados.Clear();
            if (File.Exists("Empleados.txt"))
            {
                try
                {
                    if (dt_empleados.Columns.Count != 4) 
                    {
                        
                        dt_empleados.Columns.Add("Nombre", typeof(string));
                        dt_empleados.Columns.Add("Cargo", typeof(string));
                        dt_empleados.Columns.Add("Edad", typeof(string));
                        dt_empleados.Columns.Add("Fecha", typeof(string));
                    }
                    string[] lineas_empleados = File.ReadAllLines("Empleados.txt");
                    foreach (string Empleado in lineas_empleados)
                    {
                        string[] partes = Empleado.Split(';');
                        if (partes.Length != 4) 
                        {
                            MessageBox.Show("Los datos de un usuario no estan completos");
                            continue;
                        }
                        else
                        {
                            dt_empleados.Rows.Add(partes);
                        }
                    }
                    Dgv_empleados.DataSource = dt_empleados;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void CargarDatosUsuarios()
        {
            try
            {
                usuarios.Clear();
                dt_usuarios.Clear();
                string[] lines = File.ReadAllLines("Users.TXT");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts.Length == 4)
                    {
                        usuarios.Add(new Usuario(parts[0], parts[1], parts[2], parts[3]));
                        dt_usuarios.Rows.Add(usuarios[i].GetNombre(), usuarios[i].GetRol(), usuarios[i].GetFechaCreacion());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El inventario ha quedado vacio", "Emergencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //fin de seccion redundante(separar en un metodo unico)
            Dgv_gestionUsuarios.DataSource = dt_usuarios;
        }
        private void Cargardatos_inventario()
        {   //inicio de seccion redundante(separar en un metodo unico para reutilizar codigo)
            //Code to load data into the DataGridView
            if (!File.Exists("Inventario.TXT")) return;
            dt_inventario.Clear();
            dt_inventario.Columns.Clear();
            dt_inventario.Columns.Add("Nombre", typeof(string));
            dt_inventario.Columns.Add("Cantidad", typeof(int));
            dt_inventario.Columns.Add("Tipo", typeof(string));
            try
            {
                string[] lines = File.ReadAllLines("Inventario.TXT");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts.Length == 3)
                    {
                        dt_inventario.Rows.Add(parts[0], int.Parse(parts[1]), parts[2]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El inventario ha quedado vacio", "Emergencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //fin de seccion redundante
            // Assigning DataTable to DataGridView and ComboBox
            DGV_inventario.DataSource = dt_inventario;
            Dgv_inventario_copia1.DataSource = dt_inventario;
            Dgv_inventario_copia2.DataSource = dt_inventario;
            Dgv_inventario_copia3.DataSource = dt_inventario;
            CBX_producto_eliminacion.DataSource = dt_inventario;
            CBX_producto_eliminacion.DisplayMember = "Nombre";
            CBX_producto_eliminacion.ValueMember = "Nombre";
            CBX_producto_eliminacion.SelectedIndex = -1;
            CBX_producto_eliminacion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_existencia.DataSource = dt_inventario;
            CBX_existencia.DisplayMember = "Nombre";
            CBX_existencia.ValueMember = "Nombre";
            CBX_existencia.SelectedIndex = -1;
            CBX_existencia.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_eliminacion.DataSource = dt_inventario;
            CBX_eliminacion.DisplayMember = "Nombre";
            CBX_eliminacion.ValueMember = "Nombre";
            CBX_eliminacion.SelectedIndex = -1;
            CBX_eliminacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Btn_Agregar_prod_nuevo_Click(object sender, EventArgs e)
        {
            if (Txb_producto_nuevo.Text == "" || Txb_cantidad_prod_nuevo.Text == "" || Cbx_tipo_insumo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(Txb_cantidad_prod_nuevo.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Existe_producto(Txb_producto_nuevo.Text))
            {
                MessageBox.Show("El producto ya existe, si desea agregar existencias vaya al apartado correspondiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nombre_producto = Txb_producto_nuevo.Text.Trim();
                using (StreamWriter inventario = new StreamWriter("Inventario.TXT", true))
                {
                    inventario.WriteLine($"{Txb_producto_nuevo.Text};{cantidad};{Cbx_tipo_insumo.SelectedItem.ToString()}");
                }
                MessageBox.Show("Producto agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargardatos_inventario();
            }
            Cbx_tipo_insumo.SelectedIndex = -1;
            Txb_cantidad_prod_nuevo.Text = string.Empty;
            Txb_producto_nuevo.Text = string.Empty;
        }
        private bool Existe_producto(string nombre)
        {
            foreach (DataRow row in dt_inventario.Rows)
            {
                if (row["Nombre"].ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private bool Validar_modificacion_productos(ComboBox seleccion, TextBox numero, string tipo)
        {
            string tipo_operacion = tipo;
            if (seleccion.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto para agregar o restar existencias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow[] fila_objetivo = dt_inventario.Select($"Nombre = '{seleccion.SelectedValue.ToString()}'");
            int cantidad_actual = int.Parse(fila_objetivo[0]["Cantidad"].ToString());
            if (tipo_operacion == "resta")
            {
                if (!int.TryParse(numero.Text, out int cantidad) || int.Parse(numero.Text) <= 0 || int.Parse(numero.Text) > cantidad_actual)
                {
                    MessageBox.Show("La cantidad agregada debe ser mayor que cero y menor que la cantidad total en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
                {

                }
            }
            else
            {
                if (!int.TryParse(numero.Text, out int cantidad) || int.Parse(numero.Text) <= 0)
                {
                    MessageBox.Show("La cantidad agregada debe ser mayor que cero y menor que la cantidad total en inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
                {

                }
            }

        }
        private void BTN_eliminar_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (CBX_producto_eliminacion.SelectedIndex == -1 || CBX_producto_eliminacion.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el producto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string seleccionado = CBX_producto_eliminacion.SelectedValue.ToString();
            var sb = new StringBuilder();

            // Construir todo el contenido nuevo en memoria (sin el producto a eliminar)
            for (int i = 0; i < dt_inventario.Rows.Count; i++)
            {
                var nombreObj = dt_inventario.Rows[i]["Nombre"];
                if (nombreObj == null || nombreObj == DBNull.Value) continue;

                string nombre = nombreObj.ToString();
                //Transferir solo los que no coinciden con el seleccionado
                if (!string.Equals(nombre, seleccionado, StringComparison.Ordinal))
                {
                    sb.AppendFormat("{0};{1};{2}\n", dt_inventario.Rows[i]["Nombre"], dt_inventario.Rows[i]["Cantidad"], dt_inventario.Rows[i]["Tipo"]);
                }
            }
            File.WriteAllText("Inventario.TXT", sb.ToString());

            MessageBox.Show("Producto eliminado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cargardatos_inventario();
        }
        private void BTN_eliminar_cantidad_Click(object sender, EventArgs e)
        {
            if (Validar_modificacion_productos(CBX_eliminacion, TXB_Eliminacion_cantidad, "resta"))
            {
                if (CBX_eliminacion.SelectedIndex == -1 || TXB_Eliminacion_cantidad.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string seleccionado = CBX_eliminacion.SelectedValue.ToString();
                var sb = new StringBuilder();

                // Construir todo el contenido nuevo en memoria (sin el producto a modificar)
                for (int i = 0; i < dt_inventario.Rows.Count; i++)
                {
                    var nombreObj = dt_inventario.Rows[i]["Nombre"];
                    if (nombreObj == null || nombreObj == DBNull.Value) continue;

                    string nombre = nombreObj.ToString();
                    //Transferir solo los que no coinciden con el seleccionado
                    if (!string.Equals(nombre, seleccionado, StringComparison.Ordinal))
                    {
                        sb.AppendFormat("{0};{1};{2}\n", dt_inventario.Rows[i]["Nombre"], dt_inventario.Rows[i]["Cantidad"], dt_inventario.Rows[i]["Tipo"]);
                    }
                    else
                    {
                        int nueva_cantidad = int.Parse(dt_inventario.Rows[i]["Cantidad"].ToString()) - int.Parse(TXB_Eliminacion_cantidad.Text);
                        sb.AppendFormat("{0};{1};{2}\n", dt_inventario.Rows[i]["Nombre"], nueva_cantidad, dt_inventario.Rows[i]["Tipo"]);
                    }
                }
                File.WriteAllText("Inventario.TXT", sb.ToString());
                MessageBox.Show("Existencias eliminadas exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargardatos_inventario();
                CBX_eliminacion.SelectedIndex = -1;
                TXB_Eliminacion_cantidad.Text = "";
            }
        }
        private void TSM_eliminar_producto_Click(object sender, EventArgs e)
        {
            PNL_eliminacion_producto.Visible = true;
            PNL_eliminacion_cantidad.Visible = false;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            Pnl_gestionUsuarios.Visible = false;
            Pnl_gestion_empleados.Visible = false;

            TSM_eliminar_producto.Checked = true;
            Tsm_Eliminar.Checked = true;
            TSM_eliminar_existencias.Checked = false;
            Tsm_agregar.Checked = false;
            Tsm_agregar_existente.Checked = false;
            Tsm_nuevo_prod.Checked = false;
        }

        private void TSM_eliminar_existencias_Click(object sender, EventArgs e)
        {
            PNL_eliminacion_cantidad.Visible = true;
            PNL_eliminacion_producto.Visible = false;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            Pnl_gestionUsuarios.Visible = false;
            Pnl_gestion_empleados.Visible = false;

            Tsm_Eliminar.Checked = true;
            TSM_eliminar_existencias.Checked = true;
            TSM_eliminar_producto.Checked = false;
            Tsm_nuevo_prod.Checked = false;
            Tsm_agregar_existente.Checked = false;

            Tsm_agregar.Checked = false;


            Tsm_agregar.Checked = false;
            Tsm_agregar_existente.Checked = false;
            Tsm_nuevo_prod.Checked = false;
        }
        private void Tsm_gestion_usuarios_Click(object sender, EventArgs e)
        {

            Pnl_gestionUsuarios.Visible = true;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            Pnl_gestion_empleados.Visible=false;    
        }
        private void Btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void Btn_filtrar_Click(object sender, EventArgs e)
        {



        }

        private bool Guardar_cambios_usuario()
        {
            var sb = new StringBuilder();
            foreach (var user in usuarios)
            {
                sb.AppendFormat("{0};{1};{2};{3}\n", user.GetNombre(), user.GetHash(), user.GetRol(), user.GetFechaCreacion());
            }
            File.WriteAllText("Users.TXT", sb.ToString());
            return true;
        }

        private void Dgv_gestionUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            Btn_editar_usuario.Enabled = Dgv_gestionUsuarios.SelectedRows.Count == 1;
        }

        private void BTN_agregar_existencias_Click_1(object sender, EventArgs e)
        {
            if (Validar_modificacion_productos(CBX_existencia, TXB_agregar_cantidad_existencia, "suma"))
            {
                if (CBX_existencia.SelectedIndex == -1 || TXB_agregar_cantidad_existencia.Text == "")
                {
                    MessageBox.Show("Debe seleccionar el producto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string seleccionado = CBX_existencia.SelectedValue.ToString();
                var sb = new StringBuilder();

                // Construir todo el contenido nuevo en memoria (sin el producto a modificar)
                for (int i = 0; i < dt_inventario.Rows.Count; i++)
                {
                    var nombreObj = dt_inventario.Rows[i]["Nombre"];
                    if (nombreObj == null || nombreObj == DBNull.Value) continue;

                    string nombre = nombreObj.ToString();
                    //Transferir solo los que no coinciden con el seleccionado
                    if (!string.Equals(nombre, seleccionado, StringComparison.Ordinal))
                    {
                        sb.AppendFormat("{0};{1};{2}\n", dt_inventario.Rows[i]["Nombre"], dt_inventario.Rows[i]["Cantidad"], dt_inventario.Rows[i]["Tipo"]);
                    }
                    else
                    {
                        int nueva_cantidad = int.Parse(dt_inventario.Rows[i]["Cantidad"].ToString()) + int.Parse(TXB_agregar_cantidad_existencia.Text);
                        sb.AppendFormat("{0};{1};{2}\n", dt_inventario.Rows[i]["Nombre"], nueva_cantidad, dt_inventario.Rows[i]["Tipo"]);
                    }
                }
                File.WriteAllText("Inventario.TXT", sb.ToString());
                MessageBox.Show("Existencias agregadas exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargardatos_inventario();
                TXB_agregar_cantidad_existencia.Text = string.Empty;

            }
        }
        string usuario_seleccionado;
        private Usuario user;
        private void Btn_editar_Click_1(object sender, EventArgs e)
        {
            Pnl_edicion_usuario.Visible = true;
            Pnl_agregar_usuario.Visible = false;
            try
            {
                if (Dgv_gestionUsuarios.SelectedRows.Count == 1)
                {
                    usuario_seleccionado = Dgv_gestionUsuarios.SelectedRows[0].Cells["Nombre de Usuario"].Value.ToString();
                    Txb_modificar_nombre_usuario.Text = usuario_seleccionado;
                    user = usuarios.FirstOrDefault(x => string.Equals(x.GetNombre().Trim(), usuario_seleccionado.Trim(), StringComparison.OrdinalIgnoreCase));

                    if (user.GetRol() == "Administrador")
                    {
                        Cbx_modificar_tipo_usuario.SelectedIndex = 0;
                    }
                    else
                    {
                        Cbx_modificar_tipo_usuario.SelectedIndex = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un solo usuario para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_guardar_cambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txb_modificar_nombre_usuario.Text.Trim() != "" && Cbx_modificar_tipo_usuario.SelectedIndex != -1)
                {
                    user._Nombre = Txb_modificar_nombre_usuario.Text.Trim();
                    user._Rol = Cbx_modificar_tipo_usuario.SelectedItem.ToString();
                    if (Tbx_modificar_contraseña.Text.Trim() != "")
                    {
                        if (Tbx_modificar_contraseña.Text.Length >= 8)
                        {
                            user.establecer_contraseña(Tbx_modificar_contraseña.Text.Trim());
                        }
                        else
                        {
                            MessageBox.Show("La contraseña ingresada no es valida, por favor ingresa una contraseña de mas de 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (Guardar_cambios_usuario())
                {
                    CargarDatosUsuarios();
                    MessageBox.Show("Cambios guardados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pnl_edicion_usuario.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            Pnl_agregar_usuario.Visible = true;
            Pnl_edicion_usuario.Visible = false;
        }

        private void Btn_nuevo_usuario_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Txb_nuevo_usuario_nombre.Text);
                if (Txb_nuevo_usuario_nombre.Text.Trim() != "" && Cbx_nuevo_usuario_tipo.SelectedIndex != -1 && Txb_nuevo_usuario_contraseña.Text.Trim() != "" && Txb_nuevo_usuario_contraseña.Text.Trim().Length > 8)
                {
                    usuarios.Add(new Usuario(Txb_nuevo_usuario_nombre.Text, Argon2Hasher.HashPassword(Txb_nuevo_usuario_contraseña.Text).ToString(), Cbx_nuevo_usuario_tipo.SelectedItem.ToString(), DateTime.Now.ToString()));
                    if (Guardar_cambios_usuario())
                    {
                        CargarDatosUsuarios();
                        MessageBox.Show("Cambios guardados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pnl_edicion_usuario.Visible = false;
                        Pnl_agregar_usuario.Visible = false;
                        Guardar_cambios_usuario();
                        CargarDatosUsuarios();
                        Txb_nuevo_usuario_contraseña.Text = string.Empty;
                        Txb_nuevo_usuario_nombre.Text = string.Empty;
                        Cbx_nuevo_usuario_tipo.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void Btn_filtrar_Click_1(object sender, EventArgs e)
        {
            if (Txb_filtro_nombre_usuario.Text.Trim() == "" && Cbx_filtro_tipo_usuario.SelectedIndex != -1)
            {
                try
                {
                    string filtro_tipo = Cbx_filtro_tipo_usuario.SelectedItem.ToString();
                    DataView dv = dt_usuarios.DefaultView;
                    dv.RowFilter = $"[Tipo de Usuario] LIKE '%{filtro_tipo}%'";
                    Dgv_gestionUsuarios.DataSource = dv.ToTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Txb_filtro_nombre_usuario.Text.Trim() != "" && Cbx_filtro_tipo_usuario.SelectedIndex == -1)
            {
                try
                {
                    string filtro_nombre = Txb_filtro_nombre_usuario.Text.Trim();
                    DataView dv = dt_usuarios.DefaultView;
                    dv.RowFilter = $"[Nombre de Usuario] LIKE '%{filtro_nombre}%'";
                    Dgv_gestionUsuarios.DataSource = dv.ToTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Txb_filtro_nombre_usuario.Text.Trim() != "" && Cbx_filtro_tipo_usuario.SelectedIndex != -1)
            {
                try
                {
                    string filtro_tipo = Cbx_filtro_tipo_usuario.SelectedItem.ToString();
                    string filtro_nombre = Txb_filtro_nombre_usuario.Text.Trim();
                    DataView dv = dt_usuarios.DefaultView;
                    dv.RowFilter = $"[Nombre de Usuario] LIKE '%{filtro_nombre}%' AND [Tipo de Usuario] LIKE '%{filtro_tipo}%'";
                    Dgv_gestionUsuarios.DataSource = dv.ToTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Primero debe establecer los criterios de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Btn_eliminar_usuario_Click(object sender, EventArgs e)
        {
            if (Dgv_gestionUsuarios.SelectedRows.Count == 0) return;
            string seleccionado = Dgv_gestionUsuarios.SelectedRows[0].Cells["Nombre de Usuario"].Value.ToString();
            usuarios.RemoveAll(u => string.Equals(u.GetNombre(), seleccionado, StringComparison.OrdinalIgnoreCase));
            Guardar_cambios_usuario();
            CargarDatosUsuarios();
        }

        private void Btn_restablecer_filtros_Click(object sender, EventArgs e)
        {
            Cbx_filtro_tipo_usuario.SelectedIndex = -1;
            DataView dv = dt_usuarios.DefaultView;
            dv.RowFilter = "";
            Dgv_gestionUsuarios.DataSource = dv.ToTable();
            Txb_filtro_nombre_usuario.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleados();
        }

        private void btn_restablecer_filtros_empleado_Click(object sender, EventArgs e)
        {
            Cbx_tipo_empleado_filtro.SelectedIndex = -1;
            DataView dv = dt_empleados.DefaultView;
            dv.RowFilter = "";
            Dgv_empleados.DataSource = dv.ToTable();
            Txb_nombre_empleado_filtro.Text = string.Empty;

        }
        private (string nombre,string edad, string cargo ,DateTime fecha) Obtener_datos_perfil()
        {
            string selected_profile_age = Dgv_empleados.SelectedRows[0].Cells["Edad"].Value.ToString();
            string selected_profile_name = Dgv_empleados.SelectedRows[0].Cells["Nombre"].Value.ToString();
            string selected_profile_cargo = Dgv_empleados.SelectedRows[0].Cells["Cargo"].Value.ToString();
            DateTime fecha_ingreso = DateTime.Parse(Dgv_empleados.SelectedRows[0].Cells["Fecha"].Value.ToString());
            return (selected_profile_name, selected_profile_age, selected_profile_cargo, fecha_ingreso);

        }

        private void Btn_editar_empleado_Click(object sender, EventArgs e)
        {
            var (profile_name,profile_age,profile_cargo,profile_fecha) = Obtener_datos_perfil();
            
            agregar = false;
            perfil_editado = profile_name;
            Lbl_panel_empleados.Text = "Panel de edicion";
            Pnl_edicion_empleado.Visible = true;
            Txb_nombre_empleado.Text = profile_name ;
            Txb_edad_empleado.Text = profile_age;
            Dtp_ingreso_empleado.Value = profile_fecha;
            switch (profile_cargo)
            {
                case "Gerente":
                    Cbx_tipo_empleado.SelectedIndex = 0;
                    break;
                case "Cuidador":
                    Cbx_tipo_empleado.SelectedIndex = 1;
                    break;
                default:
                    Cbx_tipo_empleado.SelectedIndex = 2;
                    break;
            }
        }
        private (bool ok, string nombre, string cargo, string edad, DateTime fecha) Obtener_datos_nuevos()
        {
            try
            {
                string nombre = Txb_nombre_empleado.Text;
                string edad = Txb_edad_empleado.Text;
                string cargo = Cbx_tipo_empleado.SelectedItem.ToString();
                DateTime fecha = Dtp_ingreso_empleado.Value;
               
                return (true, nombre, cargo,edad, fecha);
            }
            catch (Exception e)
            {
                MessageBox.Show("algo paso en el metodo");
                return (false,"","","",DateTime.MinValue);
            }
        }
        private void Btn_agregar_empleado_Click(object sender, EventArgs e)
        {
            

            agregar = true;
            Lbl_panel_empleados.Text = "Añadir empleado";
            Pnl_edicion_empleado.Visible = true;
            Limpiar_datos_empleado();
        }
        private bool Actualizar_documento()
        {
            try
            {
                var (ok, profile_name, profile_cargo, profile_age, profile_fecha) = Obtener_datos_nuevos();
                if (ok)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0};{1};{2};{3}", profile_name, profile_cargo, profile_age, profile_fecha.ToString("dd-MM-yyyy"));
                    using (StreamWriter empleados = new StreamWriter("Empleados.txt", true))
                    {
                        empleados.WriteLine(sb);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("ocurrio un error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hiciste algo mal"+ ex);
                return false;
            }
        }
        private void Dgv_empleados_Leave(object sender, EventArgs e)
        {
        }
        private void Limpiar_datos_empleado()
        {
            Txb_edad_empleado.Text = string.Empty;
            Txb_nombre_empleado.Text = string.Empty;
            Cbx_tipo_empleado.SelectedIndex = -1;
            Dtp_ingreso_empleado.Value = DateTime.Now;
        }
        private void Guardar_cambios_empleado()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dt_empleados.Rows.Count; i++)
            {
                try
                {
                    var nombre_obj = dt_empleados.Rows[i]["Nombre"];
                    if (nombre_obj == null || nombre_obj == DBNull.Value) continue;
                    string nombre = nombre_obj.ToString();
                    //Transferir solo los que no coinciden con el seleccionado
                    if (!string.Equals(nombre, perfil_editado, StringComparison.Ordinal))
                    {
                        sb.AppendFormat("{0};{1};{2};{3}\n", dt_empleados.Rows[i]["Nombre"], dt_empleados.Rows[i]["Cargo"], dt_empleados.Rows[i]["Edad"], dt_empleados.Rows[i]["Fecha"]);
                    }
                    else
                    {
                        sb.AppendFormat("{0};{1};{2};{3}\n", Txb_nombre_empleado.Text, Cbx_tipo_empleado.SelectedItem.ToString(), Txb_edad_empleado.Text, Dtp_ingreso_empleado.Value.ToShortDateString());
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show($"Ocurrio un error: {e}");
                }
            }
            File.WriteAllText("Empleados.txt", sb.ToString());

        }

        private void Btn_guardar_cambios_empleados_Click(object sender, EventArgs e)
        {
            //cambiamos comportamineto dependiendo de la operacion realizada
            switch (agregar){
                case true:
                    Actualizar_documento();
                    MessageBox.Show("El boton ejecuto el algoritmo para agregar empleado nuevo");
                    break;
                case false:
                    Guardar_cambios_empleado();
                    MessageBox.Show("El boton ejecuto el algoritmo para editar empleado");
                    break;
            }
            Limpiar_datos_empleado();
            CargarDatosEmpleados();
        }

        private void Btn_filtar_empleados_Click(object sender, EventArgs e)
        {
            if (Txb_nombre_empleado_filtro.Text.Trim() == "" && Cbx_tipo_empleado_filtro.SelectedIndex != -1)
            {
                try
                {
                    string filtro_tipo = Cbx_tipo_empleado_filtro.SelectedItem.ToString();
                    DataView dv = dt_empleados.DefaultView;
                    dv.RowFilter = $"[Cargo] LIKE '%{filtro_tipo}%'";
                    Dgv_empleados.DataSource = dv.ToTable();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Txb_nombre_empleado_filtro.Text.Trim() != "" && Cbx_tipo_empleado_filtro.SelectedIndex == - 1)
            {
                try
                {
                    string filtro_nombre = Txb_nombre_empleado_filtro.Text.Trim();
                    DataView dv = dt_empleados.DefaultView;
                    dv.RowFilter = $"[Nombre] LIKE '%{filtro_nombre}%'";
                    Dgv_empleados.DataSource = dv.ToTable();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (Txb_nombre_empleado_filtro.Text.Trim() != "" && Cbx_tipo_empleado_filtro.SelectedIndex != -1)
            {
                try
                {
                    string filtro_tipo = Cbx_tipo_empleado_filtro.SelectedItem.ToString();
                    string filtro_nombre = Txb_nombre_empleado_filtro.Text.Trim();
                    DataView dv = dt_empleados.DefaultView;
                    dv.RowFilter = $"[Nombre] LIKE '%{filtro_nombre}%' AND [Cargo] LIKE '%{filtro_tipo}%'";
                    Dgv_empleados.DataSource = dv.ToTable();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al aplicar filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Primero debe establecer los criterios de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void Btn_eliminar_empleado_Click(object sender, EventArgs e)
        {
            string seleccionado = Dgv_empleados.SelectedRows[0].Cells["Nombre"].Value.ToString();
            StringBuilder sb = new StringBuilder();
            foreach (DataRow perfil in dt_empleados.Rows)
            {
                if (perfil[0].ToString() != seleccionado)
                {
                    sb.AppendFormat("{0};{1};{2};{3}\n", perfil["Nombre"], perfil["Cargo"], perfil["Edad"], perfil["Fecha"]);
                }
            }
            File.WriteAllText("Empleados.txt", sb.ToString());
            CargarDatosEmpleados();
        }

        private void Tsm_gestion_empleados_Click(object sender, EventArgs e)
        {
            Pnl_gestion_empleados.Visible = true;
            Pnl_gestionUsuarios.Visible = false;
            Pnl_agregar_existente.Visible = false;
            Pnl_agregar_nuevo.Visible = false;
            PNL_eliminacion_cantidad.Visible = false;
            PNL_eliminacion_producto.Visible = false;
            {
                Tsm_Eliminar.Checked = false;
                TSM_eliminar_existencias.Checked = false;
                TSM_eliminar_producto.Checked = false;
                Tsm_agregar.Checked = false;
                Tsm_agregar_existente.Checked = false;
                Tsm_nuevo_prod.Checked = false;
            }
        }

        private void Txb_nombre_empleado_TextChanged(object sender, EventArgs e)
        {
            if (Txb_nombre_empleado.Text.Trim() == "" || Txb_edad_empleado.Text.Trim() == ""||Cbx_tipo_empleado.SelectedIndex == -1 )
            {
                Btn_guardar_cambios_empleados.Enabled = false;
            }
            else
            {
                Btn_guardar_cambios_empleados.Enabled = true;

            }
        }

        private void Txb_edad_empleado_TextChanged(object sender, EventArgs e)
        {
            if (Txb_nombre_empleado.Text.Trim() == "" || Txb_edad_empleado.Text.Trim() == "" || Cbx_tipo_empleado.SelectedIndex == -1)
            {
                Btn_guardar_cambios_empleados.Enabled = false;
            }
            else
            {
                Btn_guardar_cambios_empleados.Enabled = true;

            }

        }

        private void Cbx_tipo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txb_nombre_empleado.Text.Trim() == "" || Txb_edad_empleado.Text.Trim() == "" || Cbx_tipo_empleado.SelectedIndex == -1)
            {
                Btn_guardar_cambios_empleados.Enabled = false;
            }
            else
            {
                Btn_guardar_cambios_empleados.Enabled = true;

            }
        }

        private void Txb_nuevo_usuario_contraseña_TextChanged(object sender, EventArgs e)
        {
            if (Txb_nuevo_usuario_contraseña.Text.Trim() == "" || Cbx_nuevo_usuario_tipo.SelectedIndex == -1 || Txb_nuevo_usuario_nombre.Text.Trim() == "")
            {
                Btn_nuevo_usuario_guardar.Enabled = false;
            }
            else
            {
                Btn_nuevo_usuario_guardar.Enabled = true;
            }
        }

        private void Txb_nuevo_usuario_nombre_TextChanged(object sender, EventArgs e)
        {
            if (Txb_nuevo_usuario_contraseña.Text.Trim() == "" || Cbx_nuevo_usuario_tipo.SelectedIndex == -1 || Txb_nuevo_usuario_nombre.Text.Trim() == "")
            {
                Btn_nuevo_usuario_guardar.Enabled = false;
            }
            else
            {
                Btn_nuevo_usuario_guardar.Enabled = true;
            }

        }

        private void Cbx_nuevo_usuario_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txb_nuevo_usuario_contraseña.Text.Trim() == "" || Cbx_nuevo_usuario_tipo.SelectedIndex == -1 || Txb_nuevo_usuario_nombre.Text.Trim() == "")
            {
                Btn_nuevo_usuario_guardar.Enabled = false;
            }
            else
            {
                Btn_nuevo_usuario_guardar.Enabled = true;
            }
        }

        private void Txb_nuevo_usuario_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void Tbx_modificar_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



