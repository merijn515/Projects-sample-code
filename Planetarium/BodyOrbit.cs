using UnityEngine;

public class BodyOrbit : MonoBehaviour
{
    [SerializeField]
    private float yearInEarthDays;
    private float degreesPerDay;

    [SerializeField]
    private GameObject orbitingBody;
    [SerializeField]
    private float orbitDis;
    [SerializeField]
    private CelestialBody typeOfBody;

    private enum CelestialBody
    {
        planet, 
        moon
    }

    void Start()
    {// calculate number of degrees per day
        degreesPerDay = 360 / yearInEarthDays;
    }

    void Update()
    {// rotate/move the body by the amount of degrees per the time speed
        transform.Rotate(0, -degreesPerDay * UniversalValues.Values.timeStep * Time.deltaTime, 0);

        if (orbitingBody != null)
        {// move the bodies at the distance at which they are orbiting
            if (typeOfBody == CelestialBody.planet)
            {
                orbitingBody.transform.position = transform.position + transform.right * orbitDis;
            } else if (typeOfBody == CelestialBody.moon)
            {
                orbitingBody.transform.position = transform.position + -transform.forward * orbitDis;
            }
        }
    }
}
