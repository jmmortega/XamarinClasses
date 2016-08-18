using XamarinClasses.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.MVVM.Services.Interfaces
{
    public interface IDrinkService
    {
        List<Drink> CreateDrinks();
    }
}
