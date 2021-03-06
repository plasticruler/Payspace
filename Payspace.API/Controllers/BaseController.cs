﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Payspace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController:Controller
    {
        protected ClaimsPrincipal CurrentUser => HttpContext.User;
        protected long? UserId
        {
            get
            {
                if (CurrentUser == null)
                    return null;
                return long.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            }
        }
    }
}
