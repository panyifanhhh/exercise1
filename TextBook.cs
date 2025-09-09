public class TextBook : LibraryItem
{
    public string Publisher { get; }

    public TextBook(int id, string title, string publisher) 
        : base(id, title, ItemType.TextBook)
    {
        Publisher = publisher;
    }

    public override string GetDetails()
    {
        return $"TextBook: {Title} published by {Publisher}";
    }
}