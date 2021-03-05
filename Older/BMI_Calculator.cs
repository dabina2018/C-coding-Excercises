using System;

namespace BMI_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            string sweight;
            double weight;

            Console.WriteLine("enter weight");
            sweight = Console.ReadLine();
            if (double.TryParse(sweight, out weight))
            {
                //Console.WriteLine(weight); 
            }
            string sheight;
            double height;
            Console.WriteLine("enter height");
            sheight = Console.ReadLine();
            if (double.TryParse(sheight, out height))
            {
                //Console.WriteLine(height);
            }
            double BMI = (weight * 703) / (Math.Pow(height, 2));
            Console.WriteLine("Calculated BMI is :", BMI);

            //part II
            string classification = "none";
            string subclass = "none";
            if (BMI > 30)
            {
                classification = "Obese";
                if (30 <= BMI && BMI <= 34.9)
                { subclass = "Obese class I"; }
                else if (35 <= BMI && BMI <= 39.9)
                { subclass = "Obese class II"; }
                else if (BMI > 40)
                { subclass = "Obese class III"; }
            }
            else if (25 <= BMI && BMI <= 29.9)
            {
                classification = "Overweight";
            }
            else if (18.5 <= BMI && BMI <= 24.9)
            {
                classification = "Normal weight";
            }
            else if (BMI < 18.5)
            {
                classification = "Underweight";
                if (BMI < 16)
                { subclass = "severe thinness"; }
                else if (16 <= BMI && BMI <= 16.99)
                { subclass = "Moderate thinness"; }
                else if (17 <= BMI && BMI <= 18.49)
                { subclass = "Mild thinness"; }
            }
            Console.WriteLine("BMI clasification is: " + classification + ", subclass is :" + subclass);
        }
    }
}
