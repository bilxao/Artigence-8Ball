using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour
{
	public static UnityAds Instance;

	public string playStoreID = "4144089";
	public string appStoreID = "4144088";

	public string interstitialAd = "video";
	private string rewardedVideoAd = "rewardedVideo";

	public bool isTargetPlayStore;
	public bool isTestAd;

	private void Start()
	{
		//Advertisement.AddListener(this);
		//InitializeAdvertisement();
	}

	private void InitializeAdvertisement()
	{
		if (isTargetPlayStore)
		{
			Advertisement.Initialize(playStoreID, isTestAd);
			return;
		}
		Advertisement.Initialize(appStoreID, isTestAd);
	}

	public void ShowInterstitialAd()
	{
		//if (!Advertisement.IsReady(interstitialAd))
		//{
		//	return;
		//}
		Advertisement.Show(interstitialAd);
	}

	//public void ShowRewardedVideoAd()
	//{
		//if (!Advertisement.IsReady(rewardedVideoAd))
		//{
		//	return;
		//}
		//Advertisement.Show(rewardedVideoAd);


	//}

    //public void OnUnityAdsReady(string placementId)
    //{
	//	Debug.Log("Ad Ready");
	//}

   // public void OnUnityAdsDidError(string message)
    //{
	//	Debug.Log("Something Went Wrong");
	//}

   // public void OnUnityAdsDidStart(string placementId)
    //{
    //    Debug.Log("Ad Started");
   // }

   // public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    //{
     //   switch(showResult)
      //  {
		//	case ShowResult.Failed:
		//		break;
			//case ShowResult.Skipped:
				//break;
			//case ShowResult.Finished:
			//	if(placementId == rewardedVideoAd)
             //   {
				//	Debug.Log("Rewarded Ad Displayed");
              //  }
				//if(placementId == interstitialAd)
                //{
				//	Debug.Log("Interstitial Ad Displayed");
				//}
				//break;
        //}
    //}
}