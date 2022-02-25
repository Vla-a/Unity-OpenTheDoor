using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPazzle : MonoBehaviour, Interaction
{
	[SerializeField] private GameObject playerCamera;
	[SerializeField] private GameObject camera;

    public void Interract()
    {
        playerCamera.SetActive(false);
		camera.SetActive(true);
		Cursor.lockState = CursorLockMode.None;
    }
}
