using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayNight : MonoBehaviour
{
    [SerializeField] private GameObject directionalLight;
    [SerializeField] private int dayTime;
    [SerializeField] private Material nightSkybox;
    [SerializeField] private Material daySkybox;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        directionalLight.transform.Rotate(Vector3.right * dayTime * Time.deltaTime);

    }

    // assign via inspector
    private void Update()
    {
        if (directionalLight.transform.rotation.x > 0f)            
            RenderSettings.skybox = nightSkybox;
        else
            RenderSettings.skybox = daySkybox;
    } 
}
