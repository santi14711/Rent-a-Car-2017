Imports System.ComponentModel

Public Class AgregarModelo
    Dim marcanueva As Boolean
    Dim categorianueva As Boolean
    Dim Cierre As Boolean
    Private Sub hola() Handles MyBase.Load
        AgregarModelo_txb_categoria.Location = New Point(148, 30)
        AgregarModelo_txb_Marca.Location = New Point(147, 64)
        Principal.llenarcategoria(AgregarModelo_cmb_categoria)
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        If Cierre = False Then
            e.Cancel = True

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AgregarModelo_btn_MostrarCategoria.Click
        Cierre = False

        Select Case AgregarModelo_btn_MostrarCategoria.Text
            Case "+"
                AgregarModelo_btn_MostrarCategoria.Text = "-"
                AgregarModelo_lbl_Letra.Visible = True
                AgregarModelo_lbl_Precio.Visible = True
                AgregarModelo_txb_Precio.Visible = True
                AgregarModelo_txb_categoria.Visible = True
                AgregarModelo_txb_Precio.Clear()
                AgregarModelo_txb_categoria.Clear()
                categorianueva = True
            Case "-"
                AgregarModelo_btn_MostrarCategoria.Text = "+"
                AgregarModelo_lbl_Letra.Visible = False
                AgregarModelo_lbl_Precio.Visible = False
                AgregarModelo_txb_Precio.Visible = False
                AgregarModelo_txb_categoria.Visible = False
                categorianueva = False
        End Select
    End Sub

    Private Sub devolucion_btn_Salir_Click(sender As Object, e As EventArgs) Handles AgregarModelo_btn_Salir.Click
        Cierre = True

        Me.Close()
    End Sub

    Private Sub Devolucion_btn_aceptar_Click(sender As Object, e As EventArgs) Handles AgregarModelo_btn_Aceptar.Click
        Cierre = True
        If AgregarModelo_txb_Modelo.Text = "" Then
            MessageBox.Show("Debe de ingresar un modelo")
            Return
        End If

#Region "marca nueva, categoria nueva"
        If marcanueva = True And categorianueva = True Then ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If AgregarModelo_txb_categoria.Text = "" Then
                MessageBox.Show("Debe de ingresar una categoria")
                Return
            ElseIf AgregarModelo_txb_Precio.Text = "" Then
                MessageBox.Show("Debe de ingresar un precio para esa categoria")
                Return
            ElseIf AgregarModelo_txb_Marca.Text = "" Then
                MessageBox.Show("Debe de ingresar una marca")
                Return
            End If
            Execute("select * from categoria where letra = '" + AgregarModelo_txb_categoria.Text + "'")
            'buscamos que la categoria no este ingresada
            If dt.Rows.Count > 0 Then
                MessageBox.Show("categoria ya ingresada")
                Return
            End If

            Execute("select * from marca where nombre_marca = '" + AgregarModelo_txb_Marca.Text + "' ")
            ' buscamos que la marca no este ingresada
            If dt.Rows.Count > 0 Then
                MessageBox.Show("marca ya ingresada")
                Return
            End If



            'insertamos categoria
            Try
                sentenciasNonQuery("insert into categoria values(0,'" + AgregarModelo_txb_categoria.Text + "'," + AgregarModelo_txb_Precio.Text + ")")
            Catch ex As Exception
                MsgBox("error categoriaaaa" + ex.Message)
            End Try
            'conseguimos la id de esa categoria
            Dim idc As String = executescalar("idc", "categoria", "letra", AgregarModelo_txb_categoria.Text)
            'insertamos la marca con la categoria
            sentenciasNonQuery("insert into marca values (0,'" + AgregarModelo_txb_Marca.Text + "','" + AgregarModelo_txb_Modelo.Text + "'," + idc + " )")
            MessageBox.Show("Agregado correctamente")

#End Region

