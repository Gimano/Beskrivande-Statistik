using Beskrivande_Statistik;

while (true)
{
    
    int menuChoice;
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
            Presentation_av_data.presentation_av_data();              //Presentera data
            break;
        case 2:
            ReadCustomJson.Open();    //Välj json fil och presentera data
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
