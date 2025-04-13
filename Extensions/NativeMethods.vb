' *************************************************************************************************
' 
' NativeMethods.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' *************************************************************************************************

Module NativeMethods

  ''' <summary>
  ''' Zerstört ein Symbol und gibt jeglichen Speicher frei, den das Symbol belegt hat.
  ''' </summary>
  ''' <param name="hIcon">
  ''' Ein Handle für das Symbol, das zerstört werden soll. Das Symbol darf nicht verwendet werden.
  ''' </param>
  ''' <remarks>
  ''' https://learn.microsoft.com/de-de/windows/win32/api/winuser/nf-winuser-destroyicon
  ''' </remarks>
  <Runtime.InteropServices.DllImport("User32.dll", EntryPoint:="DestroyIcon")>
  Friend Function DestroyIcon(hIcon As IntPtr) As Integer
    'API Definition
  End Function

  ''' <summary>
  ''' Erstellt ein Array von Handles für große oder kleine Symbole, die aus der angegebenen
  ''' ausführbaren Datei, DLL oder Symboldatei extrahiert wurden.
  ''' </summary>
  ''' <param name="lpszFile">
  ''' Zeiger auf eine null-beendete Zeichenfolge, die den Namen einer ausführbaren Datei, 
  ''' DLL oder Symboldatei angibt, aus der Symbole extrahiert werden.
  ''' </param>
  ''' <param name="nIconIndex">
  ''' Gibt den nullbasierten Index des ersten Symbols an, das extrahiert werden soll.
  ''' </param>
  ''' <param name="phiconLarge">
  ''' Zeiger auf ein Array von Symbolhandhandpunkten, die die großen Symbole empfängt, 
  ''' die aus der Datei extrahiert wurden.
  ''' </param>
  ''' <param name="phiconSmall">
  ''' Zeigen Sie auf ein Array von Symbolhandhandpunkten, die die kleinen Symbole empfängt, 
  ''' die aus der Datei extrahiert wurden.
  ''' </param>
  ''' <param name="nIcons">
  ''' Die Anzahl der Symbole, die aus der Datei extrahiert werden sollen.
  ''' </param>
  ''' <remarks>
  ''' https://docs.microsoft.com/de-de/windows/win32/api/shellapi/nf-shellapi-extracticonexw
  ''' </remarks>
  <Runtime.InteropServices.DllImport("shell32.dll", EntryPoint:="ExtractIconExW")>
  Friend Function ExtractIconExW(
        <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)>
        lpszFile As String,
        nIconIndex As Integer,
        ByRef phiconLarge As IntPtr,
        ByRef phiconSmall As IntPtr,
        nIcons As UInteger) As UInteger
    'API Definition
  End Function

  ''' <summary>
  ''' Ruft Informationen zu einem Objekt im Dateisystem ab, z. B. eine Datei, einen Ordner,
  ''' ein Verzeichnis oder einen Laufwerkstamm.
  ''' </summary>
  ''' <param name="pszPath">
  ''' Ein Zeiger auf eine null-beendete Zeichenfolge mit maximaler Länge MAX_PATH, 
  ''' die den Pfad und dateinamen enthält.
  ''' </param>
  ''' <param name="dwFileAttributes">
  ''' Eine Kombination aus einem oder mehreren Dateiattributen 
  ''' (FILE_ATTRIBUTE_ Werte gemäß Der Definition in Winnt.h).
  ''' </param>
  ''' <param name="psfi">
  ''' Zeiger auf eine SHFILEINFO-Struktur , um die Dateiinformationen zu erhalten.
  ''' </param>
  ''' <param name="cbFileInfo">
  ''' Die Größe in Bytes der SHFILEINFO-Struktur , auf die der psfi-Parameter verweist.
  ''' </param>
  ''' <param name="uFlags">
  ''' Die Flags, die die abzurufenden Dateiinformationen angeben.
  ''' </param>
  ''' <remarks>
  ''' https://docs.microsoft.com/de-de/windows/win32/api/shellapi/nf-shellapi-shgetfileinfow
  ''' </remarks>
  <Runtime.InteropServices.DllImport("shell32.dll", EntryPoint:="SHGetFileInfoW")>
  Friend Function SHGetFileInfoW(
        <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)>
        pszPath As String,
        dwFileAttributes As Integer,
        ByRef psfi As SHFILEINFOW,
        cbFileInfo As Integer,
        uFlags As Integer) As Integer
    'API Definition
  End Function

  ''' <summary>
  ''' Enthält Informationen zu einem Dateiobjekt.
  ''' </summary>
  ''' <remarks>
  ''' https://learn.microsoft.com/de-de/windows/win32/api/shellapi/ns-shellapi-shfileinfoa
  ''' </remarks>
  <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
  Friend Structure SHFILEINFOW

    ''' <summary>
    ''' Ein Handle zum Symbol, das die Datei darstellt. 
    ''' </summary>
    Public hIcon As IntPtr

    ''' <summary>
    ''' Der Index des Symbolbilds in der Systembildliste.
    ''' </summary>
    Public iIcon As Integer

    ''' <summary>
    ''' Ein Array von Werten, das die Attribute des Dateiobjekts angibt.
    ''' </summary>
    ''' <remarks>
    ''' https://learn.microsoft.com/de-de/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellfolder-getattributesof
    ''' </remarks>
    Public dwAttributes As Integer

    ''' <summary>
    ''' Eine Zeichenfolge, die den Namen der Datei enthält, wie sie in der Windows-Shell angezeigt wird, 
    ''' oder den Pfad und Dateinamen der Datei, die das Symbol enthält, das die Datei darstellt.
    ''' </summary>
    <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=260)>
    Public szDisplayName As String

    ''' <summary>
    ''' Eine Zeichenfolge, die den Dateityp beschreibt.
    ''' </summary>
    <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=80)>
    Public szTypeName As String

  End Structure

End Module
