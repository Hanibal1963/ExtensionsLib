' *************************************************************************************************
' 
' DataExtensions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Runtime.CompilerServices
Imports SchlumpfSoft.Extensions.InternalFunctions

''' <summary>
''' Definition der Funktionen um den Bruchteil eines Wertes zu berechnen
''' </summary>
Module FractionByFunctions

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

End Module
