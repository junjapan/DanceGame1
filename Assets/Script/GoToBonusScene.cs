﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBonusScene : MonoBehaviour
{
    float step_time;    //経過時間カウント用

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;       //経過時間初期化
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間をカウント
        step_time += Time.deltaTime;

        //25秒後に画面遷移(Titleへ移動）
        if (step_time >= 25.0f)
        {
            SceneManager.LoadScene("BonusScene");
        }
    }
}
