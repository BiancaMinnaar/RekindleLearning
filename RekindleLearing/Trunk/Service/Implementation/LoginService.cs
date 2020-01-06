using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Service;

namespace RekindleLearing.Implementation.Service
{
    public class LoginService<T> : BaseService<T>, ILoginService<T>
    {
        public LoginService(Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task<T>> networkInterface)
            :base(networkInterface)
        {
            //#Bonsai Snippets - MethodDefinitions
        }
    }
}