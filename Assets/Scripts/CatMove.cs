using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatMove : MonoBehaviour
{
    [SerializeField] private GameObject pointOne;
    [SerializeField] private GameObject pointTwo;
    [SerializeField] private GameObject play;
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    [SerializeField] private float distanse;
    private AudioSource audioSource;
    private NavMeshAgent agent;
    private Animator _animator;
    private int count = 0;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = soundScriptableOb.GetAudio(AudioType.cat);
        agent.destination = pointOne.transform.position;
    }
    void Update()
    {
        switch (count)
        {
            case 0:               
                
                if (agent.remainingDistance <= distanse)
                {
                    StartCoroutine(catSound());
                    agent.destination = pointTwo.transform.position;
                    count = 1;
                }
                break;
            case 1:
               
                if (agent.remainingDistance <= distanse)
                {
                    StartCoroutine(catSound());
                    agent.destination = pointOne.transform.position;
                    count = 0;
                }
                break;
        } 

    }
    private IEnumerator catSound()
    {
        audioSource.Play();
        _animator.SetTrigger("Sit");
        yield return new WaitForSeconds(0.5f);
        _animator.SetTrigger("Walk");
        yield return new WaitForSeconds(1f);
        audioSource.Stop();
        
    }

}
