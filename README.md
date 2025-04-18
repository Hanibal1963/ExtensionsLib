# ExtensionsLib

Eine Bibliothek mit verschiedenen Erweiterungsmethoden.

## �bersicht

Die Datei `DataExtensions.vb` enth�lt eine Sammlung von benutzerdefinierten Erweiterungsmethoden f�r verschiedene Datentypen, darunter numerische Typen (`Short`, `Integer`, `Long`, `Decimal`, `Double`, etc.) und `IEnumerable(Of String)`. Diese Methoden erweitern die Funktionalit�t der Datentypen und bieten n�tzliche Hilfsfunktionen f�r mathematische Berechnungen, Formatierungen, Sortierungen und mehr.

Die Datei `BitmapExtensions.vb` enth�lt eine Sammlung von Erweiterungsmethoden f�r die Klasse `Bitmap`. Diese Methoden bieten zus�tzliche Funktionalit�ten wie die Konvertierung von Bitmaps in HTML-Code, Base64-Codierung, das Extrahieren von Symbolen aus Dateien und mehr.

---

## 1. Enthaltene Erweiterungsmethoden in `DataExtensions.vb`

### 1.1. Prozentsatzberechnungen

- **`PercentageOf`**  
  Berechnet den Prozentsatz eines Wertes im Verh�ltnis zu einem Gesamtwert.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

Beispiel:

```vb
Dim result As Double = 50.PercentageOf(200) ' Ergebnis: 25.0
```

### 1.2. Bruchteilberechnungen

- **`FractionBy`**  
  Berechnet den Bruchteil eines Wertes basierend auf einem Prozentsatz.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.3. Pr�fung auf positive oder negative Werte

- **`IsPositive`**  
  �berpr�ft, ob ein Wert positiv ist.  
  **Unterst�tzte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

- **`IsNegative`**  
  �berpr�ft, ob ein Wert negativ ist.  
  **Unterst�tzte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

### 1.4. Primzahlpr�fung

- **`IsPrime`**  
  Bestimmt, ob ein Wert eine Primzahl ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

Beispiel:

```vb
Dim isPrime As Boolean = 7.IsPrime() ' Ergebnis: True
```

### 1.5. Teilbarkeit und Vielfache

- **`IsDivisibleBy`**  
  �berpr�ft, ob ein Wert ohne Rest durch einen angegebenen Divisor teilbar ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

- **`IsMultipleOf`**  
  �berpr�ft, ob ein Wert ein Vielfaches eines angegebenen Wertes ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.6. Bereichspr�fung

- **`IsInRangeOf`**  
  �berpr�ft, ob ein Wert innerhalb eines angegebenen Bereichs liegt.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.7. Differenzberechnung

- **`DifferenceOf`**  
  Berechnet die Differenz zwischen einem Wert und einem angegebenen Vergleichswert.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.8. Hexadezimale Konvertierung

- **`ToVBHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im Visual Basic-Format.  
  **Unterst�tzte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

- **`ToCSharpHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im C#-Format.  
  **Unterst�tzte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 1.9. Kulturabh�ngige Formatierung

- **`Formatted`**  
  Formatiert einen numerischen Wert basierend auf einer angegebenen Kultur und Pr�zision.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `Decimal`, `Single`, `Double`.

### 1.10. String-Sammlungen

- **`CountEmptyItems`**  
  Z�hlt die leeren Elemente in einer `IEnumerable(Of String)`.

- **`CountNonEmptyItems`**  
  Z�hlt die nicht leeren Elemente in einer `IEnumerable(Of String)`.

- **`FindExact`**  
  Findet Elemente, die genau mit einer angegebenen Zeichenfolge �bereinstimmen.

- **`FindByContains`**  
  Findet Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`FindByLike`**  
  F�hrt eine Mustersuche mit dem `Like`-Operator durch.

- **`BubbleSort`**  
  Sortiert eine Sammlung von Zeichenfolgen mit der Bubble-Sort-Methode.

Beispiel:

```vb
Dim sortedList = {"b", "a", "c"}.BubbleSort() ' Ergebnis: {"a", "b", "c"}
```

- **`RemoveExact`**  
  Entfernt Elemente, die genau mit einer angegebenen Zeichenfolge �bereinstimmen.

- **`RemoveByContains`**  
  Entfernt Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`RemoveByLike`**  
  Entfernt Elemente, die einem bestimmten Muster entsprechen.

