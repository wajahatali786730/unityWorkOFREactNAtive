using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class watchSelect : MonoBehaviour
{


    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;
    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    // Start is called before the first frame update
    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    // Update is called once per frame

     public void WatchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowAnimation["w1anim"].speed = 1;
        w1WindowAnimation.Play();


    }

    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnimation["w2anim"].speed = 1;
        w2WindowAnimation.Play();
    }

    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        w3WindowAnimation["w3anim"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "w1close")
        {
            //play the animation
            w1WindowAnimation["w1anim"].speed = -1;
            w1WindowAnimation["w1anim"].time = w1WindowAnimation["w1anim"].length;
            w1WindowAnimation.Play();
        }

      else if (buttonName == "w2close")
        {
            //play the animation
            w2WindowAnimation["w2anim"].speed = -1;
            w2WindowAnimation["w2anim"].time = w2WindowAnimation["w2anim"].length;
            w2WindowAnimation.Play();
        }

        else if (buttonName == "w3close")
        {
            //play the animation

            w3WindowAnimation["w3anim"].speed = -1;
            w3WindowAnimation["w3anim"].time = w3WindowAnimation["w3anim"].length;
            w3WindowAnimation.Play();
        }
    }    
}
