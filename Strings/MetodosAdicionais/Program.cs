namespace MetodosAdicionais{
    class Program{
        static void Main(string[] args){

            var text = "Este é um texto criado para teste";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            // Console.WriteLine(text.Insert(7, "INSERIDO"));
            Console.WriteLine(text.Remove(2, 2)); //começar no indice 2 e remover os próximos 2 caracteres
            Console.WriteLine(text.Length);
        }
    }
}
