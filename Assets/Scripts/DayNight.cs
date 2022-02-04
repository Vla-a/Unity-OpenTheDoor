using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    [SerializeField] private GameObject directionalLight;
    [SerializeField] private int dayTime;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        directionalLight.transform.Rotate(Vector3.right * dayTime * Time.deltaTime);
    }
}
