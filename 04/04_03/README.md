# 04_03

*Deze oefening is een uitbreiding op oefening 01.03*

Maak een applicatie die het mogelijk maakt om te berekenen hoeveel dagen het zou duren om een boek uit te lezen voor zowel paperbacks als audioboeken. Als bijkomende vraag wordt er aan de gebruiker allereerst gevraagd om aan te geven of het over een paperback of audioboek gaat. Er wordt de gebruiker dan de vraag gesteld om een boek in te voeren. Van een paperback willen we de titel, auteur en aantal bladzijden bijhouden. Van een audioboek willen we de titel, auteur, verteller en aantal speelminuten bijhouden. Vraag nu aan de gebruiker hoeveel bladzijden of leesminuten hij per dag leest. Het programma toont als resultaat de info van het boek en hoeveel dagen het zou duren om het boek uit te lezen.

Enkele voorbeelden:

```
1. Paperback
2. Audioboek

Maak een keuze: 1

Titel: De kleine prins
Auteur: Antoine de Saint-Exupéry
Bladzijden: 96

Bladzijden per dag: 10

Het boek De kleine prins van Antoine de Saint-Exupéry zou 10 dagen duren om uit te lezen.
```

```
1. Paperback
2. Audioboek

Maak een keuze: 2

Titel: The foxhole court
Auteur: Nora Sakavic
Verteller: Alexander Cendese
Speelminuten: 463

Speelminuten per dag: 45

Het boek The foxhole court van Nora Sakavic, verteld door Alexander Cendese zou 11 dagen duren om uit te lezen.
```

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
De kleine prins
Auteur: 
George Orwell
Bladzijden: 
10

Bladzijden per dag:
1

Het boek De kleine prins van George Orwell zou 10 dagen duren om uit te lezen.
```

**Input:**

```
1
De kleine prins
George Orwell
10
1
```

**Expected Output:**

```
Het boek De kleine prins van George Orwell zou 10 dagen duren om uit te lezen.
```

---

### Case 2

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
A Brief History of Time
Auteur: 
Antoine de Saint-Exupéry
Bladzijden: 
1000

Bladzijden per dag:
100

Het boek A Brief History of Time van Antoine de Saint-Exupéry zou 10 dagen duren om uit te lezen.
```

**Input:**

```
1
A Brief History of Time
Antoine de Saint-Exupéry
1000
100
```

**Expected Output:**

```
Het boek A Brief History of Time van Antoine de Saint-Exupéry zou 10 dagen duren om uit te lezen.
```

---

### Case 3

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
1984
Auteur: 
Antoine de Saint-Exupéry
Bladzijden: 
350

Bladzijden per dag:
500

Het boek 1984 van Antoine de Saint-Exupéry zou 1 dagen duren om uit te lezen.
```

**Input:**

```
1
1984
Antoine de Saint-Exupéry
350
500
```

**Expected Output:**

```
Het boek 1984 van Antoine de Saint-Exupéry zou 1 dagen duren om uit te lezen.
```

---

### Case 4

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
1984
Auteur: 
Yann Martel
Bladzijden: 
96

Bladzijden per dag:
500

Het boek 1984 van Yann Martel zou 1 dagen duren om uit te lezen.
```

**Input:**

```
1
1984
Yann Martel
96
500
```

**Expected Output:**

```
Het boek 1984 van Yann Martel zou 1 dagen duren om uit te lezen.
```

---

### Case 5

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
2

Titel: 
Educated
Auteur: 
J.R.R. Tolkien
Verteller: 
Alexander Cendese
Speelminuten: 
720

Speelminuten per dag:
45

Het boek Educated van J.R.R. Tolkien, verteld door Alexander Cendese zou 16 dagen duren om uit te lezen.
```

**Input:**

```
2
Educated
J.R.R. Tolkien
Alexander Cendese
720
45
```

**Expected Output:**

```
Het boek Educated van J.R.R. Tolkien, verteld door Alexander Cendese zou 16 dagen duren om uit te lezen.
```

---

### Case 6

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
Het leven van Pi
Auteur: 
Frank Herbert
Bladzijden: 
350

Bladzijden per dag:
100

Het boek Het leven van Pi van Frank Herbert zou 4 dagen duren om uit te lezen.
```

**Input:**

```
1
Het leven van Pi
Frank Herbert
350
100
```

**Expected Output:**

```
Het boek Het leven van Pi van Frank Herbert zou 4 dagen duren om uit te lezen.
```

---

### Case 7

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
2

Titel: 
Project Hail Mary
Auteur: 
Nora Sakavic
Verteller: 
Ray Porter
Speelminuten: 
720

