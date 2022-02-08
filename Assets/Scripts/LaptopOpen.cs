using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopOpen : MonoBehaviour
{
	[SerializeField] private GameObject playerCamera;
	[SerializeField] private GameObject camera;
	[SerializeField] private Animator _LaptopOpen;	
	public bool _isOpened;
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject gameObject;


	void Start()
	{
		_isOpened = false;
	}

	void OnMouseOver()
	{
		{
			if (player)
			{
				float dist = Vector3.Distance(player.transform.position, transform.position);
				if (dist < 15)
				{
					if (_isOpened == false)
					{
						
						if (Input.GetMouseButtonDown(0))
						{							
							StartCoroutine(opening());
						}
					}
					else
					{
						if (_isOpened == true)
						{
							if (Input.GetMouseButtonDown(0))
							{
								StartCoroutine(closing());
							}
						}

					}

				}
			}

		}

	}
	public void ClosingLaptop()
    {
		StartCoroutine(closing());
	}
	IEnumerator opening()
	{
		print("you are opening the laptop");		
		_LaptopOpen.Play("CloseLaptop");	
		_isOpened = true;		
		playerCamera.SetActive(false);
		camera.SetActive(true);
		yield return new WaitForSeconds(2f);
		gameObject.SetActive(true);
		player.GetComponent<FirstPersonController>().enabled = false;
		Cursor.lockState = CursorLockMode.None;
	}

	IEnumerator closing()
	{
		Cursor.lockState = CursorLockMode.Locked;
		gameObject.SetActive(false);
		playerCamera.SetActive(true);
		camera.SetActive(false);
		yield return new WaitForSeconds(.8f);
		print("you are closing the laptop");
		_LaptopOpen.Play("OpenLaptop");
		_isOpened = false;
		player.GetComponent<FirstPersonController>().enabled = true;
	}
}
