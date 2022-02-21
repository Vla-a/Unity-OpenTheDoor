using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SaveGame : MonoBehaviour
{
    [SerializeField] private GameObject plaer;
    [SerializeField] private GameObject[] images;
    private ScenObject scenObject = new ScenObject();

    public string path;
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
       
        if(!NoSaveOrSave.isSave)
        LoadSave();
    }

    public void Save()
    {
        scenObject.playerPosition = plaer.gameObject.transform.position;
        scenObject.rotation = plaer.gameObject.transform.rotation;
        for (int i = 0; i < images.Length; i++)
        {
            scenObject.isBoolImage[i] = images[i].activeSelf;          
        }

        string jsonString = JsonUtility.ToJson(scenObject);
        //Debug.Log(scenObject.playerPosition);
        File.WriteAllText(path,jsonString);
        Debug.Log(jsonString);
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
}
		
