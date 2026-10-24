using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    public void selectPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void selectMenu()
    {
        SceneManager.LoadScene(0);
    }
}
