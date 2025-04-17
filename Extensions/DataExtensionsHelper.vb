' *************************************************************************************************
' 
' DataExtensionsHelper.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

''' <summary>
''' Definition von Hilfsfunktionen
''' </summary>
Friend Module DataExtensionsHelper

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu formatierende Wert.
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <param name="culture">
  ''' Die Kultur, die für die Formatierung verwendet werden soll (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalFormatted(sender As Double, precision As Integer, culture As Globalization.CultureInfo) As String
    ' Formatiert den Wert als Zeichenfolge mit der angegebenen Präzision und Kultur.
    ' Das Format "X" ist hier möglicherweise ein Fehler, da es für hexadezimale Werte verwendet wird.
    ' Es sollte überprüft werden, ob ein anderes Format wie "F" (für feste Dezimalstellen) passender ist.
    Return sender.ToString("X" & precision, culture)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von <paramref name="value"/>.
  ''' </summary>
  ''' <param name="value">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalGetPercentageOf(value As Double, total As Double) As Double
    ' Dividiere den Wert durch den Gesamtwert und multipliziere das Ergebnis mit 100,
    ' um den Prozentsatz zu berechnen.
    Return value / total * 100
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes.
  ''' </summary>
  ''' <param name="value">
  ''' Der Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="percent">
  ''' Der Prozentsatz, der auf den Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalFractionBy(value As Double, percent As Double) As Double
    ' Teile den Wert durch 100, um 1% des Wertes zu erhalten, 
    ' und multipliziere das Ergebnis mit dem angegebenen Prozentsatz.
    Return value / 100 * percent
  End Function

  ''' <summary>
  ''' Bestimmt, ob ein Wert positiv ist.
  ''' </summary>
  ''' <param name="value">
  ''' Der zu überprüfende Wert.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Wert größer als 0 ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsPositive(value As Double) As Boolean
    ' Initialisiere das Ergebnis als False
    Dim result As Boolean = False
    ' Überprüfe, ob der Wert größer als 0 ist
    If value > 0 Then
      result = True
    End If
    ' Gib das Ergebnis zurück
    Return result
  End Function

  ''' <summary>
  ''' Bestimmt, ob der Wert negativ ist.
  ''' </summary>
  ''' <param name="value">
  ''' Der zu überprüfende Wert.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Wert kleiner als 0 ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsNegative(value As Double) As Boolean
    ' Initialisiere das Ergebnis als False
    Dim result As Boolean = False
    ' Überprüfe, ob der Wert kleiner als 0 ist
    If value < 0 Then
      result = True
    End If
    ' Gib das Ergebnis zurück
    Return result
  End Function

  ''' <summary>
  ''' Bestimmt, ob der Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="value">
  ''' Der zu überprüfende Wert.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsPrime(value As Long) As Boolean
    ' Überprüfen, ob der Wert gerade ist
    ' Wenn der Wert gerade ist, kann er nur dann eine Primzahl sein, wenn er gleich 2 ist
    If (value And 1L) = 0L Then
      Return value = 2L
    Else
      ' Initialisiere den Teiler mit 3
      Dim i As Long = 3L
      ' Schleife, um mögliche Teiler zu überprüfen
      ' Die Schleife läuft, solange das Quadrat des Teilers kleiner oder gleich dem Wert ist
      While (i * i) <= value
        ' Wenn der Wert durch den aktuellen Teiler ohne Rest teilbar ist, ist er keine Primzahl
        If (value Mod i) = 0L Then
          Return False
        End If
        ' Erhöhe den Teiler um 2, um nur ungerade Zahlen zu prüfen
        i += 2L
      End While
      ' Wenn keine Teiler gefunden wurden, ist der Wert eine Primzahl, außer er ist 1
      Return value <> 1L
    End If
  End Function

  ''' <summary>
  ''' Bestimmt, ob der Quellwert durch den angegebenen Wert teilbar ist (ohne Rest).
  ''' </summary>
  ''' <param name="source">
  ''' Der Wert, der überprüft werden soll.
  ''' </param>
  ''' <param name="value">
  ''' Der Wert, durch den geteilt werden soll.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Quellwert ohne Rest durch den angegebenen Wert teilbar ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsDivisibleBy(source As Double, value As Double) As Boolean
    ' Überprüft, ob der Rest der Division von "source" durch "value" gleich 0 ist.
    ' Wenn ja, ist "source" durch "value" teilbar.
    Return source Mod value = 0
  End Function

  ''' <summary>
  ''' Bestimmt, ob der Wert ein Vielfaches von <paramref name="value"/> ist.
  ''' </summary>
  ''' <param name="source">
  ''' Der zu überprüfende Wert.
  ''' </param>
  ''' <param name="value">
  ''' Der Wert, dessen Vielfaches überprüft werden soll.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Quellwert ein Vielfaches des angegebenen Wertes ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsMultipleOf(source As Double, value As Double) As Boolean
    ' Überprüft, ob der Rest der Division von "source" durch "value" gleich 0 ist.
    ' Wenn ja, ist "source" ein Vielfaches von "value".
    Return source Mod value = 0
  End Function

  ''' <summary>
  ''' Bestimmt, ob der Quellwert im Bereich der angegebenen 
  ''' <paramref name="minimum"/>- und <paramref name="maximum"/>-Werte liegt.
  ''' </summary>
  ''' <param name="source">
  ''' Der Wert, der überprüft werden soll.
  ''' </param>
  ''' <param name="minimum">
  ''' Der Mindestwert des Bereichs.
  ''' </param>
  ''' <param name="maximum">
  ''' Der Maximalwert des Bereichs.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/>, wenn der Quellwert im Bereich liegt, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalIsInRangeOf(source As Double, minimum As Double, maximum As Double) As Boolean
    ' Überprüft, ob der Quellwert größer oder gleich dem Mindestwert ist
    ' und gleichzeitig kleiner oder gleich dem Maximalwert.
    ' Gibt True zurück, wenn beide Bedingungen erfüllt sind, andernfalls False.
    Return (source >= minimum) AndAlso (source <= maximum)
  End Function

  ''' <summary>
  ''' Gibt die Differenz zwischen dem Wert und <paramref name="value"/> zurück.
  ''' </summary>
  ''' <param name="source">
  ''' Der Ausgangswert, von dem die Differenz berechnet wird.
  ''' </param>
  ''' <param name="value">
  ''' Der Vergleichswert, mit dem die Differenz berechnet wird.
  ''' </param>
  ''' <returns>
  ''' Die berechnete Differenz zwischen dem Ausgangswert und dem Vergleichswert.
  ''' </returns>
  <DebuggerStepThrough>
  Friend Function InternalDifferenceOf(source As Double, value As Double) As Double
    ' Überprüft, ob der Vergleichswert größer als der Ausgangswert ist
    Select Case value
      ' Wenn der Vergleichswert größer ist, wird die Differenz positiv zurückgegeben
      Case Is > source
        Return +(value - source)
      ' Wenn der Vergleichswert kleiner ist, wird die Differenz negativ zurückgegeben
      Case Is < source
        Return -(source - value)
        ' Wenn beide Werte gleich sind, wird 0 zurückgegeben
      Case Else
        Return 0.0R
    End Select
  End Function

End Module
