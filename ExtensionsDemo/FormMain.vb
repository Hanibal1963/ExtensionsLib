' *************************************************************************************************
' 
' FormMain.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Public Class FormMain

  Private WithEvents AboutDialog As New AboutBox

  Private Sub MainMenuItem_Click(sender As Object, e As EventArgs) Handles _
    MenuItemBeenden.Click, MenuItemÜber.Click,
    MenuItemPercentageOf.Click, MenuItemFractionBy.Click,
    MenuItemSignTest.Click, MenuItemIsPrime.Click,
    MenuItemDivisibility.Click, MenuItemMultiples.Click,
    MenuItemIsInRangeOf.Click, MenuItemDifferenceOf.Click,
    MenuItemHexadecimalConversion.Click, MenuItemFormatted.Click,
    MenuItemStringCollections.Click

    ' welches Menü wurde angeklickt
    Select Case True

      Case sender Is Me.MenuItemBeenden : Me.Close()
      Case sender Is Me.MenuItemÜber : Dim unused = Me.AboutDialog.ShowDialog(Me)
      Case sender Is Me.MenuItemPercentageOf : Me.TabControl.SelectTab($"TabPagePercentageOf")
      Case sender Is Me.MenuItemFractionBy : Me.TabControl.SelectTab($"TabPageFractionBy")
      Case sender Is Me.MenuItemSignTest : Me.TabControl.SelectTab($"TabPageSignTest")
      Case sender Is Me.MenuItemIsPrime : Me.TabControl.SelectTab($"TabPageIsPrime")
      Case sender Is Me.MenuItemDivisibility : Me.TabControl.SelectTab($"TabPageDivisibility")
      Case sender Is Me.MenuItemMultiples : Me.TabControl.SelectTab($"TabPageMultiples")
      Case sender Is Me.MenuItemIsInRangeOf : Me.TabControl.SelectTab($"TabPageIsInRangeOf")
      Case sender Is Me.MenuItemDifferenceOf : Me.TabControl.SelectTab($"TabPageDifferenceOf")
      Case sender Is Me.MenuItemHexadecimalConversion : Me.TabControl.SelectTab($"TabPageHexadecimalConversion")
      Case sender Is Me.MenuItemFormatted : Me.TabControl.SelectTab($"TabPageFormatted")
      Case sender Is Me.MenuItemStringCollections : Me.TabControl.SelectTab($"TabPageStringCollections")

    End Select

  End Sub

  Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl.Selected

    ' welche Registerkarte wurde aktiviert
    Select Case True

      Case e.TabPage Is Me.TabPagePercentageOf
        Me.PercentageOfControl.Dock = DockStyle.Fill
        Me.PercentageOfControl.Start()

      Case e.TabPage Is Me.TabPageFractionBy
        Me.FractionByControl.Dock = DockStyle.Fill
        Me.FractionByControl.Start()

      Case e.TabPage Is Me.TabPageSignTest
        Me.SignTestControl.Dock = DockStyle.Fill
        Me.SignTestControl.Start()

      Case e.TabPage Is Me.TabPageIsPrime
        Me.IsPrimeControl.Dock = DockStyle.Fill
        Me.IsPrimeControl.Start()

      Case e.TabPage Is Me.TabPageDivisibility
        Me.IsDivisibleByControl.Dock = DockStyle.Fill
        Me.IsDivisibleByControl.Start()

      Case e.TabPage Is Me.TabPageMultiples
        Me.IsMultipleOfControl.Dock = DockStyle.Fill
        Me.IsMultipleOfControl.Start()

      Case e.TabPage Is Me.TabPageIsInRangeOf
        Me.IsInRangeOfControl.Dock = DockStyle.Fill
        Me.IsInRangeOfControl.Start()

      Case e.TabPage Is Me.TabPageDifferenceOf
        Me.DifferenceOfControl.Dock = DockStyle.Fill
        Me.DifferenceOfControl.Start()

      Case e.TabPage Is Me.TabPageHexadecimalConversion
        Me.HexadecimalConversionControl.Dock = DockStyle.Fill
        Me.HexadecimalConversionControl.Start()

      Case e.TabPage Is Me.TabPageFormatted

      Case e.TabPage Is Me.TabPageStringCollections

    End Select

  End Sub

  Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    ' aktiviert beim erstmaligem anzeigen des Fensters die erste Registerkarte
    Me.TabControl.SelectTab($"TabPagePercentageOf")
    Me.PercentageOfControl.Dock = DockStyle.Fill
    Me.PercentageOfControl.Start()

  End Sub

End Class
