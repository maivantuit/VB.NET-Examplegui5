﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnhapsohenhiphan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsohethapphanla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(738, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ĐỔI MỘT SỐ TỪ HỆ NHỊ PHÂN SANG HỆ THẬP PHÂN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 24)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nhập số hệ nhị phân:"
        '
        'txtnhapsohenhiphan
        '
        Me.txtnhapsohenhiphan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnhapsohenhiphan.Location = New System.Drawing.Point(453, 124)
        Me.txtnhapsohenhiphan.Name = "txtnhapsohenhiphan"
        Me.txtnhapsohenhiphan.Size = New System.Drawing.Size(231, 29)
        Me.txtnhapsohenhiphan.TabIndex = 29
        Me.txtnhapsohenhiphan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(345, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 71)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Thực hiện chuyển đổi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsohethapphanla
        '
        Me.txtsohethapphanla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsohethapphanla.Location = New System.Drawing.Point(463, 286)
        Me.txtsohethapphanla.Name = "txtsohethapphanla"
        Me.txtsohethapphanla.Size = New System.Drawing.Size(231, 29)
        Me.txtsohethapphanla.TabIndex = 32
        Me.txtsohethapphanla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(179, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Số hệ thập phân là:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(766, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 101)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Quay lại form chính"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 510)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsohethapphanla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnhapsohenhiphan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnhapsohenhiphan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsohethapphanla As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
