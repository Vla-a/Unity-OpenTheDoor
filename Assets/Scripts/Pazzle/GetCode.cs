using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCode : MonoBehaviour
{
    //[SerializeField] private GameObject imageOne;
    //[SerializeField] private GameObject pazzleOne;
    //[SerializeField] private GameObject imageTwo;
    //[SerializeField] private GameObject pazzleTwo;
    //[SerializeField] private GameObject imageThree;
    //[SerializeField] private GameObject pazzleThree;
    //[SerializeField] private GameObject imageFour;
    //[SerializeField] private GameObject pazzleFour;
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject pazzle;
    [SerializeField] private GameObject passwordnamber;
    private int fullElement;
    public static int myElement;
    private int count = 0;
    void Start()
    {
        fullElement = image.transform.childCount;
    }
    
    void Update()
    {
      if(fullElement == myElement)
        {
            passwordnamber.SetActive(true);
        }
        //CodeResult(imageOne, pazzleOne);
        //CodeResult(imageTwo, pazzleTwo);
        //CodeResult(imageThree, pazzleThree);
        //CodeResult(imageFour, pazzleFour);
    }

    public static void AddElement()
    {        
        myElement++;
        Debug.Log(myElement);
    }
    //private void CodeResult(GameObject image, GameObject pazzle)
    //{
    //    if (Mathf.Abs(image.transform.position.x - pazzle.transform.position.x) <= 5f &&
    //             Mathf.Abs(image.transform.position.y - pazzle.transform.position.y) <= 5f)
    //    {
    //        count++;
    //        Debug.Log(count);
    //    }
    //}
}
