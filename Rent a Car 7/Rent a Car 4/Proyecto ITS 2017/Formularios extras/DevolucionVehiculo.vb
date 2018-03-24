Public Class DevolucionVehiculo
    Dim idr As Integer
    Dim idsdev As Integer
    Dim idv As Integer
    Private Sub Login_btn_Salir_Click(sender As Object, e As EventArgs) Handles devolucion_btn_Salir.Click
        Me.Close()
    End Sub
    Dim fecharetiror As String
    Dim DiferenciaDias As Integer
    Private Sub Principal_alquileres_btn_limpiar_Click(sender As Object, e As EventArgs) Handles Devolucion_btn_aceptar.Click
        idr = executescalar("idr", "alquila", "idr", "" + Principal.DataGridView2.CurrentRow.Cells(0).Value.ToString + "")
        idsdev = executescalar("ids", "sucursal", "nombre", "" + Devolucion_cmb_sucursal.SelectedValue + "")
        idv = executescalar("idv", "vehiculo", "matricula", Principal.DataGridView2.CurrentRow.Cells(5).Value.ToString)

        If DiferenciaDias < 0 Then
            MessageBox.Show("No puede devolverlo antes que la fecha de retiro")
            Return
        End If

        Try

            sentenciasNonQuery("update alquila set fech_devolucion_real = today, cant_dias_alquiler = " + DiferenciaDias.ToString + ", precio_final = " + Devolucion_txb_precioR.Text + " ,estado_alquiler = 'Realizado', estatus = 'f',sucursal_dev = " + idsdev.ToString + "where idr =" + idr.ToString + "")

            sentenciasNonQuery("update vehiculo set disponibilidad = 'Libre' where idv = " + idv.ToString + "")

            sentenciasNonQuery("update persona set estado = 'Libre' where tipo_doc ='" + Principal.DataGridView2.CurrentRow.Cells(1).Value.ToString + "' and num_doc = '" + Principal.DataGridView2.CurrentRow.Cells(2).Value.ToString + "' ")

            Principal.llenarGrillaReserva()
            Principal.llenarGrillaCliente()
            Principal.llenarGrillaVehiculo()
            Principal.llenarGrillaVehiculoAlquila()
            MessageBox.Show("exito al finalizar alquiler")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.Message)
        End Try





        Me.Close()

    End Sub

    Dim precio As String

    Public Sub DevolucionVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        idr = executescalar("idr", "alquila", "idr", "" + Principal.DataGridView2.CurrentRow.Cells(0).Value.ToString + "")
        fecharetiror = executescalar("fech_retiro_real", "alquila", "idr", idr)
        precio = executescalar("costoxdia", "categoria", "idc", Principal.DataGridView2.CurrentRow.Cells(9).Value)

        DiferenciaDias = DateDiff(DateInterval.Day, Convert.ToDateTime(fecharetiror), Today.Date)

        If DiferenciaDias = 0 Then
            Devolucion_txb_precioR.Text = precio
            DiferenciaDias = DiferenciaDias + 1
        Else
            Devolucion_txb_precioR.Text = precio * DiferenciaDias
        End If

    End Sub
End Class