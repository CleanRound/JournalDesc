class Journal
{
    private string journalName;
    private int yearOfFoundation;
    private string journalDescription;
    private string contactPhoneNumber;
    private string email;

    public void InputData()
    {
        Console.Write("Enter the name of the journal: ");
        journalName = Console.ReadLine();

        Console.Write("Enter the year of foundation: ");
        yearOfFoundation = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the description of the journal: ");
        journalDescription = Console.ReadLine();

        Console.Write("Enter the contact phone number: ");
        contactPhoneNumber = Console.ReadLine();

        Console.Write("Enter the email: ");
        email = Console.ReadLine();
    }

    public void OutputData()
    {
        Console.WriteLine($"Journal Name: {journalName}");
        Console.WriteLine($"Year of Foundation: {yearOfFoundation}");
        Console.WriteLine($"Journal Description: {journalDescription}");
        Console.WriteLine($"Contact Phone Number: {contactPhoneNumber}");
        Console.WriteLine($"Email: {email}");
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public int GetYearOfFoundation()
    {
        return yearOfFoundation;
    }

    public void SetYearOfFoundation(int year)
    {
        yearOfFoundation = year;
    }

    public string GetJournalDescription()
    {
        return journalDescription;
    }

    public void SetJournalDescription(string description)
    {
        journalDescription = description;
    }

    public string GetContactPhoneNumber()
    {
        return contactPhoneNumber;
    }

    public void SetContactPhoneNumber(string phoneNumber)
    {
        contactPhoneNumber = phoneNumber;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetEmail(string emailAddress)
    {
        email = emailAddress;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        myJournal.InputData();

        myJournal.OutputData();
    }
}