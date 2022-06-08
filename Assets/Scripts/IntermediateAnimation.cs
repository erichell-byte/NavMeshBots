using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntermediateAnimation : MonoBehaviour
{
    private Animator _animator;
    private int _prevSceneIndex;

    private void Start()
    {
        _prevSceneIndex = PrevSceneIndex._currentScene;
        _animator = GetComponent<Animator>();
        _animator.SetTrigger("LoadingScene");
        StartCoroutine(WaitLoadAnimation());

    }

    private IEnumerator WaitLoadAnimation()
    {
        yield return new WaitForSeconds(3);
        if (_prevSceneIndex == 2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    
    
}
