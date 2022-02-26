using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    bool isGoal;

    public bool IsGoal() {
        return isGoal;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            isGoal = true;
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
