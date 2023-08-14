namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要转换的摄氏温度：");
            int num = Convert.ToInt32(Console.ReadLine());
            double res = (1.0*9) / 5 * num + 32;
            Console.WriteLine($"您所输入的摄氏温度转换到华氏温度的结果为：{res}");
            //Console.WriteLine("请输入第一个数字：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"这两个数的商是：{num1/num2}");
            //Console.WriteLine($"这两个数的余数是：{num1%num2}");
            //Console.WriteLine("Hello, World!");
            //int a = 10;
            //Console.WriteLine($"我的年龄是{a}");
            //int b;
            //b = 20;
            //Console.WriteLine(b);
            //int c, d, e, f;
            //c = 1;
            //d = 2;
            //e = 3;
            //d = 4;
            //f = 5;
            //Console.WriteLine("a="+a+",b="+b+",c="+c);
            //int p = 10, g = 30;
            //Console.WriteLine("p=" + p + ",g=" + g);
        }
    }
}