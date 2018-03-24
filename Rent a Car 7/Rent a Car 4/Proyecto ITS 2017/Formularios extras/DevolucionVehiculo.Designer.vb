<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevolucionVehiculo
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
        Me.Devolucion_pnl_Devolucion = New System.Windows.Forms.Panel()
        Me.Devolucion_cmb_sucursal = New System.Windows.Forms.ComboBox()
        Me.Devolucion_lbl_sucursal = New System.Windows.Forms.Label()
        Me.Devolucion_txb_precioR = New System.Windows.Forms.TextBox()
        Me.Devolucion_lbl_precioR = New System.Windows.Forms.Label()
        Me.Devolucion_btn_aceptar = New System.Windows.Forms.Button()
        Me.devolucion_btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Devolucion_pnl_Devolucion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Devolucion_pnl_Devolucion
        '
        Me.Devolucion_pnl_Devolucion.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Devolucion_pnl_Devolucion.Controls.Add(Me.Devolucion_cmb_sucursal)
        Me.Devolucion_pnl_Devolucion.Controls.Add(Me.Devolucion_lbl_sucursal)
        Me.Devolucion_pnl_Devolucion.Controls.Add(Me.Devolucion_txb_precioR)
        Me.Devolucion_pnl_Devolucion.Controls.Add(Me.Devolucion_lbl_precioR)
        Me.Devolucion_pnl_Devolucion.Controls.Add(Me.Devolucion_btn_aceptar)
        Me.Devolucion_pnl_Devolucion.Location = New System.Drawing.Point(5, 49)
        Me.Devolucion_pnl_Devolucion.Name = "Devolucion_pnl_Devolucion"
        Me.Devolucion_pnl_Devolucion.Size = New System.Drawing.Size(457, 215)
        Me.Devolucion_pnl_Devolucion.TabIndex = 0
        '
        'Devolucion_cmb_sucursal
        '
        Me.Devolucion_cmb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Devolucion_cmb_sucursal.FormattingEnabled = True
        Me.Devolucion_cmb_sucursal.Location = New System.Drawing.Point(224, 74)
        Me.Devolucion_cmb_sucursal.Name = "Devolucion_cmb_sucursal"
        Me.Devolucion_cmb_sucursal.Size = New System.Drawing.Size(120, 21)
        Me.Devolucion_cmb_sucursal.TabIndex = 136
        '
        'Devolucion_lbl_sucursal
        '
        Me.Devolucion_lbl_sucursal.AutoSize = True
        Me.Devolucion_lbl_sucursal.BackColor = System.Drawing.Color.Transparent
        Me.Devolucion_lbl_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Devolucion_lbl_sucursal.ForeColor = System.Drawing.SystemColors.Control
        Me.Devolucion_lbl_sucursal.Location = New System.Drawing.Point(62, 71)
        Me.Devolucion_lbl_sucursal.Name = "Devolucion_lbl_sucursal"
        Me.Devolucion_lbl_sucursal.Size = New System.Drawing.Size(135, 16)
        Me.Devolucion_lbl_sucursal.TabIndex = 133
        Me.Devolucion_lbl_sucursal.Text = "Sucursal devolución :"
        '
        'Devolucion_txb_precioR
        '
        Me.Devolucion_txb_precioR.Enabled = False
        Me.Devolucion_txb_precioR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Devolucion_txb_precioR.Location = New System.Drawing.Point(224, 110)
        Me.Devolucion_txb_precioR.Name = "Devolucion_txb_precioR"
        Me.Devolucion_txb_precioR.Size = New System.Drawing.Size(108, 22)
        Me.Devolucion_txb_precioR.TabIndex = 130
        '
        'Devolucion_lbl_precioR
        '
        Me.Devolucion_lbl_precioR.AutoSize = True
        Me.Devolucion_lbl_precioR.BackColor = System.Drawing.Color.Transparent
        Me.Devolucion_lbl_precioR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Devolucion_lbl_precioR.ForeColor = System.Drawing.SystemColors.Control
        Me.Devolucion_lbl_precioR.Location = New System.Drawing.Point(90, 112)
        Me.Devolucion_lbl_precioR.Name = "Devolucion_lbl_precioR"
        Me.Devolucion_lbl_precioR.Size = New System.Drawing.Size(79, 16)
        Me.Devolucion_lbl_precioR.TabIndex = 129
        Me.Devolucion_lbl_precioR.Text = "Precio real :"
        '
        'Devolucion_btn_aceptar
        '
        Me.Devolucion_btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Devolucion_btn_aceptar.BackColor = System.Drawing.Color.Black
        Me.Devolucion_btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Devolucion_btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Devolucion_btn_aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Devolucion_btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Devolucion_btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Devolucion_btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Devolucion_btn_aceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Devolucion_btn_aceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Devolucion_btn_aceptar.Location = New System.Drawing.Point(382, 176)
        Me.Devolucion_btn_aceptar.Name = "Devolucion_btn_aceptar"
        Me.Devolucion_btn_aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Devolucion_btn_aceptar.Size = New System.Drawing.Size(67, 33)
        Me.Devolucion_btn_aceptar.TabIndex = 128
        Me.Devolucion_btn_aceptar.Text = "Aceptar"
        Me.Devolucion_btn_aceptar.UseVisualStyleBackColor = False
        '
        'devolucion_btn_Salir
        '
        Me.devolucion_btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.devolucion_btn_Salir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.devolucion_btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.devolucion_btn_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.devolucion_btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.devolucion_btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.devolucion_btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.devolucion_btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devolucion_btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.devolucion_btn_Salir.Location = New System.Drawing.Point(411, 2)
        Me.devolucion_btn_Salir.Name = "devolucion_btn_Salir"
        Me.devolucion_btn_Salir.Size = New System.Drawing.Size(51, 46)
        Me.devolucion_btn_Salir.TabIndex = 137
        Me.devolucion_btn_Salir.Text = " X"
        Me.devolucion_btn_Salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Devolución de vehiculo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DevolucionVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(466, 270)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.devolucion_btn_Salir)
        Me.Controls.Add(Me.Devolucion_pnl_Devolucion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DevolucionVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DevolucionVehiculo"
        Me.Devolucion_pnl_Devolucion.ResumeLayout(False)
        Me.Devolucion_pnl_Devolucion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Devolucion_pnl_Devolucion As Panel
    Friend WithEvents Devolucion_cmb_sucursal As ComboBox
    Friend WithEvents Devolucion_lbl_sucursal As Label
    Friend WithEvents Devolucion_txb_precioR As TextBox
    Friend WithEvents Devolucion_lbl_precioR As Label
    Friend WithEvents Devolucion_btn_aceptar As Button
    Friend WithEvents devolucion_btn_Salir As Button
    Friend WithEvents Label1 As Label
End Class
