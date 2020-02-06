using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPillars : MonoBehaviour
{
    public GameObject pillar;
    public GameObject between;

    private const float pillarYPositionFromBotton = -100f;
    private const float pillarWidth = 15f;
    private const float pillarsMovingSpeed = 20f;
    private const float screenHeight = 200f;
    private const float deletePositionX = -110f;
    private const float lowerPillarHeight = 75f;

    private PillarContainer pillarContainer;

    private void Start()
    {
        StartCoroutine(SpawnWalls());
    }

    IEnumerator SpawnWalls()
    {
        float gap;
        float mutation;
        int isUpperOrLowerMutation;
        float time = 1f;
        while (true)
        {
            gap = Random.Range(30f, 45f);
            mutation = Random.Range(0f, 45f);
            isUpperOrLowerMutation = Random.Range(0, 2);
            yield return new WaitForSeconds(time);
            time = 3f;
            createPillarPairsByGaps(100, gap,mutation, isUpperOrLowerMutation, lowerPillarHeight);
        }

    }
    void Awake()
    {
        pillarContainer = new PillarContainer();
    }

    private void FixedUpdate()
    {
        pillarContainer.movePillars();
        pillarContainer.emptyTrashcan();
    }

    

    void createPillarPairsByGaps(float xPosition,float gap,float mutation, int isUpperOrLowerMutation,float lowerPillarHeight)
    {
        int lower;
        if (isUpperOrLowerMutation == 0)
        {
            lower = -1;
        }
        else
        {
            lower = 1;
        }

        GameObject pillar1 = Instantiate(pillar);
        //lower
        Transform pillarPosition1 = pillar1.GetComponent<Transform>();
        pillarPosition1.position = new Vector3(xPosition, pillarYPositionFromBotton + (lowerPillarHeight + (lower*mutation))/2, 0);
        pillarPosition1.localScale = new Vector3(pillarWidth, lowerPillarHeight + ((lower * mutation)), 1);
        pillarContainer.addPillar(pillar1);

        GameObject pillar2 = Instantiate(pillar);
        //upper
        Transform pillarPosition2 = pillar2.GetComponent<Transform>();
        pillarPosition2.position = new Vector3(xPosition, -pillarYPositionFromBotton - (screenHeight - gap - (lowerPillarHeight + (lower * mutation)))/2 , 0);
        pillarPosition2.localScale = new Vector3(pillarWidth, (screenHeight - gap - (lowerPillarHeight + (lower * mutation))), 1);
        pillarContainer.addPillar(pillar2);

        GameObject betweenLine = Instantiate(between);
        //line between pillars for score update when crossed
        Transform betweenPosition = betweenLine.GetComponent<Transform>();
        betweenPosition.position = new Vector3(xPosition + pillarWidth, pillarYPositionFromBotton + pillarPosition1.localScale.y + gap/2,0);
        betweenPosition.localScale = new Vector3(pillarWidth,gap,1);
        pillarContainer.addPillar(betweenLine);



    }

    public class PillarContainer
    {
        private List<GameObject> pillarList;
        private List<GameObject> trashcan;

        public PillarContainer()
        {
            pillarList = new List<GameObject>();
            trashcan = new List<GameObject>();
        }
        public void addPillar(GameObject pillar)
        {
            pillarList.Add(pillar);
        }

        public void movePillars()
        {
            for (int i = 0; i < pillarList.Count; i++)
            {
                Transform transform = pillarList[i].GetComponent<Transform>();
                transform.position += new Vector3(-1f, 0, 0) * pillarsMovingSpeed *Time.deltaTime;
                if(transform.position.x < deletePositionX)
                {
                    DestroyPillar(pillarList[i]);
                }
            }

        }

        public void DestroyPillar(GameObject pillar)
        {
            pillarList.Remove(pillar);
            trashcan.Add(pillar);
        }

        public void emptyTrashcan()
        {
            for(int i = 0; i < trashcan.Count; i++)
            {
                Destroy(trashcan[i]);
                trashcan.Remove(trashcan[i]);

            }
        }

    }
}
