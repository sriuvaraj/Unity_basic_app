using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class rowCanvas : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private TMP_Text sno;
    [SerializeField] private TMP_Text Name;
    [SerializeField] private TMP_Text email;
    [SerializeField] private TMP_Text phono;
    [SerializeField] private TMP_Text in_time;
    [SerializeField] private TMP_Text out_time;

    public string snoValue
    {
        get => sno.text;
        set => sno.text = value;

    }

    public string NameValue
    {
        get => Name.text;
        set => Name.text = value;

    }
    public string emailValue
    {
        get => email.text;
        set => email.text = value;

    }
    public string PhValue
    {
        get => phono.text;
        set => phono.text = value;

    }
    public string in_timeValue
    {
        get => in_time.text;
        set => in_time.text = value;

    }
    public string out_timeValue
    {
        get => out_time.text;
        set => out_time.text = value;

    }

}
