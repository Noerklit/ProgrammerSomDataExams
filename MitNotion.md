# Programmer som Data Exam Prep

Created: December 13, 2024 7:25 PM
Class: Programmer som Data
Type: Exam
Reviewed: No

dotnet fsi -r *jeres path til det her*/fsharp/FsLexYacc Runtime.dll Absyn.fs ExprPar.fs ExprLex.fs Expr.fs Parse.fs 

```bash
dotnet fsi -r /mnt/c/Users/mchrn/ITU/5_Semester/Programs_as_data/fsharp/FsLexYacc.Runtime.dll Absyn.fs FunPar.fs FunLex.fs Parse.fs Fun.fs ParseAndRun.fs

fslex --unicode ExprLex.fsl

fsyacc --module ExprPar ExprPar.fsy
```

- [x]  Lec01
- [x]  Lec02
- [x]  Lec03
- [x]  Lec04
- [x]  Lec05
- [x]  Lec06
- [x]  Lec09
    - Du kan kun køre ilspycmd commands i en cmd terminal, virker ikke i wsl. Alt andet burde være muligt at gøre igennem wsl
- [x]  Lec10 - tror det virker - men test hvordan man bruger den virtual machine der
    - Kan ihvertfald compile med gcc -o listmachine listmachine.c
    - Executes sådan her: ./listmachine ../../ex30.out 8 (fordi man skal være hvor executable er, men så skal man sørge for path til filen man giver den er korrekt)
- [x]  Lec11
- [x]  Lec13
- [ ]  Lec14 - er ikke eksamensmateriale
    - Her skal bruges et 32-bit flag på commanden. gcc -m32 try.o -o try

## DFA og NFA

**DFA - Deterministic Finite Automaton**

**NFA - Nondeterministic Finite Automaton**

Kun denne som kan bruge Epsilon move.



## Lav fra markdown til pdf med pandoc
pandoc MitNotion.md -o output.pdf