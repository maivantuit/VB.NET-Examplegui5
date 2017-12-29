Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tu1 As Int32 = CInt(Int(txttu1.Text))
        Dim mau1 As Int32 = CInt(Int(txtmau1.Text))
        Dim tu2 As Int32 = CInt(Int(txttu2.Text))
        Dim mau2 As Int32 = CInt(Int(txtmau2.Text))
        Dim a As Double = (tu1 * mau2) + (tu2 * mau1)
        Dim b As Double = (mau1 * mau2)
        Dim c, d As Double
        c = a
        d = b
        While c <> d
            If c > d Then
                c = c - d
            Else
                d = d - c
            End If
        End While
        Dim tukq As Double
        tukq = (a / c)
        Dim tukqstr As String = tukq
        Dim maukq As Double
        maukq = (b / c)
        Dim maukqstr As String = maukq
        txttu.Text = tukqstr.ToString
        txtmau.Text = maukqstr.ToString
    End Sub
End Class