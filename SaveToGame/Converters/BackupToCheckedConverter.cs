﻿using System;
using System.Globalization;
using ApkModifer.Logic;
using MVVM_Tools.Code.Classes;

namespace SaveToGameWpf.Converters
{
    public class BackupToCheckedConverter : ConverterBase<BackupType, BackupType, bool>
    {
        public override bool ConvertInternal(BackupType value, BackupType parameter, CultureInfo culture)
        {
            return value == parameter;
        }

        public override BackupType ConvertBackInternal(bool value, BackupType parameter, CultureInfo culture)
        {
            if (!value)
                throw new ArgumentException("Can't process false parameter", nameof(value));

            return parameter;
        }
    }
}