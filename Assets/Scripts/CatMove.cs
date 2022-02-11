using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMove : MonoBehaviour
{
     
    [SerializeField] private GameObject play;
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    private AudioSource audioSource;
    private NavMeshAgent agent;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundScriptableOb.GetAudio(AudioType.cat);
    }
    void Update()
    {
        
        agent = GetComponent<NavMeshAgent>();
        agent.destination = play.transform.position;
        StartCoroutine(catSound());        
    }

    private IEnumerator catSound()
    {
        audioSource.Play();
        yield return new WaitForSeconds(5f);
        audioSource.Stop();
    }

}
