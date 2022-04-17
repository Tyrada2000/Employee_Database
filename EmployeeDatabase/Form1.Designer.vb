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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.buttonReset = New System.Windows.Forms.Button()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.buttonOpen = New System.Windows.Forms.Button()
        Me.buttonInsert = New System.Windows.Forms.Button()
        Me.buttonUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDoH = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(242, 201)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(298, 45)
        Me.txtFirstName.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(556, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1060, 677)
        Me.DataGridView1.TabIndex = 2
        '
        'buttonReset
        '
        Me.buttonReset.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonReset.Location = New System.Drawing.Point(21, 572)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(167, 61)
        Me.buttonReset.TabIndex = 4
        Me.buttonReset.Text = "Reset"
        Me.buttonReset.UseVisualStyleBackColor = True
        '
        'buttonRemove
        '
        Me.buttonRemove.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRemove.Location = New System.Drawing.Point(194, 572)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(167, 61)
        Me.buttonRemove.TabIndex = 5
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.Location = New System.Drawing.Point(367, 572)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(167, 61)
        Me.buttonExit.TabIndex = 6
        Me.buttonExit.Text = "Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'buttonOpen
        '
        Me.buttonOpen.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonOpen.Location = New System.Drawing.Point(21, 493)
        Me.buttonOpen.Name = "buttonOpen"
        Me.buttonOpen.Size = New System.Drawing.Size(167, 61)
        Me.buttonOpen.TabIndex = 7
        Me.buttonOpen.Text = "Open"
        Me.buttonOpen.UseVisualStyleBackColor = True
        '
        'buttonInsert
        '
        Me.buttonInsert.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonInsert.Location = New System.Drawing.Point(194, 493)
        Me.buttonInsert.Name = "buttonInsert"
        Me.buttonInsert.Size = New System.Drawing.Size(167, 61)
        Me.buttonInsert.TabIndex = 8
        Me.buttonInsert.Text = "Insert"
        Me.buttonInsert.UseVisualStyleBackColor = True
        '
        'buttonUpdate
        '
        Me.buttonUpdate.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonUpdate.Location = New System.Drawing.Point(367, 493)
        Me.buttonUpdate.Name = "buttonUpdate"
        Me.buttonUpdate.Size = New System.Drawing.Size(167, 61)
        Me.buttonUpdate.TabIndex = 9
        Me.buttonUpdate.Text = "Update"
        Me.buttonUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 46)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 46)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 46)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Job Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 46)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date of Hire"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTitle.Location = New System.Drawing.Point(243, 303)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(298, 45)
        Me.txtJobTitle.TabIndex = 18
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(243, 252)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(298, 45)
        Me.txtLastName.TabIndex = 19
        '
        'txtDoH
        '
        Me.txtDoH.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoH.Location = New System.Drawing.Point(243, 354)
        Me.txtDoH.Name = "txtDoH"
        Me.txtDoH.Size = New System.Drawing.Size(298, 45)
        Me.txtDoH.TabIndex = 21
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(23, 45)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(95, 46)
        Me.lblDate.TabIndex = 25
        Me.lblDate.Text = "Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(556, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(265, 48)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Employee Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1083, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 46)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1216, 49)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(400, 45)
        Me.txtSearch.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1617, 809)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDoH)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtJobTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonUpdate)
        Me.Controls.Add(Me.buttonInsert)
        Me.Controls.Add(Me.buttonOpen)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonRemove)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents buttonReset As Button
    Friend WithEvents buttonRemove As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents buttonOpen As Button
    Friend WithEvents buttonInsert As Button
    Friend WithEvents buttonUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDoH As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
End Class