Speelminuten per dag:
10

Het boek Project Hail Mary van Nora Sakavic, verteld door Ray Porter zou 72 dagen duren om uit te lezen.
```

**Input:**

```
2
Project Hail Mary
Nora Sakavic
Ray Porter
720
10
```

**Expected Output:**

```
Het boek Project Hail Mary van Nora Sakavic, verteld door Ray Porter zou 72 dagen duren om uit te lezen.
```

---

### Case 8

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
A Brief History of Time
Auteur: 
Stephen Hawking
Bladzijden: 
10

Bladzijden per dag:
10

Het boek A Brief History of Time van Stephen Hawking zou 1 dagen duren om uit te lezen.
```

**Input:**

```
1
A Brief History of Time
Stephen Hawking
10
10
```

**Expected Output:**

```
Het boek A Brief History of Time van Stephen Hawking zou 1 dagen duren om uit te lezen.
```

---

### Case 9

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
2

Titel: 
The foxhole court
Auteur: 
Andy Weir
Verteller: 
Ray Porter
Speelminuten: 
1

Speelminuten per dag:
45

Het boek The foxhole court van Andy Weir, verteld door Ray Porter zou 1 dagen duren om uit te lezen.
```

**Input:**

```
2
The foxhole court
Andy Weir
Ray Porter
1
45
```

**Expected Output:**

```
Het boek The foxhole court van Andy Weir, verteld door Ray Porter zou 1 dagen duren om uit te lezen.
```

---

### Case 10

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
Dune
Auteur: 
Frank Herbert
Bladzijden: 
1000

Bladzijden per dag:
500

Het boek Dune van Frank Herbert zou 2 dagen duren om uit te lezen.
```

**Input:**

```
1
Dune
Frank Herbert
1000
500
```

**Expected Output:**

```
Het boek Dune van Frank Herbert zou 2 dagen duren om uit te lezen.
```

---

### Case 11

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
2

Titel: 
Sapiens
Auteur: 
Tara Westover
Verteller: 
Alexander Cendese
Speelminuten: 
720

Speelminuten per dag:
45

Het boek Sapiens van Tara Westover, verteld door Alexander Cendese zou 16 dagen duren om uit te lezen.
```

**Input:**

```
2
Sapiens
Tara Westover
Alexander Cendese
720
45
```

**Expected Output:**

```
Het boek Sapiens van Tara Westover, verteld door Alexander Cendese zou 16 dagen duren om uit te lezen.
```

---

### Case 12

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
2

Titel: 
The Hobbit
Auteur: 
Yuval Noah Harari
Verteller: 
Julia Whelan
Speelminuten: 
1500

Speelminuten per dag:
45

Het boek The Hobbit van Yuval Noah Harari, verteld door Julia Whelan zou 34 dagen duren om uit te lezen.
```

**Input:**

```
2
The Hobbit
Yuval Noah Harari
Julia Whelan
1500
45
```

**Expected Output:**

```
Het boek The Hobbit van Yuval Noah Harari, verteld door Julia Whelan zou 34 dagen duren om uit te lezen.
```

---

### Case 13

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
A Brief History of Time
Auteur: 
Frank Herbert
Bladzijden: 
350

Bladzijden per dag:
10

Het boek A Brief History of Time van Frank Herbert zou 35 dagen duren om uit te lezen.
```

**Input:**

```
1
A Brief History of Time
Frank Herbert
350
10
```

**Expected Output:**

```
Het boek A Brief History of Time van Frank Herbert zou 35 dagen duren om uit te lezen.
```

---

### Case 14

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
A Brief History of Time
Auteur: 
Stephen Hawking
Bladzijden: 
96

Bladzijden per dag:
100

Het boek A Brief History of Time van Stephen Hawking zou 1 dagen duren om uit te lezen.
```

**Input:**

```
1
A Brief History of Time
Stephen Hawking
96
100
```

**Expected Output:**

```
Het boek A Brief History of Time van Stephen Hawking zou 1 dagen duren om uit te lezen.
```

---

### Case 15

**Complete console output:**

```
Kies een optie:
1. Paperback
2. Audioboek
1

Titel: 
Dune
Auteur: 
Frank Herbert
Bladzijden: 
1000

Bladzijden per dag:
10

Het boek Dune van Frank Herbert zou 100 dagen duren om uit te lezen.
```

**Input:**

```
1
Dune
Frank Herbert
1000
10
```

**Expected Output:**

```
Het boek Dune van Frank Herbert zou 100 dagen duren om uit te lezen.
```

---
