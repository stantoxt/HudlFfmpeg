﻿using Hudl.Ffmpeg.BaseTypes;
using Hudl.Ffmpeg.Common;
using Hudl.Ffmpeg.Resources.BaseTypes;
using Hudl.Ffmpeg.Settings.BaseTypes;

namespace Hudl.Ffmpeg.Settings
{
    /// <summary>
    /// Useful if on the fly scaling is needed for demux concatenation. there are no 
    /// specific settings for this and FFmpeg states that it is good practice to include 
    /// as some files need this setting.
    /// </summary>
    [AppliesToResource(Type = typeof(IVideo))]
    [AppliesToResource(Type = typeof(IAudio))]
    [AppliesToResource(Type = typeof(IImage))]
    [SettingsApplication(PreDeclaration = true, ResourceType = SettingsCollectionResourceType.Input)]
    public class AutoConvert : BaseSetting
    {
        private const string SettingType = "-auto_convert";

        public AutoConvert()
            : base(SettingType)
        {
        }

        public override string ToString()
        {
            return string.Concat(Type, " 1");
        }
    }
}