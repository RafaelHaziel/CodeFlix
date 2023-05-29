
namespace CodeFlix.Interfaces;

public interface IRepository<T> where T : class 
{
    // CRUD (CREATE, READ, UPDATE, DELETE)
    // Create - Adicionar novo Dado
    void Add(T model);

    // Read - Leitura de Dados
    List<T> ReadAll();
    T ReadById(int? id);

    // Update - Atualizar um Dado
    void Update(T model);

    // Delete - Excluir Dado
    void Delete(int? id);
}
