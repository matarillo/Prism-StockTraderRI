// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

// using Prism.Modularity;
// using Prism.MefExtensions.Modularity;

namespace StockTraderRI.Modules.Market
{
    /// <summary>
    /// A placeholder to initialize this module.
    /// </summary>
    /// <remarks>
    /// This module is intentionally left empty because views, services, and other types are discovered through declarative attributes.
    /// View registration for this module is done through the <see cref="StockTraderRI.Infrastructure.ViewExportAttribute"/>.
    /// If you extend this reference implementation and need to initialization when this module is loaded, 
    /// uncomment the module export attribute, IModule interface, Initialize method.
    /// </remarks>
    //[ModuleExport(typeof(MarketModule)]
    public class MarketModule //: IModule
    {
        // public void Initialize() { }
    }
}
