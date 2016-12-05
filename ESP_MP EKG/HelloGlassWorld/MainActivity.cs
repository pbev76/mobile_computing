using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Glass.App;
using Android.Glass.Widget;
using Android.Graphics;

namespace ESP_MP
{
	[Activity (Label = "ESP-MP History", Icon = "@drawable/Icon", MainLauncher = true, Enabled = true)]
	[IntentFilter (new String[]{ "com.google.android.glass.action.VOICE_TRIGGER" })]
	[MetaData ("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
	public class MainActivity : Activity
	{
		// The project requires the Google Glass Component from
		// https://components.xamarin.com/view/googleglass
		// so make sure you add that in to compile succesfully.
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            var b = new CardBuilder (this, CardBuilder.Layout.Text);
			//b.SetText ("Name: John Doe  Sex: M  Age:24\nHeight: 72     Weight: 74\nPatient presents with shortness of breath and dizzyness.");


			b.AddImage();
			b.SetFootnote ("ESP-MP");
            b.SetTimestamp ("today");

            SetContentView (b.View);
		}
	}
}
