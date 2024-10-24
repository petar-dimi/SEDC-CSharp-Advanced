namespace Homework09Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string basePath = Directory.GetCurrentDirectory();

            
            string folderPath = Path.Combine(basePath, "Files");
            string namesFilePath = Path.Combine(folderPath, "names.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder 'Files' created.");
            }

            
            if (!File.Exists(namesFilePath))
            {
                File.Create(namesFilePath).Close();
                Console.WriteLine("File 'names.txt' created inside the 'Files' folder.");
            }

            
            Console.WriteLine("Enter names (type 'exit' to stop):");
            using (StreamWriter writer = new StreamWriter(namesFilePath, true)) // Append mode
            {
                string input;
                while (true)
                {
                    input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    writer.WriteLine(input);
                }
            }

            string[] names = File.ReadAllLines(namesFilePath);
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                var filteredNames = names.Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (filteredNames.Any())
                {
                    string filteredFilePath = Path.Combine(folderPath, $"namesStartingWith_{letter}.txt");

                    using (StreamWriter writer = new StreamWriter(filteredFilePath, true)) // Append mode
                    {
                        foreach (var name in filteredNames)
                        {
                            writer.WriteLine(name);
                        }
                    }

                    Console.WriteLine($"Names appended to 'namesStartingWith_{letter}.txt'.");
                }
            }

            Console.WriteLine("Filtering and appending complete.");

            
            string exerciseFolderPath = Path.Combine(basePath, "Exercise");
            string calculationsFilePath = Path.Combine(exerciseFolderPath, "calculations.txt");

            
            if (!Directory.Exists(exerciseFolderPath))
            {
                Directory.CreateDirectory(exerciseFolderPath);
                Console.WriteLine("Folder 'Exercise' created.");
            }

            
            if (!File.Exists(calculationsFilePath))
            {
                File.Create(calculationsFilePath).Close();
                Console.WriteLine("File 'calculations.txt' created inside the 'Exercise' folder.");
            }

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Calculation {i + 1}:");
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                
                string result = Calculate(num1, num2);

                
                Console.WriteLine(result);

                
                AppendToFile(calculationsFilePath, result);
            }

            Console.WriteLine("Calculations completed.");
        }

        
        static string Calculate(double num1, double num2)
        {
            double sum = num1 + num2;
            return $"{num1} + {num2} = {sum}";
        }

       
        static void AppendToFile(string filePath, string result)
        {
            string timestampedResult = $"{DateTime.Now}: {result}";

            using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
            {
                writer.WriteLine(timestampedResult);
            }
        }
    }
}
