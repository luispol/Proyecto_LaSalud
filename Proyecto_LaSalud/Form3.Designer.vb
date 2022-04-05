<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.txtFormaPagoVentas = New System.Windows.Forms.TextBox()
        Me.txtFechaVentas = New System.Windows.Forms.TextBox()
        Me.txtIdventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdVenta = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFromaPago = New System.Windows.Forms.Label()
        Me.lblIdCliente_ventas = New System.Windows.Forms.Label()
        Me.lblIdMedicamentos_ventas = New System.Windows.Forms.Label()
        Me.txtIdClienteVentas = New System.Windows.Forms.TextBox()
        Me.txtIdMedicamentoVentas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFormaPagoVentas
        '
        Me.txtFormaPagoVentas.Location = New System.Drawing.Point(185, 177)
        Me.txtFormaPagoVentas.Name = "txtFormaPagoVentas"
        Me.txtFormaPagoVentas.Size = New System.Drawing.Size(346, 27)
        Me.txtFormaPagoVentas.TabIndex = 7
        '
        'txtFechaVentas
        '
        Me.txtFechaVentas.Location = New System.Drawing.Point(185, 133)
        Me.txtFechaVentas.Name = "txtFechaVentas"
        Me.txtFechaVentas.Size = New System.Drawing.Size(346, 27)
        Me.txtFechaVentas.TabIndex = 6
        '
        'txtIdventa
        '
        Me.txtIdventa.Location = New System.Drawing.Point(185, 83)
        Me.txtIdventa.Name = "txtIdventa"
        Me.txtIdventa.Size = New System.Drawing.Size(346, 27)
        Me.txtIdventa.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(300, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ventas"
        '
        'lblIdVenta
        '
        Me.lblIdVenta.AutoSize = True
        Me.lblIdVenta.Location = New System.Drawing.Point(114, 83)
        Me.lblIdVenta.Name = "lblIdVenta"
        Me.lblIdVenta.Size = New System.Drawing.Size(65, 20)
        Me.lblIdVenta.TabIndex = 8
        Me.lblIdVenta.Text = "Id venta:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(129, 133)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(50, 20)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha:"
        '
        'lblFromaPago
        '
        Me.lblFromaPago.AutoSize = True
        Me.lblFromaPago.Location = New System.Drawing.Point(67, 177)
        Me.lblFromaPago.Name = "lblFromaPago"
        Me.lblFromaPago.Size = New System.Drawing.Size(112, 20)
        Me.lblFromaPago.TabIndex = 10
        Me.lblFromaPago.Text = "Forma de Pago:"
        '
        'lblIdCliente_ventas
        '
        Me.lblIdCliente_ventas.AutoSize = True
        Me.lblIdCliente_ventas.Location = New System.Drawing.Point(106, 223)
        Me.lblIdCliente_ventas.Name = "lblIdCliente_ventas"
        Me.lblIdCliente_ventas.Size = New System.Drawing.Size(73, 20)
        Me.lblIdCliente_ventas.TabIndex = 11
        Me.lblIdCliente_ventas.Text = "Id cliente:"
        '
        'lblIdMedicamentos_ventas
        '
        Me.lblIdMedicamentos_ventas.AutoSize = True
        Me.lblIdMedicamentos_ventas.Location = New System.Drawing.Point(48, 265)
        Me.lblIdMedicamentos_ventas.Name = "lblIdMedicamentos_ventas"
        Me.lblIdMedicamentos_ventas.Size = New System.Drawing.Size(131, 20)
        Me.lblIdMedicamentos_ventas.TabIndex = 12
        Me.lblIdMedicamentos_ventas.Text = "Id Medicamentos: "
        '
        'txtIdClienteVentas
        '
        Me.txtIdClienteVentas.Location = New System.Drawing.Point(185, 223)
        Me.txtIdClienteVentas.Name = "txtIdClienteVentas"
        Me.txtIdClienteVentas.Size = New System.Drawing.Size(346, 27)
        Me.txtIdClienteVentas.TabIndex = 13
        '
        'txtIdMedicamentoVentas
        '
        Me.txtIdMedicamentoVentas.Location = New System.Drawing.Point(185, 265)
        Me.txtIdMedicamentoVentas.Name = "txtIdMedicamentoVentas"
        Me.txtIdMedicamentoVentas.Size = New System.Drawing.Size(346, 27)
        Me.txtIdMedicamentoVentas.TabIndex = 14
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtIdMedicamentoVentas)
        Me.Controls.Add(Me.txtIdClienteVentas)
        Me.Controls.Add(Me.lblIdMedicamentos_ventas)
        Me.Controls.Add(Me.lblIdCliente_ventas)
        Me.Controls.Add(Me.lblFromaPago)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblIdVenta)
        Me.Controls.Add(Me.txtFormaPagoVentas)
        Me.Controls.Add(Me.txtFechaVentas)
        Me.Controls.Add(Me.txtIdventa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFormaPagoVentas As TextBox
    Friend WithEvents txtFechaVentas As TextBox
    Friend WithEvents txtIdventa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIdVenta As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblFromaPago As Label
    Friend WithEvents lblIdCliente_ventas As Label
    Friend WithEvents lblIdMedicamentos_ventas As Label
    Friend WithEvents txtIdClienteVentas As TextBox
    Friend WithEvents txtIdMedicamentoVentas As TextBox
End Class
