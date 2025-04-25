' *************************************************************************************************
' 
' DataExtensions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Public Module DataExtensions

#Region "Prozentsatz eines Wertes von einem Gesamtwert berechnen"

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Short, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As UShort, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Integer, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As UInteger, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Long, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As ULong, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Decimal, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Single, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

  ''' <summary>
  ''' Berechnet den Prozentsatz eines Wertes von einem gegebenen Gesamtwert (<paramref name="total"/>).
  ''' </summary>
  ''' <param name="sender">
  ''' Der Wert, dessen Prozentsatz berechnet werden soll.
  ''' </param>
  ''' <param name="total">
  ''' Der Gesamtwert, auf den sich der Prozentsatz bezieht.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Prozentsatz des Wertes im Verhältnis zum Gesamtwert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function PercentageOf(sender As Double, total As Double) As Double
    ' Ruft die interne Funktion auf, um den Prozentsatz zu berechnen.
    ' Übergibt den Wert (sender) und den Gesamtwert (total) an die Funktion.
    Return InternalGetPercentageOf(sender, total)
  End Function

#End Region

#Region "Den Bruchteil eines Wertes berechnen"

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="Percentage">
  ''' Der Anteil in Prozent (<paramref name="Percentage"/>) der berechnet werden soll.
  ''' </param>
  ''' <returns>
  ''' Der Bruchteil der berechnet wurde.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Short, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As UShort, Percentage As Double) As Double

    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)

  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Integer, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As UInteger, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Long, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As ULong, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Decimal, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Single, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

  ''' <summary>
  ''' Berechnet den Bruchteil eines Wertes in Prozent.
  ''' </summary>
  ''' <param name="sender">
  ''' Der ursprüngliche Wert, dessen Bruchteil berechnet werden soll.
  ''' </param>
  ''' <param name="Percentage">
  ''' Der Prozentsatz, der auf den ursprünglichen Wert angewendet wird.
  ''' </param>
  ''' <returns>
  ''' Der berechnete Bruchteil des ursprünglichen Wertes basierend auf dem Prozentsatz.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FractionBy(sender As Double, Percentage As Double) As Double
    ' Ruft die interne Funktion auf, um den Bruchteil zu berechnen.
    ' Übergibt den Prozentsatz (Percentage) und den ursprünglichen Wert (sender) an die Funktion.
    Return InternalFractionBy(Percentage, sender)
  End Function

#End Region

#Region "Bestimmen ob ein Wert positiv ist"

  ''' <summary>
  ''' Bestimmt, ob ein Wert positiv ist.
  ''' </summary>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert eine positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Short) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert positiv ist.
    ' Die interne Funktion prüft, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Integer-Wert positiv ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Integer-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Integer) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Long-Wert positiv ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Long-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Long) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Decimal-Wert positiv ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Decimal-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Decimal) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Single-Wert positiv ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Single-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Single) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Double-Wert positiv ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Double-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert positiv ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPositive(sender As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert größer als 0 ist.
    Return InternalIsPositive(sender)
  End Function

#End Region

