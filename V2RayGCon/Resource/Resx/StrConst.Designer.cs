﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace V2RayGCon.Resource.Resx {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StrConst {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StrConst() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("V2RayGCon.Resource.Resx.StrConst", typeof(StrConst).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 bug.txt 的本地化字符串。
        /// </summary>
        internal static string BugFileName {
            get {
                return ResourceManager.GetString("BugFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;reverseDefault&quot;: {
        ///    &quot;bridges&quot;: [
        ///      {
        ///        &quot;tag&quot;: &quot;bridge&quot;,
        ///        &quot;domain&quot;: &quot;test.v2ray.com&quot;
        ///      }
        ///    ],
        ///    &quot;portals&quot;: [
        ///      {
        ///        &quot;tag&quot;: &quot;portal&quot;,
        ///        &quot;domain&quot;: &quot;test.v2ray.com&quot;
        ///      }
        ///    ]
        ///  },
        ///  &quot;inTpl&quot;: {
        ///    &quot;port&quot;: 1080,
        ///    &quot;listen&quot;: &quot;127.0.0.1&quot;,
        ///    &quot;protocol&quot;: &quot;协议名称&quot;,
        ///    &quot;settings&quot;: {},
        ///    &quot;streamSettings&quot;: {},
        ///    &quot;tag&quot;: &quot;标识&quot;,
        ///    &quot;sniffing&quot;: {
        ///      &quot;enabled&quot;: false,
        ///      &quot;destOverride&quot;: [
        ///        &quot;http&quot;,
        ///        &quot;tls&quot;
        ///      ]
        ///    }
        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string config_example {
            get {
                return ResourceManager.GetString("config_example", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;log&quot;: {
        ///    &quot;loglevel&quot;: &quot;warning&quot;
        ///  },
        ///  &quot;inbound&quot;: {
        ///    &quot;port&quot;: 1080,
        ///    &quot;listen&quot;: &quot;127.0.0.1&quot;,
        ///    &quot;protocol&quot;: &quot;socks&quot;,
        ///    &quot;settings&quot;: {
        ///      &quot;auth&quot;: &quot;noauth&quot;,
        ///      &quot;udp&quot;: false,
        ///      &quot;ip&quot;: &quot;127.0.0.1&quot;
        ///    }
        ///  },
        ///  &quot;outbound&quot;: {
        ///    &quot;protocol&quot;: &quot;freedom&quot;,
        ///    &quot;settings&quot;: {},
        ///    &quot;tag&quot;: &quot;direct&quot;
        ///  },
        ///  &quot;policy&quot;: {
        ///    &quot;levels&quot;: {
        ///      &quot;0&quot;: {&quot;uplinkOnly&quot;: 0}
        ///    }
        ///  }
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string config_min {
            get {
                return ResourceManager.GetString("config_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;pkgV4Tpl&quot;: {
        ///    &quot;log&quot;: {
        ///      &quot;loglevel&quot;: &quot;warning&quot;
        ///    },
        ///    &quot;v2raygcon&quot;: {
        ///      &quot;alias&quot;: &quot;PackageV4&quot;,
        ///      &quot;description&quot;: &quot;&quot;
        ///    },
        ///    &quot;routing&quot;: {
        ///      &quot;balancers&quot;: [
        ///        {
        ///          &quot;tag&quot;: &quot;balancer&quot;,
        ///          &quot;selector&quot;: [
        ///            &quot;agentout&quot;
        ///          ]
        ///        }
        ///      ],
        ///      &quot;rules&quot;: [
        ///        {
        ///          &quot;type&quot;: &quot;field&quot;,
        ///          &quot;inboundTag&quot;: [
        ///            &quot;agentin&quot;
        ///          ],
        ///          &quot;balancerTag&quot;: &quot;balancer&quot;
        ///        }
        ///      ]
        ///    },
        ///    &quot;inbo [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string config_pkg {
            get {
                return ResourceManager.GetString("config_pkg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {
        ///  &quot;inbSimSock&quot;: {
        ///    &quot;tag&quot;: &quot;agentin&quot;,
        ///    &quot;port&quot;: 1080,
        ///    &quot;listen&quot;: &quot;127.0.0.1&quot;,
        ///    &quot;protocol&quot;: &quot;socks&quot;,
        ///    &quot;settings&quot;: {}
        ///  },
        ///  &quot;outbVmess&quot;: {
        ///    &quot;protocol&quot;: &quot;vmess&quot;,
        ///    &quot;settings&quot;: {
        ///      &quot;vnext&quot;: [
        ///        {
        ///          &quot;address&quot;: &quot;&quot;,
        ///          &quot;port&quot;: 1234,
        ///          &quot;users&quot;: [
        ///            {
        ///              &quot;id&quot;: &quot;&quot;,
        ///              &quot;alterId&quot;: 32,
        ///              &quot;security&quot;: &quot;auto&quot;
        ///            }
        ///          ]
        ///        }
        ///      ]
        ///    },
        ///    &quot;tag&quot;: &quot;agentout&quot;,
        ///    &quot;streamSettings [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string config_tpl {
            get {
                return ResourceManager.GetString("config_tpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 10 的本地化字符串。
        /// </summary>
        internal static string DecodeCacheSize {
            get {
                return ResourceManager.GetString("DecodeCacheSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v3.26 的本地化字符串。
        /// </summary>
        internal static string DefCoreVersion {
            get {
                return ResourceManager.GetString("DefCoreVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases/download/{0}/{1} 的本地化字符串。
        /// </summary>
        internal static string DownloadLinkTpl {
            get {
                return ResourceManager.GetString("DownloadLinkTpl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 vmess://ew0KICAicHMiOiAiZHVtbXkxIiwNCiAgImFkZCI6ICIxLjIuMy40IiwNCiAgInBvcnQiOiAiNDQzIiwNCiAgImlkIjogImI4NzNkNWY0LTMyNjEtNGYxOS04MGE3LWYwZTY3YzkwYzA4MiIsDQogICJhaWQiOiAiMTAwIiwNCiAgIm5ldCI6ICJ3cyIsDQogICJ0eXBlIjogIm5vbmUiLA0KICAiaG9zdCI6ICIvcmF5IiwNCiAgInRscyI6ICJ0bHMiDQp9 的本地化字符串。
        /// </summary>
        internal static string DummyServ1 {
            get {
                return ResourceManager.GetString("DummyServ1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 vmess://ew0KICAicHMiOiAiZHVtbXkyIiwNCiAgImFkZCI6ICIyLjMuNC41IiwNCiAgInBvcnQiOiAiMTIzNCIsDQogICJpZCI6ICI1NjIxODM4ZS1hYmM1LTRiNmQtOWQzMS00MmUwOGE3ZWMzMmYiLA0KICAiYWlkIjogIjY0IiwNCiAgIm5ldCI6ICJ0Y3AiLA0KICAidHlwZSI6ICJub25lIiwNCiAgImhvc3QiOiAiIiwNCiAgInRscyI6ICIiDQp9 的本地化字符串。
        /// </summary>
        internal static string DummyServ2 {
            get {
                return ResourceManager.GetString("DummyServ2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray.exe 的本地化字符串。
        /// </summary>
        internal static string Executable {
            get {
                return ResourceManager.GetString("Executable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 JS Files|*.js|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtJs {
            get {
                return ResourceManager.GetString("ExtJs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Json File|*.json|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtJson {
            get {
                return ResourceManager.GetString("ExtJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 PNG Files|*.png|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtPng {
            get {
                return ResourceManager.GetString("ExtPng", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Text File|*.txt|All File|*.* 的本地化字符串。
        /// </summary>
        internal static string ExtText {
            get {
                return ResourceManager.GetString("ExtText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases/latest 的本地化字符串。
        /// </summary>
        internal static string LatestCoreLink {
            get {
                return ResourceManager.GetString("LatestCoreLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 180 的本地化字符串。
        /// </summary>
        internal static string LazyGCDelay {
            get {
                return ResourceManager.GetString("LazyGCDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 30 的本地化字符串。
        /// </summary>
        internal static string LazySaveServerListDelay {
            get {
                return ResourceManager.GetString("LazySaveServerListDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 30 的本地化字符串。
        /// </summary>
        internal static string LazySaveUserSettingsDelay {
            get {
                return ResourceManager.GetString("LazySaveUserSettingsDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 vgclog.txt 的本地化字符串。
        /// </summary>
        internal static string LogFileName {
            get {
                return ResourceManager.GetString("LogFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://www.youtube.com/watch?v=BA7fdSkp8ds 的本地化字符串。
        /// </summary>
        internal static string Nobody3uVideoUrl {
            get {
                return ResourceManager.GetString("Nobody3uVideoUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 10800 的本地化字符串。
        /// </summary>
        internal static string PacmanInitPort {
            get {
                return ResourceManager.GetString("PacmanInitPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tag 的本地化字符串。
        /// </summary>
        internal static string PacmanTagPrefix {
            get {
                return ResourceManager.GetString("PacmanTagPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 5 的本地化字符串。
        /// </summary>
        internal static string ParseImportDepth {
            get {
                return ResourceManager.GetString("ParseImportDepth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 3 的本地化字符串。
        /// </summary>
        internal static string ParseImportRetry {
            get {
                return ResourceManager.GetString("ParseImportRetry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 12 的本地化字符串。
        /// </summary>
        internal static string ParseImportTimeOut {
            get {
                return ResourceManager.GetString("ParseImportTimeOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 (?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4}) 的本地化字符串。
        /// </summary>
        internal static string PatternBase64 {
            get {
                return ResourceManager.GetString("PatternBase64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [A-Za-z0-9+/]+ 的本地化字符串。
        /// </summary>
        internal static string PatternBase64NonStandard {
            get {
                return ResourceManager.GetString("PatternBase64NonStandard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /v2ray/v2ray-core/releases/download/(v[\.0-9]+)/v2ray-windows-64.zip 的本地化字符串。
        /// </summary>
        internal static string PatternDownloadLink {
            get {
                return ResourceManager.GetString("PatternDownloadLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /nobody3u/V2RayGCon/releases/tag/([\.0-9]+) 的本地化字符串。
        /// </summary>
        internal static string PatternLatestVGC {
            get {
                return ResourceManager.GetString("PatternLatestVGC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [^0-9a-zA-Z] 的本地化字符串。
        /// </summary>
        internal static string PatternNonAlphabet {
            get {
                return ResourceManager.GetString("PatternNonAlphabet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray-windows-32.zip 的本地化字符串。
        /// </summary>
        internal static string PkgWin32 {
            get {
                return ResourceManager.GetString("PkgWin32", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v2ray-windows-64.zip 的本地化字符串。
        /// </summary>
        internal static string PkgWin64 {
            get {
                return ResourceManager.GetString("PkgWin64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/v2ray/v2ray-core/releases 的本地化字符串。
        /// </summary>
        internal static string ReleasePageUrl {
            get {
                return ResourceManager.GetString("ReleasePageUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 20 的本地化字符串。
        /// </summary>
        internal static string SpeedTestTimeout {
            get {
                return ResourceManager.GetString("SpeedTestTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://www.google.com 的本地化字符串。
        /// </summary>
        internal static string SpeedTestUrl {
            get {
                return ResourceManager.GetString("SpeedTestUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/nobody3u/V2RayGCon/releases/tag/{0} 的本地化字符串。
        /// </summary>
        internal static string TplUrlVGCRelease {
            get {
                return ResourceManager.GetString("TplUrlVGCRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/nobody3u/V2RayGCon/releases/latest 的本地化字符串。
        /// </summary>
        internal static string UrlLatestVGC {
            get {
                return ResourceManager.GetString("UrlLatestVGC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 core 的本地化字符串。
        /// </summary>
        internal static string V2RayCoreFolder {
            get {
                return ResourceManager.GetString("V2RayCoreFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 v3.48,v3.47,v3.46 的本地化字符串。
        /// </summary>
        internal static string VerList {
            get {
                return ResourceManager.GetString("VerList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 https://github.com/nobody3u/V2RayGCon/wiki/vlink 的本地化字符串。
        /// </summary>
        internal static string VlinkWiki {
            get {
                return ResourceManager.GetString("VlinkWiki", resourceCulture);
            }
        }
    }
}
