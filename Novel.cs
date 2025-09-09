public class Novel : LibraryItem
{
    public string Author { get; }

    public Novel(int id, string title, string author) 
        : base(id, title, ItemType.Novels)
    {
        Author = author;
    }

    public override string GetDetails()
    {
        return $"Novel: {Title} by {Author}";
    }
}