using System;
using System.Collections.Generic;

namespace Aula23Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto cell1 = new Produto();
            cell1.Nome = "Iphone X";
            cell1.Codigo = 1;
            cell1.Preco = 4000f;

            produtos.Add(cell1);

            //Adicionamos produtos através de instâncias com construtores 

            produtos.Add(new Produto("Xiomi", 2, 1999.99f));

            produtos.Add(new Produto("Windowns Phone", 3, 999.99f));

            produtos.Add(new Produto("Asus", 3, 899.99f));
            produtos.Add(new Produto("Asus", 4, 899.99f));

            //Varremos os Produtos com o foreach

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            //Removemos itens através do método array
            produtos.Remove(cell1);

            produtos.RemoveAt(2);

            produtos.RemoveAll(p => p.Nome == "Asus");

            //Varremos os Produtos com o foreach

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            //Serve para achar um Produto, pelo nome

            Produto xiomi  = produtos.Find(x => x.Nome == "Xiomi");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(xiomi.Preco);
            Console.ResetColor();

            //Cartao

            List<Cartao> cards = new List<Cartao>();

            cards.Add(new Cartao("Vinicius", 485210589, "Visa", 04/2021, 598));
            cards.Add(new Cartao("André", 718545284, "MasterCard", 07/2021, 666));
            cards.Add(new Cartao("Marcos", 257486876, "NuBank", 12/2020, 785));
            cards.Add(new Cartao("Lucilene", 551478935, "ELO", 08/2022, 386));

            foreach(Cartao c in cards){

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dados dos seus cartões cadastrados: ");
                Console.WriteLine();
                Console.WriteLine($"Titular: {c.Titular} - Numero: {c.Numero} - Bandeira: {c.Bandeira} - Vencimento: {c.Vencimento} - CVV: {c.Cvv}");
                Console.ResetColor();

        
            }

            cards.RemoveAt(2);
            Console.WriteLine();

            foreach(Cartao c in cards){

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Dados dos seus cartões cadastrados: ");
                Console.WriteLine();
                Console.WriteLine($"Titular: {c.Titular} - Numero: {c.Numero} - Bandeira: {c.Bandeira} - Vencimento: {c.Vencimento} - CVV: {c.Cvv}");
                Console.ResetColor();

        
            }






            
        }
    }
}
