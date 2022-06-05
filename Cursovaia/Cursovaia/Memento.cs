using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class Memento
    {
        public int Floor { get; set; }//virtual
        public string Name { get; set; }//abs
        public double Price { get; set; }//abs
        public int WindowNumbers { get; set; } //vir
        public int WeightOfArea { get; set; } //h
        public int HeightOfArea { get; set; }//h
        public int TotalArea { get; set; }//h
        public int TotalPer { get; set; }//h
        public int WeightOfHouse { get; set; }//v
        public int HeightOfHouse { get; set; }//v
        public int TotalAreaOfHouse { get; set; }//h 
        public string MaterialHouse { get; set; } //v

        public Memento(int Floor,string Name,double Price,int WindowNumbers, int WeightOfArea, int HeightOfArea, int TotalArea,
                int TotalPer, int WeightOfHouse, int HeightOfHouse, int TotalAreaOfHouse,string MaterialHouse) 
        {
            this.Floor = Floor;
            this.Name = Name;
            this.Price = Price;
            this.WindowNumbers = WindowNumbers;
            this.WeightOfArea = WeightOfArea;
            this.HeightOfArea = HeightOfArea;
            this.TotalArea = TotalArea;
            this.TotalPer = TotalPer;
            this.WeightOfHouse = WeightOfHouse;
            this.HeightOfHouse = HeightOfHouse;
            this.TotalAreaOfHouse = TotalAreaOfHouse;
            this.MaterialHouse = MaterialHouse;
        }
    }
}
