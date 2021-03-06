using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult //mesaj ve successi tekrar yazmaya gerek yok
    {                                   //interface interface i implemente ederse altta çıkmaz
        T Data { get; }
    }
}
