using UnityEngine;

public class healthbar : MonoBehaviour
{
    RectTransform bar;
    float segment;
    private float move;
    private void Start()
    {
        bar = GetComponent<RectTransform>();
        segment = bar.sizeDelta.x/10f;
        
        move = segment / 2f;
    }
    public void decreaseSize()
    {
        
        Vector2 sizedelta = bar.sizeDelta;
        sizedelta.x -= segment;
        bar.sizeDelta = sizedelta;
        Vector2 newPosition = bar.anchoredPosition;
        newPosition.x -= move;
        bar.anchoredPosition = newPosition;
    }

}
