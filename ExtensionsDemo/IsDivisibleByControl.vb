' *************************************************************************************************
' 
' IsDivisibleByControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class IsDivisibleByControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)

    ' Infotext laden
    Me.TextBox1.Text = My.Resources.IsDivisibleBy_InfoText

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"durch 7 teilbar",-15}| {"durch 5 teilbar",-15}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

    Dim line As String
    For i As Integer = 1 To 100

      ' Zeile formatieren
      line = $"{i,-5}| {IsDivisibleBy(i, 7),-15}| {IsDivisibleBy(i, 5),-15}{vbCrLf}"

      ' Zeile anhängen
      Me.TextBox1.Text &= line

    Next

  End Sub

End Class
