using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrykerBugRepro.ViewModels;

public class MainViewModel
{
	public bool DoSomething()
	{
		if (DateTime.UtcNow.Second % 2 == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
