using UnityEngine;
using UnityEngine.Video;

public class OnOffTvScript : MonoBehaviour
{

    [SerializeField] public VideoPlayer video;
    public Transform Player;
    public bool IsPlaying = false;



    void OnMouseOver()
    {
        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 3)
            {
                print("tv");
                if (Input.GetMouseButtonDown(0))
                {
                    print("on tv");
                    IsPlaying = !IsPlaying;
                }

                if (IsPlaying)
                {
                    video.Play();
                }
                else
                {
                    video.Stop();
                }

            }
        }

    }

}
