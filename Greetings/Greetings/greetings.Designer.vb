﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Blue
        Me.btnClick.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.White
        Me.btnClick.Location = New System.Drawing.Point(206, 240)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(175, 52)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "Click Me"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.GhostWhite
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(207, 181)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(174, 29)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.LightBlue
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Salmon
        Me.lblHeading.Location = New System.Drawing.Point(203, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(185, 24)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Greetings Program"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Blue
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(204, 146)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(181, 23)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Enter Your Name"
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(167, 319)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(251, 75)
        Me.txtOut.TabIndex = 4
        Me.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(605, 512)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblName)
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
    Friend WithEvents lblName As Label
    Friend WithEvents txtOut As TextBox
End Class
