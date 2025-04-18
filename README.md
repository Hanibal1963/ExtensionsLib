# ExtensionsLib

Eine Bibliothek mit verschiedenen Erweiterungsmethoden.

## �bersicht
Die Datei `DataExtensions.vb` enth�lt eine Sammlung von benutzerdefinierten Erweiterungsmethoden f�r verschiedene Datentypen, darunter numerische Typen (`Short`, `Integer`, `Long`, `Decimal`, `Double`, etc.) und `IEnumerable(Of String)`. Diese Methoden erweitern die Funktionalit�t der Datentypen und bieten n�tzliche Hilfsfunktionen f�r mathematische Berechnungen, Formatierungen, Sortierungen und mehr.

---

## Enthaltene Erweiterungsmethoden

### 1. Prozentsatzberechnungen
- **`PercentageOf`**  
  Berechnet den Prozentsatz eines Wertes im Verh�ltnis zu einem Gesamtwert.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 2. Bruchteilberechnungen
- **`FractionBy`**  
  Berechnet den Bruchteil eines Wertes basierend auf einem Prozentsatz.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 3. Pr�fung auf positive oder negative Werte
- **`IsPositive`**  
  �berpr�ft, ob ein Wert positiv ist.  
  **Unterst�tzte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

- **`IsNegative`**  
  �berpr�ft, ob ein Wert negativ ist.  
  **Unterst�tzte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

### 4. Primzahlpr�fung
- **`IsPrime`**  
  Bestimmt, ob ein Wert eine Primzahl ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 5. Teilbarkeit und Vielfache
- **`IsDivisibleBy`**  
  �berpr�ft, ob ein Wert ohne Rest durch einen angegebenen Divisor teilbar ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

- **`IsMultipleOf`**  
  �berpr�ft, ob ein Wert ein Vielfaches eines angegebenen Wertes ist.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 6. Bereichspr�fung
- **`IsInRangeOf`**  
  �berpr�ft, ob ein Wert innerhalb eines angegebenen Bereichs liegt.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 7. Differenzberechnung
- **`DifferenceOf`**  
  Berechnet die Differenz zwischen einem Wert und einem angegebenen Vergleichswert.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 8. Hexadezimale Konvertierung
- **`ToVBHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im Visual Basic-Format.  
  **Unterst�tzte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

- **`ToCSharpHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im C#-Format.  
  **Unterst�tzte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 9. Kulturabh�ngige Formatierung
- **`Formatted`**  
  Formatiert einen numerischen Wert basierend auf einer angegebenen Kultur und Pr�zision.  
  **Unterst�tzte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `Decimal`, `Single`, `Double`.

### 10. String-Sammlungen
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

- **`RemoveExact`**  
  Entfernt Elemente, die genau mit einer angegebenen Zeichenfolge �bereinstimmen.

- **`RemoveByContains`**  
  Entfernt Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`RemoveByLike`**  
  Entfernt Elemente, die einem bestimmten Muster entsprechen.

### 11. Array-Gr��en�nderung
- **`Resize`**  
  �ndert die Gr��e eines Arrays auf eine neue angegebene L�nge.

---

## Verwendung
Die Erweiterungsmethoden k�nnen direkt auf unterst�tzten Datentypen oder Sammlungen aufgerufen werden, indem der Namespace importiert wird:

```vb
Imports Extensions
```


### Beispiele

#### Prozentsatzberechnung

```vb
Dim result As Double = 50.PercentageOf(200) ' Ergebnis: 25.0
```

#### Primzahlpr�fung

```vb
Dim isPrime As Boolean = 7.IsPrime() ' Ergebnis: True
```

#### Sortierung

```vb
Dim sortedList = {"b", "a", "c"}.BubbleSort() ' Ergebnis: {"a", "b", "c"}
```

---

## Lizenz

Die Datei ist urheberrechtlich gesch�tzt:  
**Copyright (c)2025 by Andreas Sauer**

---
