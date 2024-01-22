namespace ComparaString{
    class Program{
        static void Main(string[] args){
            //ComparteTo retorna 0 e 1
            var text1 = "Testando a Comparação";
            var text2 = "Testando 2"; 
            // Console.WriteLine(text1.CompareTo("testando"));

            //Contains | Contém > retorna True or False
            Console.WriteLine(text1.Contains("teste"));
            Console.WriteLine(text1.Contains("testando", StringComparison.OrdinalIgnoreCase)); //ignora case sensitive
        }
    }
}

