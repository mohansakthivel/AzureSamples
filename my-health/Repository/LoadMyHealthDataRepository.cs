using System;
using System.Collections.Generic;
using my_health.Models;
using System.Linq;

namespace my_health.Repository
{
    public class LoadMyHealthDataRepository : ILoadMyHealthDataRepository
    {
        public MyHealthDataDto GetAllMyHealthData()
        {
            var myNewHeartDataDto = new List<MyHeartDataDto>();
            myNewHeartDataDto.Add(new MyHeartDataDto
            { MyCurrentHeartBeat = 65 ,
               MyAverageHeartBeat = 62 , MyHeartBeatDate = DateTime.Now});

            myNewHeartDataDto.Add(new MyHeartDataDto
            {
                MyCurrentHeartBeat = 65,
                MyAverageHeartBeat = 63,
                MyHeartBeatDate = DateTime.Now
            });

            return new MyHealthDataDto()
            {
                myHeartDataDto = myNewHeartDataDto,
                FirstName = "Mohansakthivel",
                LastName = "Rajasekaran",
                DateOfBirth = "20/12/1989"

            };


        }

        public MyHealthDataDto GetMyHealthDataByDate(DateTime heartDataDate)
        {
            var myAllHeartData = GetAllMyHealthData();
            var responseDto = new MyHealthDataDto();

            if (heartDataDate != null && myAllHeartData != null)
            {
                responseDto.myHeartDataDto = myAllHeartData.myHeartDataDto.Where(d => d.MyHeartBeatDate.Date.Equals(heartDataDate.Date));
            }   

            return responseDto;


        }
    }
}
