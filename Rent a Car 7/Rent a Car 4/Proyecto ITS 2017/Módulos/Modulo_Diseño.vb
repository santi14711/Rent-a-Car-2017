Imports System.Configuration
Imports System.Net.Dns

Module Modulo_diseño

    'variables

    Public IP As String

    Public permisos As String

    Private Hora As String = Now.ToLongTimeString

    Private Fecha As String = Now.ToString("dd/MM/yyyy")

    Public colordefecto As Color = Color.DarkSlateGray
    'clases
    Public colorcito As Color = Color.DarkSlateGray

    Public HostName As String = System.Net.Dns.GetHostName

    Public Function GetHora() As String
        Return Hora
    End Function

    Public Function GetFecha() As String
        Return Fecha
    End Function

    Public Function GetIP() As String

        Dim IPAdress As String = GetHostByName(HostName).AddressList(0).ToString()

        Return IPAdress

    End Function

    Public Sub Español()
        'Login
        Login.Login_box_Mostrar.Text = Proyecto_ITS_2017.My.Resources.Español.Login_boxshow
        Login.Login_lbl_User.Text = Proyecto_ITS_2017.My.Resources.Español.Login_lblUser
        Login.Login_lbl_Pass.Text = Proyecto_ITS_2017.My.Resources.Español.Login_lblPass
        Login.Login_btn_Entrar.Text = Proyecto_ITS_2017.My.Resources.Español.Login_btnIn
        Login.Login_lbl_Avisos.Text = Proyecto_ITS_2017.My.Resources.Español.Login_lblavisos

        'Principal Titulos
        Principal.Principal_tlp_Opciones.Text = Proyecto_ITS_2017.My.Resources.Español.panopciones
        Principal.Principal_tlp_Vehiculo.Text = Proyecto_ITS_2017.My.Resources.Español.panvehiculo
        Principal.Principal_tlp_Alquiler.Text = Proyecto_ITS_2017.My.Resources.Español.tlpAlquiler
        Principal.Principal_tlp_Clientes.Text = Proyecto_ITS_2017.My.Resources.Español.tlpPersona
        Principal.Principal_tlp_Sucursal.Text = Proyecto_ITS_2017.My.Resources.Español.tlpSucursal
        Principal.Principal_tlp_Opciones_Configuracion.Text = Proyecto_ITS_2017.My.Resources.Español.tlpOpciones_configuracion
        Principal.Principal_tlp_Opciones_CrrSes.Text = Proyecto_ITS_2017.My.Resources.Español.tlpOpciones_cerrarses
        Principal.Principal_tlp_Opciones_Salir.Text = Proyecto_ITS_2017.My.Resources.Español.tlpOpciones_salir
        Principal.Principal_tlp_Persona_Cliente.Text = Proyecto_ITS_2017.My.Resources.Español.tlpPersona_cliente
        Principal.Principal_tlp_Persona_Empleado.Text = Proyecto_ITS_2017.My.Resources.Español.tlpPersona_empleado
        Principal.Principal_tlp_Persona_Particular.Text = Proyecto_ITS_2017.My.Resources.Español.tlpPersona_particular
        Principal.Principal_tlp_Persona_ExCli.Text = Proyecto_ITS_2017.My.Resources.Español.tlpPersona_exCli
        Principal.Principal_tlp_Vehiculo_Flota.Text = Proyecto_ITS_2017.My.Resources.Español.tlpVehiculo_flota
        Principal.Principal_tlp_Vehiculo_Man.Text = Proyecto_ITS_2017.My.Resources.Español.tlpVehiculo_mantenimiento
        Principal.Principal_tlp_Alquiler_Reserva.Text = Proyecto_ITS_2017.My.Resources.Español.tlpAlquiler_reserva
        Principal.Principal_tlp_Alquiler_Historial.Text = Proyecto_ITS_2017.My.Resources.Español.tlpAlquiler_historial
        Principal.EmpresaToolStripMenuItem.Text = Proyecto_ITS_2017.My.Resources.Español.tlpEmpresa

        'Configuracion
        Configuracion.Configuracion_lbl_Titulo.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_titulo
        Configuracion.Button1.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_CambioColor
        Configuracion.Configuracion_btn_Aceptar.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_Aceptar
        Configuracion.Configuracion_btn_Defecto.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_ConfigDefecto
        Configuracion.Configuracion_lbl_TituloUsuario.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_NombreDeUsuario
        Configuracion.Configuracion_lbl_TituloTipo.Text = Proyecto_ITS_2017.My.Resources.Español.conf_tipouser
        Configuracion.Configuracion_grp_Ingreso.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_DatosUsuario
        Configuracion.Configuracion_grp_Usuario.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_DatosIngreso
        Configuracion.Configuracion_grp_Idiomas.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_Language
        Configuracion.GroupBox1.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_themes
        Configuracion.Configuracion_lbl_TituloHost.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_nombreHost
        Configuracion.Configuracion_lbl_tituloIP.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_IP
        Configuracion.Configuracion_lbl_TituloHora.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_Hora
        Configuracion.Configuracion_lbl_TituloFecha.Text = Proyecto_ITS_2017.My.Resources.Español.Conf_Fecha

        'Vehiculo
        Principal.Principal_Vehiculo_lbl_TituloMatricula.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_mat
        Principal.Principal_Vehiculo_grp_DatosVehiculo.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_veh
        Principal.Principal_Vehiculo_lbl_TituloMarca.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_marca
        Principal.Principal_Vehiculo_lbl_TituloModelo.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_mod

        Principal.Principal_Vehiculo_lbl_TituloSucursal.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_suc
        Principal.Principal_Vehiculo_grp_BuscarVehiculo.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_bus
        Principal.Principal_Vehiculo_lbl_BuscarPor.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_Vehiculo_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar
        Principal.Principal_Vehiculo_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar



        Principal.Principal_Vehiculo_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo




        'Cliente
        Principal.Principal_Clientes_grp_DatosPersona.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_datcli
        Principal.Principal_Clientes_lbl_TituloNombrePersona.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_nom
        Principal.Principal_Clientes_lbl_TituloApellido.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_ape
        Principal.Principal_Clientes_lbl_TituloTelPersona.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_tel
        Principal.Principal_Clientes_lbl_TituloDirPersona.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_dir
        Principal.Principal_Clientes_lbl_TituloFechaNacimiento.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_fnac
        Principal.Principal_Clientes_lbl_TituloTipoDoc.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_tipodoc
        Principal.Principal_Clientes_lbl_TituloNroDoc.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_numdoc
        Principal.Principal_Clientes_lbl_TituloVencimientoLicencia.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_venlic
        Principal.Principal_Clientes_lbl_TituloDepLicencia.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_deplic
        Principal.Principal_Clientes_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar
        Principal.Principal_Clientes_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar
        Principal.Principal_Clientes_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_clientes_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_Clientes_grp_BuscarPersonaEmpresa.Text = My.Resources.Español.grpclientes
        Principal.Principal_Cliente_lbl_buscarPor.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_Clientes_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnmodificar
        Principal.Principal_clientes_cmb_buscarpor.Items(0) = Proyecto_ITS_2017.My.Resources.Español.cmbClientesBuscardoc
        Principal.Principal_clientes_cmb_buscarpor.Items(1) = Proyecto_ITS_2017.My.Resources.Español.cmbClientesBuscarApellido
        Principal.Principal_clientes_cmb_buscarpor.Items(2) = Proyecto_ITS_2017.My.Resources.Español.cmbClientesBuscarMatri

        Principal.GroupBox1.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteEmpresa_datemp
        Principal.Principal_clientes_lbl_categoria.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_cat
        Principal.Principal_Clientes_cmb_TipoDoc.Items(0) = Proyecto_ITS_2017.My.Resources.Español.Dato_ci
        Principal.Principal_Clientes_cmb_TipoDoc.Items(1) = Proyecto_ITS_2017.My.Resources.Español.Dato_pasaporte
        Principal.Principal_clientes_btn_deudor.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_asignardeu
        Principal.Principal_clientes_lbl_resultados.Text = Proyecto_ITS_2017.My.Resources.Español.lblNoSeEncontro


        'Ex Cliente
        Principal.Principal_ExClientes_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_ExClientes_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_ExClientes_gpr_Datos.Text = Proyecto_ITS_2017.My.Resources.Español.panExcli_datos
        Principal.Principal_ExClientes_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_ExClientes_btn_Recuperar.Text = Proyecto_ITS_2017.My.Resources.Español.btnRecuperar
        Principal.Principal_ExClientes_gpr_VerExClientes.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_bus
        Principal.Principal_ExClientes_lbl_NoEncontrado.Text = Proyecto_ITS_2017.My.Resources.Español.lblNoSeEncontro
        Principal.Principal_ExClientes_cbx_NroDoc.Text = Proyecto_ITS_2017.My.Resources.Español.dgvPersona_nDoc
        Principal.Principal_ExClientes_cbx_Apellido.Text = Proyecto_ITS_2017.My.Resources.Español.dgvPersona_apeCli
        Principal.Principal_ExClientes_cbx_Estado.Text = Proyecto_ITS_2017.My.Resources.Español.dgvpersona_est

        'Empleado
        Principal.Principal_Empleados_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_Empleados_gpr_DatosEmpleados.Text = Proyecto_ITS_2017.My.Resources.Español.panEmpleado_datos
        Principal.Principal_Empleados_gpr_BuscarEmpleados.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_bus
        Principal.Principal_Empleados_lbl_buscarpor.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_Empleados_btn_limpiarEmpleado.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Empleados_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar
        Principal.Principal_empleado_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnmodificar
        Principal.Principal_Empleados_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar
        Principal.Principal_Empleados_lbl_nroCedula.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_numdoc
        Principal.Principal_Empleados_lbl_sucursal.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_suc
        Principal.Principal_Empleados_lbl_seccion.Text = Proyecto_ITS_2017.My.Resources.Español.panEmpleado_seccion

        'Mantenimiento
        Principal.Principal_Mantenimiento_grp_DatosMantenimiento.Text = Proyecto_ITS_2017.My.Resources.Español.panMantenimiento_datos
        Principal.Principal_Mantenimiento_grp_Buscar.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_bus
        Principal.Principal_mantenimiento_lbl_buscarpor.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_mantenimiento_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_mantenimiento_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar
        Principal.Principal_mantenimiento_btn_modificar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnmodificar
        Principal.Principal_mantenimiento_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar
        Principal.Principal_mantenimiento_btn_limpiar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Mantenimiento_lbl_Tipo.Text = Proyecto_ITS_2017.My.Resources.Español.panMantenimiento_desc



        'alquiler

        Principal.Principal_alquileres_grp_buscar.Text = Proyecto_ITS_2017.My.Resources.Español.panVehiculo_bus
        Principal.Principal_Alquiler_lbl_buscaralquiler.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_Alquiler_btn_alquiler.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo

        Principal.Principal_alquileres_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar



        'Reserva
        Principal.Principal_Reserva_grp_DatosAlquiler.Text = Proyecto_ITS_2017.My.Resources.Español.datoReserva
        Principal.Principal_Reserva_grp_BuscarAlq.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_bus
        Principal.Principal_Reserva_btn_Vertodo.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo

        Principal.Principal_Reserva_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar

        Principal.Principal_Reserva_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar


        Principal.Principal_Reserva_lbl_TituloFechaDevFijada.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_fechadevfija
        Principal.Principal_Reserva_lbl_TituloFechaRetiro.Text = Proyecto_ITS_2017.My.Resources.Español.datoFLimiteDev


        'Sucursal
        Principal.Principal_Sucursal_gpr_DatosSucursal.Text = Proyecto_ITS_2017.My.Resources.Español.datoSucursal
        Principal.Principal_Sucursal_grp_BuscarSucursal.Text = Proyecto_ITS_2017.My.Resources.Español.busSucursal
        Principal.Principal_Sucursal_gpr_VerSucursales.Text = Proyecto_ITS_2017.My.Resources.Español.panSucursal_DatosBuscador
        Principal.Principal_Sucursal_btn_LimpiarDatos.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Sucursal_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnagregar
        Principal.Principal_Sucursal_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnmodificar
        Principal.Principal_Sucursal_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btneliminar
        Principal.Principal_Sucursal_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Sucursal_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_Sucursal_lbl_Nombre.Text = Proyecto_ITS_2017.My.Resources.Español.panSucursal_nom
        Principal.Principal_Sucursal_lbl_Direccion.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_dir
        Principal.Principal_Sucursal_lbl_Telefono.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_tel
        Principal.Principal_Sucursal_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor
        Principal.Principal_Sucursal_cbx_Nombre.Text = Proyecto_ITS_2017.My.Resources.Español.checkNom
        Principal.Principal_Sucursal_cbx_Direccion.Text = Proyecto_ITS_2017.My.Resources.Español.checkDir
        Principal.Principal_Sucursal_cbx_Telefono.Text = Proyecto_ITS_2017.My.Resources.Español.checkTel

        'Empresa
        Principal.Principal_Empresa_gpr_BuscarEmpresa.Text = Proyecto_ITS_2017.My.Resources.Español.buscarEmpresa
        Principal.Principal_Empresa_gpr_DatosEmpresa.Text = Proyecto_ITS_2017.My.Resources.Español.datoEmpresa
        'Principal.Principal_Empresa_gpr_VerEmpresas
        Principal.Principal_Empresa_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Español.panReserva_btnvertodo
        Principal.Principal_Empresa_btn_LimpiarBusca.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Empresa_lbl_Nombre.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_nom
        Principal.Principal_Empresa_lbl_Direccion.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_dir
        Principal.Principal_Empresa_lbl_Telefono.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_tel
        Principal.Principal_Empresa_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnlimpiar
        Principal.Principal_Empresa_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Español.panCliente_btnmodificar
        Principal.Principal_Empresa_cbx_Nombre.Text = Proyecto_ITS_2017.My.Resources.Español.checkNom
        Principal.Principal_Empresa_cbx_Telefono.Text = Proyecto_ITS_2017.My.Resources.Español.checkTel
        Principal.Principal_Empresa_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Español.panClienteBuscar_buspor


        'www.lawebdelprogramador.com/pdf/285-El-lenguaje-de-programacion-C.html
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(0).Visible = False
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(1).HeaderText = My.Resources.Español.Dato_ci
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(2).HeaderText = My.Resources.Español.dgvPersona_tipDoc
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(3).HeaderText = My.Resources.Español.dgvPersona_nomCli
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(4).HeaderText = My.Resources.Español.dgvPersona_apeCli
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(5).HeaderText = My.Resources.Español.dgvPersona_fNac
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(6).HeaderText = My.Resources.Español.dgvPersona_mail
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(7).HeaderText = My.Resources.Español.dgvPersona_tel
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(8).HeaderText = My.Resources.Español.dgvpersona_dir
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(9).HeaderText = My.Resources.Español.dgvpersona_cat
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(10).HeaderText = My.Resources.Español.dgvpersona_venc
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(11).HeaderText = My.Resources.Español.dgvpersona_dep
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(12).HeaderText = My.Resources.Español.dgvpersona_est
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(14).HeaderText = My.Resources.Español.dgvpersona_nome
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(13).Visible = False

        For i = 0 To Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows.Count - 1
            Select Case Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)
                Case "Alquiler"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(80, 90, 250)
            End Select
        Next
    End Sub
    Public Function calculorut(ByVal rut_cadena As String) As String

        Dim rut(11), NumeroComprobador(11), copiarut(11), suma, resta, verificador As Integer

        NumeroComprobador(0) = 4
        NumeroComprobador(1) = 3
        NumeroComprobador(2) = 2
        NumeroComprobador(3) = 9
        NumeroComprobador(4) = 8
        NumeroComprobador(5) = 7
        NumeroComprobador(6) = 6
        NumeroComprobador(7) = 5
        NumeroComprobador(8) = 4
        NumeroComprobador(9) = 3
        NumeroComprobador(10) = 2

        For i As Integer = 0 To 10
            copiarut(i) = Mid(rut_cadena, i + 1, 1)
            rut(i) = copiarut(i) * NumeroComprobador(i)
            suma += rut(i)
        Next
        resta = suma Mod 11
        If resta = 0 Then
            verificador = 0
        Else
            verificador = 11 - resta
        End If

        Return verificador

    End Function

    Public Function Verif_CI(ByVal ci_cadena As String) As String
        Try

            Dim ciVec(7), result(7), NumComprobador(7), sumatoria As Integer
            Dim resto, Resto_sumatoria, ccc, ccc_Sumatoria As Integer

            ccc = 0
            ccc_Sumatoria = 0

            NumComprobador(0) = 2
            NumComprobador(1) = 9
            NumComprobador(2) = 8
            NumComprobador(3) = 7
            NumComprobador(4) = 6
            NumComprobador(5) = 3
            NumComprobador(6) = 4


            For i As Integer = 0 To 6
                ciVec(i) = Val(ci_cadena(i))

                result(i) = ciVec(i) * NumComprobador(i)

                If result(i) >= 10 Then
                    resto = result(i) Mod 10
                    ccc = 0
                    While resto > 0
                        result(i) -= 1
                        ccc += 1
                        resto = result(i) Mod 10
                    End While
                    result(i) = ccc
                End If
                sumatoria += result(i)
            Next

            Resto_sumatoria = sumatoria Mod 10
            While Resto_sumatoria > 0
                sumatoria += 1
                ccc_Sumatoria += 1

                Resto_sumatoria = sumatoria Mod 10
            End While

            Return ccc_Sumatoria
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Sub Ingles()
        'Login
        Login.Login_box_Mostrar.Text = Proyecto_ITS_2017.My.Resources.Ingles.Login_boxshow
        Login.Login_lbl_User.Text = Proyecto_ITS_2017.My.Resources.Ingles.Login_lblUser
        Login.Login_lbl_Pass.Text = Proyecto_ITS_2017.My.Resources.Ingles.Login_lblPass
        Login.Login_btn_Entrar.Text = Proyecto_ITS_2017.My.Resources.Ingles.Login_btnIn
        Login.Login_lbl_Avisos.Text = Proyecto_ITS_2017.My.Resources.Ingles.Login_lblavisos

        'Principal Titulos
        Principal.Principal_tlp_Opciones.Text = Proyecto_ITS_2017.My.Resources.Ingles.panopciones
        Principal.Principal_tlp_Vehiculo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panvehiculo
        Principal.Principal_tlp_Alquiler.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpAlquiler
        Principal.Principal_tlp_Clientes.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpPersona
        Principal.Principal_tlp_Sucursal.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpSucursal
        Principal.Principal_tlp_Opciones_Configuracion.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpOpciones_configuracion
        Principal.Principal_tlp_Opciones_CrrSes.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpOpciones_cerrarses
        Principal.Principal_tlp_Opciones_Salir.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpOpciones_salir
        Principal.Principal_tlp_Persona_Cliente.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpPersona_cliente
        Principal.Principal_tlp_Persona_Empleado.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpPersona_empleado
        Principal.Principal_tlp_Persona_Particular.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpPersona_particular
        Principal.Principal_tlp_Persona_ExCli.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpPersona_exCli
        Principal.Principal_tlp_Vehiculo_Flota.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpVehiculo_flota
        Principal.Principal_tlp_Vehiculo_Man.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpVehiculo_mantenimiento
        Principal.Principal_tlp_Alquiler_Reserva.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpAlquiler_reserva
        Principal.Principal_tlp_Alquiler_Historial.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpAlquiler_historial
        Principal.EmpresaToolStripMenuItem.Text = Proyecto_ITS_2017.My.Resources.Ingles.tlpEmpresa

        'Configuracion
        Configuracion.Configuracion_lbl_Titulo.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_titulo
        Configuracion.Button1.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_CambioColor
        Configuracion.Configuracion_btn_Aceptar.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_Aceptar
        Configuracion.Configuracion_btn_Defecto.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_ConfigDefecto
        Configuracion.Configuracion_lbl_TituloUsuario.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_NombreDeUsuario
        Configuracion.Configuracion_lbl_TituloTipo.Text = Proyecto_ITS_2017.My.Resources.Ingles.conf_tipouser
        Configuracion.Configuracion_grp_Ingreso.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_DatosUsuario
        Configuracion.Configuracion_grp_Usuario.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_DatosIngreso
        Configuracion.Configuracion_grp_Idiomas.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_Language
        Configuracion.GroupBox1.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_themes
        Configuracion.Configuracion_lbl_TituloHost.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_nombreHost
        Configuracion.Configuracion_lbl_tituloIP.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_IP
        Configuracion.Configuracion_lbl_TituloHora.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_Hora
        Configuracion.Configuracion_lbl_TituloFecha.Text = Proyecto_ITS_2017.My.Resources.Ingles.Conf_Fecha

        'Vehiculo
        Principal.Principal_Vehiculo_lbl_TituloMatricula.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_mat
        Principal.Principal_Vehiculo_grp_DatosVehiculo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_veh
        Principal.Principal_Vehiculo_lbl_TituloMarca.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_marca
        Principal.Principal_Vehiculo_lbl_TituloModelo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_mod

        Principal.Principal_Vehiculo_lbl_TituloSucursal.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_suc
        Principal.Principal_Vehiculo_grp_BuscarVehiculo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_bus
        Principal.Principal_Vehiculo_lbl_BuscarPor.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_Vehiculo_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar
        Principal.Principal_Vehiculo_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar




        Principal.Principal_Vehiculo_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo




        'Cliente
        Principal.Principal_Clientes_grp_DatosPersona.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_datcli
        Principal.Principal_Clientes_lbl_TituloNombrePersona.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_nom
        Principal.Principal_Clientes_lbl_TituloApellido.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_ape
        Principal.Principal_Clientes_lbl_TituloTelPersona.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_tel
        Principal.Principal_Clientes_lbl_TituloDirPersona.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_dir
        Principal.Principal_Clientes_lbl_TituloFechaNacimiento.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_fnac
        Principal.Principal_Clientes_lbl_TituloTipoDoc.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_tipodoc
        Principal.Principal_Clientes_lbl_TituloNroDoc.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_numdoc
        Principal.Principal_Clientes_lbl_TituloVencimientoLicencia.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_venlic
        Principal.Principal_Clientes_lbl_TituloDepLicencia.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_deplic
        Principal.Principal_Clientes_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar
        Principal.Principal_Clientes_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar
        Principal.Principal_Clientes_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_clientes_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_Clientes_grp_BuscarPersonaEmpresa.Text = My.Resources.Ingles.grpclientes
        Principal.Principal_Cliente_lbl_buscarPor.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_Clientes_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnmodificar
        Principal.Principal_clientes_cmb_buscarpor.Items(0) = Proyecto_ITS_2017.My.Resources.Ingles.cmbClientesBuscardoc
        Principal.Principal_clientes_cmb_buscarpor.Items(1) = Proyecto_ITS_2017.My.Resources.Ingles.cmbClientesBuscarApellido
        Principal.Principal_clientes_cmb_buscarpor.Items(2) = Proyecto_ITS_2017.My.Resources.Ingles.cmbClientesBuscarMatri

        Principal.GroupBox1.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteEmpresa_datemp
        Principal.Principal_clientes_lbl_categoria.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_cat
        Principal.Principal_Clientes_cmb_TipoDoc.Items(0) = Proyecto_ITS_2017.My.Resources.Ingles.Dato_ci
        Principal.Principal_Clientes_cmb_TipoDoc.Items(1) = Proyecto_ITS_2017.My.Resources.Ingles.Dato_pasaporte
        Principal.Principal_clientes_btn_deudor.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_asignardeu
        Principal.Principal_clientes_lbl_resultados.Text = Proyecto_ITS_2017.My.Resources.Ingles.lblNoSeEncontro


        'Ex Cliente
        Principal.Principal_ExClientes_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_ExClientes_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_ExClientes_gpr_Datos.Text = Proyecto_ITS_2017.My.Resources.Ingles.panExcli_datos
        Principal.Principal_ExClientes_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_ExClientes_btn_Recuperar.Text = Proyecto_ITS_2017.My.Resources.Ingles.btnRecuperar
        Principal.Principal_ExClientes_gpr_VerExClientes.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_bus
        Principal.Principal_ExClientes_lbl_NoEncontrado.Text = Proyecto_ITS_2017.My.Resources.Ingles.lblNoSeEncontro
        Principal.Principal_ExClientes_cbx_NroDoc.Text = Proyecto_ITS_2017.My.Resources.Ingles.dgvPersona_nDoc
        Principal.Principal_ExClientes_cbx_Apellido.Text = Proyecto_ITS_2017.My.Resources.Ingles.dgvPersona_apeCli
        Principal.Principal_ExClientes_cbx_Estado.Text = Proyecto_ITS_2017.My.Resources.Ingles.dgvpersona_est

        'Empleado
        Principal.Principal_Empleados_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_Empleados_gpr_DatosEmpleados.Text = Proyecto_ITS_2017.My.Resources.Ingles.panEmpleado_datos
        Principal.Principal_Empleados_gpr_BuscarEmpleados.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_bus
        Principal.Principal_Empleados_lbl_buscarpor.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_Empleados_btn_limpiarEmpleado.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Empleados_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar
        Principal.Principal_empleado_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnmodificar
        Principal.Principal_Empleados_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar
        Principal.Principal_Empleados_lbl_nroCedula.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_numdoc
        Principal.Principal_Empleados_lbl_sucursal.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_suc
        Principal.Principal_Empleados_lbl_seccion.Text = Proyecto_ITS_2017.My.Resources.Ingles.panEmpleado_seccion

        'Mantenimiento
        Principal.Principal_Mantenimiento_grp_DatosMantenimiento.Text = Proyecto_ITS_2017.My.Resources.Ingles.panMantenimiento_datos
        Principal.Principal_Mantenimiento_grp_Buscar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_bus
        Principal.Principal_mantenimiento_lbl_buscarpor.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_mantenimiento_btn_recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_mantenimiento_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar
        Principal.Principal_mantenimiento_btn_modificar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnmodificar
        Principal.Principal_mantenimiento_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar
        Principal.Principal_mantenimiento_btn_limpiar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Mantenimiento_lbl_Tipo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panMantenimiento_desc



        'alquiler

        Principal.Principal_alquileres_grp_buscar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panVehiculo_bus
        Principal.Principal_Alquiler_lbl_buscaralquiler.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_Alquiler_btn_alquiler.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo

        Principal.Principal_alquileres_btn_agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar



        'Reserva
        Principal.Principal_Reserva_grp_DatosAlquiler.Text = Proyecto_ITS_2017.My.Resources.Ingles.datoReserva
        Principal.Principal_Reserva_grp_BuscarAlq.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_bus
        Principal.Principal_Reserva_btn_Vertodo.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo

        Principal.Principal_Reserva_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar

        Principal.Principal_Reserva_btn_eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar


        Principal.Principal_Reserva_lbl_TituloFechaDevFijada.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_fechadevfija
        Principal.Principal_Reserva_lbl_TituloFechaRetiro.Text = Proyecto_ITS_2017.My.Resources.Ingles.datoFLimiteDev


        'Sucursal
        Principal.Principal_Sucursal_gpr_DatosSucursal.Text = Proyecto_ITS_2017.My.Resources.Ingles.datoSucursal
        Principal.Principal_Sucursal_grp_BuscarSucursal.Text = Proyecto_ITS_2017.My.Resources.Ingles.busSucursal
        Principal.Principal_Sucursal_gpr_VerSucursales.Text = Proyecto_ITS_2017.My.Resources.Ingles.panSucursal_DatosBuscador
        Principal.Principal_Sucursal_btn_LimpiarDatos.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Sucursal_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnagregar
        Principal.Principal_Sucursal_btn_Modificar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnmodificar
        Principal.Principal_Sucursal_btn_Eliminar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btneliminar
        Principal.Principal_Sucursal_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Sucursal_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_Sucursal_lbl_Nombre.Text = Proyecto_ITS_2017.My.Resources.Ingles.panSucursal_nom
        Principal.Principal_Sucursal_lbl_Direccion.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_dir
        Principal.Principal_Sucursal_lbl_Telefono.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_tel
        Principal.Principal_Sucursal_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor
        Principal.Principal_Sucursal_cbx_Nombre.Text = Proyecto_ITS_2017.My.Resources.Ingles.checkNom
        Principal.Principal_Sucursal_cbx_Direccion.Text = Proyecto_ITS_2017.My.Resources.Ingles.checkDir
        Principal.Principal_Sucursal_cbx_Telefono.Text = Proyecto_ITS_2017.My.Resources.Ingles.checkTel

        'Empresa
        Principal.Principal_Empresa_gpr_BuscarEmpresa.Text = Proyecto_ITS_2017.My.Resources.Ingles.buscarEmpresa
        Principal.Principal_Empresa_gpr_DatosEmpresa.Text = Proyecto_ITS_2017.My.Resources.Ingles.datoEmpresa
        'Principal.Principal_Empresa_gpr_VerEmpresas
        Principal.Principal_Empresa_btn_Recargar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panReserva_btnvertodo
        Principal.Principal_Empresa_btn_LimpiarBusca.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Empresa_lbl_Nombre.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_nom
        Principal.Principal_Empresa_lbl_Direccion.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_dir
        Principal.Principal_Empresa_lbl_Telefono.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_tel
        Principal.Principal_Empresa_btn_Limpiar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnlimpiar
        Principal.Principal_Empresa_btn_Agregar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panCliente_btnmodificar
        Principal.Principal_Empresa_cbx_Nombre.Text = Proyecto_ITS_2017.My.Resources.Ingles.checkNom
        Principal.Principal_Empresa_cbx_Telefono.Text = Proyecto_ITS_2017.My.Resources.Ingles.checkTel
        Principal.Principal_Empresa_lbl_Buscar.Text = Proyecto_ITS_2017.My.Resources.Ingles.panClienteBuscar_buspor



        DataGrids("select * from dgv_c", Principal.Principal_Clientes_dgv_PersonaEmpresa)
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(0).Visible = False
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(1).HeaderText = My.Resources.Ingles.Dato_ci
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(2).HeaderText = My.Resources.Ingles.dgvPersona_tipDoc
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(3).HeaderText = My.Resources.Ingles.dgvPersona_nomCli
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(4).HeaderText = My.Resources.Ingles.dgvPersona_apeCli
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(5).HeaderText = My.Resources.Ingles.dgvPersona_fNac
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(6).HeaderText = My.Resources.Ingles.dgvPersona_mail
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(7).HeaderText = My.Resources.Ingles.dgvPersona_tel
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(8).HeaderText = My.Resources.Ingles.dgvpersona_dir
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(9).HeaderText = My.Resources.Ingles.dgvpersona_cat
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(10).HeaderText = My.Resources.Ingles.dgvpersona_venc
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(11).HeaderText = My.Resources.Ingles.dgvpersona_dep
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(12).HeaderText = My.Resources.Ingles.dgvpersona_est
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(14).HeaderText = My.Resources.Ingles.dgvpersona_nome
        Principal.Principal_Clientes_dgv_PersonaEmpresa.Columns(13).Visible = False
        For i = 0 To Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows.Count - 1
            Select Case Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).Cells(12).Value
                Case "Deudor"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(180, 80, 80)
                Case "Libre"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(100, 170, 100)
                Case "Alquiler"
                    Principal.Principal_Clientes_dgv_PersonaEmpresa.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(80, 90, 250)
            End Select
        Next

    End Sub
End Module
