using System;


namespace esercizio1;
class Lezione1
{
    static void Main(string[] args)
    {

        //LezioneUno();
        //VariabiliECostanti();
        //Esercizi1();
        //Casting();
        //Stringhe();
        //Esercizi2();
        Esercizi3();


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

        string nome = "mario";
        string cognome = "rossi";

        string format = string.Format("buongiorno sono {0} {1}", nome, cognome); //formattazione
        string interpol = string.Format($"buongiorno sono {nome} {cognome}"); //interpolazione
        string testMetodi = nome.ToUpper(); // altri metodi: toLower, Length , indexing , IndexOF , SubString


        Console.WriteLine(format);
        Console.WriteLine(interpol);
        Console.WriteLine(testMetodi);




    }


    static void Esercizi2()
    {
        //🍰 Esercizio 1
        //Scrivi un programma che dichiara due variabili numeriche e ne calcola la somma.Stampa il risultato a schermo.   

        int valore1Es1 = 4;
        int valore2Es1 = 3;
        int somma = valore1Es1 + valore2Es1;
        Console.WriteLine("la somma è :" + somma);



        //🍰 Esercizio 2
        //Scrivi un programma che dichiara due variabili numeriche e ne calcola la differenza.Stampa il risultato a schermo.
        int valore1Es2 = 44;
        int valore2Es2 = 32;
        int differenza = valore1Es2 - valore2Es2;
        Console.WriteLine("la differenza è :" + differenza);




        //🍰 Esercizio 3
        //Scrivi un programma che dichiara due variabili numeriche e ne calcola il prodotto.Stampa il risultato a schermo.
        int valore1Es3 = 4;
        int valore2Es3 = 5;
        int prodotto = valore1Es3 * valore2Es3;
        Console.WriteLine("il prodotto è :" + prodotto);




        //🍰 Esercizio 4
        //Scrivi un programma che dichiara due variabili numeriche intere e ne calcola il quoziente. Stampa il risultato a schermo.
        int valore1Es4 = 15;
        int valore2Es4 = 3;
        int quoziente = valore1Es4 / valore2Es4;
        Console.WriteLine("il quoziente è : " + quoziente);



        //🍰 Esercizio 5
        //Scrivi un programma che dichiara due variabili numeriche decimali e ne calcola il quoziente. Stampa il risultato a schermo.

        double valore1Es5 = 30.9;
        double valore2Es5 = 10.2;
        double quoziente2 = valore1Es5 / valore2Es5;
        Console.WriteLine("il quoziente è : " + quoziente2);


        //🍰 Esercizio 6
        //Scrivi un programma che dichiara due variabili numeriche e ne calcola il resto.Stampa il risultato a schermo.

        double valore1Es6 = 30;
        double valore2Es6 = 4;
        double resto = valore1Es6 % valore2Es6;
        Console.WriteLine("il resto è : " + resto);

        //🍰 Esercizio 7
        //Scrivi un programma che dichiara una variabile numerica e ne incrementa il valore di 1.Stampa il nuovo valore a schermo.

        int valore1Es7 = 15;
        valore1Es7 += 1;
        Console.WriteLine("+1 : " + valore1Es7);



        //🍰 Esercizio 8
        //Scrivi un programma che dichiara una variabile numerica e ne decrementa il valore di 1.Stampa il nuovo valore a schermo.

        int valore1Es8 = 15;
        valore1Es8 -= 1;
        Console.WriteLine("-1 : " + valore1Es8);


        //🍰 Esercizio 9
        //Scrivi un programma che dichiara una variabile numerica e ne calcola la radice quadrata. Stampa il risultato a schermo.

        int valore1Es9 = 25;
        valore1Es9 = (int) Math.Sqrt(valore1Es9); 
        Console.WriteLine("radice : " + valore1Es9);


        //🍰 Esercizio 10
        //Scrivi un programma che genera un numero casuale compreso tra 1 e 100.Stampa il numero generato a schermo.
        Random rnd = new Random();

        int random = rnd.Next(101);
        Console.WriteLine(random);


    }


    static void Esercizi3()
    {



    //🍰 Esercizio 1
    //Scrivi un programma che utilizzi un ciclo for per stampare i numeri da 1 a 10.

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + 1);
        }




        //🍰 Esercizio 2
        //Scrivi un programma che utilizzi un ciclo 'for' per calcolare la somma dei numeri da 1 a 100 e stampare il risultato.


        int totalEs2 = 0;
        for (int i = 1; i < 101; i++)
        {
            totalEs2 += i;
        }
        Console.WriteLine("totale : " + totalEs2);

        //🍰 Esercizio 3
        //Scrivi un programma che utilizzi un ciclo 'for' per stampare i numeri pari da 2 a 20.


        for (int i = 2; i < 22; i += 2)
        {
            Console.WriteLine(i); 
        }



        //🍰 Esercizio 4
        //Scrivi un programma che accetti un numero intero positivo da tastiera e utilizzi un ciclo 'for' per calcolarne il fattoriale.

        int inputEs4 = Convert.ToInt32(Console.ReadLine());
        int totalEs4 = 1;


        for(int i = 1; i < inputEs4 + 1; i++)
        {
            totalEs4 *= i;


        }
        Console.WriteLine("fattoriale : " + totalEs4);




        //🍰 Esercizio 5
        //Scrivi un programma che utilizzi un ciclo for per stampare i caratteri dalla lettera 'A' alla lettera 'Z'.


        for (char c = 'A'; c < 'Z' + 1; c++)
        {
            Console.WriteLine(c);
        }




        //🍰 Esercizio 6
        //Scrivi un programma che accetti un numero intero da tastiera e utilizzi un ciclo 'for' per stampare la tabellina di quel numero da 1 a 10.
        //🍰 Esercizio 7
        //Scrivi un programma che utilizzi un ciclo 'for' per stampare i numeri da 10 a 1 in ordine decrescente.
        //🍰 Esercizio 8
        //: Scrivi un programma che definisca un array di interi e utilizzi un ciclo 'for' per stampare tutti gli elementi dell'array.
        //🍰 Esercizio 9
        //Scrivi un programma che accetti una stringa da tastiera e utilizzi un ciclo 'for' per stampare tutti i caratteri della stringa uno per uno.
        //🍰 Esercizio 10
        //Scrivi un programma che accetti due numeri interi da tastiera, uno come base e l'altro come esponente, e utilizzi un ciclo 'for' per calcolare la potenza della base elevata all'esponente.







    }




}







