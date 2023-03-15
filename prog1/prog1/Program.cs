using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //1
            Console.WriteLine("enter the text");
            string text = Console.ReadLine();
            string[] array_words_split = text.Split(" ");
            var words = new List<string>();
            words.AddRange(array_words_split);
            Console.WriteLine("Amount of elements: " + words.Count);
            Console.Write("Enter the index of an element: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter direction (if forward - f, backward - smth else) ");
            string direction = Console.ReadLine();
            if (direction == "b")
            {
                for (int i = index; i >= 0; i--)
                {
                    Console.Write(words[i] + " ");
                }
            }
            else
            {
                for (int i = index; i < words.Count; i++)
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine("\n" + "---------------");
            //2
            // Створюємо словник зі значеннями
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(3, "Webber");
            dictionary.Add(2, "Willow");
            dictionary.Add(1, "Maxwell");
            // Відсортовуємо список значень словника по алфавіту
            var sortedValues = dictionary.Values.OrderBy(value => value).ToList();
            Console.WriteLine("Sorted list of values ");
            foreach (string value in sortedValues)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n" + "Dictionary in JSON: ");
            string jsonString = JsonSerializer.Serialize(dictionary);
            Console.WriteLine(jsonString);
            Console.WriteLine("---------------");
            //3
            Console.Write("enter the amount of elements:  ");
            int amount_elem = int.Parse(Console.ReadLine());
            Console.Write("enter minvalue:  ");
            int minvalue = int.Parse(Console.ReadLine());
            Console.Write("enter maxvalue:  ");
            int maxvalue = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>(amount_elem);
            Random random = new Random();
            for (int i = 0; i < amount_elem; i++)
            {
                numbers.Add(random.Next(minvalue, maxvalue));
                Console.Write(numbers[i] + " ");
            }
            var sorted_numbers = from i in numbers
                                 where i >= 10 && i < 100
                                 orderby i
                                 select i;
            Console.WriteLine("\n" + "Sorted numbers ");
            foreach (var number in sorted_numbers)
            {
                Console.Write(number + " ");
            }

        }
        catch (Exception)
        {
            Console.Write("invalid format");
        }
    }
}