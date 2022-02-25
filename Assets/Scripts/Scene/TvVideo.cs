using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TvVideo : MonoBehaviour
{
	[SerializeField] private VideoPlayer video;
		public bool _isOpened;
	[SerializeField] private Transform Player;


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
				if (dist < 3)
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

	IEnumerator opening()
	{
		print("you are opening the laptop");
		video.Play();
		
		_isOpened = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the laptop");
		video.Stop();

		_isOpened = false;
		yield return new WaitForSeconds(.5f);
	}
}
