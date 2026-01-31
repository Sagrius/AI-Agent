using UnityEngine;

public class FollowDragon : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float Height_Offset = 50;
   private void Start()
    {
        transform.rotation = Quaternion.Euler(90,0,0);
    }
    private void Update()
    {
        transform.position = target.position + new Vector3(0, Height_Offset, 0);
    }
}
