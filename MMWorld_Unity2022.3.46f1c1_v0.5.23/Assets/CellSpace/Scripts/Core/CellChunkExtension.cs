using UnityEngine;

namespace CellSpace
{
    /// <summary>
    /// �ſ���չ������ſ��������Ⱦ��Ϊ��ʱ�����ſ���Ϸ������Ϊ26�㣨����ײ�㣩��
    /// </summary>
    public class CellChunkExtension : MonoBehaviour
    {
        void Awake()
        {
            //�ſ��������Ⱦ��Ϊ��ʱ
            if (GetComponent<MeshRenderer>() == null)
            {
                //���ſ���Ϸ������Ϊ26�㣨����ײ�㣩
                gameObject.layer = 26;

            }
        }
    }
}