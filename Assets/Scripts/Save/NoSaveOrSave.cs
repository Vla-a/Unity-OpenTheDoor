using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoSaveOrSave 
{
    public static bool isSave;

    public static void Saver()
    {
        isSave = true;
    }
    public static void NoSaver()
    {
        isSave = false;
    }
}
