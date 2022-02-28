using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool isGoal;
    public ScreenManager screenManager;

    public bool IsGoal() {
        return isGoal;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            isGoal = true;
            if (PlayerPrefs.GetFloat("BestTime") > screenManager.countTime) {
                PlayerPrefs.SetFloat("BestTime", screenManager.countTime);
            }
            Invoke("changeScene", 2.0f);
        }
    }

    void changeScene() {
        SceneManager.LoadScene("TestScene");
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
