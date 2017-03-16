namespace WebApplication2.Controllers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Boilerplate.Web.Mvc;
    using Boilerplate.Web.Mvc.Filters;
    using WebApplication2.Constants;
    using WebApplication2.Services;



    public class BlogController : Controller
    {
        #region Fields

        private readonly IBrowserConfigService browserConfigService;
        private readonly IFeedService feedService;
        private readonly IManifestService manifestService;
        private readonly IOpenSearchService openSearchService;
        private readonly IRobotsService robotsService;
        private readonly ISitemapService sitemapService;

        #endregion

        #region Constructors

        public BlogController(
            IBrowserConfigService browserConfigService,
            IFeedService feedService,
            IManifestService manifestService,
            IOpenSearchService openSearchService,
            IRobotsService robotsService,
            ISitemapService sitemapService)
        {
            this.browserConfigService = browserConfigService;
            this.feedService = feedService;
            this.manifestService = manifestService;
            this.openSearchService = openSearchService;
            this.robotsService = robotsService;
            this.sitemapService = sitemapService;
        }

        #endregion

        public ActionResult Index()
        {
            return View();
        }
	}
}