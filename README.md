# TestApps-for-Xamarin-bug-39916

Sample projects for the Xamarin Forms Bug 39916 - SoftKeyboard default behavior covers Listview when using FormsAppCompatActivity. https://bugzilla.xamarin.com/show_bug.cgi?id=39916

Related bug: https://bugzilla.xamarin.com/show_bug.cgi?id=39765

Bug description: The keyboard covers the existing elements in a ListView thus, one cannot effective navigate to the last few items in the ListView.
Originally the bug was only active when using Xamarin Forms with FormsAppCompat, but lately it's also active without FormsAppCompat.

**Sample projects that contain the bug:**

*Xamarin Forms, with FormsAppCompat*
* TestApp FormsAppCompatActivity (Forms 2.1.0.6529)
* TestApp FormsAppCompatActivity (Forms 2.3.3.175)

*Xamarin Forms, without FormsAppCompat*
* TestApp FormsApplicationActivity (Forms 2.3.4.247)
* TestApp FormsApplicationActivity (Forms 2.3.5.256-pre6)

**Sample project that behaves as expected**

*Xamarin Forms, without FormsAppCompat*
* TestApp FormsApplicationActivity (Forms 2.1.0.6529)
