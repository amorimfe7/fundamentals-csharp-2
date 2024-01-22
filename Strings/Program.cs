namespace Strings{
    class Program{
        static void Main(string[] args){
            var price = 10.2;
            //Concatenação
                var text0 = "O preço do produto é: " + price;
                Console.WriteLine(text0);

            //String.Format();
                var promocao = true;
                var text1 = string.Format("O preço do produto é: {0}, a promoção é {1}", price, promocao);
                Console.WriteLine(text1);

            // $"" | $@ significa que tudo é uma string
            var text2 = $@"O preço do produto é {price}
            apenas na promoção";
            Console.WriteLine(text2);
        }
    }
}