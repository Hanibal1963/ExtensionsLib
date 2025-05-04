' *************************************************************************************************
' 
' IsInRangeOfControl.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions

Public Class IsInRangeOfControl

  Public Sub Start()

    ' Monospace-Schriftart für die TextBox setzen
    Me.TextBox1.Font = New Font("Courier New", 10)

    ' Infotext laden
    Me.TextBox1.Text = My.Resources.IsInRangeOf_InfoText

    'TODO: Code für die Demo noch erstellen
    Me.TextBox1.Text &= $"Code für die Demo muß noch erstellt werden !" & vbCrLf & vbCrLf

    ' Kopfzeile erstellen
    Dim header As String = $"{"Wert",-5}| {"",-15}{vbCrLf}"
    Me.TextBox1.Text &= header
    Me.TextBox1.Text &= New String("-"c, header.Length) & vbCrLf

  End Sub

End Class
