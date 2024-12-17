using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadStartScene()
        => SceneManager.LoadScene("1.Start", LoadSceneMode.Single);

    public void LoadPlayScene()
        => SceneManager.LoadScene("2.Play", LoadSceneMode.Single);
}