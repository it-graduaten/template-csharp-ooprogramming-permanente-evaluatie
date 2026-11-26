# 06_01

![Klassediagram](svg/TvKanaal.svg)

## Klasse

**Property `Nummer`**
Deze property bevat de nummer van het kanaal.

**Property `Omschrijving`**
Deze property bevat de omschrijving of naam van het kanaal.

**Property `ToString()`**
Deze methode geef een string terug met daarin "Nummer van het kanaal is <Nummer>

## Console applicatie
Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:

```
Een
Canvas
VTM
2BE
Vier

Van welk kanaal wil je het nummer tonen?
```

Bij het ingeven van een kanaal zorg je ervoor dat de gebruiker de juiste output krijgt. Als de gebruiker bijvoorbeeld 'VTM' ingeeft, wordt het volgende getoond:

```
Van welk kanaal wil je het nummer tonen? VTM

Nummer van het kanaal is 3
```

Maak een nieuwe lijst aan van de klasse TvKanaal. Vervolgens maak je 5 nieuwe objecten aan van deze klasse en die voeg je toe aan de lijst. Toon zoals in het voorbeeld alle kanalen en laat de gebruiker kiezen welk kanaal er getoond moet worden.

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Vier

Nummer van het kanaal is 5
```

**Input:**

```
Vier
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 5
```

---

### Case 2

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Canvas

Nummer van het kanaal is 2
```

**Input:**

```
Canvas
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 2
```

---

### Case 3

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
vtm

Nummer van het kanaal is 3
```

**Input:**

```
vtm
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 3
```

---

### Case 4

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
VTM

Nummer van het kanaal is 3
```

**Input:**

```
VTM
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 3
```

---

### Case 5

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
eEn

Nummer van het kanaal is 1
```

**Input:**

```
eEn
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 1
```

---

### Case 6

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
VTM

Nummer van het kanaal is 3
```

**Input:**

```
VTM
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 3
```

---

### Case 7

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Canvas

Nummer van het kanaal is 2
```

**Input:**

```
Canvas
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 2
```

---

### Case 8

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
vtm

Nummer van het kanaal is 3
```

**Input:**

```
vtm
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 3
```

---

### Case 9

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Een

Nummer van het kanaal is 1
```

**Input:**

```
Een
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 1
```

---

### Case 10

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Een

Nummer van het kanaal is 1
```

**Input:**

```
Een
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 1
```

---

### Case 11

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
eEn

Nummer van het kanaal is 1
```

**Input:**

```
eEn
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 1
```

---

### Case 12

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Een

Nummer van het kanaal is 1
```

**Input:**

```
Een
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 1
```

---

### Case 13

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Vier

Nummer van het kanaal is 5
```

**Input:**

```
Vier
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 5
```

---

### Case 14

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Vier

Nummer van het kanaal is 5
```

**Input:**

```
Vier
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 5
```

---

### Case 15

**Complete console output:**

```
Een
Canvas
VTM
2BE
Vier
Van welk kanaal wil je het nummer tonen?
Canvas

Nummer van het kanaal is 2
```

**Input:**

```
Canvas
```

**Expected Output:**

```
Een
Canvas
VTM
2BE
Vier
Nummer van het kanaal is 2
```

---
