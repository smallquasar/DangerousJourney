using UnityEngine;
using UnityEngine.UI;

public class LevelResultUI : MonoBehaviour
{
    [SerializeField] private Text _levelEndText;
    [SerializeField] private GameObject _levelResultPanel;
    [SerializeField] private Button _levelReloadButton;
    [SerializeField] private Button _nextLevelButton;

    private void Start()
    {
        _levelResultPanel.SetActive(false);
    }

    public void WinShow()
    {
        LevelEndShow(true);
    }

    public void GameOverShow()
    {
        LevelEndShow(false);
    }

    private void LevelEndShow(bool isSuccess)
    {
        Time.timeScale = 0;
        _levelEndText.text = isSuccess ? "Congratulations!" : "Game over";
        _levelResultPanel.SetActive(true);
        _levelReloadButton.gameObject.SetActive(isSuccess ? false : true);
        _nextLevelButton.gameObject.SetActive(isSuccess ? true : false);
    }

    public void OnLevelReloadButtonClick()
    {
        LevelManager.LvlManager.ReloadLevel();
    }

    public void OnNextLevelButtonClick()
    {
        LevelManager.LvlManager.NextLevel();
    }

    public void OnExitButtonClick()
    {
        LevelManager.LvlManager.ExitGame();
    }
}
