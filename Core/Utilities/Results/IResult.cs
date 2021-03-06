using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    // İşlem sonucu ve kullanıcı bilgilendirme mesajı
    public interface IResult
    {
        bool Success { get; } //get sadece okunabilir
        string Message { get; }

    }
}
