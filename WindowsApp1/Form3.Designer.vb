<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbieuthuc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttongbieuthuc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtnhapn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TÍNH TỔNG BIỂU THỨC"
        '
        'txtbieuthuc
        '
        Me.txtbieuthuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbieuthuc.Location = New System.Drawing.Point(234, 130)
        Me.txtbieuthuc.Name = "txtbieuthuc"
        Me.txtbieuthuc.Size = New System.Drawing.Size(432, 29)
        Me.txtbieuthuc.TabIndex = 20
        Me.txtbieuthuc.Text = "S = 1 - 1/2! +1/3!- ...(±)1/n! "
        Me.txtbieuthuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Biểu thức mẫu:"
        '
        'txttongbieuthuc
        '
        Me.txttongbieuthuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttongbieuthuc.Location = New System.Drawing.Point(234, 377)
        Me.txttongbieuthuc.Name = "txttongbieuthuc"
        Me.txttongbieuthuc.Size = New System.Drawing.Size(432, 29)
        Me.txttongbieuthuc.TabIndex = 22
        Me.txttongbieuthuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tổng biểu thức là:"
        '
        'txtnhapn
        '
        Me.txtnhapn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnhapn.Location = New System.Drawing.Point(234, 200)
        Me.txtnhapn.Name = "txtnhapn"
        Me.txtnhapn.Size = New System.Drawing.Size(432, 29)
        Me.txtnhapn.TabIndex = 24
        Me.txtnhapn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nhập n:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(394, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 71)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Thực hiện"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(766, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 101)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Quay lại form chính"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 517)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnhapn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttongbieuthuc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbieuthuc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbieuthuc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttongbieuthuc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtnhapn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
