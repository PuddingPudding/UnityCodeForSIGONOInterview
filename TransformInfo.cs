using UnityEngine;

public class TransformInfo //並非實際的Transform，只負責用來記錄Transform的基本資訊
{
    private Vector3 m_position;
    private Quaternion m_rotation;
    private Vector3 m_scale;

    public TransformInfo()
    {
        m_position = Vector3.zero;
        m_rotation = Quaternion.identity; //Quaternion.identity代表著0,0,0，完全沒有旋轉角度
        m_scale = new Vector3(1f, 1f, 1f);
    }
    public TransformInfo(Transform _copyTarget)
    {
        m_position = _copyTarget.position;
        m_rotation = _copyTarget.rotation;
        m_scale = _copyTarget.localScale;
    }
    public TransformInfo(Vector3 _pos):base()
    {
        m_position = _pos;
    }
    public TransformInfo(float _posX , float _posY , float _posZ):base()
    {
        m_position = new Vector3(_posX, _posY, _posZ);
    }

    public void SetInfo(Transform _input)
    {
        m_position = _input.position;
        m_rotation = _input.rotation;
        m_scale = _input.localScale;
    }
    public void SetInfo(TransformInfo _input)
    {
        m_position = _input.m_position;
        m_rotation = _input.m_rotation;
        m_scale = _input.m_scale;
    }

    public void CopyTo(Transform _target)
    {
        _target.position = m_position;
        _target.rotation = m_rotation;
        _target.localScale = m_scale;
    }

    public Vector3 GetPos()
    {
        return m_position;
    }
    public Quaternion GetRotation()
    {
        return m_rotation;
    }
    public Vector3 GetEulerAngles()
    {
        return m_rotation.eulerAngles;
    }
    public Vector3 GetScale()
    {
        return m_scale;
    }
    
    public static void SetTransform(TransformInfo _reference , Transform _target)
    {
        _target.position = _reference.m_position;
        _target.rotation = _reference.m_rotation;
        _target.localScale = _reference.m_scale;
    }
}