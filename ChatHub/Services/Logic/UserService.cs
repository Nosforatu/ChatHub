using ChatHub.Models;
using ChatHub.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChatHub.Services.Logic
{
    public class UserService : IUserService
    {
        private HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetOrCreateUser(LoginModel loginModel)
        {
            if (loginModel == null)
                return null;

            var loginString = JsonConvert.SerializeObject(loginModel);
            var contentData = new StringContent(loginString, Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync("https://localhost:44311/api/users", contentData);
            if(result.StatusCode == System.Net.HttpStatusCode.Created || result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return loginModel.UserName;
            }
            

            return null;
            
        }
    }
}
