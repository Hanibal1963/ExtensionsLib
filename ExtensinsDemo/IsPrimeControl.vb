' *************************************************************************************************
' 
' IsPrimeControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class IsPrimeControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)

    ' Infotext laden
    Me.TextBox1.Text = My.Resources.IsPrime_InfoText

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"ist eine Primzahl",-15}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

    Dim line As String
    For i As Integer = 1 To 100

      ' Zeile formatieren
      line = $"{i,-5}| {i.IsPrime,-15}{vbCrLf}"

      ' Zeile anhängen
      Me.TextBox1.Text &= line

    Next

  End Sub

End Class
