using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectToScen : MonoBehaviour
{
    [SerializeField] SaveGame saveGame;
    [SerializeField] List<ImageActive> pref;
    [SerializeField] private SoundScriptableOb soundScriptableOb;
    private AudioSource audioSource;
    public List<TypeNumber> spamObjects = new List<TypeNumber>();
    void Start()
    {
        if (!NoSaveOrSave.isSave)
        {
            saveGame.LoadSave();
            for (int i = 0; i < spamObjects.Count; i++)
            {
                int index = pref.FindIndex((t) => t.typeItem == spamObjects[i]);               
                ImageActive pawnObject = Instantiate(pref[index]);
                
            }
        }
        else
        {
            for (int i = 0; i < pref.Count; i++)
            {
                ImageActive pawnObject = Instantiate(pref[i]);
                spamObjects.Add(pawnObject.typeItem);              
            }
        }
        audioSource = GetComponent<AudioSource>();
        GameController.Instance.ImageVisible += RemoveListPref;      
    }

 

    public void RemoveListPref(TypeNumber type)
    {
        audioSource.PlayOneShot(soundScriptableOb.GetAudio(AudioType.send));
        int index = spamObjects.FindIndex((t) => t == type);
        spamObjects.Remove(spamObjects[index]);       
    }
 

    private void OnDestroy()
    {
        GameController.Instance.ImageVisible -= RemoveListPref;       
    }

}
