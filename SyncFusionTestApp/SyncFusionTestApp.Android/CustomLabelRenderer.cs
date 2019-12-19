using Android.Content;
using Android.Runtime;

using SyncFusionTestApp.Droid;

using System;
using Xamarin.Forms;

#pragma warning disable 612
[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
#pragma warning restore 612
namespace SyncFusionTestApp.Droid
{
    [Obsolete]
    public class CustomLabelRenderer : Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context)
        {

        }

        [Obsolete]
        public CustomLabelRenderer(IntPtr handle, JniHandleOwnership transfer)
        {

        }
    }
}