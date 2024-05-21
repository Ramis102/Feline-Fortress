using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimeOfDay : MonoBehaviour
{
    // Start is called before the first frame update
    public float secondsPerMinute = 0.625f;
    public float startTime = 12f;
    public float latitudeAngle = 45f;
    public Transform sunTilt;

    private float day, minute, smoothMin, texOffset;
    private Material skyMat;
    private Transform sunOrbit;

    void Start()
    {
        skyMat = GetComponent<Renderer>().sharedMaterial;
        sunOrbit = sunTilt.GetChild(0);
        sunTilt.Rotate(Mathf.Clamp(latitudeAngle, 0, 90),
sunTilt.eulerAngles.y, sunTilt.eulerAngles.z);
    }

    void UpdateSky()
    {
        smoothMin = (Time.time / secondsPerMinute) + (startTime * 60);
        day = Mathf.Floor(smoothMin / 1440) + 1;
        smoothMin = smoothMin - (Mathf.Floor(smoothMin / 1440) * 1440);
        smoothMin = Mathf.Round(smoothMin);
        sunOrbit.Rotate(sunOrbit.eulerAngles.x, smoothMin / 4,
sunOrbit.eulerAngles.z);
        texOffset = Mathf.Cos((((smoothMin) / 1440) * 2) * Mathf.PI) *
0.25f + 0.25f;
        skyMat.mainTextureOffset = new Vector2(Mathf.Round((texOffset
- (Mathf.Floor(texOffset / 360) * 360)) * 1000) / 1000, 0);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSky();
    }
}