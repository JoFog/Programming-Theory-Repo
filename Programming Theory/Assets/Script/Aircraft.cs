using UnityEngine;

public class Aircraft : MonoBehaviour
{
    public string model;
    public float currentSpeed;
    public float maxSpeed;
    protected float acceleration;
    public Vector3 direction;
    private float v;

    public Aircraft(string model, float aceleration, float maxSpeed, float currentSpeed)
    {
        currentSpeed = 0;
    }

    public Aircraft(float v)
    {
        this.v = v;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float Accelerate(float acceleration)
    {
        currentSpeed += acceleration;
        if (currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }

        return currentSpeed;




    }
    public float Decelerate(float acceleration)
    {
        currentSpeed -= acceleration;
        if (currentSpeed < 0)
        {
            currentSpeed = 0;
        }

        return currentSpeed;


    }

    public Vector3 TakeDirection()
    {
        direction = new (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        return direction;
    }
}
