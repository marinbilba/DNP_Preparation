using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplicationTEST.DataContainer.Repository
{
    public interface IVolumeCalculatorRepository
    {
        Task<VolumeResult> AddVolumeResult(VolumeResult volumeResult);
        Task<IList<VolumeResult>> GetAllCalculations();
    }
}