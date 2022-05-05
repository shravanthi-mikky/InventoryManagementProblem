// See https://aka.ms/new-console-template for more information
using InventoryManagementProject;
using Newtonsoft.Json;

Console.WriteLine("Welcome to JSON Inventory Data Management of Rice, Pulses and Wheats");
//Taking Input from the JSON file
string filePath = @"C:\Users\santo\OneDrive\Desktop\BridgeLabz\Projects\InventoryManagementProblem\InventoryManagementProject\jsconfig1.json";

while (true)
{
    Console.WriteLine("Please choose the correct option : \n1) uc1");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            //Deserializing the data in JSON file to Collection
            List<Inventory> InList = JsonConvert.DeserializeObject<List<Inventory>>(File.ReadAllText(filePath));
            Console.WriteLine("The Inventory details are :");
            foreach (Inventory data in InList)
            {
                Console.WriteLine("Name :" + data.Name + " Weight :" + data.Weight + " Cost :" + data.Cost);
            }
            //SErialize to JSON string
            string json1 = JsonConvert.SerializeObject(InList);
            Console.WriteLine("The output as JSON string :\n " + json1);
            break;
        default:
            Console.WriteLine("Please choose correct option !");
            break;
    }
}
