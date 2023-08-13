using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnityLevelPlay : MonoBehaviour 
{   
    private int IntInterstitial;
    private int IntUpdate;
    private int IntNoAds;

    private void Start ()
    {
        IntNoAds = PlayerPrefs.GetInt("IntNoAds");

        IronSource.Agent.init ("1ae24d5cd");
        IronSource.Agent.validateIntegration();

        if (IntNoAds == 0)
        {
            LoadBanner();  
            LoadInterstitial();
        }
    }

    private void OnEnable ()
    {
        IronSourceEvents.onSdkInitializationCompletedEvent += SdkInitializationCompletedEvent;

        //Add AdInfo Banner Events
        IronSourceBannerEvents.onAdLoadedEvent += BannerOnAdLoadedEvent;
        IronSourceBannerEvents.onAdLoadFailedEvent += BannerOnAdLoadFailedEvent;
        IronSourceBannerEvents.onAdClickedEvent += BannerOnAdClickedEvent;
        IronSourceBannerEvents.onAdScreenPresentedEvent += BannerOnAdScreenPresentedEvent;
        IronSourceBannerEvents.onAdScreenDismissedEvent += BannerOnAdScreenDismissedEvent;
        IronSourceBannerEvents.onAdLeftApplicationEvent += BannerOnAdLeftApplicationEvent;

        //Add AdInfo Interstitial Events
        IronSourceInterstitialEvents.onAdReadyEvent += InterstitialOnAdReadyEvent;
        IronSourceInterstitialEvents.onAdLoadFailedEvent += InterstitialOnAdLoadFailed;
        IronSourceInterstitialEvents.onAdOpenedEvent += InterstitialOnAdOpenedEvent;
        IronSourceInterstitialEvents.onAdClickedEvent += InterstitialOnAdClickedEvent;
        IronSourceInterstitialEvents.onAdShowSucceededEvent += InterstitialOnAdShowSucceededEvent;
        IronSourceInterstitialEvents.onAdShowFailedEvent += InterstitialOnAdShowFailedEvent;
        IronSourceInterstitialEvents.onAdClosedEvent += InterstitialOnAdClosedEvent;
    }

    void OnApplicationPause(bool isPaused) 
    {                 
        IronSource.Agent.onApplicationPause(isPaused);
    }

    private void SdkInitializationCompletedEvent()  { }

    /************* Banner *************/

    public void LoadBanner ()
    {
        IronSource.Agent.loadBanner(IronSourceBannerSize.BANNER, IronSourceBannerPosition.BOTTOM);
    }

    void BannerOnAdLoadedEvent(IronSourceAdInfo adInfo){
    }
    void BannerOnAdLoadFailedEvent(IronSourceError ironSourceError){
    }
    void BannerOnAdClickedEvent(IronSourceAdInfo adInfo){
    }
    void BannerOnAdScreenPresentedEvent(IronSourceAdInfo adInfo){
    }
    void BannerOnAdScreenDismissedEvent(IronSourceAdInfo adInfo){
    }
    void BannerOnAdLeftApplicationEvent(IronSourceAdInfo adInfo){
    }

    /************* Interstitial *************/

    public void LoadInterstitial ()
    {
        IronSource.Agent.loadInterstitial();
    }

    public void ShowInterstitial ()
    {
        IntNoAds = PlayerPrefs.GetInt("IntNoAds");

        if (IntNoAds == 0){
        IntInterstitial += 1;

        // Первый цикл рекламы
        if (IntInterstitial >= 1 && IntUpdate == 0)
        {
            if (IronSource.Agent.isInterstitialReady())
            {
                IronSource.Agent.showInterstitial();

                IntUpdate = 1;
                IntInterstitial = 0;
            }
            else
            {
                Debug.Log("Ads not ready");
            }
        }
        }
    }

    void InterstitialOnAdReadyEvent(IronSourceAdInfo adInfo) {
    }
    void InterstitialOnAdLoadFailed(IronSourceError ironSourceError) {
    }
    void InterstitialOnAdOpenedEvent(IronSourceAdInfo adInfo) {
    }
    void InterstitialOnAdClickedEvent(IronSourceAdInfo adInfo) {
    }
    void InterstitialOnAdShowFailedEvent(IronSourceError ironSourceError, IronSourceAdInfo adInfo) {
    }
    void InterstitialOnAdClosedEvent(IronSourceAdInfo adInfo) {
    }
    void InterstitialOnAdShowSucceededEvent(IronSourceAdInfo adInfo) {
    }


}