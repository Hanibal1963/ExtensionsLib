' *************************************************************************************************
' 
' AboutBox.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.IO
Imports System.Drawing
Imports Svg

Public NotInheritable Class AboutBox

  Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ' Legen Sie den Titel des Formulars fest.
    Dim ApplicationTitle = If(My.Application.Info.Title <> "",
      My.Application.Info.Title,
      Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName))
    Me.Text = $"Info {ApplicationTitle}"

    ' Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
    ' TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
    ' Projekteigenschaften (im Menü "Projekt") anpassen.
    Me.LabelProductName.Text = My.Application.Info.ProductName
    Me.LabelVersion.Text = $"Version {My.Application.Info.Version}"
    Me.LabelCopyright.Text = My.Application.Info.Copyright
    Me.LabelCompanyName.Text = My.Application.Info.CompanyName
    Me.TextBoxDescription.Text = My.Application.Info.Description
    Me.LogoPictureBox.Image = My.Resources.Papa_Schlumpf

  End Sub

  Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
    Me.Close()
  End Sub

End Class
