using UnityEngine;

public class WaveCreator : MonoBehaviour
{
    public int[] waves; //const
    public float timeInterval; //const
    public int kills = 0; //var
    public int totalKills = 0;
    float timer = 0; // time per mouse spawn
    float timer2 = 0; // time per wave spawn
    float mainTimer = 0;
    int currWave = 0; //var
    public int miceSpawned = 0; //var
    public float[] perWaveTime; //const
    public int totalMice;
    bool levelEnd = false;
    

    // Update is called once per frame
    void Update()
    {
        mainTimer += Time.deltaTime;
       
        
        
        if (!levelEnd)
        {
            timer2 += Time.deltaTime;
            if (miceSpawned < waves[currWave])
            {
                timer += Time.deltaTime;
                GetComponent<mousespawner>().SpawnMouse(ref timer,
timeInterval, ref miceSpawned);
            }

            if (currWave == waves.Length - 1 && (timer2 >=
perWaveTime[currWave] || totalKills == totalMice))
            {
                levelEnd = true;
                Actions.gamewon();
            }
            else if ((kills == waves[currWave] || timer2 >=
perWaveTime[currWave]) && currWave < waves.Length - 1)
            {
                currWave++;
                kills = 0;
                timer = 0;
                timer2 = 0;
                miceSpawned = 0;
            }

        }
        

    }


}