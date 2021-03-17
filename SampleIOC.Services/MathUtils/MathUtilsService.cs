using SampleIOC.Domain.MathUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleIOC.Services.MathUtils
{
    public class MathUtilsService : IMathUtilsService
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
