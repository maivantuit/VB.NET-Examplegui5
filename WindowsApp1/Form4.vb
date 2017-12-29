Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub bthienthidayso_Click(sender As Object, e As EventArgs) Handles bthienthidayso.Click
        Dim n As Int32 = CInt(txtnhapnso.Text())
        For index As Integer = 1 To n Step 1
            Dim rand As New Random()
            Dim number = rand.Next(1, 1000)
            MsgBox(number)
            ListBox1.Items.Add(number)
        Next
    End Sub

    Private Sub btthuchienlaycacsochiahetcho5_Click(sender As Object, e As EventArgs)
        Dim i As Integer = ListBox2.Items.Count
        For index As Integer = 1 To i Step 1
            ListBox2.SelectedItem.ToString()
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim number As Integer = CInt(ListBox1.SelectedItem.ToString())
        Dim strnumber As String
        If number Mod 5 = 0 Then
            strnumber = Convert.ToString(number)
            ListBox2.Items.Add(strnumber)
        Else
            strnumber = Convert.ToString(number)
            ListBox3.Items.Add(strnumber)
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim number As Integer = CInt(ListBox2.SelectedItem.ToString())
        Dim tong As Integer = 0
        tong = tong + number
        Dim strnumber As String = Convert.ToString(tong)
        txttong.Text = strnumber
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyInteger As Integer = 0
        For i As Integer = 0 To ListBox2.Items.Count - 1
            MyInteger += Int32.Parse(ListBox2.Items(i).ToString)
        Next
        Dim str As String = Convert.ToString(MyInteger)
        txttong.Text = str
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim integer1 As Integer
        For i As Integer = 0 To ListBox1.Items.Count - 1
            integer1 = Int32.Parse(ListBox1.Items(i).ToString)
            If integer1 Mod 5 = 0 Then
                Dim str As String = Convert.ToString(integer1)
                ListBox2.Items.Add(str)
            Else
                Dim str As String = Convert.ToString(integer1)
                ListBox3.Items.Add(str)
            End If
        Next

    End Sub
End Class