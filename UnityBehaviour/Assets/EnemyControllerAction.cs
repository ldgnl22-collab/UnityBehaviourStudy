using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "EnemyController", story: "Input down key on [damage]", category: "EnemyController", id: "3cead8da871fc642e677f6c2894c692e")]
public partial class EnemyControllerAction : Action
{
    [SerializeReference] public BlackboardVariable<int> Damage;
    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        return Status.Success;
    }

    protected override void OnEnd()
    {
    }
}

