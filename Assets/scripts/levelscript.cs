using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class levelscript : MonoBehaviour
{
    Image LevelImage;
    public Sprite[] spritearray;
    int index;
    
    private void Start()
    {
        LevelImage= GetComponent<Image>();
    }
    public void Right()
    {
        index++;
        if(index>spritearray.Length-1)
        {
            index = 0;
        }
        LevelImage.sprite = spritearray[index];
        SceneManager.LoadScene(index,LoadSceneMode.Additive);
        if(index==0)
        {
            SceneManager.UnloadSceneAsync(spritearray.Length - 1);
        }
        else
        SceneManager.UnloadSceneAsync(index - 1);
        
    }
    public void Left()
    {
        index--;
        if(index<0)
        {
            index = spritearray.Length-1;
        }
        LevelImage.sprite = spritearray[index];
        SceneManager.LoadScene(index,LoadSceneMode.Additive);
        if(index==spritearray.Length-1)
        {
            SceneManager.UnloadSceneAsync(0);
        }
        else
        SceneManager.UnloadSceneAsync(index+1);
    }
}
