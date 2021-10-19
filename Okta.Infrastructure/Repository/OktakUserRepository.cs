using Newtonsoft.Json;
using Okta.Core.Entity;
using Okta.Core.IRepository;
using Okta.Infrastructure.CommonMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okta.Infrastructure.Repository
{
    public class OktakUserRepository : IOktakUserRepository
    {
        public async Task<UserInfoWithStatus> UserInfo(string url)
        {
            var Response = await Task.Run(() => new CallRestAPI().CallGetAPI(url));
            UserInfoWithStatus rootList = new UserInfoWithStatus();
            if (!Response.Contains("error"))
            {
                rootList.UserData = JsonConvert.DeserializeObject<UserInfo>(Response);
                rootList.Status = "User Exist.";
            }
            else
                rootList.Status = Response;
            return rootList;
        }

        public async Task<UserInfoList> UserList(string url)
        {
            var Response = await Task.Run(()=> new CallRestAPI().CallGetAPI(url));
            UserInfoList rootList = new UserInfoList();
            if (!Response.Contains("error"))
            {
                rootList.UserList = JsonConvert.DeserializeObject<List<UserInfo>>(Response);
                rootList.Status = "Success.";
            }
            else
                rootList.Status = Response;
            return rootList;
        }
    }
}
