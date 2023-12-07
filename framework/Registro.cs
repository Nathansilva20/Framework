
namespace framework
{
    using System;

    public class Registro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id}, Nome: {Nome}");
        }
    }

}