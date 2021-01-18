using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using DNPExamPreparation1.Model;

namespace DNPExamPreparation1.Data.Service
{
    public class GeometricalFigures :IGeometricalFigures
    {
        private readonly HttpClient client;
        private readonly string uri = " https://localhost:5001";

        public GeometricalFigures()
        {
            client = new HttpClient();
        }

        public async Task<VolumeResult> CalculateVolumeCylinder(double radius, double height)
        {
            var uriBuilder = new UriBuilder($"{uri}/cylinder");

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["height"] = height.ToString();
            query["radius"] = radius.ToString();
            uriBuilder.Query = query.ToString();
            var longurl = uriBuilder.ToString();


            VolumeResult volumeResult = null;
           
            // 1. Send GET request

            var responseMessage = await client.GetStringAsync(longurl);

            return JsonSerializer.Deserialize<VolumeResult>(responseMessage);

        }

        public async Task<VolumeResult> CalculateVolumeCone(double radius, double height)
        {
            var uriBuilder = new UriBuilder($"{uri}/cone");

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["height"] = height.ToString();
            query["radius"] = radius.ToString();
            uriBuilder.Query = query.ToString();
            var longurl = uriBuilder.ToString();
            // 1. Send GET request

            var responseMessage = await client.GetStringAsync(longurl);

            return JsonSerializer.Deserialize<VolumeResult>(responseMessage);
        }

        public async Task<IList<VolumeResult>> GetAllCalculations()
        {

            var responseMessage = await client.GetStringAsync($"{uri}/allResults");
            return JsonSerializer.Deserialize<IList<VolumeResult>>(responseMessage);
        }
    }
    
}