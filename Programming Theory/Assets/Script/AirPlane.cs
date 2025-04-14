using UnityEngine;

public class AirPlane : Aircraft
{
    

    public AirPlane(string model, float acceleration, float maxSpeed, float currentSpeed) : base(model, acceleration, maxSpeed, currentSpeed)
    {
        this.model = model;
        this.acceleration = acceleration;
        this.maxSpeed = maxSpeed;
        this.currentSpeed = 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Correctly set the model property of the Aircraft class
        model = "Boeing 747";
        maxSpeed = 900f; // Example max speed in km/h
        acceleration = 5f; // Example acceleration in km/h per second
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.PageUp))
        {
            currentSpeed = Accelerate(acceleration);
        }
        if (Input.GetKey(KeyCode.PageDown))
        {
            currentSpeed = Decelerate(acceleration);
        }

        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);

        TakeDirection();

        transform.Rotate(direction * Time.deltaTime * 20);
    }


  
}
