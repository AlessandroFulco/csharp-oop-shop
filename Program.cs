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

//stampa il codice prodotto
Console.WriteLine(prodotto1.Codice);


//settare il nome
//prodotto1.SetNome("Samsung");

//leggere il nome
Console.WriteLine(prodotto1.Nome);


//settare la descrizione
//prodotto1.SetDescrizione("Ciao sono la nuova descrizione");

//leggere la descrizione
Console.WriteLine(prodotto1.Descrizione);



//set prezzo
prodotto1.Prezzo = 500.99;
//set iva
prodotto1.Iva = 22;
//prezzo senza iva
Console.WriteLine("Prezzo netto: " + prodotto1.Prezzo + " euro");
//prezzo ivato
Console.WriteLine("Prezzo ivato: " + prodotto1.PrezzoIvato + " euro");

//Nome esteso
Console.WriteLine(prodotto1.NomeEsteso());

Console.WriteLine(prodotto1.CodicePadLeft());

//stampa intero prodotto 
//prodotto1.Stampa();




public class Prodotto
{
    public int Codice { get; private set;  }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }
    public double PrezzoIvato
    {
        get
        {
            return Math.Round(Prezzo + (Prezzo / 100 * Iva), 2 );
        }
    }

    //costruttore senza parametri
    public Prodotto()
    {
        Codice = GeneratoreCodiceProdotto();
    }

    //costruttore con parametri
    public Prodotto(string nome, string descrizione)
    {
        Codice = GeneratoreCodiceProdotto();
        Nome = nome;
        this.Descrizione = descrizione;
    }

    //stampa dell'intero prodotto
    public void Stampa()
    {
        Console.WriteLine("Codice prodotto: " + Codice);
        Console.WriteLine("Nome prodotto: " + Nome);
        Console.WriteLine("Descrizione prodotto: " + Descrizione);
        Console.WriteLine("Prezzo netto: " + Prezzo + " euro");
        Console.WriteLine("Prezzo ivato: " + PrezzoIvato + " euro");
        Console.WriteLine("Iva: " + Iva);
    }

    //creazione codice prodotto da utilizzare nel costruttore
    private int GeneratoreCodiceProdotto()
    {
                                // 1 a 99999999
        Codice = new Random().Next(1, 100000000);
        return Codice;
    }

    //ritorna il codice prodotto concatenato con il nome del prodotto
    public string NomeEsteso()
    {
        return Codice + " " + Nome;
    }


    //BONUS: legge il codice prodotto creato ed inserisce tanti 0 tante quante posizioni mancano fino a che la lunghezza del codice prodotto sia di 8 caratteri
    public string CodicePadLeft()
    {
        string codiceStringa = Convert.ToString(this.Codice);

        while (codiceStringa.Length < 8)
        {
            codiceStringa = '0' + codiceStringa;
        }

        return codiceStringa;
    }

    ////leggere il codice
    //public int GetCodice()
    //{
    //    return Codice;
    //}


    ////leggere il nome
    //public string GetNome()
    //{
    //    return nome;
    //}
    ////settare il nome
    //public void SetNome(string input)
    //{
    //    this.nome = input;
    //}


    ////leggere la descrizione
    //public string GetDescrizione()
    //{
    //    return descrizione;
    //}
    ////settare la descrizione
    //public void SetDescrizione(string input)
    //{
    //    this.descrizione = input;
    //}


    ////leggere il prezzo
    //public double GetPrezzo()
    //{
    //    return prezzo;
    //}
    ////settare il prezzo
    //public void SetPrezzo(double input)
    //{
    //    this.prezzo = input;
    //}
    ////leggere il prezzo ivato
    //public double GetPrezzoIvato()
    //{
    //    double prezzoIvato =  Prezzo + (Prezzo * 0.22);
    //    prezzoIvato = Math.Round(prezzoIvato, 2);
    //    return prezzoIvato;
    //}


}