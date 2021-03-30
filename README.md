# WPF.ImageEffects
GPU-based image effects (brightness, contrast) for WPF

https://www.nuget.org/packages/WPF.ImageEffects

[![nuget](https://img.shields.io/nuget/v/WPF.ImageEffects.svg)](https://www.nuget.org/packages/WPF.ImageEffects)

## How to use it ##

1. Add clr namespace to root node:

```XAML
<Window x:Class="WPF.ImageEffects.Demo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:imageeffects="clr-namespace:WPF.ImageEffects;assembly=WPF.ImageEffects"
        xmlns:local="clr-namespace:WPF.ImageEffects.Demo"
        Title="MainWindow">
```

2. Place shader effect to image control

```XAML
<Slider x:Name="sliderBrightness" Minimum="-1" Maximum="1" Value="0" />
<Slider x:Name="sliderContrast" Minimum="-1" Maximum="1" Value="0" />

<Image x:Name="image">
            <Image.Effect>
                <imageeffects:BrightnessContrastEffect 
                                        Brightness="{Binding Value, ElementName=sliderBrightness}" 
                                        Contrast="{Binding Value, ElementName=sliderContrast}" />
            </Image.Effect>
</Image>
```
