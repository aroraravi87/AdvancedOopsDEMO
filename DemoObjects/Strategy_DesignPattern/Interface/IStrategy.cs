﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DesignPattern.Interface
{
   public interface IStrategy
   {
       int doOperation(int num1, int num2);
   }
}
