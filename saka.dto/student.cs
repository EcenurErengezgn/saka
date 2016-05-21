using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saka.dto
{
   public class student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public student(int id, string name, int score)
        {
            ID = id;
            Name = name;
            Score = score;
        }
    }
}
