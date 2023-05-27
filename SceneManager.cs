using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{


    public GameObject DisplayGameobject;
    public GameObject EntrygGameobject;
    public GameObject MainWindowGameobject;
    public GameObject searchGameobject;
    // Start is called before the first frame update
    void Start()
    {
        MainWindowGameobject.SetActive(true);
        EntrygGameobject.SetActive(false);
        DisplayGameobject.SetActive(false);
        searchGameobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Display()
    {
        MainWindowGameobject.SetActive(false);
        EntrygGameobject.SetActive(false);
        DisplayGameobject.SetActive(true);
        searchGameobject.SetActive(false);
    }
    public void Entry()
    {
        MainWindowGameobject.SetActive(false);
        EntrygGameobject.SetActive(true);
        DisplayGameobject.SetActive(false);
        searchGameobject.SetActive(false);

    }
    public void search_no()
    {
        searchGameobject.SetActive(true);

        MainWindowGameobject.SetActive(false);
        EntrygGameobject.SetActive(false);
        DisplayGameobject.SetActive(false);
    }

}
