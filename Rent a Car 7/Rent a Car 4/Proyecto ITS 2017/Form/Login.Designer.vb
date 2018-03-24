<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Login_lbl_Login = New System.Windows.Forms.Label()
        Me.Login_btn_Minimizar = New System.Windows.Forms.Button()
        Me.Login_btn_Salir = New System.Windows.Forms.Button()
        Me.Login_tim_Funciones = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Login_btn_Entrar = New System.Windows.Forms.Button()
        Me.Login_pan_PanelLogin = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Login_btn_Español = New System.Windows.Forms.Button()
        Me.Login_btn_Ingles = New System.Windows.Forms.Button()
        Me.Login_box_Mostrar = New System.Windows.Forms.CheckBox()
        Me.Login_img_Candado = New System.Windows.Forms.PictureBox()
        Me.Login_lbl_Avisos = New System.Windows.Forms.Label()
        Me.Login_lbl_Pass = New System.Windows.Forms.Label()
        Me.Login_lbl_User = New System.Windows.Forms.Label()
        Me.Login_txt_Pass = New System.Windows.Forms.TextBox()
        Me.Login_txt_User = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login_pan_PanelLogin.SuspendLayout()
        CType(Me.Login_img_Candado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login_lbl_Login
        '
        Me.Login_lbl_Login.AutoSize = True
        Me.Login_lbl_Login.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_lbl_Login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Login_lbl_Login.Location = New System.Drawing.Point(45, 13)
        Me.Login_lbl_Login.Name = "Login_lbl_Login"
        Me.Login_lbl_Login.Size = New System.Drawing.Size(88, 17)
        Me.Login_lbl_Login.TabIndex = 64
        Me.Login_lbl_Login.Text = "Login E.C.M."
        '
        'Login_btn_Minimizar
        '
        Me.Login_btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_btn_Minimizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Login_btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Login_btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Login_btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_btn_Minimizar.ForeColor = System.Drawing.SystemColors.Control
        Me.Login_btn_Minimizar.Location = New System.Drawing.Point(378, -2)
        Me.Login_btn_Minimizar.Name = "Login_btn_Minimizar"
        Me.Login_btn_Minimizar.Size = New System.Drawing.Size(50, 46)
        Me.Login_btn_Minimizar.TabIndex = 66
        Me.Login_btn_Minimizar.Text = "—"
        Me.Login_btn_Minimizar.UseVisualStyleBackColor = True
        '
        'Login_btn_Salir
        '
        Me.Login_btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_btn_Salir.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Login_btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Login_btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Login_btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Login_btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Login_btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_btn_Salir.ForeColor = System.Drawing.SystemColors.Control
        Me.Login_btn_Salir.Location = New System.Drawing.Point(427, -2)
        Me.Login_btn_Salir.Name = "Login_btn_Salir"
        Me.Login_btn_Salir.Size = New System.Drawing.Size(50, 46)
        Me.Login_btn_Salir.TabIndex = 65
        Me.Login_btn_Salir.Text = " X"
        Me.Login_btn_Salir.UseVisualStyleBackColor = False
        '
        'Login_tim_Funciones
        '
        Me.Login_tim_Funciones.Enabled = True
        '
        'Login_btn_Entrar
        '
        Me.Login_btn_Entrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_btn_Entrar.BackColor = System.Drawing.Color.Black
        Me.Login_btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_btn_Entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Login_btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Login_btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Login_btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Login_btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_btn_Entrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_btn_Entrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Login_btn_Entrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Login_btn_Entrar.Location = New System.Drawing.Point(284, 104)
        Me.Login_btn_Entrar.Name = "Login_btn_Entrar"
        Me.Login_btn_Entrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Login_btn_Entrar.Size = New System.Drawing.Size(138, 47)
        Me.Login_btn_Entrar.TabIndex = 61
        Me.Login_btn_Entrar.Text = "Ingresar"
        Me.Login_btn_Entrar.UseVisualStyleBackColor = False
        '
        'Login_pan_PanelLogin
        '
        Me.Login_pan_PanelLogin.BackgroundImage = Global.Proyecto_ITS_2017.My.Resources.Resources.thumb2_lines_stripes_geometric_figures_lollipop_geometry
        Me.Login_pan_PanelLogin.Controls.Add(Me.Button1)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_btn_Español)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_btn_Ingles)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_box_Mostrar)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_img_Candado)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_lbl_Avisos)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_lbl_Pass)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_lbl_User)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_btn_Entrar)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_txt_Pass)
        Me.Login_pan_PanelLogin.Controls.Add(Me.Login_txt_User)
        Me.Login_pan_PanelLogin.Location = New System.Drawing.Point(-3, 41)
        Me.Login_pan_PanelLogin.Name = "Login_pan_PanelLogin"
        Me.Login_pan_PanelLogin.Size = New System.Drawing.Size(480, 166)
        Me.Login_pan_PanelLogin.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login_btn_Español
        '
        Me.Login_btn_Español.BackgroundImage = Global.Proyecto_ITS_2017.My.Resources.Resources.es
        Me.Login_btn_Español.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Login_btn_Español.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_btn_Español.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Login_btn_Español.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login_btn_Español.Location = New System.Drawing.Point(183, 114)
        Me.Login_btn_Español.Name = "Login_btn_Español"
        Me.Login_btn_Español.Size = New System.Drawing.Size(37, 26)
        Me.Login_btn_Español.TabIndex = 3
        Me.Login_btn_Español.UseVisualStyleBackColor = True
        '
        'Login_btn_Ingles
        '
        Me.Login_btn_Ingles.BackColor = System.Drawing.Color.Transparent
        Me.Login_btn_Ingles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Login_btn_Ingles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_btn_Ingles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Login_btn_Ingles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login_btn_Ingles.Image = Global.Proyecto_ITS_2017.My.Resources.Resources.download
        Me.Login_btn_Ingles.Location = New System.Drawing.Point(223, 114)
        Me.Login_btn_Ingles.Name = "Login_btn_Ingles"
        Me.Login_btn_Ingles.Size = New System.Drawing.Size(37, 26)
        Me.Login_btn_Ingles.TabIndex = 4
        Me.Login_btn_Ingles.UseVisualStyleBackColor = False
        '
        'Login_box_Mostrar
        '
        Me.Login_box_Mostrar.AutoSize = True
        Me.Login_box_Mostrar.BackColor = System.Drawing.Color.Transparent
        Me.Login_box_Mostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_box_Mostrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_box_Mostrar.Location = New System.Drawing.Point(283, 84)
        Me.Login_box_Mostrar.Name = "Login_box_Mostrar"
        Me.Login_box_Mostrar.Size = New System.Drawing.Size(151, 21)
        Me.Login_box_Mostrar.TabIndex = 30
        Me.Login_box_Mostrar.Text = "Mostrar contraseña"
        Me.Login_box_Mostrar.UseVisualStyleBackColor = False
        '
        'Login_img_Candado
        '
        Me.Login_img_Candado.BackColor = System.Drawing.Color.Transparent
        Me.Login_img_Candado.BackgroundImage = Global.Proyecto_ITS_2017.My.Resources.Resources._1213
        Me.Login_img_Candado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Login_img_Candado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Login_img_Candado.Location = New System.Drawing.Point(29, 18)
        Me.Login_img_Candado.Name = "Login_img_Candado"
        Me.Login_img_Candado.Size = New System.Drawing.Size(127, 125)
        Me.Login_img_Candado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Login_img_Candado.TabIndex = 71
        Me.Login_img_Candado.TabStop = False
        '
        'Login_lbl_Avisos
        '
        Me.Login_lbl_Avisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_lbl_Avisos.AutoSize = True
        Me.Login_lbl_Avisos.BackColor = System.Drawing.Color.Transparent
        Me.Login_lbl_Avisos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_lbl_Avisos.Location = New System.Drawing.Point(287, 8)
        Me.Login_lbl_Avisos.Name = "Login_lbl_Avisos"
        Me.Login_lbl_Avisos.Size = New System.Drawing.Size(143, 17)
        Me.Login_lbl_Avisos.TabIndex = 70
        Me.Login_lbl_Avisos.Text = "Bloq Mayús Activado"
        '
        'Login_lbl_Pass
        '
        Me.Login_lbl_Pass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Login_lbl_Pass.AutoSize = True
        Me.Login_lbl_Pass.BackColor = System.Drawing.Color.Transparent
        Me.Login_lbl_Pass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_lbl_Pass.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Login_lbl_Pass.Location = New System.Drawing.Point(180, 63)
        Me.Login_lbl_Pass.Name = "Login_lbl_Pass"
        Me.Login_lbl_Pass.Size = New System.Drawing.Size(88, 17)
        Me.Login_lbl_Pass.TabIndex = 69
        Me.Login_lbl_Pass.Text = "Contraseña:"
        '
        'Login_lbl_User
        '
        Me.Login_lbl_User.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Login_lbl_User.AutoSize = True
        Me.Login_lbl_User.BackColor = System.Drawing.Color.Transparent
        Me.Login_lbl_User.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_lbl_User.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Login_lbl_User.Location = New System.Drawing.Point(180, 32)
        Me.Login_lbl_User.Name = "Login_lbl_User"
        Me.Login_lbl_User.Size = New System.Drawing.Size(58, 17)
        Me.Login_lbl_User.TabIndex = 68
        Me.Login_lbl_User.Text = "Usuario:"
        '
        'Login_txt_Pass
        '
        Me.Login_txt_Pass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_txt_Pass.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Login_txt_Pass.Location = New System.Drawing.Point(276, 60)
        Me.Login_txt_Pass.MaxLength = 30
        Me.Login_txt_Pass.Name = "Login_txt_Pass"
        Me.Login_txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Login_txt_Pass.Size = New System.Drawing.Size(156, 22)
        Me.Login_txt_Pass.TabIndex = 1
        '
        'Login_txt_User
        '
        Me.Login_txt_User.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_txt_User.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Login_txt_User.Location = New System.Drawing.Point(276, 29)
        Me.Login_txt_User.MaxLength = 30
        Me.Login_txt_User.Name = "Login_txt_User"
        Me.Login_txt_User.Size = New System.Drawing.Size(156, 22)
        Me.Login_txt_User.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_ITS_2017.My.Resources.Resources.User_login_256
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.Login_btn_Entrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.Login_btn_Salir
        Me.ClientSize = New System.Drawing.Size(475, 204)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Login_pan_PanelLogin)
        Me.Controls.Add(Me.Login_btn_Minimizar)
        Me.Controls.Add(Me.Login_btn_Salir)
        Me.Controls.Add(Me.Login_lbl_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Opacity = 0.96R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Login_pan_PanelLogin.ResumeLayout(False)
        Me.Login_pan_PanelLogin.PerformLayout()
        CType(Me.Login_img_Candado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_lbl_Login As Label
    Friend WithEvents Login_btn_Minimizar As Button
    Friend WithEvents Login_btn_Salir As Button
    Friend WithEvents Login_pan_PanelLogin As Panel
    Friend WithEvents Login_img_Candado As PictureBox
    Friend WithEvents Login_lbl_Avisos As Label
    Friend WithEvents Login_lbl_Pass As Label
    Friend WithEvents Login_lbl_User As Label
    Friend WithEvents Login_btn_Entrar As Button
    Friend WithEvents Login_txt_Pass As TextBox
    Friend WithEvents Login_tim_Funciones As Timer
    Friend WithEvents Login_box_Mostrar As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Login_btn_Ingles As Button
    Friend WithEvents Login_btn_Español As Button
    Public WithEvents Login_txt_User As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
