using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager
{
    public PlayerController Player { get; private set; }
    public HashSet<MonsterController> Monsters = new HashSet<MonsterController>();

    public T Spawn<T>(Vector3 position, int templateID = 0, string prefabName = "") where T : BaseController
    {
        System.Type type = typeof(T);

        if (type == typeof(PlayerController))
        { 
            GameObject go = Managers.Resource.Instantiate("mainPlayer");
            PlayerController pc = go.GetOrAddComponent<PlayerController>();
            Player = pc;
            Managers.Game.Player = pc;

            return pc as T;
        }

        else if(type == typeof(MonsterController))
        {
            GameObject go = Managers.Resource.Instantiate("Monster");
            MonsterController mc = go.GetOrAddComponent<MonsterController>();

            Monsters.Add(mc);

            return mc as T;
        }

        return null;

    }
}
