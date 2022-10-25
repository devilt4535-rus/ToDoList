using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDo
    {
        private List<string> _toDoList;
        private bool _checkList = false;
        private bool _delete = false;
        public ToDo()
        {

        }

        public void CreateList()
        {
            if (_checkList == false)
            {
                _toDoList = new List<string>();
                Console.WriteLine();
                Console.WriteLine("Список дел создан");
                Console.WriteLine();
                _checkList = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Список дел уже создан");
                Console.WriteLine();
            }
        }

        public void AddList()
        {
            if (_checkList == true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите пункт в список дел");
                Console.WriteLine();
                string select = Console.ReadLine();
                bool a = _toDoList.Contains(select);
                if (a == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Дело уже есть в списке дел");
                    Console.WriteLine();
                }
                else
                {
                    _toDoList.Add(select);
                    Console.WriteLine();
                    Console.WriteLine($" Пункт - {select} добавлен в список дел");
                    Console.WriteLine();
                    _delete = true;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Сначало создайте список дел");
                Console.WriteLine();
            }
        }

        public void InfoList()
        {
            if (_checkList == true)
            {
                foreach (string toDo in _toDoList)
                {
                    Console.WriteLine();
                    Console.WriteLine(toDo);
                    Console.WriteLine();
                }
                if (_delete == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Список пуст обратитесь к банку Tinkoff");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Сначало создайте список дел");
                Console.WriteLine();
            }
        }

        public void DeleteList()
        {
            if (_checkList == true)
            {
                Console.WriteLine();
                Console.WriteLine("Какой пункт вы хотите удалить из списка?");
                Console.WriteLine();
                string delete = Console.ReadLine();
                bool a = _toDoList.Contains(delete);
                {
                    if (a == true)
                    {
                        _toDoList.Remove(delete);
                        Console.WriteLine();
                        Console.WriteLine($"Вы удалили пункт {delete}");
                        Console.WriteLine();
                        _delete = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Такого дела нет");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Сначало создайте список дел");
                Console.WriteLine();
            }
        }
    }
}

