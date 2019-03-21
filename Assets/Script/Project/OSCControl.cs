
using UnityEngine;
using UnityEngine.UI;
using extOSC;
using System.Collections;
using System.Collections.Generic;

public class OSCControl : MonoBehaviour {

    public OSCReceiver _receiver;
    //public GameObject cube;
   
    public GameObject basicBlock;
    public GameObject black;
    public GameObject white;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five; 
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;
    public GameObject gameobject;
    public GameObject partical1;
    public GameObject trigger;
    public GameObject triggerBl;

    GameObject a;
    GameObject b;
    public Text countText;
    private int count;

    int step =1;
    AudioSource myAudio;

    private float h=-4;
    private float x = 0;
    int index = 0;
    int[] notes = { 2, 2, 5, 2, 2, 5, 2, 5, 10, 12, 10, 9, 7, 7, 5, 2, 2, 3, 12, 12, 2, 3, 12, 2, 9, 7, 5, 3, 2,
            2, 2, 5, 2, 2, 5, 2, 5, 10, 12, 2, 12, 10, 10, 7, 3, 3, 10, 9, 7, 5, 5, 2, 2, 5, 3, 2, 12, 10};

    private float time = 0.0f;
   

    void Start()
    {
        _receiver = this.gameObject.AddComponent<OSCReceiver>();

        // Set local port.
        _receiver.LocalPort = 8000;

        // Bind "MessageReceived" method to special address.
        _receiver.Bind("/1/push1", onMessage1);
        _receiver.Bind("/1/push2", onMessage2);
        _receiver.Bind("/1/push3", onMessage3);
        _receiver.Bind("/1/push4", onMessage4);
        _receiver.Bind("/1/push5", onMessage5);
        _receiver.Bind("/1/push6", onMessage6);
        _receiver.Bind("/1/push7", onMessage7);
        _receiver.Bind("/1/push8", onMessage8);
        _receiver.Bind("/1/push9", onMessage9);
        _receiver.Bind("/1/push10", onMessage10);
        _receiver.Bind("/1/push11", onMessage11);
        _receiver.Bind("/1/push12", onMessage12);

        myAudio = GetComponent<AudioSource>();
        myAudio.volume = 0;


        //two =Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);

        for (int i = 0; i < 58;i++){
            index = i;

            //h += 2;
            if (index == 0 || index == 1 || index == 3 || index == 4 || index == 6 || index == 16 ||
                index == 20 || index == 23 || index == 28 || index == 29 || index == 30 || index == 32 || index == 33 ||
                index == 35 || index == 39 || index == 51 || index == 52 || index == 55)
            {
                x = 5.31f;
                if (index == 28)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        h += step;
                        two = Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                        two.transform.parent = gameobject.transform;
                    }

                }
                if(index==39||index==51||index==55)
                {
                    for (int j = 0; j < 1; j++)
                    {

                        h += step;
                        two = Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                        two.transform.parent = gameobject.transform;
                    }
                }
                h += step;
               
                two=Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                two.transform.parent = gameobject.transform;
               // Instantiate(black, transform.position, transform.rotation);

            }

