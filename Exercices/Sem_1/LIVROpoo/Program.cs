using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIVROpoo
{
    class Program
    {
    static void Main(string[] args)
        {
            Livros[] livros = {
                new ORV(551, 150, "Omniscient Reader's Viewpoint", "singNsong", 2018),
                new RI(2334, 500, "Reverend Insanity", "Gu Zhen Ren", 2012),
                new SS(1850, 200, "Shadow Slave", "Guiltythree", 2022)
            };
           foreach(var p in livros){
                p.exibir();
                p.lançamento();
                p.CalCap();
                Console.WriteLine();
           }
        }
     }
}