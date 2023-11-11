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


End Class
