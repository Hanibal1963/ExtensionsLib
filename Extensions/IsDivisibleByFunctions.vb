' *************************************************************************************************
' 
' IsDivisibleByFunctions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definition der Funktionen zum Bestimmen ob ein Wert 
''' durch einen angegebenen Wert teilbar ist
''' </summary>
Public Module IsDivisibleByFunctions

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
End Module
