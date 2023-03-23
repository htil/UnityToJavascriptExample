using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
   
    public GameObject prefabDino;  // The prefab to be spawned
    [SerializeField] TMP_Text tField;


    public void SpawnPrefabRandomColor()
    {

        float r = Random.Range(0f, 255f) / 255f;
        float g = Random.Range(0f, 255f) / 255f;
        float b = Random.Range(0f, 255f) / 255f;

        float transformX = Random.Range(-10f, 10f);

        Vector3 newTransform = new Vector3(transform.position.x + transformX, transform.position.y, transform.position.z);
        
        GameObject newDino = Instantiate(prefabDino, newTransform, transform.rotation);
        newDino.GetComponent<SpriteRenderer>().color = new Color(r, g, b);
        
        Debug.Log(transform.position);
    }
    
    public void SpawnPrefabByColorName(string value)
    {
        if (ColorUtility.TryParseHtmlString(value, out Color color))
        {
            GameObject newDino = Instantiate(prefabDino, transform.position, transform.rotation);
            newDino.GetComponent<SpriteRenderer>().color = color;
        }
            
        Debug.Log(transform.position);
    }
    public void SpawnPrefabByColorRGB(string values)
    {
        
        Debug.Log("RGB values: " + values);
        string[] rgb = values.Split(',');
        float r = float.Parse(rgb[0]) / 255f;
        float g = float.Parse(rgb[1]) / 255f;
        float b = float.Parse(rgb[2]) / 255f;

        GameObject newDino = Instantiate(prefabDino, transform.position, transform.rotation);
        newDino.GetComponent<SpriteRenderer>().color = new Color(r, g, b);
        
        Debug.Log(transform.position);
    }

    public IEnumerator makeItRain()
    {
        for (int i = 0; i < 1000; i++)
        {
            yield return new WaitForSeconds(0.1F);
            SpawnPrefabRandomColor();
        }
    }

}
