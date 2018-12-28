using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace AliPay
{
    // @interface APayAuthInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface APayAuthInfo
    {
        // @property (copy, nonatomic) NSString * appID;
        [Export("appID")]
        string AppID { get; set; }

        // @property (copy, nonatomic) NSString * pid;
        [Export("pid")]
        string Pid { get; set; }

        // @property (copy, nonatomic) NSString * redirectUri;
        [Export("redirectUri")]
        string RedirectUri { get; set; }

        // -(id)initWithAppID:(NSString *)appIDStr pid:(NSString *)pidStr redirectUri:(NSString *)uriStr;
        [Export("initWithAppID:pid:redirectUri:")]
        IntPtr Constructor(string appIDStr, string pidStr, string uriStr);

        // -(NSString *)description;
        [Export("description")]
        string Description { get; }

        // -(NSString *)wapDescription;
        [Export("wapDescription")]
        string WapDescription { get; }
    }

    // typedef void (^CompletionBlock)(NSDictionary *);
    delegate void CompletionBlock(NSDictionary arg0);

    // @interface AlipaySDK : NSObject
    [BaseType(typeof(NSObject))]
    interface AlipaySDK
    {
        // +(AlipaySDK *)defaultService;
        [Static]
        [Export("defaultService")]
        AlipaySDK DefaultService { get; }

        // @property (nonatomic, weak) UIWindow * targetWindow;
        [Export("targetWindow", ArgumentSemantic.Weak)]
        UIWindow TargetWindow { get; set; }

        // -(void)payOrder:(NSString *)orderStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export("payOrder:fromScheme:callback:")]
        void PayOrder(string orderStr, string schemeStr, CompletionBlock completionBlock);

        // -(void)payOrder:(NSString *)orderStr dynamicLaunch:(BOOL)dynamicLaunch fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export("payOrder:dynamicLaunch:fromScheme:callback:")]
        void PayOrder(string orderStr, bool dynamicLaunch, string schemeStr, CompletionBlock completionBlock);

        // -(void)processOrderWithPaymentResult:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export("processOrderWithPaymentResult:standbyCallback:")]
        void ProcessOrderWithPaymentResult(NSUrl resultUrl, CompletionBlock completionBlock);

        // -(NSString *)fetchTradeToken;
        [Export("fetchTradeToken")]
        string FetchTradeToken { get; }

        // -(void)auth_V2WithInfo:(NSString *)infoStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export("auth_V2WithInfo:fromScheme:callback:")]
        void Auth_V2WithInfo(string infoStr, string schemeStr, CompletionBlock completionBlock);

        // -(void)processAuth_V2Result:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export("processAuth_V2Result:standbyCallback:")]
        void ProcessAuth_V2Result(NSUrl resultUrl, CompletionBlock completionBlock);

        // -(void)authWithInfo:(APayAuthInfo *)authInfo callback:(CompletionBlock)completionBlock;
        [Export("authWithInfo:callback:")]
        void AuthWithInfo(APayAuthInfo authInfo, CompletionBlock completionBlock);

        // -(void)processAuthResult:(NSURL *)resultUrl standbyCallback:(CompletionBlock)completionBlock;
        [Export("processAuthResult:standbyCallback:")]
        void ProcessAuthResult(NSUrl resultUrl, CompletionBlock completionBlock);

        // -(BOOL)payInterceptorWithUrl:(NSString *)urlStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export("payInterceptorWithUrl:fromScheme:callback:")]
        bool PayInterceptorWithUrl(string urlStr, string schemeStr, CompletionBlock completionBlock);

        // -(NSString *)fetchOrderInfoFromH5PayUrl:(NSString *)urlStr;
        [Export("fetchOrderInfoFromH5PayUrl:")]
        string FetchOrderInfoFromH5PayUrl(string urlStr);

        // -(void)payUrlOrder:(NSString *)orderStr fromScheme:(NSString *)schemeStr callback:(CompletionBlock)completionBlock;
        [Export("payUrlOrder:fromScheme:callback:")]
        void PayUrlOrder(string orderStr, string schemeStr, CompletionBlock completionBlock);

        // -(NSString *)queryTidFactor:(AlipayTidFactor)factor;
        [Export("queryTidFactor:")]
        string QueryTidFactor(AlipayTidFactor factor);

        // -(BOOL)isLogined;
        [Export("isLogined")]
        bool IsLogined { get; }

        // -(NSString *)currentVersion;
        [Export("currentVersion")]
        string CurrentVersion { get; }

        // -(void)setUrl:(NSString *)url;
        [Export("setUrl:")]
        void SetUrl(string url);

        // -(void)fetchSdkConfigWithBlock:(void (^)(BOOL))block;
        [Export("fetchSdkConfigWithBlock:")]
        void FetchSdkConfigWithBlock(Action<bool> block);
    }
}
