public abstract class LibraryItem
{
    public int Id { get; }
    public string Title { get; }
    public ItemType Type { get; }

    protected LibraryItem(int id, string title, ItemType type)
    {
        Id = id;
        Title = title;
        Type = type;
    }

    public abstract string GetDetails();
}