using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class SaveGame : MonoBehaviour
{    
    [SerializeField] private GameObject plaer;
    [SerializeField] private GameObject[] images;
    [SerializeField] private SetObjectToScen objectToScen; 
    private ScenObject scenObject = new ScenObject(); 
    public string path;

    private void Awake()
    {
     
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {          
             
            Save();            
        }
      
    }
    private void Start()
    {
        
        path = Path.Combine(Application.persistentDataPath + "playsave.txt");
       
    }

    public void Save()
    {      

        scenObject.playerPosition = plaer.gameObject.transform.position;
        scenObject.rotation = plaer.gameObject.transform.rotation;
        for (int i = 0; i < images.Length; i++)
        {
            scenObject.isBoolImage[i] = images[i].activeSelf;          
        }
        scenObject.cubeNumber.Clear();
        for (int i = 0; i < objectToScen.spamObjects.Count; i++)
        {
            scenObject.cubeNumber.Add(objectToScen.spamObjects[i].ToString());          
        }
       
        string jsonString = JsonUtility.ToJson(scenObject);
        //Debug.Log(jsonString);
        File.WriteAllText(path,jsonString);
      
    }

    public void  LoadSave()
    {
        if (File.Exists(path))
        {
            string fileScenObject = File.ReadAllText(path);          
            ScenObject _scenObject = JsonUtility.FromJson<ScenObject>(fileScenObject);

            plaer.transform.position = _scenObject.playerPosition;
            plaer.transform.rotation = _scenObject.rotation;
            for (int i = 0; i < scenObject.isBoolImage.Length; i++)
            {
                images[i].active = _scenObject.isBoolImage[i];
                Debug.Log(images[i].active);
            }
            for (int i = 0; i < _scenObject.cubeNumber.Count; i++)
            {
                switch (_scenObject.cubeNumber[i])
                {
                    case "NumberOne":
                        objectToScen.spamObjects.Add(TypeNumber.NumberOne);
                        break;
                    case "NumberTwo":
                        objectToScen.spamObjects.Add(TypeNumber.NumberTwo);                        
                        break;              
              
                }                
            }          
        }
    }

}

[System.Serializable]
public class ScenObject
{
    public Vector3 playerPosition;
    public Quaternion rotation;
    public bool[] isBoolImage = new bool[4];
    public List<string> cubeNumber = new List<string>(); 
}


