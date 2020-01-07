using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Service;

namespace RekindleLearing.Implementation.Service
{
    public class CourseListService<T> : BaseService<T>, ICourseListService<T>
    {
        public CourseListService(Func<string, Dictionary<string, ParameterTypedValue>, BaseNetworkAccessEnum, Task<T>> networkInterface)
            :base(networkInterface)
        {
           
            //#Bonsai Snippets - MethodDefinitions
        }

        public async Task<T> GetCourseList()
        {
            string requestURL = "/courses";
            var httpMethod = BaseNetworkAccessEnum.Get;
            var parameters = new Dictionary<string, ParameterTypedValue>()
            {

            };

            return await _NetworkInterfaceWithOutput(requestURL, parameters, httpMethod);
        }
    }
}