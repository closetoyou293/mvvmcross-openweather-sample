package md5f9ca00c8c6fe66460baf6f5b644dd8f4;


public class WeatherDetailsView
	extends mvvmcross.droid.support.v7.appcompat.MvxAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmWeather2.Droid.Views.WeatherDetailsView, MvvmWeather2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", WeatherDetailsView.class, __md_methods);
	}


	public WeatherDetailsView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == WeatherDetailsView.class)
			mono.android.TypeManager.Activate ("MvvmWeather2.Droid.Views.WeatherDetailsView, MvvmWeather2.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