#Region "Bestimmen ob ein Wert negativ ist"

  ''' <summary>
  ''' Bestimmt, ob der Wert negativ ist.
  ''' </summary>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Short) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert negativ ist.
    ' Die interne Funktion prüft, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Integer-Wert negativ ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Integer-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Integer) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Long-Wert negativ ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Long-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Long) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Decimal-Wert negativ ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Decimal-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Decimal) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Single-Wert negativ ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Single-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Single) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Double-Wert negativ ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Double-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert negativ ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsNegative(sender As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert kleiner als 0 ist.
    Return InternalIsNegative(sender)
  End Function

#End Region

#Region "Bestimmen ob ein Wert eine Primzahl ist"

  ''' <summary>
  ''' Bestimmt, ob der Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Wert.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPrime(sender As Short) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert eine Primzahl ist.
    ' Die interne Funktion führt die eigentliche Berechnung und Prüfung durch.
    Return InternalIsPrime(sender)
  End Function

  ''' <summary>
  ''' Bestimmt, ob der übergebene UShort-Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende UShort-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsPrime(sender As UShort) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert eine Primzahl ist.
    ' Die interne Funktion führt die eigentliche Berechnung und Prüfung durch.
    Return InternalIsPrime(sender)
  End Function

  ''' <summary>
  ''' Bestimmt, ob der übergebene Integer-Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Integer-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode verwendet die interne Funktion <see cref="InternalIsPrime"/>, 
  ''' um die Berechnung und Prüfung durchzuführen.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function IsPrime(sender As Integer) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert eine Primzahl ist.
    Return InternalIsPrime(sender)
  End Function

  ''' <summary>
  ''' Bestimmt, ob der übergebene UInteger-Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende UInteger-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode verwendet die interne Funktion <see cref="InternalIsPrime"/>, 
  ''' um die Berechnung und Prüfung durchzuführen.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function IsPrime(sender As UInteger) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert eine Primzahl ist.
    ' Die interne Funktion führt die eigentliche Berechnung und Prüfung durch.
    Return InternalIsPrime(sender)
  End Function

  ''' <summary>
  ''' Bestimmt, ob der übergebene Long-Wert eine Primzahl ist.
  ''' </summary>
  ''' <param name="sender">
  ''' Der zu überprüfende Long-Wert.
  ''' </param>
  ''' <returns>
  ''' Gibt <see langword="True"/> zurück, wenn der Wert eine Primzahl ist, andernfalls <see langword="False"/>.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode verwendet die interne Funktion <see cref="InternalIsPrime"/>, 
  ''' um die Berechnung und Prüfung durchzuführen.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function IsPrime(sender As Long) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert eine Primzahl ist.
    ' Die interne Funktion führt die eigentliche Berechnung und Prüfung durch.
    Return InternalIsPrime(sender)
  End Function

#End Region

