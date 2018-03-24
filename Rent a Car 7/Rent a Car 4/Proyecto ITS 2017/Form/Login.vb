
Imports System.Configuration
Imports System.Data.Odbc

Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Login_txt_User.Select()

    End Sub

    Private Sub Salir(sender As Object, e As EventArgs) Handles Login_btn_Salir.Click
        Dim Result As DialogResult = MessageBox.Show("¿Seguro que desea salir del login?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then


            Me.Close()

            Me.Close()
        ElseIf Result = DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub Minimizar(sender As Object, e As EventArgs) Handles Login_btn_Minimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub TimerLogin(sender As Object, e As EventArgs) Handles Login_tim_Funciones.Tick

        MayusActive()

        EmptyPassword()

    End Sub
    Private Sub borrar() Handles Login_txt_User.TextChanged
        If Login_txt_User.Text = "" Then
            Login_txt_Pass.Text = ""
        End If

    End Sub


    Private Sub Ingresar(sender As Object, e As EventArgs) Handles Login_btn_Entrar.Click

        SetUsuario(Login_txt_User.Text)

        SetContraseña(Login_txt_Pass.Text)

        Ingresar()

    End Sub

    Private Sub LetrasPermitidas(sender As Object, e As KeyPressEventArgs) Handles Login_txt_Pass.KeyPress, Login_txt_User.KeyPress

        If InStr(1, "0123456789abcdefghijkmnlopqrstuvwxyzABCDEFGHIJKMNROPQRSTUVWXYZ._" & Chr(8), e.KeyChar) = 0 Then

            e.KeyChar = ""

        End If


    End Sub

    Public Sub Ingresar()

        If String.IsNullOrWhiteSpace(Login_txt_User.Text) Then

            MessageBox.Show("Error :  Ingrese usuario.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf String.IsNullOrWhiteSpace(Login_txt_Pass.Text) Then

            MessageBox.Show("Error :  Ingrese contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Connect(GetUsuario, GetContraseña) = False Then

            MessageBox.Show("Error :  Datos incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Connect(GetUsuario, GetContraseña) = True Then

            Principal.Show()

        End If

    End Sub

    Private Sub EmptyPassword()

        If String.IsNullOrWhiteSpace(Login_txt_User.Text) Then

            Login_txt_Pass.Enabled = False

        Else

            Login_txt_Pass.Enabled = True

        End If

    End Sub

    Private Sub MayusActive()

        If My.Computer.Keyboard.CapsLock = True Then

            Login_lbl_Avisos.Visible = True

        Else

            Login_lbl_Avisos.Visible = False

        End If

    End Sub

    Private Sub MostrarContraseña() Handles Login_box_Mostrar.CheckedChanged

        If Login_box_Mostrar.Checked = False Then

            Login_txt_Pass.PasswordChar = "•"

        ElseIf Login_box_Mostrar.Checked = True Then

            Login_txt_Pass.PasswordChar = ""

        End If

    End Sub

    Private Sub Ingles_Click(sender As Object, e As EventArgs) Handles Login_btn_Ingles.Click

        Ingles()

    End Sub

    Private Sub Español_Click(sender As Object, e As EventArgs) Handles Login_btn_Español.Click

        Español()

    End Sub

    Private Sub login_Enter(sender As Object, e As KeyEventArgs) Handles Login_txt_User.KeyDown, Login_txt_Pass.KeyDown
        If (e.KeyValue = Keys.Enter) Then
            Call Sub() Ingresar(Login_btn_Entrar, e)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Login_txt_User.Text = "santiago.toscanini"
        'Login_txt_Pass.Text = "contra123"

        Login_txt_User.Text = "informix"
        Login_txt_Pass.Text = "39781550"
    End Sub
End Class
