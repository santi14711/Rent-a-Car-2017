<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.Configuracion_btn_Salir = New System.Windows.Forms.Button()
        Me.Configuracion_lbl_Titulo = New System.Windows.Forms.Label()
        Me.Configuracion_tim_Funciones = New System.Windows.Forms.Timer(Me.components)
        Me.Configuraciones_col_ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Configuracion_grp_Usuario = New System.Windows.Forms.GroupBox()
        Me.Configuracion_lbl_Host = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_TituloHost = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_Hora = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_tituloIP = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_Fecha = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_IP = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_TituloHora = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_TituloFecha = New System.Windows.Forms.Label()
        Me.Configuracion_grp_Ingreso = New System.Windows.Forms.GroupBox()
        Me.Configuracion_lbl_Usuario = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_Tipo = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_TituloTipo = New System.Windows.Forms.Label()
        Me.Configuracion_lbl_TituloUsuario = New System.Windows.Forms.Label()
        Me.Configuracion_grp_Idiomas = New System.Windows.Forms.GroupBox()
        Me.Login_btn_Español = New System.Windows.Forms.Button()
        Me.Login_btn_Ingles = New System.Windows.Forms.Button()
        Me.Configuracion_btn_Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Configuracion_btn_Defecto = New System.Windows.Forms.Button()
        Me.Configuracion_pnl_Configuracion = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Configuracion_grp_Usuario.SuspendLayout()
        Me.Configuracion_grp_Ingreso.SuspendLayout()
        Me.Configuracion_grp_Idiomas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Configuracion_pnl_Configuracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Configuracion_btn_Salir
        '
        Me.Configuracion_btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Configuracion_btn_Salir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Configuracion_btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Configuracion_btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Configuracion_btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Configuracion_btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Configuracion_btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Configuracion_btn_Salir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_btn_Salir.ForeColor = System.Drawing.SystemColors.Control
        Me.Configuracion_btn_Salir.Location = New System.Drawing.Point(437, -4)
        Me.Configuracion_btn_Salir.Name = "Configuracion_btn_Salir"
        Me.Configuracion_btn_Salir.Size = New System.Drawing.Size(55, 60)
        Me.Configuracion_btn_Salir.TabIndex = 67
        Me.Configuracion_btn_Salir.Text = " X"
        Me.Configuracion_btn_Salir.UseVisualStyleBackColor = False
        '
        'Configuracion_lbl_Titulo
        '
        Me.Configuracion_lbl_Titulo.AutoSize = True
        Me.Configuracion_lbl_Titulo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Configuracion_lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Configuracion_lbl_Titulo.Location = New System.Drawing.Point(58, 18)
        Me.Configuracion_lbl_Titulo.Name = "Configuracion_lbl_Titulo"
        Me.Configuracion_lbl_Titulo.Size = New System.Drawing.Size(216, 17)
        Me.Configuracion_lbl_Titulo.TabIndex = 70
        Me.Configuracion_lbl_Titulo.Text = "Configuraciones del programa"
        '
        'Configuracion_tim_Funciones
        '
        Me.Configuracion_tim_Funciones.Enabled = True
        '
        'Configuraciones_col_ColorDialog1
        '
        Me.Configuraciones_col_ColorDialog1.AnyColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_ITS_2017.My.Resources.Resources.f1fe4e2c004dc614689794d82157e75b
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Configuracion_grp_Usuario
        '
        Me.Configuracion_grp_Usuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Configuracion_grp_Usuario.BackColor = System.Drawing.Color.Transparent
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_Host)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_TituloHost)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_Hora)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_tituloIP)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_Fecha)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_IP)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_TituloHora)
        Me.Configuracion_grp_Usuario.Controls.Add(Me.Configuracion_lbl_TituloFecha)
        Me.Configuracion_grp_Usuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_grp_Usuario.ForeColor = System.Drawing.Color.White
        Me.Configuracion_grp_Usuario.Location = New System.Drawing.Point(16, 17)
        Me.Configuracion_grp_Usuario.Name = "Configuracion_grp_Usuario"
        Me.Configuracion_grp_Usuario.Size = New System.Drawing.Size(325, 119)
        Me.Configuracion_grp_Usuario.TabIndex = 107
        Me.Configuracion_grp_Usuario.TabStop = False
        Me.Configuracion_grp_Usuario.Text = "Datos de ingreso"
        '
        'Configuracion_lbl_Host
        '
        Me.Configuracion_lbl_Host.AutoSize = True
        Me.Configuracion_lbl_Host.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_Host.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_Host.Location = New System.Drawing.Point(145, 93)
        Me.Configuracion_lbl_Host.Name = "Configuracion_lbl_Host"
        Me.Configuracion_lbl_Host.Size = New System.Drawing.Size(68, 16)
        Me.Configuracion_lbl_Host.TabIndex = 90
        Me.Configuracion_lbl_Host.Text = "HostName"
        '
        'Configuracion_lbl_TituloHost
        '
        Me.Configuracion_lbl_TituloHost.AutoSize = True
        Me.Configuracion_lbl_TituloHost.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_TituloHost.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_TituloHost.Location = New System.Drawing.Point(20, 92)
        Me.Configuracion_lbl_TituloHost.Name = "Configuracion_lbl_TituloHost"
        Me.Configuracion_lbl_TituloHost.Size = New System.Drawing.Size(113, 17)
        Me.Configuracion_lbl_TituloHost.TabIndex = 89
        Me.Configuracion_lbl_TituloHost.Text = "Nombre de Host : "
        '
        'Configuracion_lbl_Hora
        '
        Me.Configuracion_lbl_Hora.AutoSize = True
        Me.Configuracion_lbl_Hora.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_Hora.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_Hora.Location = New System.Drawing.Point(145, 46)
        Me.Configuracion_lbl_Hora.Name = "Configuracion_lbl_Hora"
        Me.Configuracion_lbl_Hora.Size = New System.Drawing.Size(36, 16)
        Me.Configuracion_lbl_Hora.TabIndex = 3
        Me.Configuracion_lbl_Hora.Text = "Hora"
        '
        'Configuracion_lbl_tituloIP
        '
        Me.Configuracion_lbl_tituloIP.AutoSize = True
        Me.Configuracion_lbl_tituloIP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_tituloIP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_tituloIP.Location = New System.Drawing.Point(20, 71)
        Me.Configuracion_lbl_tituloIP.Name = "Configuracion_lbl_tituloIP"
        Me.Configuracion_lbl_tituloIP.Size = New System.Drawing.Size(82, 17)
        Me.Configuracion_lbl_tituloIP.TabIndex = 88
        Me.Configuracion_lbl_tituloIP.Text = "Dirección IP:"
        '
        'Configuracion_lbl_Fecha
        '
        Me.Configuracion_lbl_Fecha.AutoSize = True
        Me.Configuracion_lbl_Fecha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_Fecha.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_Fecha.Location = New System.Drawing.Point(145, 26)
        Me.Configuracion_lbl_Fecha.Name = "Configuracion_lbl_Fecha"
        Me.Configuracion_lbl_Fecha.Size = New System.Drawing.Size(45, 16)
        Me.Configuracion_lbl_Fecha.TabIndex = 2
        Me.Configuracion_lbl_Fecha.Text = "Fecha"
        '
        'Configuracion_lbl_IP
        '
        Me.Configuracion_lbl_IP.AutoSize = True
        Me.Configuracion_lbl_IP.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_IP.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_IP.Location = New System.Drawing.Point(145, 72)
        Me.Configuracion_lbl_IP.Name = "Configuracion_lbl_IP"
        Me.Configuracion_lbl_IP.Size = New System.Drawing.Size(19, 16)
        Me.Configuracion_lbl_IP.TabIndex = 87
        Me.Configuracion_lbl_IP.Text = "IP"
        '
        'Configuracion_lbl_TituloHora
        '
        Me.Configuracion_lbl_TituloHora.AutoSize = True
        Me.Configuracion_lbl_TituloHora.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_TituloHora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_TituloHora.Location = New System.Drawing.Point(20, 48)
        Me.Configuracion_lbl_TituloHora.Name = "Configuracion_lbl_TituloHora"
        Me.Configuracion_lbl_TituloHora.Size = New System.Drawing.Size(45, 17)
        Me.Configuracion_lbl_TituloHora.TabIndex = 1
        Me.Configuracion_lbl_TituloHora.Text = "Hora : "
        '
        'Configuracion_lbl_TituloFecha
        '
        Me.Configuracion_lbl_TituloFecha.AutoSize = True
        Me.Configuracion_lbl_TituloFecha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_TituloFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_TituloFecha.Location = New System.Drawing.Point(20, 25)
        Me.Configuracion_lbl_TituloFecha.Name = "Configuracion_lbl_TituloFecha"
        Me.Configuracion_lbl_TituloFecha.Size = New System.Drawing.Size(54, 17)
        Me.Configuracion_lbl_TituloFecha.TabIndex = 0
        Me.Configuracion_lbl_TituloFecha.Text = "Fecha : "
        '
        'Configuracion_grp_Ingreso
        '
        Me.Configuracion_grp_Ingreso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Configuracion_grp_Ingreso.BackColor = System.Drawing.Color.Transparent
        Me.Configuracion_grp_Ingreso.Controls.Add(Me.Configuracion_lbl_Usuario)
        Me.Configuracion_grp_Ingreso.Controls.Add(Me.Configuracion_lbl_Tipo)
        Me.Configuracion_grp_Ingreso.Controls.Add(Me.Configuracion_lbl_TituloTipo)
        Me.Configuracion_grp_Ingreso.Controls.Add(Me.Configuracion_lbl_TituloUsuario)
        Me.Configuracion_grp_Ingreso.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_grp_Ingreso.ForeColor = System.Drawing.Color.White
        Me.Configuracion_grp_Ingreso.Location = New System.Drawing.Point(15, 140)
        Me.Configuracion_grp_Ingreso.Name = "Configuracion_grp_Ingreso"
        Me.Configuracion_grp_Ingreso.Size = New System.Drawing.Size(330, 63)
        Me.Configuracion_grp_Ingreso.TabIndex = 109
        Me.Configuracion_grp_Ingreso.TabStop = False
        Me.Configuracion_grp_Ingreso.Text = "Datos de usuario"
        '
        'Configuracion_lbl_Usuario
        '
        Me.Configuracion_lbl_Usuario.AutoSize = True
        Me.Configuracion_lbl_Usuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_Usuario.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_Usuario.Location = New System.Drawing.Point(146, 20)
        Me.Configuracion_lbl_Usuario.Name = "Configuracion_lbl_Usuario"
        Me.Configuracion_lbl_Usuario.Size = New System.Drawing.Size(51, 16)
        Me.Configuracion_lbl_Usuario.TabIndex = 85
        Me.Configuracion_lbl_Usuario.Text = "Usuario"
        '
        'Configuracion_lbl_Tipo
        '
        Me.Configuracion_lbl_Tipo.AutoSize = True
        Me.Configuracion_lbl_Tipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_Tipo.ForeColor = System.Drawing.Color.White
        Me.Configuracion_lbl_Tipo.Location = New System.Drawing.Point(146, 41)
        Me.Configuracion_lbl_Tipo.Name = "Configuracion_lbl_Tipo"
        Me.Configuracion_lbl_Tipo.Size = New System.Drawing.Size(33, 16)
        Me.Configuracion_lbl_Tipo.TabIndex = 86
        Me.Configuracion_lbl_Tipo.Text = "Tipo"
        '
        'Configuracion_lbl_TituloTipo
        '
        Me.Configuracion_lbl_TituloTipo.AutoSize = True
        Me.Configuracion_lbl_TituloTipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_TituloTipo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_TituloTipo.Location = New System.Drawing.Point(21, 41)
        Me.Configuracion_lbl_TituloTipo.Name = "Configuracion_lbl_TituloTipo"
        Me.Configuracion_lbl_TituloTipo.Size = New System.Drawing.Size(99, 17)
        Me.Configuracion_lbl_TituloTipo.TabIndex = 83
        Me.Configuracion_lbl_TituloTipo.Text = "Tipo de usuario:"
        '
        'Configuracion_lbl_TituloUsuario
        '
        Me.Configuracion_lbl_TituloUsuario.AutoSize = True
        Me.Configuracion_lbl_TituloUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_lbl_TituloUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_lbl_TituloUsuario.Location = New System.Drawing.Point(21, 20)
        Me.Configuracion_lbl_TituloUsuario.Name = "Configuracion_lbl_TituloUsuario"
        Me.Configuracion_lbl_TituloUsuario.Size = New System.Drawing.Size(123, 17)
        Me.Configuracion_lbl_TituloUsuario.TabIndex = 82
        Me.Configuracion_lbl_TituloUsuario.Text = "Nombre de usuario:"
        '
        'Configuracion_grp_Idiomas
        '
        Me.Configuracion_grp_Idiomas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Configuracion_grp_Idiomas.BackColor = System.Drawing.Color.Transparent
        Me.Configuracion_grp_Idiomas.Controls.Add(Me.Login_btn_Español)
        Me.Configuracion_grp_Idiomas.Controls.Add(Me.Login_btn_Ingles)
        Me.Configuracion_grp_Idiomas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_grp_Idiomas.ForeColor = System.Drawing.Color.White
        Me.Configuracion_grp_Idiomas.Location = New System.Drawing.Point(365, 13)
        Me.Configuracion_grp_Idiomas.Name = "Configuracion_grp_Idiomas"
        Me.Configuracion_grp_Idiomas.Size = New System.Drawing.Size(113, 190)
        Me.Configuracion_grp_Idiomas.TabIndex = 104
        Me.Configuracion_grp_Idiomas.TabStop = False
        Me.Configuracion_grp_Idiomas.Text = "Lenguajes"
        '
        'Login_btn_Español
        '
        Me.Login_btn_Español.BackgroundImage = Global.Proyecto_ITS_2017.My.Resources.Resources.es
        Me.Login_btn_Español.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Login_btn_Español.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Login_btn_Español.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login_btn_Español.Location = New System.Drawing.Point(29, 40)
        Me.Login_btn_Español.Name = "Login_btn_Español"
        Me.Login_btn_Español.Size = New System.Drawing.Size(54, 33)
        Me.Login_btn_Español.TabIndex = 73
        Me.Login_btn_Español.UseVisualStyleBackColor = True
        '
        'Login_btn_Ingles
        '
        Me.Login_btn_Ingles.BackColor = System.Drawing.Color.Transparent
        Me.Login_btn_Ingles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Login_btn_Ingles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Login_btn_Ingles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login_btn_Ingles.Image = Global.Proyecto_ITS_2017.My.Resources.Resources.download
        Me.Login_btn_Ingles.Location = New System.Drawing.Point(29, 110)
        Me.Login_btn_Ingles.Name = "Login_btn_Ingles"
        Me.Login_btn_Ingles.Size = New System.Drawing.Size(54, 33)
        Me.Login_btn_Ingles.TabIndex = 74
        Me.Login_btn_Ingles.UseVisualStyleBackColor = False
        '
        'Configuracion_btn_Aceptar
        '
        Me.Configuracion_btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Configuracion_btn_Aceptar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Configuracion_btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Configuracion_btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Configuracion_btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Configuracion_btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Configuracion_btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Configuracion_btn_Aceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_btn_Aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_btn_Aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Configuracion_btn_Aceptar.Location = New System.Drawing.Point(249, 328)
        Me.Configuracion_btn_Aceptar.Name = "Configuracion_btn_Aceptar"
        Me.Configuracion_btn_Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Configuracion_btn_Aceptar.Size = New System.Drawing.Size(225, 49)
        Me.Configuracion_btn_Aceptar.TabIndex = 106
        Me.Configuracion_btn_Aceptar.Text = "Aceptar"
        Me.Configuracion_btn_Aceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 89)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temas"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(176, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 59)
        Me.Button5.TabIndex = 92
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OrangeRed
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(21, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 54)
        Me.Button2.TabIndex = 89
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(333, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(104, 54)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Usar color personalizado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Configuracion_btn_Defecto
        '
        Me.Configuracion_btn_Defecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Configuracion_btn_Defecto.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Configuracion_btn_Defecto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Configuracion_btn_Defecto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Configuracion_btn_Defecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Configuracion_btn_Defecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Configuracion_btn_Defecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Configuracion_btn_Defecto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Configuracion_btn_Defecto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Configuracion_btn_Defecto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Configuracion_btn_Defecto.Location = New System.Drawing.Point(20, 328)
        Me.Configuracion_btn_Defecto.Name = "Configuracion_btn_Defecto"
        Me.Configuracion_btn_Defecto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Configuracion_btn_Defecto.Size = New System.Drawing.Size(207, 49)
        Me.Configuracion_btn_Defecto.TabIndex = 105
        Me.Configuracion_btn_Defecto.Text = "Configuración por defecto"
        Me.Configuracion_btn_Defecto.UseVisualStyleBackColor = False
        '
        'Configuracion_pnl_Configuracion
        '
        Me.Configuracion_pnl_Configuracion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Configuracion_pnl_Configuracion.BackColor = System.Drawing.Color.Silver
        Me.Configuracion_pnl_Configuracion.BackgroundImage = Global.Proyecto_ITS_2017.My.Resources.Resources.thumb_1920_316707
        Me.Configuracion_pnl_Configuracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.Configuracion_btn_Defecto)
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.GroupBox1)
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.Configuracion_btn_Aceptar)
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.Configuracion_grp_Idiomas)
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.Configuracion_grp_Ingreso)
        Me.Configuracion_pnl_Configuracion.Controls.Add(Me.Configuracion_grp_Usuario)
        Me.Configuracion_pnl_Configuracion.Location = New System.Drawing.Point(-3, 50)
        Me.Configuracion_pnl_Configuracion.Name = "Configuracion_pnl_Configuracion"
        Me.Configuracion_pnl_Configuracion.Size = New System.Drawing.Size(493, 399)
        Me.Configuracion_pnl_Configuracion.TabIndex = 68
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(490, 448)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Configuracion_lbl_Titulo)
        Me.Controls.Add(Me.Configuracion_pnl_Configuracion)
        Me.Controls.Add(Me.Configuracion_btn_Salir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConf"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Configuracion_grp_Usuario.ResumeLayout(False)
        Me.Configuracion_grp_Usuario.PerformLayout()
        Me.Configuracion_grp_Ingreso.ResumeLayout(False)
        Me.Configuracion_grp_Ingreso.PerformLayout()
        Me.Configuracion_grp_Idiomas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Configuracion_pnl_Configuracion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Configuracion_btn_Salir As Button
    Friend WithEvents Configuracion_lbl_Titulo As Label
    Friend WithEvents Configuracion_tim_Funciones As Timer
    Public WithEvents Configuraciones_col_ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Configuracion_grp_Usuario As GroupBox
    Friend WithEvents Configuracion_lbl_Host As Label
    Friend WithEvents Configuracion_lbl_TituloHost As Label
    Friend WithEvents Configuracion_lbl_Hora As Label
    Friend WithEvents Configuracion_lbl_tituloIP As Label
    Friend WithEvents Configuracion_lbl_Fecha As Label
    Friend WithEvents Configuracion_lbl_IP As Label
    Friend WithEvents Configuracion_lbl_TituloHora As Label
    Friend WithEvents Configuracion_lbl_TituloFecha As Label
    Friend WithEvents Configuracion_grp_Ingreso As GroupBox
    Friend WithEvents Configuracion_lbl_Usuario As Label
    Friend WithEvents Configuracion_lbl_Tipo As Label
    Friend WithEvents Configuracion_lbl_TituloTipo As Label
    Friend WithEvents Configuracion_lbl_TituloUsuario As Label
    Friend WithEvents Configuracion_grp_Idiomas As GroupBox
    Friend WithEvents Login_btn_Español As Button
    Friend WithEvents Login_btn_Ingles As Button
    Friend WithEvents Configuracion_btn_Aceptar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Configuracion_btn_Defecto As Button
    Friend WithEvents Configuracion_pnl_Configuracion As Panel
End Class
