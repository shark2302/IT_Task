using System;

namespace FurnitureLib
{
    public interface IFurniture
    {
        public DateTime DataOfCreate { get; set; }

        string GetInfo();

        float CountPrice();
    }
}