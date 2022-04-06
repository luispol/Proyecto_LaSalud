<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdClientes = New System.Windows.Forms.TextBox()
        Me.txtDUIClientes = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreoClientes = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefonoClientes = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreClientes = New System.Windows.Forms.TextBox()
        Me.lblApellidosClientes = New System.Windows.Forms.Label()
        Me.txtApellidosClientes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(222, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'txtIdClientes
        '
        Me.txtIdClientes.Location = New System.Drawing.Point(109, 59)
        Me.txtIdClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdClientes.Name = "txtIdClientes"
        Me.txtIdClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtIdClientes.TabIndex = 1
        '
        'txtDUIClientes
        '
        Me.txtDUIClientes.Location = New System.Drawing.Point(109, 163)
        Me.txtDUIClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDUIClientes.Name = "txtDUIClientes"
        Me.txtDUIClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtDUIClientes.TabIndex = 2
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(70, 59)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(20, 15)
        Me.lblIdCliente.TabIndex = 4
        Me.lblIdCliente.Text = "Id:"
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(59, 163)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(29, 15)
        Me.lblDUI.TabIndex = 5
        Me.lblDUI.Text = "DUI:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(42, 202)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(46, 15)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo:"
        '
        'txtCorreoClientes
        '
        Me.txtCorreoClientes.Location = New System.Drawing.Point(109, 200)
        Me.txtCorreoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreoClientes.Name = "txtCorreoClientes"
        Me.txtCorreoClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtCorreoClientes.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(31, 240)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefonoClientes
        '
        Me.txtTelefonoClientes.Location = New System.Drawing.Point(109, 240)
        Me.txtTelefonoClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTelefonoClientes.Name = "txtTelefonoClientes"
        Me.txtTelefonoClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtTelefonoClientes.TabIndex = 10
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(28, 94)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(59, 15)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombres:"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Location = New System.Drawing.Point(109, 94)
        Me.txtNombreClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Location = New System.Drawing.Point(26, 129)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(59, 15)
        Me.lblApellidosClientes.TabIndex = 13
        Me.lblApellidosClientes.Text = "Apellidos:"
        '
        'txtApellidosClientes
        '
        Me.txtApellidosClientes.Location = New System.Drawing.Point(109, 129)
        Me.txtApellidosClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellidosClientes.Name = "txtApellidosClientes"
        Me.txtApellidosClientes.Size = New System.Drawing.Size(303, 23)
        Me.txtApellidosClientes.TabIndex = 14
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 470)
        Me.Controls.Add(Me.txtApellidosClientes)
        Me.Controls.Add(Me.lblApellidosClientes)
        Me.Controls.Add(Me.txtNombreClientes)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtTelefonoClientes)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtCorreoClientes)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.txtDUIClientes)
        Me.Controls.Add(Me.txtIdClientes)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormClientes"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdClientes As TextBox
    Friend WithEvents txtDUIClientes As TextBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents lblDUI As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreoClientes As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefonoClientes As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreClientes As TextBox
    Friend WithEvents lblApellidosClientes As Label
    Friend WithEvents txtApellidosClientes As TextBox
End Class
