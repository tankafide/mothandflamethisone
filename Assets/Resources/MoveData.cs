using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveData
{
    
    private float timestamp;
    private float longitude;
    private float latitiude;
    private float altitude;

    public MoveData(float longitude, float latitiude, float altitude)
    {
        this.longitude = longitude;
        this.latitiude = latitiude;
        this.altitude = altitude;
    }

    public float GetLongitude()
    {
        return longitude;
    }

    public float GetLatitiude()
    {
        return latitiude;
    }

    public float GetAltitude()
    {
        return altitude;
    }


}


