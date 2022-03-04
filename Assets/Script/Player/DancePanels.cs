﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DancePanels : MonoBehaviour
{
    //ダンスパネルの名称取得のため、親要素をまとめて取得
    public GameObject[] dancePanels;
    VideoPlayer videoPlayer;

    public void CheckDancePanel(string danceName)
    {
        //モーションリストがダンスパネルオブジェクトにいるかオブジェクト名で検索。
        for (int i = 0; i < dancePanels.Length; i++)
        {
            //            Debug.Log("dancePanels:getDanceName:"+danceName+";");
            //            Debug.Log("dancePanels:getDancePanelName:" + dancePanels[i].name + ";");
            //存在した場合は動画を有効にする。
            //存在しない場合は動画を無効にする。
            if (danceName.Substring(10, 7) == dancePanels[i].name)
            {
                //                Debug.Log("dancePanels:nameHit");
                dancePanels[i].SetActive(true);
            }
            else
            {
                //                Debug.Log("dancePanels:nameNoHit");
                //                dancePanels[i].SetActive(false);
            }
            //ダンスパネルオブジェクトがアクティブかどうかの確認。アクティブな時は動画の再生など制御できるので
            //動画が停止してたら再生。
            if (dancePanels[i].activeSelf)
            {
                videoPlayer = dancePanels[i].GetComponent<VideoPlayer>();
                if (!videoPlayer.isPlaying)
                {
                    videoPlayer.Play();
                }
            }
        }
    }

}
