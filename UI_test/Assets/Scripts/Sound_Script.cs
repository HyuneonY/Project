using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Script : MonoBehaviour
{
    private AudioSource music;
    public Slider sound;
    public static bool bCheck_Parameter = true;
    // Start is called before the first frame update
    void Start()
    {
        this.music = this.gameObject.GetComponent<AudioSource>();
        this.music.loop = false;
        music.volume = sound.value;
    }

    // Update is called once per frame
    void Update()
    {
        music.volume = sound.value;
    }

    public void MyCheckButtonScript()
    {
        if (bCheck_Parameter == true)
        {
            sound.value = 0;
            bCheck_Parameter = false;
        }
        else if (bCheck_Parameter == false)
        {
            sound.value = 1;
            bCheck_Parameter = true;
        }

        Debug.Log("My check button:" + bCheck_Parameter);
    }
}
