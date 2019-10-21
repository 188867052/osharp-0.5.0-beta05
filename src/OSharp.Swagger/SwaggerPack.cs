﻿// -----------------------------------------------------------------------
//  <copyright file="SwaggerPack.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2019-04-15 16:35</last-date>
// -----------------------------------------------------------------------

using System.ComponentModel;

using OSharp.AspNetCore;
using OSharp.Core.Packs;


namespace OSharp.Swagger
{
    /// <summary>
    /// SwaggerApi模块
    /// </summary>
    [DependsOnPacks(typeof(AspNetCorePack))]
    [Description("SwaggerApi模块 ")]
    public class SwaggerPack : SwaggerPackBase
    { }
}