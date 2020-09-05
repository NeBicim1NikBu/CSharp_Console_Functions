using System;

namespace CSharpConsoleFunctions
{
    class Program
    {
       public static string WritingChar = "█";
        static void Main(string[] args)
        {
            var exit = true;
            do
            {
                Console.SetCursorPosition(0, 24);
                Console.WriteLine("1) I am Happy");
                Console.WriteLine("2) I am Sad");
                Console.WriteLine("3) I am Suprised");
                Console.WriteLine("4) Exit");
                Console.Write("Please select your mood (1/2/3) or Exit (4) : " );
                var MyMood = Console.ReadLine();
                switch (MyMood)
                {
                   case "1":            
                        DrawSmileyFace();
                        DrawSpeakingBaloon(55, 10);
                        Console.SetCursorPosition(61, 4);
                        Console.WriteLine("I AM HAPPY");
                        break;
                    case "2":
                        DrawSadFace();
                        DrawSpeakingBaloon(55, 10);
                        Console.SetCursorPosition(61, 4);
                        Console.WriteLine("I AM SAD");
                        break;
                    case "3":
                        DrawSuprisedFace();
                        DrawSpeakingBaloon(55, 10);
                        Console.SetCursorPosition(61, 4);
                        Console.WriteLine("I AM SUPRISED");
                        break;
                    case "4":
                        DrawSmileyFace();
                        DrawSpeakingBaloon(55, 10);
                        Console.SetCursorPosition(61, 4);
                        Console.WriteLine("BYE BYE");
                        exit = false;
                        break;
                    default:
                        break;
            }
                Console.SetCursorPosition(0, 29);
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            } while (exit);
        }

        private static void DrawSmileyFace()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DrawRectangle(5, 3, 30, 5);
            DrawRectangle(5, 3, 41, 5);
            GoStepDown(3, 38, 9);
            GoStepRight(2, 32, 13);
            GoStepRight(7, 34, 14);
            GoStepRight(2, 41, 13);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void DrawSadFace()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            DrawRectangle(5, 3, 30, 5);
            DrawRectangle(5, 3, 41, 5);
            GoStepDown(3, 38, 9);
            GoStepRight(2, 32, 15);
            GoStepRight(7, 34, 14);
            GoStepRight(2, 41, 15);
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void DrawSuprisedFace()
        {
           Console.ForegroundColor= ConsoleColor.Green;
            DrawRectangle(5, 3, 30, 5);
            DrawRectangle(5, 3, 41, 5);
            GoStepDown(3, 38, 9);
            GoStepRight(2, 32, 15);
            GoStepRight(7, 34, 14);
            GoStepRight(2, 41, 15);
            GoStepRight(7, 34, 16);
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void DrawSpeakingBaloon(int CursorLeft,int CursorTop)
        {
            Console.SetCursorPosition(CursorLeft, CursorTop);
            GoStepRight(1, CursorLeft, CursorTop);
            GoStepRight(1, CursorLeft+1, CursorTop-1);
            GoStepRight(1, CursorLeft +2, CursorTop - 2);
            GoStepRight(1, CursorLeft + 3, CursorTop - 3);
            DrawRectangle(16, 4, CursorLeft + 5, CursorTop - 8);
        }
        private static void DrawRectangle(int X,int Y,int CursorLeft,int CursorTop)
        {
            Console.SetCursorPosition(CursorLeft, CursorTop);
            GoStepRight(X, Console.CursorLeft, Console.CursorTop);
            GoStepDown(Y, Console.CursorLeft, Console.CursorTop);
            GoStepLeft(X, Console.CursorLeft, Console.CursorTop);
            GoStepUp(Y, Console.CursorLeft, Console.CursorTop);
        }

        private static void GoStepRight(int StepCount,int CursorLeft,int CursorTop)
        {
            for (int i = 0; i < StepCount; i++)
            {
                Console.SetCursorPosition(CursorLeft, CursorTop);
                Console.Write(WritingChar);
                CursorLeft++;
            }
        }
        private static void GoStepDown(int StepCount,int CursorLeft,int CursorTop)
        {
            for (int i = 0; i < StepCount; i++)
            {
                CursorTop++;
                Console.SetCursorPosition(CursorLeft-1, CursorTop);
                Console.Write(WritingChar);
            }
        }
        private static void GoStepLeft(int StepCount, int CursorLeft, int CursorTop)
        {
            for (int i = 0; i < StepCount; i++)
            {
                CursorLeft--;
                Console.SetCursorPosition(CursorLeft - 1, CursorTop);
                Console.Write(WritingChar);
            }
        }
        private static void GoStepUp(int StepCount, int CursorLeft, int CursorTop)
        {
            for (int i = 0; i < StepCount; i++)
            {
                CursorTop--;
                Console.SetCursorPosition(CursorLeft - 1, CursorTop);
                Console.Write(WritingChar);
            }
        }
    }
}
