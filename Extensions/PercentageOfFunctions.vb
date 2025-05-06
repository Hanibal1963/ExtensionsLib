' *************************************************************************************************
' 
' PercentageOfFunctions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definition der Funktionen um den Prozentsatz eines Wertes 
''' von einem Gesamtwert berechnen
''' </summary>
Public Module PercentageOfFunctions

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

End Module
