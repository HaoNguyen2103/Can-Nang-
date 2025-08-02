class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao chieu cao : ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap vao can nang : ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double bmi = weight / Math.Pow(height, 2);
         Console.WriteLine("Chi so BMI la: " + bmi);
        if (bmi < 18)
        {
            Console.WriteLine("Underweight");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
       
    }
}