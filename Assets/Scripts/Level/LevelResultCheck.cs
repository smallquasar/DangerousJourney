using UnityEngine;

public class LevelResultCheck : MonoBehaviour
{
    private string _enemyTag;

    private void Start()
    {
        _enemyTag = LevelManager.LvlManager.EnemyTag;
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag(_enemyTag))
        {
            gameObject.SetActive(false);
        }
    }
}
