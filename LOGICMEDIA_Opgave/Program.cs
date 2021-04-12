using System;

namespace LOGICMEDIA_Opgave
{
    class Program
    {
        /*
         *Du har til opgave at løse nedenstående i C#: 
           Du har en liste af tal fra 1 - 100. 
           Jeg vil gerne du løber igennem listen. 
           For hvert tal i listen der kan deles ligeligt med 3 skal du udskrive dit [Fornavn]. 
           For hvert tal der kan deles ligeligt med 5 skal du udskrive dit [Efternavn]. 
           For hvert tal der kan deles ligeligt med 3 OG 5 skal du udskrive “[Fornavn][Efternavn]”. 
         *
         */
        private static void Main(string[] args)
        {
            const string Fornavn = "Jonas";
            const string Efternavn = "Holm";

            for (var i = 1; i <= 100; i++)
            {
                var str_i = i + " ";
                if ((i % 3 == 0) & (i % 5 == 0))
                    Console.WriteLine(str_i += Fornavn+ " " + Efternavn);
                else if (i % 3 == 0)
                    Console.WriteLine(str_i += Fornavn);
                else if (i % 5 == 0)
                    Console.WriteLine(str_i += Efternavn);
                else
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
