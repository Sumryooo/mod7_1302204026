﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace mod7_1302204026
{
    internal class BankTransferConfig
    {
        string jsonFilePath = @"D:\kuliah\mod7_1302204026.json";
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            dynamic data = JsonConvert.DeserializeObject(jsonFile);

            Console.Write(data.lang + " Please Insert the ammout of money to transfer : ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine();

            int total;
            int threshold = data.transfer.threshold;

            if (a <= threshold)
            {
                int x = data.transfer.low_fee;
                total = a + x;
            }
            else
            {
                int x = data.transfer.high_fee;
                total = a + x;
            }
            Console.Write("Total Biaya : ");
            Console.WriteLine(total);

            Console.Write(data.lang + " Select transfer method : ");
            string b = Console.ReadLine();

            Console.WriteLine("Please type " + data.confirmation.en + " to confirm the transaction:");
            string confirm = data.confirmation.en;
            string c = Console.ReadLine();

            if (c == confirm)
            {
                Console.WriteLine("The transfer is completed");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }
    }
}
