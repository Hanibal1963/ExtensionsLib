' *************************************************************************************************
' 
' BitmapExtensions.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Imports System.Diagnostics.CodeAnalysis
Imports System.Runtime.CompilerServices
Imports System.Drawing

''' <summary>
''' Enthält Erweiterungsfunktionen für die Klasse <seealso cref="Bitmap"/> 
''' </summary>
Public Module BitmapExtensions

#Region "Konstantendefinitionen"

	Private Const _sHGFI_ICON = &H100
	Private Const _sHGFI_USEFILEATTRIBUTES = &H10

	Public ReadOnly Property SHGFI_ICON As Integer
		Get
			Return _sHGFI_ICON
		End Get
	End Property

	Public ReadOnly Property SHGFI_USEFILEATTRIBUTES As Integer
		Get
			Return _sHGFI_USEFILEATTRIBUTES
		End Get
	End Property

#End Region

#Region "Aufzählungsdefinitionen"

	''' <summary>
	''' Aufzählung der möglichen Symbolgrößen
	''' </summary>
	<Flags>
	Public Enum IconSizes

		''' <summary>
		''' großes Symbol (32*32 Pixel)
		''' </summary>
		x32 = 0

		''' <summary>
		''' kleines Symbol (16*16 Pixel)
		''' </summary>
		x16 = 1

	End Enum

#End Region

#Region "Interne Funktionen"

	''' <summary>
	''' Wandelt ein Bild in HTML-Code
	''' </summary>
	Private Function InternalGetHtmlCode(sender As Bitmap, RelSize As Integer, Alt As String) As String

		Dim code As String = "<img width='{0}' height='{1}' src='data:image;base64,{2}' alt='{3}' />"

		'Base64 - Code erzeugen
		Dim b64code As String = sender.ToBase64

		'Bildgröße anpassen
		Dim w As Integer = CInt(sender.Width / 100 * RelSize)
		Dim h As Integer = CInt(sender.Height / 100 * RelSize)

		'Ergebnis zurück
		Return String.Format(code, CStr(w), CStr(h), b64code, Alt)

	End Function

	''' <summary>
	''' Gibt das Symbol zurück welches einer Datei, eines Ordners oder einer Dateierweiteung zugeordnet ist.
	''' </summary>
	Private Function InternalGetBitmapFromFilePathOrExt(FilePathOrExt As String, Size As IconSizes) As Bitmap

		Dim fi As New SHFILEINFOW
		Dim fa = If(FilePathOrExt.StartsWith(".", True, Globalization.CultureInfo.CurrentCulture), Size Or SHGFI_USEFILEATTRIBUTES, Size)

		If SHGetFileInfoW(FilePathOrExt, 0, fi, Runtime.InteropServices.Marshal.SizeOf(fi), SHGFI_ICON Or fa) <> 0 Then
			Return Icon.FromHandle(fi.hIcon).ToBitmap
			Dim unused = DestroyIcon(fi.hIcon)
			Exit Function
		End If

		Return Nothing

	End Function

