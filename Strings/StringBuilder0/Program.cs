using System;
using System.Text;

namespace StringBuilder0{
    class Program{
        static void Main(string[] args){
            //quando possuimos textos mt grandes, uma das opções é utilizar o @, pois, vai ler a string completa
            //como se fosse apenas 1 line >> poupa memória

            //se precisar criar as linhas de forma dinâmica, o ideal é que utilize o StringBuilder

            var text = "Este é um texto teste";
            text += " AQUI";

            var text2 = new StringBuilder(); //construção de texto
            text2.ToString(); //dentro de um outro tipo de objeto, mt provável q tenhamos q converter .ToString()
                                //aqui não foi necessário, pois, o WriteLine já realiza a conversão

            text2.Append("Testando ");
            text2.Append("a ");
            text2.Append("frase ");
            text2.Append("teste");
            Console.WriteLine(text2);

        }
    }
}