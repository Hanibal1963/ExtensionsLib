' *************************************************************************************************
' 
' FormMain.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Public Class FormMain

  Private Sub MainMenuItem_Click(sender As Object, e As EventArgs) Handles _
    MenuItemBeenden.Click, MenuItemÜber.Click,
    MenuItemPercentageOf.Click, MenuItemFractionBy.Click,
    MenuItemSignTest.Click, MenuItemIsPrime.Click,
    MenuItemDivisibilityAndMultiples.Click, MenuItemIsInRangeOf.Click,
    MenuItemDifferenceOf.Click, MenuItemHexadecimalConversion.Click,
    MenuItemFormatted.Click, MenuItemStringCollections.Click

    Select Case True
      Case sender Is Me.MenuItemBeenden : Me.Close()
      Case sender Is Me.MenuItemÜber : Me.ShowAboutDialog()
      Case sender Is Me.MenuItemPercentageOf : Me.TabControl.SelectTab($"TabPagePercentageOf")
      Case sender Is Me.MenuItemFractionBy : Me.TabControl.SelectTab($"TabPageFractionBy")
      Case sender Is Me.MenuItemSignTest : Me.TabControl.SelectTab($"TabPageSignTest")
      Case sender Is Me.MenuItemIsPrime : Me.TabControl.SelectTab($"TabPageIsPrime")
      Case sender Is Me.MenuItemDivisibilityAndMultiples : Me.TabControl.SelectTab($"TabPageDivisibilityAndMultiples")
      Case sender Is Me.MenuItemIsInRangeOf : Me.TabControl.SelectTab($"TabPageIsInRangeOf")
      Case sender Is Me.MenuItemDifferenceOf : Me.TabControl.SelectTab($"TabPageDifferenceOf")
      Case sender Is Me.MenuItemHexadecimalConversion : Me.TabControl.SelectTab($"TabPageHexadecimalConversion")
      Case sender Is Me.MenuItemFormatted : Me.TabControl.SelectTab($"TabPageFormatted")
      Case sender Is Me.MenuItemStringCollections : Me.TabControl.SelectTab($"TabPageStringCollections")
    End Select

  End Sub

  Private Sub TabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl.Selected

    Select Case True
      Case e.TabPage Is Me.TabPagePercentageOf
        Me.PercentageOfControl.Dock = DockStyle.Fill
        Me.PercentageOfControl.Start()
      Case e.TabPage Is Me.TabPageFractionBy
        Me.FractionByControl.Dock = DockStyle.Fill
        Me.FractionByControl.Start()
      Case e.TabPage Is Me.TabPageSignTest
      Case e.TabPage Is Me.TabPageIsPrime
      Case e.TabPage Is Me.TabPageDivisibilityAndMultiples
      Case e.TabPage Is Me.TabPageIsInRangeOf
      Case e.TabPage Is Me.TabPageDifferenceOf
      Case e.TabPage Is Me.TabPageHexadecimalConversion
      Case e.TabPage Is Me.TabPageFormatted
      Case e.TabPage Is Me.TabPageStringCollections
    End Select

  End Sub

  Private Sub ShowAboutDialog()

    MsgBox($"Funktion noch nicht implementiert.")

  End Sub

  Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    Me.TabControl.SelectTab($"TabPagePercentageOf")
    Me.PercentageOfControl.Dock = DockStyle.Fill
    Me.PercentageOfControl.Start()
  End Sub

End Class
