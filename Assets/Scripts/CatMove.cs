using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMove : MonoBehaviour
{
     
    [SerializeField] private GameObject play;
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    [SerializeField] private float distanse;
    private AudioSource audioSource;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundScriptableOb.GetAudio(AudioType.cat);
    }
    void Update()
    {     
        agent.destination = play.transform.position;

        if(Vector3.Distance(play.transform.position, agent.transform.position) <= distanse)
        {
            StartCoroutine(catSound());
        }
               
    }

    private IEnumerator catSound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(5f);
        audioSource.Stop();
    }

}
