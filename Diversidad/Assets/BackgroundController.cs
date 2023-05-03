using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float speed = 0.4f;
    public float resetPosition = -8f;

    private SpriteRenderer[] sprites;
    private bool moving;
    private void Start()
    {
        // Get all child SpriteRenderer components
        sprites = GetComponentsInChildren<SpriteRenderer>();
        moving = true;
        PlayerController.OnPlayerDead += stopMoving;
        
    }
    private void OnDestroy()
    {
        PlayerController.OnPlayerDead -= stopMoving;
    }

    private void stopMoving()
    {
        moving = false;
    }
    private void Update()
    {
        if (moving)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            // Check if first sprite has reached the reset position
            if (sprites[0].transform.position.x <= resetPosition)
            {
                // Teleport first sprite to the right of the second sprite
                sprites[0].transform.position = new Vector2(sprites[1].transform.position.x + sprites[1].bounds.size.x, sprites[0].transform.position.y);
            }
            if (sprites[1].transform.position.x <= resetPosition)
            {
                // Teleport first sprite to the right of the second sprite
                sprites[1].transform.position = new Vector2(sprites[0].transform.position.x + sprites[0].bounds.size.x, sprites[1].transform.position.y);
            }
        }
        
        

       
    }
}