Imports System.ComponentModel
Imports System.Data.Odbc

Public Class Principal

#Region "| V A R I A B L E S |"

    Dim tipodoc As Integer = 0 'Tipo documento (Pasaporte o Cédula) en pestaña clientes
    Dim buscarpersona As String 'guarda el tipo por el que se buscara en la pestaña clientes
    Dim buscaralquiler As String 'guarda el tipo por el que se buscara en la pestaña alquiler
    Dim idpex As String = "" 'guarda el id de la persona seleccionada en la grilla exclientes
    Dim busquedaexcli As String 'guarda el tipo por el que se buscara en la pestaña alquiler
    Dim idp As Integer = 0  'Guarda la id de la persona seleccionada en la grilla clientes
    Dim nombremar As String = "" 'Guarda el nombre de la marca seleccionada actualmente en el combobox
    Dim ids As String = "0" 'Guarda el id de la sucursal seleccionada en la grilla sucursal
    Dim busquedasuc = "0" 'Guarda el tipo por el que se buscara en la pestaña sucursal
    Public panelsel As Integer 'guarda la seleccion del panel
    Dim idempcli As Integer = 0 'guarda la selección
    Public idr As String ' guarda seleccion reseerva en alquila

#End Region

    Public Sub CargaPrincipal(sender As Object, e As EventArgs) Handles MyBase.Load ''''''''''''''''''''''''''''''''''''''''''''''

        llenarcategoria(Principal_Reserva_cmb_categoria)

        llenarmarca(AgregarModelo.AgregarModelo_cmb_marca)
        llenarmarca(Principal_Vehiculo_cmb_Marca)

        CargarModelo()

        cargarSucursal(Principal_Vehiculo_cmb_Sucursal)
        cargarSucursal(Principal_Empleados_cmb_sucursal)
        cargarSucursal(ComboBox2)
        cargarSucursal(DevolucionVehiculo.Devolucion_cmb_sucursal)


        '   Principal_Vehiculo_cmb_Marca.SelectedIndex = 1
        Principal_ExClientes_cbx_NroDoc.Checked = True
        CheckBox1.Checked = False
        GroupBox1.Visible = False
        cargarTodo()
        Principal_Clientes_dtp_NacimientoPersona.MaxDate = DateTime.Today.AddYears(-18) 'no se permiten ingresar personas menores de edad
        cargardefecto() 'damos color por defecto a todo
        ComboBoxDefecto() ' ponemos todos los combobox en la posición 0 por defecto asi se muestran cargados


#Region "Permisos"
        permisos = executescalar("rol_u", "usuario", "login", GetUsuario) 'conseguimos los permisos de el usuario que se ingreso
        Select Case permisos 'depende de que permisos tenga se mostraran u ocultaran items

            Case "Root"

            Case "Oficina"

                Principal_tlp_Vehiculo.Dispose()


            Case "Taller"

                Principal_tlp_Vehiculo.Dispose()
                Principal_tlp_Clientes.Dispose()


            Case "Técnico"

            Case "Dirección"

        End Select
#End Region


        OcultarPaneles()
        aaaPrincipal_Defecto.Show() 'mostramos pantalla de inicio en el load
        Login.Hide() 'ocultamos login cuando inicia el principal

    End Sub

    Private Sub cargarSucursal(combo As ComboBox)
        Dim sucursal As DataTable = Execute("select nombre from sucursal")
        If sucursal.Rows.Count = 0 Then
            Return
        End If
        If sucursal.Rows.Count > 0 Then

            With combo
                .DataSource = sucursal
                .DisplayMember = "nombre"
                .ValueMember = "nombre"
                '   Principal_Vehiculo_cmb_Sucursal ComboBox3 Principal_Empleados_cmb_sucursal DevolucionVehiculo.Devolucion_cmb_sucursal
            End With
        End If
    End Sub

    Private Sub cargarTodo()
        llenarGrillaMantenimiento()
        llenarGrillaCliente()
        llenarGrillaExCliente()
        llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
        llenarGrillaEmpresa(DataGridView1)
        llenarGrillaSucursal()
        llenarGrillaReserva()
        llenarGrillaVehiculo()
        llenarGrillaClienteReserva()
        llenarGrillaEmpleado()
        llenarGrillaVehiculoMantenimiento()

    End Sub

    Public Sub CargarModelo()

        If Principal_Vehiculo_cmb_Marca.Items.Count = 0 Then
            Return
        End If
        nombremar = Principal_Vehiculo_cmb_Marca.SelectedValue.ToString()

        Dim modelito As DataTable = Execute("select nombre_modelo from marca where nombre_marca = '" + nombremar + "'")


        With Principal_Vehiculo_cmb_Modelo
                .DataSource = modelito
                .DisplayMember = "nombre_modelo"
                .ValueMember = "nombre_modelo"
            End With

    End Sub

    Public Sub llenarmarca(combo As ComboBox)
        Dim marca As DataTable = Execute("Select distinct nombre_marca from marca")
        If marca.Rows.Count = 0 Then
            Return
        End If

        If marca.Rows.Count > 0 Then

            With combo
                .DataSource = marca
                .DisplayMember = "nombre_marca"
                .ValueMember = "nombre_marca"
            End With
        End If
    End Sub
    Public Sub llenarcategoria(combo As ComboBox)
        Dim categori As DataTable = Execute("select letra from categoria")
        If categori.Rows.Count = 0 Then
            Return
        End If
        If categori.Rows.Count > 0 Then
            Try
                With combo
                    .DataSource = categori
                    .DisplayMember = "letra"
                    .ValueMember = "letra"
                End With

            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub llenarGrillaMantenimiento() ''''''''''''''''''''''''''''''''''''''''''''''
        DataGrids("Select m.idm,v.idv,v.matricula,ma.nombre_marca,ma.nombre_modelo,m.descripcion,m.costo,m.fech_inicio,m.fech_fin from mantenimiento m inner join vehiculo v on v.idv = m.idv inner join marca ma on ma.idma = v.idma where m.estado_mantenimiento = 't'", Principal_Mantenimiento_dgv_Mantenimientos)

        If dt.Rows.Count = 0 Then
            Return
        End If
        If dt.Rows.Count > 0 Then

            'llenar nombre columnas y ocultar innecesarias
        End If
    End Sub

    Public Sub llenarGrillaVehiculoAlquila()

        DataGrids("select v.idv,v.matricula,m.nombre_marca,m.nombre_modelo,s.nombre,c.letra from vehiculo v inner join sucursal s on s.ids = v.ids inner join marca m on m.idma = v.idma inner join categoria c on c.idc = m.idc where estado_uso = 't' and disponibilidad = 'Libre' and c.letra = '" + Principal_Alquiler_dgv_alquier.CurrentRow.Cells(6).Value.ToString + "'", DataGridView3)
        If dt.Rows.Count > 0 Then
            DataGridView3.Columns(0).Visible = False
            DataGridView3.Columns(1).HeaderText = "Matricula"
            DataGridView3.Columns(2).HeaderText = "Marca"
            DataGridView3.Columns(3).HeaderText = "Modelo"
            DataGridView3.Columns(4).HeaderText = "Sucursal"
            DataGridView3.Columns(5).HeaderText = "Categoria"
        End If

    End Sub
    Public Sub llenarGrillaVehiculoMantenimiento()

        DataGrids("select v.idv,v.matricula,m.nombre_marca,m.nombre_modelo,s.nombre,c.letra from vehiculo v inner join sucursal s on s.ids = v.ids inner join marca m on m.idma = v.idma inner join categoria c on c.idc = m.idc where estado_uso = 't' and disponibilidad = 'Libre';", Principal_mantenimiento_dgv_CargarVehiculos)
        If dt.Rows.Count > 0 Then
            DataGridView3.Columns(0).Visible = False
            DataGridView3.Columns(1).HeaderText = "Matricula"
            DataGridView3.Columns(2).HeaderText = "Marca"
            DataGridView3.Columns(3).HeaderText = "Modelo"
            DataGridView3.Columns(4).HeaderText = "Sucursal"
            DataGridView3.Columns(5).HeaderText = "Categoria"
        End If
    End Sub

    Public Sub llenarGrillaReserva() ''''''''''''''''''''''''''''''''''''''''''''''

        DataGrids("select a.idr,p.tipo_doc,p.num_doc, p.nombre, p.apellido, v.matricula,a.fech_retiro_real, s.nombre sucursal_ret, a.estado_alquiler, c.idc,v.idv from alquila a inner join categoria c on c.idc = a.idc inner join persona p on p.idp = a.idp left join sucursal s on s.ids = a.sucursal_ret inner join vehiculo v on v.idv = a.idv where a.estado_alquiler = 'Alquiler' and a.estatus = 't'", DataGridView2)
        DataGridView2.Columns(0).Visible = False

        DataGrids("select r.idr,p.idp,p.num_doc,p.tipo_doc,p.nombre,p.apellido, c.letra, r.fecha_retiro_fijada, r.fech_devolucion_fijada from alquila r inner join persona p on p.idp= r.idp inner join categoria c on r.idc = c.idc where r.estatus = 't' and r.estado_alquiler= 'Reserva'", Principal_Alquiler_dgv_alquier)
        If dt.Rows.Count > 0 Then
            Principal_Alquiler_dgv_alquier.Columns(0).Visible = False
        Principal_Alquiler_dgv_alquier.Columns(1).Visible = False
        Principal_Alquiler_dgv_alquier.Columns(2).HeaderText = "Número de documento"
        Principal_Alquiler_dgv_alquier.Columns(3).HeaderText = "Tipo de documento"
        Principal_Alquiler_dgv_alquier.Columns(4).HeaderText = "Nombre cliente"
        Principal_Alquiler_dgv_alquier.Columns(5).HeaderText = "Apellido cliente"
        Principal_Alquiler_dgv_alquier.Columns(6).HeaderText = "Categoría vehículo"
        Principal_Alquiler_dgv_alquier.Columns(7).HeaderText = "Retiro pautado"
            Principal_Alquiler_dgv_alquier.Columns(8).HeaderText = "Devolución pautada"
        End If

        DataGrids("select r.idr,p.idp,p.num_doc,p.tipo_doc,p.nombre,p.apellido, c.letra, r.fecha_retiro_fijada, r.fech_devolucion_fijada, r.precio_estimado from alquila r inner join persona p on p.idp= r.idp inner join categoria c on r.idc = c.idc where r.estatus = 't' and r.estado_alquiler= 'Reserva'", Principal_Reserva_dgv_buscar)
        If dt.Rows.Count > 0 Then
            Principal_Reserva_dgv_buscar.Columns(0).Visible = False
            Principal_Reserva_dgv_buscar.Columns(1).Visible = False
            Principal_Reserva_dgv_buscar.Columns(2).HeaderText = "Número de documento"
            Principal_Reserva_dgv_buscar.Columns(3).HeaderText = "Tipo de documento"
            Principal_Reserva_dgv_buscar.Columns(4).HeaderText = "Nombre cliente"
            Principal_Reserva_dgv_buscar.Columns(5).HeaderText = "Apellido cliente"
            Principal_Reserva_dgv_buscar.Columns(6).HeaderText = "Categoría vehículo"
            Principal_Reserva_dgv_buscar.Columns(7).HeaderText = "Retiro pautado"
            Principal_Reserva_dgv_buscar.Columns(8).HeaderText = "Devolución pautada"
            Principal_Reserva_dgv_buscar.Columns(9).HeaderText = "Precio estimado"
        End If
    End Sub

    Public Sub llenarGrillaVehiculo()
        DataGrids("select v.idv,v.matricula,m.nombre_marca,m.nombre_modelo,s.nombre,c.letra,v.disponibilidad from vehiculo v inner join sucursal s on s.ids = v.ids inner join marca m on m.idma = v.idma inner join categoria c on c.idc = m.idc where estado_uso = 't';", Principal_Vehiculo_dgv_buscarVehiculos)
        If dt.Rows.Count > 0 Then
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(0).Visible = False
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(1).HeaderText = "Número matrícula"
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(2).HeaderText = "Nombre marca"
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(3).HeaderText = "Nombre modelo"
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(4).HeaderText = "Nombre sucursal"
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(5).HeaderText = "Típo de categoría"
            Principal_Vehiculo_dgv_buscarVehiculos.Columns(6).HeaderText = "Disponibilidad del vehiculo"
            For i = 0 To Principal_Vehiculo_dgv_buscarVehiculos.Rows.Count - 1
                Select Case Principal_Vehiculo_dgv_buscarVehiculos.Rows(i).Cells(6).Value
                    Case "Alquilado"
                        Principal_Vehiculo_dgv_buscarVehiculos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                    Case "Libre"
                        Principal_Vehiculo_dgv_buscarVehiculos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)
                    Case "Mantenimiento"
                        Principal_Vehiculo_dgv_buscarVehiculos.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(80, 90, 250)
                End Select
            Next

        End If
    End Sub

    Private Sub llenarGrillaEmpresa(dgv As DataGridView) ''''''''''''''''''''''''''''''''''''''''''''''
        DataGrids("select * from empresa where estado_empresa = 't'", dgv)

        dgv.Columns(0).Visible = False
            dgv.Columns(5).Visible = False
            dgv.Columns(1).HeaderText = "R.U.T."
            dgv.Columns(2).HeaderText = "Nombre"
            dgv.Columns(3).HeaderText = "Teléfono"
            dgv.Columns(4).HeaderText = "Dirección"


    End Sub

    Public Sub llenarGrillaCliente()
        DataGrids("select * From dgv_c", Principal_Clientes_dgv_PersonaEmpresa)

        If dt.Rows.Count > 0 Then
            Principal_Clientes_dgv_PersonaEmpresa.Columns(0).Visible = False
            Principal_Clientes_dgv_PersonaEmpresa.Columns(1).HeaderText = "Nº de documento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(2).HeaderText = "Tipo de documento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(3).HeaderText = "Nombre cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(4).HeaderText = "Apellido cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(5).HeaderText = "Fecha de nacimiento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(6).HeaderText = "Correo electrónico"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(7).HeaderText = "Número teléfono"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(8).HeaderText = "Dirección cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(9).HeaderText = "Categoría licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(10).HeaderText = "Vencimiento de licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(11).HeaderText = "Departamento de licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(12).HeaderText = "Estado del cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(13).Visible = False
            Principal_Clientes_dgv_PersonaEmpresa.Columns(14).HeaderText = "Nombre Empresa"
        End If
        For i = 0 To Principal_Clientes_dgv_PersonaEmpresa.Rows.Count - 1
            Select Case Principal_Clientes_dgv_PersonaEmpresa.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)
                Case "Alquiler"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(80, 90, 250)
            End Select
        Next

    End Sub

    Private Sub llenarGrillaSucursal() ''''''''''''''''''''''''''''''''''''''''''''''
        DataGrids("select * from sucursal where estado_sucursal = 't'", Principal_Sucursal_dgv_Sucursal)
        If dt.Rows.Count > 0 Then
            Principal_Sucursal_dgv_Sucursal.Columns(0).Visible = False
            Principal_Sucursal_dgv_Sucursal.Columns(4).Visible = False
            Principal_Sucursal_dgv_Sucursal.Columns(1).HeaderText = "Nombre"
            Principal_Sucursal_dgv_Sucursal.Columns(2).HeaderText = "Dirección"
            Principal_Sucursal_dgv_Sucursal.Columns(3).HeaderText = "Teléfono"

        End If

    End Sub

    Private Sub llenarGrillaClienteReserva()
        DataGrids("Select idp, num_doc, tipo_doc, nombre, apellido from persona where estado_activo = 't' and estado = 'Libre'", Principal_Reserva_dgv_Clientes)
        If dt.Rows.Count > 0 Then
            Principal_Reserva_dgv_Clientes.Columns(0).Visible = False
            Principal_Reserva_dgv_Clientes.Columns(1).HeaderText = "Nº de documento"
            Principal_Reserva_dgv_Clientes.Columns(2).HeaderText = "Tipo de documento"
            Principal_Reserva_dgv_Clientes.Columns(3).HeaderText = "Nombre cliente"
            Principal_Reserva_dgv_Clientes.Columns(4).HeaderText = "Apellido cliente"
        End If
    End Sub

    Private Sub llenarGrillaExCliente()
        DataGrids("select * from dgv_c_inactivos", Principal_ExClientes_dgv_ExClientes)
        If dt.Rows.Count > 0 Then
            Principal_ExClientes_dgv_ExClientes.Columns(0).Visible = False
            Principal_ExClientes_dgv_ExClientes.Columns(1).HeaderText = "Nº de documento"
            Principal_ExClientes_dgv_ExClientes.Columns(2).HeaderText = "Tipo de documento"
            Principal_ExClientes_dgv_ExClientes.Columns(3).HeaderText = "Nombre cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(4).HeaderText = "Apellido cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(5).HeaderText = "Fecha de nacimiento"
            Principal_ExClientes_dgv_ExClientes.Columns(6).HeaderText = "Correo electrónico"
            Principal_ExClientes_dgv_ExClientes.Columns(7).HeaderText = "Número teléfono"
            Principal_ExClientes_dgv_ExClientes.Columns(8).HeaderText = "Dirección cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(9).HeaderText = "Categoría licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(10).HeaderText = "Vencimiento de licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(11).HeaderText = "Departamento de licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(12).HeaderText = "Estado del cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(13).Visible = False
            Principal_ExClientes_dgv_ExClientes.Columns(14).HeaderText = "Nombre Empresa"
        End If
        For i = 0 To Principal_ExClientes_dgv_ExClientes.Rows.Count - 1
            Select Case Principal_ExClientes_dgv_ExClientes.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal_ExClientes_dgv_ExClientes.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal_ExClientes_dgv_ExClientes.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)

            End Select
        Next

    End Sub



    Private Sub cargardefecto()     ''''''''''''''''''''''''''''''''''''''''''''''
        'Le damos el color por defecto a todo 

        Me.BackColor = colordefecto

        'Color de fondo a dgv
        Configuracion.Configuracion_pnl_Configuracion.BackColor = colordefecto
        Principal_tlp_Clientes.BackColor = colordefecto

        DataGridView1.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal_Empresa_dgv_Empresa.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal_Reserva_dgv_buscar.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal_Reserva_dgv_Clientes.DefaultCellStyle.SelectionBackColor = colordefecto
        'AGREGAR DGV QUE FALTAN

    End Sub

    Private Sub CerrarSesión(sender As Object, e As EventArgs) Handles Principal_tlp_Opciones_CrrSes.Click
        Dim Result As DialogResult = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then

            Me.Close()

            Configuracion.Close()

            Login.Show()

            Login.Login_txt_Pass.Text = ""

            Login.Login_txt_User.Text = ""

            Login.Login_txt_User.Select()

            Login.Login_box_Mostrar.Checked = False
        ElseIf Result = DialogResult.No Then
            Return
        End If

    End Sub

    Public Sub LimpiarToolStrip()
        EmpresaToolStripMenuItem.BackColor = Color.Transparent
        Principal_tlp_Clientes.BackColor = Color.Transparent
        Principal_tlp_Vehiculo.BackColor = Color.Transparent
        Principal_tlp_Opciones.BackColor = Color.Transparent
        Principal_tlp_Alquiler.BackColor = Color.Transparent
        Principal_tlp_Sucursal.BackColor = Color.Transparent

    End Sub

    Private Sub OcultarPaneles()


        aaaPrincipal_Vehiculo_pan.Hide()

        aaaPrincipal_Clientes_pan.Hide()

        aaaPrincipal_Reserva_pan.Hide()

        aaaPrincipal_Mantenimiento_pan.Hide()

        aaaPrincipal_Defecto.Hide()

        aaaPrincipal_pnl_alquileres.Hide()

        aaaPanelEmpleados.Hide()

        aaaPrincipal_pnl_ExClientes.Hide()

        aaaPrincipal_pnl_Empresa.Hide()

        aaaPrincipal_pnl_Sucursales.Hide()

    End Sub

    Private Sub ventanas(a As Integer, sender As ToolStripMenuItem)

        OcultarPaneles()

        LimpiarToolStrip()

        ColoresPaneles(sender)

        Select Case a

            Case 1

                aaaPrincipal_Mantenimiento_pan.Show()

            Case 2

                aaaPrincipal_Reserva_pan.Show()

            Case 3

                aaaPrincipal_Clientes_pan.Show()

            Case 4

                aaaPrincipal_Vehiculo_pan.Show()
            Case 5
                aaaPrincipal_pnl_alquileres.Show()
            Case 6
                aaaPanelEmpleados.Show()
            Case 7
                aaaPrincipal_pnl_ExClientes.Show()
            Case 8
                aaaPrincipal_pnl_Empresa.Show()
            Case 9
                aaaPrincipal_pnl_Sucursales.Show()
            Case 10
                aaaPanelEmpleados.Show()
        End Select
    End Sub

    Private Sub ColoresPaneles(sender As ToolStripMenuItem)

        LimpiarToolStrip()
        sender.BackColor = BackColor

    End Sub

    Private Sub ComboBoxDefecto()

        'Panel Mantenimiento

        Principal_Reserva_cmb_buscarpor.SelectedIndex = 0

        'Panel Clientes
        Principal_clientes_cmb_buscarpor.SelectedIndex = 0
        Principal_Clientes_cmb_TipoDoc.SelectedIndex = 0
        Principal_Clientes_cmb_DepLicencia.SelectedIndex = 0
        Principal_clientes_cmb_Categoria.SelectedIndex = 0

    End Sub

    Private Sub Salir(sender As Object, e As EventArgs) Handles Principal_tlp_btn_Salir.Click, Principal_tlp_Opciones_Salir.Click
        Dim Result As DialogResult = MessageBox.Show("¿Seguro que desea salir del programa?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Login.Close()

            Me.Close()
        ElseIf Result = DialogResult.No Then
            Return
        End If


    End Sub

    Private Sub Minimizar(sender As Object, e As EventArgs) Handles Principal_tlp_btn_Minimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub AbrirConfiguracion(sender As Object, e As EventArgs) Handles Principal_tlp_Opciones_Configuracion.Click

        Configuracion.ShowDialog()


    End Sub

    Private Sub ApretaCedula(sender As Object, e As EventArgs) Handles Principal_Clientes_txt_NroDocPersona.TextChanged

        If tipodoc = 0 Then

            If (Principal_Clientes_txt_NroDocPersona.Text.Length = 6) Then

                Principal_clientes_txt_Verificador.Text = Verif_CI("0" + Principal_Clientes_txt_NroDocPersona.Text)
            ElseIf Principal_Clientes_txt_NroDocPersona.Text.Length = 7 Then
                Principal_clientes_txt_Verificador.Text = Verif_CI(Principal_Clientes_txt_NroDocPersona.Text)
            Else
                Principal_clientes_txt_Verificador.Text = ""
            End If

        End If

    End Sub

    Public Sub sololetras(sender As Object, e As KeyPressEventArgs) Handles Principal_Clientes_txt_NombrePersona.KeyPress, Principal_Clientes_txt_ApellidoPersona.KeyPress, Principal_empleados_txb_Apellido.KeyPress, Principal_Empleados_txb_Cargo.KeyPress, Principal_empleados_txb_Nombre.KeyPress, Principal_Empresa_txb_Nombre.KeyPress, Principal_Sucursal_txb_Nombre.KeyPress
        If InStr(1, "abcdefghijkmnlopqrstuvwxyzABCDEFGHIJKMNROPQRSTUVWXLYZáéíóú ´" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub solonumerosced(sender As Object, e As KeyPressEventArgs) Handles Principal_Clientes_txt_NroDocPersona.KeyPress
        If tipodoc = 0 Then
            If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            End If
        ElseIf tipodoc = 1 Then
            If InStr(1, "1234567890abcdefghijkmnlropqrstuvwxyzABCDEFGHIJKMNLROPQRSTUVWXYZ" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Public Sub solonumeros(sender As Object, e As KeyPressEventArgs) Handles Principal_Clientes_txt_TelPersona.KeyPress, Principal_Empresa_txb_Rut.KeyPress, Principal_empleados_txb_Tel.KeyPress, Principal_Empleados_txb_ci.KeyPress, Principal_Empresa_txb_Rut.KeyPress, Principal_Empresa_txb_Telefono.KeyPress, Principal_Sucursal_txb_Telefono.KeyPress, Principal_mantenimiento_txb_costo.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub mail(sender As Object, e As KeyPressEventArgs) Handles Principal_Clientes_txt_EMailPersona.KeyPress, Principal_empleados_txb_Email.KeyPress
        If InStr(1, "abcdefghijkmnropqrstuvwxlyz_.1234567809@" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub direccion(sender As Object, e As KeyPressEventArgs) Handles Principal_Clientes_txt_DirPersona.KeyPress, Principal_empleados_txb_Direc.KeyPress, Principal_Empresa_txb_Direccion.KeyPress, Principal_Sucursal_txb_Direccion.KeyPress, Principal_Empresa_txb_BuscarEmpresa.KeyPress, Principal_ExClientes_txb_Buscar.KeyPress, Principal_clientes_txt_buscar.KeyPress, Principal_Sucursal_txb_Buscar.KeyPress, Principal_Alquiler_txb_buscarAlquiler.KeyPress, TextBox1.KeyPress, Principal_Reserva_txb_BuscaCliente.KeyPress, Principal_Reserva_txt_buscar.KeyPress, Principal_Vehiculo_txt_Matricula.KeyPress, Principal_Vehiculo_txb_BuscarVehiculos.KeyPress, Principal_mantenimiento_txt_descripcion.KeyPress, Principal_mantenimiento_btn_buscar.KeyPress
        If InStr(1, "abcdefghijkmnropqrstluvwxyzABCDEFGHIJKMNROPQRLSTUVWXYZ 1234567809" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PasaporteOCedula(sender As Object, e As EventArgs) Handles Principal_Clientes_cmb_TipoDoc.SelectedIndexChanged

        If Principal_Clientes_cmb_TipoDoc.SelectedIndex = 0 Then
            Principal_clientes_txt_Verificador.Visible = True
            Principal_clientes_lbl_guion.Visible = True
            Principal_Clientes_txt_NroDocPersona.Size = New Size(104, 21)
            tipodoc = 0
            Principal_Clientes_txt_NroDocPersona.MaxLength = 7
            Principal_Clientes_txt_NroDocPersona.Clear()

        ElseIf Principal_Clientes_cmb_TipoDoc.SelectedIndex = 1 Then
            Principal_Clientes_txt_NroDocPersona.Size = New Size(153, 23)
            Principal_clientes_lbl_guion.Visible = False
            Principal_clientes_txt_Verificador.Visible = False
            tipodoc = 1
            Principal_Clientes_txt_NroDocPersona.MaxLength = 15
            Principal_Clientes_txt_NroDocPersona.Clear()
            Principal_clientes_txt_Verificador.Clear()
        End If

    End Sub



    Private Sub LimpiarClientes(sender As Object, e As EventArgs) Handles Principal_Clientes_btn_Limpiar.Click

        Principal_Clientes_txt_ApellidoPersona.Clear()
        Principal_Clientes_txt_DirPersona.Clear()
        Principal_Clientes_txt_EMailPersona.Clear()
        Principal_Clientes_txt_NombrePersona.Clear()
        Principal_Clientes_txt_TelPersona.Clear()
        Principal_Clientes_dtp_NacimientoPersona.Value = DateTime.Today.AddYears(-18)

        Principal_Clientes_cmb_TipoDoc.SelectedIndex = 0
        Principal_Clientes_cmb_DepLicencia.SelectedIndex = 0
        Principal_Clientes_dtp_VencimientoLicencia.Value = DateTime.Today.AddDays(+1)
        Principal_Clientes_txt_NroDocPersona.Clear()
        Principal_clientes_cmb_Categoria.SelectedIndex = 0
    End Sub

    Private Sub Principal_Clientes_txt_RUT_TextChanged(sender As Object, e As EventArgs) Handles Principal_Empresa_txb_Rut.TextChanged

        If (Principal_Empresa_txb_Rut.Text.Length = 11) Then

            Principal_Empresa_txb_NumVerif.Text = calculorut(Principal_Empresa_txb_Rut.Text)
        Else
            Principal_Empresa_txb_NumVerif.Text = "!"
        End If

    End Sub

    Private Sub ActualizarCliente(sender As Object, e As EventArgs) Handles Principal_clientes_btn_recargar.Click

        Principal_clientes_txt_buscar.Clear()
        llenarGrillaCliente()

    End Sub
    Dim idpdirect As String
    Private Sub Principal_Clientes_btn_Agregar_Click(sender As Object, e As EventArgs) Handles Principal_Clientes_btn_Agregar.Click

#Region "validamos valores cliente"
        If Principal_Clientes_txt_NroDocPersona.Text.Length < 6 Then
            MessageBox.Show("Error : debe ingresar un número de documento válido", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Principal_clientes_txt_Verificador.Text = ""
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_ApellidoPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un apellido", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_EMailPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un mail", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_TelPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un teléfono", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_DirPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar una dirección", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_dtp_VencimientoLicencia.Value < Today.Date Then
            MessageBox.Show("Error : debe ingresar una licencia que no este vencida", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
#End Region

        'verificamos que el documento no esté ingresado ya como cliente activo
        Execute("select * from persona where num_doc = '" + Principal_Clientes_txt_NroDocPersona.Text + Principal_clientes_txt_Verificador.Text + "' and tipo_doc = '" + Principal_Clientes_cmb_TipoDoc.SelectedItem + "' and estado_activo = 't'")
        If (dt.Rows.Count > 0) Then
            If tipodoc = 0 Then
                MessageBox.Show("La cedula ya esta registrada, por favor verifique y vuelva a intentar.")
                Return
            ElseIf tipodoc = 1 Then
                MessageBox.Show("El pasaporte ya esta registrado, por favor verifique y vuelva a intentar.")
                Return
            End If
        End If

        'verificamos que el documento no esté ingresado ya como cliente inactivo
        Execute("select * from persona where num_doc= '" + Principal_Clientes_txt_NroDocPersona.Text + Principal_clientes_txt_Verificador.Text + "' and tipo_doc = '" + Principal_Clientes_cmb_TipoDoc.SelectedItem + "' and estado_activo = 'f' ")
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Persona inactiva, vaya al panel de ex clientes y recuperela", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'cliente con empresa
        If CheckBox1.Checked = True Then
            If idempcli = 0 Then
                MessageBox.Show("seleccione una empresa") 'fijamos si clckeo empresa para relacionar
                Return
            End If
            'insertamos persona con empresa auomaicamente
            sentenciasNonQuery("insert into persona values (0,'" + Principal_Clientes_txt_NroDocPersona.Text + Principal_clientes_txt_Verificador.Text + "','" + Principal_Clientes_cmb_TipoDoc.SelectedItem + "' , '" + Principal_Clientes_txt_NombrePersona.Text + "' , '" + Principal_Clientes_txt_ApellidoPersona.Text + "','" + Principal_Clientes_txt_EMailPersona.Text + "'," + Principal_Clientes_txt_TelPersona.Text + ", '" + Principal_Clientes_txt_DirPersona.Text + "','" + Principal_clientes_cmb_Categoria.SelectedItem + "','" + Principal_Clientes_dtp_VencimientoLicencia.Value.Date + "','" + Principal_Clientes_dtp_NacimientoPersona.Value.Date + "','" + Principal_Clientes_cmb_DepLicencia.SelectedItem + "','Libre','t',null," + idempcli.ToString + ")")
            Try
                llenarGrillaCliente()
                llenarGrillaClienteReserva()
                MessageBox.Show("Exito : Exito al ingresar el nuevo representante.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error :  No se pudo ingresar nuevo representante.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            Try
                'insertamos persona sin emresa
                sentenciasNonQuery("insert into persona values (0,'" + Principal_Clientes_txt_NroDocPersona.Text + Principal_clientes_txt_Verificador.Text + "','" + Principal_Clientes_cmb_TipoDoc.SelectedItem + "' , '" + Principal_Clientes_txt_NombrePersona.Text + "' , '" + Principal_Clientes_txt_ApellidoPersona.Text + "','" + Principal_Clientes_txt_EMailPersona.Text + "'," + Principal_Clientes_txt_TelPersona.Text + ", '" + Principal_Clientes_txt_DirPersona.Text + "','" + Principal_clientes_cmb_Categoria.SelectedItem + "','" + Principal_Clientes_dtp_VencimientoLicencia.Value.Date + "','" + Principal_Clientes_dtp_NacimientoPersona.Value.Date + "','" + Principal_Clientes_cmb_DepLicencia.SelectedItem + "','Libre','t',null,null)")
                llenarGrillaCliente()
                llenarGrillaClienteReserva()
                MessageBox.Show("Exito : Exito al ingresar el nuevo cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OdbcException
                MessageBox.Show("Error :  No se pudo ingresar nuevo cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Principal_Reserva_txt_buscar.TextChanged
        DataGrids("Select a.idv, v.matricula, a.idp, p.num_doc, p.tipo_doc, a.fecha_retiro_fijada, a.fech_devolucion_fijada, a.fech_limite_devolucion, a.cant_dias_alquiler from alquila where TO_CHAR(" + buscaralquiler + ") Like  '" + Principal_Reserva_txt_buscar.Text + "%' ", Principal_Reserva_dgv_buscar)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Principal_Reserva_cmb_buscarpor.SelectedIndexChanged
        Select Case Principal_Reserva_cmb_buscarpor.SelectedIndex
            Case 0
                buscaralquiler = "num_doc"
            Case 1
                buscaralquiler = "matricula"
            Case 2
                buscaralquiler = "idr"
        End Select
    End Sub

    Private Sub comboboxito(sender As Object, e As EventArgs) Handles Principal_clientes_cmb_buscarpor.SelectedIndexChanged
        Principal_clientes_txt_buscar.Clear()
        Select Case Principal_clientes_cmb_buscarpor.SelectedIndex
            Case 0
                buscarpersona = "p.num_doc"
            Case 1
                buscarpersona = "apellido"
            Case 2
                buscarpersona = "cat_licencia"
        End Select
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Principal_clientes_txt_buscar.TextChanged
        If buscarpersona = "cat_licencia" Then
            Principal_clientes_txt_buscar.Text = UCase(Principal_clientes_txt_buscar.Text)
            Principal_clientes_txt_buscar.SelectionStart = Principal_clientes_txt_buscar.TextLength + 1

        End If
        DataGrids("select p.idp, p.num_doc, p.tipo_doc, p.nombre, p.apellido,  p.fech_nac, p.email, p.tel, p.direccion, p.cat_licencia, p.fech_venc_licencia, p.departamento_licencia, p.estado,e.idem, e.nombre nombre_empresa from persona p left join empresa e on p.idem = e.idem  where TO_CHAR(" + buscarpersona + ") like '" + Principal_clientes_txt_buscar.Text + "%' and estado_activo = 't'", Principal_Clientes_dgv_PersonaEmpresa)

        If dt.Rows.Count = 0 Then
            Principal_clientes_lbl_resultados.Visible = True
        ElseIf dt.Rows.Count > 0 Then
            Principal_Clientes_dgv_PersonaEmpresa.Columns(0).Visible = False
            Principal_Clientes_dgv_PersonaEmpresa.Columns(1).HeaderText = "Nº de documento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(2).HeaderText = "Tipo de documento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(3).HeaderText = "Nombre cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(4).HeaderText = "Apellido cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(5).HeaderText = "Fecha de nacimiento"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(6).HeaderText = "Correo electrónico"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(7).HeaderText = "Número teléfono"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(8).HeaderText = "Dirección cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(9).HeaderText = "Categoría licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(10).HeaderText = "Vencimiento de licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(11).HeaderText = "Departamento de licencia"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(12).HeaderText = "Estado del cliente"
            Principal_Clientes_dgv_PersonaEmpresa.Columns(13).Visible = False
            Principal_Clientes_dgv_PersonaEmpresa.Columns(14).HeaderText = "Nombre Empresa"
        End If
        For i = 0 To Principal_Clientes_dgv_PersonaEmpresa.Rows.Count - 1
            Select Case Principal_Clientes_dgv_PersonaEmpresa.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)
                Case "Alquiler"
                    Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(80, 90, 250)
            End Select
        Next
    End Sub

    Private Sub Principal_Clientes_btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Principal_Clientes_btn_Eliminar.Click

        If idp = "0" Then
            MessageBox.Show("Error : Debe seleccionar una persona para eliminarla.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_dgv_PersonaEmpresa.CurrentRow.Cells(12).Value = "Alquiler" Then
            MessageBox.Show("no puede eliminar a una persona con un alquiler en proceso, primero debe terminarlo")
            Return
        End If

        sentenciasNonQuery("update persona set estado_activo = 'f' where idp = " + idp.ToString + " ")

        llenarGrillaCliente()
        MessageBox.Show("Éxito : Éxito al dar de baja al cliente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenarGrillaExCliente()
    End Sub

    Private Sub Principal_Clientes_dgv_PersonaEmpresa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_Clientes_dgv_PersonaEmpresa.CellClick
        idp = Principal_Clientes_dgv_PersonaEmpresa.CurrentRow.Cells(0).Value.ToString()

        '     posiciondefectoclientes()


        Dim row As DataGridViewRow = Principal_Clientes_dgv_PersonaEmpresa.CurrentRow

        Principal_Clientes_cmb_TipoDoc.Text = row.Cells(2).Value.ToString()
        Principal_Clientes_txt_NroDocPersona.Text = row.Cells(1).Value.ToString()

        If Principal_Clientes_cmb_TipoDoc.Text = "C.I." Then
            Principal_Clientes_txt_NroDocPersona.Text = Principal_Clientes_txt_NroDocPersona.Text.Substring(0, Principal_Clientes_txt_NroDocPersona.Text.Length - 1)
        End If

        Principal_Clientes_txt_NombrePersona.Text = row.Cells(3).Value.ToString()
        Principal_Clientes_txt_TelPersona.Text = row.Cells(7).Value.ToString()
        Principal_Clientes_txt_DirPersona.Text = row.Cells(8).Value.ToString()
        Principal_Clientes_txt_ApellidoPersona.Text = row.Cells(4).Value.ToString()
        Principal_Clientes_txt_EMailPersona.Text = row.Cells(6).Value.ToString()

        Principal_Clientes_cmb_DepLicencia.Text = row.Cells(11).Value.ToString()
        Principal_clientes_cmb_Categoria.Text = row.Cells(9).Value.ToString()
        Principal_Clientes_dtp_NacimientoPersona.Text = row.Cells(5).Value.ToString()
        Principal_Clientes_dtp_VencimientoLicencia.Text = row.Cells(10).Value.ToString()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Principal_ExClientes_btn_Recargar.Click
        llenarGrillaExCliente()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Principal_Clientes_btn_Modificar.Click
        If Principal_Clientes_txt_NroDocPersona.Text.Length < 6 Then
            MessageBox.Show("Error : debe ingresar un número de documento válido", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Principal_clientes_txt_Verificador.Text = ""
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_ApellidoPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un apellido", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_EMailPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un mail", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_TelPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un teléfono", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_DirPersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar una dirección", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_txt_NombrePersona.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Clientes_dtp_VencimientoLicencia.Value < Today.Date Then
            MessageBox.Show("Error : debe ingresar una licencia que no este vencida", "Error de modificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        sentenciasNonQuery("update persona set nombre = '" + Principal_Clientes_txt_NombrePersona.Text + "', apellido = '" + Principal_Clientes_txt_ApellidoPersona.Text + "', email = '" + Principal_Clientes_txt_EMailPersona.Text + "', tel = " + Principal_Clientes_txt_TelPersona.Text + ", direccion = '" + Principal_Clientes_txt_DirPersona.Text + "', cat_licencia = '" + Principal_clientes_cmb_Categoria.SelectedValue + "', fech_venc_licencia = '" + Principal_Clientes_dtp_VencimientoLicencia.Value.Date + "', fech_nac = '" + Principal_Clientes_dtp_NacimientoPersona.Value.Date + "', departamento_licencia = '" + Principal_Clientes_cmb_DepLicencia.SelectedValue + "' where num_doc = '" + Principal_Clientes_txt_NroDocPersona.Text & Principal_clientes_txt_Verificador.Text + "'")
        llenarGrillaCliente()
        MessageBox.Show("Exito al modificar el cliente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Vehiculo_Agregar(sender As Object, e As EventArgs) Handles Principal_Vehiculo_btn_Agregar.Click

        If Principal_Vehiculo_txt_Matricula.Text = "" Then
            MessageBox.Show("Error : Matricula no puede estar vacia", "Error ingreso matricula", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else

            Execute("select * from vehiculo where matricula = '" + Principal_Vehiculo_txt_Matricula.Text + "'")
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Matricula ya ingresada, pruebe con otra")
                Return
            End If

            Dim ids As String = executescalar("ids", "sucursal", "nombre", Principal_Vehiculo_cmb_Sucursal.Text)

            Dim idma As String = executescalar2("idma", "marca", "nombre_marca = '" + Principal_Vehiculo_cmb_Marca.SelectedValue + "' and nombre_modelo = '" + Principal_Vehiculo_cmb_Modelo.SelectedValue + "'")

            Try
                sentenciasNonQuery("insert into vehiculo values (0,'" + Principal_Vehiculo_txt_Matricula.Text + "', " + ids.ToString + " , " + idma.ToString + ",'Libre','t')")
            Catch ex As Exception
                MessageBox.Show("Error : No se logró ingresar este vehículo", "Error ingreso vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            llenarGrillaVehiculo()
            llenarGrillaVehiculoAlquila()
            llenarGrillaVehiculoMantenimiento()
        End If
    End Sub


#Region "Ex cliente"

    Private Sub CeduladeExCliente(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_ExClientes_dgv_ExClientes.CellClick
        idpex = Principal_ExClientes_dgv_ExClientes.CurrentRow.Cells(0).Value.ToString() 'conseguimos la id del ex cliente cuando clickeamos
    End Sub

    Private Sub RevivirCliente(sender As Object, e As EventArgs) Handles Principal_ExClientes_btn_Recuperar.Click

        If idpex = "" Then
            MessageBox.Show("Error: Debe de seleccionar una persona para recuperarla", "Error de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'si la variable idpex tiene el valor por defecto entonces error
            Return
        End If
        If Principal_ExClientes_dgv_ExClientes.CurrentRow.Cells(12).Value = "Deudor" Then
            Dim Result As DialogResult = MessageBox.Show("¿Esta persona pago su deuda?", "Recuperando deudor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = DialogResult.Yes Then
                sentenciasNonQuery("update persona set estado_activo = 't', estado = 'Libre' where idp = '" + idpex + "'  ") 'del contrario lo marcamos como estado true
            ElseIf Result = DialogResult.No Then
                sentenciasNonQuery("update persona set estado_activo = 't' where idp = '" + idpex + "' ") 'del contrario lo marcamos como estado true
            End If
        Else
            sentenciasNonQuery("update persona set estado_activo = 't' where idp = '" + idpex + "' ")
        End If

        llenarGrillaExCliente() 'llenamos grilla excliente
        MessageBox.Show("Éxito: éxito al recuperar cliente", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        llenarGrillaCliente() 'llenamos grilla clientes

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles Principal_ExClientes_txb_Buscar.TextChanged

        DataGrids("select p.idp, p.num_doc, p.tipo_doc, p.nombre, p.apellido,  p.fech_nac, p.email, p.tel, p.direccion, p.cat_licencia, p.fech_venc_licencia, p.departamento_licencia, p.estado,e.idem, e.nombre nombre_empresa from persona p left join empresa e on p.idem = e.idem  where TO_CHAR(" + busquedaexcli + ") like '" + Principal_ExClientes_txb_Buscar.Text + "%' and estado_activo = 'f'", Principal_ExClientes_dgv_ExClientes)

        If dt.Rows.Count = 0 Then 'si no encontro nada se muestra un mensaje
            Principal_ExClientes_lbl_NoEncontrado.Visible = True
        ElseIf dt.Rows.Count > 0 Then
            Principal_ExClientes_dgv_ExClientes.Columns(0).Visible = False
            Principal_ExClientes_dgv_ExClientes.Columns(1).HeaderText = "Nº de documento"
            Principal_ExClientes_dgv_ExClientes.Columns(2).HeaderText = "Tipo de documento"
            Principal_ExClientes_dgv_ExClientes.Columns(3).HeaderText = "Nombre cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(4).HeaderText = "Apellido cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(5).HeaderText = "Fecha de nacimiento"
            Principal_ExClientes_dgv_ExClientes.Columns(6).HeaderText = "Correo electrónico"
            Principal_ExClientes_dgv_ExClientes.Columns(7).HeaderText = "Número teléfono"
            Principal_ExClientes_dgv_ExClientes.Columns(8).HeaderText = "Dirección cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(9).HeaderText = "Categoría licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(10).HeaderText = "Vencimiento de licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(11).HeaderText = "Departamento de licencia"
            Principal_ExClientes_dgv_ExClientes.Columns(12).HeaderText = "Estado del cliente"
            Principal_ExClientes_dgv_ExClientes.Columns(13).Visible = False
            Principal_ExClientes_dgv_ExClientes.Columns(14).HeaderText = "Nombre Empresa"
        End If
        For i = 0 To Principal_ExClientes_dgv_ExClientes.Rows.Count - 1
            Select Case Principal_ExClientes_dgv_ExClientes.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal_ExClientes_dgv_ExClientes.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal_ExClientes_dgv_ExClientes.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)

            End Select
        Next

    End Sub

#Region "CheckBox ExClientes Buscar"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_ExClientes_cbx_NroDoc.CheckedChanged

        If Principal_ExClientes_cbx_NroDoc.Checked = vbTrue Then
            Principal_ExClientes_cbx_Apellido.Checked = vbFalse
            Principal_ExClientes_cbx_Estado.Checked = vbFalse
            busquedaexcli = "num_doc" ' validamos una variable que sera la que buscara
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_ExClientes_cbx_Apellido.CheckedChanged
        If Principal_ExClientes_cbx_Apellido.Checked = vbTrue Then
            Principal_ExClientes_cbx_NroDoc.Checked = vbFalse
            Principal_ExClientes_cbx_Estado.Checked = vbFalse
            busquedaexcli = "apellido" ' validamos una variable que sera la que buscara
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_ExClientes_cbx_Estado.CheckedChanged
        If Principal_ExClientes_cbx_Estado.Checked = vbTrue Then
            Principal_ExClientes_cbx_Apellido.Checked = vbFalse
            Principal_ExClientes_cbx_NroDoc.Checked = vbFalse
            busquedaexcli = "estado" ' validamos una variable que sera la que buscara
        End If
    End Sub
#End Region

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Principal_ExClientes_btn_Limpiar.Click
        Principal_ExClientes_cbx_NroDoc.Checked = True
        Principal_ExClientes_txb_Buscar.Clear()
        Principal_ExClientes_cbx_Apellido.Checked = False
        Principal_ExClientes_cbx_Estado.Checked = False
    End Sub

#End Region

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Principal_Empleados_btn_recargar.Click
        llenarGrillaEmpleado()


    End Sub

    Private Sub SucrusalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Sucursal.Click
        ventanas(9, Principal_tlp_Sucursal)
        panelsel = 4
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Principal_clientes_btn_deudor.Click

        If idp = "0" Then
            MessageBox.Show("Error : para asignar como deudor primero debe seleccionar", "Error deudor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            If Principal_Clientes_dgv_PersonaEmpresa.CurrentRow.Cells(12).Value = "Alquiler" Then
                MsgBox("primero debe terminar alquiler")
                Return
            End If
            sentenciasNonQuery("update persona set estado = 'Deudor' where idp = " + idp.ToString + " ")
            llenarGrillaCliente()
            llenarGrillaClienteReserva()
        End If
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        If idp = "0" Then
            MessageBox.Show("Error : para asignar como pago primero debe seleccionar", "Error pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            If Principal_Clientes_dgv_PersonaEmpresa.CurrentRow.Cells(12).Value = "Alquiler" Then
                MsgBox("primero debe terminar alquiler")
                Return
            End If
            sentenciasNonQuery("update persona set estado = 'Libre' where idp = " + idp.ToString + " ")
            llenarGrillaCliente()
            llenarGrillaClienteReserva()
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_LimpiarDatos.Click

        Principal_Sucursal_txb_Nombre.Clear()
        Principal_Sucursal_txb_Direccion.Clear()
        Principal_Sucursal_txb_Telefono.Clear()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_Agregar.Click

        If Principal_Sucursal_txb_Nombre.Text = "" Then
            MessageBox.Show("Error : Debe de ingresar un nombre", "Error sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Sucursal_txb_Direccion.Text = "" Then
            MessageBox.Show("Error : Debe de ingresar una dirección", "Error sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_Sucursal_txb_Telefono.Text = "" Then
            MessageBox.Show("Error : Debe de ingresar un teléfono", "Error sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        Execute("select * from sucursal where nombre = '" + Principal_Sucursal_txb_Nombre.Text + "' ")

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Sucursal con ese nombre ya existente", "Redundancia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            Try
                sentenciasNonQuery("insert into sucursal values (0, '" + Principal_Sucursal_txb_Nombre.Text + "','" + Principal_Sucursal_txb_Direccion.Text + "'," + Principal_Sucursal_txb_Telefono.Text + ",'t')")
                DataGrids("select * from sucursal where estado_sucursal = 't'", Principal_Sucursal_dgv_Sucursal)
                MessageBox.Show("Sucursal creada correctamente", "Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cargarSucursal(Principal_Vehiculo_cmb_Sucursal)
                cargarSucursal(Principal_Empleados_cmb_sucursal)
                cargarSucursal(ComboBox2)
                cargarSucursal(DevolucionVehiculo.Devolucion_cmb_sucursal)

            Catch ex As Exception
                MessageBox.Show("Error : error al crear una sucursal", "Error sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End Try

        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_Recargar.Click
        DataGrids("select * from sucursal where estado_sucursal = 't'", Principal_Sucursal_dgv_Sucursal)
        Principal_Sucursal_dgv_Sucursal.Columns(0).Visible = False
        Principal_Sucursal_dgv_Sucursal.Columns(4).Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_Modificar.Click
        If ids = "0" Then
            MessageBox.Show("Error : Debe de seleccionar una sucursal para modificarla", "Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Else
            sentenciasNonQuery("update sucursal set nombre = '" + Principal_Sucursal_txb_Nombre.Text + "', direccion='" + Principal_Sucursal_txb_Direccion.Text + "',tel = " + Principal_Sucursal_txb_Telefono.Text + ", estado_sucursal = 't' where ids = " + ids + "")
            DataGrids("select * from sucursal where estado_sucursal = 't'", Principal_Sucursal_dgv_Sucursal)
        End If

    End Sub



    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_Sucursal_dgv_Sucursal.CellClick

        ids = Principal_Sucursal_dgv_Sucursal.CurrentRow.Cells(0).Value.ToString()
        Principal_Sucursal_txb_Nombre.Text = Principal_Sucursal_dgv_Sucursal.CurrentRow.Cells(1).Value.ToString()
        Principal_Sucursal_txb_Direccion.Text = Principal_Sucursal_dgv_Sucursal.CurrentRow.Cells(2).Value.ToString()
        Principal_Sucursal_txb_Telefono.Text = Principal_Sucursal_dgv_Sucursal.CurrentRow.Cells(3).Value.ToString()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_Eliminar.Click
        If ids = "0" Then
            MessageBox.Show("Error : debe seleccionar una sucursal para eliminarla", "Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            sentenciasNonQuery("update sucursal set estado_sucursal = 'f' where ids = " + ids + "")
            DataGrids("select * from sucursal where estado_sucursal = 't'", Principal_Sucursal_dgv_Sucursal)
        End If



    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Principal_Vehiculo_btn_recargar.Click
        llenarGrillaVehiculo()
    End Sub



    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Principal_Empresa_btn_Recargar.Click
        Try
            llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
            llenarGrillaEmpresa(DataGridView1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'DataGridView5.Columns(0).Visible = False
        'DataGridView5.Columns(2).Visible = False
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_Sucursal_cbx_Nombre.CheckedChanged
        If Principal_Sucursal_cbx_Nombre.Checked = vbTrue Then
            Principal_Sucursal_cbx_Direccion.Checked = vbFalse
            Principal_Sucursal_cbx_Telefono.Checked = vbFalse
            busquedasuc = "nombre"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_Sucursal_cbx_Direccion.CheckedChanged
        If Principal_Sucursal_cbx_Direccion.Checked = vbTrue Then
            Principal_Sucursal_cbx_Nombre.Checked = vbFalse
            Principal_Sucursal_cbx_Telefono.Checked = vbFalse
            busquedasuc = "direccion"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles Principal_Sucursal_cbx_Telefono.CheckedChanged
        If Principal_Sucursal_cbx_Telefono.Checked = vbTrue Then
            Principal_Sucursal_cbx_Direccion.Checked = vbFalse
            Principal_Sucursal_cbx_Nombre.Checked = vbFalse
            busquedasuc = "tel"
        End If
    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles Principal_Sucursal_txb_Buscar.TextChanged
        Dim sent As String = "select * from sucursal where estado_sucursal = 't' and TO_CHAR(" + busquedasuc + ") like '" + Principal_Sucursal_txb_Buscar.Text + "%'"
        DataGrids(sent, Principal_Sucursal_dgv_Sucursal)


    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Principal_Sucursal_btn_Limpiar.Click
        Principal_Sucursal_txb_Buscar.Clear()
        Principal_Sucursal_cbx_Nombre.Checked = True
    End Sub


    Private Sub Principal_Empleados_btn_limpiarEmpleado_Click(sender As Object, e As EventArgs) Handles Principal_Empleados_btn_limpiarEmpleado.Click
        Principal_Empleados_txb_ci.Text = ""
        Principal_Empleados_cmb_sucursal.SelectedIndex = 0
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Principal_tlp_Persona_Empleado.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPanelEmpleados.Show()
        Principal_tlp_Clientes.BackColor = BackColor
        panelsel = 1
    End Sub

    Private Sub ParticularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Persona_Particular.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_Clientes_pan.Show()
        Principal_tlp_Clientes.BackColor = BackColor
        panelsel = 1
    End Sub

    Private Sub ExClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Persona_ExCli.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_pnl_ExClientes.Show()
        Principal_tlp_Clientes.BackColor = BackColor
        panelsel = 1
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Alquiler_Reserva.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_Reserva_pan.Show()
        Principal_tlp_Alquiler.BackColor = BackColor
        panelsel = 3
    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Alquiler_Historial.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_pnl_alquileres.Show()
        Principal_tlp_Alquiler.BackColor = BackColor
        panelsel = 3
    End Sub

    Private Sub FlotaDeVehículosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Vehiculo_Flota.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_Vehiculo_pan.Show()
        Principal_tlp_Vehiculo.BackColor = BackColor
        panelsel = 2
    End Sub

    Private Sub MantenimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Principal_tlp_Vehiculo_Man.Click
        OcultarPaneles()
        LimpiarToolStrip()
        aaaPrincipal_Mantenimiento_pan.Show()
        Principal_tlp_Vehiculo.BackColor = BackColor
        panelsel = 2
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        ventanas(8, sender)
        panelsel = 5
    End Sub

#Region "empresa"
    Private Sub Principal_Empresa_btn_agregar_Click(sender As Object, e As EventArgs) Handles Principal_Empresa_btn_Agregar.Click

        If Principal_Empresa_txb_Rut.Text.Length < 11 Then
            MessageBox.Show("Error rut con pocos digitos")
            Return
        ElseIf Principal_Empresa_txb_Nombre.Text = "" Then
            MessageBox.Show("debe ingresar un nombre")
            Return
        ElseIf Principal_Empresa_txb_Direccion.Text = "" Then
            MessageBox.Show("debe ingresar una direccion")
            Return
        ElseIf Principal_Empresa_txb_Telefono.Text = "" Then
            MessageBox.Show("debe de proporcionar un telefono")
            Return
        End If

        Execute("select * from empresa where rut = '" + Principal_Empresa_txb_Rut.Text & Principal_Empresa_txb_NumVerif.Text + "'")

        If dt.Rows.Count > 0 Then

            Execute("select * from empresa where rut = '" + Principal_Empresa_txb_Rut.Text & Principal_Empresa_txb_NumVerif.Text + "' and estado_empresa= 't'")

            If dt.Rows.Count > 0 Then
                MessageBox.Show("Empresa ya ingresada")
                Return
            End If

            Execute("select * from empresa where rut = '" + Principal_Empresa_txb_Rut.Text & Principal_Empresa_txb_NumVerif.Text + "' and estado_empresa= 'f'")
            If dt.Rows.Count Then

                Dim Result As DialogResult = MessageBox.Show("Empresa inactiva, ¿desea recuperara?", "Recuperación...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = DialogResult.Yes Then

                    sentenciasNonQuery("update empresa set estado_empresa='t' where rut ='" + Principal_Empresa_txb_Rut.Text & Principal_Empresa_txb_NumVerif.Text + "' ")
                    llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
                    llenarGrillaEmpresa(DataGridView1)
                    MessageBox.Show("empresa recuperada")

                ElseIf Result = DialogResult.No Then
                    Return
                End If

            End If

        Else

            Try
                sentenciasNonQuery(" insert into empresa values(0,'" + Principal_Empresa_txb_Rut.Text & Principal_Empresa_txb_NumVerif.Text + "','" + Principal_Empresa_txb_Nombre.Text + "'," + Principal_Empresa_txb_Telefono.Text + ",'" + Principal_Empresa_txb_Direccion.Text + "','t') ")

                llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
                llenarGrillaEmpresa(DataGridView1)
                MessageBox.Show("exito")
            Catch ex As Exception
                MsgBox("Ocurrio un error : " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Principal_Empresa_btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Principal_Empresa_btn_Limpiar.Click
        Principal_Empresa_txb_Rut.Clear()
        Principal_Empresa_txb_Nombre.Clear()
        Principal_Empresa_txb_Direccion.Clear()
        Principal_Empresa_txb_Telefono.Clear()
    End Sub

    Private Sub Principal_Empresa_btn_Eliminar(sender As Object, e As EventArgs) Handles Button2.Click
        sentenciasNonQuery("update empresa set estado_empresa='f' where  idem = " + Principal_Empresa_dgv_Empresa.CurrentRow.Cells(0).Value.ToString + " ")
        llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
        llenarGrillaEmpresa(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        idempcli = DataGridView1.CurrentRow.Cells(0).Value.ToString()

    End Sub


    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Visible = True
        ElseIf CheckBox1.Checked = False Then
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click

        If idempcli = 0 Then
            MessageBox.Show("seleccione una empresa")
            Return
        ElseIf idp = 0 Then
            MessageBox.Show("seleccione un cliente")
            Return

        End If

        Try
            sentenciasNonQuery("update persona set idem = " + idempcli.ToString + " where idp =  " + idp.ToString + " ")
            llenarGrillaCliente()
            MessageBox.Show("Exito : Exito al ingresar el nuevo representante.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Principal_Alquiler_btn_Agregar_Click(sender As Object, e As EventArgs) Handles Principal_Reserva_btn_Agregar.Click
        If Principal_Reserva_dtp_FechaDevFijada.Value.Date < Principal_Reserva_dtp_FechaRetiro.Value.Date Then
            MessageBox.Show("no puede devolver antes de retirar")
            Return
        End If
        If Principal_Reserva_dtp_FechaRetiro.Value.Date < Today.Date Then
            MessageBox.Show("tiene que reservar a partir de hoy")
            Return

        ElseIf Principal_Reserva_dtp_FechaDevFijada.Value.Date < Today.Date Then
            MessageBox.Show("tiene que retirar a partir de hoy")
            Return

        ElseIf idpres = 0 Then
            MessageBox.Show("Debe de seleccionar una persona")
            Return
        End If

        Dim idcr As String = Convert.ToString(executescalar("idc", "categoria", "letra", Principal_Reserva_cmb_categoria.SelectedValue))
        Dim precioCat As Int32 = Integer.Parse(executescalar("costoxdia", "categoria", "idc", idcr))

        Dim userrr = GetUsuario()
        Dim dif As Integer = DateDiff(DateInterval.Day, Principal_Reserva_dtp_FechaRetiro.Value.Date, Principal_Reserva_dtp_FechaDevFijada.Value.Date)
        If dif = 0 Then
            dif = 1
        End If
        Dim precioest As Int32 = dif * precioCat
        Try
            sentenciasNonQuery("insert into alquila values (0,null," + idpres + ", today, null,'" + Principal_Reserva_dtp_FechaRetiro.Value.Date + "',null , '" + Principal_Reserva_dtp_FechaDevFijada.Value.Date + "','Reserva',null,null, '" + userrr + "', " + idcr + ", 't',null,null," + precioest.ToString + ")") 'funciona
        Catch ex As Exception

        End Try
        Try
            sentenciasNonQuery("update persona set estado = 'Alquiler' where idp = " + idp.ToString + "")

        Catch ex As Exception
        End Try
        sentenciasNonQuery("update persona set estado = 'Alquiler' where idp = " + idpres + "")
        llenarGrillaReserva()
        llenarGrillaClienteReserva()
        idpres = 0
    End Sub

    Dim idpres As String = 0

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_Reserva_dgv_Clientes.CellClick
        idpres = Principal_Reserva_dgv_Clientes.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Principal_Empresa_dgv_Empresa_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_Empresa_dgv_Empresa.CellClick

        Principal_Empresa_txb_Rut.Text = Principal_Empresa_dgv_Empresa.CurrentRow.Cells(1).Value.ToString()
        Principal_Empresa_txb_Rut.Text = Principal_Empresa_txb_Rut.Text.Substring(0, Principal_Empresa_txb_Rut.Text.Length - 1)
        Principal_Empresa_txb_Nombre.Text = Principal_Empresa_dgv_Empresa.CurrentRow.Cells(2).Value.ToString()
        Principal_Empresa_txb_Telefono.Text = Principal_Empresa_dgv_Empresa.CurrentRow.Cells(3).Value.ToString()
        Principal_Empresa_txb_Direccion.Text = Principal_Empresa_dgv_Empresa.CurrentRow.Cells(4).Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sentenciasNonQuery("update empresa set rut = '" + Principal_Empresa_txb_Rut.Text + Principal_Empresa_txb_NumVerif.Text + "',nombre = '" + Principal_Empresa_txb_Nombre.Text + "',tel = " + Principal_Empresa_txb_Telefono.Text + ",direccion = '" + Principal_Empresa_txb_Direccion.Text + "' where idem = " + Principal_Empresa_dgv_Empresa.CurrentRow.Cells(0).Value.ToString + "  ")
        llenarGrillaEmpresa(Principal_Empresa_dgv_Empresa)
        llenarGrillaEmpresa(DataGridView1)

    End Sub



    Dim idv As String
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        idp = executescalar("idp", "persona", "tipo_doc = 'C.I.' and num_doc", "" + Principal_Alquiler_dgv_alquier.CurrentRow.Cells(2).Value.ToString + "")
        idr = Principal_Alquiler_dgv_alquier.CurrentRow.Cells(0).Value.ToString
        Dim ids As String = executescalar("ids", "sucursal", "nombre", ComboBox2.SelectedValue)
        '  MsgBox(ids)
        Try
            sentenciasNonQuery("update alquila set idv = " + idv + ", sucursal_ret = " + ids + ",fech_retiro_real = today, estado_alquiler = 'Alquiler' where idr = " + idr + "")
        Catch ex As Exception
        End Try
        Try
            sentenciasNonQuery("update vehiculo set disponibilidad = 'Alquilado' where idv = " + idv + "")
        Catch ex As Exception
        End Try

            llenarGrillaVehiculoAlquila()
        llenarGrillaReserva()
        llenarGrillaVehiculo()
        MsgBox("exito")
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        idv = DataGridView3.CurrentRow.Cells(0).Value.ToString
    End Sub
    Public idvdos As String
    Private Sub idrCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        idr = DataGridView2.CurrentRow.Cells(0).Value.ToString
        idvdos = DataGridView2.CurrentRow.Cells(10).Value.ToString
    End Sub

    Private Sub Principal_Alquiler_btn_alquiler_Click(sender As Object, e As EventArgs) Handles Principal_Alquiler_btn_alquiler.Click
        llenarGrillaReserva()
    End Sub

    Private Sub Principal_alquileres_btn_agregar_Click(sender As Object, e As EventArgs) Handles Principal_alquileres_btn_agregar.Click
        DevolucionVehiculo.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AgregarModelo.ShowDialog()
    End Sub

    Private Sub Principal_Vehiculo_cmb_Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Principal_Vehiculo_cmb_Marca.SelectedIndexChanged
        CargarModelo()
    End Sub

    Private Sub Principal_Vehiculo_btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Principal_Vehiculo_btn_Eliminar.Click
        idv = executescalar("idv", "vehiculo", "matricula", "" + Principal_Vehiculo_dgv_buscarVehiculos.CurrentRow.Cells(1).Value.ToString + "")


        Try
            sentenciasNonQuery("Update vehiculo set estado_uso = 'f' where idv = " + idv + "")

            llenarGrillaVehiculo()
            llenarGrillaVehiculoMantenimiento()
            llenarGrillaVehiculoAlquila()
            MessageBox.Show("Exito al eliminar vehiculo")
        Catch ex As Exception
            MessageBox.Show("Error al intentar elimiar el vehicluo" + ex.Message + "")
        End Try
    End Sub

    Private Sub Login_lbl_Login_Click(sender As Object, e As EventArgs) Handles Login_lbl_Login.MouseHover
        Login_lbl_Login.ForeColor = Color.Black
    End Sub


    Private Sub Login_lbl_Login_Clic12k(sender As Object, e As EventArgs) Handles Login_lbl_Login.MouseLeave
        Login_lbl_Login.ForeColor = Color.White
    End Sub

    Private Sub Principal_Reserva_btn_eliminar_Click(sender As Object, e As EventArgs) Handles Principal_Reserva_btn_eliminar.Click
        If resel = 0 Then
            MessageBox.Show("Debe de seleccionar una reserva para cancelarla")
            Return
        End If

        sentenciasNonQuery("update alquila set estatus = 'f' where idr = " + resel + "")
        sentenciasNonQuery("update persona set estado = 'Libre' where idp = '" + idprespan + "'")

        llenarGrillaCliente()
        llenarGrillaClienteReserva()
        llenarGrillaReserva()
        MessageBox.Show("Exito al cancelar reserva")
    End Sub

    Dim resel As String = 0
    Dim idprespan As String

    Public Sub llenarGrillaEmpleado()
        DataGrids("select p.idp, p.tipo_doc, p.num_doc, p.nombre, p.apellido,p.email,p.tel,p.direccion,p.fech_nac,e.ide,e.cargo,s.ids,s.nombre sucursal from empleado e inner join persona p on p.idp = e.idp inner join sucursal s on s.ids = e.ids where estado_empleado = 't'", Principal_Empleados_dgv_empleado)

    End Sub
    Private Sub Principal_Empleados_btn_agregar_Click(sender As Object, e As EventArgs) Handles Principal_Empleados_btn_agregar.Click

        ids = executescalar("ids", "sucursal", "nombre", "" + Principal_Empleados_cmb_sucursal.SelectedValue + "")
        idp = executescalar("idp", "persona", "tipo_doc = 'C.I.' and num_doc", "" + Principal_Empleados_txb_ci.Text + "")

        If Principal_Empleados_txb_ci.Text.Length < 6 Then
            MessageBox.Show("Error : debe ingresar un número de documento válido", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Principal_clientes_txt_Verificador.Text = ""
            Return
        ElseIf Principal_empleados_txb_Nombre.Text = "" Then
            MessageBox.Show("Error : debe ingresar un nombre", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_empleados_txb_Apellido.Text = "" Then
            MessageBox.Show("Error : debe ingresar un apellido", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_empleados_txb_Email.Text = "" Then
            MessageBox.Show("Error : debe ingresar un mail", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_empleados_txb_Tel.Text = "" Then
            MessageBox.Show("Error : debe ingresar un teléfono", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        ElseIf Principal_empleados_txb_Direc.Text = "" Then
            MessageBox.Show("Error : debe ingresar una dirección", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        Execute("select * from persona where num_doc = '" + Principal_Empleados_txb_ci.Text + Principal_Empleados_txb_ciVerif.Text + "' and trabaja = 't'")
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Este trabajador ya existe.")
            Return
        End If
        Execute("select * from persona where num_doc = '" + Principal_Empleados_txb_ci.Text + Principal_Empleados_txb_ciVerif.Text + "")
        If dt.Rows.Count > 0 Then
            Try
                sentenciasNonQuery("insert into empleado values (0," + idp + "" + ids + "" + Principal_Empleados_txb_Cargo.Text + ",)")
                sentenciasNonQuery("update persona set trabaja = 't' where idp = " + idp + "")
                llenarGrillaEmpleado()
                MessageBox.Show("Exito : Exito al ingresar el nuevo empleado.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As OdbcException
                MessageBox.Show("Error :  No se pudo ingresar nuevo empleado.", "empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Return
        Else

            Try
                sentenciasNonQuery("insert into persona values (0,'" + Principal_Empleados_txb_ci.Text + Principal_Empleados_txb_ciVerif.Text + "','C.I.' , '" + Principal_empleados_txb_Nombre.Text + "' , '" + Principal_empleados_txb_Apellido.Text + "','" + Principal_empleados_txb_Email.Text + "'," + Principal_empleados_txb_Tel.Text + ", '" + Principal_empleados_txb_Direc.Text + "',null,null,'" + Principal_empleados_dtp_FechNac.Value.Date + "',null,null,null,'t',null) ")

                MessageBox.Show("Se ha ingresado una persona a la base de datos.")
            Catch ex As Exception
                MessageBox.Show("Error :  No se pudo ingresar la persona.", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            idp = executescalar("idp", "persona", "tipo_doc = 'C.I.' and num_doc", "" + Principal_Empleados_txb_ci.Text + Principal_Empleados_txb_ciVerif.Text + "")
            Try
                sentenciasNonQuery("insert into empleado values (0," + idp.ToString + "," + ids + ",'" + Principal_Empleados_txb_Cargo.Text + "','t' )")
                llenarGrillaEmpleado()
                MessageBox.Show("Exito : Exito al ingresar el nuevo empleado.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As OdbcException
                MessageBox.Show("Error :  No se pudo ingresar nuevo empleado.", "empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Return
        End If

    End Sub

    Private Sub Principal_empleado_btn_Modificar_Click(sender As Object, e As EventArgs) Handles Principal_empleado_btn_Modificar.Click

        ids = executescalar("ids", "sucursal", "nombre", "" + Principal_Empleados_cmb_sucursal.SelectedValue + "")
        idp = executescalar("idp", "persona", "tipo_doc = 'C.I.' and num_doc", "" + Principal_Empleados_txb_ci.Text + "")

        Try
            sentenciasNonQuery("update persona set nombre = '" + Principal_empleados_txb_Nombre.Text + "', apellido= '" + Principal_empleados_txb_Apellido.Text + "', email = '" + Principal_empleados_txb_Email.Text + "',tel = " + Principal_empleados_txb_Tel.Text + ", direccion= '" + Principal_empleados_txb_Direc.Text + "',fech_nac='" + Principal_empleados_dtp_FechNac.Value.Date + "', num_doc= '" + Principal_Empleados_txb_ci.Text + Principal_Empleados_txb_ciVerif.Text + "' where tipo_doc = 'C.I.' and num_doc = " + Principal_Empleados_dgv_empleado.CurrentRow.Cells(2).Value + "")
            MessageBox.Show("Exito : Exito al modificar los datos de la persona.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error : mo se a podido modificar los datos del empleado", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Try
            sentenciasNonQuery("update empleado set idp =" + idp.ToString + ", ids = " + ids.ToString + ", cargo = '" + Principal_Empleados_txb_Cargo.Text + "' where ide = " + Principal_Empleados_dgv_empleado.CurrentRow.Cells(9).Value.ToString + "")
            llenarGrillaEmpleado()
            MessageBox.Show("Exito : Exito al modificar los datos del empleado.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error : mo se a podido modificar los datos del empleado", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Principal_Empleados_btn_eliminar_Click(sender As Object, e As EventArgs) Handles Principal_Empleados_btn_eliminar.Click

        Try
            sentenciasNonQuery("update persona set trabaja = 'f' where idp =" + Principal_Empleados_dgv_empleado.CurrentRow.Cells(0).Value.ToString + "")
        Catch ex As OdbcException
        End Try
        Try
            sentenciasNonQuery("update empleado set estado_empleado = 'f' where ide = " + Principal_Empleados_dgv_empleado.CurrentRow.Cells(9).Value.ToString + "")
            MessageBox.Show("Exito : Exito al eliminar al empleado.", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            llenarGrillaEmpleado()
        Catch ex As OdbcException
            MessageBox.Show("Error : se a producido un error al intentar eliminar a este empleado", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Principal_mantenimiento_btn_agregar_Click(sender As Object, e As EventArgs) Handles Principal_mantenimiento_btn_agregar.Click

        sentenciasNonQuery("insert into mantenimiento values(0," + Principal_mantenimiento_dgv_CargarVehiculos.CurrentRow.Cells(0).Value.ToString + ",'" + Principal_mantenimiento_txt_descripcion.Text + "'," + Principal_mantenimiento_txb_costo.Text + ",today,null,'t') ")
        sentenciasNonQuery("update vehiculo set disponibilidad = 'Mantenimiento' where idv=" + Principal_mantenimiento_dgv_CargarVehiculos.CurrentRow.Cells(0).Value.ToString + "")

        llenarGrillaMantenimiento()
        llenarGrillaVehiculoMantenimiento()
        MessageBox.Show("se ha iniciado el mantenimiento para este vehiculo.")
    End Sub

    Private Sub Principal_mantenimiento_btn_eliminar_Click(sender As Object, e As EventArgs) Handles Principal_mantenimiento_btn_eliminar.Click
        sentenciasNonQuery("Update mantenimiento set estado_mantenimiento ='f', fech_fin = today where idm = " + Principal_Mantenimiento_dgv_Mantenimientos.CurrentRow.Cells(0).Value.ToString + "")
        sentenciasNonQuery("update vehiculo set disponibilidad = 'Libre' where idv=" + Principal_Mantenimiento_dgv_Mantenimientos.CurrentRow.Cells(1).Value.ToString + "")
        llenarGrillaMantenimiento()
        llenarGrillaVehiculoMantenimiento()
        MessageBox.Show("se termino este mantenimiento")
    End Sub

    Private Sub Principal_mantenimiento_btn_modificar_Click(sender As Object, e As EventArgs) Handles Principal_mantenimiento_btn_modificar.Click
        Dim idvAntigua As Integer = executescalar("idv", "vehiculo", "idv", "" + Principal_Mantenimiento_dgv_Mantenimientos.CurrentRow.Cells(1).Value.ToString + "")
        idv = executescalar("idv", "vehiculo", "idv", "" + Principal_mantenimiento_dgv_CargarVehiculos.CurrentRow.Cells(0).Value.ToString + "")
        If idv > 0 Then
            sentenciasNonQuery("Update mantenimiento set idv = " + Principal_mantenimiento_dgv_CargarVehiculos.CurrentRow.Cells(0).Value.ToString + ",descripcion = '" + Principal_mantenimiento_txt_descripcion.Text + "', costo = '" + Principal_mantenimiento_txb_costo.Text + "' where idm = " + Principal_Mantenimiento_dgv_Mantenimientos.CurrentRow.Cells(0).Value.ToString + "")
            sentenciasNonQuery("update vehiculo set disponibilidad = 'Libre' where idv=" + idvAntigua.ToString + "")
            sentenciasNonQuery("update vehiculo set disponibilidad = 'Mantenimiento' where idv=" + idv.ToString + "")
            llenarGrillaMantenimiento()
            llenarGrillaVehiculoMantenimiento()
        Else
            sentenciasNonQuery("Update mantenimiento set, descripcion = '" + Principal_mantenimiento_txt_descripcion.Text + "', costo = '" + Principal_mantenimiento_txb_costo.Text + "' where idm = " + Principal_Mantenimiento_dgv_Mantenimientos.CurrentRow.Cells(0).Value.ToString + "")
            llenarGrillaMantenimiento()
            llenarGrillaVehiculoMantenimiento()
        End If

    End Sub

    Private Sub ApretaCedulaEmpleado(sender As Object, e As EventArgs) Handles Principal_Empleados_txb_ci.TextChanged

        If tipodoc = 0 Then

            If (Principal_Empleados_txb_ci.Text.Length = 6) Then

                Principal_Empleados_txb_ciVerif.Text = Verif_CI("0" + Principal_Empleados_txb_ci.Text)
            ElseIf Principal_Empleados_txb_ci.Text.Length = 7 Then
                Principal_Empleados_txb_ciVerif.Text = Verif_CI(Principal_Empleados_txb_ci.Text)
            Else
                Principal_Empleados_txb_ciVerif.Text = ""
            End If

        End If

    End Sub

    Private Sub Principal_Reserva_btn_Modificar_Click(sender As Object, e As EventArgs) Handles Principal_Reserva_btn_Modificar.Click
        Try

            resel = Principal_Reserva_dgv_buscar.CurrentRow.Cells(0).Value
            idprespan = Principal_Reserva_dgv_buscar.CurrentRow.Cells(1).Value

            idpres = idprespan

            Principal_Reserva_cmb_categoria.SelectedValue = Principal_Reserva_dgv_buscar.CurrentRow.Cells(6).Value.ToString()
            Principal_Reserva_dtp_FechaRetiro.Value = Date.Parse(Principal_Reserva_dgv_buscar.CurrentRow.Cells(7).Value.ToString())
            Principal_Reserva_dtp_FechaDevFijada.Value = Date.Parse(Principal_Reserva_dgv_buscar.CurrentRow.Cells(8).Value.ToString())

            Principal_Reserva_btn_Salvar.Visible = True
        Catch ex As Exception
            MessageBox.Show("Por favor seleccione una reserva para modificar")
        End Try

    End Sub

    Private Sub Principal_Reserva_btn_Salvar_Click(sender As Object, e As EventArgs) Handles Principal_Reserva_btn_Salvar.Click
        If Principal_Reserva_dtp_FechaDevFijada.Value.Date < Principal_Reserva_dtp_FechaRetiro.Value.Date Then
            MessageBox.Show("no puede devolver antes de retirar")
            Return
        End If
        If Principal_Reserva_dtp_FechaRetiro.Value.Date < Today.Date Then
            MessageBox.Show("tiene que reservar a partir de hoy")
            Return

        ElseIf Principal_Reserva_dtp_FechaDevFijada.Value.Date < Today.Date Then
            MessageBox.Show("tiene que retirar a partir de hoy")
            Return

        ElseIf idpres = 0 Then
            MessageBox.Show("Debe de seleccionar una persona")
            Return
        End If

        Dim idcr As String = Convert.ToString(executescalar("idc", "categoria", "letra", Principal_Reserva_cmb_categoria.SelectedValue))
        Dim precioCat As Int32 = Integer.Parse(executescalar("costoxdia", "categoria", "idc", idcr))

        Dim userrr = GetUsuario()
        Dim dif As Integer = DateDiff(DateInterval.Day, Principal_Reserva_dtp_FechaRetiro.Value.Date, Principal_Reserva_dtp_FechaDevFijada.Value.Date)
        If dif = 0 Then
            dif = 1
        End If
        Dim precioest As Int32 = dif * precioCat

        Try
            sentenciasNonQuery("update alquila set idc = " + idcr + ", fecha_retiro_fijada = '" + Principal_Reserva_dtp_FechaRetiro.Value.Date.ToString + "', fech_devolucion_fijada = '" + Principal_Reserva_dtp_FechaDevFijada.Value.Date.ToString + "', precio_estimado = " + precioest.ToString + " where idr = " + resel)
        Catch ex As Exception

        End Try

        llenarGrillaReserva()
        llenarGrillaClienteReserva()
        idpres = 0

        Principal_Reserva_btn_Salvar.Visible = False
    End Sub

    Private Sub Principal_Reserva_btn_Vertodo_Click(sender As Object, e As EventArgs) Handles Principal_Reserva_btn_Vertodo.Click
        llenarGrillaReserva()
        llenarGrillaClienteReserva()

    End Sub

    Private Sub Principal_Alquiler_dgv_alquier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Principal_Alquiler_dgv_alquier.CellClick
        DataGridView3.DataSource = New DataTable
        llenarGrillaVehiculoAlquila()

    End Sub



#End Region


    '-------------------------------------------------------------
    '|     |
    '                                                            |------------------------------------------|
    'TERMINAR AL APRETAR DATAGRIDVIEW SE CARGUEN EN TEXTBOX    |
    '                                                           |
    'PROBA SI CONTROLE BIEN TODOS LOS CARACTERES EN LOS TEXTBOX |
    '                          |--------------------------------|
    'TERMINAR BUSCADORES       |
    '                          |   
    'TERMINAR TITULOS DE LOS DGV|
    '                          |-    
    'TERMINAR CAMBIO DE IDIOMA |
    '                          |    
    'GENERAR EL EJECUTABLE BIEN|    
    '                          |----------------------------------------------------------------------------------------------------------------------------------|
    '|
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------|
    ' panel reserva : cancelar --> preguntar si el usuario esta seguro
End Class

