using System;

namespace Win10ToastDemo.Models.Factories
{
	public interface IAddLineAndImage
	{
		IAddLineAndImageAndBuild AddLine(string Line);
		IAddLineAndBuild AddImage(string ImageFilename);
        IAddLineAndImageAndBuild AddExpirationTime(DateTimeOffset ExpirationTime);
    }
}
