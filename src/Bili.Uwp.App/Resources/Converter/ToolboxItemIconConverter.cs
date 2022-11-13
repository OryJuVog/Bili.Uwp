﻿// Copyright (c) Richasy. All rights reserved.

using System;
using Bili.Models.Enums;
using Richasy.FluentIcon.Uwp;
using Windows.UI.Xaml.Data;

namespace Bili.Uwp.App.Resources.Converter
{
    internal class ToolboxItemIconConverter : IValueConverter
    {
        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var symbol = RegularFluentSymbol.ErrorCircle24;
            if (value is ToolboxItemType type)
            {
                switch (type)
                {
                    case ToolboxItemType.AvBvConverter:
                        symbol = RegularFluentSymbol.TextClearFormatting24;
                        break;
                    case ToolboxItemType.CoverDownloader:
                        symbol = RegularFluentSymbol.ImageSearch24;
                        break;
                    default:
                        break;
                }
            }

            return symbol;
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => throw new NotImplementedException();
    }
}
