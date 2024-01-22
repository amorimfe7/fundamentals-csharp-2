namespace StartEndWith
{
    class Program
    {
        static void Main(string[] args){

            //StartsWith aplica-se IgnoreCase
            var text = "Testando comparação e with";
            Console.WriteLine(text.StartsWith("Testando"));
            Console.WriteLine(text.StartsWith("testando"));

            //EndsWith
            Console.WriteLine(text.EndsWith("with"));
            Console.WriteLine(text.EndsWith("fim"));
        }
    }
}
