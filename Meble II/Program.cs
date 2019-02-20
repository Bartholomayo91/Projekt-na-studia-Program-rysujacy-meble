using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Meble_II
{
    //------------------------------------------------------------------------------------------------------Początek klasy WARDROBE-----------------------------------------------------------------------------------------------------------
    class Wardrobe
    {
        int _heightWardrobe;                //wysokość szafy
        int _widthWardrobe;                 //szerokość szafy
        char _symbol;
        int _open;

        public void DataWardrobe()
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("Podaj wysokość drzwi szafy (proszę o liczbę większą od 2) po czym nacisnij Enter");
                try
                {
                    _heightWardrobe = int.Parse(Console.ReadLine());
                    if (_heightWardrobe <= 2)
                    {
                        Console.WriteLine("Poproszę liczbę większa od 2.");
                        Console.WriteLine("Spróbuj ponownie (wcisnij dowolny klawisz).");
                        Console.ReadKey();
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        a = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Podany znak nie jest liczbą!");
                    Console.WriteLine("Spróbuj ponownie (wcisnij dowolny klawisz)");
                    Console.ReadKey();
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            bool t = true;
            Console.WriteLine("Podaj szerokość drzwi szafy (proszę o liczbę większą od 5) po czym nacisnij Enter");
            while (t)
            {
                try
                {
                    _widthWardrobe = int.Parse(Console.ReadLine());
                    if (_widthWardrobe <= 5)
                    {
                        Console.WriteLine("Poproszę liczbę większa od 5. Spróbuj ponownie(wcisnij dowolny klawisz");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine("                                                                          ");
                        Console.SetCursorPosition(0, 5);
                        Console.Write("                                                                              ");
                        Console.SetCursorPosition(0, 3);
                        t = true;
                    }
                    if (_widthWardrobe > 5)
                    {
                        t = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Podany znak nie jest liczbą! Spróbuj ponownie (wcisnij dowolny klawisz)");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("                                                                         ");
                    Console.SetCursorPosition(0, 5);
                    Console.Write("                                                                             ");
                    Console.SetCursorPosition(0, 3);
                    t = true;
                }
            }

            Console.WriteLine("Podaj symbol do rysowania szafy - dowolny znaczek z klawiatury i naciśnij Enter"); _symbol = (char)Console.Read();
            Console.WriteLine();

            // _color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true); //zmienia zczytanego stringa na typ consolecolor//nie dziala
        }
//#############################################
        public void StatusWardrobe()
        {
            Console.ReadLine();

            Console.WriteLine("Wybierz status szafy: ");
            Console.WriteLine("[1] Szafa zamknięta.");
            Console.WriteLine("[2] Szafa otwarta.");


             bool x = true;

             while (x)
              {
                  try
                  {
                      _open = int.Parse(Console.ReadLine());
                      if (_open == 1)
                      {
                          x = false;
                      }
                      else if (_open == 2)
                      {
                          x = false;
                      }
                  }
                  catch
                  {
                      Console.WriteLine("Nie ma takiej opcji w menu. Sprobuj ponownie.");
                      Console.WriteLine("Niepoprawny znak! Spróbuj ponownie. (naciśnij dowolny klawisz)");
                      Console.ReadKey();
                  }
              }
              
                if (_open == 1)
                {
                    Console.WriteLine("Wybrano status: zamknięta szafa.");
                }
                else if (_open == 2)
                {
                    Console.WriteLine("Wybrano status: otwarta szafa.");
                }

                Console.ReadLine();
        }
//#############################################
        public void DrawWardrobe(char t, int x, int y)
        {
            x = Console.CursorLeft;     //koordynaty
            y = Console.CursorTop;

            Console.SetCursorPosition(x, y);
            Console.Write(t);

        }
//#############################################
        public void PrintStatusWardrobe()
        {
            Console.ReadLine();
            if (_open == 1)
            {
                Console.Write("Obecny status szafy: zamknięta");

            }
            else if (_open == 2)
            {
                Console.Write("Obecny status szafy: otwarta");
            }
        }
 //#############################################
         public void PrintWardrobe()
        {
            Console.Clear();
            //StatusWardrobe();
            if (_open == 1)
            {
                Console.WriteLine();
                Console.SetCursorPosition(_widthWardrobe / 2 + 1, 7);
                if (_widthWardrobe % 2 == 0)
                {
                    for (int j = 0; j <= _widthWardrobe + 2; j++)
                    {
                        Console.Write("_");         //rysowanie górnej belki szafy
                    }
                }
                else
                {
                    for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("_");
                }
                int k = 8;
                for (int i = 0; i < _heightWardrobe; i++)//pętla rysująca w dół
                {
                    //Console.WriteLine();
                    Console.SetCursorPosition(_widthWardrobe / 2 + 1, k);

                    Console.Write("|");

                    for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, 0, 0); Console.Write("|");//pętla rysujaca połowę szafy w szerz
                    for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, _widthWardrobe / 2, 0); Console.Write("|");
                    k++;
                }
                Console.WriteLine();
                Console.SetCursorPosition(_widthWardrobe / 2 + 1, _heightWardrobe + 8);

                if (_widthWardrobe % 2 == 0)
                {
                    for (int j = 0; j <= _widthWardrobe + 2; j++) Console.Write("^");            //rysuje dolne nóżki szafy 
                }
                else
                {
                    for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("^");
                }
                Console.ResetColor();
            }
            else if(_open==2)
            {
                Console.WriteLine();
                Console.WriteLine("Szafa jest otwarta. Jesli chcesz wyswietlić zmień jes status na - zamknięta");
            }
        }
//#############################################
        public void _openWardroble()
        {
            Console.Clear();
            if (_open == 2)
            {
                Console.SetCursorPosition(_widthWardrobe / 2 + 1, 7);

            if (_widthWardrobe % 2 == 0)
            {
                for (int j = 0; j <= _widthWardrobe + 2; j++)
                    Console.Write("_");         //rysowanie górnej belki szafy
            }
            else
            {
                for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("_");
            }

            int k = 8;
            for (int i = 0; i < _heightWardrobe; i++)
            {
                Console.WriteLine();
                Console.Write("|");

                for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, 0, 0); Console.Write("|");

                if (_widthWardrobe % 2 == 0) { Console.SetCursorPosition(_widthWardrobe + (_widthWardrobe / 2 + 2) + 1, k); }
                else { Console.SetCursorPosition(_widthWardrobe + (_widthWardrobe / 2 + 2), k); }

                Console.Write("|");

                for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, _widthWardrobe * 2, 0);
                Console.Write("|");
                k++;

            }

            Console.WriteLine();
            Console.SetCursorPosition(_widthWardrobe / 2 + 1, _heightWardrobe + 8);

            if (_widthWardrobe % 2 == 0)
            {
                for (int j = 0; j <= _widthWardrobe + 2; j++) Console.Write("^");            //rysuje dolne nóżki szafy 
            }
            else
            {
                for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("^");
            }
        }
        else
        {
                Console.WriteLine("Szafa ma status zamknięta. Jeśli chcesz wyswietlić szafę otwartą, zmień jej status. (wciśnij dowolny klawisz)");
        }
            Console.ResetColor();
        }
