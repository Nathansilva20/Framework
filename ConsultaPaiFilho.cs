using System;

public class ConsultaPaiFilho
{
    private IOperacoesCRUD<Registro> operacoesCRUD;

    public ConsultaPaiFilho(IOperacoesCRUD<Registro> operacoesCRUD)
    {
        this.operacoesCRUD = operacoesCRUD;
    }

    public void RecebePai(Registro registroPai)
    {
        Console.WriteLine($"Recebido registro pai-filho com Id: {registroPai.Id}");
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
