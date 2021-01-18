using System.Collections.Generic;
using System.Threading.Tasks;
using DNPExamPreparation1.Model;

namespace DNPExamPreparation1.Data.Service
{
    public interface IGeometricalFigures
    {
        Task<VolumeResult> CalculateVolumeCylinder(double radius, double height);
        Task<VolumeResult> CalculateVolumeCone(double radius, double height);
        Task<IList<VolumeResult>> GetAllCalculations();
    }
}