using UnityEngine;

public class mousespawner : MonoBehaviour
{
    public GameObject mouse;
    public GameObject spawn;
    public void SpawnMouse(ref float time, float rate, ref int spawns)
    {
        if (time >= rate)
        {
            GameObject mouseClone = Instantiate(mouse,
spawn.transform.position, spawn.transform.rotation);
            time = 0;
            mouseClone.SetActive(true);
            spawns++;
        }
    }
}