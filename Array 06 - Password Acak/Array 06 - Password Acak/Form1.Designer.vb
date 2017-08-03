<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnBuat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJumKar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(17, 41)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPassword.Size = New System.Drawing.Size(171, 205)
        Me.txtPassword.TabIndex = 2
        '
        'btnBuat
        '
        Me.btnBuat.Location = New System.Drawing.Point(204, 38)
        Me.btnBuat.Name = "btnBuat"
        Me.btnBuat.Size = New System.Drawing.Size(86, 25)
        Me.btnBuat.TabIndex = 3
        Me.btnBuat.Text = "&Buat Password"
        Me.btnBuat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jumlah karakter (min. 3)"
        '
        'txtJumKar
        '
        Me.txtJumKar.Location = New System.Drawing.Point(145, 12)
        Me.txtJumKar.Name = "txtJumKar"
        Me.txtJumKar.Size = New System.Drawing.Size(36, 20)
        Me.txtJumKar.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 262)
        Me.Controls.Add(Me.txtJumKar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuat)
        Me.Controls.Add(Me.txtPassword)
        Me.Name = "Form1"
        Me.Text = "Password Acak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnBuat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtJumKar As System.Windows.Forms.TextBox

End Class
