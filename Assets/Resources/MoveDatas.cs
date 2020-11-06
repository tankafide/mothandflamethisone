using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDatas
{
    private List<MoveData> moveDatas;

    public List<MoveData> GetMoveDatas()
    {
        return moveDatas;
    }

    public void GenTestData()
    {
        this.moveDatas = new List<MoveData>()
        {
            new MoveData(1,0,1),
            new MoveData(2,1,2),
            new MoveData(3,4,3),
            new MoveData(4,5,4),
            new MoveData(5,6,5)
        };
    }
}
