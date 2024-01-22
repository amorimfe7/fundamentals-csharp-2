namespace Equals{
    class Program{
        static void Main(string[] args){
            //Equals | Exatamente igual
            var text = "Testando comparação com Equals";
            Console.WriteLine(text.Equals("Testando comparação com equals"));
            Console.WriteLine(text.Equals("Testando comparação com Equals"));
        }
    }
}