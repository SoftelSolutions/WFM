using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WFM.WebAPI.Claims
{
    public class ClaimActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var claims = context.HttpContext.User.Claims;
            if(claims.Any())
            {
                var userId = claims.Where(x => x.Type == ClaimTypes.NameIdentifier).SingleOrDefault().Value;

                context.HttpContext.Items["userId"] = userId;

                base.OnActionExecuting(context);
            }

            
        }

    }
}
