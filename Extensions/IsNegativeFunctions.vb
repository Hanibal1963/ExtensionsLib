' *************************************************************************************************
' 
' IsNegativeFunctions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definition der Funktionen zum Bestimmen ob ein Wert negativ ist
''' </summary>
Public Module IsNegativeFunctions


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
End Module
