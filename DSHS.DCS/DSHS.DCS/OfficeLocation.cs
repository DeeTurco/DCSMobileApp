using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace DSHS.DCS
{
   public class OfficeLocation : ViewCell
   {
	  Grid grid = new Grid
	  {
		 Padding = new Thickness(5, 10, 0, 0),
		 ColumnDefinitions =
        {
            new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star) },
            new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
            new ColumnDefinition
            { Width = new GridLength(25, 
                    GridUnitType.Absolute)
            }, 
            new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
            new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star)  },
        },

	  };


   }
}