#Region "Bestimmen ob ein Wert durch einen angegebenen Wert teilbar ist"

  ''' <summary>
  ''' Bestimmt, ob der Wert durch den angegebenen Wert teilbar ist (ohne Rest).
  ''' </summary>
  ''' <param name="Divisor">
  ''' Der Wert, durch den dividiert werden soll.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert teilbar ist, andernfalls <see langword="False"/> .
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Short, Divisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ohne Rest durch den Divisor teilbar ist.
    ' Die interne Funktion führt die eigentliche Berechnung durch und gibt das Ergebnis zurück.
    Return InternalIsDivisibleBy(sender, Divisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene UShort-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UShort-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As UShort, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Integer-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Integer-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Integer, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene UInteger-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UInteger-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As UInteger, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Long-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Long-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Long, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene ULong-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende ULong-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As ULong, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Decimal-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Decimal-Wert.</param>
  ''' <param name="Dvisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Decimal, Dvisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Dvisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Single-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Single-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Single, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Double-Wert ohne Rest durch den angegebenen Divisor teilbar ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Double-Wert.</param>
  ''' <param name="Devisor">Der Divisor, durch den geteilt werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert teilbar ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsDivisibleBy(sender As Double, Devisor As Double) As Boolean
    ' Ruft die interne Funktion auf, um die Teilbarkeit zu überprüfen.
    Return InternalIsDivisibleBy(sender, Devisor)
  End Function

#End Region

#Region "Bestimmen ob ein Wert das vielfache von einem angegebenen Wert ist"

  ''' <summary>
  ''' Bestimmt, ob der Wert ein Vielfaches von <paramref name="value"/> ist.
  ''' </summary>
  ''' <param name="value">
  ''' Der Wert, dessen Vielfaches überprüft werden soll.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode verwendet die interne Funktion <see cref="InternalIsMultipleOf"/>, 
  ''' um die Berechnung und Prüfung durchzuführen.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Short, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der übergebene Wert ein Vielfaches des angegebenen Wertes ist.
    ' Die interne Funktion prüft, ob der Rest der Division von "sender" durch "value" gleich 0 ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene UShort-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UShort-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As UShort, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Integer-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Integer-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Integer, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene UInteger-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UInteger-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As UInteger, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Long-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Long-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Long, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene ULong-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende ULong-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As ULong, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Decimal-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Decimal-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Decimal, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Single-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Single-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Single, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

  ''' <summary>
  ''' Überprüft, ob der übergebene Double-Wert ein Vielfaches des angegebenen Wertes ist.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Double-Wert.</param>
  ''' <param name="value">Der Wert, dessen Vielfaches überprüft werden soll.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert ein Vielfaches ist, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsMultipleOf(sender As Double, value As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert ein Vielfaches des angegebenen Wertes ist.
    Return InternalIsMultipleOf(sender, value)
  End Function

#End Region

#Region "Bestimmen ob ein Wert im Bereich innerhalb von Minimum und Maximum liegt"

  ''' <summary>
  ''' Bestimmt, ob der Wert im Bereich der angegebenen 
  ''' <paramref name="min"/>- und <paramref name="max"/>-Werte liegt.
  ''' </summary>
  ''' <param name="min">
  ''' Der Mindestwert des Bereichs.
  ''' </param>
  ''' <param name="max">
  ''' Der Maximalwert des Bereichs.
  ''' </param>
  ''' <returns>
  ''' <see langword="True"/> wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Short, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert innerhalb des angegebenen Bereichs liegt.
    ' Die interne Funktion prüft, ob der Wert größer oder gleich dem Mindestwert (min) 
    ' und kleiner oder gleich dem Maximalwert (max) ist.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene UShort-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UShort-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As UShort, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene Integer-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Integer-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Integer, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene UInteger-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende UInteger-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As UInteger, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene Long-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Long-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Long, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene ULong-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende ULong-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As ULong, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene Decimal-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Decimal-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Decimal, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene Single-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Single-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Single, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

  ''' <summary>
  ''' Überprüft, ob der angegebene Double-Wert innerhalb des angegebenen Bereichs liegt.
  ''' </summary>
  ''' <param name="sender">Der zu überprüfende Double-Wert.</param>
  ''' <param name="min">Der Mindestwert des Bereichs.</param>
  ''' <param name="max">Der Maximalwert des Bereichs.</param>
  ''' <returns>Gibt <see langword="True"/> zurück, wenn der Wert im Bereich liegt, andernfalls <see langword="False"/>.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function IsInRangeOf(sender As Double, min As Double, max As Double) As Boolean
    ' Ruft die interne Funktion auf, um zu überprüfen, ob der Wert im Bereich liegt.
    Return InternalIsInRangeOf(sender, min, max)
  End Function

#End Region

#Region "Die Differenz zwischen dem Wert und einem angegebenen Wert bestimmen"

  ''' <summary>
  ''' Gibt die Differenz zwischen dem Wert und <paramref name="value"/> zurück.
  ''' </summary>
  ''' <param name="value">
  ''' Der Wert, mit dem die Differenz berechnet wird.
  ''' </param>
  ''' <returns>
  ''' Die berechnete Differenz zwischen dem Quellwert und dem angegebenen Wert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Short, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As UShort, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Integer, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As UInteger, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Long, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As ULong, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Decimal, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Single, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

  ''' <summary>
  ''' Berechnet die Differenz zwischen dem aktuellen Wert und einem angegebenen Wert.
  ''' </summary>
  ''' <param name="sender">Der aktuelle Wert, von dem die Differenz berechnet wird.</param>
  ''' <param name="value">Der Vergleichswert, mit dem die Differenz berechnet wird.</param>
  ''' <returns>Die berechnete Differenz als Double.</returns>
  <DebuggerStepThrough> <Extension>
  Public Function DifferenceOf(sender As Double, value As Double) As Double
    ' Ruft die interne Funktion auf, um die Differenz zu berechnen.
    Return InternalDifferenceOf(sender, value)
  End Function

#End Region

#Region "Einen Wert in seine literale hexadezimale Visual Basic-Darstellung konvertieren"

  ''' <summary>
  ''' Konvertiert einen Byte-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Byte-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Der Hexadezimalwert.
  ''' </returns>
  ''' <remarks>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert darstellt.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As Byte) As String
    ' Konvertiert den Byte-Wert in eine hexadezimale Zeichenfolge und formatiert sie
    ' mit "&H" als Präfix. Die Ausgabe wird in Großbuchstaben dargestellt.
    Return String.Format("&H{0}", Convert.ToString(sender, 16).ToUpper())
  End Function

  ''' <summary>
  ''' Konvertiert einen Short-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Short-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Suffix "S" darstellt.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As Short) As String
    ' Konvertiert den Short-Wert in eine hexadezimale Zeichenfolge und fügt das Suffix "S" hinzu.
    Return String.Format("&H{0}S", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen UShort-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der UShort-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Suffix "US" darstellt.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As UShort) As String
    ' Konvertiert den UShort-Wert in eine hexadezimale Zeichenfolge und fügt das Suffix "US" hinzu.
    Return String.Format("&H{0}US", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen Integer-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Integer-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Suffix "I" darstellt.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As Integer) As String
    ' Konvertiert den Integer-Wert in eine hexadezimale Zeichenfolge und fügt das Suffix "I" hinzu.
    Return String.Format("&H{0}I", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen UInteger-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der UInteger-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Suffix "UI" darstellt.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As UInteger) As String
    ' Konvertiert den UInteger-Wert in eine hexadezimale Zeichenfolge und fügt das Suffix "UI" hinzu.
    Return String.Format("&H{0}UI", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen Long-Wert in seine literale hexadezimale Visual Basic-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Long-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Suffix "L" darstellt.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function ToVBHex(sender As Long) As String
    ' Konvertiert den Long-Wert in eine hexadezimale Zeichenfolge und fügt das Suffix "L" hinzu.
    Return String.Format("&H{0}L", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

#End Region

#Region "Einen Wert in seine literale hexadezimale C#-Darstellung konvertieren"

  ''' <summary>
  ''' Konvertiert einen Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <returns>
  ''' Der Hexadezimalwert.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen Byte-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As Byte) As String
    ' Konvertiert den Byte-Wert in eine hexadezimale Zeichenfolge.
    ' Die Methode Convert.ToString(sender, 16) wandelt den Wert in eine Basis-16-Zeichenfolge um.
    ' Die Methode ToUpper() stellt sicher, dass die Buchstaben in Großbuchstaben dargestellt werden.
    ' String.Format fügt das Präfix "0x" hinzu, um die C#-Hexadezimaldarstellung zu erzeugen.
    Return String.Format("0x{0}", Convert.ToString(sender, 16).ToUpper())
  End Function

  ''' <summary>
  ''' Konvertiert einen Short-Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Short-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Präfix "0x" darstellt.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen Short-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As Short) As String
    ' Konvertiert den Short-Wert in eine hexadezimale Zeichenfolge und gibt sie mit dem Präfix "0x" zurück.
    Return String.Format("0x{0}", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen UShort-Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der UShort-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Präfix "0x" darstellt.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen UShort-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As UShort) As String
    ' Konvertiert den UShort-Wert in eine hexadezimale Zeichenfolge und gibt sie mit dem Präfix "0x" zurück.
    Return String.Format("0x{0}", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen Integer-Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Integer-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Präfix "0x" darstellt.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen Integer-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As Integer) As String
    ' Konvertiert den Integer-Wert in eine hexadezimale Zeichenfolge und gibt sie mit dem Präfix "0x" zurück.
    Return String.Format("0x{0}", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen UInteger-Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der UInteger-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Präfix "0x" und dem Suffix "U" darstellt.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen UInteger-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt und mit "U" endet, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As UInteger) As String
    ' Konvertiert den UInteger-Wert in eine hexadezimale Zeichenfolge und gibt sie mit dem Präfix "0x" und dem Suffix "U" zurück.
    Return String.Format("0x{0}U", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

  ''' <summary>
  ''' Konvertiert einen Long-Wert in seine literale hexadezimale C#-Darstellung.
  ''' </summary>
  ''' <param name="sender">
  ''' Der Long-Wert, der konvertiert werden soll.
  ''' </param>
  ''' <returns>
  ''' Eine Zeichenfolge, die den hexadezimalen Wert mit dem Präfix "0x" und dem Suffix "L" darstellt.
  ''' </returns>
  ''' <remarks>
  ''' Diese Methode formatiert den übergebenen Long-Wert als hexadezimale Zeichenfolge,
  ''' die mit "0x" beginnt und mit "L" endet, was der Konvention in C# entspricht.
  ''' </remarks>
  <DebuggerStepThrough> <Extension>
  Public Function ToCSharpHex(sender As Long) As String
    ' Konvertiert den Long-Wert in eine hexadezimale Zeichenfolge und gibt sie mit dem Präfix "0x" und dem Suffix "L" zurück.
    Return String.Format("0x{0}L", Convert.ToString(sender, toBase:=16).ToUpper)
  End Function

#End Region

#Region "Einen Wert in Abhängigkeit von der Kultur formatieren"

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur mit der angegebenen Genauigkeit der Dezimalstellen.
  ''' </summary>
  ''' <param name="precision">
  ''' Die Genauigkeit der Dezimalstellen.
  ''' </param>
  ''' <param name="culture">
  ''' Das Kulturformat.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Short, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, um den Wert zu formatieren.
    ' Übergibt den Wert (sender), die gewünschte Präzision (precision) und die Kultur (culture).
    ' Die interne Funktion kümmert sich um die eigentliche Formatierung des Wertes.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Short, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As UShort, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As UShort, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Integer, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Integer, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As UInteger, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As UInteger, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Long, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Long, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Decimal, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Decimal, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Double, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Double, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur und der angegebenen Präzision.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <param name="precision">
  ''' Die Anzahl der Dezimalstellen, die im formatierten Wert angezeigt werden sollen.
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Single, culture As Globalization.CultureInfo, precision As Integer) As String
    ' Ruft die interne Funktion auf, die die eigentliche Formatierung basierend auf den übergebenen Parametern durchführt.
    Return InternalFormatted(sender, precision, culture)
  End Function

  ''' <summary>
  ''' Formatiert einen Wert durch Platzieren von Punkten oder Kommas an den entsprechenden Positionen, 
  ''' abhängig von der angegebenen Kultur ohne Dezimalstellen.
  ''' </summary>
  ''' <param name="culture">
  ''' Das Kulturformat, das bestimmt, wie Zahlen formatiert werden (z. B. "de-DE" für Deutsch).
  ''' </param>
  ''' <returns>
  ''' Der formatierte Wert als Zeichenfolge.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Formatted(sender As Single, culture As Globalization.CultureInfo) As String
    ' Ruft die überladene Methode auf, die auch die Präzision (Anzahl der Dezimalstellen) akzeptiert,
    ' und setzt die Präzision standardmäßig auf 0.
    Return Formatted(sender, culture, 0)
  End Function

#End Region

#Region "leere oder nicht leere Elemente suchen"

  ''' <summary>
  ''' Zählt die leeren Elemente eines <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <returns>
  ''' Die Anzahl der leeren Elemente.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function CountEmptyItems(sender As IEnumerable(Of String)) As Integer
    ' Initialisiere die Zählvariable für leere Elemente
    Dim result As Integer = 0
    ' Iteriere durch jedes Element in der Sammlung
    For Each str As String In sender
      ' Überprüfe, ob das aktuelle Element leer oder nur aus Leerzeichen besteht
      If String.IsNullOrEmpty(str) OrElse String.IsNullOrWhiteSpace(str) Then
        ' Erhöhe den Zähler, wenn das Element leer ist
        result += 1
      End If
    Next
    ' Gib die Gesamtanzahl der leeren Elemente zurück
    Return result
  End Function

  ''' <summary>
  ''' Zählt die nicht leeren Elemente eines <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <returns>
  ''' Die Anzahl der nicht leeren Elemente.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function CountNonEmptyItems(sender As IEnumerable(Of String)) As Integer
    ' Initialisiere eine Variable, um die Anzahl der nicht leeren Elemente zu speichern
    Dim result As Integer = 0
    ' Iteriere durch jedes Element in der übergebenen Sammlung
    For Each str As String In sender
      ' Überprüfe, ob das aktuelle Element weder null noch leer ist und keine Leerzeichen enthält
      If Not String.IsNullOrEmpty(str) AndAlso Not String.IsNullOrWhiteSpace(str) Then
        ' Erhöhe den Zähler für nicht leere Elemente
        result += 1
      End If
    Next
    ' Gib die Gesamtanzahl der nicht leeren Elemente zurück
    Return result
  End Function

#End Region

#Region "Elemente nach Muster suchen"

  ''' <summary>
  ''' Findet die Elemente, die genau gleich der angegebenen Zeichenfolge in der Quelle sind <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <param name="stringComparison">
  ''' Die Zeichenfolgenvergleichsregel, die angibt, wie die Zeichenfolgen verglichen werden sollen (z. B. Groß-/Kleinschreibung beachten oder nicht).
  ''' </param>
  ''' <returns>
  ''' Die gefundenen Elemente als <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FindExact(sender As IEnumerable(Of String), searchString As String, stringComparison As StringComparison) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der Suche speichert.
    Dim result As IEnumerable(Of String)
    ' Verwendet eine LINQ-Abfrage, um alle Elemente in der Sammlung zu finden, 
    ' die genau mit der angegebenen Zeichenfolge übereinstimmen, basierend auf der Vergleichsregel.
    result = From str As String In sender Where str.Equals(searchString, stringComparison)
    ' Gibt die gefundenen Elemente zurück.
    Return result
  End Function

  ''' <summary>
  ''' Findet die Elemente, die die angegebene Zeichenfolge in der Quelle enthalten <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <param name="ignoreCase">
  ''' Wenn auf True gesetzt, wird ein nicht sensibler String-Case-Vergleich durchgeführt.
  ''' </param>
  ''' <returns>
  ''' Die gefundenen Elemente als <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FindByContains(sender As IEnumerable(Of String), searchString As String, ignoreCase As Boolean) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der Suche speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu finden, 
    ' die die angegebene Zeichenfolge enthalten. Der Vergleich kann optional 
    ' groß-/kleinschreibungsunabhängig sein, basierend auf dem Parameter "ignoreCase".
    result = From str As String In sender Where If(ignoreCase, str.ToLower.Contains(searchString.ToLower), str.Contains(searchString))
    ' Gibt die gefundenen Elemente zurück.
    Return result
  End Function

  ''' <summary>
  ''' Findet die Elemente, die die angegebene Zeichenfolge in der Quelle enthalten <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <returns>
  ''' Die gefundenen Elemente als <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FindByContains(sender As IEnumerable(Of String), searchString As String) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der Suche speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu finden,
    ' die die angegebene Zeichenfolge enthalten. Der Vergleich ist standardmäßig
    ' groß-/kleinschreibungsabhängig, da der zweite Parameter von If auf False gesetzt ist.
    result = From str As String In sender Where If(False, str.ToLower.Contains(searchString.ToLower), str.Contains(searchString))
    ' Gibt die gefundenen Elemente zurück.
    Return result
  End Function

  ''' <summary>
  ''' Führt eine Zeichenkettenähnliche Mustersuche in der Quelle <see cref="IEnumerable(Of String)"/> 
  ''' durch und gibt alle Übereinstimmungen zurück.
  ''' </summary>
  ''' <param name="likePattern">
  ''' Der mit dem <see langword="Like"/>-Operator zu verwendende Mustervergleich.
  ''' </param>
  ''' <param name="ignoreCase">
  ''' Wenn auf True gesetzt, wird ein nicht sensibler String-Case-Vergleich durchgeführt.
  ''' </param>
  ''' <returns>
  ''' Die gefundenen Elemente als <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FindByLike(sender As IEnumerable(Of String), likePattern As String, ignoreCase As Boolean) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der Suche speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu finden,
    ' die dem angegebenen Muster entsprechen. Der Vergleich kann optional
    ' groß-/kleinschreibungsunabhängig sein, basierend auf dem Parameter "ignoreCase".
    result = From str As String In sender Where If(ignoreCase, str.ToLower Like likePattern.ToLower, str Like likePattern)
    ' Gibt die gefundenen Elemente zurück.
    Return result
  End Function

  ''' <summary>
  ''' Führt eine Zeichenkettenähnliche Mustersuche in der Quelle <see cref="IEnumerable(Of String)"/> 
  ''' durch und gibt alle Übereinstimmungen zurück.
  ''' </summary>
  ''' <param name="likePattern">
  ''' Der mit dem <see langword="Like"/>-Operator zu verwendende Mustervergleich.
  ''' </param>
  ''' <returns>
  ''' Die gefundenen Elemente als <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function FindByLike(sender As IEnumerable(Of String), likePattern As String) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der Suche speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu finden,
    ' die dem angegebenen Muster entsprechen. Der Vergleich ist standardmäßig
    ' groß-/kleinschreibungsabhängig, da der zweite Parameter von If auf False gesetzt ist.
    result = From str As String In sender Where If(False, str.ToLower Like likePattern.ToLower, str Like likePattern)
    ' Gibt die gefundenen Elemente zurück.
    Return result
  End Function

#End Region

#Region "Element sortieren"

  ''' <summary>
  ''' Sortiert die Quelle <see cref="IEnumerable(Of String)"/> nach der Bubble-Sort-Methode.
  ''' </summary>
  ''' <returns>
  ''' Die sortierten Elemente als <see cref="IEnumerable(Of T)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function BubbleSort(sender As IEnumerable(Of String)) As IEnumerable(Of String)
    ' Wendet eine Transformation auf jedes Element der Sammlung an, um eine sortierbare Struktur zu erstellen.
    Return sender.Select(
      Function(value As String)
        ' Erstellt ein anonymes Objekt mit dem Originalwert und einem sortierbaren Schlüssel.
        Return New With {
                 Key .OrgStr = value, ' Originalzeichenfolge
                 Key .SortStr = ' Sortierschlüssel
                 Text.RegularExpressions.Regex.Replace(
                 value, "(\d+)|(\D+)", ' Teilt die Zeichenfolge in numerische und nicht-numerische Teile auf.
                 Function(match As Text.RegularExpressions.Match)
                   ' Formatiert jeden Teil so, dass numerische Teile mit Leerzeichen aufgefüllt werden
                   ' und nicht-numerische Teile mit dem maximalen Zeichenwert.
                   Return match.Value.PadLeft(
                   sender.Select(
                    Function(str As String)
                      Return str.Length ' Ermittelt die maximale Länge der Zeichenfolgen in der Sammlung.
                    End Function
                  ).Max, If(Char.IsDigit(match.Value(0)), " "c, Char.MaxValue))
                 End Function)
        }
      End Function).OrderBy(Function(anon) anon.SortStr).Select(Function(anon) anon.OrgStr)
    ' Sortiert die anonymen Objekte nach dem Sortierschlüssel und gibt die Originalzeichenfolgen zurück.
  End Function

