# Google UMP for Xamarin (Android and iOS)

A cross-platform wrapper for Google's User Messaging Platform for Android and iOS.

https://developers.google.com/admob/ump/android/quick-start
https://developers.google.com/admob/ump/ios/quick-start

## Installation

Available (as a preview) on Nuget [Plugin.GoogleUserMessagingPlatform](https://www.nuget.org/packages/Plugin.GoogleUserMessagingPlatform/)

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Plugin.GoogleUserMessagingPlatform)](https://www.nuget.org/packages/Plugin.GoogleUserMessagingPlatform/)

## Implementation

### Android

Uses the Android binding from Xamarin Components:

https://github.com/xamarin/XamarinComponents/
https://www.nuget.org/packages/Xamarin.Google.UserMessagingPlatform/1.0.0

### iOS

Currently uses an included iOS binding.


## Usage

On Android, make sure `Xamarin.Essentials.Init` is initialized, either in `Activity.OnCreate` or `Application.OnCreate`. For example:

```csharp
public class MainApplication : Application
{
    public MainApplication(IntPtr handle, JniHandleOwnership transer)
        : base(handle, transer)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
        Xamarin.Essentials.Platform.Init(this);
    }
}
```

Then use something like the following somewhere in the start-up flow in your cross-platform code:

```csharp

var ump = UserMessagingPlatform.Instance;
if (ump.IsSupported)
{
    var parameters = new RequestParameters
    {
        DebugSettings = new ConsentDebugSettings
        {
            // Optional, for testing
            Geography = DebugGeography.Eea
        }
    };
    var consent = await ump.GetConsentInformationAsync(parameters);
    if (consent.ConsentStatus == ConsentStatus.Required && consent.FormStatus == FormStatus.Available)
    {
        await ump.LoadConsentFormAsync();
        await ump.ShowFormAsync();
    }
}
```

## More reading

See the original documentation from Google for more information:

https://developers.google.com/admob/ump/android/quick-start
https://developers.google.com/admob/ump/ios/quick-start

Apart from minor renames, the API matches the original.

The only exception is the addition of the `IsSupported` property. This returns `true` on Android and iOS and `false` on .NET Standard. All other methods throw `PlatformNotSupportedException` when called from .NET Standard.
