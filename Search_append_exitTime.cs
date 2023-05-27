using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Search_append_exitTime : MonoBehaviour
{
    string filename = "";
    public InputField NoGameobject;
    public InputField ExitTimeGameobject;
    void Start()
    {
        filename = Application.persistentDataPath + "test.csv";
        //filename = Application.dataPath + "/test.csv";
    }
    public void appendExitTime()
    {
        string appendtime = ExitTimeGameobject.text;
        string no = NoGameobject.text;
        string[] data = File.ReadAllLines(filename);
        bool lineModified = false;
        for(int i = 0; i < data.Length; i++)
        {
            if (data[i].StartsWith(no))
            {
                data[i] = data[i] + appendtime;
                lineModified = true;
            }
        }

        if (lineModified)
        {

            File.WriteAllText(filename, string.Empty);
            File.AppendAllLines(filename, data);
            Debug.Log("appened");
        }
        else
        {
            Debug.Log("notfound");
        }
        NoGameobject.text = "";
        ExitTimeGameobject.text = "";

    }
 


}
