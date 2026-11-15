# 01_01

## Klassen

### Teller

![Klassediagram](svg/Teller.svg)

**Methode `Verhoog`**

Deze methode verhoogt de waarde van de teller met 1.

**Methode `Verlaag`**

Deze methode verlaagt de waarde van de teller met 1.

**Methode `Resetten`**

Deze methode zet de waarde van de teller op 0.

**Methode `ToonGegevens`**

Deze methode retourneert een tekstuele weergave van het object: `De waarde van de teller is <waarde>`.

## Console applicatie

Maak een console applicatie die de gebruiker vraagt om een keuze te maken. De mogelijke keuzes vind je hieronder:

- 0: Stoppen
- 1: Verhogen
- 2: Verlagen
- 3: Resetten

Indien de gebruiker kiest voor 1, 2 of 3 voer je de betreffende methode uit op het teller-object. Indien de gebruiker kiest voor 0, stopt de applicatie en toon je de waarde van de teller. Na elke keuze en actie krijgt de gebruiker opnieuw de mogelijkheid om een keuze te maken tot er 0 gekozen wordt.

### Voorbeeld

```plaintext
Maak een keuze: 1
Maak een keuze: 1
Maak een keuze: 2
Maak een keuze: 0

De waarde van de teller is 1
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 2.
```

**Input:**

```
4
2
1
2
1
1
```

**Expected Output:**

```
De waarde van de teller is 2.
```

---

### Case 2

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 2.
```

**Input:**

```
2
1
1
```

**Expected Output:**

```
De waarde van de teller is 2.
```

---

### Case 3

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 0.
```

**Input:**

```
2
4
1
```

**Expected Output:**

```
De waarde van de teller is 0.
```

---

### Case 4

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 1.
```

**Input:**

```
2
3
1
```

**Expected Output:**

```
De waarde van de teller is 1.
```

---

### Case 5

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 2.
```

**Input:**

```
2
1
4
4
4
1
```

**Expected Output:**

```
De waarde van de teller is 2.
```

---

### Case 6

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 0.
```

**Input:**

```
3
3
2
3
4
1
```

**Expected Output:**

```
De waarde van de teller is 0.
```

---

### Case 7

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 0.
```

**Input:**

```
4
1
```

**Expected Output:**

```
De waarde van de teller is 0.
```

---

### Case 8

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 2.
```

**Input:**

```
2
1
2
1
```

**Expected Output:**

```
De waarde van de teller is 2.
```

---

### Case 9

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 2
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is 3.
```

**Input:**

```
2
4
3
2
2
1
```

**Expected Output:**

```
De waarde van de teller is 3.
```

---

### Case 10

**Complete console output:**

```
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 4
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 3
Kies een optie:
1. Stop
2. Verhoog
3. Verlaag
4. Reset
Geef een keuze: 1
De waarde van de teller is -1.
```

**Input:**

```
4
3
1
1
1
```

**Expected Output:**

```
De waarde van de teller is -1.
```

---
