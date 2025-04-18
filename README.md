# ExtensionsLib

Eine Bibliothek mit verschiedenen Erweiterungsmethoden.

## Übersicht

Die Datei `DataExtensions.vb` enthält eine Sammlung von benutzerdefinierten Erweiterungsmethoden für verschiedene Datentypen, darunter numerische Typen (`Short`, `Integer`, `Long`, `Decimal`, `Double`, etc.) und `IEnumerable(Of String)`. Diese Methoden erweitern die Funktionalität der Datentypen und bieten nützliche Hilfsfunktionen für mathematische Berechnungen, Formatierungen, Sortierungen und mehr.

Die Datei `BitmapExtensions.vb` enthält eine Sammlung von Erweiterungsmethoden für die Klasse `Bitmap`. Diese Methoden bieten zusätzliche Funktionalitäten wie die Konvertierung von Bitmaps in HTML-Code, Base64-Codierung, das Extrahieren von Symbolen aus Dateien und mehr.

---

## 1. Enthaltene Erweiterungsmethoden in `DataExtensions.vb`

### 1.1. Prozentsatzberechnungen

- **`PercentageOf`**  
  Berechnet den Prozentsatz eines Wertes im Verhältnis zu einem Gesamtwert.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

Beispiel:

```vb
Dim result As Double = 50.PercentageOf(200) ' Ergebnis: 25.0
```

### 1.2. Bruchteilberechnungen

- **`FractionBy`**  
  Berechnet den Bruchteil eines Wertes basierend auf einem Prozentsatz.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.3. Prüfung auf positive oder negative Werte

- **`IsPositive`**  
  Überprüft, ob ein Wert positiv ist.  
  **Unterstützte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

- **`IsNegative`**  
  Überprüft, ob ein Wert negativ ist.  
  **Unterstützte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

### 1.4. Primzahlprüfung

- **`IsPrime`**  
  Bestimmt, ob ein Wert eine Primzahl ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

Beispiel:

```vb
Dim isPrime As Boolean = 7.IsPrime() ' Ergebnis: True
```

### 1.5. Teilbarkeit und Vielfache

- **`IsDivisibleBy`**  
  Überprüft, ob ein Wert ohne Rest durch einen angegebenen Divisor teilbar ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

- **`IsMultipleOf`**  
  Überprüft, ob ein Wert ein Vielfaches eines angegebenen Wertes ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.6. Bereichsprüfung

- **`IsInRangeOf`**  
  Überprüft, ob ein Wert innerhalb eines angegebenen Bereichs liegt.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.7. Differenzberechnung

- **`DifferenceOf`**  
  Berechnet die Differenz zwischen einem Wert und einem angegebenen Vergleichswert.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 1.8. Hexadezimale Konvertierung

- **`ToVBHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im Visual Basic-Format.  
  **Unterstützte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

- **`ToCSharpHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im C#-Format.  
  **Unterstützte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 1.9. Kulturabhängige Formatierung

- **`Formatted`**  
  Formatiert einen numerischen Wert basierend auf einer angegebenen Kultur und Präzision.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `Decimal`, `Single`, `Double`.

### 1.10. String-Sammlungen

- **`CountEmptyItems`**  
  Zählt die leeren Elemente in einer `IEnumerable(Of String)`.

- **`CountNonEmptyItems`**  
  Zählt die nicht leeren Elemente in einer `IEnumerable(Of String)`.

- **`FindExact`**  
  Findet Elemente, die genau mit einer angegebenen Zeichenfolge übereinstimmen.

- **`FindByContains`**  
  Findet Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`FindByLike`**  
  Führt eine Mustersuche mit dem `Like`-Operator durch.

- **`BubbleSort`**  
  Sortiert eine Sammlung von Zeichenfolgen mit der Bubble-Sort-Methode.

Beispiel:

```vb
Dim sortedList = {"b", "a", "c"}.BubbleSort() ' Ergebnis: {"a", "b", "c"}
```

- **`RemoveExact`**  
  Entfernt Elemente, die genau mit einer angegebenen Zeichenfolge übereinstimmen.

- **`RemoveByContains`**  
  Entfernt Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`RemoveByLike`**  
  Entfernt Elemente, die einem bestimmten Muster entsprechen.

### 1.11. Array-Größenänderung

- **`Resize`**  
  Ändert die Größe eines Arrays auf eine neue angegebene Länge.

