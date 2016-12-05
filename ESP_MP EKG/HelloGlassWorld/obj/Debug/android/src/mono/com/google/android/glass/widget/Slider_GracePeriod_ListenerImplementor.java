package mono.com.google.android.glass.widget;


public class Slider_GracePeriod_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.glass.widget.Slider.GracePeriod.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGracePeriodCancel:()V:GetOnGracePeriodCancelHandler:Android.Glass.Widget.Slider/IGracePeriodListenerInvoker, Xamarin.Google.Glass\n" +
			"n_onGracePeriodEnd:()V:GetOnGracePeriodEndHandler:Android.Glass.Widget.Slider/IGracePeriodListenerInvoker, Xamarin.Google.Glass\n" +
			"";
		mono.android.Runtime.register ("Android.Glass.Widget.Slider+IGracePeriodListenerImplementor, Xamarin.Google.Glass, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", Slider_GracePeriod_ListenerImplementor.class, __md_methods);
	}


	public Slider_GracePeriod_ListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Slider_GracePeriod_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Glass.Widget.Slider+IGracePeriodListenerImplementor, Xamarin.Google.Glass, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGracePeriodCancel ()
	{
		n_onGracePeriodCancel ();
	}

	private native void n_onGracePeriodCancel ();


	public void onGracePeriodEnd ()
	{
		n_onGracePeriodEnd ();
	}

	private native void n_onGracePeriodEnd ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
