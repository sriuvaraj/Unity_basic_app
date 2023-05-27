using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class CSVReader : MonoBehaviour
{
    // Start is called before the first frame update
    string filename = "";

    public GameObject dest;
    public RectTransform _content;
    public GameObject prefab;

    public int rowCount=0;
    void Start()
    {
        filename = Application.persistentDataPath+ "test.csv";
        //filename = Application.dataPath+ "/test.csv";
    }

    private rowCanvas CreateItem(string sno, string name, string email, string phNo, string inTime, string out_Time)
    {
        GameObject gobj;
        rowCanvas item;

        gobj = Instantiate(prefab, Vector3.zero, Quaternion.identity);
        gobj.transform.SetParent(_content);
        gobj.transform.localScale = new Vector3(1f, 1f, 1f);
        gobj.transform.localPosition = new Vector3();
        gobj.transform.localRotation = Quaternion.Euler(new Vector3());
        item = gobj.GetComponent<rowCanvas>();
        item.snoValue = sno;
        item.NameValue = name;
        item.emailValue = email;
        item.PhValue = phNo;
        item.in_timeValue = inTime;
        item.out_timeValue = out_Time;
        return item;
    }



    public void display()
    {
        string[] data = File.ReadAllLines(filename);
        rowCount = data.Length;
        for (int i = 0; i < data.Length; i++)
        {
            string[] datas = data[i].Split(new string[] { ",", "\n" }, System.StringSplitOptions.None);
            Debug.Log("datas length" + datas.Length + "\n" + datas[1]);
            CreateItem(datas[0], datas[1],datas[2],datas[3],datas[4],datas[5]);
           
        }
    }
       

    public void emptyDisplay()
    {
        
        foreach (Transform obj in _content)
        {

            Destroy(obj.gameObject);
        }
    }

}

