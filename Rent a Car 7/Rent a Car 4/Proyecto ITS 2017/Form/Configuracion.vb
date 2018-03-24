Public Class Configuracion
    Public colorcito As Color
    Private Sub ConfLoad(sender As Object, e As EventArgs) Handles MyBase.Load



        Configuracion_lbl_Host.Text = HostName

        Configuracion_lbl_IP.Text = GetIP()

        Configuracion_lbl_Hora.Text = GetHora()

        Configuracion_lbl_Fecha.Text = GetFecha()

        Configuracion_lbl_Usuario.Text = GetUsuario()

        Configuracion_lbl_Tipo.Text = permisos

    End Sub

    Private Sub SalirConf(sender As Object, e As EventArgs) Handles Configuracion_btn_Salir.Click

        Me.Close()

    End Sub

    Private Sub ConfiguracionDefecto(sender As Object, e As EventArgs) Handles Configuracion_btn_Defecto.Click
        'por defecto el idioma es español
        Español()
        'por defecto el color de fondo de los dgv 
        Principal.Principal_Clientes_dgv_PersonaEmpresa.BackgroundColor = colordefecto
        Principal.Principal_Vehiculo_dgv_buscarVehiculos.BackgroundColor = colordefecto
        Principal.Principal_Reserva_dgv_buscar.BackgroundColor = colordefecto
        Principal.Principal_Mantenimiento_dgv_Mantenimientos.BackgroundColor = colordefecto
        Principal.Principal_Alquiler_dgv_alquier.BackgroundColor = colordefecto
        Principal.Principal_Empleados_dgv_empleado.BackgroundColor = colordefecto
        Principal.Principal_Empresa_dgv_Empresa.BackgroundColor = colordefecto
        Principal.Principal_ExClientes_dgv_ExClientes.BackgroundColor = colordefecto
        'por defecto color de los selectores de dgv
        ' Principal.Principal_Clientes_dgv_PersonaEmpresa.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Vehiculo_dgv_buscarVehiculos.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Reserva_dgv_buscar.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Mantenimiento_dgv_Mantenimientos.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Alquiler_dgv_alquier.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Empleados_dgv_empleado.DefaultCellStyle.SelectionBackColor = colordefecto
        Principal.Principal_Empresa_dgv_Empresa.DefaultCellStyle.SelectionBackColor = colordefecto
        ' Principal.Principal_ExClientes_dgv_ExClientes.DefaultCellStyle.SelectionBackColor = colordefecto
        'por defecto color de form principal
        Principal.BackColor = colordefecto


    End Sub


    Private Sub Cerrar(sender As Object, e As EventArgs) Handles Configuracion_btn_Aceptar.Click

        Me.Close()

    End Sub


    Private Sub BotonColorDialog(sender As Object, e As EventArgs) Handles Button1.Click

        'Mostramos el ColorDialog para seleccionar el color
        Configuraciones_col_ColorDialog1.ShowDialog()
        'Guardamos el color seleccionado en un objeto de tipo Color que esta en Modulo_Diseño
        colorcito = Configuraciones_col_ColorDialog1.Color
        'Limpiamos los toolstrip para que no quede el color anterior
        Principal.LimpiarToolStrip()
        'Comenzamos a darle el nuevo color a todo lo que queremos que cambie:
        'color de fondo del panel princiapl
        Principal.BackColor = colorcito
        'color de fondo de dgv
        Principal.Principal_Clientes_dgv_PersonaEmpresa.BackgroundColor = colorcito
        Principal.Principal_Vehiculo_dgv_buscarVehiculos.BackgroundColor = colorcito
        Principal.Principal_Reserva_dgv_buscar.BackgroundColor = colorcito
        Principal.Principal_Mantenimiento_dgv_Mantenimientos.BackgroundColor = colorcito
        Principal.Principal_Alquiler_dgv_alquier.BackgroundColor = colorcito
        Principal.Principal_Empleados_dgv_empleado.BackgroundColor = colorcito
        Principal.Principal_Empresa_dgv_Empresa.BackgroundColor = colorcito
        Principal.Principal_ExClientes_dgv_ExClientes.BackgroundColor = colorcito
        Principal.Principal_Sucursal_dgv_Sucursal.BackgroundColor = colorcito
        Principal.DataGridView1.BackgroundColor = colorcito
        'color de selector de dgv
        ' Principal.Principal_Clientes_dgv_PersonaEmpresa.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Vehiculo_dgv_buscarVehiculos.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Reserva_dgv_buscar.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Mantenimiento_dgv_Mantenimientos.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Alquiler_dgv_alquier.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Empleados_dgv_empleado.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Empresa_dgv_Empresa.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_ExClientes_dgv_ExClientes.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.Principal_Sucursal_dgv_Sucursal.DefaultCellStyle.SelectionBackColor = colorcito
        Principal.DataGridView1.DefaultCellStyle.SelectionBackColor = colorcito

        Select Case Principal.panelsel
            Case 1
                Principal.Principal_tlp_Clientes.BackColor = colorcito
            Case 2
                Principal.Principal_tlp_Vehiculo.BackColor = colorcito
            Case 3
                Principal.Principal_tlp_Alquiler.BackColor = colorcito
            Case 4
                Principal.Principal_tlp_Sucursal.BackColor = colorcito
            Case 5
                Principal.EmpresaToolStripMenuItem.BackColor = colorcito
        End Select
    End Sub

    Private Sub Login_btn_Español_Click(sender As Object, e As EventArgs) Handles Login_btn_Español.Click
        Español()
    End Sub

    Private Sub Login_btn_Ingles_Click(sender As Object, e As EventArgs) Handles Login_btn_Ingles.Click
        Ingles()
    End Sub


End Class