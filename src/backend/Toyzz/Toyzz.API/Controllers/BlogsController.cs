using Microsoft.AspNetCore.Mvc;
using Toyzz.Domain.SeedWork;

namespace Toyzz.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    private readonly IUnitOfWork _uow;

    public BlogsController(IUnitOfWork uow)
    {
        _uow = uow;
    }

    /// <summary>
    ///     获取所有博客
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _uow.Blogs.GetAll());
    }

    /// <summary>
    ///     根据id获取博客
    /// </summary>
    /// <param name="id">博客id</param>
    /// <returns></returns>
    [HttpGet("id")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _uow.Blogs.GetBlog(id));
    }

    /// <summary>
    ///     新增博客
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpPost]
    public IActionResult Post()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     修改博客
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpPut]
    public IActionResult Put()
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        throw new NotImplementedException();
    }
}