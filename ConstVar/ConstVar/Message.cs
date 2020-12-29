using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    public class Message
    {
        public Message(string name) : this(name, 5000)
        {
        }

        public Message(string name, int owed)
        {
            Name = name;
            Amount = owed;
            Console.WriteLine("\nWe are sorry to inform you {0}, you owe us a total of ${1} before you are allowed to access your funds.", name, Amount);
        }

        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
