using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Car
    {
        public ICarReport Eze;
        public Employee(ICarReport report)
        {
            Eze = eze;
            Hard = hard;
        }
        public string Drive { get; set; }
        public string Repair { get; set; }
        public bool Add(Car emp)
        {
            return true;
        }

        public void MakeReport()
        {
            Eze.MakeCar(this);
        }


        public abstract class Emp
        {
            public virtual string GetWorkDetails(int id)
            {
                return "Base Work";
            }
            public virtual string GetEmpDetails(int id)
            {
                return "Base Emp";
            }
        }

        public class Senior : Emp
        {
            public override string GetWorkDetails(int id)
            {
                return "Senior Work";
            }
            public override string GetEmpDetails(int id)
            {
                return "Senior Emp";
            }
        }

        public class Junior : Emp
        {
            public override string GetWorkDetails(int id)
            {
                throw new NotImplementedException();
            }
            public override string GetEmpDetails(int id)
            {
                return "Junior Emp";
            }
        }





        public interface ICTO
        {
            void Offical();
            void Arms();
        }

        public class Email2 : ICTO
        {
            public void Offical()
            {
                ;
            }
        }

        public class SMS : ICTO
        {
            public void Arms()
            {
                ;
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                List<Emp> lst = new List<Emp>();
                lst.Add(new Senior());
                lst.Add(new Junior());
                foreach (var item in lst)
                {
                    Console.WriteLine(item.GetEmpDetails(123));
                    Console.WriteLine(item.GetWorkDetails(123));
                }
            }
        }
    }
}
