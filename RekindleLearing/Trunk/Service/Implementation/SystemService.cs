using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Service;

namespace RekindleLearing.Implementation.Service
{
    public class SystemService<T> : BaseService<T>, ISystemService<T>
    {
        public SystemService(Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task<T>> networkInterface)
            :base(networkInterface)
        {
            //#Bonsai Snippets - MethodDefinitions
        }
    }
}