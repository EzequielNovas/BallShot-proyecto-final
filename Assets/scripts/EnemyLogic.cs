using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public GameObject Effect;
    public LogicController logicController;
    
    public void OnMouseDown()
    {
        Instantiate(Effect, transform.position, Quaternion.identity);
        logicController.SubtractEnemies();
        Destroy(gameObject);
    }
}