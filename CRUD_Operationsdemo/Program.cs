using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace CRUD_Operationsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConfigurationSection = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
#if DEBUG
                .AddJsonFile("appsettings.Debug.json")
#else
                .AddJsonFile("appsettings.release.json")
#endif
                .Build();


            string connStr = ConfigurationSection.GetConnectionString("DefaultConnection");
            productrepository repo = new productrepository(connStr);


            //All 4 methods are below. C.R.U.D. respectively. you can uncomment each one to test



            //Create
            //repo.CreateNewProduct("MacBook2", 1200.99m);


            //Read
            //repo.GetProductNames(6);


            //Update
            //repo.UpdateTable(25,"MacBook3");


            //Delete
            //repo.DeleteProduct(4);



        }
    }
}
