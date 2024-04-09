string folderPath = @"C:\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);

}

else
{
    File.Create(filePath).Close();

    Console.WriteLine($"File {fileName} created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);

}


ShowItemsFromList(myShoppingList);

static List<string> GetItemsFromUser ()
{
        List<string> userList = new List<string>();
    while (true)
    {
        Console.WriteLine("Print add/exit");
        string userChoise = Console.ReadLine();

        if (userChoise == "add")
        {
            Console.WriteLine("Enter item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }

    return userList;
}

static void ShowItemsFromList (List<string> somelist)
{
    Console.Clear();

    int listLenght = somelist.Count;

    Console.WriteLine($"Listis on {listLenght} itemit");

    int i = 1;
    foreach (string item in somelist)
    {
        Console.WriteLine($"{i} {item}");
        i++;
    }
}