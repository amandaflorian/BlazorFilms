using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFilmes.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorFilmes.Server;

namespace BlazorFilmes.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : Controller
    {
        
        
        //metodo para adicionar um usuario (post)


        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody]Registro registro);
    }

    {
        //adicionar novo usuario a lista
        return null;
    }
}