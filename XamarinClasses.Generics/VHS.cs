using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.Generics
{
    public class VHS : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Playing VHS with duration {0}", Duration);
        }

        public TimeSpan Duration { get; set; }        
    }
}
