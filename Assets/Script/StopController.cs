using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StopController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ボタンをクリックするとtitleScene に移動する。

    public void ButtonClicked()
    {
        SceneManager.LoadScene("Title");
    }
}
