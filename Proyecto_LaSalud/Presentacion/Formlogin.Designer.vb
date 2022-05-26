<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formlogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gblogin = New System.Windows.Forms.GroupBox()
        Me.bttSalir = New System.Windows.Forms.Button()
        Me.bttIngresar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gblogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 91)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Proyecto_LaSalud.My.Resources.Resources.network
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 155)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(295, 265)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'gblogin
        '
        Me.gblogin.Controls.Add(Me.bttSalir)
        Me.gblogin.Controls.Add(Me.bttIngresar)
        Me.gblogin.Controls.Add(Me.txtContrasena)
        Me.gblogin.Controls.Add(Me.txtUsuario)
        Me.gblogin.Controls.Add(Me.lblContrasena)
        Me.gblogin.Controls.Add(Me.lblUsuario)
        Me.gblogin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gblogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gblogin.Location = New System.Drawing.Point(351, 91)
        Me.gblogin.Name = "gblogin"
        Me.gblogin.Size = New System.Drawing.Size(603, 329)
        Me.gblogin.TabIndex = 5
        Me.gblogin.TabStop = False
        Me.gblogin.Text = "Ingresa usuario y contraseña"
        '
        'bttSalir
        '
        Me.bttSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttSalir.Location = New System.Drawing.Point(332, 250)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(157, 51)
        Me.bttSalir.TabIndex = 5
        Me.bttSalir.Text = "Salir"
        Me.bttSalir.UseVisualStyleBackColor = False
        '
        'bttIngresar
        '
        Me.bttIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttIngresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttIngresar.Location = New System.Drawing.Point(69, 250)
        Me.bttIngresar.Name = "bttIngresar"
        Me.bttIngresar.Size = New System.Drawing.Size(157, 51)
        Me.bttIngresar.TabIndex = 4
        Me.bttIngresar.Text = "Ingresar"
        Me.bttIngresar.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(181, 156)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(308, 38)
        Me.txtContrasena.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(181, 80)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(308, 38)
        Me.txtUsuario.TabIndex = 2
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(32, 156)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(134, 31)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(69, 80)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(97, 31)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHora.Location = New System.Drawing.Point(118, 35)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(85, 38)
        Me.lblHora.TabIndex = 6
        Me.lblHora.Text = "Login"
        '
        'Formlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(985, 456)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.gblogin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formlogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gblogin.ResumeLayout(False)
        Me.gblogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gblogin As GroupBox
    Friend WithEvents bttIngresar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents bttSalir As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As Label
End Class
