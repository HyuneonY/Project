using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    [SerializeField] private InputField Name_Input;
    [SerializeField] private InputField Password_Input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyInputField_Name()
    {
        Debug.Log("이름을 입력했습니다.");
        if(Name_Input.text == "YANG")
        {
            Debug.Log("존재하는 ID 입니다.");
        }
    }
    public void MyInputField_Password()
    {
        Debug.Log("암호를 입력했습니다.");
        if (Name_Input.text == "1234")
        {
            Debug.Log("암호가 일치합니다.");
        }
    }
    public void MyButtonScript()
    {
        SceneManager.LoadScene("Start");
    }
}
