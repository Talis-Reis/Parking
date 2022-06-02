using API_A2W.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_A2W.Domain.Interfaces.Services.Carro
{
    public interface ICarroService
    {
        Task<IEnumerable<CarroEntity>> getAll();

        Task<CarroEntity> getCarroById(int id);

        Task<CarroEntity> putCarro(CarroEntity carro);

        Task<CarroEntity> postCarro(CarroEntity carro);

        Task<bool> deleteCarro(int id);
    }
}
