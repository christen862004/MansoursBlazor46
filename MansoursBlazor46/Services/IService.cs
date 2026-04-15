using MansoursBlazor46.Models;

namespace MansoursBlazor46.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetByID(int id);

        //Add, remove ,update
    }
}
