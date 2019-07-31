using Sitecore.Mvc.Pipelines.MvcEvents.ActionExecuted;

namespace Sitecore.Support.Mvc.Pipelines.MvcEvents.ActionExecuted
{
    public class CacheControl : Sitecore.Mvc.Pipelines.MvcEvents.ActionExecuted.CacheControl
    {
        protected override void RunCacheControl(ActionExecutedArgs args)
        {
            if (Context.HttpContext.Response.IsRequestBeingRedirected)
            {
                return;
            }

            if (base.IsDisableBrowserCaching(args))
            {
                base.SetNoCacheNoStore(args);
            }
        }
    }
}