#End Region

	''' <summary>
	''' Wandelt das Bitmap in Html-Code.
	''' </summary>
	''' <param name="RelSize">
	''' Relative Größe des Bitmap in Prozent.
	''' </param>
	''' <param name="Alt">
	''' Alternativer Text.
	''' </param>
	''' <returns>
	''' Der erzeugte Html-Code oder leer wenn Bitmap Nothing ist.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ToHtml(sender As Bitmap, RelSize As Integer, Alt As String) As String

		If IsNothing(sender) Then Return ""
		Return InternalGetHtmlCode(sender, RelSize, Alt)

	End Function

	''' <summary>
	''' Wandelt das Bitmap in Html-Code.
	''' </summary>
	''' <param name="RelSize">
	''' Relative Größe des Bitmap in Prozent.
	''' </param>
	''' <returns>
	''' Der erzeugte Html-Code oder leer wenn Bitmap Nothing ist.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ToHtml(sender As Bitmap, RelSize As Integer) As String

		If IsNothing(sender) Then Return ""
		Return InternalGetHtmlCode(sender, RelSize, "")

	End Function

	''' <summary>
	''' Wandelt das Bitmap in Html-Code.
	''' </summary>
	''' <param name="Alt">
	''' Alternativer Text.
	''' </param>
	''' <returns>
	''' Der erzeugte Html-Code oder leer wenn Bitmap Nothing ist.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ToHtml(sender As Bitmap, Alt As String) As String

		If IsNothing(sender) Then Return ""
		Return InternalGetHtmlCode(sender, 100, Alt)

	End Function

	''' <summary>
	''' Wandelt Base64-Code in ein Bitmap um.
	''' </summary>
	''' <param name="Base64Code">
	''' Der Base64-Code.
	''' </param>
	''' <returns>
	''' Das erzeugte Bitmap oder Nothing wenn der Parameter Bas64Code keinen wert enthält.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	<SuppressMessage("Style", "IDE0060:Nicht verwendete Parameter entfernen", Justification:="<Ausstehend>")>
	Public Function FromBase64(sender As Bitmap, Base64Code As String) As Bitmap

		'Nothing zurück wenn der Parameter Base64Code keinen Wert enthält.
		If String.IsNullOrEmpty(Base64Code) Then Return Nothing

		Dim ic As New ImageConverter

		'String decodieren und in Byte-Array umwandeln
		Dim bytes() As Byte = Convert.FromBase64String(Base64Code)

		'Byte-Array in Image-Objekt umwandeln und das Image-Objekt zurückgeben 
		Return CType(ic.ConvertFrom(bytes), Bitmap)

	End Function

	''' <summary>
	''' Wandelt ein Bitmap in Base64-Code.
	''' </summary>
	''' <returns>
	''' Der erzeugte Base64-Code.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ToBase64(sender As Bitmap) As String

		Dim ic As New ImageConverter

		'Bitmap in Byte-Array umwandeln
		Dim bytes() As Byte = CType(ic.ConvertTo(sender, GetType(Byte())), Byte())

		'Byte-Array in Base64-codierten String umwandeln	und Datenstring zurückgeben
		Return Convert.ToBase64String(bytes, Base64FormattingOptions.InsertLineBreaks)

	End Function

	''' <summary>
	''' Gibt das Symbol zurück welches einer Datei, eines Ordners oder einer Dateierweiteung zugeordnet ist.
	''' </summary>
	''' <param name="FilePathOrExt">
	''' Der Pfad zu einer Datei, einem Ordner oder die Dateierweiterung.
	''' </param>
	''' <param name="Size">
	''' Die gewünschte Größe des Symbols. (16x16 oder 32x32 Pixel)
	''' </param>
	''' <returns>
	''' Ein Bitmap bei Erfolg oder Nothing bei Fehler.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	<SuppressMessage("Style", "IDE0060:Nicht verwendete Parameter entfernen", Justification:="<Ausstehend>")>
	Public Function FromFilePathOrExt(sender As Bitmap, FilePathOrExt As String, Size As IconSizes) As Bitmap

		'Ergebnis = Nothing wenn Parameter Null oder leer ist
		If String.IsNullOrEmpty(FilePathOrExt) Then Return Nothing

		Return InternalGetBitmapFromFilePathOrExt(FilePathOrExt, Size)

	End Function

	''' <summary>
	''' Gibt das Symbol zurück welches einer Datei, eines Ordners oder einer Dateierweiteung zugeordnet ist.
	''' </summary>
	''' <param name="FilePathOrExt">
	''' Der Pfad zu einer Datei, einem Ordner oder die Dateierweiterung.
	''' </param>
	''' <returns>
	''' Ein Bitmap bei Erfolg oder Nothing bei Fehler.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	<SuppressMessage("Style", "IDE0060:Nicht verwendete Parameter entfernen", Justification:="<Ausstehend>")>
	Public Function FromFilePathOrExt(sender As Bitmap, FilePathOrExt As String) As Bitmap

		'Ergebnis = Nothing wenn Parameter Null oder leer ist
		If String.IsNullOrEmpty(FilePathOrExt) Then Return Nothing

		Return InternalGetBitmapFromFilePathOrExt(FilePathOrExt, IconSizes.x16)

	End Function

	''' <summary>
	''' Gibt das angeforderte Symbol inder angegebenen Größe als Bitmap zurück.
	''' </summary>
	''' <param name="File">
	''' Vollständiger Pfad zu der Datei aus der das Symbol extrahiert werden soll.
	''' </param>
	''' <param name="Index">
	''' Nullbasierter Index des Symbols welches extrahiert werden soll.
	''' </param>
	''' <param name="Size">
	''' Größe des Symbols das extrahiert werden soll.
	''' </param>
	''' <returns>
	''' Ein Bitmap welches das angeforderte Symbol darstellt oder Nothing.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ExtractIcon(sender As Bitmap, File As String, Index As Integer, Size As IconSizes) As Bitmap

		'Ergebnis = Nothing wenn Parameter leer ist
		If String.IsNullOrEmpty(File) Then
			Return Nothing
			Exit Function
		End If

		'Ergebnis = Nothing wenn Datei nicht existiert
		If Not IO.File.Exists(File) Then
			Return Nothing
			Exit Function
		End If

		'Ergebnis = Nothing wenn der Symbolindex < 0 oder >= Anzahl der Symbol in der Datei ist
		If Index < 0 OrElse Index >= GetFileIcons(sender, File) Then
			Return Nothing
			Exit Function
		End If

		'Handle auf das Symbol erstellen
		Dim hIcon As IntPtr = Nothing
		Select Case Size

			Case IconSizes.x16  'kleines Symbol extrahieren wenn gefordert
				Dim unused1 = ExtractIconExW(File, Index, Nothing, hIcon, 1)

			Case IconSizes.x32 'großes Symbol extrahieren wenn gefordert
				Dim unused2 = ExtractIconExW(File, Index, hIcon, Nothing, 1)

			Case Else

		End Select

		'Symbol extrahieren	und Ergebnis zurück
		Return Icon.FromHandle(hIcon).ToBitmap

		'Handle zerstören
		Dim unused = DestroyIcon(hIcon)

	End Function

	''' <summary>
	''' Gibt das angeforderte Symbol als 16x16 Bitmap zurück.
	''' </summary>
	''' <param name="File">
	''' Vollständiger Pfad zu der Datei aus der das Symbol extrahiert werden soll.
	''' </param>
	''' <param name="Index">
	''' Nullbasierter Index des Symbols welches extrahiert werden soll.
	''' </param>
	''' <returns>
	''' Ein Bitmap welches das angeforderte Symbol darstellt oder Nothing.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	Public Function ExtractIcon(sender As Bitmap, File As String, Index As Integer) As Bitmap

		Return ExtractIcon(sender, File, Index, IconSizes.x16)

	End Function

	''' <summary>
	''' Gibt die Anzahl der Symbole zurück die in der Datei enthalten sind,
	''' die im Parameter "<paramref name="File"/>" angegeben ist.
	''' </summary>
	''' <param name="File">
	''' Pfad und Datei deren Symbolanzahl ermittelt werden soll.
	''' </param>
	''' <returns>
	''' Die nullbasierte Anzahl der in der Datei enthaltenen Symbole oder -1 bei Fehler.
	''' </returns>
	<DebuggerStepThrough> <Extension>
	<SuppressMessage("Style", "IDE0060:Nicht verwendete Parameter entfernen", Justification:="<Ausstehend>")>
	Public Function GetFileIcons(sender As Bitmap, File As String) As Integer

		'-1 zurück wenn Parameter leer ist
		If String.IsNullOrEmpty(File) Then Return -1

		'-1 zurück wenn Datei nicht vorhanden ist
		If Not IO.File.Exists(File) Then Return -1

		'Anzahl der in der Datei vorhandenen Symbole ermitteln und Ergebnis zurück
		Return CInt(ExtractIconExW(File, -1, Nothing, Nothing, 0))

	End Function

End Module
