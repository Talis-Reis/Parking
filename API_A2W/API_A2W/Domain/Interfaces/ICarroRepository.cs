using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_A2W.Domain.Interfaces
{
    public interface ICarroRepository<CarroEntity>
    {
        Task<IEnumerable<CarroEntity>> SelectAll();

        Task<CarroEntity> SelectCarroById(int Id);

        Task<CarroEntity> CreateCarro(CarroEntity carro);

        Task<CarroEntity> UpdateCarro(CarroEntity carro);

        Task<bool> RemoveCarro(int Id);
    }
}