//#############################################
        public void SupriseWardroble()
        {
            Console.Clear();
            if (_open == 2)
            {
                Console.SetCursorPosition(_widthWardrobe / 2 + 1, 7);

                if (_widthWardrobe % 2 == 0)
                {
                    for (int j = 0; j <= _widthWardrobe + 2; j++)
                        Console.Write("_");         //rysowanie górnej belki szafy
                }
                else
                {
                    for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("_");
                }
                int k = 8;
                for (int i = 0; i < _heightWardrobe; i++)
                {
                    Console.WriteLine();
                    Console.Write("|");

                    for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, 0, 0); Console.Write("|");

                    if (_widthWardrobe % 2 == 0) { Console.SetCursorPosition(_widthWardrobe + (_widthWardrobe / 2 + 2) + 1, k); }
                    else { Console.SetCursorPosition(_widthWardrobe + (_widthWardrobe / 2 + 2), k); }

                    Console.Write("|");

                    for (int j = 0; j < _widthWardrobe / 2; j++) DrawWardrobe(_symbol, _widthWardrobe * 2, 0);
                    Console.Write("|");
                    k++;
                }
                //Thread.Sleep(30);

                Console.WriteLine();
                Console.SetCursorPosition(_widthWardrobe / 2 + 1, _heightWardrobe + 8);

                if (_widthWardrobe % 2 == 0)
                {
                    for (int j = 0; j <= _widthWardrobe + 2; j++) Console.Write("^");            //rysuje dolne nóżki szafy 
                }
                else
                {
                    for (int j = 0; j <= _widthWardrobe + 1; j++) Console.Write("^");
                }
                if (_widthWardrobe % 2 == 0)
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(_widthWardrobe, 7 + _heightWardrobe / 3);
                    Console.Write("(0 0)");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(_widthWardrobe, 7 + _heightWardrobe / 3);

                    Console.Write("(- 0)");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(_widthWardrobe, 7 + _heightWardrobe / 3);

                    Console.Write("(0 0)");
                    Thread.Sleep(750);
                }
                else
                {
                    Console.ResetColor();
                    Console.SetCursorPosition(_widthWardrobe - 1, 7 + _heightWardrobe / 3);
                    Console.Write("(0 0)");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(_widthWardrobe - 1, 7 + _heightWardrobe / 3);

                    Console.Write("(- 0)");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(_widthWardrobe - 1, 7 + _heightWardrobe / 3);

                    Console.Write("(0 0)");
                    Thread.Sleep(750);
                }
            }

            else
            {
                Console.WriteLine("Szafa ma status zamknięta. Zmień jej status na otwartą, by zobaczyć niespodziankę. (wciśnij dowolny klawisz)");
            }
        }

        //----------------------------------------------------------------------------------------------------Koniec klasy WARDROBE------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------Początek klasy TABLE-------------------------------------------------------------------------------------------------------------
        class Table
        {
            private int _heightTable;                //wysokość stołu
            private int _widthTable;                 //szerokość stołu
            private char _symbol;                    //symbol wypełnienia
            int _nakrycie;

            public void DataTable()
            {
                bool b = true;
                while (b)
                {
                    Console.WriteLine("Podaj wysokość stołu (zalecana wartość większa niz 2) po czym naciśnij Enter:");
                    try
                    {
                        _heightTable = int.Parse(Console.ReadLine());
                        if (_heightTable <= 2)
                        {
                            Console.WriteLine("Poproszę liczbę większa od 2.");
                            Console.WriteLine("Spróbuj ponownie (wciśnij dowolny klawisz).");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            b = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Podany znak nie jest liczbą!");
                        Console.WriteLine("Spróbuj ponownie (wciśnij dowolny klawisz).");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.WriteLine("Podaj szerokość stołu (zalecana szerokość większa niż 3) po czym nacisnij Enter:");
                bool t = true;
                while (t) 
                {
                    try
                    {
                       _widthTable = int.Parse(Console.ReadLine());
                        if (_widthTable <= 3)
                        {
                            Console.WriteLine("Poproszę liczbę większa od 3. Spróbuj ponownie (wciśnij dowolny klawisz");
                            Console.ReadKey();
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("                                                                         ");
                            Console.SetCursorPosition(0, 5);
                            Console.Write("                                                                              ");
                            Console.SetCursorPosition(0, 3);
                        }
                        if (_widthTable > 3)
                        {
                            t = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Podany znak nie jest liczbą! Spróbuj ponownie (wcisnij dowolny klawisz)");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine("                                                                        ");
                        Console.SetCursorPosition(0, 5);
                        Console.Write("                                                                             ");
                        Console.SetCursorPosition(0, 3);
                    }

                } 
                Console.WriteLine("Podaj symbol do rysowania stołu - dowolny znaczek z klawiatury i naciśnij Enter:"); _symbol = (char)Console.Read();
                // _color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true); //zmienia zczytanego stringa na typ consolecolor//nie dziala(do wyjaśnienia)
                Console.ReadLine();
            }
 //#############################################
            public void StatusTable()
            {
                Console.ReadLine();

                Console.WriteLine("Wybierz status stołu: ");
                Console.WriteLine("[1] Stół bez nakrycia.");
                Console.WriteLine("[2] Stół nakryty.");


                bool x = true;

                while (x)
                {
                    try
                    {
                        _nakrycie = int.Parse(Console.ReadLine());
                        if (_nakrycie == 1)
                        {
                            x = false;
                        }
                        else if (_nakrycie == 2)
                        {
                            x = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Nie ma takiej opcji w menu. Sprobuj ponownie.");
                        Console.WriteLine("Niepoprawny znak! Spróbuj ponownie. (naciśnij dowolny klawisz)");
                        Console.ReadKey();
                    }
                }

                if (_nakrycie == 1)
                {
                    Console.WriteLine("Wybrano status: stół bez nakrycia.");
                }
                else if (_nakrycie == 2)
                {
                    Console.WriteLine("Wybrano status: stół z nakryciem.");
                }
                Console.ReadLine();
            }
 //#############################################
            public void PrintStatusTable()
            {
                Console.ReadLine();
                if (_nakrycie == 1)
                {
                    Console.Write("Obecny status stołu: bez nakrycia");

                }
                else if (_nakrycie == 2)
                {
                    Console.Write("Obecny status stołu: nakryty");
                }
            }
 //#############################################
            public void PrintTable()
            {
                if (_nakrycie == 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(3, 11);
                    for (int i = 0; i < _widthTable; i++) Console.Write(_symbol);//rysownaie blatu

                    int lenght1 = 12;
                    for (int i = 0; i < _heightTable - 1; i++)//rysowanie pierwszej nogi
                    {
                        Console.SetCursorPosition(2 + _widthTable - (_widthTable - 3), lenght1);
                        Console.Write(_symbol);
                        lenght1++;
                    }

                    int lenght2 = 12;
                    for (int i = 0; i < _heightTable - 1; i++)//rysowanie drugiej nogi
                    {
                        Console.SetCursorPosition(_widthTable, lenght2);  //rysowanie nóg stołu
                        Console.Write(_symbol);
                        lenght2++;
                    }
                    Console.SetCursorPosition(0, 12 + _heightTable);

                    Console.Write("(wciśnij dowolny klawisz)");
                }
                else
                {

                    Console.ReadLine();
                    Console.WriteLine("Stół posiada status - nakryty. Jeśli chcesz wyświetlić stół bez nakrycia - zmien status. (wciśnij dowolny klawisz)");

                }
                Console.ResetColor();
            }
//#############################################
            public void SetTable()//nakryty stół
            {
                Console.Clear();
                if (_nakrycie == 2)
                {

                    Console.SetCursorPosition(2, 10);
                    for (int i = 0; i < _widthTable + 2; i++) Console.Write("_");//rysownaie obrusa

                    Console.SetCursorPosition(2, 11);
                    Console.Write("|");

                    //Console.SetCursorPosition(3, 18);
                    for (int i = 0; i < _widthTable; i++) Console.Write(_symbol);//rysownaie blatu

                    Console.SetCursorPosition(_widthTable + 3, 11);
                    Console.Write("|");

                    int lenght1 = 12;
                    for (int i = 0; i < _heightTable - 1; i++)//rysowanie pierwszej nogi
                    {
                        Console.SetCursorPosition(2 + _widthTable - (_widthTable - 3), lenght1);
                        Console.Write(_symbol);
                        lenght1++;
                    }

                    int lenght2 = 12;
                    for (int i = 0; i < _heightTable - 1; i++)//rysowanie drugiej nogi
                    {
                        Console.SetCursorPosition(_widthTable, lenght2);  //rysowanie nóg stołu
                        Console.Write(_symbol);
                        lenght2++;
                    }
                    Console.SetCursorPosition(0, 12 + _heightTable);

                    Console.Write("(wciśnij dowolny klawisz)");
                }
                else
                {
                    Console.ReadLine();
                    Console.WriteLine("Stół posiada status - bez nakrycia. Jeśli chcesz wyświetlić stół z nakryciem - zmien status. (wciśnij dowolny klawisz)");
                }
                Console.ResetColor();
            }
//#############################################
        public void SupriseTable()
        {
                Console.Clear();
                if (_nakrycie == 2)
                {

                    Console.SetCursorPosition(2, 10);
                    for (int i = 0; i < _widthTable + 2; i++) Console.Write("_");//rysownaie obrusa

                    Console.SetCursorPosition(2, 11);
                    Console.Write("|");

                    //Console.SetCursorPosition(3, 18);
                    for (int i = 0; i < _widthTable; i++) Console.Write(_symbol);//rysownaie blatu

                    Console.SetCursorPosition(_widthTable + 3, 11);
                    Console.Write("|");

                    int lenght1 = 12;
                    for (int i = 0; i < _heightTable; i++)//rysowanie pierwszej nogi
                    {
                        Console.SetCursorPosition(2 + _widthTable - (_widthTable - 3), lenght1);
                        Console.Write(_symbol);
                        lenght1++;
                    }

                    int lenght2 = 12;
                    for (int i = 0; i < _heightTable; i++)//rysowanie drugiej nogi
                    {
                        Console.SetCursorPosition(_widthTable, lenght2);  //rysowanie nóg stołu
                        Console.Write(_symbol);
                        lenght2++;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(_widthTable / 2 - 1, 7);
                        Console.Write("{0} |  | /", (char)92);
                        Console.SetCursorPosition(_widthTable / 2 - 1, 8);
                        Console.Write("- $  $ -");
                        Console.ResetColor();
                        Console.SetCursorPosition(_widthTable / 2, 9);
                        Console.Write("_|__|_");
                        Console.SetCursorPosition(_widthTable / 2, 10);
                        Console.Write("|____|");
                        Thread.Sleep(150);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(_widthTable / 2 - 1, 7);
                        Console.Write("         ", (char)92);
                        Console.SetCursorPosition(_widthTable / 2 - 1, 8);
                        Console.Write("  $  $  ");
                        Console.ResetColor();
                        Console.SetCursorPosition(_widthTable / 2, 9);
                        Console.Write("_|__|_");
                        Console.SetCursorPosition(_widthTable / 2, 10);
                        Console.Write("|____|");
                        Thread.Sleep(150);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(_widthTable / 2 - 1, 7);
                        Console.Write("{0} |  | /", (char)92);
                        Console.SetCursorPosition(_widthTable / 2 - 1, 8);
                        Console.Write("- $  $ -");
                        Console.ResetColor();
                        Console.SetCursorPosition(_widthTable / 2, 9);
                        Console.Write("_|__|_");
                        Console.SetCursorPosition(_widthTable / 2, 10);
                        Console.Write("|____|");
                        Thread.Sleep(150);
                    }
                }
                else
                {
                    Console.ReadLine();
                    Console.WriteLine("Stół posiada status - bez nakrycia. Jeśli chcesz wyświetlić niespodziankę - zmien status. (wciśnij dowolny klawisz)");

                }
                Console.ResetColor();
        }
    }
        //----------------------------------------------------------------------------------------------------Koniec klasy TABLE-------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------Początek klasy CHAIR-----------------------------------------------------------------------------------------------------------
        class CHAIR
        {
            private int _heightChair;                //wysokość krzesła
            private int _heightOfBackers;            //wysokośc oparcia
            private int _widthChairHabitat = 8;      //zmienna m jest potrzebna by przypisać później _heightChair
            private char _symbol;                    //symbol wypełnienia
            private int _rotation;                    //ilość obrotów krzesła
            private int _crack;                    


            public void DataChair()
            {
                Console.WriteLine("Podaj wysokość krzesła od podłogi do wierzchu siedliska (zalecana wartość większa niż 2), po czym nacisnij Enter: ");

                bool r = true;
                while (r)
                {
                    try
                    {
                        _heightChair = int.Parse(Console.ReadLine());
                        if (_heightChair <= 2)
                        {
                            Console.WriteLine("Poproszę liczbę większa od 2. Spróbuj ponownie (wcisnij dowolny klawisz)");
                            Console.ReadKey();
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine("                                                                         ");
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine("                                                                         ");
                            Console.SetCursorPosition(0, 1);
                        }
                        else
                        {
                            r = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Podany znak nie jest liczbą! Spróbuj ponownie (wcisnij dowolny klawisz)");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("                                                                         ");
                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine("                                                                         ");
                        Console.SetCursorPosition(0, 1);
                    }
                }
                bool t = true;
                Console.WriteLine("Podaj wysokośc oparcia (zalecana wartość większa niz 2), po czym nacisnij Enter: ");
                do
                {
                    try
                    {
                        _heightOfBackers = int.Parse(Console.ReadLine());
                        if (_heightOfBackers <= 2)
                        {
                            Console.WriteLine("Poproszę liczbę większa od 2. Spróbuj ponownie(wcisnij dowolny klawisz");
                            Console.ReadKey();
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("                                ");
                            Console.SetCursorPosition(0, 5);
                            Console.Write("                                                    ");
                            Console.SetCursorPosition(0, 3);
                            t = true;

                        }
                        if (_heightOfBackers > 2)
                        {
                            t = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Podany znak nie jest liczbą! Spróbuj ponownie (wcisnij dowolny klawisz)");
                        Console.ReadKey();
                        Console.SetCursorPosition(0, 4);
                        Console.WriteLine("                                                                         ");
                        Console.SetCursorPosition(0, 5);
                        Console.Write("                                                                             ");
                        Console.SetCursorPosition(0, 3);
                        t = true;
                    }
                }
                while (t);

                    Console.WriteLine("Podaj symbol do rysowania krzesła - dowolny znaczek z klawiatury i naciśnij Enter");    _symbol = (char)Console.Read();
               
                    // _color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine(), true); //zmienia zczytanego stringa na typ consolecolor//nie dziala
                
                Console.ReadLine();
            }
 //###############################################
            public void StatusChair()
            {
                Console.ReadLine();

                Console.WriteLine("Wybierz status krzesła: ");
                Console.WriteLine("[1] Krzesło zepsute.");
                Console.WriteLine("[2] Krzesło sprawne.");


                bool x = true;

                while (x)
                {
                    try
                    {
                        _crack = int.Parse(Console.ReadLine());
                        if (_crack == 1)
                        {
                            x = false;
                        }
                        else if (_crack == 2)
                        {
                            x = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Nie ma takiej opcji w menu. Sprobuj ponownie.");
                        Console.WriteLine("Niepoprawny znak! Spróbuj ponownie. (naciśnij dowolny klawisz)");
                        Console.ReadKey();
                    }
                }

                if (_crack == 1)
                {
                    Console.WriteLine("Wybrano status: krzesło zepsute.");
                }
                else if (_crack == 2)
                {
                    Console.WriteLine("Wybrano status: krzesło sprawne.");
                }

                Console.ReadLine();
            }
//###############################################
            public void PrintStatusChair()
            {
                Console.ReadLine();
                if (_crack == 1)
                {
                    Console.Write("Obecny status krzesła: zepsute");

                }
                else if (_crack == 2)
                {
                    Console.Write("Obecny status: sprawne");
                }
            }
//##############################################
            public void PrintChair()
            {
                Console.Clear();
                if (_crack == 2)
                {
                    int k = 8;
                    for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                    {
                        Console.SetCursorPosition(3, k);
                        Console.WriteLine(_symbol);
                        k++;
                    }
                    Console.SetCursorPosition(3, _heightOfBackers + 8);

                    for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                    int m = 9;
                    for (int i = 0; i < _heightChair - 1; i++)
                    {
                        Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                        Console.Write(_symbol);
                        m++;
                    }

                    Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                    for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła
                }
                else
                {
                    Console.WriteLine("Krzesło ma status - zepsute. Jeśli chcesz je wyswietlić, zmień status. (wciśnij dowolny klawisz);");

                }
                Console.ResetColor();
            }
//###############################################
            public void RotationChair()
            {
                Console.Clear();
                if (_crack == 2)
                {
                    Console.CursorVisible = false;
                    Console.Clear();
                    int[] Tab = { 3, 4, 5, 6, 7, 8, 9 };
                    bool c = true;
                    while (c)
                    {
                        Console.WriteLine("Podaj ilość obrotów jakie ma wykonać krzesło, po czym nacisnij Enter");
                        try
                        {
                            _rotation = int.Parse(Console.ReadLine());
                            c = false;
                        }
                        catch
                        {
                            Console.WriteLine("Podany znak nie jest liczbą!");
                            Console.WriteLine("Spróbuj ponownie (wcisnij dowolny klawisz)");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    for (int j = 0; j < _rotation; j++)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            int r = 8;
                            for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                            {
                                Console.SetCursorPosition(Tab[k], r);
                                Console.WriteLine(_symbol);
                                r++;
                            }

                            Console.SetCursorPosition(3, _heightOfBackers + 8);

                            for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                            int m = 9;
                            for (int i = 0; i < _heightChair - 1; i++)
                            {
                                Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                                Console.Write(_symbol);
                                m++;
                            }

                            Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                            for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła
                            Thread.Sleep(50);
                            //Console.Clear();
                        }
                        for (int k = 0; k < 7; k++)
                        {
                            int r = 8;
                            for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                            {
                                Console.SetCursorPosition(Tab[k], r);
                                Console.WriteLine(" ");
                                r++;
                            }

                            Console.SetCursorPosition(3, _heightOfBackers + 8);

                            for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                            int m = 9;
                            for (int i = 0; i < _heightChair - 1; i++)
                            {
                                Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                                Console.Write(_symbol);
                                m++;
                            }

                            Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                            for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła
                            Thread.Sleep(50);
                            //Console.Clear();
                        }
                        for (int k = 6; k >= 0; k--)
                        {
                            int r = 8;
                            for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                            {
                                Console.SetCursorPosition(Tab[k], r);
                                Console.WriteLine(_symbol);
                                r++;
                            }

                            Console.SetCursorPosition(3, _heightOfBackers + 8);

                            for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                            int m = 9;
                            for (int i = 0; i < _heightChair - 1; i++)
                            {
                                Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                                Console.Write(_symbol);
                                m++;
                            }

                            Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                            for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła
                            Thread.Sleep(50);
                            //Console.Clear();
                        }
                        for (int k = 6; k >= 0; k--)
                        {
                            int r = 8;
                            for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                            {
                                Console.SetCursorPosition(Tab[k], r);
                                Console.WriteLine(" ");
                                r++;
                            }

                            Console.SetCursorPosition(3, _heightOfBackers + 8);

                            for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                            int m = 9;
                            for (int i = 0; i < _heightChair - 1; i++)
                            {
                                Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                                Console.Write(_symbol);
                                m++;
                            }

                            Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                            for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła
                            Thread.Sleep(50);
                            //Console.Clear();
                        }
                    }

                    int y = 8;
                    for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                    {
                        Console.SetCursorPosition(3, y);
                        Console.WriteLine(_symbol);
                        y++;
                    }
                    Console.SetCursorPosition(3, _heightOfBackers + 8);

                    for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                    int l = 9;
                    for (int i = 0; i < _heightChair - 1; i++)
                    {
                        Console.SetCursorPosition(2 + _widthChairHabitat / 2, l + _heightOfBackers);//rysowanie nogi krzesła
                        Console.Write(_symbol);
                        l++;
                    }

                    Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                    for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła

                }
                else
                {
                    Console.WriteLine("Krzesło ma status - zepsute. Jeśli chcesz je wyswietlić, zmień status. (wciśnij dowolny klawisz);");
                }
                Console.ResetColor();
                Console.ReadKey();

            }
//###############################################
            public void SupriseChair()
            {
                Console.Clear();
                if (_crack == 2)
                {
                    Console.CursorVisible = false;
                    Console.Clear();
                    int k = 8;
                    for (int i = 0; i < _heightOfBackers; i++)//rysowanie oparcia
                    {
                        Console.SetCursorPosition(3, k);
                        Console.WriteLine(_symbol);
                        k++;
                    }
                    Console.SetCursorPosition(3, _heightOfBackers + 8);

                    for (int i = 0; i < 7; i++) Console.Write(_symbol);//rysowanie siedliska

                    int m = 9;
                    for (int i = 0; i < _heightChair - 1; i++)
                    {
                        Console.SetCursorPosition(2 + _widthChairHabitat / 2, m + _heightOfBackers);//rysowanie nogi krzesła
                        Console.Write(_symbol);
                        m++;
                    }

                    Console.SetCursorPosition(4, 7 + _heightOfBackers + _heightChair);
                    for (int i = 0; i < 5; i++) Console.Write(_symbol);//rysowanie podstawki krzesła

                    int l = 8;
                    for (int i = 0; i < _heightOfBackers - 1; i++)//rysowanie tułowia
                    {
                        Console.SetCursorPosition(5, l);
                        Console.WriteLine("|");
                        l++;
                    }
                    Console.SetCursorPosition(3, _heightOfBackers * 2 / 3 + 1);
                    Console.WriteLine("*(oo)*");
                    Console.SetCursorPosition(5, _heightOfBackers * 2 / 3 + 2);
                    Console.WriteLine("O");
                    Console.SetCursorPosition(5, _heightOfBackers * 2 / 3 + 3);
                    Console.WriteLine("|");                                                                                 //twarz, szyja i ramię ludzika
                    Console.SetCursorPosition(6, _heightOfBackers * 2 / 3 + 4);
                    Console.WriteLine("____");
                    Console.SetCursorPosition(10, _heightOfBackers * 2 / 3 + 4);
                    Console.WriteLine("/");
                    Console.SetCursorPosition(11, _heightOfBackers * 2 / 3 + 3);
                    Console.WriteLine("/");
                    Console.SetCursorPosition(5, _heightOfBackers + 7);

                    for (int i = 0; i < 8; i++) Console.Write("-");//rysowanie ud ludzika

                    int z = 9;
                    for (int i = 0; i < _heightChair; i++)
                    {
                        Console.SetCursorPosition(4 + _widthChairHabitat, z + _heightOfBackers - 1);//rysowanie nóg przed kolanem ludzika
                        Console.Write("|");
                        z++;
                    }
                    Console.SetCursorPosition(13, 7 + _heightOfBackers + _heightChair);//stopy ludzika
                    Console.Write("__");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.SetCursorPosition(11, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine("|");
                        Thread.Sleep(300);
                        Console.SetCursorPosition(11, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(10, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine((char)92);
                        Thread.Sleep(300);
                        Console.SetCursorPosition(10, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine(" ");                                                                     //machanie ręką ludzika
                        Console.SetCursorPosition(11, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine("|");
                        Thread.Sleep(300);
                        Console.SetCursorPosition(11, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(12, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine("/");
                        Thread.Sleep(300);
                        Console.SetCursorPosition(12, _heightOfBackers * 2 / 3 + 2);
                        Console.WriteLine(" ");
                    }
                    Console.SetCursorPosition(12, _heightOfBackers * 2 / 3 + 2);
                    Console.WriteLine("/");
                }
                else
                {
                    Console.WriteLine("Krzesło ma status - zepsute. Jeśli chcesz je wyswietlić, zmień status. (wciśnij dowolny klawisz);");
                }
                Console.ResetColor();
            }
            /*
            static public void PrintColor()
            {
                string _color;
                Console.WriteLine("Podaj jakiego koloru chcesz mieć stół? (do wybory: White, Blue, Red, Green)");
                bool a = true;
                while (a)
                {
                    try
                    {
                        _color = Console.ReadLine();

                        if (_color == "White")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            a = false;
                        }
                        if (_color == "Blue")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            a = false;
                        }
                        if (_color == "Red")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            a = false;
                        }
                        if (_color == "Green")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Proszę poprawnie wpisać kolor (tak jak w opisie powyżej). Spróbuj ponownie (nacisnij dowolny klawisz)");
                    }
                }
            }
            */
        }
        //----------------------------------------------------------------------------------------------------Koniec klasy CHAIR-------------------------------------------------------------------------------------------------------------
        class Program
        {
            static void Main(string[] args)
            {
                Wardrobe myWardrobe = new Wardrobe();
                Table myTable = new Table();
                CHAIR myChair = new CHAIR();

                Console.Title = "RYSOWANIE MEBLI";

                bool q = true;//zmienna potrzebna do pętli while z głównego MENU

                while (q)
                {
                    bool f = true;
                    bool g = true;          //zmienne potrzebne do pętli while w poszczególnych podMENU
                    bool h = true;

                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("\tWitaj z programie rysującym meble!");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Do wyboru masz: ");
                    Console.WriteLine("[1] Szafa dwudrzwiowa.");
                    Console.WriteLine("[2] Stół.");
                    Console.WriteLine("[3] Krzesło.");
                    Console.WriteLine("[0] Exit.");
                    Console.WriteLine("--------------------------------------------------");

                    ConsoleKeyInfo _key = Console.ReadKey();


                    switch (_key.Key)
                    {

                        case ConsoleKey.D1 :
                            
                            Console.Clear();
                            myWardrobe.DataWardrobe();
                            myWardrobe.StatusWardrobe();

                            while (g)
                                {

                                Console.Clear();
                                    Console.WriteLine("- Podaj jeszcze proszę jaką szafę chcesz wyświetlić:");
                                    Console.WriteLine("Do wyboru masz: ");
                                    Console.WriteLine("[1] Szafa zamknięta.");
                                    Console.WriteLine("[2] Szafa otwarta.");
                                    Console.WriteLine("[3] Szafa otwarta z niespodzianką ;).");
                                    Console.WriteLine("[4] Zmiana statusu.");
                                Console.WriteLine("[5] Pokaż obecny status.");

                                Console.WriteLine("[0] Exit.");

                                    ConsoleKeyInfo _key1 = Console.ReadKey();

                                    switch (_key1.Key)
                                    {
                                        case ConsoleKey.D1:
                                            myWardrobe.PrintWardrobe();
                                            Console.ReadKey();
                                            break;
                                        case ConsoleKey.D2:
                                            myWardrobe._openWardroble();
                                            Console.ReadKey();
                                            break;
                                        case ConsoleKey.D3:
                                            myWardrobe.SupriseWardroble();
                                        Console.ReadLine();
                                            break;
                                    case ConsoleKey.D4:
                                        myWardrobe.StatusWardrobe();

                                        break;
                                    case ConsoleKey.D5:
                                        myWardrobe.PrintStatusWardrobe();
                                        Console.ReadKey();
                                        Console.ReadLine();

                                        break;

                                    case ConsoleKey.D0:
                                            g = false;
                                            break;
                                    }
                                }
                            break;

                        case ConsoleKey.D2:
                            Console.Clear();
                            myTable.DataTable();
                            myTable.StatusTable();


                            while (f)
                            {
                                Console.Clear();
                                Console.WriteLine("- Podaj jeszcze proszę status stołu:");
                                Console.WriteLine("Do wyboru masz: ");
                                Console.WriteLine("[1] Stół bez obrusu.");
                                Console.WriteLine("[2] Stół z obrusem.");
                                Console.WriteLine("[3] Stół z obrusem + niespodzianka ;).");
                                Console.WriteLine("[4] Zmiana statusu.");
                                Console.WriteLine("[5] Pokaż obecny status.");
                                Console.WriteLine("[0] Exit.");

                                ConsoleKeyInfo _key1 = Console.ReadKey();

                                switch (_key1.Key)
                                {
                                    case ConsoleKey.D1:
                                        myTable.PrintTable();
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D2:
                                        myTable.SetTable();
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D3:
                                        myTable.SupriseTable();
                                        Console.ReadKey();
                                        Console.ReadLine();
                                        break;
                                    case ConsoleKey.D4:
                                        myTable.StatusTable();
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D5:
                                        myTable.PrintStatusTable();
                                        Console.ReadKey();
                                        break;

                                    case ConsoleKey.D0:
                                         f =false;
                                        break;
                                }
                            }  
                            break;

                        case ConsoleKey.D3:
                            Console.Clear();
                            myChair.DataChair();
                            myChair.StatusChair();

                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("- Podaj jeszcze proszę status krzesła:");
                                Console.WriteLine("Do wyboru masz: ");
                                Console.WriteLine("[1] Stojące krzesło .");
                                Console.WriteLine("[2] Obracajace się krzesło.");
                                Console.WriteLine("[3] Krzesło + niespodzianka ;).");
                                Console.WriteLine("[4] Zmiana statusu.");
                                Console.WriteLine("[5] Pokaż obecny status.");
                                Console.WriteLine("[0] Exit.");

                                ConsoleKeyInfo _key1 = Console.ReadKey();

                                switch (_key1.Key)
                                {
                                    case ConsoleKey.D1:
                                        myChair.PrintChair();
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D2:
                                        myChair.RotationChair();
                                        Console.ReadKey();
                                        break;
                                    case ConsoleKey.D3:
                                        myChair.SupriseChair();
                                        Console.ReadKey();
                                        Console.ReadLine();
                                        break;
                                    case ConsoleKey.D4:
                                        myChair.StatusChair();
                                        Console.ReadKey();
                                        Console.ReadLine();
                                        break;
                                    case ConsoleKey.D5:
                                        myChair.PrintStatusChair();
                                        Console.ReadKey();
                                        Console.ReadLine();

                                        break;
                                    case ConsoleKey.D0:
                                        h = false;
                                        break;
                                }
                            }
                            break;
                        case ConsoleKey.D0:
                            q = false;
                            Environment.Exit(0);
                            break;
                        default: break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}


    

