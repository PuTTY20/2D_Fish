using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadPlayScene()
        => SceneManager.LoadScene("2.Play", LoadSceneMode.Single);
}