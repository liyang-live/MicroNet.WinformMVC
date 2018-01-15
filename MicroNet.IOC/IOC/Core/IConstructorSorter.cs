﻿
using System.Reflection;
using System.Collections.Generic;

namespace     MicroNet.IOC.Core
{
    /// <summary>
    /// Sort the constructors.
    /// </summary>
    public interface IConstructorSorter
    {
        /// <summary>
        /// Sorts the constructors.
        /// </summary>
        /// <param name="constructors">The constructors.</param>
        /// <returns></returns>
        List<ConstructorInfo> SortConstructors(List<ConstructorInfo> constructors);
    }
}
