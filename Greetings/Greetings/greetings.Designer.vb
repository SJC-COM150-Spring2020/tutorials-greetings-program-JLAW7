<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greetings
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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Blue
        Me.btnClick.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.White
        Me.btnClick.Location = New System.Drawing.Point(208, 255)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(174, 52)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click Me"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(208, 203)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 29)
        Me.txtName.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(23, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(185, 22)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Greetings Program"
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(605, 512)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Greetings"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHeading As Label
End Class
