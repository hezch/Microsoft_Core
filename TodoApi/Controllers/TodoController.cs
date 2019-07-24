using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;
        public TodoController(TodoContext _context)
        {

        }
    }
    /*
     定义了没有方法的 API 控制器类。
使用 [ApiController] 属性修饰类。 此属性指示控制器响应 Web API 请求。 有关该属性启用的特定行为的信息，请参阅 使用 ASP.NET Core 创建 Web API。
使用 DI 将数据库上下文 (TodoContext) 注入到控制器中。 数据库上下文将在控制器中的每个 CRUD 方法中使用。
如果数据库为空，则将名为 Item1 的项添加到数据库。 此代码位于构造函数中，因此在每次出现新 HTTP 请求时运行。 如果删除所有项，则构造函数会在下次调用 API 方法时再次创建 Item1。 因此删除可能看上去不起作用，不过实际上确实有效。    
     */
}
