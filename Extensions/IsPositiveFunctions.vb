' *************************************************************************************************
' 
' IsPositiveFunctions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definitionen der Funktionen zum Bestimmen ob ein Wert positiv ist
''' </summary>
Module IsPositiveFunctions


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
End Module
