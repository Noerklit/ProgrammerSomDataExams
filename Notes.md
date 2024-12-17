# Sammenligning mellem DFA og NFA

## **1. Hvad er en DFA og en NFA?**
- En **DFA** (Deterministic Finite Automaton) og en **NFA** (Nondeterministic Finite Automaton) er **modeller**, der bruges til at **genkende mønstre** i inputstrømme, som f.eks. i et sprog eller en maskine.
- De bruges i **programmeringssprog** (f.eks. til lexere) og i **teoretisk datalogi** til at forstå, hvordan en maskine kan acceptere eller afvise input.

---

## **2. DFA (Deterministic Finite Automaton)**

### **Hovedidé**:
- En **DFA** er **deterministisk**: For hvert input-symbol er der **kun én mulighed** for, hvilken tilstand maskinen går til næste gang.
- **Ingen tvivl!** Maskinen ved altid præcis, hvad den skal gøre.

### **Egenskaber**:
1. **Entydige overgange**:
   - Hvert input-symbol i en given tilstand har **kun én vej videre**.
2. **Ingen ε-overgange**:
   - En DFA kan **ikke skifte tilstand uden et input-symbol**.
3. **Tilstande og overgange**:
   - For hvert input-symbol er der **en overgang** fra én tilstand til en anden.

### **Eksempel på DFA**
Lad os lave en DFA, der genkender **strenge med præcis "ab"** som input.

**Diagram**:
```
(q0) --a--> (q1) --b--> (q2) <-- Accept
(q0) -- andre --> (q0)
(q1) -- andre --> (q0)
(q2) -- andre --> (q2)
```

- **Starttilstand**: `q0`.
- **Overgange**:
   - Fra `q0`: Hvis input er `a`, gå til `q1`. Ellers bliv i `q0`.
   - Fra `q1`: Hvis input er `b`, gå til `q2`. Ellers gå tilbage til `q0`.
   - Fra `q2`: `q2` er en **accept-tilstand**.

**Input-eksempler**:
- Input: `"ab"` → **Accepteret**.
- Input: `"a"` → **Afvist** (mangler `b`).
- Input: `"abc"` → **Accepteret** (de første to tegn er "ab").
- Input: `"ba"` → **Afvist** (fejlrækkefølge).

---

## **3. NFA (Nondeterministic Finite Automaton)**

### **Hovedidé**:
- En **NFA** er **ikke-deterministisk**: For et input-symbol kan der være **flere muligheder** for, hvilken tilstand maskinen skal gå til næste gang.
- **Valgfrihed!** Maskinen kan "prøve alle veje på én gang" (konceptuelt).

### **Egenskaber**:
1. **Flere overgange**:
   - For et input-symbol kan der være **flere mulige veje**.
2. **ε-overgange**:
   - En NFA kan **skifte tilstand uden et input-symbol** (dvs. "gratis" overgang).
3. **Ikke-determinisme**:
   - Maskinen prøver **alle mulige veje samtidig**, indtil én af dem fører til succes.

### **Eksempel på NFA**
Lad os lave en NFA, der **genkender "ab" eller "a"**.

**Diagram**:
```
(q0) --a--> (q1) --b--> (q2) <-- Accept
 (q0) --a--> (q2) <-- Accept
```

- **Starttilstand**: `q0`.
- **Overgange**:
   - Fra `q0`: Hvis input er `a`, kan maskinen vælge **to veje**:
     1. Gå til `q1` (og vente på `b`).
     2. Gå direkte til `q2` (accepter input "a").
   - Fra `q1`: Hvis input er `b`, gå til `q2`.
   - `q2` er en **accept-tilstand**.

**Input-eksempler**:
- Input: `"a"` → **Accepteret** (den anden vej fra `q0` til `q2`).
- Input: `"ab"` → **Accepteret** (den første vej fra `q0` → `q1` → `q2`).
- Input: `"b"` → **Afvist** (ingen overgang fra `q0`).

---

## **4. Sammenligning mellem DFA og NFA**

| **Egenskab**            | **DFA**                         | **NFA**                         |
|-------------------------|---------------------------------|---------------------------------|
| Overgange               | Én vej pr. input-symbol         | Flere veje pr. input-symbol     |
| ε-overgange             | Ikke tilladt                    | Tilladt                         |
| Determinisme            | Kun én mulig sti                | Flere mulige stier              |
| Implementering          | Nem og entydig                 | Sværere at implementere         |
| Tilstande               | Flere tilstande ofte kræves     | Færre tilstande typisk          |
| Løsning af input        | Går én sti ad gangen            | Prøver alle stier samtidig      |

---

## **5. Hovedpunkter at huske**
- **DFA**:
   - **Én overgang** pr. input fra en tilstand.
   - Simpel og entydig.
   - Ingen ε-overgange.

- **NFA**:
   - **Flere mulige overgange** pr. input.
   - Kan have **ε-overgange**.
   - Konceptuelt prøver alle veje samtidig.

---

## **6. Ekstra info: NFA kan konverteres til DFA**
- **NFA og DFA er lige stærke**: NFA kan altid **konverteres** til en DFA.
- En DFA kræver dog ofte flere tilstande for at repræsentere det samme sprog.

---

## **7. Metafor til at huske forskellen**
- **DFA**: Som en **GPS**, der kun giver dig én rute at følge. Ingen tvivl!
- **NFA**: Som at stå ved et **kryds** og kunne tage flere veje på samme tid. Du prøver alle veje parallelt.

---

## **Opsummering**
- DFA: Entydig overgang, ingen ε-overgange.
- NFA: Flere overgange og ε-overgange er tilladt.
- NFA er konceptuelt mere fleksibel, men DFA er lettere at implementere.
