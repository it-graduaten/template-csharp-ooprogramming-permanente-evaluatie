# 02_02

## Klassen

### Bmi

![Klassediagram](svg/Bmi.svg)

**Methode `BerekenBmi`**

Deze methode berekent de Body Mass Index (BMI) van een persoon. De BMI wordt berekend door het gewicht in kilogram te delen door het kwadraat van de lengte in meter. Rond af tot op 1 cijfer na de komma. Gebruik hiervoor de methode `Math.Round`.

## Console applicatie

Schrijf een programma dat de naam, lengte en gewicht van een persoon inleest. Bereken de BMI en toon de gegevens van de persoon. De output ziet er als volgt uit:

```
Geef een naam: Jan
Geef een gewicht: 67
Geef een lengte: 1,8

Jan weegt 67 kg en is 1,8 m groot. De BMI is 20,7.
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Geef een naam: Jean-Luc
Geef een gewicht: 120,25
Geef een lengte: 
1,6
Jean-Luc weegt 120,25 kg en is 1,6 m groot. De BMI is 47.
```

**Input:**

```
Jean-Luc
120,25
1,6
```

**Expected Output:**

```
Jean-Luc weegt 120,25 kg en is 1,6 m groot. De BMI is 47.
```

---

### Case 2

**Complete console output:**

```
Geef een naam: Jan
Geef een gewicht: 90
Geef een lengte: 
1,5
Jan weegt 90 kg en is 1,5 m groot. De BMI is 40.
```

**Input:**

```
Jan
90
1,5
```

**Expected Output:**

```
Jan weegt 90 kg en is 1,5 m groot. De BMI is 40.
```

---

### Case 3

**Complete console output:**

```
Geef een naam: Jean-Luc
Geef een gewicht: 67
Geef een lengte: 
1,6
Jean-Luc weegt 67 kg en is 1,6 m groot. De BMI is 26,2.
```

**Input:**

```
Jean-Luc
67
1,6
```

**Expected Output:**

```
Jean-Luc weegt 67 kg en is 1,6 m groot. De BMI is 26,2.
```

---

### Case 4

**Complete console output:**

```
Geef een naam: Jan
Geef een gewicht: 120,25
Geef een lengte: 
1,75
Jan weegt 120,25 kg en is 1,75 m groot. De BMI is 39,3.
```

**Input:**

```
Jan
120,25
1,75
```

**Expected Output:**

```
Jan weegt 120,25 kg en is 1,75 m groot. De BMI is 39,3.
```

---

### Case 5

**Complete console output:**

```
Geef een naam: Amina
Geef een gewicht: 50,5
Geef een lengte: 
1,8
Amina weegt 50,5 kg en is 1,8 m groot. De BMI is 15,6.
```

**Input:**

```
Amina
50,5
1,8
```

**Expected Output:**

```
Amina weegt 50,5 kg en is 1,8 m groot. De BMI is 15,6.
```

---

### Case 6

**Complete console output:**

```
Geef een naam: L
Geef een gewicht: 67
Geef een lengte: 
1,5
L weegt 67 kg en is 1,5 m groot. De BMI is 29,8.
```

**Input:**

```
L
67
1,5
```

**Expected Output:**

```
L weegt 67 kg en is 1,5 m groot. De BMI is 29,8.
```

---

### Case 7

**Complete console output:**

```
Geef een naam: Amina
Geef een gewicht: 120,25
Geef een lengte: 
2
Amina weegt 120,25 kg en is 2 m groot. De BMI is 30,1.
```

**Input:**

```
Amina
120,25
2
```

**Expected Output:**

```
Amina weegt 120,25 kg en is 2 m groot. De BMI is 30,1.
```

---

### Case 8

**Complete console output:**

```
Geef een naam: Jean-Luc
Geef een gewicht: 50,5
Geef een lengte: 
1,75
Jean-Luc weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

**Input:**

```
Jean-Luc
50,5
1,75
```

**Expected Output:**

```
Jean-Luc weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

---

### Case 9

**Complete console output:**

```
Geef een naam: Amina
Geef een gewicht: 50,5
Geef een lengte: 
1,5
Amina weegt 50,5 kg en is 1,5 m groot. De BMI is 22,4.
```

**Input:**

```
Amina
50,5
1,5
```

**Expected Output:**

```
Amina weegt 50,5 kg en is 1,5 m groot. De BMI is 22,4.
```

---

### Case 10

**Complete console output:**

```
Geef een naam: Jean-Luc
Geef een gewicht: 50,5
Geef een lengte: 
2
Jean-Luc weegt 50,5 kg en is 2 m groot. De BMI is 12,6.
```

**Input:**

```
Jean-Luc
50,5
2
```

**Expected Output:**

```
Jean-Luc weegt 50,5 kg en is 2 m groot. De BMI is 12,6.
```

---

### Case 11

**Complete console output:**

```
Geef een naam: Amina
Geef een gewicht: 50,5
Geef een lengte: 
1,75
Amina weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

**Input:**

```
Amina
50,5
1,75
```

**Expected Output:**

```
Amina weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

---

### Case 12

**Complete console output:**

```
Geef een naam: Jan
Geef een gewicht: 45
Geef een lengte: 
1,75
Jan weegt 45 kg en is 1,75 m groot. De BMI is 14,7.
```

**Input:**

```
Jan
45
1,75
```

**Expected Output:**

```
Jan weegt 45 kg en is 1,75 m groot. De BMI is 14,7.
```

---

### Case 13

**Complete console output:**

```
Geef een naam: L
Geef een gewicht: 50,5
Geef een lengte: 
1,75
L weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

**Input:**

```
L
50,5
1,75
```

**Expected Output:**

```
L weegt 50,5 kg en is 1,75 m groot. De BMI is 16,5.
```

---

### Case 14

**Complete console output:**

```
Geef een naam: L
Geef een gewicht: 90
Geef een lengte: 
1,75
L weegt 90 kg en is 1,75 m groot. De BMI is 29,4.
```

**Input:**

```
L
90
1,75
```

**Expected Output:**

```
L weegt 90 kg en is 1,75 m groot. De BMI is 29,4.
```

---

### Case 15

**Complete console output:**

```
Geef een naam: L
Geef een gewicht: 120,25
Geef een lengte: 
1,8
L weegt 120,25 kg en is 1,8 m groot. De BMI is 37,1.
```

**Input:**

```
L
120,25
1,8
```

**Expected Output:**

```
L weegt 120,25 kg en is 1,8 m groot. De BMI is 37,1.
```

---
