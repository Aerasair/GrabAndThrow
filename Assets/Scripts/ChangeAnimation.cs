using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ChangeAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Moving(float axis)
    {
        _animator.SetFloat("Speed", Mathf.Abs(axis));
    }


}
