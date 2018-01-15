﻿using    MicroNet.WinformMVC.Filters.Contexts;

namespace    MicroNet.WinformMVC.Filters
{
    /// <summary>
    /// Exception filter interface
    /// </summary>
    public interface IExceptionFilter
    {
        /// <summary>
        /// The method is executed after all other filters. It handle exceptions
        /// </summary>
        /// <param name="filterContext">The context of execution</param>
        void OnException(ExceptionContext filterContext);
    }
}
