using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Services.Interfaces
{
    public interface ILoginService
    {
        bool login(string userName, string password);
    }
}
