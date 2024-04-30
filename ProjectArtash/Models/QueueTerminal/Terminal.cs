using ProjectArtash.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArtash.Models.QueueTerminal
{
    public class Terminal
    {

        public Queue<Client> queue { get; set; }

        public Terminal()
        {
            queue = new Queue<Client>();
            queue.Enqueue(new Client("TerminalClient", "First", 30));
            queue.Enqueue(new Client("TerminalClient", "Second", 25));
        }


        public void GetToken(Client client)
        {

            queue.Enqueue(client);
            Console.WriteLine($"{client.Name}. You are number {queue.Count} in the queue.");
        }

        public void ServeNext()
        {
            if (queue.Count > 0)
            {
                Client currentClient = queue.Dequeue();
                Console.WriteLine($"Now serving {currentClient.Name} Id:{currentClient.Id}.");
            }
            else
            {
                Console.WriteLine("No clients in the queue.");
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Current queue:");
            foreach (var client in queue)
            {
                Console.WriteLine($"Client {client.Name} (Id: {client.Id})");
            }
        }
        public void ServeQueueWithDelay(Client client)
        {
            while (queue.Peek() != client)
            {

                Client currentClient = queue.Dequeue();
                Console.WriteLine($"Serving client: {currentClient.Name},please wait");


                Task.Delay(10000).Wait();
            }

            Console.WriteLine("Now we are serving you.");
        }
    }
}


