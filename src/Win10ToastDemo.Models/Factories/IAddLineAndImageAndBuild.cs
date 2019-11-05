using System;
using Win10ToastDemo.Models;

namespace Win10ToastDemo.Models.Factories
{
	public interface IAddLineAndImageAndBuild
	{
		IAddLineAndImageAndBuild AddLine(string Line);
		IAddLineAndBuild AddImage(string ImageFilename);

        Toast Build();
	}
}
