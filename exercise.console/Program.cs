using exercise.console.Data;

bool running = true;

ProductInventory.Initialize();

while (running)
{
    
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("***************************");
    Console.WriteLine("Welcome to the Boolean Shop");
    Console.WriteLine("1 List Products");
    Console.WriteLine("2 Add product");
    Console.WriteLine("3 Delete Product");
    Console.WriteLine("q to Quit");
    Console.WriteLine("***************************");
    Console.WriteLine("");
    Console.WriteLine("");


    string selection = Console.ReadLine();

    
    switch (selection)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Boolean Stock List");
            Console.WriteLine("");
            ProductInventory.Read();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Enter Product name to add");
            string item = Console.ReadLine();
            ProductInventory.Create(item);
            Console.WriteLine("Added..");
            Thread.Sleep(1200);
            Console.Clear();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Enter Product Id to delete");
            ProductInventory.Read();
            string id = Console.ReadLine();
            ProductInventory.Delete(int.Parse(id));
            Console.WriteLine("Deleted..");
            Thread.Sleep(1200);
            Console.Clear();
            break;
        case "q":
        case "Q":
            return;
        default:
            break;
            
    }
}