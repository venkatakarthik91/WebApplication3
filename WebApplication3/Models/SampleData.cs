using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class SampleData
    {
        public static List<string> listOfGirlFriends;
        static SampleData()
        {
            listOfGirlFriends = new List<string>();
            listOfGirlFriends.Add("Anjana");
            listOfGirlFriends.Add("Archana");
        }
    }
}
