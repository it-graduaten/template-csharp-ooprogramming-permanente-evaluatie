# 01_02

## Klassen

### Televisie

![Klassediagram](svg/Televisie.svg)

- Het kanaal kan niet kleiner worden dan 1 of groter dan 30.
- Het volume kan niet kleiner worden dan 0 of groter dan 10.
- Standaardwaarde voor het kanaal is 1. 
- Standaaardwaarde voor het volume is 5.

## Console applicatie

Maak een console applicatie waar de gebruiker een tv kan configureren. Bij het starten van de applicatie wordt er een televisie-object aangemaakt.

De gebruiker kan nu kiezen om het kanaal of volume te verhogen of te verlagen adhv volgende opties:

- 1: Kanaal verhogen
- 2: Kanaal verlagen
- 3: Volume verhogen
- 4: Volume verlagen
- 5: Stoppen

Hij kan keuzes blijven maken tot hij 5 kiest.

Wanneer de gebruiker 5 kiest, toon je de huidige configuratie van de televisie en sluit je de applicatie af.

### Voorbeeld

```plaintext
Startconfiguratie: Kanaal: 1 - Volume 5
Maak een keuze: 1
Maak een keuze: 1
Maak een keuze: 1
Maak een keuze: 3
Maak een keuze: 3
Maak een keuze: 5

Huidige configuratie: Kanaal: 4 - Volume 7
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 2 - Volume: 3
```

**Input:**

```
4
1
4
5
```

**Expected Output:**

```
Kanaal: 2 - Volume: 3
```

---

### Case 2

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
2
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 1 - Volume: 5
```

**Input:**

```
1
2
5
```

**Expected Output:**

```
Kanaal: 1 - Volume: 5
```

---

### Case 3

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 2 - Volume: 5
```

**Input:**

```
4
1
3
5
```

**Expected Output:**

```
Kanaal: 2 - Volume: 5
```

---

### Case 4

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 4 - Volume: 4
```

**Input:**

```
1
1
1
4
5
```

**Expected Output:**

```
Kanaal: 4 - Volume: 4
```

---

### Case 5

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
2
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 2 - Volume: 6
```

**Input:**

```
2
3
4
3
1
5
```

**Expected Output:**

```
Kanaal: 2 - Volume: 6
```

---

### Case 6

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 3 - Volume: 5
```

**Input:**

```
1
4
1
3
5
```

**Expected Output:**

```
Kanaal: 3 - Volume: 5
```

---

### Case 7

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
2
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 1 - Volume: 5
```

**Input:**

```
4
2
3
5
```

**Expected Output:**

```
Kanaal: 1 - Volume: 5
```

---

### Case 8

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
1
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 3 - Volume: 6
```

**Input:**

```
3
1
1
5
```

**Expected Output:**

```
Kanaal: 3 - Volume: 6
```

---

### Case 9

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
2
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
3
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 1 - Volume: 6
```

**Input:**

```
4
3
2
3
5
```

**Expected Output:**

```
Kanaal: 1 - Volume: 6
```

---

### Case 10

**Complete console output:**

```
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
4
Kies een optie:
1. Kanaal verhogen
2. Kanaal verlagen
3. Volume verhogen
4. Volume verlagen
5. Stop
5
Kanaal: 1 - Volume: 4
```

**Input:**

```
4
5
```

**Expected Output:**

```
Kanaal: 1 - Volume: 4
```

---
