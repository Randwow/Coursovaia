using System;
using System.Collections.Generic;
using System.Text;

namespace Cursovaia
{
    class House
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

        public Memento SaveMemento() 
        {
            return new Memento(Floor, Name, Price, WindowNumbers, WeightOfArea, HeightOfArea, TotalArea,
                TotalPer, WeightOfHouse, HeightOfHouse, TotalAreaOfHouse, MaterialHouse);
        }
        public void RestoreMemento(Memento memento) 
        {
            Floor = memento.Floor;
            Name = memento.Name;
            Price = memento.Price;
            WindowNumbers = memento.WindowNumbers;
            WeightOfArea = memento.WeightOfArea;
            HeightOfArea = memento.HeightOfArea;
            TotalArea = memento.TotalArea;
            TotalPer = memento.TotalPer;
            WeightOfHouse = memento.WeightOfHouse;
            HeightOfHouse = memento.HeightOfHouse;
            TotalAreaOfHouse = memento.TotalAreaOfHouse;
            MaterialHouse = memento.MaterialHouse;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name of house " + Name + "\n"
                      + "Number of flourse: " + Floor + "\n"
                      + "Number of Windows: " + WindowNumbers + "\n"
                      + "Section width: " + WeightOfArea + "\n"
                      + "Section lenght: " + HeightOfArea + "\n"
                      + "Total section area: " + TotalArea + "\n"
                      + "Total section perimetr: " + TotalPer + "\n"
                      + "House width: " + WeightOfHouse + "\n"
                      + "House lenght: " + HeightOfHouse + "\n"
                      + "Total house area: " + TotalAreaOfHouse + "\n"
                      + "The material from which the house will be made is: " + MaterialHouse + "\n"
                      + "House Price: " + Price + "\n");
            return sb.ToString();
        }
    }
}