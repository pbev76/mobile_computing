package mono.com.google.android.glass.touchpad;


public class GestureDetector_OneFingerScrollListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.glass.touchpad.GestureDetector.OneFingerScrollListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOneFingerScroll:(FFF)Z:GetOnOneFingerScroll_FFFHandler:Android.Glass.Touchpad.GestureDetector/IOneFingerScrollListenerInvoker, Xamarin.Google.Glass\n" +
			"";
		mono.android.Runtime.register ("Android.Glass.Touchpad.GestureDetector+IOneFingerScrollListenerImplementor, Xamarin.Google.Glass, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", GestureDetector_OneFingerScrollListenerImplementor.class, __md_methods);
	}


	public GestureDetector_OneFingerScrollListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GestureDetector_OneFingerScrollListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Glass.Touchpad.GestureDetector+IOneFingerScrollListenerImplementor, Xamarin.Google.Glass, Version=2.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onOneFingerScroll (float p0, float p1, float p2)
	{
		return n_onOneFingerScroll (p0, p1, p2);
	}

	private native boolean n_onOneFingerScroll (float p0, float p1, float p2);

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
