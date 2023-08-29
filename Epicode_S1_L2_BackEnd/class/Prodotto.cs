using System;
public class Prodotto
{
    public string NomeProdotto { get; set; }
    public decimal Prezzo { get; set; }
    public int Quantita { get; set; }

    public decimal CalcolaTotale()
    {
        return Prezzo * Quantita;
    }
}
