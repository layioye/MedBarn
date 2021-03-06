﻿using MedBarn.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MedBarn.Droid.Controls;

[assembly:ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace MedBarn.Droid.Controls
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}