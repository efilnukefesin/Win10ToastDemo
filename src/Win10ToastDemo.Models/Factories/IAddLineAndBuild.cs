using System;
using Win10ToastDemo.Models;

namespace Win10ToastDemo.Models.Factories
{
	public interface IAddLineAndBuild
	{
		IAddLineAndImageAndBuild AddLine(string Line);
        IAddLineAndImageAndBuild AddExpirationTime(DateTimeOffset ExpirationTime);
        Toast Build();
	}
}
