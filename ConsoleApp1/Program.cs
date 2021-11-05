using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {         

            Color myColorPurpule = new Color
            {
                ColorName = "Фиолетовый"
            };

            myColorPurpule.Colors.AddRange(
                new Color[]
                {
                    new Color{ColorName = "Голубой"}
                });



            Color myColorBlue = new Color
            {
                ColorName = "Синий"
            };

            myColorBlue.Colors.AddRange(
                new Color[]
                {
                    new Color{ColorName = "Оранжевый"},
                    new Color{ColorName = "Желтый"}
                });

            Color myColor = new Color
            {
                ColorName = "Зеленый"
            };

            myColor.Colors.AddRange(
                new Color[]
                {
                    myColorBlue,
                    new Color { ColorName = "Красный" },
                    myColorPurpule
                });

            var peremen = myColor;
        }
    }
}
