﻿using ETModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BuffTargetType
{
    自身,
    范围内我方角色,
    范围内敌方角色,
    敌方单体,
}

public enum RestrictionType
{
    击退,
    眩晕,
}

/// <summary>
/// 如果这个BUFF是叠加的,当有相同类型,比如同种DOT,同种效果的BUFF,那么重复施放的效果就是叠加BUFF层数
/// 刷新就是刷新时间
/// 独立就是该BUFF和其他BUFF是分开的
/// </summary>
public enum BuffStackType
{
    叠加,
    刷新,
    独立
}

[Serializable]
public abstract class BaseBuffData 
{
    public abstract string GetBuffIdType();

}

[Serializable]
public abstract class BaseBuffHasTarget : BaseBuffData
{

}

