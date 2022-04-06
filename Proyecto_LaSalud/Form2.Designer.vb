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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtTipoMedicamento
        '
        Me.txtTipoMedicamento.Location = New System.Drawing.Point(381, 273)
        Me.txtTipoMedicamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTipoMedicamento.Name = "txtTipoMedicamento"
        Me.txtTipoMedicamento.Size = New System.Drawing.Size(303, 23)
        Me.txtTipoMedicamento.TabIndex = 7
        '
        'txtNombreMedicamentos
        '
        Me.txtNombreMedicamentos.Location = New System.Drawing.Point(381, 237)
        Me.txtNombreMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreMedicamentos.Name = "txtNombreMedicamentos"
        Me.txtNombreMedicamentos.Size = New System.Drawing.Size(303, 23)
        Me.txtNombreMedicamentos.TabIndex = 6
        '
        'txtIdMedicamentos
        '
        Me.txtIdMedicamentos.Location = New System.Drawing.Point(381, 204)
        Me.txtIdMedicamentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdMedicamentos.Name = "txtIdMedicamentos"
        Me.txtIdMedicamentos.Size = New System.Drawing.Size(303, 23)
        Me.txtIdMedicamentos.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(404, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Medicamentos"
        '
        'lblIdMedicamentos
        '
        Me.lblIdMedicamentos.AutoSize = True
        Me.lblIdMedicamentos.Location = New System.Drawing.Point(343, 204)
        Me.lblIdMedicamentos.Name = "lblIdMedicamentos"
        Me.lblIdMedicamentos.Size = New System.Drawing.Size(20, 15)
        Me.lblIdMedicamentos.TabIndex = 8
        Me.lblIdMedicamentos.Text = "Id:"
        '
        'lblNombreMedicamentos
        '
        Me.lblNombreMedicamentos.AutoSize = True
        Me.lblNombreMedicamentos.Location = New System.Drawing.Point(306, 237)
        Me.lblNombreMedicamentos.Name = "lblNombreMedicamentos"
        Me.lblNombreMedicamentos.Size = New System.Drawing.Size(54, 15)
        Me.lblNombreMedicamentos.TabIndex = 9
        Me.lblNombreMedicamentos.Text = "Nombre:"
        '
        'lblTipoMedicamento
        '
        Me.lblTipoMedicamento.AutoSize = True
        Me.lblTipoMedicamento.Location = New System.Drawing.Point(244, 273)
        Me.lblTipoMedicamento.Name = "lblTipoMedicamento"
        Me.lblTipoMedicamento.Size = New System.Drawing.Size(110, 15)
        Me.lblTipoMedicamento.TabIndex = 10
        Me.lblTipoMedicamento.Text = "Tipo Medicamento:"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 100)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 412)
        Me.Panel2.TabIndex = 12
        '
        'FormMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 512)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTipoMedicamento)
        Me.Controls.Add(Me.lblNombreMedicamentos)
        Me.Controls.Add(Me.lblIdMedicamentos)
        Me.Controls.Add(Me.txtTipoMedicamento)
        Me.Controls.Add(Me.txtNombreMedicamentos)
        Me.Controls.Add(Me.txtIdMedicamentos)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
