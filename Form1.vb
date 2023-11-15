Public Class Form1

    Private objConv As New TempConv.TempConvComp

    Private Sub rbCToR_CheckedChanged(sender As Object, e As EventArgs) Handles rbCToR.CheckedChanged
        Dim c As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            c = 0
        Else
            c = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Celcius Ke Reamur" & vbNewLine & vbNewLine & "Celcius: " & temp & vbNewLine & "Reamur: " & objConv.cToR(c)

    End Sub

    Private Sub rbCToF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCToF.CheckedChanged
        Dim c As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            c = 0
        Else
            c = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Celcius Ke Fahrenheit" & vbNewLine & vbNewLine & "Celcius: " & temp & vbNewLine & "Fahrenheit: " & objConv.cToF(c)
    End Sub

    Private Sub rbCToK_CheckedChanged(sender As Object, e As EventArgs) Handles rbCToK.CheckedChanged
        Dim c As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            c = 0
        Else
            c = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Celcius Ke Kelvin" & vbNewLine & vbNewLine & "Celcius: " & temp & vbNewLine & "Kelvin: " & objConv.cToK(c)
    End Sub
    Private Sub rbRToC_CheckedChanged(sender As Object, e As EventArgs) Handles rbRToC.CheckedChanged
        Dim r As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            r = 0
        Else
            r = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Reamur Ke Celicus" & vbNewLine & vbNewLine & "Reamur: " & temp & vbNewLine & "Celcius: " & objConv.rToC(r)
    End Sub

    Private Sub rbRToF_CheckedChanged(sender As Object, e As EventArgs) Handles rbRToF.CheckedChanged
        Dim r As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            r = 0
        Else
            r = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Reamur Ke Fahrenheit" & vbNewLine & vbNewLine & "Reamur: " & temp & vbNewLine & "Fahrenheit: " & objConv.rToF(r)
    End Sub

    Private Sub rbRToK_CheckedChanged(sender As Object, e As EventArgs) Handles rbRToK.CheckedChanged
        Dim r As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            r = 0
        Else
            r = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Reamur Ke Kelvin" & vbNewLine & vbNewLine & "Reamur: " & temp & vbNewLine & "Kelvin: " & objConv.rToK(r)
    End Sub

    Private Sub rbFToC_CheckedChanged(sender As Object, e As EventArgs) Handles rbFToC.CheckedChanged
        Dim f As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            f = 0
        Else
            f = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Fahrenheit Ke Celicus" & vbNewLine & vbNewLine & "Fahrenheit: " & temp & vbNewLine & "Celcius: " & objConv.fToC(f)
    End Sub

    Private Sub rbFToR_CheckedChanged(sender As Object, e As EventArgs) Handles rbFToR.CheckedChanged
        Dim f As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            f = 0
        Else
            f = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Fahrenheit Ke Reamur" & vbNewLine & vbNewLine & "Fahrenheit: " & temp & vbNewLine & "Reamur: " & objConv.fToR(f)
    End Sub

    Private Sub rbFToK_CheckedChanged(sender As Object, e As EventArgs) Handles rbFToK.CheckedChanged
        Dim f As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            f = 0
        Else
            f = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Fahrenheit Ke Kelvin" & vbNewLine & vbNewLine & "Fahrenheit: " & temp & vbNewLine & "Kelvin: " & objConv.fToK(f)
    End Sub

    Private Sub rbKToC_CheckedChanged(sender As Object, e As EventArgs) Handles rbKToC.CheckedChanged
        Dim k As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            k = 0
        Else
            k = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Kelvin Ke Celicus" & vbNewLine & vbNewLine & "Kelvin: " & temp & vbNewLine & "Celcius: " & objConv.kToC(k)
    End Sub

    Private Sub rbKToR_CheckedChanged(sender As Object, e As EventArgs) Handles rbKToR.CheckedChanged
        Dim k As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            k = 0
        Else
            k = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Kelvin Ke Reamur" & vbNewLine & vbNewLine & "Kelvin: " & temp & vbNewLine & "Reamur: " & objConv.kToR(k)
    End Sub

    Private Sub rbKToF_CheckedChanged(sender As Object, e As EventArgs) Handles rbKToF.CheckedChanged
        Dim k As Double
        Dim temp As String

        temp = valTemp.Text

        If temp = "" Then
            k = 0
        Else
            k = CDbl(valTemp.Text)
        End If

        valResult.Text = "Konversi Kelvin Ke Fahrenheit" & vbNewLine & vbNewLine & "Kelvin: " & temp & vbNewLine & "Fahrenheit: " & objConv.kToF(k)
    End Sub
End Class
