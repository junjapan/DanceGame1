using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    float countTime = 0;
    string goalFlg = "";
    string panelAllFlg = "";
    string spcialFlg = "";

    //キャンバスの左上の経過時間表示設定
    public Text timeText;

    //キャンバスの右上のモーション表示設定
    public GameObject player;
    GetMotionList motions;
    public Text motionText;
    //モーション用にダンスパネルの設定
    public DancePanels dancePanels;

    void Start()
    {
        motions = player.GetComponent<GetMotionList>();

    }


    public float getCountTime()
    {
        return countTime;
    }

    public string getGoalFlg()
    {
        return goalFlg;
    }

    // Update is called once per frame
    void Update()
    {
        //キャンバスの左上の経過時間表示設定
        countTime += Time.deltaTime;
        timeText.text = countTime.ToString("F2");

        //キャンバスの右上のモーション表示設定
        if (!(panelAllFlg.Equals("all")))
        {
            List<string> actions = motions.motionList;
            string[] array = actions.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                motionText.text = string.Join("\n", array);
                if (array[i] == "Dance08")
                {
                    spcialFlg = "sp";
                }
                dancePanels.CheckDancePanel(array[i]);
                panelAllFlg = dancePanels.getPanelAllFlg();
                Debug.Log("ScreenManager panelAllFlg:" + panelAllFlg);
            }
            if (panelAllFlg.Equals("all"))
            {
                if (spcialFlg == "sp")
                {
                    goalFlg = "clear";
                }
                else
                {
                    goalFlg = "ok";
                }
            }
        }


    }

}
