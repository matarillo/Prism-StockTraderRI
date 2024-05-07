// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Prism.Regions;

namespace StockTraderRI.Modules.Position.Tests.Mocks
{
    public class MockRegionManager : IRegionManager
    {
        private MockRegionCollection _regions = new MockRegionCollection();

        public IRegionCollection Regions
        {
            get { return _regions; }
        }

        public IRegionManager AddToRegion(string regionName, object view)
        {
            throw new NotImplementedException();
        }

        public IRegion AttachNewRegion(object regionTarget, string regionName)
        {
            throw new NotImplementedException();
        }

        public IRegionManager CreateRegionManager()
        {
            throw new NotImplementedException();
        }

        public bool Navigate(Uri source)
        {
            throw new NotImplementedException();
        }

        public IRegionManager RegisterViewWithRegion(string regionName, Type viewType)
        {
            throw new NotImplementedException();
        }

        public IRegionManager RegisterViewWithRegion(string regionName, Func<object> getContentDelegate)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, Uri source, Action<NavigationResult> navigationCallback)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, Uri source)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, string source, Action<NavigationResult> navigationCallback)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, string source)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, Uri target, Action<NavigationResult> navigationCallback, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, string target, Action<NavigationResult> navigationCallback, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, Uri target, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(string regionName, string target, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }
    }

    internal class MockRegionCollection : IRegionCollection
    {
        private Dictionary<string, IRegion> regions = new Dictionary<string, IRegion>();

        public IEnumerator<IRegion> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IRegion this[string regionName]
        {
            get { return regions[regionName]; }
        }

        public void Add(IRegion region)
        {
            regions[region.Name] = region;
        }

        public bool Remove(string regionName)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsRegionWithName(string regionName)
        {
            throw new System.NotImplementedException();
        }

        public void Add(string regionName, IRegion region)
        {
            throw new NotImplementedException();
        }

        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
    }

    public class MockRegion : IRegion
    {
        public List<object> AddedViews = new List<object>();

        public string Name { get; set; }

        public IRegionManager Add(object view)
        {
            AddedViews.Add(view);
            return null;
        }

        public void Remove(object view)
        {
            AddedViews.Remove(view);
        }

        public IViewsCollection Views
        {
            get { return new MockViewsCollection(AddedViews); }
        }

        public void Activate(object view)
        {
            SelectedItem = view;
        }

        public void Deactivate(object view)
        {
            throw new NotImplementedException();
        }

        public IRegionManager Add(object view, string viewName)
        {
            Add(view);
            return null;
        }

        public object GetView(string viewName)
        {
            return AddedViews.Count > 0 ? AddedViews[0] : null;
        }

        public IRegionManager Add(object view, string viewName, bool createRegionManagerScope)
        {
            throw new NotImplementedException();
        }

        public IRegionManager RegionManager
        {
            get { throw new NotImplementedException(); }         
            set { throw new NotImplementedException(); }
        }

        public IRegionBehaviorCollection Behaviors
        {
            get { throw new System.NotImplementedException(); }
        }

        public object SelectedItem { get; set; }

        public IViewsCollection ActiveViews
        {
            get { throw new NotImplementedException(); }
        }

        public object Context
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public NavigationParameters NavigationParameters
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RequestNavigate(Uri source, Action<NavigationResult> navigationCallback)
        {
            throw new NotImplementedException();
        }

        public void RequestNavigate(Uri source, Action<NavigationResult> navigationCallback, NavigationParameters navigationParameters)
        {
            throw new NotImplementedException();
        }

        public IRegionNavigationService NavigationService
        {
            get { throw new NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }


        public Comparison<object> SortComparison
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void MoveFrom(IRegion sourceRegion, object view)
        {
            throw new System.NotImplementedException();
        }

        public void MoveFrom(IRegion sourceRegion, object view, string viewName)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new NotImplementedException();
        }
    }

    internal class MockViewsCollection : IViewsCollection
    {
        private readonly IList<object> views;

        public MockViewsCollection(IList<object> views)
        {
            this.views = views;
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<object> GetEnumerator()
        {
            return views.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
