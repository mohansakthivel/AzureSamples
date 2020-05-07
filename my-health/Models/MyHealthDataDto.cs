using System;
using System.Collections.Generic;

namespace my_health.Models
{
    public class MyHealthDataDto : MyBasicDetailsDto
    {

        public IEnumerable<MyHeartDataDto> myHeartDataDto { get; set; }
        
    }
}
