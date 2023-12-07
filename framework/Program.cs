using System;
using System.Windows.Forms;

namespace framework
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CadastroSimples cadastroSimples = new CadastroSimples();
            CadastroPaiFilho cadastroPaiFilho = new CadastroPaiFilho();
            ConsultaSimples consultaSimples = new ConsultaSimples(cadastroSimples);
            ConsultaPaiFilho consultaPaiFilho = new ConsultaPaiFilho(cadastroPaiFilho);
    
            cadastroSimples.NovoRegistro(new Registro { Nome = "Registro1" });
            cadastroSimples.NovoRegistro(new Registro { Nome = "Registro2" });
            cadastroSimples.GravaRegistro(new Registro { Id = 1, Nome = "Atualizado" });
            cadastroSimples.ExcluiRegistro(2);

            cadastroPaiFilho.NovoRegistro(new Registro { Nome = "Pai-Filho1" });
            cadastroPaiFilho.GravaRegistro(new Registro { Id = 1, Nome = "Atualizado Pai-Filho" });
            cadastroPaiFilho.ExcluiRegistro(2);

            consultaSimples.Filtrar("filtro");
            consultaSimples.Alterar(1);
            consultaSimples.Incluir(2);

            consultaPaiFilho.RecebePai(new Registro { Id = 3, Nome = "RegistroPai" });
            consultaPaiFilho.Filtrar("filtro");
            consultaPaiFilho.Alterar(1);
            consultaPaiFilho.Incluir(3);

            Console.ReadLine();
        }
    }
}
