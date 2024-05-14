namespace Bai3
{
    public class Users
    {
        public string hoTen { get; set; }
        public string maSV { get; set; }
    }
    public class userData
    {
        public string ID { get; set; }
        List<float> Scores=new List<float>();
        public Users a=new();
        public userData(string _hoTen, string _maSV, string _ID, List<float> ds)
        {
            a.hoTen = _hoTen;
            a.maSV = _maSV;
            ID = _ID;
            Scores = ds;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.InputEncoding=System.Text.Encoding.Unicode;
            Console.Write("Nhập họ tên:");
            string ht=Console.ReadLine();
            Console.Write("Nhập mã số sinh viên:");
            string msv= Console.ReadLine();
            Console.Write("Nhập ID:");
            string _id= Console.ReadLine();
            List<float> listScores=new List<float>();
            for (int i=0;i<6;i++)
            {
                Console.Write("Score 0" + (i + 1) + ":");
                float score=float.Parse(Console.ReadLine());
                listScores.Add(score);
            }
            userData t=new userData(ht,msv,_id,listScores);
            Console.WriteLine("Name: " + t.a.hoTen);
            Console.WriteLine("Student Code: "+t.a.maSV);
            Console.WriteLine("ID: "+t.ID);
            Console.Write("Các điểm của người chơi {0} là: ", t.a.hoTen);
            foreach (float s in listScores)
            {
                Console.Write("{0}  ", s);
            }
            Console.ReadKey();
        }
    }
}
