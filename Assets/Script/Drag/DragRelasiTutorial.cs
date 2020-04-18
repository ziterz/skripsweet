using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragRelasiTutorial : MonoBehaviour, IDragHandler, IEndDragHandler 
{

    public GameObject item1, item2, item3, item4,item5,dragObject, target1, target2;
    Vector3 startpos, startpos1, startpos2,startpos3,startpos4,startpos5;

    // Start is called before the first frame update
    void Start()
    {
        startpos = dragObject.transform.position;
        startpos1 = item1.transform.position;
		startpos2 = item2.transform.position;
		startpos3 = item3.transform.position;
        startpos4 = item4.transform.position;
        startpos5 = item5.transform.position;
    }

    public void OnDrag(PointerEventData eventData)
	{
   		Vector3 newpos = Input.mousePosition - new Vector3 (Screen.width / 2f, Screen.height / 2f, 0f);
	    dragObject.transform.localPosition = newpos;
    }

    public void OnEndDrag(PointerEventData eventData)
	{
        float Dis1 = Vector3.Distance(dragObject.transform.position, target1.transform.position);
        float Dis2 = Vector3.Distance(dragObject.transform.position, target2.transform.position);

		if(Dis1<2)
        {
            if (item1.transform.position == target1.transform.position) {
                item1Back();
            } 
            else if (item2.transform.position == target1.transform.position) {
                item2Back();
            }
            else if (item3.transform.position == target1.transform.position) {
                item3Back();
            }
            else if (item4.transform.position == target1.transform.position) {
                item4Back();
            }
            else if (item5.transform.position == target1.transform.position) {
                item5Back();
            }
            dragObject.transform.position = target1.transform.position;
        }
        else if(Dis2<2)
        {
            if (item1.transform.position == target2.transform.position) {
                item1Back();
            } 
            else if (item2.transform.position == target2.transform.position) {
                item2Back();
            }
            else if (item3.transform.position == target2.transform.position) {
                item3Back();
            }
            else if (item4.transform.position == target2.transform.position) {
                item4Back();
            }
            else if (item5.transform.position == target2.transform.position) {
                item5Back();
            }
            dragObject.transform.position = target2.transform.position;
        }
        else 
        {
            dragObject.transform.position = startpos;
        }
    }

    void item1Back()
	{
		item1.transform.position = startpos1;
	}

	void item2Back()
	{
		item2.transform.position = startpos2;
	}

	void item3Back()
	{
		item3.transform.position = startpos3;
	}
    void item4Back()
	{
		item4.transform.position = startpos4;
	}
    void item5Back()
	{
		item5.transform.position = startpos5;
	}


}
