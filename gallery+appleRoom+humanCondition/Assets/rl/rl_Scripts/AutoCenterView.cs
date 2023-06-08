using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Globalization;
using TMPro;

public class AutoCenterView : MonoBehaviour,IDragHandler,IEndDragHandler
{
    //��������
    public Transform _container;
    //�������
    public ScrollRect _scrollRect;
    //�������
    public LayoutGroup _layoutGroup = null;

    GameObject intro=null;

    public int _curCenterChildIndex = 0;
    public GameObject CurCenterChildItem
    {
        get
        {
            GameObject centerChild = null;
            if(_container != null&&_curCenterChildIndex>=0 && _curCenterChildIndex < _container.childCount) {
                centerChild=_container.GetChild(_curCenterChildIndex).gameObject;
            }
            return centerChild;
        }
    }
    [SerializeField]
    //�洢Ԫ��λ��
    private List<float> _childrenPos = new List<float>();
    //����Ҫ�ƶ�����Ŀ��λ��
    private float _targetPos;
    //�����ٶ�
    public float _centerSpeed = 20f;
    //�Ƿ����ھ���
    public bool _centering = true;

    //�Ƿ���������
    public bool _scaleing = true;
    //���ű���
    public Vector3 _centerChildScale = new Vector3(1.2f, 1.2f, 1.2f);

    private void Awake()
    {
        InitView();
    }

    public void InitView()
    {
        //��ȡ�������
        _scrollRect = GetComponent<ScrollRect>();
        //��ȡ����
        _container = _scrollRect.content;
        //���ƶ���ʽ����Ϊ������
        _scrollRect.movementType=ScrollRect.MovementType.Unrestricted;
        //��ȡ�������
        _layoutGroup = _container.GetComponent<LayoutGroup>();
       
       
        if (_layoutGroup is GridLayoutGroup)
        {
            GridLayoutGroup grid;
            grid = _container.GetComponent<GridLayoutGroup>();
            float childPosX = _scrollRect.GetComponent<RectTransform>().rect.width * 0.5f - grid.cellSize.x * 0.5f;
            _childrenPos.Add(childPosX);
            //�洢����������λ�����ĵ�λ��
            for(int i=0;i<_container.childCount-1;i++) {
                childPosX-=grid.cellSize.x+grid.spacing.x;
                _childrenPos.Add(childPosX);
            }
            //����ǰ������
            _targetPos = FindClosestPos(_container.localPosition.x);
        }

        
    }

    private void Update()
    {
        if (_centering)
        {
            if (_layoutGroup is GridLayoutGroup)
            {
                Vector3 v = _container.localPosition;
                v.x = Mathf.Lerp(_container.localPosition.x, _targetPos, _centerSpeed * Time.deltaTime);
                _container.localPosition = v;
            }
        }
        //��������
        if(_scaleing)
        {
            //��ֵ����
            for(int i=0 ; i<_container.childCount; i++)
            {
                if (i == _curCenterChildIndex)
                {
                     _container.GetChild(i).transform.localScale =
                        new Vector3(Mathf.Lerp(CurCenterChildItem.transform.localScale.x, _centerChildScale.x, _centerSpeed * Time.deltaTime),
                            Mathf.Lerp(CurCenterChildItem.transform.localScale.y, _centerChildScale.y, _centerSpeed * Time.deltaTime),
                            Mathf.Lerp(CurCenterChildItem.transform.localScale.z, _centerChildScale.z, _centerSpeed * Time.deltaTime)
                            );
                    Transform trans = this.transform.Find("StyleChoser"+i);
                    intro = trans.gameObject;
                    intro.GetComponent<TextMeshProUGUI>().alpha = 255;
                }
                else
                {
                    Transform trans = this.transform.Find("StyleChoser" + i);
                    intro = trans.gameObject;
                    intro.GetComponent<TextMeshProUGUI>().alpha = 0.0f;

                    _container.GetChild(i).transform.localScale =
                        new Vector3(Mathf.Lerp(_container.GetChild(i).transform.localScale.x, 1f, _centerSpeed * Time.deltaTime),
                        Mathf.Lerp(_container.GetChild(i).transform.localScale.y, 1f, _centerSpeed * Time.deltaTime),
                        Mathf.Lerp(_container.GetChild(i).transform.localScale.z, 1f, _centerSpeed * Time.deltaTime)
                        );
                }
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        _centering = false;
        if (_layoutGroup is GridLayoutGroup)
        {
            _targetPos = FindClosestPos(_container.localPosition.x);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (_layoutGroup is GridLayoutGroup)
        {
            _targetPos = FindClosestPos(_container.localPosition.x);
        }
        _centering = true;
    }

    private float FindClosestPos(float currentPos)
    {
        int LastCenterIndex = _curCenterChildIndex;
        int childIndex = 0;
        float closest = 0;
        _curCenterChildIndex = -1;
        float distance = Mathf.Infinity;

        //���������������λ��
        for(int i=0;i<_childrenPos.Count;i++)
        {
            float p = _childrenPos[i];
            float d = Mathf.Abs(p - currentPos);
            if(d < distance)
            {
                distance = d;
                closest = p;
                childIndex = i;
            }
        }
        //���õ�ǰ����Ԫ������
        _curCenterChildIndex = childIndex;
        return closest;
    }

    public void SetCenterChild(int _index)
    {
        _curCenterChildIndex = _index;
        _targetPos = _childrenPos[_index];
    }

}