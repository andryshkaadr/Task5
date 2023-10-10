namespace Task5
{

    public class Program
    {
        static void Main(string[] args)
        {
            Communication[] communications = new Communication[4];

            Console.WriteLine("Array Contents:");
            for (int i = 0; i < communications.Length; i++)
            {
                var communication = communications[i];
                if (communication != null)
                {
                    Console.WriteLine(communication);
                }
            }

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1 - Add an element");
            Console.WriteLine("2 - Delete an element");
            Console.WriteLine("3 - Edit an element");
            Console.WriteLine("0 - Exit");

            while (true)
            {
                Console.Write("Enter the action number: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("\nChoose the type of element to add:");
                            Console.WriteLine("1 - Communication");
                            Console.WriteLine("2 - Speech");
                            Console.WriteLine("3 - Cave Painting");
                            Console.WriteLine("4 - Writing");
                            Console.WriteLine("0 - Exit adding");
                            Console.Write("Enter the element type number: ");
                            int elementTypeChoice = int.Parse(Console.ReadLine());

                            switch (elementTypeChoice)
                            {
                                case 1:
                                    Console.WriteLine("\nAdding a Communication element:");
                                    Communication newCommunication = CreateCommunication();
                                    communications = communications.Concat(new Communication[] { newCommunication }).ToArray();
                                    break;
                                case 2:
                                    Console.WriteLine("\nAdding a Speech element:");
                                    Speech newSpeech = CreateSpeech();
                                    communications = communications.Concat(new Communication[] { newSpeech }).ToArray();
                                    break;
                                case 3:
                                    Console.WriteLine("\nAdding a Cave Painting element:");
                                    CavePainting newCavePainting = CreateCavePainting();
                                    communications = communications.Concat(new Communication[] { newCavePainting }).ToArray();
                                    break;
                                case 4:
                                    Console.WriteLine("\nAdding a Writing element:");
                                    Writing newWriting = CreateWriting();
                                    communications = communications.Concat(new Communication[] { newWriting }).ToArray();
                                    break;
                                case 0:
                                    break;
                                default:
                                    Console.WriteLine("Invalid element type choice.");
                                    break;
                            }

                            if (elementTypeChoice == 0)
                            {
                                break; 
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nDeleting an element:");
                        Console.Write("Enter the index of the element to delete: ");
                        int indexToDelete = int.Parse(Console.ReadLine());
                        if (indexToDelete >= 0 && indexToDelete < communications.Length)
                        {
                            communications = communications.Where((x, i) => i != indexToDelete).ToArray();
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEditing an element:");
                        Console.Write("Enter the index of the element to edit: ");
                        int indexToEdit = int.Parse(Console.ReadLine());
                        if (indexToEdit >= 0 && indexToEdit < communications.Length)
                        {
                            Communication editedCommunication = CreateCommunication();
                            communications[indexToEdit] = editedCommunication;
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nUpdated array contents:");
                for (int i = 0; i < communications.Length; i++)
                {
                    var communication = communications[i];
                    if (communication != null)
                    {
                        Console.WriteLine(communication);
                    }
                }
            }
        }

        static Communication CreateCommunication()
        {
            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Communication Channel: ");
            string communicationChannel = Console.ReadLine();

            Console.Write("Date and Time (yyyy-MM-dd HH:mm:ss): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Context: ");
            string context = Console.ReadLine();

            return new Communication(message, author, communicationChannel, dateTime, context);
        }

        static Speech CreateSpeech()
        {
            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Communication Channel: ");
            string communicationChannel = Console.ReadLine();

            Console.Write("Date and Time (yyyy-MM-dd HH:mm:ss): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Context: ");
            string context = Console.ReadLine();

            Console.Write("Language: ");
            string language = Console.ReadLine();

            Console.Write("Duration (in minutes): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Topic: ");
            string topic = Console.ReadLine();

            return new Speech(message, author, communicationChannel, dateTime, context, language, duration, topic);
        }

        static CavePainting CreateCavePainting()
        {
            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Communication Channel: ");
            string communicationChannel = Console.ReadLine();

            Console.Write("Date and Time (yyyy-MM-dd HH:mm:ss): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Context: ");
            string context = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Area: ");
            int area = int.Parse(Console.ReadLine());

            Console.Write("Style: ");
            string style = Console.ReadLine();

            return new CavePainting(message, author, communicationChannel, dateTime, context, location, area, style);
        }

        static Writing CreateWriting()
        {
            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Communication Channel: ");
            string communicationChannel = Console.ReadLine();

            Console.Write("Date and Time (yyyy-MM-dd HH:mm:ss): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.Write("Context: ");
            string context = Console.ReadLine();

            Console.Write("Document Type: ");
            string documentType = Console.ReadLine();

            Console.Write("Language: ");
            string language = Console.ReadLine();

            Console.Write("Page Count: ");
            int pageCount = int.Parse(Console.ReadLine());

            return new Writing(message, author, communicationChannel, dateTime, context, documentType, language, pageCount);
        }
    }

}
