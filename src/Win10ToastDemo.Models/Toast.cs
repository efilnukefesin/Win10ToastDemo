using NET.efilnukefesin.Implementations.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Win10ToastDemo.Models
{
    /// <summary>
    /// a class for symolizing the toast message and data
    /// </summary>
    public class Toast : BaseObject
    {
        #region Properties

        public string Caption { get; set; }
        public List<string> Lines { get; set; }
        public string ImageFilename { get; set; }
        public DateTimeOffset? ExpirationTime { get; set; }

        #endregion Properties

        #region Construction

        public Toast(string caption)
        {
            this.Caption = caption;
            this.Lines = new List<string>();
        }

        #endregion Construction

        #region Methods

        #region dispose
        protected override void dispose()
        {
            
        }
        #endregion dispose

        #endregion Methods
    }
}
