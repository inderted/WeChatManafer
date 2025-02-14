﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace WxManager
{
    /// <summary>
    /// Represents base search model
    /// </summary>
    public abstract partial class BaseSearchModel : EntityDto<int>
    {
        #region Ctor

        public BaseSearchModel()
        {
            //set the default values
            this.Page = 1;
            this.PageSize = 10;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets a page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets a comma-separated list of available page sizes
        /// </summary>
        public string AvailablePageSizes { get; set; }

        #endregion
    }
}
