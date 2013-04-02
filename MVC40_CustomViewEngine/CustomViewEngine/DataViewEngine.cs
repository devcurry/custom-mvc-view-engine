using System;
using System.Web.Mvc;

namespace MVC40_CustomViewEngine.CustomViewEngine
{
    /// <summary>
    /// The class Implementing 'IViewEngine' interface. This Interface  methods for ViewEngine
    /// </summary>
    public class DataViewEngine : IViewEngine
    {
        /// <summary>
        /// Method for Partial Viuew
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="partialViewName"></param>
        /// <param name="useCache"></param>
        /// <returns></returns>
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method for View
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="viewName"></param>
        /// <param name="masterName"></param>
        /// <param name="useCache"></param>
        /// <returns></returns>
        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "DataView")
            {
                return new ViewEngineResult(new DataView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] {"This View Engine is Currently in design, will be launched soon"});
            }
        }

 
        /// <summary>
        /// Release the view
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="view"></param>
        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            
        }
    }
}