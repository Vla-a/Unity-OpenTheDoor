using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageActive : MonoBehaviour
{
    [SerializeField] private GameObject image;
    public void ImageActiv()
    {
        gameObject.SetActive(false);
        image.gameObject.SetActive(true);
    }
}
