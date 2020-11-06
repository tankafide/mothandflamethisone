using MEC;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private const float TIME_TO_EACH_POINT = 1f;

    void Start()
    {
        string jsonData = loadResourceTextfile();
        MoveDatas dummyMoveData = new MoveDatas();
        dummyMoveData.GenTestData();
        Timing.RunCoroutine(_updatePosition(dummyMoveData).CancelWith(gameObject));
    }

    private IEnumerator<float> _updatePosition(MoveDatas moveDatas)
    {
        List<MoveData> moveData = moveDatas.GetMoveDatas();
        transform.position = new Vector3(moveData[0].GetLatitiude(), 
            moveData[0].GetAltitude(), moveData[0].GetLongitude());

        int currentTargetIndex = 1;
        while (currentTargetIndex < moveData.Count)
        {
            float timeElapsed = 0;
            Vector3 startPos = transform.position;
            Vector3 targetPos = new Vector3(moveData[currentTargetIndex].GetLatitiude(),
            moveData[currentTargetIndex].GetAltitude(), moveData[currentTargetIndex].GetLongitude());

            while (timeElapsed < TIME_TO_EACH_POINT)
            {
                timeElapsed += Time.deltaTime;
                transform.position = Vector3.Lerp(startPos, targetPos, timeElapsed / TIME_TO_EACH_POINT);
                yield return Timing.WaitForOneFrame;
            }
            currentTargetIndex++;
        }
    }

    private string loadResourceTextfile()
    {
        TextAsset targetFile = Resources.Load<TextAsset>("flightData");

        return targetFile.text;
    }
}
