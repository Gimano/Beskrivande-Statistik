using Newtonsoft.Json;

namespace Beskrivande_Statistik
{

    // Niklas (Martin har hjälpt till att lösa vissa logiska problem)

    public static class UserCreateJson
    {
        public static List<int> IntList = new List<int>();
        public static void UserJson()
        {
            Console.Clear();
            Console.Write("Vad ska din fil heta: ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".json";
            string jsonChoice = "";
            Console.Clear();

            while (jsonChoice != "0") 
            {
                Console.Write($"[1] Lägg till integers manuellt i {fileName}.\n[2] Fyll {fileName} med random integers.\n[0] Gå tillbaka till menyn\nDitt val: ");
                jsonChoice = Console.ReadLine();
                switch (jsonChoice)
                {

                    #region Case 1 - Lägg till integers manuellt

                    // Låt användaren skapa en json fil fylld med integers som man användaren matar in själv.
                    case "1":
                        // Låt användaren lägga till integers manuellt i IntList
                        // Sen serialiserar vi värdena i listan och skriver ut dom i json filen.
                        while (true)
                        {
                            int input = 0;
                            Console.WriteLine("Skriv in integer värden att lägga till. Avsluta med [0]");
                            Console.Write("Lägg till siffra: ");
                            input = ExceptionHandling();

                            if (input != 0)
                            {
                                IntList.Add(input);
                            }
                            else
                            {
                                // Kallar på metoden för serializering och exception handling (tömmer sedan listan utifallat man vill skapa fler filer sen)
                                SerializeAndIOExceptions(fileName);
                                IntList.Clear();
                                break;
                            }
                        }
                        jsonChoice = "0";
                        break;

                    #endregion

                    #region Case 2 - Fill list with random integers

                    // Låter användaren skapa en json fil fylld med random integers.
                    case "2":
                        int numberOfInts = 0;
                        int lowRnd = 0;
                        int highRnd = 0;
                        string confirmInts = "";

                        Console.Write("Hur många random integers vill du skapa till din json fil: ");
                        numberOfInts = ExceptionHandling();

                        numberOfInts = HowManyRandomInts(numberOfInts);
              
                        Console.Write("Lägsta möjliga nummer att genereras: ");
                        lowRnd = ExceptionHandling();

                        do
                        {
                            Console.Write($"Högsta möjliga nummer att genereras (kan inte vara lägre än {lowRnd}): ");
                            highRnd = ExceptionHandling();
                        } while (lowRnd >= highRnd);

                        // skapar så många värden användaren valt med hjälp av en random
                        for (int i = 0; i < numberOfInts; i++)
                        {
                            Random rnd = new Random();
                            int num = rnd.Next(lowRnd, highRnd);
                            IntList.Add(num);
                        }

                        // Kallar på metoden för serializering och exception handling (tömmer sedan listan utifallat man vill skapa fler filer sen)
                        SerializeAndIOExceptions(fileName);
                        IntList.Clear();

                        jsonChoice = "0";
                        break;

                    #endregion

                    #region Default
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning");
                        break;
                        #endregion

                }
            }
        }

        // En metod för att testa och fånga exceptions som rimligtvis kommer att ske i koden.
        // Detta för att undvika en massa onödig upprepning i resten av koden.
        public static int ExceptionHandling()
        {
            while (true)
            {
                try
                {
                    int temp = int.Parse(Console.ReadLine());
                    return temp;
                }
                catch (FormatException)
                {
                    Console.Write("Ogiltig inmatning. Inmatningen accepterar bara integers.\nVar god försök igen: ");
                }
                catch (OverflowException)
                {
                    Console.Write("Inmatningen är utanför tillåtet intervall\nMata in en giltig integer: ");
                }
            }
        }
       
        // En metod som serializerar värdena vi skapat i intlist och skriver dom till en ny json fil med namnet användaren valt
        // kollar också efter IOException (T.ex ogiltiga karaktärer i filnamnet)
        public static void SerializeAndIOExceptions(string fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                File.WriteAllText(fileName, json);
            }
            catch (IOException)
            {
                Console.Write("Ogiltigt filnamn.\nTryck enter för att gå tillbaka till menyn.");
                Console.ReadLine();
            }
        }
        
        // Metod där användaren får välja hur många random integers som ska skapas i filen
        // Ser även till att användaren inte kan skapa en för stor fil (vi har satt värdet till 1.000.000 för tillfället)
        public static int HowManyRandomInts(int numberOfInts)
        {
            int maxVärde = 1000000;
            while (numberOfInts < 1 || numberOfInts > maxVärde)
            {
                Console.WriteLine("Värden att skapa måste vara mellan 1 - 10000000");
                numberOfInts = ExceptionHandling();
            }
            return numberOfInts;
        }
    }
}
