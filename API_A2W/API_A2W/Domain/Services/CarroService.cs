using API_A2W.Domain.Entities;
using API_A2W.Domain.Interfaces;
using API_A2W.Domain.Interfaces.Services.Carro;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_A2W.Domain.Services
{
    public class CarroService : ICarroService
    {

        private ICarroRepository<CarroEntity> _carroRepository;

        public CarroService(ICarroRepository<CarroEntity> carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public async Task<bool> deleteCarro(int id)
        {
            return await _carroRepository.RemoveCarro(id);
        }

        public async Task<IEnumerable<CarroEntity>> getAll()
        {
            return await _carroRepository.SelectAll();
        }

        public async Task<CarroEntity> getCarroById(int id)
        {
            return await _carroRepository.SelectCarroById(id);
        }

        public async Task<CarroEntity> postCarro(CarroEntity carro)
        {
            return await _carroRepository.CreateCarro(carro);
        }

        public async Task<CarroEntity> putCarro(CarroEntity carro)
        {
            return await _carroRepository.UpdateCarro(carro);
        }
    }
}
