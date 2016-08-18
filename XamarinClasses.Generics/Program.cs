using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClasses.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            WhichTypeIs<string>("Hello world");
            WhichTypeIs<int>(5);
            WhichTypeIs<double>(5.5);


            //---------------------------------------------------------------------------------//

            Concatter<int> concatter = new Concatter<int>();

            concatter.Add(5);
            concatter.Add(10);
            concatter.Add(3);

            concatter.Print();

            //---------------------------------------------------------------------------------//

            VHS ghostBusters = new VHS() { Duration = TimeSpan.FromMinutes(87) };
            DVD phantomMenace = new DVD() { Duration = TimeSpan.FromMinutes(104) };

            PlayingMedia(ghostBusters);
            PlayingMedia(phantomMenace);

            //We don't playing a integer. :(
            //PlayingMedia(5);

            Console.ReadKey();
        }

        static void WhichTypeIs<T>(T element)
        {                           
            if(element.GetType() == typeof(string))
            {
                Console.WriteLine("Generic is a string and value {0}" , element);
            }
            else if(element.GetType() == typeof(int))
            {
                Console.WriteLine("Generic is a integer and value {0}" , element);
            }
            else if(element.GetType() == typeof(double))
            {
                Console.WriteLine("Generic is a double and value {0}" , element);
            }
            else
            {
                Console.WriteLine("I don't know what type is");
            }
        }

        static void PlayingMedia<T>(T mediaElement) where T : IMedia , new()
        {            
            mediaElement.Play();            
        }

        static void WhichTypeIs<T,W>(T element , T element1)
        {

        }
    }
}
