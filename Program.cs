using Beskrivande_Statistik;

while (true)
{
    Console.Clear();
    Console.WriteLine("Välkommen!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Välj ett alternativ: ");
    Console.WriteLine("1. Presentera uträkning av data.json.");
    Console.WriteLine("2. Välj en annan json fil att räkna ut ifrån");
    Console.WriteLine("3. Generera en json fil med nummer.");
    Console.WriteLine("4. Ta bort en json fil.");
    Console.WriteLine("5. Avsluta");
    Console.WriteLine("--------------------------------------------");

    int menuChoice;
    while (!int.TryParse(Console.ReadLine(), out menuChoice));

    switch (menuChoice)
    {
        case 1: 
            //Presentera data från data.json
            Presentation_av_data.presentation_av_data(Statistics.DescriptiveStatistics(ReadJsonFile.Deserialize("data.json")));              
            break;
        case 2:
            //Välj json fil och presentera data
            ReadCustomJson.Open();
            break;
        case 3:
            //Skapa en json fil och fyll med data
            UserCreateJson.UserJson();
            break;
        case 4:
            DeleteJson.Delete();
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            break;
    }
}