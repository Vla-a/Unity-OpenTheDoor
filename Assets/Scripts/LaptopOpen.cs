using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopOpen : MonoBehaviour
{
	[SerializeField] private Animator _LaptopOpen;	
	public bool _isOpened;
	[SerializeField] private Transform Player;
	[SerializeField] private GameObject gameObject;


	void Start()
	{
		_isOpened = false;
	}

	void OnMouseOver()
	{
		{
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
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
		yield return new WaitForSeconds(.8f);
		gameObject.SetActive(true);
	}

	IEnumerator closing()
	{
		gameObject.SetActive(false);		
		yield return new WaitForSeconds(.8f);
		print("you are closing the laptop");
		_LaptopOpen.Play("OpenLaptop");
		_isOpened = false;
	}
}
