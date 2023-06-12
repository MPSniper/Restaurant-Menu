using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public enum ErrorCode_Enum
    {
        ErrorInDB = -1,
        Register_successfully = 1,
        Nationalcode_Correct = 0,
        ThereIsNull = -2,
        AllFieldsComplete = 2,
    }
}
