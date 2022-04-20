<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox_First = New System.Windows.Forms.TextBox()
        Me.TextBox_Last = New System.Windows.Forms.TextBox()
        Me.TextBox_Job = New System.Windows.Forms.TextBox()
        Me.TextBox_DoH = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button_LoadTable = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Search_txt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Job Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 36)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date of Hire"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(51, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 60)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox_First
        '
        Me.TextBox_First.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_First.Location = New System.Drawing.Point(268, 194)
        Me.TextBox_First.Name = "TextBox_First"
        Me.TextBox_First.Size = New System.Drawing.Size(130, 41)
        Me.TextBox_First.TabIndex = 6
        '
        'TextBox_Last
        '
        Me.TextBox_Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Last.Location = New System.Drawing.Point(268, 263)
        Me.TextBox_Last.Name = "TextBox_Last"
        Me.TextBox_Last.Size = New System.Drawing.Size(130, 41)
        Me.TextBox_Last.TabIndex = 7
        '
        'TextBox_Job
        '
        Me.TextBox_Job.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Job.Location = New System.Drawing.Point(268, 318)
        Me.TextBox_Job.Name = "TextBox_Job"
        Me.TextBox_Job.Size = New System.Drawing.Size(130, 41)
        Me.TextBox_Job.TabIndex = 8
        '
        'TextBox_DoH
        '
        Me.TextBox_DoH.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_DoH.Location = New System.Drawing.Point(268, 375)
        Me.TextBox_DoH.Name = "TextBox_DoH"
        Me.TextBox_DoH.Size = New System.Drawing.Size(130, 41)
        Me.TextBox_DoH.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(236, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 60)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 36)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Employee Id"
        '
        'TextBox_Id
        '
        Me.TextBox_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Id.Location = New System.Drawing.Point(268, 136)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(130, 41)
        Me.TextBox_Id.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(51, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 60)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button_LoadTable
        '
        Me.Button_LoadTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_LoadTable.Location = New System.Drawing.Point(591, 446)
        Me.Button_LoadTable.Name = "Button_LoadTable"
        Me.Button_LoadTable.Size = New System.Drawing.Size(270, 60)
        Me.Button_LoadTable.TabIndex = 14
        Me.Button_LoadTable.Text = "Refresh"
        Me.Button_LoadTable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(416, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(570, 280)
        Me.DataGridView1.TabIndex = 15
        '
        'Search_txt
        '
        Me.Search_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_txt.Location = New System.Drawing.Point(298, 538)
        Me.Search_txt.Name = "Search_txt"
        Me.Search_txt.Size = New System.Drawing.Size(285, 34)
        Me.Search_txt.TabIndex = 17
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 601)
        Me.Controls.Add(Me.Search_txt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_LoadTable)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox_Id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox_DoH)
        Me.Controls.Add(Me.TextBox_Job)
        Me.Controls.Add(Me.TextBox_Last)
        Me.Controls.Add(Me.TextBox_First)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox_First As TextBox
    Friend WithEvents TextBox_Last As TextBox
    Friend WithEvents TextBox_Job As TextBox
    Friend WithEvents TextBox_DoH As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button_LoadTable As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Search_txt As TextBox
End Class
