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
    Me.txtUserName = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtPassword = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'txtUserName
    '
    Me.txtUserName.Location = New System.Drawing.Point(95, 12)
    Me.txtUserName.Name = "txtUserName"
    Me.txtUserName.Size = New System.Drawing.Size(183, 22)
    Me.txtUserName.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(77, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Username:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 43)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(73, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Password:"
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(95, 40)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(183, 22)
    Me.txtPassword.TabIndex = 3
    Me.txtPassword.UseSystemPasswordChar = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(158, 68)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(120, 23)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Get Account"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(15, 95)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(255, 146)
    Me.TextBox1.TabIndex = 5
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(282, 253)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.txtPassword)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtUserName)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtUserName As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents txtPassword As TextBox
  Friend WithEvents Button1 As Button
  Friend WithEvents TextBox1 As TextBox
End Class
