# 02_00

## Klassen

### Student

![Klassediagram](svg/Student.svg)

**Property `ScoreProgrammeren`**

Deze mag niet kleiner zijn dan 0. Bij een waarde kleiner dan 0, zal 0 ingesteld worden.
Deze mag niet groter zijn dan 20. Bij een waarde groter dan 20, zal 20 ingesteld worden.

**Property `ScoreNetwerken`**

Deze mag niet kleiner zijn dan 0. Bij een waarde kleiner dan 0, zal 0 ingesteld worden.
Deze mag niet groter zijn dan 20. Bij een waarde groter dan 20, zal 20 ingesteld worden.

**Methode `VoerScoreIn`**

De eerste parameter zal aangeven of de score voor programmeren of netwerken ingevoerd wordt. (0 = programmeren, 1 = netwerken)
De tweede parameter is de behaalde score

**Methode `ToonRapport`**

Deze methode retourneert een tekstuele weergave van het object:

```
<Naam>
------
Programmeren: <ScoreProgrammeren>
Netwerken: <ScoreNetwerken>
Proficiat u bent geslaagd! (Indien beide scores 10 of hoger)
Helaas u bent niet geslaagd! (Indien minimaal 1 score onder 10)
```

## Console applicatie
Maak een console applicatie die de gegevens van een student inleest.
Zorg voor een output die er als volgt uit ziet:

```plaintext
Geef een naam: Piet
Geef een score voor programmeren: 15
Geef een score voor netwerken: 8

Piet
------
Programmeren: 15
Netwerken: 8
Helaas u bent niet geslaagd!
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 10
Geef een score voor netwerken: -5
Ada
---
Programmeren: 10
Netwerken: 0
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
10
-5
```

**Expected Output:**

```
Ada
---
Programmeren: 10
Netwerken: 0
Helaas u bent niet geslaagd!
```

---

### Case 2

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: -5
Geef een score voor netwerken: 10
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
-5
10
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

---

### Case 3

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 25
Geef een score voor netwerken: 10
Ada
---
Programmeren: 20
Netwerken: 10
Proficiat u bent geslaagd!
```

**Input:**

```
Ada
25
10
```

**Expected Output:**

```
Ada
---
Programmeren: 20
Netwerken: 10
Proficiat u bent geslaagd!
```

---

### Case 4

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 9
Geef een score voor netwerken: -5
Ada
---
Programmeren: 9
Netwerken: 0
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
9
-5
```

**Expected Output:**

```
Ada
---
Programmeren: 9
Netwerken: 0
Helaas u bent niet geslaagd!
```

---

### Case 5

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 15
Geef een score voor netwerken: 20
Ada
---
Programmeren: 15
Netwerken: 20
Proficiat u bent geslaagd!
```

**Input:**

```
Ada
15
20
```

**Expected Output:**

```
Ada
---
Programmeren: 15
Netwerken: 20
Proficiat u bent geslaagd!
```

---

### Case 6

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 25
Geef een score voor netwerken: 15
Ada
---
Programmeren: 20
Netwerken: 15
Proficiat u bent geslaagd!
```

**Input:**

```
Ada
25
15
```

**Expected Output:**

```
Ada
---
Programmeren: 20
Netwerken: 15
Proficiat u bent geslaagd!
```

---

### Case 7

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 0
Geef een score voor netwerken: 10
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
0
10
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

---

### Case 8

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: -5
Geef een score voor netwerken: 10
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
-5
10
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 10
Helaas u bent niet geslaagd!
```

---

### Case 9

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: -5
Geef een score voor netwerken: 15
Ada
---
Programmeren: 0
Netwerken: 15
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
-5
15
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 15
Helaas u bent niet geslaagd!
```

---

### Case 10

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 0
Geef een score voor netwerken: -5
Ada
---
Programmeren: 0
Netwerken: 0
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
0
-5
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 0
Helaas u bent niet geslaagd!
```

---

### Case 11

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 0
Geef een score voor netwerken: 15
Ada
---
Programmeren: 0
Netwerken: 15
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
0
15
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 15
Helaas u bent niet geslaagd!
```

---

### Case 12

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 15
Geef een score voor netwerken: 9
Ada
---
Programmeren: 15
Netwerken: 9
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
15
9
```

**Expected Output:**

```
Ada
---
Programmeren: 15
Netwerken: 9
Helaas u bent niet geslaagd!
```

---

### Case 13

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 10
Geef een score voor netwerken: 9
Ada
---
Programmeren: 10
Netwerken: 9
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
10
9
```

**Expected Output:**

```
Ada
---
Programmeren: 10
Netwerken: 9
Helaas u bent niet geslaagd!
```

---

### Case 14

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: -5
Geef een score voor netwerken: 20
Ada
---
Programmeren: 0
Netwerken: 20
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
-5
20
```

**Expected Output:**

```
Ada
---
Programmeren: 0
Netwerken: 20
Helaas u bent niet geslaagd!
```

---

### Case 15

**Complete console output:**

```
Geef een naam: Ada
Geef een score voor programmeren: 20
Geef een score voor netwerken: -5
Ada
---
Programmeren: 20
Netwerken: 0
Helaas u bent niet geslaagd!
```

**Input:**

```
Ada
20
-5
```

**Expected Output:**

```
Ada
---
Programmeren: 20
Netwerken: 0
Helaas u bent niet geslaagd!
```

---
