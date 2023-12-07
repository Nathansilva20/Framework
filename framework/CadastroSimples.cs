
namespace framework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CadastroSimples : IOperacoesCRUD<Registro>
    {
        private List<Registro> baseDeDados = new List<Registro>();

        public void NovoRegistro(Registro registro)
        {
            registro.Id = baseDeDados.Count + 1;
            baseDeDados.Add(registro);
            Console.WriteLine("Novo registro adicionado com sucesso.");
        }

        public void GravaRegistro(Registro registro)
        {
            var registroExistente = BuscaRegistro(registro.Id);
            if (registroExistente != null)
            {
                registroExistente.Nome = registro.Nome;
                Console.WriteLine("Registro atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Registro não encontrado.");
            }
        }

        public void ExcluiRegistro(int id)
        {
            var registro = BuscaRegistro(id);
            if (registro != null)
            {
                baseDeDados.Remove(registro);
                Console.WriteLine("Registro excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Registro não encontrado.");
            }
        }

        public Registro BuscaRegistro(int id)
        {
            return baseDeDados.FirstOrDefault(r => r.Id == id);
        }
    }

}
