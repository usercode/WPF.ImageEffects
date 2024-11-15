﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace WPF.ImageEffects
{
    /// <summary>
    /// BrightContrastEffect
    /// </summary>
    public class BrightnessContrastEffect : ShaderEffect
    {
        public static readonly DependencyProperty InputProperty =
        ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(BrightnessContrastEffect), 0);

        public static readonly DependencyProperty BrightnessProperty =
            DependencyProperty.Register(nameof(Brightness), typeof(double), typeof(BrightnessContrastEffect), new UIPropertyMetadata(0.0, PixelShaderConstantCallback(0)));

        public static readonly DependencyProperty ContrastProperty =
            DependencyProperty.Register(nameof(Contrast), typeof(double), typeof(BrightnessContrastEffect), new UIPropertyMetadata(0.0, PixelShaderConstantCallback(1)));


        public BrightnessContrastEffect()
        {
            PixelShader = new PixelShader() { UriSource = new Uri(@"pack://application:,,,/WPF.ImageEffects;component/Shaders/ImageShader.fxc") };
            UpdateShaderValue(InputProperty);
            UpdateShaderValue(BrightnessProperty);
            UpdateShaderValue(ContrastProperty);
        }

        /// <summary>
        /// Input
        /// </summary>
        public Brush Input
        {
            get { return (Brush)GetValue(InputProperty); }
            set { SetValue(InputProperty, value); }
        }       

        /// <summary>
        /// Brightness
        /// </summary>
        public double Brightness
        {
            get { return (double)GetValue(BrightnessProperty); }
            set { SetValue(BrightnessProperty, value); }
        }

        /// <summary>
        /// Contrast
        /// </summary>
        public double Contrast
        {
            get { return (double)GetValue(ContrastProperty); }
            set { SetValue(ContrastProperty, value); }
        }
    }
}
