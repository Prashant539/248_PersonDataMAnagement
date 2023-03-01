﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operations
    {
        public void RetreiveTopRecordsOfAge(List<Person> persons)
        {
            var data = persons.Where(x => x.Age < 60).ToList().Take(2);
            foreach (var result in data)
            {
                Console.WriteLine(result.SSN);
            }
        }
    }
}