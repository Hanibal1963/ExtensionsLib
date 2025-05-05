' *************************************************************************************************
' 
' DifferenceOfControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class DifferenceOfControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)

    ' Infotext laden
    Me.TextBox1.Text = My.Resources.DifferenceOf_InfoText

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"Differenz zu 50",-15}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

    Dim line As String
    For i As Double = 5 To 100 Step 5

      ' Zeile formatieren
      line = $"{i,-5}| {i.DifferenceOf(50),-15}{vbCrLf}"

      ' Zeile anhängen
      Me.TextBox1.Text &= line

    Next

  End Sub

End Class
