namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Bài 2.1:
            Console.WriteLine("Câu 2.1:");
            var userInfo = new
            {
                id=2024,
                name="Đỗ Lê Minh Trung",
                isPlaying=true,
                bag=new
                {
                    skin=999999,
                    cup=100
                }
            };
            Console.WriteLine("ID: "+userInfo.id);
            Console.WriteLine("Name: " + userInfo.name);
            Console.WriteLine("Isplaying: " + userInfo.isPlaying);
            Console.WriteLine("Bag skins: " + userInfo.bag.skin);
            Console.WriteLine("Bag cups: " + userInfo.bag.cup);
            Console.WriteLine();
            //Bài 2.2:
            Console.WriteLine("Câu 2.2:");
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int tong = x + y;
                int hieu = x - y;
                Console.WriteLine("Tổng hai số là " + tong);
                Console.WriteLine("Hiệu hai số là " + hieu);
            };
            AnonymousMethod(5);
            Console.ReadKey();
        }
    }
}
