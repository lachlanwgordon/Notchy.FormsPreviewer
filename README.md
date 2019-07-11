# Notchy.FormsPreviewer
Extend the Xamarin Forms Previewers with notches, curved corners and toolbars to help you make the right UI decisions at design time.

# Getting Started
1. Install from Nuget into your Android, iOS and .NetStandard projects.
2. Open a .xaml file and check that it's rendering in the previewer.
3. Add the namespace `xmlns:prev="clr-namespace:NotchyFormsPreviewer;assembly=NotchyFormsPreviewer"`
4. Add the Notch Effect to your ContentPage properties
e.g.
```
<ContentPage.Effects>
        <prev:NotchEffect
            d:Model="{OnPlatform Android=Pixel3XL, iOS=iPhoneXSMax}"
            />
</ContentPage.Effects>
```


# Models
The `Model` property has several presets built in and the ability to customize.

## iOS:
For all iPhone size please match the device selected for the notch to the device selected in the previewer.
* iPhoneX
* iPhoneXS
* iPhoneXSMax
* iPhoneXR

## Android
All Android presets at present are designed to work with the device size `Pixel 3 XL` but this may be updated in the future when other devices are added
* Pixel3XL
* P30

## Custom
If you set the device to `Custom` you can add your own notch parameters to work with other devices.

e.g.
```
<ContentPage.Effects>
    <local:NotchEffect
        Model="Custom">
        <local:NotchEffect.CustomDevice>
            <local:Device
                NotchX="370"
                NotchWidth="80"
                NotchHeight="58"
                NotchTopRadius="18"
                CornerRadius="45"
                NotchBottomRadius="40"
                >
            </local:Device>
        </local:NotchEffect.CustomDevice>
    </local:NotchEffect>
</ContentPage.Effects>
```

## More?
If you want to see other devices in here, please open a pull request or send me the metrics.

## Errors on Mac
This library is built using VS 2019 for windows using an SDK style project and multi-targeting. At this point in time VS Mac doesn't support multi-targeting. If you want to play around with the code and try custom device sizes you can checkout github.com/lachlanwgordon/NotchExperiment for a self contained app with much of the same code.

## Blog
This library was made as part of #XamarinUIJuly, you can read my post at lachlanwgordon.com/xamarinuijuly-notch/ and read a month's worth of excellent posts on Xamarin User Interfaces at https://www.thewissen.io/introducing-xamarin-ui-july/ .

![alt text](https://raw.githubusercontent.com/lachlanwgordon/Notchy.FormsPreviewer/master/xamuijuly-1.png
)
