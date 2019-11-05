using System;
using Win10ToastDemo.Models;

namespace Win10ToastDemo.Models.Factories
{
	public class ToastBuilder : IAddLineAndImage, IAddLineAndImageAndBuild, IAddLineAndBuild
	{
        #region Properties

        private Toast result;

        #endregion Properties

        #region Construction

        public ToastBuilder(Toast result)
        {
            this.result = result;
        }

        #endregion Construction

        #region Methods

        // Instantiating functions
        #region Create
        public static IAddLineAndImage Create(string Caption)
        {
            return new ToastBuilder(new Toast(Caption));
        }
        #endregion Create

        // Chaining functions
        #region AddLine
        public IAddLineAndImageAndBuild AddLine(string Line)
        {
            this.result.Lines.Add(Line);
            return this;
        }
        #endregion AddLine

        #region AddImage
        public IAddLineAndBuild AddImage(string ImageFilename)
        {
            this.result.ImageFilename = ImageFilename;
            return this;
        }
        #endregion AddImage

        #region AddExpirationTime
        public IAddLineAndImageAndBuild AddExpirationTime(DateTimeOffset ExpirationTime)
        {
            this.result.ExpirationTime = ExpirationTime;
            return this;
        }
        #endregion AddExpirationTime

        // Executing functions
        #region Build
        public Toast Build()
        {
            return this.result;
        }
        #endregion Build

        #endregion Methods
    }
}
