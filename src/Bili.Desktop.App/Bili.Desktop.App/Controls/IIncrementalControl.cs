﻿// Copyright (c) Richasy. All rights reserved.

using System;

namespace Bili.Desktop.App.Controls
{
    /// <summary>
    /// 支持增量加载的控件.
    /// </summary>
    public interface IIncrementalControl
    {
        /// <summary>
        /// 增量加载请求被触发.
        /// </summary>
        event EventHandler IncrementalTriggered;
    }
}
