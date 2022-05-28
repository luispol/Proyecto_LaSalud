<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formlogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formlogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gblogin = New System.Windows.Forms.GroupBox()
        Me.bttIngresar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gblogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gblogin
        '
        Me.gblogin.Controls.Add(Me.bttIngresar)
        Me.gblogin.Controls.Add(Me.txtContrasena)
        Me.gblogin.Controls.Add(Me.txtUsuario)
        Me.gblogin.Controls.Add(Me.lblContrasena)
        Me.gblogin.Controls.Add(Me.lblUsuario)
        Me.gblogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gblogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gblogin.Location = New System.Drawing.Point(12, 159)
        Me.gblogin.Name = "gblogin"
        Me.gblogin.Size = New System.Drawing.Size(687, 289)
        Me.gblogin.TabIndex = 5
        Me.gblogin.TabStop = False
        Me.gblogin.Text = "Iniciar Sesión"
        '
        'bttIngresar
        '
        Me.bttIngresar.BackColor = System.Drawing.Color.Lavender
        Me.bttIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttIngresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.bttIngresar.Location = New System.Drawing.Point(323, 219)
        Me.bttIngresar.Name = "bttIngresar"
        Me.bttIngresar.Size = New System.Drawing.Size(125, 40)
        Me.bttIngresar.TabIndex = 4
        Me.bttIngresar.Text = "Ingresar"
        Me.bttIngresar.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(212, 156)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(345, 34)
        Me.txtContrasena.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(212, 77)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(345, 34)
        Me.txtUsuario.TabIndex = 2
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(62, 159)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(119, 28)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña :"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(99, 80)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(88, 28)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario :"
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
        Me.lblHora.Location = New System.Drawing.Point(12, 451)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(85, 38)
        Me.lblHora.TabIndex = 6
        Me.lblHora.Text = "Login"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(529, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 141)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Formlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 501)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.gblogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gblogin.ResumeLayout(False)
        Me.gblogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gblogin As GroupBox
    Friend WithEvents bttIngresar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
