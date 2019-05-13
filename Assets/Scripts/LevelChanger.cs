using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    private int LevelToLoad;
    private Vector3 MoveFire;

    public void FadeToLevel (int LevelIndex) // To go to any level we need to give level index
    {
        LevelToLoad = LevelIndex;
        animator.SetTrigger("Disappear");

    }

    public void FadeToNextLevel ()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(LevelToLoad);

    }

}
