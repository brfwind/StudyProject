using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ABTest : MonoBehaviour
{
    void Start()
    {
        GameObject obj = ABManager.Instance.LoadRes("universe","Universe",typeof(GameObject)) as GameObject;
    }

    // void Start()
    // {
    //     //加载所需AB包
    //     AssetBundle ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/" + "model");

    //     //加载AB包中指定资源
    //     //GameObject obj = ab.LoadAsset<GameObject>("Tank");
    //     GameObject obj = ab.LoadAsset("Tank",typeof(GameObject)) as GameObject;

    //     Instantiate(obj);

    //     StartCoroutine(LoadABRes("universe","Universe"));

    //     AssetBundle abMain = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/" + "PC");
    //     AssetBundleManifest adManifest = abMain.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
    //     string[] strs = adManifest.GetAllDependencies("model");
    // }

    // //协程加载
    // IEnumerator LoadABRes(string ABName,string resName)
    // {
    //     //加载AB包
    //     AssetBundleCreateRequest ab2 = AssetBundle.LoadFromFileAsync(Application.streamingAssetsPath + "/" + ABName);
    //     yield return ab2;//等待ab2加载完成

    //     //加载资源
    //     AssetBundleRequest abcr = ab2.assetBundle.LoadAssetAsync(resName,typeof(GameObject));
    //     yield return abcr;//等待obj2加载完成

    //     GameObject obj2 = abcr.asset as GameObject;

    //     Instantiate(obj2);
    //     yield return null;
    // }

    // private AssetBundle mainAB;//主包
    // private AssetBundleManifest mainfestAB;//依赖获取文件
    // private Dictionary<string,AssetBundle> abDic = new Dictionary<string, AssetBundle>();//记录已加载包

    // public string ABPath
    // {
    //     get
    //     {
    //         return Application.streamingAssetsPath + "/";
    //     }
    // }

    // public void LoadDependencies(string abName)//传入需要寻找依赖的包
    // {
    //     if(mainAB == null)
    //         mainAB = AssetBundle.LoadFromFile(ABPath + "主包名");

    //     if(mainfestAB == null)
    //         mainfestAB = mainAB.LoadAsset<AssetBundleManifest>("AssetBundleManifest");

    //     string[] strs = mainfestAB.GetAllDependencies(abName);

    //     for(int i = 0; i < strs.Length;i++)
    //     {
    //         //字典避免重复加载包
    //         //if里的代码可以同时完成加载和如典两步
    //         if(!abDic.ContainsKey(strs[i]))
    //         {
    //             abDic.Add(strs[i],AssetBundle.LoadFromFile(ABPath + strs[i]));
    //         }
    //     }
    // }
}
