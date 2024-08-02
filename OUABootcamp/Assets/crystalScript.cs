using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class crystalScript : MonoBehaviour
{
    public string name;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="crystal")
        {
            changeMenu(name);
        }
    }

    public void changeMenu(string name)
    {
        SceneManager.LoadScene(name);
    }
}
