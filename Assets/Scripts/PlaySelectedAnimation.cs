using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySelectedAnimation : MonoBehaviour
{
    public Animator animator;
    private void Start()
    {
        animator.Play(PlayerPrefs.GetString("SelectedAnimation"));
    }
}
