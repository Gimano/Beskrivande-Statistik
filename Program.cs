using Beskrivande_Statistik;

public class Program
{
    static void Main(string[] args)
    {
        int[] temp = DeserializeJson.Deserialize();
        DisplayMinimum(temp);
        DisplayMaximum(temp);
        DisplayMean(temp);
        DisplayRange(temp);
    }
    static void DisplayMean(int[] temp)
    {
        Console.WriteLine("Medelvärde: " + Statistics.Mean(temp));
    }
    static void DisplayMinimum(int[] temp)
    {
        Console.WriteLine("Minsta värde: " + Statistics.Minimum(temp));
    }
    static void DisplayMaximum(int[] temp)
    {
        Console.WriteLine("Högsta värde: " + Statistics.Maximum(temp));
    }
    static void DisplayRange(int[] temp)
    {
        Console.WriteLine("Variationsbredd: " + Statistics.Range(temp));
    }
}