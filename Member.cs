using System.Collections.Generic;

public class Member
{
    public string Name { get; }
    private List<LibraryItem> borrowedItems;

    public Member(string name)
    {
        Name = name;
        borrowedItems = new List<LibraryItem>();
    }

    public string BorrowItem(LibraryItem item)
    {
        if (borrowedItems.Count >= 3)
        {
            return "You cannot borrow more than 3 items.";
        }

        borrowedItems.Add(item);
        return $"{item.Title} has been added to {Name}'s borrowed items.";
    }

    public string ReturnItem(LibraryItem item)
    {
        if (borrowedItems.Contains(item))
        {
            borrowedItems.Remove(item);
            return $"{item.Title} has been successfully returned.";
        }
        else
        {
            return "The item was not in the list of borrowed items.";
        }
    }

    public List<LibraryItem> GetBorrowedItems()
    {
        return borrowedItems;
    }
}