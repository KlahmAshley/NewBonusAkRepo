using UnityEngine;

public class Apple : MonoBehaviour, IFruit
{
    public Vector2 SpawnA;
    public GameObject apple;

    public void AssignFruit(GameObject apple, Vector2 SpawnA)
    {
        GameObject bullet = GameObject.Instantiate(apple, SpawnA, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }


}
