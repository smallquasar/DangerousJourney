using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button _restartLevelButton;
    [SerializeField] private Button _nextLevelButton;
    [SerializeField] private Button _exitGameButton;

    void Update()
    {
        if (Input.GetButtonDown("RestartLevel"))
        {
            _restartLevelButton.onClick.Invoke();
        }
        else if (Input.GetButtonDown("NextLevel"))
        {
            _nextLevelButton.onClick.Invoke();
        }
        else if (Input.GetButtonDown("ExitGame"))
        {
            _exitGameButton.onClick.Invoke();
        }
    }
}
