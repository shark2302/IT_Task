using System;

namespace FurnitureLib
{
    public abstract class Cupboard: IFurniture
    {

        public enum Material
        {
            WOOD, 
            STEEL
        }
        public Material CupboardMaterial { get; set; }

        public int ShelfCount { get; set; }

        private float _startPrice;

        public DateTime DataOfCreate { get; set; }
        public abstract string GetInfo();
        
        public Cupboard(Material material, int shelfCount, float startPrice, int yearOfCreate)
        {
            CupboardMaterial = material;
            DataOfCreate = new DateTime(yearOfCreate, 1, 1);
            if (shelfCount >= 0)
                ShelfCount = shelfCount;
            else
                ShelfCount = 0;
            if (startPrice > 0)
                _startPrice = startPrice;
            else
                _startPrice = 0;
        }
        
        public float CountPrice()
        {
          
            if (DateTime.Now.Year - DataOfCreate.Year < 100)
            {
                var price = _startPrice - DataOfCreate.Year / 100;
                if (price > 0)
                    return price;
                if (price < 0)
                    return 10;
            }
            return DataOfCreate.Year + _startPrice;
        }

      
        
    }
}
