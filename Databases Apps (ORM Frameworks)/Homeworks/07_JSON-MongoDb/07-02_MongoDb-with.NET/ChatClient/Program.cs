namespace ChatClient
{
    using System;
    using MongoDB.Driver;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the console chat.");
            Console.WriteLine("Plesase login.");
            Console.WriteLine("Enter Username");

            var username = Console.ReadLine().Trim();
            var isActive = true;

            while (isActive)
            {
                Console.WriteLine("Please use one of options.");
                Console.WriteLine("1. Enter message.");
                Console.WriteLine("2. Show all messages.");
                Console.WriteLine("3. Exit");

                int option = Int32.Parse(Console.ReadLine().Trim());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("=============================");
                        Console.WriteLine("Enter your message: ");
                        Console.WriteLine("=============================");

                        var message = Console.ReadLine().Trim();

                        AddMessage(username, message);
                        break;

                    case 2:
                        Console.WriteLine("=============================");
                        Console.WriteLine("Messages: ");
                        Console.WriteLine("=============================");

                        PrintAllMessages();
                        break;

                    case 3:
                        Console.WriteLine("Bay bay...");
                        isActive = false;
                        break;

                    default:
                        throw new InvalidOperationException("Invalid option!");
                        break;
                }
            }
        }

        public static void AddMessage(string username, string text)
        {
            MongoDatabase db = new MongoClient("mongodb://daniel:1234@ds061548.mongolab.com:61548/chat-db")
                .GetServer()
                .GetDatabase("chat-db");

            var messagesCollection = db.GetCollection<Message>("messages");

            var message = new Message { Date = DateTime.Now, Username = username, Text = text };

            messagesCollection.Insert(message);
        }

        public static void PrintAllMessages()
        {
            MongoDatabase db = new MongoClient("mongodb://daniel:1234@ds061548.mongolab.com:61548/chat-db")
                .GetServer()
                .GetDatabase("chat-db");

            var messagesCollection = db.GetCollection<Message>("messages");

            var messages = messagesCollection.FindAll();

            foreach (var message in messages)
            {
                Console.WriteLine("Message:\n User:{0}\n Text: {1}", message.Username, message.Text);
                Console.WriteLine();
            }
        }
    }
}
