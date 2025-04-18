# ExtensionsLib

Eine Bibliothek mit verschiedenen Erweiterungsmethoden.

## Übersicht
Die Datei `DataExtensions.vb` enthält eine Sammlung von benutzerdefinierten Erweiterungsmethoden für verschiedene Datentypen, darunter numerische Typen (`Short`, `Integer`, `Long`, `Decimal`, `Double`, etc.) und `IEnumerable(Of String)`. Diese Methoden erweitern die Funktionalität der Datentypen und bieten nützliche Hilfsfunktionen für mathematische Berechnungen, Formatierungen, Sortierungen und mehr.

---

## Enthaltene Erweiterungsmethoden

### 1. Prozentsatzberechnungen
- **`PercentageOf`**  
  Berechnet den Prozentsatz eines Wertes im Verhältnis zu einem Gesamtwert.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 2. Bruchteilberechnungen
- **`FractionBy`**  
  Berechnet den Bruchteil eines Wertes basierend auf einem Prozentsatz.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 3. Prüfung auf positive oder negative Werte
- **`IsPositive`**  
  Überprüft, ob ein Wert positiv ist.  
  **Unterstützte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

- **`IsNegative`**  
  Überprüft, ob ein Wert negativ ist.  
  **Unterstützte Typen:** `Short`, `Integer`, `Long`, `Decimal`, `Single`, `Double`.

### 4. Primzahlprüfung
- **`IsPrime`**  
  Bestimmt, ob ein Wert eine Primzahl ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 5. Teilbarkeit und Vielfache
- **`IsDivisibleBy`**  
  Überprüft, ob ein Wert ohne Rest durch einen angegebenen Divisor teilbar ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

- **`IsMultipleOf`**  
  Überprüft, ob ein Wert ein Vielfaches eines angegebenen Wertes ist.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 6. Bereichsprüfung
- **`IsInRangeOf`**  
  Überprüft, ob ein Wert innerhalb eines angegebenen Bereichs liegt.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 7. Differenzberechnung
- **`DifferenceOf`**  
  Berechnet die Differenz zwischen einem Wert und einem angegebenen Vergleichswert.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `ULong`, `Decimal`, `Single`, `Double`.

### 8. Hexadezimale Konvertierung
- **`ToVBHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im Visual Basic-Format.  
  **Unterstützte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

- **`ToCSharpHex`**  
  Konvertiert einen Wert in seine hexadezimale Darstellung im C#-Format.  
  **Unterstützte Typen:** `Byte`, `Short`, `UShort`, `Integer`, `UInteger`, `Long`.

### 9. Kulturabhängige Formatierung
- **`Formatted`**  
  Formatiert einen numerischen Wert basierend auf einer angegebenen Kultur und Präzision.  
  **Unterstützte Typen:** `Short`, `UShort`, `Integer`, `UInteger`, `Long`, `Decimal`, `Single`, `Double`.

### 10. String-Sammlungen
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

- **`RemoveExact`**  
  Entfernt Elemente, die genau mit einer angegebenen Zeichenfolge übereinstimmen.

- **`RemoveByContains`**  
  Entfernt Elemente, die eine bestimmte Zeichenfolge enthalten.

- **`RemoveByLike`**  
  Entfernt Elemente, die einem bestimmten Muster entsprechen.

### 11. Array-Größenänderung
- **`Resize`**  
  Ändert die Größe eines Arrays auf eine neue angegebene Länge.

---

## Verwendung
Die Erweiterungsmethoden können direkt auf unterstützten Datentypen oder Sammlungen aufgerufen werden, indem der Namespace importiert wird:

```vb
Imports Extensions
```


### Beispiele

#### Prozentsatzberechnung

```vb
Dim result As Double = 50.PercentageOf(200) ' Ergebnis: 25.0
```

#### Primzahlprüfung

```vb
Dim isPrime As Boolean = 7.IsPrime() ' Ergebnis: True
```

#### Sortierung

```vb
Dim sortedList = {"b", "a", "c"}.BubbleSort() ' Ergebnis: {"a", "b", "c"}
```

---

## Lizenz

Die Datei ist urheberrechtlich geschützt:  
**Copyright (c)2025 by Andreas Sauer**

---
