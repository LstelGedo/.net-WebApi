using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace net6Demo.WebApi.Controllers
{
    /// <summary>
    /// 公司资源
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="logger"></param>
        public CompanyController(ILogger<CompanyController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 获取公司信息
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "Company")]
        private Company GetUser() 
        {
            return new()
            {
                Id = 123,
                Name = "Richard",
                AddRess = "广东广州"
            };
        }

        /// <summary>
        /// 新增公司信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost(Name ="Company")]
        private int AddCompany(Company user) 
        {
            return 1;
        }


        /// <summary>
        /// 修改公司信息
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPut(Name = "Company")]
        public int UpdateCompany(Company company) 
        {
            return 1;
        }


        /// <summary>
        /// 删除公司信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete(Name = "Company")]
        public int DeleteCompany(int id) 
        {
            return 1;
        }
    }
}
