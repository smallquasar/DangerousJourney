using UnityEngine;

public class LevelResultCheck : MonoBehaviour
{
    [SerializeField] private LevelResultUI _levelResultUI;

    private string _enemyTag;
    private string _endLevelTag;

    private void Start()
    {
        _enemyTag = LevelManager.LvlManager.EnemyTag;
        _endLevelTag = LevelManager.LvlManager.EndLevelTag;
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag(_enemyTag))
        {
            _levelResultUI.GameOverShow();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_endLevelTag))
        {
            _levelResultUI.WinShow();
        }
    }
}
