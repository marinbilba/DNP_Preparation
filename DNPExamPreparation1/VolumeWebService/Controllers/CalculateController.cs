using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTEST.CalculatorService.VolumeCalculator;
using WebApplicationTEST.DataContainer;
using WebApplicationTEST.DataContainer.Repository;

namespace WebApplicationTEST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        private ICalculator _calculator;

        private IVolumeCalculatorRepository _volumeCalculatorRepository;
      
        public CalculateController(ICalculator calculator)
        {
            _calculator = calculator;
           _volumeCalculatorRepository=new VolumeCalculatorRepository();
        }

        [HttpGet]
        [Route("/cylinder")]
        public async Task<Object> VolumeCylinder([FromQuery] double height, [FromQuery] double radius)
        {
         
            var response = new VolumeResult() 
            {
                Height = height,
                Radius = radius,
                Type = "Cylinder",
                Volume =  _calculator.CalculateVolumeCylinder(radius, height)
            };
            await _volumeCalculatorRepository.AddVolumeResult(response);
            return JsonSerializer.Serialize(response);
        }

        [HttpGet]
        [Route("/cone")]
        public async Task<Object> VolumeCone([FromQuery] double height, [FromQuery] double radius)
        {
            var response = new VolumeResult()
            {
                Height = height,
                Radius = radius,
                Type = "Cone",
                Volume = _calculator.CalculateVolumeCone(radius, height)
            };
            await _volumeCalculatorRepository.AddVolumeResult(response);
            return JsonSerializer.Serialize(response);
        }

        [HttpGet]
        [Route("/allResults")]
        public async Task<Object> GetAllResults()
        {
            IList<VolumeResult> response= await _volumeCalculatorRepository.GetAllCalculations();
            return JsonSerializer.Serialize(response);
        }
      
    }
}