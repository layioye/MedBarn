﻿using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MedBarn;
using MedBarn.iOS;
using MedBarn.Controls;
using System.ComponentModel;
using System;
using MedBarn.iOS.Controls;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace MedBarn.iOS.Controls
{
    public class CustomEditorRenderer : EditorRenderer
    {
        private nfloat transparent;

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.Layer.RemoveBackgroundLayer();
        }
    }
}