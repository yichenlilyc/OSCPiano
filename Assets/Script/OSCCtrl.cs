using UnityEngine;
using extOSC;

public class OSCCtrl : MonoBehaviour
{
    OSCReceiver osc;
    

    void Start()
    {
        osc = this.gameObject.AddComponent<OSCReceiver>();
        osc.Bind("/accxyz", onMessage);
    }

    void Update(float x, float y, float z)
    {
        // osc.Bind("/accxyz", onMessage);
        /*this.gameObject.transform.Rotate(
            x, y, z
        );*/
        this.gameObject.transform.eulerAngles = new Vector3(x*30, y*30, z*30);
    }

    void onMessage(OSCMessage msg)
    {
        Debug.LogFormat("msg {0}", msg);

        float x = msg.Values[0].FloatValue;
        float y = msg.Values[1].FloatValue;
        float z = msg.Values[2].FloatValue;

        float xf = Mathf.Round(x);
        float yf = Mathf.Round(y);
        float zf = Mathf.Round(z);

        /*this.gameObject.transform.Rotate(
            msg.Values[0].FloatValue,
            msg.Values[1].FloatValue,
            msg.Values[2].FloatValue
        );*/

        Update(y,z,-x);

    }
}