<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMedicamentos
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
        Me.txtTipoMedicamento = New System.Windows.Forms.TextBox()
        Me.txtNombreMedicamentos = New System.Windows.Forms.TextBox()
        Me.txtIdMedicamentos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdMedicamentos = New System.Windows.Forms.Label()
        Me.lblNombreMedicamentos = New System.Windows.Forms.Label()
        Me.lblTipoMedicamento = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTipoMedicamento
        '
        Me.txtTipoMedicamento.Location = New System.Drawing.Point(191, 195)
        Me.txtTipoMedicamento.Name = "txtTipoMedicamento"
        Me.txtTipoMedicamento.Size = New System.Drawing.Size(346, 27)
        Me.txtTipoMedicamento.TabIndex = 7
        '
        'txtNombreMedicamentos
        '
        Me.txtNombreMedicamentos.Location = New System.Drawing.Point(191, 147)
        Me.txtNombreMedicamentos.Name = "txtNombreMedicamentos"
        Me.txtNombreMedicamentos.Size = New System.Drawing.Size(346, 27)
        Me.txtNombreMedicamentos.TabIndex = 6
        '
        'txtIdMedicamentos
        '
        Me.txtIdMedicamentos.Location = New System.Drawing.Point(191, 103)
        Me.txtIdMedicamentos.Name = "txtIdMedicamentos"
        Me.txtIdMedicamentos.Size = New System.Drawing.Size(346, 27)
        Me.txtIdMedicamentos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(217, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Medicamentos"
        '
        'lblIdMedicamentos
        '
        Me.lblIdMedicamentos.AutoSize = True
        Me.lblIdMedicamentos.Location = New System.Drawing.Point(147, 103)
        Me.lblIdMedicamentos.Name = "lblIdMedicamentos"
        Me.lblIdMedicamentos.Size = New System.Drawing.Size(25, 20)
        Me.lblIdMedicamentos.TabIndex = 8
        Me.lblIdMedicamentos.Text = "Id:"
        '
        'lblNombreMedicamentos
        '
        Me.lblNombreMedicamentos.AutoSize = True
        Me.lblNombreMedicamentos.Location = New System.Drawing.Point(105, 147)
        Me.lblNombreMedicamentos.Name = "lblNombreMedicamentos"
        Me.lblNombreMedicamentos.Size = New System.Drawing.Size(67, 20)
        Me.lblNombreMedicamentos.TabIndex = 9
        Me.lblNombreMedicamentos.Text = "Nombre:"
        '
        'lblTipoMedicamento
        '
        Me.lblTipoMedicamento.AutoSize = True
        Me.lblTipoMedicamento.Location = New System.Drawing.Point(34, 195)
        Me.lblTipoMedicamento.Name = "lblTipoMedicamento"
        Me.lblTipoMedicamento.Size = New System.Drawing.Size(138, 20)
        Me.lblTipoMedicamento.TabIndex = 10
        Me.lblTipoMedicamento.Text = "Tipo Medicamento:"
        '
        'FormMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 627)
        Me.Controls.Add(Me.lblTipoMedicamento)
        Me.Controls.Add(Me.lblNombreMedicamentos)
        Me.Controls.Add(Me.lblIdMedicamentos)
        Me.Controls.Add(Me.txtTipoMedicamento)
        Me.Controls.Add(Me.txtNombreMedicamentos)
        Me.Controls.Add(Me.txtIdMedicamentos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMedicamentos"
        Me.Text = "Medicamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTipoMedicamento As TextBox
    Friend WithEvents txtNombreMedicamentos As TextBox
    Friend WithEvents txtIdMedicamentos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIdMedicamentos As Label
    Friend WithEvents lblNombreMedicamentos As Label
    Friend WithEvents lblTipoMedicamento As Label
End Class
