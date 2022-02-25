using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


[CreateAssetMenu(menuName = "ScriptableObjects/AudioStore")]
public class SoundScriptableOb : ScriptableObject
{
    [SerializeField] private AudioFiled[] audioFileds;

public AudioClip GetAudio(AudioType audioType)
    {
        return audioFileds.First(audio => audio.audioType == audioType).audioClip;
    }
}
public enum AudioType {door, knob, move, close, klock, menu, cat, no, win, street, button, send}


[Serializable]
public class AudioFiled
{
    public AudioType audioType;
    public AudioClip audioClip;
}

