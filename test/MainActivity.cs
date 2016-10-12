using Android.App;
using Android.Widget;
using Android.OS;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using Xamarin.Android.Net;
using System.Net;

namespace test
{
	[Activity(Label = "test", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		string[] imgsUrl = new string[]{
			"http://img.uscri.be/ath/3221404b3f960cffee3e40b8b2e8434395e60d2b.jpg",
			"http://img.uscri.be/ath/c4c9da584fe26bcf1551b5d65a1d3961c0a6d7d8.jpg",
			"http://img.uscri.be/pth/4b827be1baf2dcb81d6b3f95c709f56853f26214",
			"http://img.uscri.be/pth/126a34cc83d6cbaf7d9e8d25f6b3042e0f6651a4",
			"http://img.uscri.be/pth/9bde0a3287acfe836a621fad00906dd15e17f5e8",
			"http://img.uscri.be/pth/7c980d7c663b86798b56402afadafdca9a696135",
			"http://img.uscri.be/pth/ceb99b9dec27943f1b5fccb9281e8b3624d5ee9d",
			"http://img.uscri.be/pth/9c42d16f577e8c27234f4f798d81f9ee0a292a87",
			"http://img.uscri.be/pth/895f91964b54571c5a4b3bd4d1c2e1f00e9588f5",
			"http://img.uscri.be/pth/d734bf6615586ecd6933293021a46b372d11aa8f",
			"http://img.uscri.be/pth/f7aa7514002cd3a8511acd4d6bc4fbff22830448",
			"http://img.uscri.be/pth/2a0dcd97052268beee1391676877564c159d5bc2",
			"http://cms.uscri.be/c79f4947-2a0b-4319-90d9-4776d63bf7ff.png",
			"http://img.uscri.be/pth/4082e01591f1097be1a7f80dcece416fba86aa5f",
			"http://img.uscri.be/pth/c855c7fc7663c7839eee53f333ad66ce36226fdd",
			"http://img.uscri.be/pth/db9ad155bd4bdb0c916f3aadebef781bf9e65742",
			"http://img.uscri.be/pth/c80bb016ccfbb092d1c94a64bafe86201183b2dc",
			"http://img.uscri.be/pth/43d2145b2d1d078d02d3540ecfb6770544837ed0",
			"http://img.uscri.be/pth/307e542eeefd34b6735bf78ca52605adbdc828cb",
			"http://img.uscri.be/pth/3f081c1d9c5e74abfe57f48a06cd09558b25486d",
			"http://img.uscri.be/pth/9523481a9bd306d7c0a52cd8bbeca220090719ee",
			"http://img.uscri.be/ath/3221404b3f960cffee3e40b8b2e8434395e60d2b.jpg",
			"http://img.uscri.be/ath/c4c9da584fe26bcf1551b5d65a1d3961c0a6d7d8.jpg",
			"http://img.uscri.be/pth/4b827be1baf2dcb81d6b3f95c709f56853f26214",
			"http://img.uscri.be/pth/126a34cc83d6cbaf7d9e8d25f6b3042e0f6651a4",
			"http://img.uscri.be/pth/9bde0a3287acfe836a621fad00906dd15e17f5e8",
			"http://img.uscri.be/pth/7c980d7c663b86798b56402afadafdca9a696135",
			"http://img.uscri.be/pth/ceb99b9dec27943f1b5fccb9281e8b3624d5ee9d",
			"http://img.uscri.be/pth/9c42d16f577e8c27234f4f798d81f9ee0a292a87",
			"http://img.uscri.be/pth/895f91964b54571c5a4b3bd4d1c2e1f00e9588f5",
			"http://img.uscri.be/pth/d734bf6615586ecd6933293021a46b372d11aa8f",
			"http://img.uscri.be/pth/f7aa7514002cd3a8511acd4d6bc4fbff22830448",
			"http://img.uscri.be/pth/2a0dcd97052268beee1391676877564c159d5bc2",
			"http://cms.uscri.be/c79f4947-2a0b-4319-90d9-4776d63bf7ff.png",
			"http://img.uscri.be/pth/4082e01591f1097be1a7f80dcece416fba86aa5f",
			"http://img.uscri.be/pth/c855c7fc7663c7839eee53f333ad66ce36226fdd",
			"http://img.uscri.be/pth/db9ad155bd4bdb0c916f3aadebef781bf9e65742",
			"http://img.uscri.be/pth/c80bb016ccfbb092d1c94a64bafe86201183b2dc",
			"http://img.uscri.be/pth/43d2145b2d1d078d02d3540ecfb6770544837ed0",
			"http://img.uscri.be/pth/307e542eeefd34b6735bf78ca52605adbdc828cb",
			"http://img.uscri.be/pth/3f081c1d9c5e74abfe57f48a06cd09558b25486d",
			"http://img.uscri.be/pth/9523481a9bd306d7c0a52cd8bbeca220090719ee",
			"http://img.uscri.be/ath/3221404b3f960cffee3e40b8b2e8434395e60d2b.jpg",
			"http://img.uscri.be/ath/c4c9da584fe26bcf1551b5d65a1d3961c0a6d7d8.jpg",
			"http://img.uscri.be/pth/4b827be1baf2dcb81d6b3f95c709f56853f26214",
			"http://img.uscri.be/pth/126a34cc83d6cbaf7d9e8d25f6b3042e0f6651a4",
			"http://img.uscri.be/pth/9bde0a3287acfe836a621fad00906dd15e17f5e8",
			"http://img.uscri.be/pth/7c980d7c663b86798b56402afadafdca9a696135",
			"http://img.uscri.be/pth/ceb99b9dec27943f1b5fccb9281e8b3624d5ee9d",
			"http://img.uscri.be/pth/9c42d16f577e8c27234f4f798d81f9ee0a292a87",
			"http://img.uscri.be/pth/895f91964b54571c5a4b3bd4d1c2e1f00e9588f5",
			"http://img.uscri.be/pth/d734bf6615586ecd6933293021a46b372d11aa8f",
			"http://img.uscri.be/pth/f7aa7514002cd3a8511acd4d6bc4fbff22830448",
			"http://img.uscri.be/pth/2a0dcd97052268beee1391676877564c159d5bc2",
			"http://cms.uscri.be/c79f4947-2a0b-4319-90d9-4776d63bf7ff.png",
			"http://img.uscri.be/pth/4082e01591f1097be1a7f80dcece416fba86aa5f",
			"http://img.uscri.be/pth/c855c7fc7663c7839eee53f333ad66ce36226fdd",
			"http://img.uscri.be/pth/db9ad155bd4bdb0c916f3aadebef781bf9e65742",
			"http://img.uscri.be/pth/c80bb016ccfbb092d1c94a64bafe86201183b2dc",
			"http://img.uscri.be/pth/43d2145b2d1d078d02d3540ecfb6770544837ed0",
			"http://img.uscri.be/pth/307e542eeefd34b6735bf78ca52605adbdc828cb",
			"http://img.uscri.be/pth/3f081c1d9c5e74abfe57f48a06cd09558b25486d",
			"http://img.uscri.be/pth/9523481a9bd306d7c0a52cd8bbeca220090719ee",
		};

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			Button button2 = FindViewById<Button>(Resource.Id.myButton2);
			Button button3 = FindViewById<Button>(Resource.Id.myButton3);
			ServicePointManager.MaxServicePoints = 10;

			button.Click += delegate { 
				var ysHttpClient = new HttpClient(new ModernHttpClient.NativeMessageHandler());
				foreach (var img in imgsUrl)
					Test(img, ysHttpClient, "modernhttpclient");
			};

			button2.Click += delegate
			{
				var ysHttpClient = new HttpClient(new AndroidClientHandler());
				foreach (var img in imgsUrl)
					Test(img, ysHttpClient, "AndroidClientHandler");
			};


			button3.Click += delegate
			{
				var ysHttpClient = new HttpClient();
				foreach (var img in imgsUrl)
					Test(img, ysHttpClient, "normalhandler");
			};
		}

		public async Task Test(string url, HttpClient ysHttpClient, string info)
		{
			var now = DateTime.Now;
			System.Console.WriteLine(info + ":DL " + url + " started at " + now);
            try
            {
                using (var resp = await ysHttpClient.GetAsync(url))
                {
                    using (var fstream = File.OpenWrite(Path.GetTempFileName()))
                    {
                        await resp.Content.CopyToAsync(fstream);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error for " + url + " => " + e.Message);
            }
			System.Console.WriteLine(info + ":DL " + url + " end in " + (DateTime.Now - now).TotalMilliseconds + " at " + DateTime.Now);
		}
	}
}

