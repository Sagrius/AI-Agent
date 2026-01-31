using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public SetAtRandomLocation obstaclePrefab;
    public int ObstacleAmount = 20;
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            SetAtRandomLocation inst = Instantiate(obstaclePrefab,transform);
            inst.Execute();
        }
    }


}
