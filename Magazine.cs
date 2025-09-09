public class Magazine : LibraryItem
{
    public int IssueNumber { get; }

    public Magazine(int id, string title, int issueNumber) 
        : base(id, title, ItemType.Magazine)
    {
        IssueNumber = issueNumber;
    }

    public override string GetDetails()
    {
        return $"Magazine: {Title} (Issue #{IssueNumber})";
    }
}