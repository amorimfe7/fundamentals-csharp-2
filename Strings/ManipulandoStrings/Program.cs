namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args){

            var text = "      Este é um texto de teste";
            
            Console.WriteLine(text.Replace("x", "7")); //troque 'este' por "isso"

            var divisao = text.Split(" "); //divida o texto
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);
            Console.WriteLine(divisao[5]);

            var resultado = text.Substring(10,5); //pegue da posição 10, 5 caracteres em diante (incluindo espaços)
            var resultado = text.Substring(10,text.LastIndexOf("o"));
            Console.WriteLine(resultado);

            Console.WriteLine(text.Trim()); //remove espaço do começo e do fim
        }
    }
}