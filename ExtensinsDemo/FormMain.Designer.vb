<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
  Inherits System.Windows.Forms.Form

  'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Wird vom Windows Form-Designer benötigt.
  Private components As System.ComponentModel.IContainer

  'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
  'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
  'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim MainMenuItemDatei As System.Windows.Forms.ToolStripMenuItem
    Dim MainMenuItemAnsicht As System.Windows.Forms.ToolStripMenuItem
    Dim MainMenuItemHilfe As System.Windows.Forms.ToolStripMenuItem
    Me.MenuItemBeenden = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemPercentageOf = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemFractionBy = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemSignTest = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemIsPrime = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemDivisibility = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemMultiples = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemIsInRangeOf = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemDifferenceOf = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHexadecimalConversion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemFormatted = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemStringCollections = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemÜber = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPagePercentageOf = New System.Windows.Forms.TabPage()
        Me.PercentageOfControl = New SchlumpfSoft.ExtensionsDemo.PercentageOfControl()
        Me.TabPageFractionBy = New System.Windows.Forms.TabPage()
        Me.FractionByControl = New SchlumpfSoft.ExtensionsDemo.FractionByControl()
        Me.TabPageSignTest = New System.Windows.Forms.TabPage()
        Me.SignTestControl = New SchlumpfSoft.ExtensionsDemo.SignTestControl()
        Me.TabPageIsPrime = New System.Windows.Forms.TabPage()
        Me.IsPrimeControl = New SchlumpfSoft.ExtensionsDemo.IsPrimeControl()
        Me.TabPageDivisibility = New System.Windows.Forms.TabPage()
        Me.IsDivisibleByControl = New SchlumpfSoft.ExtensionsDemo.IsDivisibleByControl()
        Me.TabPageMultiples = New System.Windows.Forms.TabPage()
        Me.IsMultipleOfControl = New SchlumpfSoft.ExtensionsDemo.IsMultipleOfControl()
        Me.TabPageIsInRangeOf = New System.Windows.Forms.TabPage()
        Me.TabPageDifferenceOf = New System.Windows.Forms.TabPage()
        Me.TabPageHexadecimalConversion = New System.Windows.Forms.TabPage()
        Me.TabPageFormatted = New System.Windows.Forms.TabPage()
        Me.TabPageStringCollections = New System.Windows.Forms.TabPage()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.DifferenceOfControl = New SchlumpfSoft.ExtensionsDemo.DifferenceOfControl()
        Me.IsInRangeOfControl = New SchlumpfSoft.ExtensionsDemo.IsInRangeOfControl()
        MainMenuItemDatei = New System.Windows.Forms.ToolStripMenuItem()
        MainMenuItemAnsicht = New System.Windows.Forms.ToolStripMenuItem()
        MainMenuItemHilfe = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl.SuspendLayout()
        Me.TabPagePercentageOf.SuspendLayout()
        Me.TabPageFractionBy.SuspendLayout()
        Me.TabPageSignTest.SuspendLayout()
        Me.TabPageIsPrime.SuspendLayout()
        Me.TabPageDivisibility.SuspendLayout()
        Me.TabPageMultiples.SuspendLayout()
        Me.TabPageIsInRangeOf.SuspendLayout()
        Me.TabPageDifferenceOf.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenuItemDatei
        '
        MainMenuItemDatei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemBeenden})
        MainMenuItemDatei.Name = "MainMenuItemDatei"
        MainMenuItemDatei.Size = New System.Drawing.Size(46, 20)
        MainMenuItemDatei.Text = "Datei"
        '
        'MenuItemBeenden
        '
        Me.MenuItemBeenden.Name = "MenuItemBeenden"
        Me.MenuItemBeenden.Size = New System.Drawing.Size(120, 22)
        Me.MenuItemBeenden.Text = "Beenden"
        '
        'MainMenuItemAnsicht
        '
        MainMenuItemAnsicht.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemPercentageOf, Me.MenuItemFractionBy, Me.MenuItemSignTest, Me.MenuItemIsPrime, Me.MenuItemDivisibility, Me.MenuItemMultiples, Me.MenuItemIsInRangeOf, Me.MenuItemDifferenceOf, Me.MenuItemHexadecimalConversion, Me.MenuItemFormatted, Me.MenuItemStringCollections})
        MainMenuItemAnsicht.Name = "MainMenuItemAnsicht"
        MainMenuItemAnsicht.Size = New System.Drawing.Size(59, 20)
        MainMenuItemAnsicht.Text = "Ansicht"
        '
        'MenuItemPercentageOf
        '
        Me.MenuItemPercentageOf.Name = "MenuItemPercentageOf"
        Me.MenuItemPercentageOf.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemPercentageOf.Text = "Prozentsatzberechnungen"
        '
        'MenuItemFractionBy
        '
        Me.MenuItemFractionBy.Name = "MenuItemFractionBy"
        Me.MenuItemFractionBy.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemFractionBy.Text = "Bruchteilberechnungen"
        '
        'MenuItemSignTest
        '
        Me.MenuItemSignTest.Name = "MenuItemSignTest"
        Me.MenuItemSignTest.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemSignTest.Text = "Vorzeichentest"
        '
        'MenuItemIsPrime
        '
        Me.MenuItemIsPrime.Name = "MenuItemIsPrime"
        Me.MenuItemIsPrime.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemIsPrime.Text = "Primzahlprüfung"
        '
        'MenuItemDivisibility
        '
        Me.MenuItemDivisibility.Name = "MenuItemDivisibility"
        Me.MenuItemDivisibility.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemDivisibility.Text = "Teilbarkeitstest"
        '
        'MenuItemMultiples
        '
        Me.MenuItemMultiples.Name = "MenuItemMultiples"
        Me.MenuItemMultiples.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemMultiples.Text = "Vielfachestest"
        '
        'MenuItemIsInRangeOf
        '
        Me.MenuItemIsInRangeOf.Name = "MenuItemIsInRangeOf"
        Me.MenuItemIsInRangeOf.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemIsInRangeOf.Text = "Bereichsprüfung"
        '
        'MenuItemDifferenceOf
        '
        Me.MenuItemDifferenceOf.Name = "MenuItemDifferenceOf"
        Me.MenuItemDifferenceOf.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemDifferenceOf.Text = "Differenzberechnung"
        '
        'MenuItemHexadecimalConversion
        '
        Me.MenuItemHexadecimalConversion.Name = "MenuItemHexadecimalConversion"
        Me.MenuItemHexadecimalConversion.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemHexadecimalConversion.Text = "Hexadezimale Konvertierung"
        '
        'MenuItemFormatted
        '
        Me.MenuItemFormatted.Name = "MenuItemFormatted"
        Me.MenuItemFormatted.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemFormatted.Text = "Kulturabhängige Formatierung"
        '
        'MenuItemStringCollections
        '
        Me.MenuItemStringCollections.Name = "MenuItemStringCollections"
        Me.MenuItemStringCollections.Size = New System.Drawing.Size(237, 22)
        Me.MenuItemStringCollections.Text = "String-Sammlungen"
        '
        'MainMenuItemHilfe
        '
        MainMenuItemHilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemÜber})
        MainMenuItemHilfe.Name = "MainMenuItemHilfe"
        MainMenuItemHilfe.Size = New System.Drawing.Size(44, 20)
        MainMenuItemHilfe.Text = "Hilfe"
        '
        'MenuItemÜber
        '
        Me.MenuItemÜber.Name = "MenuItemÜber"
        Me.MenuItemÜber.Size = New System.Drawing.Size(206, 22)
        Me.MenuItemÜber.Text = "Über dieses Programm ..."
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPagePercentageOf)
        Me.TabControl.Controls.Add(Me.TabPageFractionBy)
        Me.TabControl.Controls.Add(Me.TabPageSignTest)
        Me.TabControl.Controls.Add(Me.TabPageIsPrime)
        Me.TabControl.Controls.Add(Me.TabPageDivisibility)
        Me.TabControl.Controls.Add(Me.TabPageMultiples)
        Me.TabControl.Controls.Add(Me.TabPageIsInRangeOf)
        Me.TabControl.Controls.Add(Me.TabPageDifferenceOf)
        Me.TabControl.Controls.Add(Me.TabPageHexadecimalConversion)
        Me.TabControl.Controls.Add(Me.TabPageFormatted)
        Me.TabControl.Controls.Add(Me.TabPageStringCollections)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(800, 426)
        Me.TabControl.TabIndex = 0
        '
        'TabPagePercentageOf
        '
        Me.TabPagePercentageOf.Controls.Add(Me.PercentageOfControl)
        Me.TabPagePercentageOf.Location = New System.Drawing.Point(4, 40)
        Me.TabPagePercentageOf.Name = "TabPagePercentageOf"
        Me.TabPagePercentageOf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePercentageOf.Size = New System.Drawing.Size(792, 382)
        Me.TabPagePercentageOf.TabIndex = 2
        Me.TabPagePercentageOf.Text = "Prozentsatzberechnung"
        Me.TabPagePercentageOf.UseVisualStyleBackColor = True
        '
        'PercentageOfControl
        '
        Me.PercentageOfControl.Location = New System.Drawing.Point(39, 38)
        Me.PercentageOfControl.Name = "PercentageOfControl"
        Me.PercentageOfControl.Size = New System.Drawing.Size(430, 253)
        Me.PercentageOfControl.TabIndex = 0
        '
        'TabPageFractionBy
        '
        Me.TabPageFractionBy.Controls.Add(Me.FractionByControl)
        Me.TabPageFractionBy.Location = New System.Drawing.Point(4, 40)
        Me.TabPageFractionBy.Name = "TabPageFractionBy"
        Me.TabPageFractionBy.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFractionBy.Size = New System.Drawing.Size(792, 382)
        Me.TabPageFractionBy.TabIndex = 3
        Me.TabPageFractionBy.Text = "Bruchteilberechnungen"
        Me.TabPageFractionBy.UseVisualStyleBackColor = True
        '
        'FractionByControl
        '
        Me.FractionByControl.Location = New System.Drawing.Point(24, 42)
        Me.FractionByControl.Name = "FractionByControl"
        Me.FractionByControl.Size = New System.Drawing.Size(428, 259)
        Me.FractionByControl.TabIndex = 0
        '
        'TabPageSignTest
        '
        Me.TabPageSignTest.Controls.Add(Me.SignTestControl)
        Me.TabPageSignTest.Location = New System.Drawing.Point(4, 40)
        Me.TabPageSignTest.Name = "TabPageSignTest"
        Me.TabPageSignTest.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSignTest.Size = New System.Drawing.Size(792, 382)
        Me.TabPageSignTest.TabIndex = 4
        Me.TabPageSignTest.Text = "Vorzeichentest"
        Me.TabPageSignTest.UseVisualStyleBackColor = True
        '
        'SignTestControl
        '
        Me.SignTestControl.Location = New System.Drawing.Point(81, 42)
        Me.SignTestControl.Name = "SignTestControl"
        Me.SignTestControl.Size = New System.Drawing.Size(387, 261)
        Me.SignTestControl.TabIndex = 0
        '
        'TabPageIsPrime
        '
        Me.TabPageIsPrime.Controls.Add(Me.IsPrimeControl)
        Me.TabPageIsPrime.Location = New System.Drawing.Point(4, 40)
        Me.TabPageIsPrime.Name = "TabPageIsPrime"
        Me.TabPageIsPrime.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageIsPrime.Size = New System.Drawing.Size(792, 382)
        Me.TabPageIsPrime.TabIndex = 5
        Me.TabPageIsPrime.Text = "Primzahlprüfung"
        Me.TabPageIsPrime.UseVisualStyleBackColor = True
        '
        'IsPrimeControl
        '
        Me.IsPrimeControl.Location = New System.Drawing.Point(59, 40)
        Me.IsPrimeControl.Name = "IsPrimeControl"
        Me.IsPrimeControl.Size = New System.Drawing.Size(390, 243)
        Me.IsPrimeControl.TabIndex = 0
        '
        'TabPageDivisibility
        '
        Me.TabPageDivisibility.Controls.Add(Me.IsDivisibleByControl)
        Me.TabPageDivisibility.Location = New System.Drawing.Point(4, 40)
        Me.TabPageDivisibility.Name = "TabPageDivisibility"
        Me.TabPageDivisibility.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDivisibility.Size = New System.Drawing.Size(792, 382)
        Me.TabPageDivisibility.TabIndex = 6
        Me.TabPageDivisibility.Text = "Teilbarkeitstest"
        Me.TabPageDivisibility.UseVisualStyleBackColor = True
        '
        'IsDivisibleByControl
        '
        Me.IsDivisibleByControl.Location = New System.Drawing.Point(80, 41)
        Me.IsDivisibleByControl.Name = "IsDivisibleByControl"
        Me.IsDivisibleByControl.Size = New System.Drawing.Size(437, 263)
        Me.IsDivisibleByControl.TabIndex = 0
        '
        'TabPageMultiples
        '
        Me.TabPageMultiples.Controls.Add(Me.IsMultipleOfControl)
        Me.TabPageMultiples.Location = New System.Drawing.Point(4, 40)
        Me.TabPageMultiples.Name = "TabPageMultiples"
        Me.TabPageMultiples.Size = New System.Drawing.Size(792, 382)
        Me.TabPageMultiples.TabIndex = 12
        Me.TabPageMultiples.Text = "Mehrfachtest"
        Me.TabPageMultiples.UseVisualStyleBackColor = True
        '
        'IsMultipleOfControl
        '
        Me.IsMultipleOfControl.Location = New System.Drawing.Point(120, 59)
        Me.IsMultipleOfControl.Name = "IsMultipleOfControl"
        Me.IsMultipleOfControl.Size = New System.Drawing.Size(358, 234)
        Me.IsMultipleOfControl.TabIndex = 0
        '
        'TabPageIsInRangeOf
        '
        Me.TabPageIsInRangeOf.Controls.Add(Me.IsInRangeOfControl)
        Me.TabPageIsInRangeOf.Location = New System.Drawing.Point(4, 40)
        Me.TabPageIsInRangeOf.Name = "TabPageIsInRangeOf"
        Me.TabPageIsInRangeOf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageIsInRangeOf.Size = New System.Drawing.Size(792, 382)
        Me.TabPageIsInRangeOf.TabIndex = 7
        Me.TabPageIsInRangeOf.Text = "Bereichsprüfung"
        Me.TabPageIsInRangeOf.UseVisualStyleBackColor = True
        '
        'TabPageDifferenceOf
        '
        Me.TabPageDifferenceOf.Controls.Add(Me.DifferenceOfControl)
        Me.TabPageDifferenceOf.Location = New System.Drawing.Point(4, 40)
        Me.TabPageDifferenceOf.Name = "TabPageDifferenceOf"
        Me.TabPageDifferenceOf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDifferenceOf.Size = New System.Drawing.Size(792, 382)
        Me.TabPageDifferenceOf.TabIndex = 8
        Me.TabPageDifferenceOf.Text = "Differenzberechnung"
        Me.TabPageDifferenceOf.UseVisualStyleBackColor = True
        '
        'TabPageHexadecimalConversion
        '
        Me.TabPageHexadecimalConversion.Location = New System.Drawing.Point(4, 40)
        Me.TabPageHexadecimalConversion.Name = "TabPageHexadecimalConversion"
        Me.TabPageHexadecimalConversion.Size = New System.Drawing.Size(792, 382)
        Me.TabPageHexadecimalConversion.TabIndex = 9
        Me.TabPageHexadecimalConversion.Text = "Hexadezimale Konvertierung"
        Me.TabPageHexadecimalConversion.UseVisualStyleBackColor = True
        '
        'TabPageFormatted
        '
        Me.TabPageFormatted.Location = New System.Drawing.Point(4, 40)
        Me.TabPageFormatted.Name = "TabPageFormatted"
        Me.TabPageFormatted.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFormatted.Size = New System.Drawing.Size(792, 382)
        Me.TabPageFormatted.TabIndex = 10
        Me.TabPageFormatted.Text = "Kulturabhängige Formatierung"
        Me.TabPageFormatted.UseVisualStyleBackColor = True
        '
        'TabPageStringCollections
        '
        Me.TabPageStringCollections.Location = New System.Drawing.Point(4, 40)
        Me.TabPageStringCollections.Name = "TabPageStringCollections"
        Me.TabPageStringCollections.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStringCollections.Size = New System.Drawing.Size(792, 382)
        Me.TabPageStringCollections.TabIndex = 11
        Me.TabPageStringCollections.Text = "String-Sammlungen"
        Me.TabPageStringCollections.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {MainMenuItemDatei, MainMenuItemAnsicht, MainMenuItemHilfe})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(800, 24)
        Me.MainMenu.TabIndex = 1
        Me.MainMenu.Text = "MainMenu"
        '
        'DifferenceOfControl
        '
        Me.DifferenceOfControl.Location = New System.Drawing.Point(40, 32)
        Me.DifferenceOfControl.Name = "DifferenceOfControl"
        Me.DifferenceOfControl.Size = New System.Drawing.Size(417, 231)
        Me.DifferenceOfControl.TabIndex = 0
        '
        'IsInRangeOfControl
        '
        Me.IsInRangeOfControl.Location = New System.Drawing.Point(61, 51)
        Me.IsInRangeOfControl.Name = "IsInRangeOfControl"
        Me.IsInRangeOfControl.Size = New System.Drawing.Size(478, 281)
        Me.IsInRangeOfControl.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.TabPagePercentageOf.ResumeLayout(False)
        Me.TabPageFractionBy.ResumeLayout(False)
        Me.TabPageSignTest.ResumeLayout(False)
        Me.TabPageIsPrime.ResumeLayout(False)
        Me.TabPageDivisibility.ResumeLayout(False)
        Me.TabPageMultiples.ResumeLayout(False)
        Me.TabPageIsInRangeOf.ResumeLayout(False)
        Me.TabPageDifferenceOf.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TabControl As TabControl
  Private WithEvents MainMenu As MenuStrip
  Private WithEvents MenuItemBeenden As ToolStripMenuItem
  Private WithEvents MenuItemÜber As ToolStripMenuItem
  Private WithEvents TabPagePercentageOf As TabPage
  Friend WithEvents TabPageFractionBy As TabPage
  Private WithEvents MenuItemPercentageOf As ToolStripMenuItem
  Private WithEvents MenuItemFractionBy As ToolStripMenuItem
  Private WithEvents TabPageSignTest As TabPage
  Private WithEvents MenuItemSignTest As ToolStripMenuItem
  Private WithEvents MenuItemIsPrime As ToolStripMenuItem
  Private WithEvents TabPageIsPrime As TabPage
  Private WithEvents MenuItemDivisibility As ToolStripMenuItem
  Private WithEvents MenuItemIsInRangeOf As ToolStripMenuItem
  Private WithEvents TabPageIsInRangeOf As TabPage
  Private WithEvents TabPageDivisibility As TabPage
  Private WithEvents MenuItemDifferenceOf As ToolStripMenuItem
  Private WithEvents TabPageDifferenceOf As TabPage
  Private WithEvents MenuItemHexadecimalConversion As ToolStripMenuItem
  Private WithEvents TabPageHexadecimalConversion As TabPage
  Private WithEvents MenuItemFormatted As ToolStripMenuItem
  Private WithEvents TabPageFormatted As TabPage
  Private WithEvents TabPageStringCollections As TabPage
  Private WithEvents MenuItemStringCollections As ToolStripMenuItem
    Private WithEvents PercentageOfControl As PercentageOfControl
    Private WithEvents FractionByControl As FractionByControl
    Private WithEvents SignTestControl As SignTestControl
    Private WithEvents IsPrimeControl As IsPrimeControl
    Private WithEvents TabPageMultiples As TabPage
    Private WithEvents MenuItemMultiples As ToolStripMenuItem
    Private WithEvents IsDivisibleByControl As IsDivisibleByControl
    Private WithEvents IsMultipleOfControl As IsMultipleOfControl
    Private WithEvents IsInRangeOfControl As IsInRangeOfControl
    Private WithEvents DifferenceOfControl As DifferenceOfControl
End Class
