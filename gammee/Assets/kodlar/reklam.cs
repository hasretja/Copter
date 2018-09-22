using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class reklam : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MobileAds.Initialize("ca-app-pub-9927642697685217~6072450923");

        BannerView reklamObjesi = new BannerView("ca-app-pub-9927642697685217/4020577627", AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);
    }
	
}
