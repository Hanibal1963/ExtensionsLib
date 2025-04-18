' *************************************************************************************************
' 
' PercentageOfControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class PercentageOfControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)
    Me.TextBox1.Text = My.Resources.PercentageOf_InfoText

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"sind Prozent",-15}| {"von",-5}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

    Dim total As Double = 50
    For i As Double = 5 To 100 Step 5

      ' Zeile formatieren
      Dim line As String = $"{i,-5}| {i.PercentageOf(total),-15}| {total,-5}{vbCrLf}"

      ' Zeile anhängen
      Me.TextBox1.Text &= line

    Next

  End Sub

End Class
