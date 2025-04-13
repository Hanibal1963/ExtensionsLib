' *************************************************************************************************
' 
' TestClass.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports SchlumpfSoft.Extensions.DataExtensions

<TestClass>
Public Class TestClass

  <TestMethod>
  Public Sub Test_PercentageOf()
    Dim value As Integer = 50
    Dim total As Integer = 200
    Dim expected As Double = 25.0
    Dim result As Double = value.PercentageOf(total)
    Assert.AreEqual(expected, result, "PercentageOf hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_FractionBy()
    Dim value As Integer = 200
    Dim percentage As Double = 25.0
    Dim expected As Double = 50.0
    Dim result As Double = value.FractionBy(percentage)
    Assert.AreEqual(expected, result, "FractionBy hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsPositive()
    Dim value As Integer = 10
    Assert.IsTrue(value.IsPositive(), "IsPositive hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsNegative()
    Dim value As Integer = -10
    Assert.IsTrue(value.IsNegative(), "IsNegative hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsPrime()
    Dim value As Integer = 7
    Assert.IsTrue(value.IsPrime(), "IsPrime hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsDivisibleBy()
    Dim value As Integer = 10
    Dim divisor As Integer = 2
    Assert.IsTrue(value.IsDivisibleBy(divisor), "IsDivisibleBy hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsMultipleOf()
    Dim value As Integer = 10
    Dim multiple As Integer = 5
    Assert.IsTrue(value.IsMultipleOf(multiple), "IsMultipleOf hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_IsInRangeOf()
    Dim value As Integer = 5
    Dim min As Integer = 1
    Dim max As Integer = 10
    Assert.IsTrue(value.IsInRangeOf(min, max), "IsInRangeOf hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_DifferenceOf()
    Dim value As Integer = 10
    Dim otherValue As Integer = 5
    Dim expected As Double = 5.0
    Dim result As Double = value.DifferenceOf(otherValue)
    Assert.AreEqual(expected, result, "DifferenceOf hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_ToVBHex()
    Dim value As Byte = 255
    Dim expected As String = "&HFF"
    Dim result As String = value.ToVBHex()
    Assert.AreEqual(expected, result, "ToVBHex hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_ToCSharpHex()
    Dim value As Byte = 255
    Dim expected As String = "0xFF"
    Dim result As String = value.ToCSharpHex()
    Assert.AreEqual(expected, result, "ToCSharpHex hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_CountEmptyItems()
    Dim items As IEnumerable(Of String) = {"", " ", Nothing, "Test"}
    Dim expected As Integer = 3
    Dim result As Integer = items.CountEmptyItems()
    Assert.AreEqual(expected, result, "CountEmptyItems hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_CountNonEmptyItems()
    Dim items As IEnumerable(Of String) = {"", " ", Nothing, "Test"}
    Dim expected As Integer = 1
    Dim result As Integer = items.CountNonEmptyItems()
    Assert.AreEqual(expected, result, "CountNonEmptyItems hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_FindExact()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Test"}
    Dim searchString As String = "Test"
    Dim result As IEnumerable(Of String) = items.FindExact(searchString, StringComparison.Ordinal)
    Assert.AreEqual(2, result.Count(), "FindExact hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_FindByContains()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Testing"}
    Dim searchString As String = "Test"
    Dim result As IEnumerable(Of String) = items.FindByContains(searchString)
    Assert.AreEqual(2, result.Count(), "FindByContains hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_BubbleSort()
    Dim items As IEnumerable(Of String) = {"Banana", "Apple", "Cherry"}
    Dim expected As IEnumerable(Of String) = {"Apple", "Banana", "Cherry"}
    Dim result As IEnumerable(Of String) = items.BubbleSort()
    CollectionAssert.AreEqual(expected.ToList(), result.ToList(), "BubbleSort hat nicht das erwartete Ergebnis geliefert.")
  End Sub
  <TestMethod>
  Public Sub Test_FindByLike()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Testing"}
    Dim pattern As String = "Test*"
    Dim result As IEnumerable(Of String) = items.FindByLike(pattern, ignoreCase:=True)
    Assert.AreEqual(2, result.Count(), "FindByLike hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_RemoveExact()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Test"}
    Dim searchString As String = "Test"
    Dim result As IEnumerable(Of String) = items.RemoveExact(searchString, StringComparison.Ordinal)
    Assert.AreEqual(1, result.Count(), "RemoveExact hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_RemoveByContains()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Testing"}
    Dim searchString As String = "Test"
    Dim result As IEnumerable(Of String) = items.RemoveByContains(searchString, ignoreCase:=True)
    Assert.AreEqual(1, result.Count(), "RemoveByContains hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_RemoveByLike()
    Dim items As IEnumerable(Of String) = {"Test", "Example", "Testing"}
    Dim pattern As String = "Test*"
    Dim result As IEnumerable(Of String) = items.RemoveByLike(pattern, ignoreCase:=True)
    Assert.AreEqual(1, result.Count(), "RemoveByLike hat nicht das erwartete Ergebnis geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_Resize()
    Dim array As Integer() = {1, 2, 3, 4, 5}
    Dim newSize As Integer = 3
    Dim result As Integer() = array.Resize(newSize)
    Assert.AreEqual(newSize, result.Length, "Resize hat nicht die erwartete Größe geliefert.")
    CollectionAssert.AreEqual({1, 2, 3}, result, "Resize hat nicht die erwarteten Elemente geliefert.")
  End Sub

  <TestMethod>
  Public Sub Test_Formatted()
    Dim value As Double = 1234.5678
    Dim culture As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Dim precision As Integer = 2
    Dim result As String = value.Formatted(culture, precision)
    Assert.AreEqual("1234.57", result, "Formatted hat nicht das erwartete Ergebnis geliefert.")
  End Sub

End Class
