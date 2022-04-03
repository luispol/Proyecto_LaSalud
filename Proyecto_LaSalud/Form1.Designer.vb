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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtDUI = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.txtNombreClientes = New System.Windows.Forms.TextBox()
        Me.lblApellidosClientes = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(128, 75)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(346, 27)
        Me.txtId.TabIndex = 1
        '
        'txtDUI
        '
        Me.txtDUI.Location = New System.Drawing.Point(128, 217)
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(346, 27)
        Me.txtDUI.TabIndex = 2
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(88, 75)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(25, 20)
        Me.lblIdCliente.TabIndex = 4
        Me.lblIdCliente.Text = "Id:"
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(76, 217)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(37, 20)
        Me.lblDUI.TabIndex = 5
        Me.lblDUI.Text = "DUI:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(56, 267)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(57, 20)
        Me.lblCorreo.TabIndex = 7
        Me.lblCorreo.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(128, 264)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(346, 27)
        Me.txtCorreo.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(43, 313)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(70, 20)
        Me.lblTelefono.TabIndex = 9
        Me.lblTelefono.Text = "Telefono:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 27)
        Me.TextBox1.TabIndex = 10
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(40, 122)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(73, 20)
        Me.lblNombreCliente.TabIndex = 11
        Me.lblNombreCliente.Text = "Nombres:"
        '
        'txtNombreClientes
        '
        Me.txtNombreClientes.Location = New System.Drawing.Point(128, 122)
        Me.txtNombreClientes.Name = "txtNombreClientes"
        Me.txtNombreClientes.Size = New System.Drawing.Size(346, 27)
        Me.txtNombreClientes.TabIndex = 12
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Location = New System.Drawing.Point(38, 172)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(75, 20)
        Me.lblApellidosClientes.TabIndex = 13
        Me.lblApellidosClientes.Text = "Apellidos:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 172)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(346, 27)
        Me.TextBox2.TabIndex = 14
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblApellidosClientes)
        Me.Controls.Add(Me.txtNombreClientes)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.lblIdCliente)
        Me.Controls.Add(Me.txtDUI)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormClientes"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtDUI As TextBox
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents lblDUI As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreClientes As TextBox
    Friend WithEvents lblApellidosClientes As Label
    Friend WithEvents TextBox2 As TextBox
End Class
