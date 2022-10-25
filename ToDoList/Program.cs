using ToDoList;

ToDo ToDo1 = new ToDo();
void Menu()
{
    Console.WriteLine("1. Создать список дел");
    Console.WriteLine("2. Добавить новую запись в список ");
    Console.WriteLine("3. Посмотреть список дел");
    Console.WriteLine("4. Удалить дело из списка");
}
void FuncMenu()
{
    while (true)
    {
        Menu();
        string select = Console.ReadLine();
        int select1 = int.Parse(select);

        switch (select1)
        {
            case 1:
                ToDo1.CreateList();
                break;
            case 2:
                ToDo1.AddList();
                break;
            case 3:
                ToDo1.InfoList();
                break;
            case 4:
                ToDo1.DeleteList();
                break;

            default:
                Console.WriteLine($"Такого пункта нет");
                break;
        }
    }
}

FuncMenu();