            else if (index == 17 || index == 21 || index == 27 || index == 44 || index == 45 || index == 54)
            {
                x = 4.96f;
                if (index == 21)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        h += step;
                        three = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        three.transform.parent = gameobject.transform;
                    }

                }
                if(index==17||index==27||index==54)
                {
                    for (int j = 0; j < 1; j++)
                    {

                        h += step;
                        three = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        three.transform.parent = gameobject.transform;
                    }
                }
                h += step;
                three = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                three.transform.parent = gameobject.transform;
                //three = Instantiate(black, transform.position, transform.rotation);
            }

            else if (index == 2 || index == 5 || index == 7 || index == 14 || index == 26 || index == 31 || index == 34 ||
                    index == 26 || index == 31 || index == 34 || index == 36 || index == 49 || index == 50 || index == 53)
            {
                x = 4.31f;
                if (index==2||index==5||index==31||index==34)
                {
                   
                    for (int j = 0; j < 3;j++){
                        h += step;
                        five = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        five.transform.parent = gameobject.transform;
                    }
                   
                }
                if(index==14||index==26||index==50)
                {
                    for (int j = 0; j < 1; j++)
                    {

                        h += step;
                        five = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        five.transform.parent = gameobject.transform;
                    }
                }
                h += step; 
                five = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                five.transform.parent = gameobject.transform;

                
                // five = Instantiate(black, transform.position, transform.rotation);
            }

            else if (index == 12 || index == 13 || index == 25 || index == 43 || index == 48)
            {
                x = 3.31f;
                if (index==13||index==43)
                {
                    for (int j = 0; j < 1; j++)
                    {

                        h += step;
                        seven = Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                        seven.transform.parent = gameobject.transform;
                    }
                }
                h += step;
           
                seven = Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                seven.transform.parent = gameobject.transform;
                // seven = Instantiate(black, transform.position, transform.rotation);
            }

            else if (index == 11 || index == 24 || index == 47)
            {
                x = 2.66f;
                h += step;
               
                nine = Instantiate(black, new Vector3(x, h, 0), Quaternion.identity);
                nine.transform.parent = gameobject.transform;
                // nine = Instantiate(black, transform.position, transform.rotation);
            }

            else if (index == 8 || index == 10 || index == 37 || index == 41 || index == 42 || index == 46 || index == 57)
            {
                x = 2.31f;
                if (index == 46)
                {
                    for (int j = 0; j < 2; j++)
                    {
                      
                        h += step;
                        ten = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        ten.transform.parent = gameobject.transform;
                    }

                }
                if (index==10||index==42||index==57)
                {
                    for (int j = 0; j < 1;j++)
                    {
                     
                        h += step;
                        ten = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        ten.transform.parent = gameobject.transform;
                    }
                }
                h += step;
      
                ten= Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                ten.transform.parent = gameobject.transform;
                // ten = Instantiate(black, transform.position, transform.rotation);
            }

            else if (index == 9 || index == 15 || index == 18 || index == 19 || index == 22 || index == 38 || index == 40 || index == 56)
            {
                x = 1.66f;
                if(index==18||index==56)
                {
                    for (int j = 0; j < 1; j++)
                    {

                        h += step;
                        twelve = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                        twelve.transform.parent = gameobject.transform;
                    }
                }
                h += step;
              
                twelve = Instantiate(white, new Vector3(x, h, 0), Quaternion.identity);
                twelve.transform.parent = gameobject.transform;
                //twelve = Instantiate(black, transform.position, transform.rotation);
            }
        }

    }

    //Update();

    void Update()
    {
        //myAudio.Play();
        gameobject.transform.Translate(0,-Time.deltaTime*2.15f,0);

    }


    void onMessage1(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt==1){
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            Destroy(one);
        }
    }
    void onMessage2(OSCMessage msg)
    {

        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(5.31f, -3.7f, 0), Quaternion.identity);
            b = Instantiate(triggerBl, new Vector3(5.31f, -4f, 0), Quaternion.identity);

            b.transform.parent = this.transform;
            //OnTriggerEnter(Collider other);
            //private void OnTriggerEnter(Collider other)
            //{
            //    if (other.gameObject.CompareTag("block"))
            //    {
            //        other.gameObject.SetActive(false);
            //        //count++;
            //        //SetCountText();
            //    }
            //}
            //count++;
            //SetCountText();
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            //Destroy(g, 0.4f);
            //Destroy(o, 0.4f);
            if (two.transform.position.y > -3.58 && two.transform.position.y < -2.9)
            {
                Destroy(two);

            }

        }
        if(xInt==0){
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
       
    void onMessage3(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(4.96f, -3.7f, 0), transform.rotation);
            b = Instantiate(trigger, new Vector3(4.96f, -4f, 0), Quaternion.identity);

            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            //count++;
            //SetCountText();
            if (three.transform.position.y > -3.58 && three.transform.position.y < -2.9)
            {
                Destroy(three);
            }
        }
        if(xInt==0){
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
    void onMessage4(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            Destroy(four);
        }
    }
    void onMessage5(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(4.31f, -3.7f, 0), transform.rotation);
            b = Instantiate(trigger, new Vector3(4.31f, -4f, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            //count++;
            //SetCountText();
            if (five.transform.position.y > -3.58 && five.transform.position.y < -2.9)
            {
                Destroy(five);
            }
        }
        if (xInt == 0)
        {
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
    void onMessage6(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            Destroy(six);
        }
    }
    void onMessage7(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(3.31f, -3.7f, 0), transform.rotation);
            b = Instantiate(triggerBl, new Vector3(3.31f, -4f, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            //count++;
            //SetCountText();
            if (seven.transform.position.y > -3.58 && seven.transform.position.y < -2.9)
            {
                Destroy(seven);
                Destroy(a);
                Destroy(b);
            }
        }
        if (xInt == 0)
        {
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
    void onMessage8(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            Destroy(eight);
        }
    }
    void onMessage9(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(2.66f, -3.7f, 0), transform.rotation);
            b = Instantiate(triggerBl, new Vector3(2.66f, -4f, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            // count++;
            //SetCountText();
            if (nine.transform.position.y > -3.58 && nine.transform.position.y < -2.9)
            {
                Destroy(nine);
            }
        }
        if (xInt == 0)
        {
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
    void onMessage10(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(2.31f, -3.7f, 0), transform.rotation);
            b = Instantiate(trigger, new Vector3(2.31f, -4f, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a, 1.5f);
            Destroy(b, 1.5f);
            //count++;
            //SetCountText();
            if (ten.transform.position.y > -3.58 && ten.transform.position.y < -2.9)
            {
                Destroy(ten);
            }
        }
        if (xInt == 0)
        {
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }
    void onMessage11(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            //two=Instantiate(one, new Vector3(2, 2, 0), Quaternion.identity);
            Destroy(eleven);
        }
    }
    void onMessage12(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            a = Instantiate(partical1, new Vector3(1.66f, -3.7f, 0), transform.rotation);
            b = Instantiate(trigger, new Vector3(1.66f, -4f, 0), Quaternion.identity);
            myAudio.volume = 1;
            Destroy(a,1.5f);
            Destroy(b,1.5f);
            //count++;
            //SetCountText();
            if (twelve.transform.position.y > -3.58 && twelve.transform.position.y < -2.9)
            {
                Destroy(twelve);
            }
        }
        if (xInt == 0)
        {
            myAudio.volume = 0;
            Destroy(a);
            Destroy(b);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("block"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score:" + count.ToString();
    }




}
