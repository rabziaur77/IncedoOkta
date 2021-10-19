using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Okta.Core.Entity;
using Okta.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Okta.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IOktakUserRepository iOktakUserRepository;
        private readonly IConfiguration configuration;
        public UsersController(IOktakUserRepository _iOktakUserRepository, IConfiguration _configuration)
        {
            iOktakUserRepository = _iOktakUserRepository;
            configuration = _configuration;
        }
        [HttpGet]
        public async Task<ActionResult<UserInfoList>> Listofusers(int? limit)
        {
            string url = configuration.GetSection("OktaDomain").Value + "/api/v1/users";
            if (limit!=null)
                url = url+ "?limit=" + limit;
            var data = await iOktakUserRepository.UserList(url);
            return Ok(data);
        }
        [HttpGet]
        public async Task<ActionResult<UserInfoList>> ListofusersTillUpdateOrCreate(DateTime tillDate)
        {
            string date = tillDate.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.000Z");
            string url = configuration.GetSection("OktaDomain").Value + string.Concat("/api/v1/users?search=lastUpdated le ", "\""+date+"\"", " or created le ", "\"" + date + "\"");
            var data = await iOktakUserRepository.UserList(url);
            return Ok(data);
        }
        [Route("{UserID}")]
        [HttpGet]
        public async Task<ActionResult<UserInfoWithStatus>> Users(string UserID)
        {
            string url = configuration.GetSection("OktaDomain").Value + string.Concat("/api/v1/users/"+UserID);
            var data = await iOktakUserRepository.UserInfo(url);
            return Ok(data);
        }
    }
}
