using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TonNgoKhong.Scripts.ButtonGroup;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TabButton : AButton
{
    [SerializeField] private Button _button;

    [FoldoutGroup("Config")] [SerializeField]
    private TabContainer _manager;

    [FoldoutGroup("Config")] [SerializeField]
    private ScreenTab _tab;

    [FoldoutGroup("Config")] [SerializeField]
    private bool _isLock;

    [FoldoutGroup("Anim")] [SerializeField]
    private GameObject _lock;

    [FoldoutGroup("Anim")] [SerializeField]
    private Image _bgImg;

    [FoldoutGroup("Anim")] [SerializeField]
    private Sprite _on, _off;

    [FoldoutGroup("Anim")] [SerializeField]
    private RectTransform _rectTransform;

    [FoldoutGroup("Anim")] [SerializeField]
    private GameObject _iconVector;

    [FoldoutGroup("Anim")] [SerializeField]
    private GameObject _name;

    [FoldoutGroup("Anim")] [SerializeField]
    private Animator _animator;

    public bool IsLock => _isLock;

    private void OnValidate()
    {
        _button = GetComponent<Button>();

        if (_animator == null)
        {
            _animator = GetComponentInChildren<Animator>(true);
        }

        if (_rectTransform == null)
        {
            _rectTransform = GetComponentInChildren<RectTransform>(true);
        }

        _manager = GetComponentInParent<TabContainer>();
    }

    private void Start()
    {
        _button.onClick.AddListener(OpenScreen);
    }

    private void OpenScreen()
    {
        if (_isLock)
            return;

        _manager.OpenScreen(_tab);
    }

    public override void SetListener(UnityAction action)
    {
        _button.onClick.AddListener(action);
    }

    public override void OnChoose()
    {
        if (_isLock)
        {
            //_lock?.SetActive(true);
          //  _iconVector?.SetActive(false);
           // _name?.SetActive(false);
            return;
        }

        _bgImg.sprite = _on;
        //_rectTransform.sizeDelta = new Vector2(400, 220);

        if (_lock != null)
            _lock.SetActive(false);
       // _name?.SetActive(true);
       // _iconVector?.SetActive(true);
       // _animator?.Play("VectorBattleBack");
    }

    public override void OnUnChoose()
    {
        if (_isLock)
        {
           // _lock?.SetActive(true);
           // _iconVector?.SetActive(false);
           // _name?.SetActive(false);
            return;
        }

        //_bgImg.sprite = _off;
       // _rectTransform.sizeDelta = new Vector2(170, 170);

        if (_lock != null)
            _lock.SetActive(false);

       // _name?.SetActive(false);
       // _iconVector?.SetActive(true);
       // _animator?.Play("VectorBattle");
    }
}