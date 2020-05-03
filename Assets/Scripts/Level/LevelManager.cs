using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager LvlManager { get; private set; }

    public string EnemyTag { get; private set; }
    public string EndLevelTag { get; private set; }

    private void Awake()
    {
        if (!LvlManager)
        {
            DontDestroyOnLoad(gameObject);
            LvlManager = this;
        }
        else
        {
            Destroy(gameObject);
        }

        EnemyTag = "Enemy";
        EndLevelTag = "EndLevel";
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);

            if (Time.timeScale == 0)
                Time.timeScale = 1;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
