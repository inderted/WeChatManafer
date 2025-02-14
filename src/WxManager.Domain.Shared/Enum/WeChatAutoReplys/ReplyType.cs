﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WxManager.WeChatManager.WeChatAutoReplys
{
    /// <summary>
    /// 回复类型
    /// </summary>
    public enum ReplyType
    {
        /// <summary>
        /// 文本
        /// </summary>
        [Description("文本")]
        Text = 0,

        /// <summary>
        /// 图文消息
        /// </summary>
        [Description("图文消息")]
        News = 1,

        /// <summary>
        /// 图片
        /// </summary>
        [Description("图片")]
        Image = 2,

        /// <summary>
        /// 音频
        /// </summary>
        [Description("音频")]
        Voice = 3,

        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 4
    }
}
