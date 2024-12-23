
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Admob : Singleton<Admob>
{
    // [SerializeField] [TextArea(1, 2)] string testAppId = "ca-app-pub-3940256099942544~3347511713";
    // [Space(order = 0)]

    [Header("Admob Ad Units :", order = 1)]
    [SerializeField] [TextArea(1, 2)] string idBanner = "ca-app-pub-3940256099942544/6300978111";
    [SerializeField] [TextArea(1, 2)] string idInterstitial = "ca-app-pub-3940256099942544/1033173712";
    [SerializeField] [TextArea(1, 2)] string idReward = "ca-app-pub-3940256099942544/5224354917";

    [Space]

    [Header("Toggle Admob Ads :")]
    [SerializeField] bool bannerAdEnabled = true;
    [SerializeField] bool interstitialAdEnabled = true;
    [SerializeField] bool rewardedAdEnabled = true;

    bool initDone = false;

    public static event Action OnRewardedAdWatched;

    public bool IsRewardedAdLoaded => false;

    private void OnEnable() => SceneManager.sceneLoaded += HandleOnSceneLoaded;
    private void OnDisable() => SceneManager.sceneLoaded -= HandleOnSceneLoaded;

    private void HandleOnSceneLoaded(Scene scene, LoadSceneMode lsm)
    {
        if (scene.buildIndex == 0) Destroy(gameObject);
    }

    private void Start()
    {
        
    }

}
