' *************************************************************************************************
' 
' IsPrimeFunctions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definition der Funktionen zum Bestimmen ob ein Wert eine Primzahl ist
''' </summary>
Public Module IsPrimeFunctions

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
End Module
