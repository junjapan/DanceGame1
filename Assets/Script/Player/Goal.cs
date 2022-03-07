using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool isGoal;
    public ScreenManager screenManager;

    public bool IsGoal()
    {
        return isGoal;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tag name:" + other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
            isGoal = true;
            //            if (PlayerPrefs.GetFloat("BestTime",9999f) > screenManager.countTime) {
            //                PlayerPrefs.SetFloat("BestTime", screenManager.countTime);
            if (PlayerPrefs.GetFloat("BestTime", 9999f) > screenManager.getCountTime())
            {
                PlayerPrefs.SetFloat("BestTime", screenManager.getCountTime());
            }
            Debug.Log("goal collider in:");
            Debug.Log("goal getGoalFlg:" + screenManager.getGoalFlg() + ";");
            if (screenManager.getGoalFlg().Equals("ok") ||
                screenManager.getGoalFlg().Equals("clear")
            )
            {
                Debug.Log("dance:");
                Invoke("changeScene", 2.0f);
            }
            else
            {
                Debug.Log("no dance:");
                Invoke("changeScene_noDance", 2.0f);
            }
        }
    }

    void changeScene()
    {
        Debug.Log("changeScene:dance");
        SceneManager.LoadScene("Dance");
    }

    void changeScene_noDance()
    {
        Debug.Log("changeScene:nodance");
        SceneManager.LoadScene("NoDance");
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
