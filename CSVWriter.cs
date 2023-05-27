using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class CSVWriter : MonoBehaviour
{
    // Start is called before the first frame update

    string filename = "";


    public InputField dataField;
    public InputField nameField;
    public InputField emailField;
    public InputField phnoField;
    public InputField entryTimeField;
    public InputField exitTimeField;

    void Start()
    {
        filename = Application.persistentDataPath + "test.csv";
        //filename = Application.dataPath + "/test.csv";
        if (!File.Exists(filename))
        {   
            File.Create(filename);
            TextWriter tw = new StreamWriter(filename, false);
            tw.WriteLine("User data, Name, Email, Phno, EntryTime, ExitTime");
            tw.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void submit()
    {

        string data = dataField.text;
        string name = nameField.text;
        string email = emailField.text;
        string phno = phnoField.text;
        string entryTime = entryTimeField.text;
        string exitTime = exitTimeField.text;


        TextWriter tw1 = new StreamWriter(filename, true);
        tw1.WriteLine(data + "," + name + "," + email + "," + phno + "," + entryTime + "," + exitTime);
        tw1.Close();
        dataField.text = "";
        nameField.text = "";
        emailField.text = "";
        phnoField.text = "";
        entryTimeField.text = "";
        exitTimeField.text = "";



    }
}
