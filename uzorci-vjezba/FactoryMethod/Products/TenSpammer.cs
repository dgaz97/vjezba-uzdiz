﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uzorci_vjezba.FactoryMethod.Abstractions;

namespace uzorci_vjezba.FactoryMethod.Products
{
    public class TenSpammer : ISpammer
    {
        public string SpamMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                sb.AppendLine(message);
            }
            return sb.ToString();
        }
    }
}
