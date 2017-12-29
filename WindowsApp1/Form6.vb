Public Class Form6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Integer.Parse(txtnhapsohenhiphan.Text)
        Dim tong As Integer = 0
        Dim hangdonvi As Integer = n Mod 10
        Dim hangchuc As Integer = (n / 10) Mod 10
        Dim hangtram As Integer = (n / 100) Mod 10
        Dim hangngan As Integer = (n / 1000) Mod 10
        Dim hangchucngan As Integer = (n / 10000) Mod 10
        Dim hangtramngan As Integer = (n / 100000) Mod 10
        Dim hangtrieu As Integer = (n / 1000000) Mod 10
        Dim hangchuctrieu As Integer = (n / 10000000) Mod 10
        Dim hangtramtrieu As Integer = (n / 100000000) Mod 10
        Dim hangti As Integer = (n / 1000000000) Mod 10
        'tim so n do co bao nhieu chu so:
        Dim demso As Integer = 0
        If n <= 9 Then
            demso = 1
        Else
            Dim luythua As Integer = 10
            Dim m As Integer
            For index As Integer = 1 To n Step 1
                luythua = luythua * 10
                m = n / luythua
                If m <> 0 Then
                    demso = index + 1
                    Exit For
                End If
            Next
        End If
        'MsgBox(demso)        
        If hangdonvi <> 0 Then
                tong = tong + hangdonvi * (Math.Pow(2, 0))
            End If
            If hangchuc <> 0 Then
                tong = tong + hangchuc * (Math.Pow(2, 1))
            End If
            If hangtram <> 0 Then
                tong = tong + hangtram * (Math.Pow(2, 2))
            End If
            If hangngan <> 0 Then
                tong = tong + hangngan * (Math.Pow(2, 3))
            End If
            If hangchucngan <> 0 Then
                tong = tong + hangchucngan * (Math.Pow(2, 4))
            End If

        Dim strtong As String = Convert.ToString(tong)
        txtsohethapphanla.Text = strtong
    End Sub
End Class