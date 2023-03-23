using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableWebGLKeyboardCapture : MonoBehaviour
{
    public int clickCount = 0;
    // Start is called before the first frame update
    public void DisableEnableTypingOutsideOfUnity()
    {
       #if !UNITY_EDITOR && UNITY_WEBGL
        if (clickCount % 2 == 0){
            // disable WebGLInput.captureAllKeyboardInput so elements in web page can handle keyboard inputs
            WebGLInput.captureAllKeyboardInput = false;
        }   
        else{
            // enable WebGLInput.captureAllKeyboardInput so elements in Unity can handle keyboard inputs
            WebGLInput.captureAllKeyboardInput = true;
        }
        clickCount++;
        #endif
    }

}