### 1.11. Array-Gr��en�nderung

- **`Resize`**  
  �ndert die Gr��e eines Arrays auf eine neue angegebene L�nge.

---

## 2. Enthaltene Erweiterungsmethoden in `BitmapExtensions.vb`

### 2.1. **Konvertierung in HTML**

- **`ToHtml(RelSize As Integer, Alt As String)`**  
  Wandelt ein `Bitmap` in HTML-Code um.  
  **Parameter:**  
  - `RelSize`: Relative Gr��e des Bildes in Prozent.  
  - `Alt`: Alternativer Text f�r das Bild.  
  **R�ckgabe:** HTML-Code als `String`.

- **`ToHtml(RelSize As Integer)`**  
  Wandelt ein `Bitmap` in HTML-Code um, ohne alternativen Text.  
  **Parameter:**  
  - `RelSize`: Relative Gr��e des Bildes in Prozent.  
  **R�ckgabe:** HTML-Code als `String`.

- **`ToHtml(Alt As String)`**  
  Wandelt ein `Bitmap` in HTML-Code um, ohne Gr��enanpassung.  
  **Parameter:**  
  - `Alt`: Alternativer Text f�r das Bild.  
  **R�ckgabe:** HTML-Code als `String`.

Beispiel:

```vb
Dim bmp As New Bitmap("example.png") Dim htmlCode As String = bmp.ToHtml(50, "Beispielbild") Console.WriteLine(htmlCode)
```

---

### 2.2. **Base64-Codierung**

- **`ToBase64()`**  
  Wandelt ein `Bitmap` in einen Base64-codierten String um.  
  **R�ckgabe:** Base64-codierter String.

- **`FromBase64(Base64Code As String)`**  
  Wandelt einen Base64-codierten String in ein `Bitmap` um.  
  **Parameter:**  
  - `Base64Code`: Der Base64-codierte String.  
  **R�ckgabe:** Das erzeugte `Bitmap` oder `Nothing`, wenn der String leer ist.

---

### 2.3. **Symbole aus Dateien extrahieren**

- **`FromFilePathOrExt(FilePathOrExt As String, Size As IconSizes)`**  
  Gibt das Symbol zur�ck, das einer Datei, einem Ordner oder einer Dateierweiterung zugeordnet ist.  
  **Parameter:**  
  - `FilePathOrExt`: Pfad oder Dateierweiterung.  
  - `Size`: Gr��e des Symbols (`16x16` oder `32x32`).  
  **R�ckgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`FromFilePathOrExt(FilePathOrExt As String)`**  
  Gibt das Symbol in der Standardgr��e `16x16` zur�ck.  
  **Parameter:**  
  - `FilePathOrExt`: Pfad oder Dateierweiterung.  
  **R�ckgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`ExtractIcon(File As String, Index As Integer, Size As IconSizes)`**  
  Extrahiert ein Symbol aus einer Datei in der angegebenen Gr��e.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  - `Index`: Nullbasierter Index des Symbols.  
  - `Size`: Gr��e des Symbols (`16x16` oder `32x32`).  
  **R�ckgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`ExtractIcon(File As String, Index As Integer)`**  
  Extrahiert ein Symbol aus einer Datei in der Standardgr��e `16x16`.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  - `Index`: Nullbasierter Index des Symbols.  
  **R�ckgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`GetFileIcons(File As String)`**  
  Gibt die Anzahl der Symbole zur�ck, die in einer Datei enthalten sind.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  **R�ckgabe:** Anzahl der Symbole oder `-1` bei Fehler.

Beispiel:

```vb
Dim icon As Bitmap = New Bitmap().FromFilePathOrExt("example.txt", IconSizes.x32) Dim iconCount As Integer = New Bitmap().GetFileIcons("example.dll")
```

---

## 3. Aufz�hlungen

### **`IconSizes`**

Eine Aufz�hlung, die die m�glichen Symbolgr��en definiert:
- `x32`: Gro�es Symbol (32x32 Pixel).  
- `x16`: Kleines Symbol (16x16 Pixel).

---

## 4. Verwendung

Die Erweiterungsmethoden k�nnen direkt auf unterst�tzten Datentypen oder Sammlungen aufgerufen werden, indem der Namespace importiert wird:

```vb
Imports Extensions
```

---

## 5. Lizenz

Die Datei ist urheberrechtlich gesch�tzt:  
**Copyright (c)2025 by Andreas Sauer**

---
