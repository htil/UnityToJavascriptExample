using System.Text;
using UnityEngine;
using System.Runtime.InteropServices;

public class uToJS : MonoBehaviour {

    [DllImport("__Internal")]
    private static extern void HelloString(byte[] str);

    public void HelloWorldCall() {
        string message = "Hello World!";
        byte[] utf8Bytes = Encoding.UTF8.GetBytes(message);
        HelloString(utf8Bytes);
    }
}
