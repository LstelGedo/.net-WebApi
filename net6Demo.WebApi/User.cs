namespace net6Demo.WebApi
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 用户名称
        /// </summary>
        public string? Name { get; set; }


        /// <summary>
        /// 用户年龄 
        /// </summary>
        public int? Age { get; set; }
    }
}
