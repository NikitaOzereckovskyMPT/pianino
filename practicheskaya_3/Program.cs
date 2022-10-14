namespace practicheskaya_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int com = 0;
            while (com != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.F1)
                {
                    Console.WriteLine(" -> переход к 1 октаве");
                    Fod();
                }
                if (a.Key == ConsoleKey.F2)
                {
                    Console.WriteLine(" -> переход к 2 октаве");
                    Fdva();
                }
                if (a.Key == ConsoleKey.F3)
                {
                    Console.WriteLine(" -> переход к 3 октаве");
                    Ftre();
                }
                if (a.Key == ConsoleKey.F4)
                {
                    Console.WriteLine(" -> переход к 4 октаве");
                    Fche();
                }
                if (a.Key == ConsoleKey.F5)
                {
                    Console.WriteLine(" -> переход к 5 октаве");
                    Fpyt();
                }
                if (a.Key == ConsoleKey.F6)
                {
                    Console.WriteLine(" -> переход к 6 октаве");
                    Fshe();
                }
                if (a.Key == ConsoleKey.F7)
                {
                    Console.WriteLine(" -> переход к 7  октаве");
                    Fsem();
                }
                if (a.Key == ConsoleKey.X)
                {
                    Console.WriteLine(" Выход из программы Пианино");
                    com = 1;
                }
            }
        }
        static void Fod()
        {
            int[] Fod = new int[] { 37, 37, 37, 37, 37, 37, 38, 41, 46, 43, 51, 49 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fod[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fod[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fod[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fod[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fod[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fod[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fod[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fod[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fod[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fod[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fod[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fod[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fdva()
        {
            int[] Fdva = new int[] { 55, 58, 61, 69, 65, 73, 77, 82, 92, 87, 103, 98 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fdva[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fdva[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fdva[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fdva[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fdva[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fdva[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fdva[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fdva[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fdva[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fdva[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fdva[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fdva[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Ftre()
        {
            int[] Ftre = new int[] { 110, 116, 123, 138, 130, 146, 155, 164, 185, 174, 207, 196 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Ftre[0], 750);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Ftre[1], 750);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Ftre[2], 750);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Ftre[3], 750);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Ftre[4], 750);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Ftre[5], 750);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Ftre[6], 750);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Ftre[7], 750);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Ftre[8], 750);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Ftre[9], 750);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Ftre[10], 750);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Ftre[11], 750);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fche()
        {
            int[] Fche = new int[] { 220, 233, 246, 277, 261, 293, 311, 329, 370, 349, 415, 392 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fche[0], 750);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fche[1], 750);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fche[2], 750);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fche[3], 750);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fche[4], 750);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fche[5], 750);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fche[6], 750);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fche[7], 750);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fche[8], 750);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fche[9], 750);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fche[10], 750);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fche[11], 750);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fpyt()
        {
            int[] Fpyt = new int[] { 440, 466, 493, 554, 523, 587, 622, 659, 740, 698, 830, 784 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fpyt[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fpyt[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fpyt[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fpyt[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fpyt[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fpyt[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fpyt[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fpyt[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fpyt[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fpyt[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fpyt[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fpyt[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fshe()
        {
            int[] Fshe = new int[] { 880, 932, 987, 1109, 1047, 1175, 1245, 1319, 1480, 1397, 1661, 1568 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fshe[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fshe[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fshe[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fshe[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fshe[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fshe[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fshe[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fshe[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fshe[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fshe[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fshe[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fshe[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fsem()
        {
            int[] Fsem = new int[] { 1760, 1865, 1976, 2217, 2093, 2349, 2489, 2637, 2960, 2794, 3322, 3136 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fsem[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fsem[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fsem[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fsem[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fsem[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fsem[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fsem[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fsem[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fsem[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fsem[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fsem[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fsem[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
        static void Fvosem()
        {
            int[] Fvos = new int[] { 3520, 3729, 3951, 4435, 4186, 4699, 4978, 5274, 5920, 5588, 6645, 6272 };
            int command = 0;
            while (command != 1)
            {
                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.A)
                {
                    Console.Beep(Fvos[0], 500);
                }
                if (a.Key == ConsoleKey.W)
                {
                    Console.Beep(Fvos[1], 500);
                }
                if (a.Key == ConsoleKey.S)
                {
                    Console.Beep(Fvos[2], 500);
                }
                if (a.Key == ConsoleKey.E)
                {
                    Console.Beep(Fvos[3], 500);
                }
                if (a.Key == ConsoleKey.D)
                {
                    Console.Beep(Fvos[4], 500);
                }
                if (a.Key == ConsoleKey.F)
                {
                    Console.Beep(Fvos[5], 500);
                }
                if (a.Key == ConsoleKey.T)
                {
                    Console.Beep(Fvos[6], 500);
                }
                if (a.Key == ConsoleKey.G)
                {
                    Console.Beep(Fvos[7], 500);
                }
                if (a.Key == ConsoleKey.Y)
                {
                    Console.Beep(Fvos[8], 500);
                }
                if (a.Key == ConsoleKey.H)
                {
                    Console.Beep(Fvos[9], 500);
                }
                if (a.Key == ConsoleKey.U)
                {
                    Console.Beep(Fvos[10], 500);
                }
                if (a.Key == ConsoleKey.J)
                {
                    Console.Beep(Fvos[11], 500);
                }
                if (a.Key == ConsoleKey.X || a.Key == ConsoleKey.F1 || a.Key == ConsoleKey.F2 || a.Key == ConsoleKey.F3 || a.Key == ConsoleKey.F4 || a.Key == ConsoleKey.F5 || a.Key == ConsoleKey.F6 || a.Key == ConsoleKey.F7 || a.Key == ConsoleKey.F8)
                {
                    command = 1;
                }
            }
        }
    }
}