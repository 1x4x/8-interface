# C# – Övning 8: Interface

Det här projektpaketet innehåller lösningar till **Övning 8 – Interface** i C#.

## Innehåll

- `Del1_Interface/Program.cs`
  - Definierar interfacet `IProgram` med metoden `Start()`.
  - Klassen `Program1` implementerar `IProgram` och `IExtra`.
  - Klassen `Program2` implementerar `IProgram`.
  - Visar hur en klass kan implementera flera interface.

- `Extra_Uppgift/Program.cs`
  - Definierar två interface: `IFirst` och `ISecond`.
  - Båda interfacen har metoden `Run()`, men med olika returtyper (`void` respektive `int`).
  - Visar explicit interface implementation.
  - `int`-metoden returnerar värdet `7`.

## Så kör du koden

Varje mapp innehåller ett separat C#-exempel. Kör dem var för sig:

1. Öppna Visual Studio.
2. Skapa ett nytt **Console App**-projekt i C#.
3. Öppna projektets `Program.cs`.
4. Ersätt innehållet med koden från `Program.cs` i den valda mappen.
5. Kör programmet.

> Kör exemplen som separata projekt eftersom båda filerna innehåller en klass som heter `Program`.

## Förväntad utskrift

### Del 1 – Interface

```text
Nu kör vi program 1
Detta är en extra metod
Nu kör vi program 2
```

### Extra uppgift

```text
Void Run-metoden körs
Int Run-metoden körs
Returvärde: 7
```

## Vad visar övningen?

- Ett **interface** definierar ett kontrakt som en klass ska uppfylla.
- En klass kan implementera flera interface.
- Variabler av interfacetyp kan användas för att anropa de metoder som interfacet beskriver.
- **Explicit interface implementation** gör det möjligt att implementera två interface som har metoder med samma namn och parametrar men olika returtyper.

## Teknik

- Språk: C#
- Projekttyp: Console App
