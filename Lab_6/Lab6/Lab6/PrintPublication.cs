namespace Lab6;

public abstract class PrintPublication : Author
{
    public string? NameOfThePrintPublication;
    public int AmountOfPages;
    public int YearOfPublication;
    public double PriceOfThePrintPublication;

    public virtual void Reading()
    {
        Console.WriteLine("Reading some print publication.") ;
    }

    public abstract void TestFunction();
}