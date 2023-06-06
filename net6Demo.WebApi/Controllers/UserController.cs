using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace net6Demo.WebApi.Controllers
{
    /// <summary>
    /// 用户资源
    /// </summary>
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logget;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="logget"></param>
        public UserController(ILogger<UserController> logget)
        {
            _logget = logget;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name ="User")]
        public User GetUser() 
        {
            return new()
            {
                Id = 123,
                Name = "Richard",
                Age = 28
            };
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost(Name = "User")]
        public int AddUser(User user) 
        {
            return 1;
        }


        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut (Name = "User")]
        public int UpdateUser(User user) 
        {
            return 1;
        }


        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete(Name = "User")]
        public int DeleteUser(int id) 
        {
            return 1;
        }
    }
}
