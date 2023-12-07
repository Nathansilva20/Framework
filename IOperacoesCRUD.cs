public interface IOperacoesCRUD<T>
{
    void NovoRegistro(T registro);
    void GravaRegistro(T registro);
    void ExcluiRegistro(int id);
    T BuscaRegistro(int id);
}
