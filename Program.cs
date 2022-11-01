using Beskrivande_Statistik;
// Martin
while (true)
{
        Console.Clear();
    ColorConsole.WriteWrappedHeader("Välkommen!");
    ColorConsole.AlternateColor("Välj ett alternativ:");
    ColorConsole.AlternateColor("1. Presentera uträkning av data.json.");
    ColorConsole.AlternateColor("2. Välj en annan json fil att räkna ut ifrån.");
    ColorConsole.AlternateColor("3. Generera en json fil med nummer.");
    ColorConsole.AlternateColor("4. Ta bort en json fil.");
    ColorConsole.AlternateColor("5. Avsluta.");

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
            //Ta bort en json fil
            DeleteJson.Delete();
            break;
        case 5:
            //Avsluta Programmet
            Environment.Exit(0);
            break;
        default:
            break;
    }
}