using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class player2OSC : MonoBehaviour {

    public GameObject particle;
    public OSCReceiver _receiver;
	// Use this for initialization
	void Start () {
        _receiver = this.gameObject.AddComponent<OSCReceiver>();

        // Set local port.
        _receiver.LocalPort = 6000;

        // Bind "MessageReceived" method to special address.
        _receiver.Bind("/2/push13", onMessage1);
        _receiver.Bind("/2/push14", onMessage2);
        _receiver.Bind("/2/push15", onMessage3);
        _receiver.Bind("/2/push16", onMessage4);
    }
	
    void onMessage1(OSCMessage msg){
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1){
            GameObject o= Instantiate(particle, new Vector3(0.31f, -3f, 0), transform.rotation);
            Destroy(o, 0.5f);
        }
    }

    void onMessage2(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            GameObject o=Instantiate(particle, new Vector3(2.31f, -1.5f, 0), transform.rotation);
            Destroy(o, 0.5f);
        }
    }

    void onMessage3(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            GameObject o= Instantiate(particle, new Vector3(4.31f, -1f, 0), transform.rotation);
            Destroy(o, 0.5f);
        }
    }

    void onMessage4(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;

        int xInt = Mathf.RoundToInt(x);

        if (xInt == 1)
        {
            GameObject o= Instantiate(particle, new Vector3(6.31f, -2.2f, 0), transform.rotation);
            Destroy(o, 0.5f);
        }
    }
}
