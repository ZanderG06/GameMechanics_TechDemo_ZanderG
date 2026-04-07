using UnityEngine;

public class RaveRoom : MonoBehaviour
{
    private int wait = 0;

    private void Update()
    {   
        wait++;

        if(wait == 120)
        {
            float r = Random.Range(0f, 10f);
            float g = Random.Range(0f, 10f);
            float b = Random.Range(0f, 10f);

            GetComponent<Renderer>().material.color = new Color(r, g, b, 0);
            wait = 0;
        }
    }
}
