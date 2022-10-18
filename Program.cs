using Beskrivande_Statistik;

while (true)
{
    int menuChoice;
    Console.Clear();
    Console.WriteLine("Välkommen!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Välj ett alternativ: ");
    Console.WriteLine("1. Presentera uträkning av data.json.");
    Console.WriteLine("2. Välj en annan json fil att räkna ut ifrån");
    Console.WriteLine("3. Generera en json fil med nummer.");
    Console.WriteLine("4. Avsluta");
    Console.WriteLine("--------------------------------------------");
    while (!int.TryParse(Console.ReadLine(), out menuChoice));
    switch (menuChoice)
    {
        case 1:
            //dynamic o = Statistics.DescriptiveStatistics(DeserializeJson.Deserialize());
            //Console.WriteLine(o["Maximum"]);
            //int[] i = o["Mode"];
            //Console.WriteLine(o["Mode"][0]);
            //Array.ForEach(i, Console.Write);
            ReadJson.Display();
            Console.ReadKey();
            //Presentera data
            break;
        case 2:
            //Välj json fil och presentera data
            break;
        case 3:
            //Skapa en json fil och fyll med data
            break;
        default:
            break;
    }
    if (menuChoice == 4)
        break;
}
