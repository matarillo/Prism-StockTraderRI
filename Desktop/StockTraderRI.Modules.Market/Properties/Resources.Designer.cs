﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTraderRI.Modules.Market.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StockTraderRI.Modules.Market.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;MarketItems xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; RefreshRate=&quot;5&quot;&gt;
        ///  &lt;MarketItem TickerSymbol=&quot;STOCK0&quot; LastPrice=&quot;37.00&quot; Volume=&quot;1000&quot;&gt;&lt;/MarketItem&gt;
        ///  &lt;MarketItem TickerSymbol=&quot;STOCK1&quot; LastPrice=&quot;78.13&quot; Volume=&quot;100&quot;&gt;&lt;/MarketItem&gt;
        ///  &lt;MarketItem TickerSymbol=&quot;STOCK2&quot; LastPrice=&quot;23.80&quot; Volume=&quot;200&quot;&gt;&lt;/MarketItem&gt;
        ///  &lt;MarketItem TickerSymbol=&quot;STOCK3&quot; LastPrice=&quot;34.22&quot; Volume=&quot;300&quot;&gt;&lt;/MarketItem&gt;
        ///  &lt;MarketItem Ticke [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Market {
            get {
                return ResourceManager.GetString("Market", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Symbol does not exist in market feed. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MarketFeedTickerSymbolNotFoundException {
            get {
                return ResourceManager.GetString("MarketFeedTickerSymbolNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;MarketHistoryItems xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;MarketHistoryItem TickerSymbol=&quot;STOCK0&quot; Date=&quot;2008-02-23&quot;&gt;30.00&lt;/MarketHistoryItem&gt;
        ///  &lt;MarketHistoryItem TickerSymbol=&quot;STOCK0&quot; Date=&quot;2008-02-24&quot;&gt;35.00&lt;/MarketHistoryItem&gt;
        ///  &lt;MarketHistoryItem TickerSymbol=&quot;STOCK0&quot; Date=&quot;2008-02-25&quot;&gt;50.00&lt;/MarketHistoryItem&gt;
        ///  &lt;MarketHistoryItem TickerSymbol=&quot;STOCK0&quot; Date=&quot;2008-02-26&quot;&gt;75.00&lt;/MarketHistoryItem&gt;
        ///  &lt;Ma [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MarketHistory {
            get {
                return ResourceManager.GetString("MarketHistory", resourceCulture);
            }
        }
    }
}
