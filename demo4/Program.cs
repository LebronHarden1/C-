namespace demo4
{
    enum qqState
    {
        online=2,
        offline,//默认值就是3
        hidden//默认值就是4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine((qqState)a);//打印offline，也就是拿着值找到枚举项
        }
    }
}