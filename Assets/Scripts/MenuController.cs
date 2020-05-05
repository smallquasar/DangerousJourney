using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button _restartLevelButton;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private Button _exitGameButton;

    [SerializeField] private GameObject _levelResultPanel;

    void Update()
    {
        if (_levelResultPanel.activeSelf)
        {
            if (Input.GetButtonDown("RestartLevel"))
            {
                _restartLevelButton.onClick.Invoke();
            }
            else if (Input.GetButtonDown("NextLevel"))
            {
                _nextLevelButton.onClick.Invoke();
            }
        }

        if (Input.GetButtonDown("ExitGame"))
        {
            _exitGameButton.onClick.Invoke();
        }
    }
}
