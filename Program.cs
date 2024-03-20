namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Xosh Geldiniz...");
            List<string> list = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("Hansi Emeliyyati Etmek Isterdiniz?");
                Console.WriteLine("1-i Secerek  yeni task-lar elave ede bilersiniz ");
                Console.WriteLine("2-i Secerek List-den task-lar sile bilersiniz ");
                Console.WriteLine("3-u Secerek List-e baxa bilersiniz");
                Console.WriteLine("0-i Secerek Programdan Cixa Bilersiniz");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Elave etmek istediyiniz task-i daxil edin: ");
                    string task = Console.ReadLine();
                    list.Add(task);
                    Console.WriteLine("Task Ugurla Elave Olundu .....");
                }
                else if (option == "2")
                {
                    Console.WriteLine("List-de Olan Tasklar: ");

                    for (int i = 0; i <list.Count; i++)
                    {
                        Console.WriteLine($"{i}. {list[i]}");
                    }
                    Console.WriteLine("Silmek Istediyiniz Task-in Indexini Daxil Edin: ");
                    int option1 = Convert.ToInt32(Console.ReadLine());
                    list.RemoveAt(option1);

                }
                else if (option == "3")
                {
                    Console.WriteLine("List-de Olan Tasklar: ");
                    for (int i = 0; i <list.Count; i++)
                    {
                        Console.WriteLine($"{i}. {list[i]}");
                    }
                }
                else if (option == "0")
                {
                    Console.WriteLine("Sistemden Ugurla Cixis Etdiniz!");
                    break;
                }

                else
                {
                    Console.WriteLine("Duzgun Secim Edilmemisdir!");
                }
            }

        }
    }
}