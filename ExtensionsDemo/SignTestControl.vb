' *************************************************************************************************
' 
' SignTestControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class SignTestControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)

    ' Infotext laden
    Me.TextBox1.Text = My.Resources.SignTest_InfoText

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"ist negativ",-15}| {"ist positiv",-15}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

    Dim line As String
    For i As Double = -10 To 10

      ' Zeile formatieren
      line = $"{i,-5}| {i.IsNegative,-15}| {i.IsPositive,-15}{vbCrLf}"

      ' Zeile anhängen
      Me.TextBox1.Text &= line

    Next

  End Sub

End Class
