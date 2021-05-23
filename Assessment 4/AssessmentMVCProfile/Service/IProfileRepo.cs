using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentMVCProfile.Service
{
    public interface IProfileRepo<T>
    {
        bool Register(T t);
    }
}
