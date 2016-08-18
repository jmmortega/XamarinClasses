using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.Generics
{
    public interface IMedia
    {
        void Play();
        TimeSpan Duration { get; set; }
    }
}
