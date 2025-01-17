﻿using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace GoodMorningProgram;

class Program
{
    static void Main(string[] args)
    {
        var program = new GoodMorning();
        program.Run();
    }

}
/*
Her skal dere designe et program som skal returnere en bedskjed tilbake til en bruker basert på noen valgfrie parametere.
Dere kan selv bestemme hvilke parametere som skal bestemme hva hilsen kommer tilbake, men her kommer noen tips:

Kanskje vi kan bruke noe i DateTime objektet for å styre programflyt?

Er det mulig å bruke et dictionary som et lookup table her?

Trenger vi å parse brukerinput på noe vis?

Et forslag til oppgave er å skrive et program, som returnerer en custom hilsen basert på hva tidspunkt det er på maskinen nå.

Husk å skrive både pseudokode, samt å tegne programflyt.
Flytdiagrammet bør starte på bruker input.

Lykke til!
*/