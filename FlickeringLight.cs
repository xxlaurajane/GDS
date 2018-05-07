using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

    public enum WaveForm { sin, tri, sqr, saw, inv, noise };
    public WaveForm waveform = WaveForm.sin;

    public float delay = 0; 
    public float baseStart = 0.0f; 
    public float amplitude = 1.0f; 
    public float phase = 0.0f; 
    public float frequency = 0.5f; 

    
    private Color originalColor;
    private Light light;

    private int x = 0;
    
	void Start () {
        light = GetComponent<Light>();
        originalColor = light.color;
	}
	
	
	void FixedUpdate () {
        x += 1;

        if (x >= delay)
        {
            light.color = originalColor * (EvalWave());
            x = 0;
        }
	}

    float EvalWave()
    {
        float x = (Time.time + phase) * frequency;
        float y;
        x = x - Mathf.Floor(x); 

        if( waveform == WaveForm.sin)
        {
            y = Mathf.Sin(x * 2 * Mathf.PI);
        }
        else if (waveform == WaveForm.tri)
        {

            if ( x < 0.5f)
            {
                y = 1.0f;
            }
            else
            {
                y = -1.0f;
            }
        }
        else if (waveform == WaveForm.saw)
        {
            y = x;
        }
        else if (waveform == WaveForm.inv)
        {
            y = 1.0f - x;
        }
        else if (waveform == WaveForm.noise)
        {
            y = 1f - (Random.value * 2);
        }
        else
        {
            y = 1.0f;
        }

        return (y * amplitude) + baseStart;
    }
}