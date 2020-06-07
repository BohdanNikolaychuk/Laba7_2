using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_2
{
    class Net : IComparable<Net>
    {
        public int Number { get; set; }

        public string Secondname { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public int Debt { get; set; }

        public int  Sum { get; set; }
       


        public Net(int Number,string Secondname,string Name,string Adress,int Debt,int Sum)
        {
            this.Number = Number;
            this.Secondname = Secondname;
            this.Name = Name;
            this.Adress = Adress;
            this.Debt = Debt;
            this.Sum = Sum;

        }


        public int CompareTo(Net obj)
        {
            if (this.Number > obj.Number)
            {
                return 1;
            }
            if (this.Number < obj.Number)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return String.Format("\tНомер: {0}\tПрізвище: {1}\tІм*я:{2}\tАдреса{3}\tБорг: {4}\tСума:{5}  ", this.Number, this.Secondname, this.Name,this.Adress,this.Debt,this.Sum);
            

        }
    }
}
