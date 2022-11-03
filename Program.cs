/*
 * Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
    codice (numero intero)
    nome
    descrizione
    prezzo
    iva

    Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
    1. alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
    2. Il codice prodotto sia accessibile solo in lettura
    3. Gli altri attributi siano accessibili sia in lettura che in scrittura
    4. Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
    5. Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome

    BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri 
    (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
*/


// istanzia prodotto con tutte le informazioni usando il secondo costruttore
Prodotto prodotto1 = new Prodotto("realme", "octacore, 12GB RAM, quattro fotocamere");
// istanzia prodotto con solo il codice random usando il primo costruttore
//Prodotto prodotto2 = new Prodotto();

//accessibile solo in lettura
//stampa il codice prodotto
Console.WriteLine(prodotto1.GetCodice());


//accessibili sia lettura che scrittura
//settare il nome
//prodotto1.SetNome("Samsung");

//leggere il nome
Console.WriteLine(prodotto1.GetNome());


//accessibili sia lettura che scrittura
//settare la descrizione
//prodotto1.SetDescrizione("Ciao sono la nuova descrizione");

//leggere la descrizione
Console.WriteLine(prodotto1.GetDescrizione());



//set prezzo
prodotto1.SetPrezzo(500.99);
//prezzo senza iva
Console.WriteLine("Prezzo netto: " + prodotto1.GetPrezzo() + " euro");
//prezzo ivato
Console.WriteLine("Prezzo ivato: " + prodotto1.GetPrezzoIvato() + " euro");

//Nome esteso
prodotto1.NomeEsteso();

Console.WriteLine(prodotto1.CodicePadLeft());

//stampa intero prodotto 
//prodotto1.Stampa();




public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private int iva;

    //costruttore senza parametri
    public Prodotto()
    {
        codice = Codice();
    }

    //costruttore con parametri
    public Prodotto(string nome, string descrizione)
    {
        codice = Codice();
        this.nome = nome;
        this.descrizione = descrizione;
    }

    //stampa dell'intero prodotto
    public void Stampa()
    {
        Console.WriteLine("Codice prodotto: " + codice);
        Console.WriteLine("Nome prodotto: " + nome);
        Console.WriteLine("Descrizione prodotto: " + descrizione);
        Console.WriteLine("Prezzo netto: " + GetPrezzo() + " euro");
        Console.WriteLine("Prezzo ivato: " + GetPrezzoIvato() + " euro");
        Console.WriteLine("Iva: " + iva);
    }

    //creazione codice prodotto da utilizzare nel costruttore
    private int Codice()
    {
                                // 1 a 99999999
        codice = new Random().Next(1, 100000000);
        return codice;
    }

    //leggere il codice
    public int GetCodice()
    {
        return codice;
    }


    //leggere il nome
    public string GetNome()
    {
        return nome;
    }
    //settare il nome
    public void SetNome(string input)
    {
        this.nome = input;
    }


    //leggere la descrizione
    public string GetDescrizione()
    {
        return descrizione;
    }
    //settare la descrizione
    public void SetDescrizione(string input)
    {
        this.descrizione = input;
    }

    
    //leggere il prezzo
    public double GetPrezzo()
    {
        return prezzo;
    }
    //settare il prezzo
    public void SetPrezzo(double input)
    {
        this.prezzo = input;
    }
    //leggere il prezzo ivato
    public double GetPrezzoIvato()
    {
        double prezzoIvato =  prezzo + (prezzo * 0.22);
        prezzoIvato = Math.Round(prezzoIvato, 2);
        return prezzoIvato;
    }

    //ritorna il codice prodotto concatenato con il nome del prodotto
    public void NomeEsteso()
    {
        Console.WriteLine(codice + " " + nome);
    }


    //BONUS: legge il codice prodotto creato ed inserisce tanti 0 tante quante posizioni mancano fino a che la lunghezza del codice prodotto sia di 8 caratteri
    public string CodicePadLeft()
    {
        string codiceStringa = Convert.ToString(this.codice);

        while(codiceStringa.Length < 8)
        {
            codiceStringa = '0' + codiceStringa;
        }

        return codiceStringa;
    }
}