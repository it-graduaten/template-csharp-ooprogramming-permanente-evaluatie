# 04_01

## Klassen

### Overzicht

![Klassendiagram](svg/Overview.svg)

### Punt

![Klassendiagram](svg/Punt.svg)

**Property `Omschrijving`**
Dit geeft als returnwaarde de tekstuele waarde `<klassenaam>:coord=(<X>,<Y>)` Tip: De klassenaam is op te vragen door de methode this.GetType().Name
**Methode `ToonGegevens()`**
Returnwaarde is de omschrijving.

### Cirkel

![Klassendiagram](svg/Cirkel.svg)

**Property `Omschrijving`**
Dit geeft als returnwaarde de waarde
`<klassenaam>:coord=(<X>,<Y>) straal <R>`
Tip: De klassenaam is op te vragen door de methode this.GetType().Name

**Methode `Omtrek()`**
Returnwaarde is de omtrek van de cirkel
Formule: `2 * π * r`. Rond af tot 2 cijfers na de komma adhv Math.Round().

**Methode `Oppervlakte()`**
Returnwaarde is de oppervlakte van de cirkel
Formule: `π * r²`. Rond af tot 2 cijfers na de komma adhv Math.Round().

**Methode `ToonGegevens()`**
Geeft de tekstuele voorstelling van het object als volgt
`<klassenaam>:coord=(<X>,<Y>) straal <R>
Oppervlakte: <Oppervlakte>
Omtrek: <Omtrek>`
Maak gebruik van de property Omschrijving!

### Cilinder

![Klassendiagram](svg/Cilinder.svg)

**Property `Omschrijving`**
Dit geeft als returnwaarde de waarde
`<klassenaam>:coord=(<X>,<Y>) straal <R>, hoogte<H>`
Tip: De klassenaam is op te vragen door de methode this.GetType().Name

**Methode `Volume()`**
Berekent het volume van de cilinder
Formule = `π * r² * h`
Maak gebruik van de oppervlakte van de cirkel die in de klasse Cirkel is aangemaakt

**Methode `Oppervlakte()`**
Berekent de oppervlakte van de cilinder
Formule = `2 * π * r² + 2 * π * r * h`
Maak in de formule gebruik van de oppervlakte en de omtrek die in de klasse Cirkel is aangemaakt

**Methode `ToonGegevens()`**
Geeft de tekstuele voorstelling van het object als volgt
`<klassenaam>:coord=(<X>,<Y>) straal <R>, hoogte<H>
Oppervlakte: <Oppervlakte>
Volume: <Volume>`
Maak gebruik van de property Omschrijving!

## Console applicatie
Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:
```
0. Punt
1. Cirkel
2. Cilinder
```

Afhankelijk van de keuze, worden de benodigde gegevens opgevraagd. Ingegeven waardes moeten numeriek zijn en groter dan 0. Hierna word een object aangemaakt met opgevraagde waardes en word deze vervolgens getoond.


## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 2
Punt: coord=(1,2)
```

**Input:**

```
ongeldig
1
ongeldig
0
2
ongeldig
0
2
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(1,2)
```

---

### Case 2

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 1
Punt: coord=(2,1)
```

**Input:**

```
ongeldig
2
ongeldig
0
1
ongeldig
0
5
ongeldig
0
2
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,1)
```

---

### Case 3

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 10
Punt: coord=(1,10)
```

**Input:**

```
ongeldig
1
ongeldig
0
10
ongeldig
0
10
ongeldig
0
1
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(1,10)
```

---

### Case 4

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 10
Punt: coord=(2,10)
```

**Input:**

```
ongeldig
2
ongeldig
0
10
ongeldig
0
1
ongeldig
0
10
ongeldig
0
2
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,10)
```

---

### Case 5

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(2,5)
```

**Input:**

```
ongeldig
2
ongeldig
0
5
ongeldig
0
5
ongeldig
0
5
ongeldig
0
2
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,5)
```

---

### Case 6

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 1
Punt: coord=(1,1)
```

**Input:**

```
ongeldig
1
ongeldig
0
1
ongeldig
0
10
ongeldig
0
1
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(1,1)
```

---

### Case 7

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 2
Punt: coord=(1,2)
```

**Input:**

```
ongeldig
1
ongeldig
0
2
ongeldig
0
1
ongeldig
0
1
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(1,2)
```

---

### Case 8

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: 10
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(10,5)
```

**Input:**

```
ongeldig
0
ongeldig
0
10
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Ongeldig getal
Punt: coord=(10,5)
```

---

### Case 9

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(2,5)
```

**Input:**

```
ongeldig
2
ongeldig
0
5
ongeldig
0
2
ongeldig
0
10
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,5)
```

---

### Case 10

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: 10
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(10,5)
```

**Input:**

```
ongeldig
0
ongeldig
0
10
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Ongeldig getal
Punt: coord=(10,5)
```

---

### Case 11

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 10
Punt: coord=(1,10)
```

**Input:**

```
ongeldig
1
ongeldig
0
10
ongeldig
0
10
ongeldig
0
1
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(1,10)
```

---

### Case 12

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 1
Punt: coord=(2,1)
```

**Input:**

```
ongeldig
2
ongeldig
0
1
ongeldig
0
2
ongeldig
0
5
ongeldig
0
10
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,1)
```

---

### Case 13

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(2,5)
```

**Input:**

```
ongeldig
0
ongeldig
0
2
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Ongeldig getal
Punt: coord=(2,5)
```

---

### Case 14

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 2
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 2
Punt: coord=(2,2)
```

**Input:**

```
ongeldig
2
ongeldig
0
2
ongeldig
0
5
ongeldig
0
5
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Punt: coord=(2,2)
```

---

### Case 15

**Complete console output:**

```
0. Punt
1. Cirkel
2. Cilinder
Maak uw keuze: ongeldig
Ongeldige keuze
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor X: 0
Geef een getal groter dan 0 voor X: 1
Geef een getal groter dan 0 voor Y: ongeldig
Ongeldig getal
Geef een getal groter dan 0 voor Y: 0
Geef een getal groter dan 0 voor Y: 5
Punt: coord=(1,5)
```

**Input:**

```
ongeldig
0
ongeldig
0
1
ongeldig
0
5
```

**Expected Output:**

```
0. Punt
1. Cirkel
2. Cilinder
Ongeldige keuze
Ongeldig getal
Ongeldig getal
Punt: coord=(1,5)
```

---
