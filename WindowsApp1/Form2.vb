Public Class Form2
    Function TinhDienTichTamGiac2(canhketrai As Integer, canhkephai As Integer, canhday As Integer, dientichtamgiac As Integer) As Integer
        Dim duongcao, x, y, kq1, kq2 As Integer
        kq1 = ((canhkephai * canhkephai) - (canhketrai * canhketrai))
        'x2-y2 = (x+y)(x-y)=kq1
        'x+y = canhday
        'x-y = kq1 : canhday = kq2
        kq2 = kq1 / canhday
        'x+ (x-kq2) = canhday
        '=> x= (canhday+kq2)/2        
        x = (canhday + kq2) / 2
        'duongcao=canbac2(canhkephai2-x2)
        duongcao = Math.Sqrt((canhkephai * canhkephai) - (x * x))
        'dientich= 1/2*canhday*duongcao
        dientichtamgiac = (1 / 2) * canhday * duongcao
        Return dientichtamgiac
    End Function
    Sub TinhDienTichTamGiac(canhketrai As Integer, canhkephai As Integer, canhday As Integer, dientichtamgiac As Integer)
        Dim duongcao, x, y, kq1, kq2 As Integer
        '1. canh day:
        'canhday = x + y
        '2. tinh duongcao:
        'duongcao = canbac2(canhketrai2-y2)
        'duongcao = canbac2(canhkephai2-x2)
        'canhketrai2-y2 = canhkephai2-x2
        'x2-y2 = canhkephai2 - canhketrai2 = kq1
        kq1 = Math.Sqrt((canhkephai * 2) - (canhketrai * 2))
        'x+y = canhday
        'x-y = kq1 : canhday = kq2
        kq2 = kq1 / canhday
        'x+ (x-kq2) = canhday
        '=> x= (canhday+kq2)/2        
        x = (canhday + kq2) / 2
        'duongcao=canbac2(canhkephai2-x2)
        duongcao = Math.Sqrt((canhkephai * 2) - (x * 2))
        'dientich= 1/2*canhday*duongcao
        dientichtamgiac = (1 / 2) * canhday * duongcao
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub btthuchien_Click(sender As Object, e As EventArgs) Handles btthuchien.Click
        Dim canhketrai As Int32 = CInt(txtcanhketrai.Text())
        Dim canhkephai As Int32 = CInt(txtcanhkephai.Text())
        Dim canhday As Int32 = CInt(txtcanhday.Text())
        Dim result As Integer = 0
        Dim myObject As Form2 = New Form2()

        result = myObject.TinhDienTichTamGiac2(canhketrai, canhkephai, canhday, result)
        txtdientichtamgiac.Text = result
    End Sub
End Class