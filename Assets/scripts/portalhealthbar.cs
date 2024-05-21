using UnityEngine;

public class portalhealthbar : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    float segment;
    float move;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        segment = spriteRenderer.size.x / 250;
        move = segment / 2f;
    }
    public void decreasesize()
    {
        spriteRenderer.size.Set(spriteRenderer.size.x-segment,spriteRenderer.size.y);
        spriteRenderer.transform.position.Set(spriteRenderer.transform.position.x-move,spriteRenderer.transform.position.y,spriteRenderer.transform.position.z);
    }
    private void Update()
    {
       if(Input.anyKeyDown)
        {
            decreasesize();
        }
    }
}
