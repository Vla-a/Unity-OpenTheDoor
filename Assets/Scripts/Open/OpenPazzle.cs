using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPazzle : MonoBehaviour
{
	[SerializeField] private GameObject playerCamera;
	[SerializeField] private GameObject camera;	

	private void OnTriggerEnter(Collider other)
	{
		playerCamera.SetActive(false);
		camera.SetActive(true);
		Cursor.lockState = CursorLockMode.None;		
	}
	private void OnTriggerExit(Collider other)
	{	
		playerCamera.SetActive(true);
		camera.SetActive(false);
		Cursor.lockState = CursorLockMode.Locked;
	}
}
