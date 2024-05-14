namespace Bai1
{
    public class userData
    {
        private string id;
        private string name;
        private int level;
        public userData(string _id, string _name, int _level)
        {
            id = _id;
            name = _name;
            level = _level;
        }
        public void getInfo()
        {
            Console.WriteLine("ID: " + id + " |Name: " + name + " |Level: " + level);
        }
    }
    internal class Program
    {
        public static void Bai1a()
        {
            var x = 10;
            Console.WriteLine("x: " + x);
        }
        public static void Bai1b()
        {
            getDetail(10);
            getDetail("games");
            getDetail(true);
            getDetail(9.5);

        }
        public static void getDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }
        public static void Bai1c()
        {
            userData data = new userData("2024", "Đỗ Lê Minh Trung", 100);
            data.getInfo();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 1a:");
            Bai1a();
            Console.WriteLine();
            Console.WriteLine("Bài 1b:");
            Bai1b();
            Console.WriteLine();
            Console.WriteLine("Bài 1c:");
            Bai1c();
            Console.ReadKey();
        }
    }
}
