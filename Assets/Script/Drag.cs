using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour
{
//	Vector3 dist;
//	//Vector3 startPos;
//	float posX;
//	float posZ;
//	float posY;
//
//	bool dirty;
//
//	void OnMouseDown()
//	{
//		//startPos = transform.position;
//		if(dirty) return;
//		dirty = true;
//
//		dist = Camera.main.WorldToScreenPoint(transform.position);
//		posX = Input.mousePosition.x - dist.x;
//		posY = Input.mousePosition.y - dist.y;
//		posZ = Input.mousePosition.z - dist.z;
//	}
//
//	void OnMouseDrag()
//	{
//		
//		float disX = Input.mousePosition.x - posX;
//		float disY = Input.mousePosition.y - posY;
//		float disZ = Input.mousePosition.z - posZ;
//		Vector3 lastPos = Camera.main.ScreenToWorldPoint(new Vector3(disX, dist.y, disY));
//		transform.position = new Vector3(0, 0, lastPos.z);
//		//Debug.Log ("OnMouseDrag - " + transform.position);
//	}

	public GameObject target;
	Vector3 posSoepardjo;
	Vector3 firstPosScroll;
	Vector3 touchPos;
	float progress, prevProgress;

	void OnEnable()
	{
		posSoepardjo = target.transform.localPosition;
		firstPosScroll = transform.localPosition;
	}

	void Update()
	{

	}

	void OnMouseDrag()
	{
		progress = prevProgress + Camera.main.ScreenToViewportPoint(Input.mousePosition - touchPos).y;
		transform.localPosition = Vector3.Lerp (firstPosScroll, posSoepardjo, progress);

	}

	void OnMouseUp()
	{
		prevProgress = progress;
	}

	void OnMouseDown()
	{
		touchPos = Input.mousePosition;
	}
}