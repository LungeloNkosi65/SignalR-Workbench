using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_WorkBench.Shared
{
   public class DeveloperData
    {
        public static List<Developer> Developers = new List<Developer>
        {
            new Developer(1,"Lungelo","Nkosi","l@gmail.com",1),
            new Developer(2,"Mdumazi","Mhlongo","m@gmail.com",2),
            new Developer(3,"Khuzai","Mpungose","khuba@gmail.com",1)

        };
    }
}
