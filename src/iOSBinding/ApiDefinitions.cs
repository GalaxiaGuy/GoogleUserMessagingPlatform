using Foundation;
using ObjCRuntime;
using UIKit;

namespace GoogleUserMessagingPlatform
{
    // @interface UMPDebugSettings : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface UMPDebugSettings : INSCopying
    {
        // @property (nonatomic) NSArray<NSString *> * _Nullable testDeviceIdentifiers;
        [NullAllowed, Export("testDeviceIdentifiers", ArgumentSemantic.Assign)]
        string[] TestDeviceIdentifiers { get; set; }

        // @property (nonatomic) UMPDebugGeography geography;
        [Export("geography", ArgumentSemantic.Assign)]
        UMPDebugGeography Geography { get; set; }
    }

    // @interface UMPRequestParameters : NSObject
    [BaseType(typeof(NSObject))]
    interface UMPRequestParameters
    {
        // @property (nonatomic) BOOL tagForUnderAgeOfConsent;
        [Export("tagForUnderAgeOfConsent")]
        bool TagForUnderAgeOfConsent { get; set; }

        // @property (copy, nonatomic) UMPDebugSettings * _Nullable debugSettings;
        [NullAllowed, Export("debugSettings", ArgumentSemantic.Copy)]
        UMPDebugSettings DebugSettings { get; set; }
    }

    [Static]
    public interface Constants
    {
        // extern NSString *const _Nonnull UMPVersionString;
        [Field("UMPVersionString", "__Internal")]
        public NSString UMPVersionString { get; }

        // extern NSErrorDomain  _Nonnull const UMPErrorDomain;
        [Field("UMPErrorDomain", "__Internal")]
        public NSString UMPErrorDomain { get; }
    }

    // typedef void (^UMPConsentInformationUpdateCompletionHandler)(NSError * _Nullable);
    delegate void UMPConsentInformationUpdateCompletionHandler([NullAllowed] NSError arg0);

    // @interface UMPConsentInformation : NSObject
    [BaseType(typeof(NSObject))]
    interface UMPConsentInformation
    {
        // @property (readonly, nonatomic, class) UMPConsentInformation * _Nonnull sharedInstance;
        [Static]
        [Export("sharedInstance")]
        UMPConsentInformation SharedInstance { get; }

        // @property (readonly, nonatomic) UMPConsentStatus consentStatus;
        [Export("consentStatus")]
        UMPConsentStatus ConsentStatus { get; }

        // @property (readonly, nonatomic) UMPConsentType consentType;
        [Export("consentType")]
        UMPConsentType ConsentType { get; }

        // @property (readonly, nonatomic) UMPFormStatus formStatus;
        [Export("formStatus")]
        UMPFormStatus FormStatus { get; }

        // -(void)requestConsentInfoUpdateWithParameters:(UMPRequestParameters * _Nullable)parameters completionHandler:(UMPConsentInformationUpdateCompletionHandler _Nonnull)handler;
        [Export("requestConsentInfoUpdateWithParameters:completionHandler:")]
        void RequestConsentInfoUpdateWithParameters([NullAllowed] UMPRequestParameters parameters, UMPConsentInformationUpdateCompletionHandler handler);

        // -(void)reset;
        [Export("reset")]
        void Reset();
    }

    // typedef void (^UMPConsentFormLoadCompletionHandler)(UMPConsentForm * _Nullable, NSError * _Nullable);
    delegate void UMPConsentFormLoadCompletionHandler([NullAllowed] UMPConsentForm arg0, [NullAllowed] NSError arg1);

    // typedef void (^UMPConsentFormPresentCompletionHandler)(NSError * _Nullable);
    delegate void UMPConsentFormPresentCompletionHandler([NullAllowed] NSError arg0);

    // @interface UMPConsentForm : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UMPConsentForm
    {
        // +(void)loadWithCompletionHandler:(UMPConsentFormLoadCompletionHandler _Nonnull)completionHandler;
        [Static]
        [Export("loadWithCompletionHandler:")]
        void LoadWithCompletionHandler(UMPConsentFormLoadCompletionHandler completionHandler);

        // -(void)presentFromViewController:(UIViewController * _Nonnull)viewController completionHandler:(UMPConsentFormPresentCompletionHandler _Nullable)completionHandler;
        [Export("presentFromViewController:completionHandler:")]
        void PresentFromViewController(UIViewController viewController, [NullAllowed] UMPConsentFormPresentCompletionHandler completionHandler);
    }
}
