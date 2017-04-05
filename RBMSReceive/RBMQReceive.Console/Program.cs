﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RBMQReceive.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var type = "abc";

            System.Console.WriteLine("Started...");
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: type,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    System.Console.WriteLine(" [x] Received {0}", message);
                };
                channel.BasicConsume(queue: type,
                                     noAck: true,
                                     consumer: consumer);

                System.Console.WriteLine(" Press [enter] to exit.");
                System.Console.ReadLine();
            }
        }
    }
}
