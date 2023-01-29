using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JavascriptHook : MonoBehaviour
{
    [SerializeField] private SpriteRenderer circleSpriteRenderer;

    public void TintRed()
    {
        circleSpriteRenderer.color = Color.red;
    }

    public void TintGreen()
    {
        circleSpriteRenderer.color = Color.green;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TintRed();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            TintGreen();
        }
    }
}
