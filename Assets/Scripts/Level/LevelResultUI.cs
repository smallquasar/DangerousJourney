using UnityEngine;
using UnityEngine.UI;

public class LevelResultUI : MonoBehaviour
{
    [SerializeField] private Text _levelEndText;
    [SerializeField] private GameObject _levelResultPanel; 

    private void Start()
    {
        _levelResultPanel.SetActive(false);
    }

    public void WinShow()
    {

    }

    public void GameOverShow()
    {
        Time.timeScale = 0;
        _levelEndText.text = "Game over";
        _levelResultPanel.SetActive(true);
        //LevelManager.LvlManager.ReloadLevel();
    }
}