#End Region

#Region "Elemente nach Muster entfernen"

  ''' <summary>
  ''' Entfernt die Elemente, die genau gleich der angegebenen Zeichenfolge in der Quelle sind <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <param name="stringComparison">
  ''' Die Zeichenfolgenvergleichsregel, die angibt, wie die Zeichenfolgen verglichen werden sollen (z. B. Groß-/Kleinschreibung beachten oder nicht).
  ''' </param>
  ''' <returns>
  ''' Die übrigen Elemente in <see cref="IEnumerable(Of String)"/>, die nicht mit der angegebenen Zeichenfolge übereinstimmen.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function RemoveExact(sender As IEnumerable(Of String), searchString As String, stringComparison As StringComparison) As IEnumerable(Of String)
    ' Verwendet eine LINQ-Abfrage, um alle Elemente in der Sammlung zu filtern,
    ' die nicht genau mit der angegebenen Zeichenfolge übereinstimmen.
    ' Die Vergleichsregel wird durch den Parameter "stringComparison" bestimmt.
    Return From value As String In sender Where Not value.Equals(searchString, stringComparison)
  End Function

  ''' <summary>
  ''' Entfernt die Elemente, die die angegebene Zeichenfolge in der Quelle enthalten <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <param name="ignoreCase">
  ''' Standardmässig wird ein nicht sensibler String-Case-Vergleich durchgeführt.
  ''' </param>
  ''' <returns>
  ''' Die übrigen Elemente in <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function RemoveByContains(sender As IEnumerable(Of String), searchString As String, ignoreCase As Boolean) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der gefilterten Sammlung speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu filtern.
    ' Wenn "ignoreCase" True ist, wird ein groß-/kleinschreibungsunabhängiger Vergleich durchgeführt.
    ' Andernfalls wird ein groß-/kleinschreibungsabhängiger Vergleich verwendet.
    result = From str As String In sender Where If(ignoreCase, Not str.ToLower.Contains(searchString.ToLower), Not str.Contains(searchString))
    ' Gibt die gefilterte Sammlung zurück, die keine Elemente enthält, die die Suchzeichenfolge enthalten.
    Return result
  End Function

  ''' <summary>
  ''' Entfernt die Elemente, die die angegebene Zeichenfolge in der Quelle enthalten <see cref="IEnumerable(Of String)"/>.
  ''' </summary>
  ''' <param name="searchString">
  ''' Die Zeichenfolge, nach der gesucht werden soll.
  ''' </param>
  ''' <returns>
  ''' Die übrigen Elemente in <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function RemoveByContains(sender As IEnumerable(Of String), searchString As String) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der gefilterten Sammlung speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu filtern.
    ' Überprüft, ob die Elemente die Suchzeichenfolge enthalten.
    ' Wenn die Zeichenfolge enthalten ist, wird das Element ausgeschlossen.
    ' Der Vergleich ist standardmäßig groß-/kleinschreibungsabhängig.
    result = From str As String In sender Where If(False, Not str.ToLower.Contains(searchString.ToLower), Not str.Contains(searchString))
    ' Gibt die gefilterte Sammlung zurück, die keine Elemente enthält, die die Suchzeichenfolge enthalten.
    Return result
  End Function

  ''' <summary>
  ''' Führt eine Zeichenkettenähnliche Mustersuche in der Quelle <see cref="IEnumerable(Of String)"/> durch und entfernt alle Übereinstimmungen.
  ''' </summary>
  ''' <param name="likePattern">
  ''' Der mit dem <see langword="Like"/>-Operator zu verwendende Mustervergleich.
  ''' </param>
  ''' <param name="ignoreCase">
  ''' Standardmässig wird ein nicht sensibler String-Case-Vergleich durchgeführt.
  ''' </param>
  ''' <returns>
  ''' Die übrigen Elemente in <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function RemoveByLike(sender As IEnumerable(Of String), likePattern As String, ignoreCase As Boolean) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der gefilterten Sammlung speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu filtern.
    ' Wenn "ignoreCase" True ist, wird ein groß-/kleinschreibungsunabhängiger Vergleich durchgeführt.
    ' Andernfalls wird ein groß-/kleinschreibungsabhängiger Vergleich verwendet.
    result = From str As String In sender Where If(ignoreCase, Not str.ToLower Like likePattern.ToLower, Not str Like likePattern)
    ' Gibt die gefilterte Sammlung zurück, die keine Elemente enthält, die dem Muster entsprechen.
    Return result
  End Function

  ''' <summary>
  ''' Führt eine Zeichenkettenähnliche Mustersuche in der Quelle <see cref="IEnumerable(Of String)"/> durch und entfernt alle Übereinstimmungen.
  ''' </summary>
  ''' <param name="likePattern">
  ''' Der mit dem <see langword="Like"/>-Operator zu verwendende Mustervergleich.
  ''' </param>
  ''' <returns>
  ''' Die übrigen Elemente in <see cref="IEnumerable(Of String)"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function RemoveByLike(sender As IEnumerable(Of String), likePattern As String) As IEnumerable(Of String)
    ' Deklariert eine Variable, die die Ergebnisse der gefilterten Sammlung speichert.
    Dim result As IEnumerable(Of String)
    ' Führt eine LINQ-Abfrage aus, um alle Elemente in der Sammlung zu filtern.
    ' Überprüft, ob die Elemente dem angegebenen Muster entsprechen.
    ' Wenn ein Element dem Muster entspricht, wird es ausgeschlossen.
    ' Der Vergleich ist standardmäßig groß-/kleinschreibungsabhängig.
    result = From str As String In sender Where If(False, Not str.ToLower Like likePattern.ToLower, Not str Like likePattern)
    ' Gibt die gefilterte Sammlung zurück, die keine Elemente enthält, die dem Muster entsprechen.
    Return result
  End Function

#End Region

#Region "Anzahl der Elemente ändern"

  ''' <summary>
  ''' Ändert die Anzahl der Elemente eines <see cref="Array"/>.
  ''' </summary>
  ''' <param name="NewSize">
  ''' Die neue Größe des <see cref="Array"/>.
  ''' </param>
  ''' <returns>
  ''' Das in der Größe geänderte <see cref="Array"/>.
  ''' </returns>
  <DebuggerStepThrough> <Extension>
  Public Function Resize(Of T)(sender As T(), NewSize As Integer) As T()
    ' Bestimme die minimale Länge zwischen der aktuellen Array-Länge und der neuen Größe
    Dim minLength As Integer = Math.Min(sender.Length, NewSize)
    ' Wenn die minimale Länge größer als 0 ist, erstelle ein neues Array und kopiere die Werte
    If minLength > 0 Then
      ' Erstelle ein neues Array mit der angegebenen neuen Größe
      Dim newArray As Array = Array.CreateInstance(sender.GetType.GetElementType, NewSize)
      ' Kopiere die Elemente vom alten Array in das neue Array bis zur minimalen Länge
      Array.Copy(sender, newArray, minLength)
      ' Gib das neue Array zurück, gecastet auf den ursprünglichen Typ
      Return DirectCast(newArray, T())
    Else
      ' Wenn die minimale Länge 0 oder kleiner ist, gib das ursprüngliche Array zurück
      Return sender
    End If
  End Function

#End Region


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
  Private Function InternalFormatted(sender As Double, precision As Integer, culture As Globalization.CultureInfo) As String
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
  Private Function InternalGetPercentageOf(value As Double, total As Double) As Double
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
  Private Function InternalFractionBy(value As Double, percent As Double) As Double
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
  Private Function InternalIsPositive(value As Double) As Boolean
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
  Private Function InternalIsNegative(value As Double) As Boolean
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
  Private Function InternalIsPrime(value As Long) As Boolean
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
  Private Function InternalIsDivisibleBy(source As Double, value As Double) As Boolean
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
  Private Function InternalIsMultipleOf(source As Double, value As Double) As Boolean
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
  Private Function InternalIsInRangeOf(source As Double, minimum As Double, maximum As Double) As Boolean
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
  Private Function InternalDifferenceOf(source As Double, value As Double) As Double
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