﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region region 1
            for(int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                // cond2 = red light is flashing
                for(int cond2=0; cond2 <= 1; cond2++)
                {
                    for(int k=0; k < 2; k++)
                    {
                        if(printerPrintsCondition == 0 && cond2 == 0 && k == 0)
                        {
                            // print out conditions
                            Console.WriteLine("Print prints condition: NO");
                            // call action methods
                        }
                        if(printerPrintsCondition == 0 && cond2 == 0 && k == 1)
                        {
                            // call action methods
                            // printer jam
                        }
                    }
                }
            }
            #endregion
            #region region 2
            for(int i=0; i <= 7; i++)
            {
                switch (i)
                {
                    case 0:
                        // print out conditions
                        // call action methods for NO, No, NO
                        break;
                    case 1:
                }
            }

            #endregion
        }

        public void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty.");
        }
    }
}
