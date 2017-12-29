Public Class Form3
    Function GiaiThua(so As Double) As Double
        Dim giaithuaso As Double = 1
        For index As Integer = 1 To so Step 1
            giaithuaso = giaithuaso * index
        Next
        Return giaithuaso
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tong As Double = 0
        Dim n As Double = Double.Parse(txtnhapn.Text)
        For index As Integer = 1 To n Step 1
            If index Mod 2 = 0 Then
                'doi index sang gia tri giai thua va gan vao bieu thuc:
                Dim i As Double = GiaiThua(index)
                tong = tong - (1 / i)
            Else
                'doi index sang gia tri giai thua va gan vao bieu thuc:
                Dim i As Double = GiaiThua(index)
                tong = tong + (1 / i)
            End If
        Next
        Dim strtong As String = Convert.ToString(tong)
        txttongbieuthuc.Text = strtong
    End Sub

    Private Sub txtbieuthuc_TextChanged(sender As Object, e As EventArgs) Handles txtbieuthuc.TextChanged

    End Sub
End Class