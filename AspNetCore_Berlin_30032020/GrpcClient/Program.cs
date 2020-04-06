using Grpc.Core;
using Grpc.Net.Client;
using GrpcService.Protos;
using GrpcService;

using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        //Beispielvideo YouTube -> https://www.youtube.com/watch?v=QyxCX2GYHxk
        static async Task Main(string[] args)
        {
            #region Hallo Welt Beispiel
            //var input = new HelloRequest { Name = "Tim" };
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            Console.WriteLine("Hello World!");
            #endregion

            #region Übertragen und Anzeigen eines komplexen Objektes
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var customerClient = new Customer.CustomerClient(channel);
            var clientRequested = new CustomerLookupModel { UserId = 2 };

            var customer = await customerClient.GetCustomerInfoAsync(clientRequested);

            Console.WriteLine($"{customer.FirstName} {customer.LastName}");


            #endregion

            #region Übertragen von Listen
            using (var call = customerClient.GetNewCustomers(new NewCustomerRequest()))
            {
                while (await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;

                    Console.WriteLine($"{currentCustomer.FirstName} {currentCustomer.LastName}:{currentCustomer.EmaiAdress}");
                }
            }

            #endregion
            Console.ReadLine();
        }
    }
}
