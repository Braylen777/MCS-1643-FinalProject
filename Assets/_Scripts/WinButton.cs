using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{
    public void OnWinButton()
    {
        SceneManager.LoadScene(0);
    }
}
