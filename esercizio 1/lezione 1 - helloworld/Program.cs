using System;


namespace esercizio1;
class Lezione1
{
    static void Main(string[] args)
    {

        LezioneUno();
        VariabiliECostanti();
        Esercizi1();
        Casting();
        Stringhe();


    }



    static void LezioneUno()
    {
        Console.WriteLine("Hello, World!");
        //Console.Read();
    }



    static void Esercizi1()
    {

        //🍰 Esercizio 1
        //scrivi un programma che dichiari tre variabili di tipo intero e successivamente le inizializzi con i valori 10, 20 e 30.
        int valore1Es1;
        int valore2Es1;
        int valore3Es1;
        valore1Es1 = 10;
        valore2Es1 = 20;
        valore3Es1 = 30;

        Console.WriteLine("valore 1 : " + valore1Es1 + " valore 2 : " + valore2Es1 + " valore 3 : " + valore3Es1);

        //🍰 esercizio 2
        //crea una costante numerica di tipo float chiamata "pi" e assegna il valore 3.14.
        float pi;
        pi = 3.14f;

        Console.WriteLine("pi greco : " + pi);

        //🍰 esercizio 3
        //scrivi un programma che chieda all'utente di inserire un numero intero e successivamente lo stampi a schermo.
        Console.WriteLine("inserisci un numero");
        string input;
        input = Console.ReadLine();

        Console.WriteLine("l'input inserito è : " + input);

        //🍰 esercizio 4
        //crea una variabile booleana chiamata "istrue" e assegnale il valore true.
        bool istrue = true;


        Console.WriteLine("vero ? " + istrue);

        //🍰 esercizio 5
        //scrivi un programma che dichiari due variabili di tipo intero, esegua l'addizione tra di esse e stampi il risultato.
        int valore1Es5 = 5;
        int valore2Es5 = 3;


        Console.WriteLine("somma :" + valore1Es5 + valore2Es5);

        //🍰 esercizio 6
        //scrivi un programma che dichiari una variabile di tipo float, la inizializzi con il valore 3.7 e successivamente la converta in un intero.
        float valore1Es6 = 3.7f;
        valore1Es6 = (int) 3;


        Console.WriteLine("conversione : " + valore1Es6);



        //🍰 esercizio 7
        //scrivi un programma che dichiari due variabili di tipo stringa, le inizializzi con due nomi diversi e successivamente le concateni in un'unica stringa.


        string nome1 = "gianni";
        string nome2 = "franco";

        Console.WriteLine(nome2 + nome1);

        //🍰 esercizio 8
        //crea una variabile di tipo carattere chiamata "lettera" e assegnale il valore 'a'.

        char lettera1ES8 = 'A';

        Console.WriteLine(lettera1ES8);


        //🍰 esercizio 9
        //scrivi un programma che dichiari una variabile intera, le assegni il valore 5 e successivamente incrementi il suo valore di 1.

        int valore1ES9 = 10;
        valore1ES9 += 1;
        Console.WriteLine(valore1ES9);


        //🍰 esercizio 10
        //scrivi un programma che dichiari una costante di tipo stringa chiamata "nome_prodotto" e assegnale il valore "computer".successivamente, stampa a schermo il messaggio "il prodotto selezionato è: computer".

        string nome_prodotto = "computer";

        Console.WriteLine("il prodotto selezionato è: " + nome_prodotto);


    }






    static void VariabiliECostanti()
    {
        //commento
        string cognome; // dichiarazione variabile
        cognome = "rossi";// assegnazione 
        string nome = "ale"; //creazione e inizializzazione variabile
        const string secondoNome = "ale"; //creazione e inizializzazione CONSTANTE

        cognome = "verdi"; //riassegnazione

        Console.WriteLine("ciao io sono: " + nome + " " + cognome); //concatenazione string
        Console.Read();
    }

    static void Casting()
    {
        // casting
        int prova = 345;
        long qwerty = prova;

        double doppio = 35.56;
        int intero = (int)doppio;

        Console.WriteLine("long : " + qwerty + " intero : " + intero);


        string test = "34";
        bool boleano = true;

        string stringa = Convert.ToString(test); // conversione da int a string

        Console.WriteLine("stringa : " + stringa);



    }

    static void Stringhe()
    {

        string stringa1 = "citazione : \n\"si vive una volta sola\""; // escape dei caratteri
        Console.WriteLine(stringa1);

        string nome = "mario"
        string cognome = "rossi"

        string format = string.Format("buongiorno sono {0} {1}", nome, cognome) //formattazione
        string interpol = string.Format($"buongiorno sono {nome} {cognome}") //interpolazione
        string testMetodi = nome.ToUpper(); // altri metodi: toLower, Length , indexing , IndexOF , SubString


        Console.WriteLine(format);
        Console.WriteLine(interpol);
        Console.WriteLine(testMetodi);




    }

}







