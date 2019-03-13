using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Services.Interfaces
{
    public interface ILoginService
    {
        bool Login(string userName, string password);
    }
}
