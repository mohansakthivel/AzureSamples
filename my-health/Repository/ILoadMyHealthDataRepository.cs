using System;
using my_health.Models;

namespace my_health.Repository
{
    public interface ILoadMyHealthDataRepository
    {
        public MyHealthDataDto GetAllMyHealthData();
        public MyHealthDataDto GetMyHealthDataByDate(DateTime heartDataDate);
    }
}
