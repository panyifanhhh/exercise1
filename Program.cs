using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Library Management System");
        Console.WriteLine("=========================");
        Console.WriteLine();

        // Create LibraryManager object
        LibraryManager library = new LibraryManager();

        // Add items to the catalog
        library.AddItem(new Novel(1, "To Kill a Mockingbird", "Harper Lee"));
        library.AddItem(new Magazine(2, "National Geographic", 256));
        library.AddItem(new TextBook(3, "Introduction to Algorithms", "MIT Press"));
        library.AddItem(new Novel(4, "1984", "George Orwell"));

        // Create member objects
        Member alice = new Member("Alice");
        Member bob = new Member("Bob");

        // Register members
        library.RegisterMember(alice);
        library.RegisterMember(bob);

        // Show catalog
        library.ShowCatalog();

        // Alice borrows items
        Console.WriteLine("Alice borrowing items:");
        Console.WriteLine("----------------------");
        
        var item1 = library.FindItemById(1);
        if (item1 != null)
            Console.WriteLine(alice.BorrowItem(item1));

        var item2 = library.FindItemById(2);
        if (item2 != null)
            Console.WriteLine(alice.BorrowItem(item2));

        var item3 = library.FindItemById(3);
        if (item3 != null)
            Console.WriteLine(alice.BorrowItem(item3));

        // Try to borrow fourth item (should fail)
        Console.WriteLine("\nTrying to borrow fourth item:");
        Console.WriteLine("-----------------------------");
        var item4 = library.FindItemById(4);
        if (item4 != null)
            Console.WriteLine(alice.BorrowItem(item4));

        Console.WriteLine();

        // Show borrowed items for Alice
        Console.WriteLine($"Items borrowed by Alice:");
        Console.WriteLine("-----------------------");
        foreach (var item in alice.GetBorrowedItems())
        {
            Console.WriteLine($"- {item.GetDetails()}");
        }

        Console.WriteLine();

        // Return an item
        Console.WriteLine("Returning an item:");
        Console.WriteLine("------------------");
        if (item1 != null)
            Console.WriteLine(alice.ReturnItem(item1));

        Console.WriteLine();

        // Show borrowed items after return
        Console.WriteLine($"Items borrowed by Alice after return:");
        Console.WriteLine("-------------------------------------");
        foreach (var item in alice.GetBorrowedItems())
        {
            Console.WriteLine($"- {item.GetDetails()}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}