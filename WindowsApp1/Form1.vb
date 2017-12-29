Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDanhsachcacbaitap.SelectedIndexChanged
        Dim a As String = cboDanhsachcacbaitap.FindStringExact(cboDanhsachcacbaitap.Text)
        Dim chimuc As Int32 = CInt(Int(a))
        'kq.Text = chimuc.ToString
        Select Case chimuc
            Case 0
                Form2.Show()
            Case 1
                Form3.Show()
            Case 2
                Form4.Show()
            Case 3
                Form5.Show()
            Case 4
                Form6.Show()
            Case Else

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Close()
    End Sub
End Class
