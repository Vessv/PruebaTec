using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationSelection : MonoBehaviour
{
    string _selectedAnimationName;
    public void GoToMain()
    {
        PlayerPrefs.SetString("SelectedAnimation", _selectedAnimationName);
        SceneManager.LoadScene("Main");
    }

    public void SetSelectedAnimation(string animationName)
    {
        _selectedAnimationName = animationName;
    }
}
