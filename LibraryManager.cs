using System;
using System.Collections.Generic;

public class LibraryManager
{
    private List<LibraryItem> catalog;
    private List<Member> members;

    public LibraryManager()
    {
        catalog = new List<LibraryItem>();
        members = new List<Member>();
    }

    public void AddItem(LibraryItem item)
    {
        catalog.Add(item);
    }

    public void RegisterMember(Member member)
    {
        members.Add(member);
    }

    public void ShowCatalog()
    {
        Console.WriteLine("Library Catalog:");
        Console.WriteLine("================");
        
        foreach (var item in catalog)
        {
            Console.WriteLine(item.GetDetails());
        }
        Console.WriteLine();
    }

    public LibraryItem? FindItemById(int id)
    {
        return catalog.Find(i => i.Id == id);
    }

    public Member? FindMemberByName(string name)
    {
        return members.Find(m => m.Name == name);
    }
}