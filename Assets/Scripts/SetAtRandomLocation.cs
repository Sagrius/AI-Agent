using UnityEngine;

public class SetAtRandomLocation : MonoBehaviour
{
    private Vector2 BoundsX = new Vector2(-95,95) , BoundsZ = new Vector2(1, 1900);

    public void Execute()
    {
  
        float randomX = Random.Range(BoundsX.x, BoundsX.y);
        float randomZ = Random.Range(BoundsZ.x, BoundsZ.y);

        transform.position = new Vector3(randomX, Random.Range(1,50), randomZ);
    }
}
