using System;

public class ConsultaSimples
{
    private IOperacoesCRUD<Registro> operacoesCRUD;

    public ConsultaSimples(IOperacoesCRUD<Registro> operacoesCRUD)
    {
        this.operacoesCRUD = operacoesCRUD;
    }

    public void Filtrar(string filtro)
    {
        Console.WriteLine($"Filtrando por: {filtro}");
    }

    public void Alterar(int id)
    {
        var registro = operacoesCRUD.BuscaRegistro(id);
        if (registro != null)
        {
            registro.MostrarDetalhes();
            Console.WriteLine("Abrindo tela de edição...");
        }
        else
        {
            Console.WriteLine("Registro não encontrado.");
        }
    }

    public void Incluir(int id)
    {
        var registro = operacoesCRUD.BuscaRegistro(id);
        if (registro != null)
        {
            registro.MostrarDetalhes();
            Console.WriteLine("Abrindo tela de inclusão...");
        }
        else
        {
            Console.WriteLine("Registro não encontrado.");
        }
    }
}
