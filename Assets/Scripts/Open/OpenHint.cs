using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenHint : MonoBehaviour
{
    [SerializeField] Text textHint;
    [SerializeField] Text textTopic;
    private bool isActive;
    private void Update() 
    {
        StartCoroutine(correctTopic());
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isActive)
            {
                isActive = true;
                textHint.gameObject.SetActive(true);
            }
            else
            {
                isActive = false;
                textHint.gameObject.SetActive(false);
            }
           
        }
    }

    private IEnumerator correctTopic()
    {        
        yield return new WaitForSeconds(5f);
        textTopic.gameObject.SetActive(false);
    }
}
