using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Title");
        }

        if (other.gameObject.tag == "Ball" || other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
