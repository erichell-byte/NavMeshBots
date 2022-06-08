using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public static void SwitchToScene(int index)
    {
        PrevSceneIndex._currentScene = index;
        SceneManager.LoadScene(1);
    }

}
