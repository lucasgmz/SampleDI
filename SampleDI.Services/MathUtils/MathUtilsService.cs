using SampleDI.Domain.MathUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDI.Services.MathUtils
{
    public class MathUtilsService : IMathUtilsService
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
