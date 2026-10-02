/*
 * Realizzare un programma C# da console per gestire un semplice ordine
effettuato in una libreria. Il programma deve chiedere all'utente il
nome del cliente, il numero di libri acquistati, il prezzo di un singolo
libro, se il cliente è uno studente (forse qui serve qualcosa di nuovo) e il tipo di consegna desiderato (spedizione, ritiro).

Dopo aver acquisito i dati, il programma deve calcolare il subtotale
dell'ordine moltiplicando il numero dei libri per il prezzo unitario. La spedizione costa 5 euro. 

Al termine, il programma deve mostrare l'elenco dei libri
acquistati e un riepilogo contenente il nome del cliente, la quantità,
il prezzo unitario, il tipo di consegna, il subtotale, le
eventuali spese di spedizione e il totale finale. Deve inoltre mostrare
un messaggio conclusivo diverso (forse qui serve qualcosa di nuovo)  in base all'importo dell'ordine.
Es: grazie per il tuo ordine! - Ordine non valido! - Ordine di piccolo importo!. 

Per realizzare il programma utilizzare variabili e costanti locali,
i tipi string, int, decimal e bool, gli operatori aritmetici, logici e
di confronto, le strutture if, else if, else. Tutto il codice deve essere scritto all'interno del metodo Main.

Il codice deve rispettare i principi di base del Clean Code, utilizzando
nomi chiari e descrittivi, un'indentazione coerente e una suddivisione
ordinata delle diverse parti del programma.
 */

using System;

class Program
{
    static void Main()
    {
        // Costante che indica il costo della spedizione
        const decimal shippingCost = 5;

        // Chiediamo il nome del cliente
        Console.Write("Customer name: ");
        string name = Console.ReadLine()!;

        // Chiediamo il numero di libri acquistati
        Console.Write("Number of books: ");
        int books = int.Parse(Console.ReadLine()!);

        // Chiediamo il prezzo di un singolo libro
        Console.Write("Price of one book: ");
        decimal price = decimal.Parse(Console.ReadLine()!);

        // Chiediamo se il cliente è uno studente
        Console.Write("Are you a student? (yes/no): ");
        string answer = Console.ReadLine()!;

        // Trasformiamo la risposta in un valore true o false
        bool student = answer == "yes";

        // Chiediamo il tipo di consegna
        Console.Write("Delivery type (shipping/pickup): ");
        string delivery = Console.ReadLine()!;

        // Calcoliamo il subtotale
        decimal subtotal = books * price;

        // Inizialmente le spese di spedizione sono 0
        decimal shipping = 0;

        // Se il cliente sceglie la spedizione, aggiungiamo 5 euro
        if (delivery == "shipping")
        {
            shipping = shippingCost;
        }

        // Calcoliamo il totale finale
        decimal total = subtotal + shipping;

        // Mostriamo il riepilogo dell'ordine
        Console.WriteLine();
        Console.WriteLine("----- ORDER SUMMARY -----");

        Console.WriteLine("Customer: " + name);
        Console.WriteLine("Number of books: " + books);
        Console.WriteLine("Price of one book: " + price + " euros");
        Console.WriteLine("Student: " + student);
        Console.WriteLine("Delivery: " + delivery);
        Console.WriteLine("Subtotal: " + subtotal + " euros");
        Console.WriteLine("Shipping: " + shipping + " euros");
        Console.WriteLine("Total: " + total + " euros");

        // Controlliamo se l'ordine non è valido
        if (books <= 0 || price <= 0)
        {
            Console.WriteLine("Invalid order!");
        }
        // Controlliamo se l'ordine è di piccolo importo
        else if (total < 20)
        {
            Console.WriteLine("Small order!");
        }
        // Se non ci sono problemi, mostriamo il messaggio finale
        else
        {
            Console.WriteLine("Thank you for your order!");
        }
    }
}