#Region "combos cargados"
        ElseIf marcanueva = False And categorianueva = False Then ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Execute("Select * from marca where nombre_marca = '" + AgregarModelo_cmb_marca.SelectedValue + "' and nombre_modelo = '" + AgregarModelo_txb_Modelo.Text + "'")
            If dt.Rows.Count > 0 Then
                MsgBox("Modelo ya existente para esa marca")
                Return
            End If
            'conseguimos la id de esa categoria
            Dim idc As String = executescalar("idc", "categoria", "letra", AgregarModelo_cmb_categoria.SelectedValue)
            'insertamos la marca con la categoria
            sentenciasNonQuery("insert into marca values (0,'" + AgregarModelo_cmb_marca.SelectedValue + "','" + AgregarModelo_txb_Modelo.Text + "'," + idc + " )")
            MessageBox.Show("Agregado correctamente")
#End Region

#Region "categoria nueva"

        ElseIf marcanueva = False And categorianueva = True Then ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If AgregarModelo_txb_categoria.Text = "" Then
                MessageBox.Show("debe de ingresar una categoria")
                Return
            ElseIf AgregarModelo_txb_Precio.Text = "" Then
                MessageBox.Show("Debe de ingresar un precio para esa categoria")
                Return
            End If
            Execute("select * from categoria where letra = '" + AgregarModelo_txb_categoria.Text + "'")
            'buscamos que la categoria no este ingresada
            If dt.Rows.Count > 0 Then
                MessageBox.Show("categoria ya ingresada, pruebe otra")
                Return
            End If
            'insertamos categoria

            Try
                sentenciasNonQuery("insert into categoria values(0,'" + AgregarModelo_txb_categoria.Text + "'," + AgregarModelo_txb_Precio.Text + ")")
            Catch ex As Exception
                MsgBox("error categoriaaaa" + ex.Message)
            End Try
            'conseguimos la id de esa categoria
            Dim idc As String = executescalar("idc", "categoria", "letra", AgregarModelo_txb_categoria.Text)
            'insertamos la marca con la categoria
            sentenciasNonQuery("insert into marca values (0,'" + AgregarModelo_cmb_marca.SelectedValue + "','" + AgregarModelo_txb_Modelo.Text + "'," + idc + " )")
            MessageBox.Show("Agregado correctamente")
#End Region

#Region "marca nueva"
        ElseIf marcanueva = True And categorianueva = False Then  ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If AgregarModelo_txb_Marca.Text = "" Then
                MessageBox.Show("Debe de ingresar una marca")
                Return
            End If
            Execute("select * from marca where nombre_marca = '" + AgregarModelo_txb_Marca.Text + "' ")
            'buscamos que la marca no este ingresada
            If dt.Rows.Count > 0 Then
                MessageBox.Show("marca ya ingresada")
                Return
            End If
            'conseguimos id de esa categoria
            Dim idc As String = executescalar("idc", "categoria", "letra", AgregarModelo_cmb_categoria.SelectedValue)

            sentenciasNonQuery("insert into marca values (0,'" + AgregarModelo_txb_Marca.Text + "','" + AgregarModelo_txb_Modelo.Text + "'," + idc + ")")
            MessageBox.Show("Agregado correctamente")

        End If
#End Region

        Principal.llenarcategoria(Principal.Principal_Reserva_cmb_categoria)
        Principal.llenarcategoria(AgregarModelo_cmb_categoria)
        Principal.llenarmarca(Principal.Principal_Vehiculo_cmb_Marca)
        Principal.llenarmarca(AgregarModelo_cmb_marca)
        'Select Case Button2.Visible
        '    Case True


        '    Case False
        'End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AgregarModelo_btn_MostrarMarca.Click
        Cierre = False
        Select Case AgregarModelo_btn_MostrarMarca.Text
            Case "+"
                AgregarModelo_btn_MostrarMarca.Text = "-"
                AgregarModelo_txb_Marca.Visible = True
                AgregarModelo_txb_Marca.Clear()
                marcanueva = True
            Case "-"
                AgregarModelo_btn_MostrarMarca.Text = "+"
                AgregarModelo_txb_Marca.Visible = False
                marcanueva = False
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AgregarModelo_cmb_categoria.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AgregarModelo_txb_categoria.TextChanged
        AgregarModelo_txb_categoria.Text = UCase(AgregarModelo_txb_categoria.Text)
        AgregarModelo_txb_categoria.SelectionStart = AgregarModelo_txb_categoria.TextLength + 1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles AgregarModelo_txb_Precio.TextChanged

    End Sub

End Class