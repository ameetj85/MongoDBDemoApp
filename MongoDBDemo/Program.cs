using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "LogiBear",
            //    LastName = "Jayawant"              
            //};

            //PersonModel person = new PersonModel
            //{
            //    FirstName = "James",
            //    LastName = "Jayawant",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "23 MOntauk Ave",
            //        City = "Merrick",
            //        State = "NY",
            //        ZipCode = "11566"
            //    }
            //};

            // db.InsertRecord("Users", person);

            //var records = db.LoadRecords<NameModel>("Users");

            //foreach (NameModel item in records)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //    Console.WriteLine();
            //}

            var records = db.LoadRecords<PersonModel>("Users");

            foreach (PersonModel item in records)
            {
                Console.WriteLine($"{item.Id} : {item.FirstName} {item.LastName}");
                if (item.PrimaryAddress != null)
                {
                    Console.WriteLine(item.PrimaryAddress.City);
                }
                Console.WriteLine();
            }

            // var person = db.LoadRecordById<PersonModel>("Users", new Guid("12be3a03-08f9-4048-b666-30b7be835366"));

            //person.DateOfBirth = new DateTime(1965, 1, 17, 0, 0, 0, DateTimeKind.Utc);

            //db.UpsertRecord<PersonModel>("Users", person.Id, person);

            // db.DeleteRecord<PersonModel>("Users", person.Id);

            Console.ReadLine();
        }
    }
}
