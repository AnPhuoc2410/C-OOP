using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Phoenix = new Student();
            //toàn bộ info bên trong object là default:
            //chuỗi -> empty, số -> 0, bool -> false

            Phoenix.FlexProfile();
            Phoenix.SetId("AGENT1");
            Phoenix.SetName("Phoenix");
            Phoenix.SetGpa(8.6);
            Phoenix.SetPassword(1234);
            Console.WriteLine(Phoenix.ToString());
            Console.WriteLine(Phoenix);//Gọi thầm
            //Khi bạn quyết định in biến object, bên C in ra địa chỉ(address) con trỏ
            //Bên Java C# đi tìm hàm ToString() để chạy
            //Java in ra Hash của vùng Ram nếu Class mình làm k có hàm ToString(), đi gọi hàm của cha
            //C#: K in ra mã băm(Hash) vùng ram của class nếu Class của mình k có hàm ToString(), trả về data type của vùng new - tình huống trả về chữ Student

            //Vậy nếu mình cố tình sửa lại code ToString() -> Thì mới gọi là Override phủ quyết
        }
    }
}
