using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


/*
    emerald 1
    diamond 2
    sapphire 3
    onyx 4
    ruby 5 
    joker 6 
 */


//main jak w cpp, będą się tu znajdować rzeczy które odpowiadają za wykonanie programu
namespace Szkielete_na_obiektowe
{
    class MainClass
    {
        
        static void Main()
        {
            string iloscgraczy;
            int iloscgraczyInt;
            Console.WriteLine("Witajcie Gracze, ilu was jest");
            iloscgraczy= Console.ReadLine();

            bool isParsable = Int32.TryParse(iloscgraczy, out iloscgraczyInt);
            //sprawdzenie ilosci gracyz
            if (isParsable==true)
            {
                iloscgraczyInt= Int32.Parse(iloscgraczy);

                if (iloscgraczyInt < 2)
                {
                    Console.WriteLine("Sam nie jesteś w stanie zagrać, poproś kogoś o za granie z tobą! :)");
                }
                else if(iloscgraczyInt>4)
                {
                    Console.WriteLine("Maks to 4 graczy :)");
                }
                else
                {
                    Console.WriteLine("Jest: ");
                    Console.WriteLine(iloscgraczy);
                    Console.WriteLine(" Graczy!");
                }
            }
            else { Console.WriteLine("Nie wpisałeś liczby graczy"); }
            List<Player> players = new List<Player>(); 

            for (int i = 1; i < iloscgraczyInt+1; i++)
            {
                players.Add(new Player());
                Console.WriteLine("Wpisz imie gracza numer ");
                Console.WriteLine(i);
                Console.WriteLine(": ");

                players[i - 1].Name = Console.ReadLine();
                //Console.WriteLine(players[i-1].Name);
                players[i - 1].PlayerID = i;
            }
            //wczytanie danych
            
           
 
            List<Card> cards = new List<Card>();
            {
                string CardsFileName =
                    @"C:\Users\Jakub\source\repos\Szkielete na obiektowe\Szkielete na obiektowe\karty.json";
                if (File.Exists(CardsFileName))
                {
                    cards=
                        JsonConvert.DeserializeObject<List<Card>>(File.ReadAllText(CardsFileName));
                    
                }
                else
                {
                    Console.WriteLine("Brak pliku z kartami");
                }
            }
            /*
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(cards[i].cardLevel);
                Console.WriteLine(cards[i].points);
                Console.WriteLine(cards[i].emeraldCost);
                Console.WriteLine(cards[i].diamondCost);
                Console.WriteLine(cards[i].sapphireCost);
                Console.WriteLine(cards[i].onyxCost);
                Console.WriteLine(cards[i].rubyCost);
            }*/
            List<Nobles> nobles = new List<Nobles>();
            {
                string NoblesFileName =
                    @"C:\Users\Jakub\source\repos\Szkielete na obiektowe\Szkielete na obiektowe\noblisci.json";
                if (File.Exists(NoblesFileName))
                {
                    nobles =
                        JsonConvert.DeserializeObject<List<Nobles>>(File.ReadAllText(NoblesFileName));

                }
                else
                {
                    Console.WriteLine("Brak pliku ze szlachta");
                }
            }



            //start gry
            const int progwygranej = 15;
            //zasady gry w zaleznosci od ilosci graczy:
            TokensOnBoard tokensonboard = new TokensOnBoard();
            int value = 0;
            switch (iloscgraczyInt)
            {
                case 4:
                    value = 7;
                    tokensonboard.emeraldTokenOnBoard = value;
                    tokensonboard.diamondTokenOnBoard = value;
                    tokensonboard.sapphireTokenOnBoard = value;
                    tokensonboard.onyxTokenOnBoard = value;
                    tokensonboard.rubyTokenOnBoard = value;
                    tokensonboard.jokerTokenOnBoard = 5;

                    break;
                case 3:
                    value = 5;
                    tokensonboard.emeraldTokenOnBoard = value;
                    tokensonboard.diamondTokenOnBoard = value;
                    tokensonboard.sapphireTokenOnBoard = value;
                    tokensonboard.onyxTokenOnBoard = value;
                    tokensonboard.rubyTokenOnBoard = value;
                    tokensonboard.jokerTokenOnBoard = 5;
                    break;
                case 2:
                    value = 4;
                    tokensonboard.emeraldTokenOnBoard = value;
                    tokensonboard.diamondTokenOnBoard = value;
                    tokensonboard.sapphireTokenOnBoard = value;
                    tokensonboard.onyxTokenOnBoard = value;
                    tokensonboard.rubyTokenOnBoard = value;
                    tokensonboard.jokerTokenOnBoard = 5;
                    break;
            }

            List<Card> cardsonboard= new List<Card>();
            for (int i=0; i<4; i++)
            {
                Random r = new Random();
                int rInt = r.Next(0, 48);

                cards[rInt].transfering(1);
                cardsonboard.Add(cards[rInt]);
                rInt = r.Next(0, 48+28);
                cards[rInt].transfering(1);
                cardsonboard.Add(cards[rInt]);
                rInt = r.Next(0, 48 + 28+18);
                cards[rInt].transfering(1);
                cardsonboard.Add(cards[rInt]);
            }
            for (int i=0; i<12;i++)
            {
                Console.WriteLine(cardsonboard[i].cardLevel);
                Console.WriteLine(cardsonboard[i].points);
                Console.WriteLine(cardsonboard[i].emeraldCost);
                Console.WriteLine(cardsonboard[i].diamondCost);
                Console.WriteLine(cardsonboard[i].sapphireCost);
                Console.WriteLine(cardsonboard[i].onyxCost);
                Console.WriteLine(cardsonboard[i].rubyCost);
            }

            int graczktorymature = 1;
            //while (players[graczktorymature].Points>)
        }
    }
}