using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChange : MonoBehaviour
{
    public void scene1()
    {
        SceneManager.LoadScene("stage 1");
    }
    public void scene2()
    {
        SceneManager.LoadScene("gamescene");
    }
    
}
