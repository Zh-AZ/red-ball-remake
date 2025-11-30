using UnityEngine;

public class DestroyStones : PlayerInventory
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && hasShovel && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            Debug.Log("You have destroyed the stones!");
        }
    }
}
