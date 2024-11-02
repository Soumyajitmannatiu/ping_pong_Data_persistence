using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class IntroMenuHandler : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
#if UNITY_EDITOR
        {
            EditorApplication.ExitPlaymode();            
        }
#else
        {
            Application.Quit();
        }
#endif
    }
}
