<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(348, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check Connection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox_UN
        '
        Me.TextBox_UN.Location = New System.Drawing.Point(256, 126)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_UN.TabIndex = 4
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Location = New System.Drawing.Point(256, 180)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.Size = New System.Drawing.Size(175, 22)
        Me.TextBox_Pass.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 291)
        Me.Controls.Add(Me.TextBox_Pass)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents TextBox_Pass As TextBox
End Class
