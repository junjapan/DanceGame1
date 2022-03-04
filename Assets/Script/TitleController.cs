using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text bestTimeText;

    public void Start() {
        bestTimeText.text = "Best Time:" + PlayerPrefs.GetFloat("BestTime").ToString("F2")+"s";
    }

    public void OnStartButtonClicked() {
        SceneManager.LoadScene("Main");
    }
}
