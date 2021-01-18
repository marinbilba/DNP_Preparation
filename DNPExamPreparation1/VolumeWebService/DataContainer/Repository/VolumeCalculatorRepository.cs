using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTEST.DataContainer.DataContext;

namespace WebApplicationTEST.DataContainer.Repository
{
    public class VolumeCalculatorRepository : IVolumeCalculatorRepository
    {
        private VolumeCalculatorContext ctx;

        public VolumeCalculatorRepository()
        {
            ctx=new VolumeCalculatorContext();
        }

        public async Task<VolumeResult> AddVolumeResult(VolumeResult volumeResult)
        {
            await ctx.VolumeResults.AddAsync(volumeResult);
            ctx.Entry(volumeResult).State = EntityState.Added;
            await ctx.SaveChangesAsync();
            return volumeResult;
        }

        public async Task<IList<VolumeResult>> GetAllCalculations()
        {
            return ctx.VolumeResults.ToList();
        }
    }
}