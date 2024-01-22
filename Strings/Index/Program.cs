namespace Index{
    class Program{
        static void Main(string[] args){
            //Index/Índice da lista
            var text = "Testando o Index";
            var position = (text.IndexOf("o")); //IndexOf sempre vai pedir um obj do mesmo tipo
            var lastPosition = (text.LastIndexOf("x"));

            Console.WriteLine($"O índice desejado está na posição {position}");
            Console.WriteLine($"O último índice utilizando o filtro desejado está na posição {lastPosition}");
        }
    }
}