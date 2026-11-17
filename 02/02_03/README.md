# 02_03

Maak een applicatie die het mogelijk maakt om de gegevens bij te houden in verhouding met het onderhoud van een auto. Allereerst geeft de gebruiker de hoeveelheid brandstof (in liter), huidig kilometerstand (in kilometer) en de kilometerstand (in kilometer) van het laatste onderhoud op. Vervolgens heeft de gebruiker de mogelijkheid om te kiezen uit een menu. Hierbij kan er gekozen worden om een aantal kilometers toe te voegen aan de kilometerstand. Hierna word een overzicht afgedrukt waarbij de status van de auto word weergegeven.

De hoeveelheid brandstof kan niet groter zijn dan 60 en niet kleiner zijn dan 0. Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden. Bij foutieve nieuwe waarde groter dan 60, wordt 60 ingesteld. Beide kilometerstanden kunnen niet kleiner zijn dan 0. Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden.

Per kilometer zal 0.05 liter verdwijnen uit de brandstof. Indien de brandstof onder de 10 liter komt, zal er vloeistof aangevuld moeten worden. Vanaf 25.000 kilometer gereden te hebben sinds het laatste onderhoud, zal er onderhoud aan de auto vereist zijn.

## Console applicatie

### Voorbeeld auto in orde
```plaintext
Geef hoeveelheid brandstof: 30
Geef huidige kilometerstand: 24000
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 2

Status
------
De auto is volledig in orde!
```

### Voorbeeld brandstof aanvullen
```plaintext
Geef hoeveelheid brandstof: 12
Geef huidige kilometerstand: 20000
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 3

Status
------
Voeg brandstof toe aub!
```

### Voorbeeld onderhoud vereist
```plaintext
Geef hoeveelheid brandstof: 60
Geef huidige kilometerstand: 24999
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 1

Status
------
Er is dringend onderhoud nodig!
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Geef hoeveelheid brandstof: 14.392091535897801
Geef huidige kilometerstand: 24000
Geef kilometerstand laatste onderhoud: 1000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
14.392091535897801
24000
1000
5
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 2

**Complete console output:**

```
Geef hoeveelheid brandstof: 7.349106100269934
Geef huidige kilometerstand: 0
Geef kilometerstand laatste onderhoud: 1000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

**Input:**

```
7.349106100269934
0
1000
2
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

---

### Case 3

**Complete console output:**

```
Geef hoeveelheid brandstof: 57.259362217627185
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Geef hoeveelheid brandstof: 4
De auto is volledig in orde!
```

**Input:**

```
57.259362217627185
24975
0
4
28.20860755802667
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 4

**Complete console output:**

```
Geef hoeveelheid brandstof: 15.43114486493857
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
Er is dringend onderhoud nodig!
```

**Input:**

```
15.43114486493857
24975
0
3
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
Er is dringend onderhoud nodig!
```

---

### Case 5

**Complete console output:**

```
Geef hoeveelheid brandstof: 3.7105612389686637
Geef huidige kilometerstand: 24000
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

**Input:**

```
3.7105612389686637
24000
0
5
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

---

### Case 6

**Complete console output:**

```
Geef hoeveelheid brandstof: 28.060165276244152
Geef huidige kilometerstand: 25000
Geef kilometerstand laatste onderhoud: 1000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
28.060165276244152
25000
1000
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 7

**Complete console output:**

```
Geef hoeveelheid brandstof: 30.305134079722073
Geef huidige kilometerstand: 0
Geef kilometerstand laatste onderhoud: 24000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
30.305134079722073
0
24000
2
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 8

**Complete console output:**

```
Geef hoeveelheid brandstof: 7.094545363642657
Geef huidige kilometerstand: 0
Geef kilometerstand laatste onderhoud: 24000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

**Input:**

```
7.094545363642657
0
24000
3
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

---

### Case 9

**Complete console output:**

```
Geef hoeveelheid brandstof: 23.265332788760876
Geef huidige kilometerstand: 25000
Geef kilometerstand laatste onderhoud: 24000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
23.265332788760876
25000
24000
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 10

**Complete console output:**

```
Geef hoeveelheid brandstof: 8.556036083951204
Geef huidige kilometerstand: 0
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

**Input:**

```
8.556036083951204
0
0
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Voeg brandstof toe aub!
```

---

### Case 11

**Complete console output:**

```
Geef hoeveelheid brandstof: 15.93057287394007
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 1000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
15.93057287394007
24975
1000
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 12

**Complete console output:**

```
Geef hoeveelheid brandstof: 33.649427164649616
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
33.649427164649616
24975
0
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 13

**Complete console output:**

```
Geef hoeveelheid brandstof: 53.82711150358801
Geef huidige kilometerstand: 24900
Geef kilometerstand laatste onderhoud: 24000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Geef hoeveelheid brandstof: 4
De auto is volledig in orde!
```

**Input:**

```
53.82711150358801
24900
24000
4
28.301141238807777
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 14

**Complete console output:**

```
Geef hoeveelheid brandstof: 23.29566293777313
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 1000
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

**Input:**

```
23.29566293777313
24975
1000
1
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: De auto is volledig in orde!
```

---

### Case 15

**Complete console output:**

```
Geef hoeveelheid brandstof: 26.62430414535418
Geef huidige kilometerstand: 24975
Geef kilometerstand laatste onderhoud: 0
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Er is dringend onderhoud nodig!
```

**Input:**

```
26.62430414535418
24975
0
2
```

**Expected Output:**

```
1. Voeg 25 kilometer toe
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit
Maak een keuze tussen 1 en 5: Er is dringend onderhoud nodig!
```

---