---

## 2. Enthaltene Erweiterungsmethoden in `BitmapExtensions.vb`

### 2.1. **Konvertierung in HTML**

- **`ToHtml(RelSize As Integer, Alt As String)`**  
  Wandelt ein `Bitmap` in HTML-Code um.  
  **Parameter:**  
  - `RelSize`: Relative Größe des Bildes in Prozent.  
  - `Alt`: Alternativer Text für das Bild.  
  **Rückgabe:** HTML-Code als `String`.

- **`ToHtml(RelSize As Integer)`**  
  Wandelt ein `Bitmap` in HTML-Code um, ohne alternativen Text.  
  **Parameter:**  
  - `RelSize`: Relative Größe des Bildes in Prozent.  
  **Rückgabe:** HTML-Code als `String`.

- **`ToHtml(Alt As String)`**  
  Wandelt ein `Bitmap` in HTML-Code um, ohne Größenanpassung.  
  **Parameter:**  
  - `Alt`: Alternativer Text für das Bild.  
  **Rückgabe:** HTML-Code als `String`.

Beispiel:

```vb
Dim bmp As New Bitmap("example.png") Dim htmlCode As String = bmp.ToHtml(50, "Beispielbild") Console.WriteLine(htmlCode)
```

---

### 2.2. **Base64-Codierung**

- **`ToBase64()`**  
  Wandelt ein `Bitmap` in einen Base64-codierten String um.  
  **Rückgabe:** Base64-codierter String.

- **`FromBase64(Base64Code As String)`**  
  Wandelt einen Base64-codierten String in ein `Bitmap` um.  
  **Parameter:**  
  - `Base64Code`: Der Base64-codierte String.  
  **Rückgabe:** Das erzeugte `Bitmap` oder `Nothing`, wenn der String leer ist.

---

### 2.3. **Symbole aus Dateien extrahieren**

- **`FromFilePathOrExt(FilePathOrExt As String, Size As IconSizes)`**  
  Gibt das Symbol zurück, das einer Datei, einem Ordner oder einer Dateierweiterung zugeordnet ist.  
  **Parameter:**  
  - `FilePathOrExt`: Pfad oder Dateierweiterung.  
  - `Size`: Größe des Symbols (`16x16` oder `32x32`).  
  **Rückgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`FromFilePathOrExt(FilePathOrExt As String)`**  
  Gibt das Symbol in der Standardgröße `16x16` zurück.  
  **Parameter:**  
  - `FilePathOrExt`: Pfad oder Dateierweiterung.  
  **Rückgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`ExtractIcon(File As String, Index As Integer, Size As IconSizes)`**  
  Extrahiert ein Symbol aus einer Datei in der angegebenen Größe.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  - `Index`: Nullbasierter Index des Symbols.  
  - `Size`: Größe des Symbols (`16x16` oder `32x32`).  
  **Rückgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`ExtractIcon(File As String, Index As Integer)`**  
  Extrahiert ein Symbol aus einer Datei in der Standardgröße `16x16`.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  - `Index`: Nullbasierter Index des Symbols.  
  **Rückgabe:** Ein `Bitmap` oder `Nothing` bei Fehler.

- **`GetFileIcons(File As String)`**  
  Gibt die Anzahl der Symbole zurück, die in einer Datei enthalten sind.  
  **Parameter:**  
  - `File`: Pfad zur Datei.  
  **Rückgabe:** Anzahl der Symbole oder `-1` bei Fehler.

Beispiel:

```vb
Dim icon As Bitmap = New Bitmap().FromFilePathOrExt("example.txt", IconSizes.x32) Dim iconCount As Integer = New Bitmap().GetFileIcons("example.dll")
```

---

## 3. Aufzählungen

### **`IconSizes`**

Eine Aufzählung, die die möglichen Symbolgrößen definiert:
- `x32`: Großes Symbol (32x32 Pixel).  
- `x16`: Kleines Symbol (16x16 Pixel).

---

## 4. Verwendung

Die Erweiterungsmethoden können direkt auf unterstützten Datentypen oder Sammlungen aufgerufen werden, indem der Namespace importiert wird:

```vb
Imports Extensions
```

---

## 5. Lizenz

Die Datei ist urheberrechtlich geschützt:  
**Copyright (c)2025 by Andreas Sauer**

---
