namespace MyApp{
    class Program{
        static void Main(string[] args){
            // var id = Guid.NewGuid(); //gerar um novo GUID

            var id = new Guid("82ced55f-f896-41bb-82ef-9bd6a065d94c"); //assimilando um GUID
            var id2 = Guid.NewGuid(); //gerar um novo GUID

            //comparando grids
            if (id == id2){
                Console.WriteLine("Os Grids são iguais");
            } else {
                Console.WriteLine(id.ToString().Substring(0,8));
                Console.WriteLine(id2.ToString().Substring(0,8));
                Console.WriteLine("Os Grids não são iguais");
            }
        }
    }
}
