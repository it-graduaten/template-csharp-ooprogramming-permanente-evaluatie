# 01_04

## Klassen

### Zwembad

![Klassediagram](svg/Zwembad.svg)

**Property `Breedte`**

De breedte van het zwembad. Deze mag niet kleiner zijn dan 0. Bij een foutieve waarde wordt de breedte ingesteld op 0.

**Property `Diepte`**

De diepte van het zwembad. Deze mag niet kleiner zijn dan 0. Bij een foutieve waarde wordt de diepte ingesteld op 0.

**Property `Lengte`**

De lengte van het zwembad. Deze mag niet kleiner zijn dan 0. Bij een foutieve waarde wordt de lengte ingesteld op 0.

**Property `Randafstand`**

De randafstand van het zwembad. Deze mag niet kleiner zijn dan 0 en niet groter dan de diepte. Bij een foutieve waarde wordt de randafstand ingesteld op 0.

**Methode `LiterWater`**

Deze methode berekent de hoeveelheid water die nodig is om het zwembad te vullen. De formule hiervoor is: `Breedte * (Diepte - Randafstand) * Lengte * 1000`.

**Methode `ToonGegevens`**

Deze methode retourneert een tekstuele weergave van het object:

```plaintext
Diepte = <Diepte>
Breedte = <Breedte>
Lengte = <Lengte>
Randafstand = <Randafstand>

Liters water = <LitersWater>
```

### Console applicatie

Maak een console applicatie die de gebruiker vraagt om een breedte, lengte, diepte en randafstand in te geven in de volgorde zoals hier beschreven. Voorzie de correcte controles. Nadat de gebruiker deze gegevens heeft ingegeven, toon je de gegevens van het zwembad en sluit de applicatie af.

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Geef de breedte: 4
Geef de lengte: 25
Geef de diepte: 16
Geef de randafstand: 1
Breedte = 4
Diepte = 16
Lengte = 25
Randafstand = 1

Liters water = 1500000
```

**Input:**

```
4
25
16
1
```

**Expected Output:**

```
Breedte = 4
Diepte = 16
Lengte = 25
Randafstand = 1
Liters water = 1500000
```

---

### Case 2

**Complete console output:**

```
Geef de breedte: 1
Geef de lengte: 8
Geef de diepte: 16
Geef de randafstand: 2
Breedte = 1
Diepte = 16
Lengte = 8
Randafstand = 2

Liters water = 112000
```

**Input:**

```
1
8
16
2
```

**Expected Output:**

```
Breedte = 1
Diepte = 16
Lengte = 8
Randafstand = 2
Liters water = 112000
```

---

### Case 3

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 42
Geef de diepte: 18
Geef de randafstand: 0
Breedte = 2
Diepte = 18
Lengte = 42
Randafstand = 0

Liters water = 1512000
```

**Input:**

```
2
42
18
0
```

**Expected Output:**

```
Breedte = 2
Diepte = 18
Lengte = 42
Randafstand = 0
Liters water = 1512000
```

---

### Case 4

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 32
Geef de diepte: 44
Geef de randafstand: 0
Breedte = 2
Diepte = 44
Lengte = 32
Randafstand = 0

Liters water = 2816000
```

**Input:**

```
2
32
44
0
```

**Expected Output:**

```
Breedte = 2
Diepte = 44
Lengte = 32
Randafstand = 0
Liters water = 2816000
```

---

### Case 5

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 39
Geef de diepte: 13
Geef de randafstand: 0
Breedte = 2
Diepte = 13
Lengte = 39
Randafstand = 0

Liters water = 1014000
```

**Input:**

```
2
39
13
0
```

**Expected Output:**

```
Breedte = 2
Diepte = 13
Lengte = 39
Randafstand = 0
Liters water = 1014000
```

---

### Case 6

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 45
Geef de diepte: 50
Geef de randafstand: 2
Breedte = 2
Diepte = 50
Lengte = 45
Randafstand = 2

Liters water = 4320000
```

**Input:**

```
2
45
50
2
```

**Expected Output:**

```
Breedte = 2
Diepte = 50
Lengte = 45
Randafstand = 2
Liters water = 4320000
```

---

### Case 7

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 22
Geef de diepte: 7
Geef de randafstand: 0
Breedte = 2
Diepte = 7
Lengte = 22
Randafstand = 0

Liters water = 308000
```

**Input:**

```
2
22
7
0
```

**Expected Output:**

```
Breedte = 2
Diepte = 7
Lengte = 22
Randafstand = 0
Liters water = 308000
```

---

### Case 8

**Complete console output:**

```
Geef de breedte: 2
Geef de lengte: 16
Geef de diepte: 12
Geef de randafstand: 0
Breedte = 2
Diepte = 12
Lengte = 16
Randafstand = 0

Liters water = 384000
```

**Input:**

```
2
16
12
0
```

**Expected Output:**

```
Breedte = 2
Diepte = 12
Lengte = 16
Randafstand = 0
Liters water = 384000
```

---

### Case 9

**Complete console output:**

```
Geef de breedte: 1
Geef de lengte: 30
Geef de diepte: 8
Geef de randafstand: 2
Breedte = 1
Diepte = 8
Lengte = 30
Randafstand = 2

Liters water = 180000
```

**Input:**

```
1
30
8
2
```

**Expected Output:**

```
Breedte = 1
Diepte = 8
Lengte = 30
Randafstand = 2
Liters water = 180000
```

---

### Case 10

**Complete console output:**

```
Geef de breedte: 3
Geef de lengte: 29
Geef de diepte: 6
Geef de randafstand: 2
Breedte = 3
Diepte = 6
Lengte = 29
Randafstand = 2

Liters water = 348000
```

**Input:**

```
3
29
6
2
```

**Expected Output:**

```
Breedte = 3
Diepte = 6
Lengte = 29
Randafstand = 2
Liters water = 348000
```

---
