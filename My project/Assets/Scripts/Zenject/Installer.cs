using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    [SerializeField] private TextInstaller textInstaller;

    public override void InstallBindings()
    {
        BindTextInstaller();
    }

    private void BindTextInstaller()
    {
        Container.Bind<TextInstaller>().FromInstance(textInstaller).AsSingle();
    }
}
