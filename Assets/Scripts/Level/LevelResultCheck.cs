using UnityEngine;

public class LevelResultCheck : MonoBehaviour
{
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
            LevelManager.LvlManager.ReloadLevel();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_endLevelTag))
        {
            LevelManager.LvlManager.NextLevel();
        }
    }
}
